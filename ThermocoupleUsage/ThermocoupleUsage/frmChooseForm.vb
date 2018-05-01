Option Strict On
Public Class frmChooseForm
    Private Sub btnRecordUseForm_Click(sender As Object, e As EventArgs) Handles btnRecordUseForm.Click
        frmRecordUse.ShowDialog()
    End Sub

    Private Sub btnNewThermocoupleForm_Click(sender As Object, e As EventArgs) Handles btnNewThermocoupleForm.Click
        frmNewThermocouple.ShowDialog()
    End Sub

    Private Sub btnViewLog_Click(sender As Object, e As EventArgs) Handles btnViewLog.Click


        If GlobalSettings.CurrentFurnace = 3 Then

            For Each Item In GlobalSettings.Furnace03List

                Dim RowAdded As Integer

                RowAdded = frmUsageLog.dgvLog.Rows.Add()

                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colUses").Value = RowAdded + 1
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colDate").Value = Item.HiddenDate.ToShortDateString()
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colWO").Value = Item.HiddenWorkOrder
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colTemp").Value = Item.HiddenTemperature
            Next

        End If

        If GlobalSettings.CurrentFurnace = 4 Then

            For Each Item In GlobalSettings.Furnace04List

                Dim RowAdded As Integer

                RowAdded = frmUsageLog.dgvLog.Rows.Add()

                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colUses").Value = RowAdded + 1
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colDate").Value = Item.HiddenDate.ToShortDateString()
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colWO").Value = Item.HiddenWorkOrder
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colTemp").Value = Item.HiddenTemperature
            Next

        End If

        If GlobalSettings.CurrentFurnace = 6 Then

            For Each Item In GlobalSettings.Furnace06List

                Dim RowAdded As Integer

                RowAdded = frmUsageLog.dgvLog.Rows.Add()

                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colUses").Value = RowAdded + 1
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colDate").Value = Item.HiddenDate.ToShortDateString()
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colWO").Value = Item.HiddenWorkOrder
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colTemp").Value = Item.HiddenTemperature
            Next

        End If

        If GlobalSettings.CurrentFurnace = 12 Then

            For Each Item In GlobalSettings.Furnace12List

                Dim RowAdded As Integer

                RowAdded = frmUsageLog.dgvLog.Rows.Add()

                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colUses").Value = RowAdded + 1
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colDate").Value = Item.HiddenDate.ToShortDateString()
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colWO").Value = Item.HiddenWorkOrder
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colTemp").Value = Item.HiddenTemperature
            Next

        End If

        If GlobalSettings.CurrentFurnace = 14 Then

            For Each Item In GlobalSettings.Furnace14List

                Dim RowAdded As Integer

                RowAdded = frmUsageLog.dgvLog.Rows.Add()

                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colUses").Value = RowAdded + 1
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colDate").Value = Item.HiddenDate.ToShortDateString()
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colWO").Value = Item.HiddenWorkOrder
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colTemp").Value = Item.HiddenTemperature
            Next

        End If

        If GlobalSettings.CurrentFurnace = 8 Then

            For Each Item In GlobalSettings.FurnaceV8List

                Dim RowAdded As Integer

                RowAdded = frmUsageLog.dgvLog.Rows.Add()

                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colUses").Value = RowAdded + 1
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colDate").Value = Item.HiddenDate.ToShortDateString()
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colWO").Value = Item.HiddenWorkOrder
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colTemp").Value = Item.HiddenTemperature
            Next

        End If

        If GlobalSettings.CurrentFurnace = 9 Then

            For Each Item In GlobalSettings.FurnaceV9List

                Dim RowAdded As Integer

                RowAdded = frmUsageLog.dgvLog.Rows.Add()

                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colUses").Value = RowAdded + 1
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colDate").Value = Item.HiddenDate.ToShortDateString()
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colWO").Value = Item.HiddenWorkOrder
                frmUsageLog.dgvLog.Rows(RowAdded).Cells("colTemp").Value = Item.HiddenTemperature
            Next

        End If

        frmUsageLog.ShowDialog()

    End Sub

    Private Sub cboCurrentFurnace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCurrentFurnace.SelectedIndexChanged
        If cboCurrentFurnace.SelectedIndex = 0 Then
            GlobalSettings.CurrentFurnace = 3
        ElseIf cboCurrentFurnace.SelectedIndex = 1 Then
            GlobalSettings.CurrentFurnace = 4
        ElseIf cboCurrentFurnace.SelectedIndex = 2 Then
            GlobalSettings.CurrentFurnace = 6
        ElseIf cboCurrentFurnace.SelectedIndex = 3 Then
            GlobalSettings.CurrentFurnace = 12
        ElseIf cboCurrentFurnace.SelectedIndex = 4 Then
            GlobalSettings.CurrentFurnace = 14
        ElseIf cboCurrentFurnace.SelectedIndex = 5 Then
            GlobalSettings.CurrentFurnace = 8
        ElseIf cboCurrentFurnace.SelectedIndex = 6 Then
            GlobalSettings.CurrentFurnace = 9
        End If
    End Sub

    Private Sub btnRandomData_Click(sender As Object, e As EventArgs) Handles btnRandomData.Click
        Dim CurrentRandom As New Random(1)
        For x = 1 To 180
            Dim u As New Uses
            u.HiddenDate = System.DateTime.Today
            u.HiddenTemperature = CurrentRandom.Next(300, 1400)
            u.HiddenWorkOrder = CurrentRandom.Next(90000, 90179)
            GlobalSettings.Furnace03List.Add(u)
        Next
    End Sub
End Class