Public Class shaft
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

    Private _c1 As Single   'key slot height shaft
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
    End Sub
    Private Sub getKey(d As Double)
        'here communication with Excel script
        'in: d
        'out: w, h, c1, c2
        '************
        _w = 0
        _h = 0
        _c1 = 0
        _c2 = 0
    End Sub
End Class
