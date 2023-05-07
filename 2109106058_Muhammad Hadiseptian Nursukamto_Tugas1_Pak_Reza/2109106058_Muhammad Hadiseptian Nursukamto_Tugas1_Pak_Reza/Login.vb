Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrStart.Start()
        lblGagalLogin.Visible = False
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub

    Private Sub tmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity = Me.Opacity + 0.2
        End If
    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.MediumSeaGreen
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.White
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Then
            txtUsername.Focus()
            Return
        ElseIf txtPassword.Text = "" Then
            txtPassword.Focus()
            Return
        End If

        If txtUsername.Text = "hadi" And txtPassword.Text = "123" Then
            App.Show()
            Me.Close()
        Else
            tmrTurun.Enabled = True
            tmrNaik.Enabled = False
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub tmrTurun_Tick(sender As Object, e As EventArgs) Handles tmrTurun.Tick
        If Me.Height < 435 Then
            Me.Height = Int(Me.Height + 5)
        Else
            Me.Height = 435
            tmrDurasi.Enabled = True
            lblGagalLogin.Visible = True
        End If
    End Sub

    Private Sub tmrNaik_Tick(sender As Object, e As EventArgs) Handles tmrNaik.Tick
        If Me.Height > 366 Then
            Me.Height = Int(Me.Height - 5)
        Else
            Me.Height = 366
            tmrDurasi.Enabled = False
            lblGagalLogin.Visible = False
        End If
    End Sub

    Private Sub tmrDurasi_Tick(sender As Object, e As EventArgs) Handles tmrDurasi.Tick
        tmrTurun.Enabled = False
        tmrNaik.Enabled = True
    End Sub
End Class