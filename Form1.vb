Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim water, initial, final, energy As Double
        Const eq As Integer = 4184
        water = CDbl(txtWater.Text)
        initial = CDbl(txtInitial.Text)
        final = CDbl(txtFinal.Text)
        energy = CDbl(water * (final - initial) * eq)
        txtEnergy.Text = String.Format("{0:N2}", energy)
    End Sub
End Class
