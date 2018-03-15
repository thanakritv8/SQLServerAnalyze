Imports BLL
Imports System.Data.SqlClient

Public Class frmLoad
    Dim conn As SqlConnection
    Dim strQuery As String
    Dim strCmd As String
    Dim _t As Threading.Thread
    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click
        If btStart.Text = "Start" Then
            _t = New Threading.Thread(AddressOf Run)
            _t.IsBackground = True
            _t.Start()
            btStart.Text = "Stop"
            btStart.BackColor = Color.Crimson
        Else
            If _t.IsAlive Then
                _t.Abort()
            End If
            btStart.Text = "Start"
            btStart.BackColor = Color.Green
        End If
    End Sub

    Delegate Sub DelUpDgv(ByVal Dt As DataTable, ByVal _dgv As DataGridView)
    Public Sub UpDgv(ByVal Dt As DataTable, ByVal _dgv As DataGridView)
        If InvokeRequired Then
            Invoke(New DelUpDgv(AddressOf UpDgv), Dt, _dgv)
        Else
            _dgv.DataSource = Dt
        End If
    End Sub

    Delegate Sub DelUpText(ByVal strTxt As String)
    Public Sub UpText(ByVal strTxt As String)
        If InvokeRequired Then
            Invoke(New DelUpText(AddressOf UpText), strTxt)
        Else
            btStart.Text = strTxt
            If strTxt = "Start" Then
                btStart.BackColor = Color.Green
            Else
                btStart.BackColor = Color.Crimson
            End If
        End If
    End Sub

    Public Sub Run()
        While _t.IsAlive
            Dim _SQL As String = "SELECT hostname, Command, program_name, Text FROM sys.dm_exec_requests as r, master.dbo.sysprocesses as p CROSS APPLY sys.dm_exec_sql_text(p.sql_handle) t WHERE r.session_id = p.spid"
            Dim Dt As DataTable = objDB.SelectSQL(_SQL, conn)
            If Dt.Rows.Count > 0 Then
                Dim items = (From p In Dt.AsEnumerable() _
                             Select New With {.Text = p.Field(Of String)("Text"), .Command = p.Field(Of String)("Command")}).ToList()
                Dim filtered = items.Where(Function(x) x.Text.Contains(strCmd) And x.Command = strQuery).ToList()
                UpDgv(Dt, dgv)
                If filtered.Count > 0 Then
                    If Not String.IsNullOrEmpty(strQuery) And Not String.IsNullOrEmpty(strCmd) Then
                        UpText("Start")
                        _t.Abort()
                        Threading.Thread.Sleep(1000)
                    End If
                End If
            End If
            _SQL = "SELECT COUNT(program_name) as NumberOfConnections , program_name , hostname FROM sys.sysprocesses WHERE dbid > 0 GROUP BY program_name, hostname ORDER BY NumberOfConnections DESC"
            UpDgv(objDB.SelectSQL(_SQL, conn), dgvCountConnection)
            Threading.Thread.Sleep(100)
        End While
    End Sub

    Private Sub cbQuery_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbQuery.SelectedIndexChanged
        strQuery = cbQuery.Text
    End Sub

    Private Sub tbCmd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCmd.TextChanged
        strCmd = tbCmd.Text
    End Sub

    Private Sub frmLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btStart.Enabled = False

        strQuery = String.Empty
        strCmd = String.Empty
    End Sub

    Private Sub frmLoad_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        _t.Abort()
    End Sub

    Private Sub btConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConnect.Click
        If btConnect.Text = "Connect" Then
            If Not String.IsNullOrEmpty(tbIp.Text) And Not String.IsNullOrEmpty(tbUser.Text) And Not String.IsNullOrEmpty(tbPass.Text) Then
                conn = objDB.ConnectDB(tbIp.Text, tbUser.Text, tbPass.Text)
                If conn.State = ConnectionState.Closed Then
                    Try
                        conn.Open()
                        btStart.Enabled = True
                    Catch ex As Exception
                        btStart.Enabled = False
                        tbIp.Enabled = True
                        tbUser.Enabled = True
                        tbPass.Enabled = True
                    End Try
                Else
                    btStart.Enabled = True
                End If
            End If
            If btStart.Enabled Then
                btConnect.Text = "Disconnect"
                btConnect.BackColor = Color.Crimson
                tbIp.Enabled = False
                tbUser.Enabled = False
                tbPass.Enabled = False
            End If
        Else
            conn.Close()
            btConnect.Text = "Connect"
            btConnect.BackColor = Color.Green
            btStart.Enabled = False
            btStart.Text = "Start"
            btStart.BackColor = Color.Green
            tbIp.Enabled = True
            tbUser.Enabled = True
            tbPass.Enabled = True

            If Not _t Is Nothing Then
                If _t.IsAlive Then
                    _t.Abort()
                End If
            End If
        End If

    End Sub
End Class
