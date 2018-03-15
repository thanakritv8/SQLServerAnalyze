<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btStart = New System.Windows.Forms.Button()
        Me.tbCmd = New System.Windows.Forms.TextBox()
        Me.cbQuery = New System.Windows.Forms.ComboBox()
        Me.dgvCountConnection = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbIp = New System.Windows.Forms.TextBox()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.btConnect = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCountConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(13, 37)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(535, 397)
        Me.dgv.TabIndex = 0
        '
        'btStart
        '
        Me.btStart.BackColor = System.Drawing.Color.Green
        Me.btStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btStart.ForeColor = System.Drawing.Color.White
        Me.btStart.Location = New System.Drawing.Point(821, 8)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(75, 23)
        Me.btStart.TabIndex = 1
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = False
        '
        'tbCmd
        '
        Me.tbCmd.Location = New System.Drawing.Point(715, 10)
        Me.tbCmd.Name = "tbCmd"
        Me.tbCmd.Size = New System.Drawing.Size(100, 20)
        Me.tbCmd.TabIndex = 3
        '
        'cbQuery
        '
        Me.cbQuery.FormattingEnabled = True
        Me.cbQuery.Items.AddRange(New Object() {"SELECT", "UPDATE", "INSERT", "DELETE"})
        Me.cbQuery.Location = New System.Drawing.Point(554, 10)
        Me.cbQuery.Name = "cbQuery"
        Me.cbQuery.Size = New System.Drawing.Size(121, 21)
        Me.cbQuery.TabIndex = 4
        '
        'dgvCountConnection
        '
        Me.dgvCountConnection.AllowUserToAddRows = False
        Me.dgvCountConnection.AllowUserToDeleteRows = False
        Me.dgvCountConnection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCountConnection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCountConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCountConnection.Location = New System.Drawing.Point(554, 37)
        Me.dgvCountConnection.Name = "dgvCountConnection"
        Me.dgvCountConnection.ReadOnly = True
        Me.dgvCountConnection.RowHeadersVisible = False
        Me.dgvCountConnection.Size = New System.Drawing.Size(352, 397)
        Me.dgvCountConnection.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Pass"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(513, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Query"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(681, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Text"
        '
        'tbIp
        '
        Me.tbIp.Location = New System.Drawing.Point(33, 9)
        Me.tbIp.Name = "tbIp"
        Me.tbIp.Size = New System.Drawing.Size(100, 20)
        Me.tbIp.TabIndex = 11
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(174, 10)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(100, 20)
        Me.tbUser.TabIndex = 12
        '
        'tbPass
        '
        Me.tbPass.Location = New System.Drawing.Point(316, 10)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPass.Size = New System.Drawing.Size(100, 20)
        Me.tbPass.TabIndex = 13
        '
        'btConnect
        '
        Me.btConnect.BackColor = System.Drawing.Color.Green
        Me.btConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConnect.ForeColor = System.Drawing.Color.White
        Me.btConnect.Location = New System.Drawing.Point(422, 9)
        Me.btConnect.Name = "btConnect"
        Me.btConnect.Size = New System.Drawing.Size(85, 23)
        Me.btConnect.TabIndex = 14
        Me.btConnect.Text = "Connect"
        Me.btConnect.UseVisualStyleBackColor = False
        '
        'frmLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 446)
        Me.Controls.Add(Me.btConnect)
        Me.Controls.Add(Me.tbPass)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.tbIp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCountConnection)
        Me.Controls.Add(Me.cbQuery)
        Me.Controls.Add(Me.tbCmd)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmLoad"
        Me.Text = "Analyze"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCountConnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents tbCmd As System.Windows.Forms.TextBox
    Friend WithEvents cbQuery As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCountConnection As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbIp As System.Windows.Forms.TextBox
    Friend WithEvents tbUser As System.Windows.Forms.TextBox
    Friend WithEvents tbPass As System.Windows.Forms.TextBox
    Friend WithEvents btConnect As System.Windows.Forms.Button

End Class
