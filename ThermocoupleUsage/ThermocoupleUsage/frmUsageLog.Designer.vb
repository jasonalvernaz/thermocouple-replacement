<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsageLog
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
        Me.dgvLog = New System.Windows.Forms.DataGridView()
        Me.colUses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTemp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDoneUsageLog = New System.Windows.Forms.Button()
        Me.lblFurnaceNumberPrompt = New System.Windows.Forms.Label()
        Me.lblFurnaceNumber = New System.Windows.Forms.Label()
        Me.lblFurnaceThermocouple1Prompt = New System.Windows.Forms.Label()
        Me.lblFurnaceThermocouple1 = New System.Windows.Forms.Label()
        Me.lblFurnaceThermocouple2Prompt = New System.Windows.Forms.Label()
        Me.lblFurnaceThermocouple2 = New System.Windows.Forms.Label()
        Me.lblDateIssuedPrompt = New System.Windows.Forms.Label()
        Me.lblDateIssued = New System.Windows.Forms.Label()
        Me.lblMaxWithdrawDatePrompt = New System.Windows.Forms.Label()
        Me.lblMaxWithdrawDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLog
        '
        Me.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUses, Me.colDate, Me.colWO, Me.colTemp})
        Me.dgvLog.Location = New System.Drawing.Point(12, 175)
        Me.dgvLog.Name = "dgvLog"
        Me.dgvLog.Size = New System.Drawing.Size(444, 366)
        Me.dgvLog.TabIndex = 0
        '
        'colUses
        '
        Me.colUses.HeaderText = "Number of Uses"
        Me.colUses.Name = "colUses"
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        '
        'colWO
        '
        Me.colWO.HeaderText = "Work Order(s)"
        Me.colWO.Name = "colWO"
        '
        'colTemp
        '
        Me.colTemp.HeaderText = "Temperature"
        Me.colTemp.Name = "colTemp"
        '
        'btnDoneUsageLog
        '
        Me.btnDoneUsageLog.Location = New System.Drawing.Point(462, 518)
        Me.btnDoneUsageLog.Name = "btnDoneUsageLog"
        Me.btnDoneUsageLog.Size = New System.Drawing.Size(121, 23)
        Me.btnDoneUsageLog.TabIndex = 1
        Me.btnDoneUsageLog.Text = "Done"
        Me.btnDoneUsageLog.UseVisualStyleBackColor = True
        '
        'lblFurnaceNumberPrompt
        '
        Me.lblFurnaceNumberPrompt.AutoSize = True
        Me.lblFurnaceNumberPrompt.Location = New System.Drawing.Point(46, 87)
        Me.lblFurnaceNumberPrompt.Name = "lblFurnaceNumberPrompt"
        Me.lblFurnaceNumberPrompt.Size = New System.Drawing.Size(49, 13)
        Me.lblFurnaceNumberPrompt.TabIndex = 2
        Me.lblFurnaceNumberPrompt.Text = "Furnace:"
        '
        'lblFurnaceNumber
        '
        Me.lblFurnaceNumber.AutoSize = True
        Me.lblFurnaceNumber.Location = New System.Drawing.Point(101, 87)
        Me.lblFurnaceNumber.Name = "lblFurnaceNumber"
        Me.lblFurnaceNumber.Size = New System.Drawing.Size(83, 13)
        Me.lblFurnaceNumber.TabIndex = 3
        Me.lblFurnaceNumber.Text = "FurnaceNumber"
        '
        'lblFurnaceThermocouple1Prompt
        '
        Me.lblFurnaceThermocouple1Prompt.AutoSize = True
        Me.lblFurnaceThermocouple1Prompt.Location = New System.Drawing.Point(254, 87)
        Me.lblFurnaceThermocouple1Prompt.Name = "lblFurnaceThermocouple1Prompt"
        Me.lblFurnaceThermocouple1Prompt.Size = New System.Drawing.Size(101, 13)
        Me.lblFurnaceThermocouple1Prompt.TabIndex = 4
        Me.lblFurnaceThermocouple1Prompt.Text = "Thermocouple S/N:"
        '
        'lblFurnaceThermocouple1
        '
        Me.lblFurnaceThermocouple1.AutoSize = True
        Me.lblFurnaceThermocouple1.Location = New System.Drawing.Point(361, 87)
        Me.lblFurnaceThermocouple1.Name = "lblFurnaceThermocouple1"
        Me.lblFurnaceThermocouple1.Size = New System.Drawing.Size(120, 13)
        Me.lblFurnaceThermocouple1.TabIndex = 5
        Me.lblFurnaceThermocouple1.Text = "FurnaceThermocouple1"
        '
        'lblFurnaceThermocouple2Prompt
        '
        Me.lblFurnaceThermocouple2Prompt.AutoSize = True
        Me.lblFurnaceThermocouple2Prompt.Location = New System.Drawing.Point(254, 112)
        Me.lblFurnaceThermocouple2Prompt.Name = "lblFurnaceThermocouple2Prompt"
        Me.lblFurnaceThermocouple2Prompt.Size = New System.Drawing.Size(101, 13)
        Me.lblFurnaceThermocouple2Prompt.TabIndex = 6
        Me.lblFurnaceThermocouple2Prompt.Text = "Thermocouple S/N:"
        Me.lblFurnaceThermocouple2Prompt.Visible = False
        '
        'lblFurnaceThermocouple2
        '
        Me.lblFurnaceThermocouple2.AutoSize = True
        Me.lblFurnaceThermocouple2.Location = New System.Drawing.Point(361, 112)
        Me.lblFurnaceThermocouple2.Name = "lblFurnaceThermocouple2"
        Me.lblFurnaceThermocouple2.Size = New System.Drawing.Size(120, 13)
        Me.lblFurnaceThermocouple2.TabIndex = 7
        Me.lblFurnaceThermocouple2.Text = "FurnaceThermocouple2"
        Me.lblFurnaceThermocouple2.Visible = False
        '
        'lblDateIssuedPrompt
        '
        Me.lblDateIssuedPrompt.AutoSize = True
        Me.lblDateIssuedPrompt.Location = New System.Drawing.Point(28, 134)
        Me.lblDateIssuedPrompt.Name = "lblDateIssuedPrompt"
        Me.lblDateIssuedPrompt.Size = New System.Drawing.Size(67, 13)
        Me.lblDateIssuedPrompt.TabIndex = 8
        Me.lblDateIssuedPrompt.Text = "Date Issued:"
        '
        'lblDateIssued
        '
        Me.lblDateIssued.AutoSize = True
        Me.lblDateIssued.Location = New System.Drawing.Point(101, 134)
        Me.lblDateIssued.Name = "lblDateIssued"
        Me.lblDateIssued.Size = New System.Drawing.Size(61, 13)
        Me.lblDateIssued.TabIndex = 9
        Me.lblDateIssued.Text = "DateIssued"
        '
        'lblMaxWithdrawDatePrompt
        '
        Me.lblMaxWithdrawDatePrompt.AutoSize = True
        Me.lblMaxWithdrawDatePrompt.Location = New System.Drawing.Point(251, 134)
        Me.lblMaxWithdrawDatePrompt.Name = "lblMaxWithdrawDatePrompt"
        Me.lblMaxWithdrawDatePrompt.Size = New System.Drawing.Size(104, 13)
        Me.lblMaxWithdrawDatePrompt.TabIndex = 10
        Me.lblMaxWithdrawDatePrompt.Text = "Max Withdraw Date:"
        '
        'lblMaxWithdrawDate
        '
        Me.lblMaxWithdrawDate.AutoSize = True
        Me.lblMaxWithdrawDate.Location = New System.Drawing.Point(361, 134)
        Me.lblMaxWithdrawDate.Name = "lblMaxWithdrawDate"
        Me.lblMaxWithdrawDate.Size = New System.Drawing.Size(95, 13)
        Me.lblMaxWithdrawDate.TabIndex = 11
        Me.lblMaxWithdrawDate.Text = "MaxWithdrawDate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 55)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Usage Log"
        '
        'frmUsageLog
        '
        Me.AcceptButton = Me.btnDoneUsageLog
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMaxWithdrawDate)
        Me.Controls.Add(Me.lblMaxWithdrawDatePrompt)
        Me.Controls.Add(Me.lblDateIssued)
        Me.Controls.Add(Me.lblDateIssuedPrompt)
        Me.Controls.Add(Me.lblFurnaceThermocouple2)
        Me.Controls.Add(Me.lblFurnaceThermocouple2Prompt)
        Me.Controls.Add(Me.lblFurnaceThermocouple1)
        Me.Controls.Add(Me.lblFurnaceThermocouple1Prompt)
        Me.Controls.Add(Me.lblFurnaceNumber)
        Me.Controls.Add(Me.lblFurnaceNumberPrompt)
        Me.Controls.Add(Me.btnDoneUsageLog)
        Me.Controls.Add(Me.dgvLog)
        Me.Name = "frmUsageLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usage Log"
        CType(Me.dgvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLog As DataGridView
    Friend WithEvents colUses As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colWO As DataGridViewTextBoxColumn
    Friend WithEvents colTemp As DataGridViewTextBoxColumn
    Friend WithEvents btnDoneUsageLog As Button
    Friend WithEvents lblFurnaceNumberPrompt As Label
    Friend WithEvents lblFurnaceNumber As Label
    Friend WithEvents lblFurnaceThermocouple1Prompt As Label
    Friend WithEvents lblFurnaceThermocouple1 As Label
    Friend WithEvents lblFurnaceThermocouple2Prompt As Label
    Friend WithEvents lblFurnaceThermocouple2 As Label
    Friend WithEvents lblDateIssuedPrompt As Label
    Friend WithEvents lblDateIssued As Label
    Friend WithEvents lblMaxWithdrawDatePrompt As Label
    Friend WithEvents lblMaxWithdrawDate As Label
    Friend WithEvents Label1 As Label
End Class
