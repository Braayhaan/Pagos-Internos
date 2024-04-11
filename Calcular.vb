Imports Pagos_Internos.My

Public Class Calcular
    Private Sub Felix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = My.Settings.FechaPago
        CantTar.Text = My.Settings.CantTar
        CantFuen.Text = My.Settings.CantFuen
        CantFan.Text = My.Settings.CantFan
        CantMant.Text = My.Settings.CantMant
        TotalTarj.Text = My.Settings.TotalTarj
        TotalFuen.Text = My.Settings.TotalFuen
        TotalFan.Text = My.Settings.TotalFan
        TotalMant.Text = My.Settings.TotalMant
        UltPago.Text = My.Settings.UltPagoGuard
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CantTar.Text = Val(CantTar.Text) + 1
        TotalTarj.Text = CantTar.Text * 3
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CantTar.Text = Val(CantTar.Text) - 1
        TotalTarj.Text = CantTar.Text * 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CantFuen.Text = Val(CantFuen.Text) + 1
        TotalFuen.Text = CantFuen.Text * 5
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CantFuen.Text = Val(CantFuen.Text) - 1
        TotalFuen.Text = CantFuen.Text * 5
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CantFan.Text = Val(CantFan.Text) + 1
        TotalFan.Text = CantFan.Text * 2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CantFan.Text = Val(CantFan.Text) - 1
        TotalFan.Text = CantFan.Text * 2
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CantMant.Text = Val(CantMant.Text) + 1
        TotalMant.Text = CantMant.Text * 2
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CantMant.Text = Val(CantMant.Text) - 1
        TotalMant.Text = CantMant.Text * 2
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TotalTotal.Text = Val(TotalTarj.Text) + Val(TotalFuen.Text) + Val(TotalFan.Text) + Val(TotalMant.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        CantTar.Text = "0"
        CantFuen.Text = "0"
        CantFan.Text = "0"
        CantMant.Text = "0"
        TotalTarj.Text = "0"
        TotalFuen.Text = "0"
        TotalFan.Text = "0"
        TotalMant.Text = "0"
        My.Settings.CantTar = CantTar.Text
        My.Settings.CantFuen = CantFuen.Text
        My.Settings.CantFan = CantFan.Text
        My.Settings.CantMant = CantMant.Text
        My.Settings.TotalTarj = TotalTarj.Text
        My.Settings.TotalFuen = TotalFuen.Text
        My.Settings.TotalFan = TotalFan.Text
        My.Settings.TotalMant = TotalMant.Text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UltPago.Text = TotalTotal.Text
        My.Settings.FechaPago = Date.Now
        My.Settings.CantTar = CantTar.Text
        My.Settings.CantFuen = CantFuen.Text
        My.Settings.CantFan = CantFan.Text
        My.Settings.CantMant = CantMant.Text
        My.Settings.TotalTarj = TotalTarj.Text
        My.Settings.TotalFuen = TotalFuen.Text
        My.Settings.TotalFan = TotalFan.Text
        My.Settings.TotalMant = TotalMant.Text
        My.Settings.UltPagoGuard = TotalTotal.Text
        Label7.Text = My.Settings.FechaPago
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If CantTar.Text = "0" And CantFuen.Text = "0" And CantFan.Text = "0" And CantMant.Text = "0" Then
            Button10.Enabled = False
        Else
            Button10.Enabled = True
        End If
    End Sub
End Class