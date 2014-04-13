Public Class shaft
    Private excelSheet As String = My.Computer.FileSystem.CurrentDirectory & "\calculationFiles\KeyDesign.xlsx"
    Private _d As Double    'Shaft diameter 
    Public Property diameter As Double
        Get
            Return _d
        End Get
        Set(value As Double)
            _d = value
        End Set
    End Property

    Private _w As Single    'key width
    Public Property keyWidth As Double
        Get
            Return _w
        End Get
        Set(value As Double)
            _w = value
        End Set
    End Property

    Private _h As Single    'key height
    Public Property keyHeight As Double
        Get
            Return _h
        End Get
        Set(value As Double)
            _h = value
        End Set
    End Property

    Private _c1 As Double   'key slot height shaft
    Public Property keyC1 As Double
        Get
            Return _c1
        End Get
        Set(value As Double)
            _c1 = value
        End Set
    End Property

    Private _c2 As Double   'key slot height gear
    Public Property keyC2 As Double
        Get
            Return _c2
        End Get
        Set(value As Double)
            _c2 = value
        End Set
    End Property

    Public Sub New(diameter As Double)
        _d = diameter
        getKey()
    End Sub

    Private Sub getKey()
        'here communication with Excel script
        'in: d
        'out: w, h, c1, c2
        '************
        Dim ExcelApp As New Microsoft.Office.Interop.Excel.Application
        Try
            ExcelApp = GetObject(, "Excel.Application")
        Catch ex As Exception
            ExcelApp = CreateObject("Excel.Application", )
        End Try

        ExcelApp.Visible = True

        Dim opened As Boolean
        Dim calcWB As Microsoft.Office.Interop.Excel.Workbook
        For Each W As Microsoft.Office.Interop.Excel.Workbook In ExcelApp.Workbooks
            If W.FullName = excelSheet Then
                opened = True
                calcWB = W
                Exit For
            End If
        Next
        If opened = False Then
            calcWB = ExcelApp.Workbooks.Open(excelSheet)
        End If
        Dim WS As Microsoft.Office.Interop.Excel.Worksheet
        WS = calcWB.Sheets("Sheet1")

        Dim row As Integer = 10

        While row < 36
            If WS.Cells(row, 3).value >= _d Then
                Exit While
            End If
            row += 1
        End While
        _w = WS.Cells(row, 4).value
        _h = WS.Cells(row, 5).value
        _c1 = WS.Cells(row, 6).value
        _c2 = WS.Cells(row, 7).value
    End Sub
End Class
