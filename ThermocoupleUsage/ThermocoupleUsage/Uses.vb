Option Strict On
Public Class Uses

    Public HiddenWorkOrder As Integer
    Public HiddenTemperature As Integer
    Public HiddenDate As Date

    Public Sub WorkOrder(argValue As Integer)
        HiddenWorkOrder = argValue
    End Sub

    Public Sub Temp(argValue As Integer)
        HiddenTemperature = argValue
    End Sub

    Public Sub DateOfUse(argValue As Date)
        HiddenDate = argValue
    End Sub
End Class
