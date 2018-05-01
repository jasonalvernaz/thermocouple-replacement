<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecordUse
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
        Me.lblWorkOrderPrompt = New System.Windows.Forms.Label()
        Me.txtWorkOrder = New System.Windows.Forms.TextBox()
        Me.lblEnterTempPrompt = New System.Windows.Forms.Label()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.lblDegreesPrompt = New System.Windows.Forms.Label()
        Me.btnRecordUse = New System.Windows.Forms.Button()
        Me.btnDoneRecordUsage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWorkOrderPrompt
        '
        Me.lblWorkOrderPrompt.AutoSize = True
        Me.lblWorkOrderPrompt.Location = New System.Drawing.Point(129, 201)
        Me.lblWorkOrderPrompt.Name = "lblWorkOrderPrompt"
        Me.lblWorkOrderPrompt.Size = New System.Drawing.Size(144, 13)
        Me.lblWorkOrderPrompt.TabIndex = 2
        Me.lblWorkOrderPrompt.Text = "Enter Work Order Number(s):"
        '
        'txtWorkOrder
        '
        Me.txtWorkOrder.Location = New System.Drawing.Point(132, 217)
        Me.txtWorkOrder.Name = "txtWorkOrder"
        Me.txtWorkOrder.Size = New System.Drawing.Size(183, 20)
        Me.txtWorkOrder.TabIndex = 3
        Me.txtWorkOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEnterTempPrompt
        '
        Me.lblEnterTempPrompt.AutoSize = True
        Me.lblEnterTempPrompt.Location = New System.Drawing.Point(129, 287)
        Me.lblEnterTempPrompt.Name = "lblEnterTempPrompt"
        Me.lblEnterTempPrompt.Size = New System.Drawing.Size(98, 13)
        Me.lblEnterTempPrompt.TabIndex = 4
        Me.lblEnterTempPrompt.Text = "Enter Temperature:"
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(132, 303)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(121, 20)
        Me.txtTemperature.TabIndex = 5
        Me.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDegreesPrompt
        '
        Me.lblDegreesPrompt.AutoSize = True
        Me.lblDegreesPrompt.Location = New System.Drawing.Point(259, 306)
        Me.lblDegreesPrompt.Name = "lblDegreesPrompt"
        Me.lblDegreesPrompt.Size = New System.Drawing.Size(56, 13)
        Me.lblDegreesPrompt.TabIndex = 6
        Me.lblDegreesPrompt.Text = "Degrees F"
        '
        'btnRecordUse
        '
        Me.btnRecordUse.Location = New System.Drawing.Point(132, 359)
        Me.btnRecordUse.Name = "btnRecordUse"
        Me.btnRecordUse.Size = New System.Drawing.Size(121, 23)
        Me.btnRecordUse.TabIndex = 7
        Me.btnRecordUse.Text = "Record Use"
        Me.btnRecordUse.UseVisualStyleBackColor = True
        '
        'btnDoneRecordUsage
        '
        Me.btnDoneRecordUsage.Location = New System.Drawing.Point(132, 401)
        Me.btnDoneRecordUsage.Name = "btnDoneRecordUsage"
        Me.btnDoneRecordUsage.Size = New System.Drawing.Size(121, 23)
        Me.btnDoneRecordUsage.TabIndex = 8
        Me.btnDoneRecordUsage.Text = "Done"
        Me.btnDoneRecordUsage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 55)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Record"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(503, 55)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Thermocouple Usage"
        '
        'frmRecordUse
        '
        Me.AcceptButton = Me.btnRecordUse
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDoneRecordUsage)
        Me.Controls.Add(Me.btnRecordUse)
        Me.Controls.Add(Me.lblDegreesPrompt)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.lblEnterTempPrompt)
        Me.Controls.Add(Me.txtWorkOrder)
        Me.Controls.Add(Me.lblWorkOrderPrompt)
        Me.Name = "frmRecordUse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Thermocouple Usage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWorkOrderPrompt As Label
    Friend WithEvents txtWorkOrder As TextBox
    Friend WithEvents lblEnterTempPrompt As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents lblDegreesPrompt As Label
    Friend WithEvents btnRecordUse As Button
    Friend WithEvents btnDoneRecordUsage As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
