Public Class gearBox

    Private _name As String
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Private _id As Integer
    Public ReadOnly Property ID As Integer
        Get
            Return _id
        End Get
    End Property
    Private _mat1 As material
    Public Property Material1 As material
        Get
            Return _mat1
        End Get
        Set(value As material)
            _mat1 = value
        End Set
    End Property
    Private _mat2 As material
    Public Property Material2 As material
        Get
            Return _mat2
        End Get
        Set(value As material)
            _mat2 = value
        End Set
    End Property
    Private _d As Double
    Public Property Distance As Double
        Get
            Return _d
        End Get
        Set(value As Double)
            _d = value
        End Set
    End Property
    Private _m As Double
    Public Property Modulus As Double
        Get
            Return _m
        End Get
        Set(value As Double)
            _m = value
        End Set
    End Property
    Private _t1 As Double
    Public Property Torque1 As Double
        Get
            Return _t1
        End Get
        Set(value As Double)
            _t1 = value
        End Set
    End Property
    Private _t2 As Double
    Public Property Torque2 As Double
        Get
            Return _t2
        End Get
        Set(value As Double)
            _t2 = value
        End Set
    End Property

    'gear: New(ByVal mat As material, modulus As Double, distance As Double, tOwn As Double, tOther As Double)
    Public Gear1 As New gear(_mat1, _m, _d, _t1, _t2)

    Public Gear2 As New gear(_mat2, _m, _d, _t2, _t1)

    'Public Sub New(ByVal mat1 As material, mat2 As material, modulus As Double, distance As Double, t1 As Double, t2 As Double)
    '   _m = modulus
    '   _d = distance
    '   _t1 = t1
    '   _t2 = t2
    '   _mat1 = mat1
    '   _mat2 = mat2
    'End Sub

    Public Function createCAD()
        Return 0
    End Function

End Class
