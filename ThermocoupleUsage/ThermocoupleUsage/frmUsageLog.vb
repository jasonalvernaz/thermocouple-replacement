Option Strict On
Imports System.Convert
Public Class frmUsageLog
    Private Sub btnDoneUsageLog_Click(sender As Object, e As EventArgs) Handles btnDoneUsageLog.Click
        lblFurnaceThermocouple2.Hide()
        lblFurnaceThermocouple2Prompt.Hide()
        dgvLog.Rows.Clear()
        Me.Close()
        frmChooseForm.Activate()
    End Sub

    Private Sub frmUsageLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        If GlobalSettings.CurrentFurnace = 3 Then
            lblFurnaceNumber.Text = "Temper 03"
            lblFurnaceThermocouple1.Text = GlobalSettings.Furnace03Thermocouple.ThermocoupleSN
            lblDateIssued.Text = GlobalSettings.Furnace03Thermocouple.ReadDateIssued
            lblMaxWithdrawDate.Text = GlobalSettings.Furnace03Thermocouple.ReadMaxDate
        ElseIf GlobalSettings.CurrentFurnace = 4 Then
            lblFurnaceNumber.Text = "Temper 04"
            lblFurnaceThermocouple1.Text = GlobalSettings.Furnace04Thermocouple.ThermocoupleSN
            lblDateIssued.Text = GlobalSettings.Furnace04Thermocouple.ReadDateIssued
            lblMaxWithdrawDate.Text = GlobalSettings.Furnace04Thermocouple.ReadMaxDate
        ElseIf GlobalSettings.CurrentFurnace = 6 Then
            lblFurnaceNumber.Text = "Temper 06"
            lblFurnaceThermocouple1.Text = GlobalSettings.Furnace06Thermocouple.ThermocoupleSN
            lblDateIssued.Text = GlobalSettings.Furnace06Thermocouple.ReadDateIssued
            lblMaxWithdrawDate.Text = GlobalSettings.Furnace06Thermocouple.ReadMaxDate
        ElseIf GlobalSettings.CurrentFurnace = 12 Then
            lblFurnaceNumber.Text = "Temper 12"
            lblFurnaceThermocouple1.Text = GlobalSettings.Furnace12Thermocouple.ThermocoupleSN
            lblDateIssued.Text = GlobalSettings.Furnace12Thermocouple.ReadDateIssued
            lblMaxWithdrawDate.Text = GlobalSettings.Furnace12Thermocouple.ReadMaxDate
        ElseIf GlobalSettings.CurrentFurnace = 14 Then
            lblFurnaceNumber.Text = "Temper 14"
            lblFurnaceThermocouple1.Text = GlobalSettings.Furnace14Thermocouple.ThermocoupleSN
            lblDateIssued.Text = GlobalSettings.Furnace14Thermocouple.ReadDateIssued
            lblMaxWithdrawDate.Text = GlobalSettings.Furnace14Thermocouple.ReadMaxDate
        ElseIf GlobalSettings.CurrentFurnace = 8 Then
            lblFurnaceNumber.Text = "Vacuum 08"
            lblFurnaceThermocouple1.Text = GlobalSettings.FurnaceV8Thermocouple1.ThermocoupleSN
            lblFurnaceThermocouple2.Text = GlobalSettings.FurnaceV8Thermocouple2.ThermocoupleSN
            lblDateIssued.Text = GlobalSettings.FurnaceV8Thermocouple1.ReadDateIssued
            lblMaxWithdrawDate.Text = GlobalSettings.FurnaceV8Thermocouple1.ReadMaxDate
            lblFurnaceThermocouple2Prompt.Show()
            lblFurnaceThermocouple2.Show()
        ElseIf GlobalSettings.CurrentFurnace = 9 Then
            lblFurnaceNumber.Text = "Vacuum 09"
            lblFurnaceThermocouple1.Text = GlobalSettings.FurnaceV9Thermocouple1.ThermocoupleSN
            lblFurnaceThermocouple2.Text = GlobalSettings.FurnaceV9Thermocouple2.ThermocoupleSN
            lblDateIssued.Text = GlobalSettings.FurnaceV9Thermocouple1.ReadDateIssued
            lblMaxWithdrawDate.Text = GlobalSettings.FurnaceV9Thermocouple1.ReadMaxDate
            lblFurnaceThermocouple2Prompt.Show()
            lblFurnaceThermocouple2.Show()
        End If
    End Sub
End Class