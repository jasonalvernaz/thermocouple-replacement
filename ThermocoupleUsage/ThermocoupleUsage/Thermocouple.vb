Option Strict On
Imports System.Convert
Public Class Thermocouple

    Private HiddenLotID As Integer
    Private HiddenThermocoupleID As Integer
    Private HiddenDateIssued As Date
    Private HiddenMaxDate As Date


    Public Sub LotID(argValue As Integer)
        HiddenLotID = argValue
    End Sub

    Public Sub ThermocoupleID(argValue As Integer)
        HiddenThermocoupleID = argValue
    End Sub

    Public Sub DateIssued(argValue As Date)
        HiddenDateIssued = argValue
    End Sub

    Public Sub MaxDate(argValue As Date)
        HiddenMaxDate = argValue.AddMonths(3)
    End Sub

    Public ReadOnly Property ThermocoupleSN As String
        Get
            ThermocoupleSN = HiddenLotID.ToString & "-" & HiddenThermocoupleID.ToString()
        End Get
    End Property

    Public ReadOnly Property ReadDateIssued As String
        Get
            ReadDateIssued = HiddenDateIssued.ToShortDateString()
        End Get
    End Property

    Public ReadOnly Property ReadMaxDate As String
        Get
            ReadMaxDate = HiddenMaxDate.ToShortDateString()
        End Get
    End Property

End Class
