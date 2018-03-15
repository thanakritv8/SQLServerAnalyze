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
        Else
            If _t.IsAlive Then
                _t.Abort()
            End If
            btStart.Text = "Start"
        End If
    End Sub

    Delegate Sub DelUpDgv(ByVal Dt As DataTable)
    Public Sub UpDgv(ByVal Dt As DataTable)
        If InvokeRequired Then
            Invoke(New DelUpDgv(AddressOf UpDgv), Dt)
        Else
            dgv.DataSource = Dt
        End If
    End Sub

    Delegate Sub DelUpText(ByVal strTxt As String)
    Public Sub UpText(ByVal strTxt As String)
        If InvokeRequired Then
            Invoke(New DelUpText(AddressOf UpText), strTxt)
        Else
            btStart.Text = strTxt
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
                UpDgv(Dt)
                If filtered.Count > 0 Then
                    If Not String.IsNullOrEmpty(strQuery) And Not String.IsNullOrEmpty(strCmd) Then
                        UpText("Start")
                        _t.Abort()
                        Threading.Thread.Sleep(1000)
                    End If
                End If
            End If
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
        conn = objDB.ConnectDB("10.40.1.10", "sa", "sa")
        strQuery = String.Empty
        strCmd = String.Empty
    End Sub
End Class
