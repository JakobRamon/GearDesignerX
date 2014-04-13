Public Class gear

    'outgoing variables for calculation sheets
    Private _mat As material '_mat.sigma for MathCad -> shaft geomatry
    Private _r As Double    'Radius as RD for MathCad -> gear geometry
    Private _m As Double    'module as m for MathCad -> gear geometry
    Private _t As Double    'torque as M for MathCad -> Shaft diameter
    Private _d As Double    'Shaft diameter

    Public shaft As shaft


    'incoming from calculation / outgoing variables for CATIA

    Public Sub New(ByVal mat As material, modulus As Double, distance As Double, tOwn As Double, tOther As Double)
        _m = modulus
        _r = distance * (1 - 1 / tOwn * tOther)
        _t = tOwn
        _mat = mat
        getShaft()
    End Sub


    Private Sub getShaft()
        Dim sigma As Double = _mat.Sigma
        'here communication with mathcad script
        'in: t, sigma
        'out: d
        '************

        'since mathcad does not run on my machine, i assume _d=10. =)
        _d = 10
        shaft = New shaft(_d)
    End Sub


End Class
