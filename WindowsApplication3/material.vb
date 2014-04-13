Public Class material
    Private _name As String
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Private _sigma As Double
    Public Property Sigma As Double
        Get
            Return _sigma
        End Get
        Set(value As Double)
            _sigma = value
        End Set
    End Property
    Public Sub New(name As String, sigma As Double)
        _name = name
        _sigma = sigma
    End Sub

    'for proper display in combobox:
    Public Overrides Function ToString() As String
        Return _name
    End Function
End Class
