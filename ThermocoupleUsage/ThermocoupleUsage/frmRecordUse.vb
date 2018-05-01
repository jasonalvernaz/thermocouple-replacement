Option Strict On
Imports System.Convert
Imports System.Text.RegularExpressions
Public Class frmRecordUse


    Private Sub btnRecordUse_Click(sender As Object, e As EventArgs) Handles btnRecordUse.Click

        Try
            Dim rWorkOrder As Match = Regex.Match(txtWorkOrder.Text, "^(\d{5})*")
            If txtWorkOrder.Text <> rWorkOrder.ToString Then
                Throw New Exception
            End If

            Dim NewUse As New Uses
            NewUse.WorkOrder(ToInt32(txtWorkOrder.Text))
            NewUse.DateOfUse(System.DateTime.Today)
            NewUse.Temp(ToInt32(txtTemperature.Text))

            If GlobalSettings.CurrentFurnace = 3 Then
                If System.DateTime.Today.ToShortDateString > GlobalSettings.Furnace03Thermocouple.ReadMaxDate Or
                GlobalSettings.Furnace03List.Count >= 180 Then
                    MessageBox.Show(Me, "Thermocouple needs to be replaced.", "Over Usage", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    GlobalSettings.Furnace03List.Add(NewUse)
                    MessageBox.Show(Me, "Thank you for recording thermocouple use.", "Usage Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf GlobalSettings.CurrentFurnace = 4 Then
                If System.DateTime.Today.ToShortDateString > GlobalSettings.Furnace04Thermocouple.ReadMaxDate Or
                GlobalSettings.Furnace04List.Count >= 270 Then
                    MessageBox.Show(Me, "Thermocouple needs to be replaced.", "Over Usage", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    GlobalSettings.Furnace04List.Add(NewUse)
                    MessageBox.Show(Me, "Thank you for recording thermocouple use.", "Usage Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf GlobalSettings.CurrentFurnace = 6 Then
                If System.DateTime.Today.ToShortDateString > GlobalSettings.Furnace06Thermocouple.ReadMaxDate Or
                GlobalSettings.Furnace06List.Count >= 270 Then
                    MessageBox.Show(Me, "Thermocouple needs to be replaced.", "Over Usage", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    GlobalSettings.Furnace06List.Add(NewUse)
                    MessageBox.Show(Me, "Thank you for recording thermocouple use.", "Usage Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf GlobalSettings.CurrentFurnace = 12 Then
                If System.DateTime.Today.ToShortDateString > GlobalSettings.Furnace12Thermocouple.ReadMaxDate Or
                GlobalSettings.Furnace12List.Count >= 180 Then
                    MessageBox.Show(Me, "Thermocouple needs to be replaced.", "Over Usage", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    GlobalSettings.Furnace12List.Add(NewUse)
                    MessageBox.Show(Me, "Thank you for recording thermocouple use.", "Usage Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf GlobalSettings.CurrentFurnace = 14 Then
                If System.DateTime.Today.ToShortDateString > GlobalSettings.Furnace14Thermocouple.ReadMaxDate Or
                GlobalSettings.Furnace14List.Count >= 180 Then
                    MessageBox.Show(Me, "Thermocouple needs to be replaced.", "Over Usage", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    GlobalSettings.Furnace14List.Add(NewUse)
                    MessageBox.Show(Me, "Thank you for recording thermocouple use.", "Usage Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf GlobalSettings.CurrentFurnace = 8 Then
                If System.DateTime.Today.ToShortDateString > GlobalSettings.FurnaceV8Thermocouple1.ReadMaxDate Or
                GlobalSettings.FurnaceV8List.Count >= 90 Then
                    MessageBox.Show(Me, "Thermocouples need to be replaced.", "Over Usage", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    GlobalSettings.FurnaceV8List.Add(NewUse)
                    MessageBox.Show(Me, "Thank you for recording thermocouple use.", "Usage Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf GlobalSettings.CurrentFurnace = 9 Then
                If System.DateTime.Today.ToShortDateString > GlobalSettings.FurnaceV9Thermocouple1.ReadMaxDate Or
                GlobalSettings.FurnaceV9List.Count >= 90 Then
                    MessageBox.Show(Me, "Thermocouples need to be replaced.", "Over Usage", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    GlobalSettings.FurnaceV9List.Add(NewUse)
                    MessageBox.Show(Me, "Thank you for recording thermocouple use.", "Usage Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch
            MessageBox.Show(Me, "Inputs are invalid. Check numbers and try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




        txtWorkOrder.Text = ""
        txtTemperature.Text = ""

    End Sub

    Private Sub btnDoneRecordUsage_Click(sender As Object, e As EventArgs) Handles btnDoneRecordUsage.Click
        Me.Close()
        frmChooseForm.Activate()
    End Sub


End Class
