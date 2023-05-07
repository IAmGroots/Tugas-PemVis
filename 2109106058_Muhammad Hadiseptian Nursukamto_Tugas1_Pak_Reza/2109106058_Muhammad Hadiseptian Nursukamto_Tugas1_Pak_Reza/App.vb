Public Class App
    Dim PATH_GAMBAR As String = CurDir() & "/rumus.png"
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = PATH_GAMBAR
        txtKecepatan.Focus()
        tmrFinish.Stop()
    End Sub

    Private Sub txtKecepatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKecepatan.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(13) Then
            txtJari.Focus()
        End If
    End Sub

    Private Sub txtJari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJari.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(13) Then
            btnHitung.PerformClick()
        End If
    End Sub

    Private Sub btnHitung_MouseEnter(sender As Object, e As EventArgs) Handles btnHitung.MouseEnter
        btnHitung.BackColor = Color.MediumSeaGreen
    End Sub

    Private Sub btnHitung_MouseLeave(sender As Object, e As EventArgs) Handles btnHitung.MouseLeave
        btnHitung.BackColor = Color.White
    End Sub

    Private Sub btnKeluar_MouseEnter(sender As Object, e As EventArgs) Handles btnKeluar.MouseEnter
        btnKeluar.BackColor = Color.Tomato
    End Sub

    Private Sub btnKeluar_MouseLeave(sender As Object, e As EventArgs) Handles btnKeluar.MouseLeave
        btnKeluar.BackColor = Color.White
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If txtKecepatan.Text = "" Then
            txtKecepatan.Focus()
            Return
        ElseIf txtJari.Text = "" Or txtJari.Text = "0" Then
            txtJari.Focus()
            Return
        End If

        Dim hasil As Double = txtKecepatan.Text * txtKecepatan.Text / txtJari.Text
        txtHasil.Text = hasil
        txtKecepatan.Text = ""
        txtJari.Text = ""
        txtHasil.FlatAppearance.BorderColor = Color.MediumSeaGreen
        btnHitung.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        tmrFinish.Start()
    End Sub

    Private Sub tmrFinish_Tick(sender As Object, e As EventArgs) Handles tmrFinish.Tick
        If Me.Opacity <= 1.0 Then
            Me.Opacity = Me.Opacity - 0.2
        End If
        If Me.Opacity = 0.0 Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtKecepatan_Enter(sender As Object, e As EventArgs) Handles txtKecepatan.Enter
        txtHasil.FlatAppearance.BorderColor = Color.Black
    End Sub
End Class
