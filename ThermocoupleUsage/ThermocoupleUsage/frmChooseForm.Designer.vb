<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChooseForm
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
        Me.btnRecordUseForm = New System.Windows.Forms.Button()
        Me.btnNewThermocoupleForm = New System.Windows.Forms.Button()
        Me.cboCurrentFurnace = New System.Windows.Forms.ComboBox()
        Me.lblSelectFurnacePrompt = New System.Windows.Forms.Label()
        Me.btnViewLog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRandomData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRecordUseForm
        '
        Me.btnRecordUseForm.Location = New System.Drawing.Point(231, 242)
        Me.btnRecordUseForm.Name = "btnRecordUseForm"
        Me.btnRecordUseForm.Size = New System.Drawing.Size(121, 23)
        Me.btnRecordUseForm.TabIndex = 0
        Me.btnRecordUseForm.Text = "Record Use"
        Me.btnRecordUseForm.UseVisualStyleBackColor = True
        '
        'btnNewThermocoupleForm
        '
        Me.btnNewThermocoupleForm.Location = New System.Drawing.Point(231, 387)
        Me.btnNewThermocoupleForm.Name = "btnNewThermocoupleForm"
        Me.btnNewThermocoupleForm.Size = New System.Drawing.Size(121, 23)
        Me.btnNewThermocoupleForm.TabIndex = 1
        Me.btnNewThermocoupleForm.Text = "New Thermocouple"
        Me.btnNewThermocoupleForm.UseVisualStyleBackColor = True
        '
        'cboCurrentFurnace
        '
        Me.cboCurrentFurnace.FormattingEnabled = True
        Me.cboCurrentFurnace.Items.AddRange(New Object() {"Temper 03", "Temper 04", "Temper 06", "Temper 12", "Temper 14", "Vacuum 08", "Vacuum 09"})
        Me.cboCurrentFurnace.Location = New System.Drawing.Point(231, 202)
        Me.cboCurrentFurnace.Name = "cboCurrentFurnace"
        Me.cboCurrentFurnace.Size = New System.Drawing.Size(121, 21)
        Me.cboCurrentFurnace.TabIndex = 2
        '
        'lblSelectFurnacePrompt
        '
        Me.lblSelectFurnacePrompt.AutoSize = True
        Me.lblSelectFurnacePrompt.Location = New System.Drawing.Point(228, 173)
        Me.lblSelectFurnacePrompt.Name = "lblSelectFurnacePrompt"
        Me.lblSelectFurnacePrompt.Size = New System.Drawing.Size(82, 13)
        Me.lblSelectFurnacePrompt.TabIndex = 3
        Me.lblSelectFurnacePrompt.Text = "Select Furnace:"
        '
        'btnViewLog
        '
        Me.btnViewLog.Location = New System.Drawing.Point(231, 416)
        Me.btnViewLog.Name = "btnViewLog"
        Me.btnViewLog.Size = New System.Drawing.Size(121, 23)
        Me.btnViewLog.TabIndex = 4
        Me.btnViewLog.Text = "View Log"
        Me.btnViewLog.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 55)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NHT Thermocouple"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(496, 55)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Management System"
        '
        'btnRandomData
        '
        Me.btnRandomData.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRandomData.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRandomData.Location = New System.Drawing.Point(457, 311)
        Me.btnRandomData.Name = "btnRandomData"
        Me.btnRandomData.Size = New System.Drawing.Size(81, 23)
        Me.btnRandomData.TabIndex = 7
        Me.btnRandomData.Text = "Random Data"
        Me.btnRandomData.UseVisualStyleBackColor = False
        '
        'frmChooseForm
        '
        Me.AcceptButton = Me.btnRecordUseForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.btnRandomData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewLog)
        Me.Controls.Add(Me.lblSelectFurnacePrompt)
        Me.Controls.Add(Me.cboCurrentFurnace)
        Me.Controls.Add(Me.btnNewThermocoupleForm)
        Me.Controls.Add(Me.btnRecordUseForm)
        Me.Name = "frmChooseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to the Thermocouple Management System!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRecordUseForm As Button
    Friend WithEvents btnNewThermocoupleForm As Button
    Friend WithEvents cboCurrentFurnace As ComboBox
    Friend WithEvents lblSelectFurnacePrompt As Label
    Friend WithEvents btnViewLog As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRandomData As Button
End Class
