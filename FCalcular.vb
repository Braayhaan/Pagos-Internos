Public Class FCalcular
    Private Sub FCalcular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = My.Settings.FFechaPago
        CantTar.Text = My.Settings.FCantTar
        CantFuen.Text = My.Settings.FCantFuen
        CantFan.Text = My.Settings.FCantFan
        CantMant.Text = My.Settings.FCantMant
        TotalTarj.Text = My.Settings.FTotalTarj
        TotalFuen.Text = My.Settings.FTotalFuen
        TotalFan.Text = My.Settings.FTotalFan
        TotalMant.Text = My.Settings.FTotalMant
        UltPago.Text = My.Settings.FUltPagoGuard
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
        My.Settings.FCantTar = CantTar.Text
        My.Settings.FCantFuen = CantFuen.Text
        My.Settings.FCantFan = CantFan.Text
        My.Settings.FCantMant = CantMant.Text
        My.Settings.FTotalTarj = TotalTarj.Text
        My.Settings.FTotalFuen = TotalFuen.Text
        My.Settings.FTotalFan = TotalFan.Text
        My.Settings.FTotalMant = TotalMant.Text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UltPago.Text = TotalTotal.Text
        My.Settings.FFechaPago = Date.Now
        My.Settings.FCantTar = CantTar.Text
        My.Settings.FCantFuen = CantFuen.Text
        My.Settings.FCantFan = CantFan.Text
        My.Settings.FCantMant = CantMant.Text
        My.Settings.FTotalTarj = TotalTarj.Text
        My.Settings.FTotalFuen = TotalFuen.Text
        My.Settings.FTotalFan = TotalFan.Text
        My.Settings.FTotalMant = TotalMant.Text
        My.Settings.FUltPagoGuard = TotalTotal.Text
        Label7.Text = My.Settings.FFechaPago
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If CantTar.Text = "0" And CantFuen.Text = "0" And CantFan.Text = "0" And CantMant.Text = "0" Then
            Button10.Enabled = False
        Else
            Button10.Enabled = True
        End If
    End Sub
End Class