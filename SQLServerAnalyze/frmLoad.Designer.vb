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
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv.Size = New System.Drawing.Size(532, 201)
        Me.dgv.TabIndex = 0
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(246, 8)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(75, 23)
        Me.btStart.TabIndex = 1
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'tbCmd
        '
        Me.tbCmd.Location = New System.Drawing.Point(140, 10)
        Me.tbCmd.Name = "tbCmd"
        Me.tbCmd.Size = New System.Drawing.Size(100, 20)
        Me.tbCmd.TabIndex = 3
        '
        'cbQuery
        '
        Me.cbQuery.FormattingEnabled = True
        Me.cbQuery.Items.AddRange(New Object() {"SELECT", "UPDATE", "INSERT", "DELETE"})
        Me.cbQuery.Location = New System.Drawing.Point(13, 10)
        Me.cbQuery.Name = "cbQuery"
        Me.cbQuery.Size = New System.Drawing.Size(121, 21)
        Me.cbQuery.TabIndex = 4
        '
        'frmLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 250)
        Me.Controls.Add(Me.cbQuery)
        Me.Controls.Add(Me.tbCmd)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmLoad"
        Me.Text = "Analyze"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents tbCmd As System.Windows.Forms.TextBox
    Friend WithEvents cbQuery As System.Windows.Forms.ComboBox

End Class
