<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewThermocouple
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
        Me.lblLotID1Prompt = New System.Windows.Forms.Label()
        Me.txtLotID1 = New System.Windows.Forms.TextBox()
        Me.lblThermocoupleID1Prompt = New System.Windows.Forms.Label()
        Me.txtThermocoupleID1 = New System.Windows.Forms.TextBox()
        Me.btnCreateUsage = New System.Windows.Forms.Button()
        Me.lblThermocouple1Prompt = New System.Windows.Forms.Label()
        Me.lblThermocouple2Prompt = New System.Windows.Forms.Label()
        Me.lblLotID2Prompt = New System.Windows.Forms.Label()
        Me.txtLotID2 = New System.Windows.Forms.TextBox()
        Me.lblThermocoupleID2Prompt = New System.Windows.Forms.Label()
        Me.txtThermocoupleID2 = New System.Windows.Forms.TextBox()
        Me.btnNewThermocoupleDone = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLotID1Prompt
        '
        Me.lblLotID1Prompt.AutoSize = True
        Me.lblLotID1Prompt.Location = New System.Drawing.Point(134, 202)
        Me.lblLotID1Prompt.Name = "lblLotID1Prompt"
        Me.lblLotID1Prompt.Size = New System.Drawing.Size(39, 13)
        Me.lblLotID1Prompt.TabIndex = 2
        Me.lblLotID1Prompt.Text = "Lot ID:"
        '
        'txtLotID1
        '
        Me.txtLotID1.Location = New System.Drawing.Point(137, 218)
        Me.txtLotID1.Name = "txtLotID1"
        Me.txtLotID1.Size = New System.Drawing.Size(121, 20)
        Me.txtLotID1.TabIndex = 3
        Me.txtLotID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblThermocoupleID1Prompt
        '
        Me.lblThermocoupleID1Prompt.AutoSize = True
        Me.lblThermocoupleID1Prompt.Location = New System.Drawing.Point(134, 268)
        Me.lblThermocoupleID1Prompt.Name = "lblThermocoupleID1Prompt"
        Me.lblThermocoupleID1Prompt.Size = New System.Drawing.Size(92, 13)
        Me.lblThermocoupleID1Prompt.TabIndex = 4
        Me.lblThermocoupleID1Prompt.Text = "Thermocouple ID:"
        '
        'txtThermocoupleID1
        '
        Me.txtThermocoupleID1.Location = New System.Drawing.Point(137, 284)
        Me.txtThermocoupleID1.Name = "txtThermocoupleID1"
        Me.txtThermocoupleID1.Size = New System.Drawing.Size(121, 20)
        Me.txtThermocoupleID1.TabIndex = 5
        Me.txtThermocoupleID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCreateUsage
        '
        Me.btnCreateUsage.Location = New System.Drawing.Point(137, 331)
        Me.btnCreateUsage.Name = "btnCreateUsage"
        Me.btnCreateUsage.Size = New System.Drawing.Size(121, 23)
        Me.btnCreateUsage.TabIndex = 6
        Me.btnCreateUsage.Text = "Replace"
        Me.btnCreateUsage.UseVisualStyleBackColor = True
        '
        'lblThermocouple1Prompt
        '
        Me.lblThermocouple1Prompt.AutoSize = True
        Me.lblThermocouple1Prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThermocouple1Prompt.Location = New System.Drawing.Point(134, 166)
        Me.lblThermocouple1Prompt.Name = "lblThermocouple1Prompt"
        Me.lblThermocouple1Prompt.Size = New System.Drawing.Size(129, 13)
        Me.lblThermocouple1Prompt.TabIndex = 7
        Me.lblThermocouple1Prompt.Text = "Thermocouple 1 S/N:"
        '
        'lblThermocouple2Prompt
        '
        Me.lblThermocouple2Prompt.AutoSize = True
        Me.lblThermocouple2Prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThermocouple2Prompt.Location = New System.Drawing.Point(320, 166)
        Me.lblThermocouple2Prompt.Name = "lblThermocouple2Prompt"
        Me.lblThermocouple2Prompt.Size = New System.Drawing.Size(129, 13)
        Me.lblThermocouple2Prompt.TabIndex = 8
        Me.lblThermocouple2Prompt.Text = "Thermocouple 2 S/N:"
        '
        'lblLotID2Prompt
        '
        Me.lblLotID2Prompt.AutoSize = True
        Me.lblLotID2Prompt.Location = New System.Drawing.Point(320, 202)
        Me.lblLotID2Prompt.Name = "lblLotID2Prompt"
        Me.lblLotID2Prompt.Size = New System.Drawing.Size(39, 13)
        Me.lblLotID2Prompt.TabIndex = 9
        Me.lblLotID2Prompt.Text = "Lot ID:"
        '
        'txtLotID2
        '
        Me.txtLotID2.Enabled = False
        Me.txtLotID2.Location = New System.Drawing.Point(323, 218)
        Me.txtLotID2.Name = "txtLotID2"
        Me.txtLotID2.Size = New System.Drawing.Size(121, 20)
        Me.txtLotID2.TabIndex = 10
        Me.txtLotID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblThermocoupleID2Prompt
        '
        Me.lblThermocoupleID2Prompt.AutoSize = True
        Me.lblThermocoupleID2Prompt.Location = New System.Drawing.Point(320, 268)
        Me.lblThermocoupleID2Prompt.Name = "lblThermocoupleID2Prompt"
        Me.lblThermocoupleID2Prompt.Size = New System.Drawing.Size(92, 13)
        Me.lblThermocoupleID2Prompt.TabIndex = 11
        Me.lblThermocoupleID2Prompt.Text = "Thermocouple ID:"
        '
        'txtThermocoupleID2
        '
        Me.txtThermocoupleID2.Enabled = False
        Me.txtThermocoupleID2.Location = New System.Drawing.Point(323, 284)
        Me.txtThermocoupleID2.Name = "txtThermocoupleID2"
        Me.txtThermocoupleID2.Size = New System.Drawing.Size(121, 20)
        Me.txtThermocoupleID2.TabIndex = 12
        Me.txtThermocoupleID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNewThermocoupleDone
        '
        Me.btnNewThermocoupleDone.Location = New System.Drawing.Point(137, 379)
        Me.btnNewThermocoupleDone.Name = "btnNewThermocoupleDone"
        Me.btnNewThermocoupleDone.Size = New System.Drawing.Size(121, 23)
        Me.btnNewThermocoupleDone.TabIndex = 13
        Me.btnNewThermocoupleDone.Text = "Done"
        Me.btnNewThermocoupleDone.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 55)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Thermocouple"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 55)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Replacement"
        '
        'frmNewThermocouple
        '
        Me.AcceptButton = Me.btnCreateUsage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewThermocoupleDone)
        Me.Controls.Add(Me.txtThermocoupleID2)
        Me.Controls.Add(Me.lblThermocoupleID2Prompt)
        Me.Controls.Add(Me.txtLotID2)
        Me.Controls.Add(Me.lblLotID2Prompt)
        Me.Controls.Add(Me.lblThermocouple2Prompt)
        Me.Controls.Add(Me.lblThermocouple1Prompt)
        Me.Controls.Add(Me.btnCreateUsage)
        Me.Controls.Add(Me.txtThermocoupleID1)
        Me.Controls.Add(Me.lblThermocoupleID1Prompt)
        Me.Controls.Add(Me.txtLotID1)
        Me.Controls.Add(Me.lblLotID1Prompt)
        Me.Name = "frmNewThermocouple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thermocouple Replacement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLotID1Prompt As Label
    Friend WithEvents txtLotID1 As TextBox
    Friend WithEvents lblThermocoupleID1Prompt As Label
    Friend WithEvents txtThermocoupleID1 As TextBox
    Friend WithEvents btnCreateUsage As Button
    Friend WithEvents lblThermocouple1Prompt As Label
    Friend WithEvents lblThermocouple2Prompt As Label
    Friend WithEvents lblLotID2Prompt As Label
    Friend WithEvents txtLotID2 As TextBox
    Friend WithEvents lblThermocoupleID2Prompt As Label
    Friend WithEvents txtThermocoupleID2 As TextBox
    Friend WithEvents btnNewThermocoupleDone As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
