Option Strict On
Imports System.Convert
Imports System.Text.RegularExpressions
Public Class frmNewThermocouple

    Private Sub btnCreateUsage_Click(sender As Object, e As EventArgs) Handles btnCreateUsage.Click

        Try

            Dim matchLotID1 As Match = Regex.Match(txtLotID1.Text, "^\d{5}")
            Dim matchLotID2 As Match = Regex.Match(txtLotID2.Text, "^\d{5}")
            Dim matchThermocoupleID1 As Match = Regex.Match(txtThermocoupleID1.Text, "^\d{1,3}")
            Dim matchThermocoupleID2 As Match = Regex.Match(txtThermocoupleID2.Text, "^\d{1,3}")


            If matchLotID1.ToString <> txtLotID1.Text Or matchLotID2.ToString <> txtLotID2.Text Or
                matchThermocoupleID1.ToString <> txtThermocoupleID1.Text Or matchThermocoupleID2.ToString <> txtThermocoupleID2.Text Then
                Throw New Exception
            End If

            If GlobalSettings.CurrentFurnace = 3 Then
                GlobalSettings.Furnace03List.Clear()
                GlobalSettings.Furnace03Thermocouple.LotID(ToInt32(txtLotID1.Text))
                GlobalSettings.Furnace03Thermocouple.ThermocoupleID(ToInt32(txtThermocoupleID1.Text))
                GlobalSettings.Furnace03Thermocouple.DateIssued(System.DateTime.Today)
                GlobalSettings.Furnace03Thermocouple.MaxDate(System.DateTime.Today)
                MessageBox.Show(Me, "Thank you for replacing thermocouples.", "Replacement Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLotID1.Text = ""
                txtThermocoupleID1.Text = ""
            ElseIf GlobalSettings.CurrentFurnace = 4 Then
                GlobalSettings.Furnace04List.Clear()
                GlobalSettings.Furnace04Thermocouple.LotID(ToInt32(txtLotID1.Text))
                GlobalSettings.Furnace04Thermocouple.ThermocoupleID(ToInt32(txtThermocoupleID1.Text))
                GlobalSettings.Furnace04Thermocouple.DateIssued(System.DateTime.Today)
                GlobalSettings.Furnace04Thermocouple.MaxDate(System.DateTime.Today)
                MessageBox.Show(Me, "Thank you for replacing thermocouples.", "Replacement Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLotID1.Text = ""
                txtThermocoupleID1.Text = ""
            ElseIf GlobalSettings.CurrentFurnace = 6 Then
                GlobalSettings.Furnace06List.Clear()
                GlobalSettings.Furnace06Thermocouple.LotID(ToInt32(txtLotID1.Text))
                GlobalSettings.Furnace06Thermocouple.ThermocoupleID(ToInt32(txtThermocoupleID1.Text))
                GlobalSettings.Furnace06Thermocouple.DateIssued(System.DateTime.Today)
                GlobalSettings.Furnace06Thermocouple.MaxDate(System.DateTime.Today)
                MessageBox.Show(Me, "Thank you for replacing thermocouples.", "Replacement Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLotID1.Text = ""
                txtThermocoupleID1.Text = ""
            ElseIf GlobalSettings.CurrentFurnace = 12 Then
                GlobalSettings.Furnace12List.Clear()
                GlobalSettings.Furnace12Thermocouple.LotID(ToInt32(txtLotID1.Text))
                GlobalSettings.Furnace12Thermocouple.ThermocoupleID(ToInt32(txtThermocoupleID1.Text))
                GlobalSettings.Furnace12Thermocouple.DateIssued(System.DateTime.Today)
                GlobalSettings.Furnace12Thermocouple.MaxDate(System.DateTime.Today)
                MessageBox.Show(Me, "Thank you for replacing thermocouples.", "Replacement Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLotID1.Text = ""
                txtThermocoupleID1.Text = ""
            ElseIf GlobalSettings.CurrentFurnace = 14 Then
                GlobalSettings.Furnace14List.Clear()
                GlobalSettings.Furnace14Thermocouple.LotID(ToInt32(txtLotID1.Text))
                GlobalSettings.Furnace14Thermocouple.ThermocoupleID(ToInt32(txtThermocoupleID1.Text))
                GlobalSettings.Furnace14Thermocouple.DateIssued(System.DateTime.Today)
                GlobalSettings.Furnace14Thermocouple.MaxDate(System.DateTime.Today)
                MessageBox.Show(Me, "Thank you for replacing thermocouples.", "Replacement Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLotID1.Text = ""
                txtThermocoupleID1.Text = ""
            ElseIf GlobalSettings.CurrentFurnace = 8 Then
                GlobalSettings.FurnaceV8List.Clear()
                GlobalSettings.FurnaceV8Thermocouple1.LotID(ToInt32(txtLotID1.Text))
                GlobalSettings.FurnaceV8Thermocouple1.ThermocoupleID(ToInt32(txtThermocoupleID1.Text))
                GlobalSettings.FurnaceV8Thermocouple2.LotID(ToInt32(txtLotID2.Text))
                GlobalSettings.FurnaceV8Thermocouple2.ThermocoupleID(ToInt32(txtThermocoupleID2.Text))
                GlobalSettings.FurnaceV8Thermocouple1.DateIssued(System.DateTime.Today)
                GlobalSettings.FurnaceV8Thermocouple1.MaxDate(System.DateTime.Today)
                MessageBox.Show(Me, "Thank you for replacing thermocouples.", "Replacement Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLotID1.Text = ""
                txtThermocoupleID1.Text = ""
                txtLotID2.Text = ""
                txtThermocoupleID2.Text = ""
            ElseIf GlobalSettings.CurrentFurnace = 9 Then
                GlobalSettings.FurnaceV9List.Clear()
                GlobalSettings.FurnaceV9Thermocouple1.LotID(ToInt32(txtLotID1.Text))
                GlobalSettings.FurnaceV9Thermocouple1.ThermocoupleID(ToInt32(txtThermocoupleID1.Text))
                GlobalSettings.FurnaceV9Thermocouple2.LotID(ToInt32(txtLotID2.Text))
                GlobalSettings.FurnaceV9Thermocouple2.ThermocoupleID(ToInt32(txtThermocoupleID2.Text))
                GlobalSettings.FurnaceV9Thermocouple1.DateIssued(System.DateTime.Today)
                GlobalSettings.FurnaceV9Thermocouple1.MaxDate(System.DateTime.Today)
                MessageBox.Show(Me, "Thank you for replacing thermocouples.", "Replacement Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLotID1.Text = ""
                txtThermocoupleID1.Text = ""
                txtLotID2.Text = ""
                txtThermocoupleID2.Text = ""
            End If
        Catch
            MessageBox.Show(Me, "Inputs are invalid. Check ID numbers and try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmNewThermocouple_Load(sender As Object, e As EventArgs) Handles Me.Load
        If GlobalSettings.CurrentFurnace = 8 Or GlobalSettings.CurrentFurnace = 9 Then
            txtLotID2.Enabled = True
            txtThermocoupleID2.Enabled = True
        End If
    End Sub

    Private Sub btnNewThermocoupleDone_Click(sender As Object, e As EventArgs) Handles btnNewThermocoupleDone.Click
        txtLotID2.Enabled = False
        txtThermocoupleID2.Enabled = False
        Me.Close()
        frmChooseForm.Activate()
    End Sub
End Class