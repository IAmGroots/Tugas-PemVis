﻿Public Class App
    Inherits Form

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.5
        Me.PrintPreviewDialog1.WindowState = WindowState.Maximized

        cmbJenis.SelectedIndex = 0
    End Sub

    Private Sub txtIdSertifikat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdSertifikat.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(13) Then
            txtNama.Focus()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNIK.Focus()
        End If
    End Sub

    Private Sub txtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIK.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(13) Then
            dtpTtl.Focus()
        End If
    End Sub

    Private Sub dtpTtl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpTtl.KeyPress
        If e.KeyChar = Chr(13) Then
            dtpTglVaksin.Focus()
        End If
    End Sub
    Private Sub dtpTglVaksin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpTglVaksin.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbJenis.Focus()
        End If
    End Sub

    Private Sub cmbJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbJenis.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtIdSertifikat.Text = "" Then
            txtIdSertifikat.Focus()
            Return
        ElseIf txtNama.Text = "" Then
            txtNama.Focus()
            Return
        ElseIf txtNama.Text = "" Then
            txtNIK.Focus()
            Return
        End If
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim f As Font = New Font("Times New Roman", 14, FontStyle.Bold)
        Dim br As SolidBrush = New SolidBrush(Color.Black) 'br = adalah warna font
        Dim p As Pen = New Pen(Color.Black) 'p = adalah warna garis kotak

        Dim judul As String = "                 SERTIFIKAT VAKSIN"
        Dim idSertifikat As String = "ID Sertifikat " & vbTab & ": " & txtIdSertifikat.Text
        Dim namaLengkap As String = "Nama Lengkap " & vbTab & ": " & txtNama.Text
        Dim nik As String = "NIK " & vbTab & vbTab & ": " & txtNIK.Text
        Dim ttl As String = "Tanggal Lahir " & vbTab & ": " & dtpTtl.Text
        Dim tglVaksin As String = "Tanggal Vaksin " & vbTab & ": " & dtpTglVaksin.Text
        Dim jenisVaksin As String = "Jenis Vaksin " & vbTab & ": " & cmbJenis.Text

        e.Graphics.DrawString(judul, f, br, 220, 60)
        e.Graphics.DrawString(idSertifikat, f, br, 220, 90)
        e.Graphics.DrawString(namaLengkap, f, br, 220, 120)
        e.Graphics.DrawString(nik, f, br, 220, 150)
        e.Graphics.DrawString(ttl, f, br, 220, 180)
        e.Graphics.DrawString(tglVaksin, f, br, 220, 210)
        e.Graphics.DrawString(jenisVaksin, f, br, 220, 240)
        e.Graphics.DrawRectangle(p, 210, 50, 405, 220)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtIdSertifikat.Clear()
        txtNama.Clear()
        txtNIK.Clear()
        cmbJenis.SelectedIndex = 0
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles btnSave.MouseEnter
        btnSave.BackColor = Color.LightGreen
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackColor = Color.White
    End Sub

    Private Sub btnReset_MouseEnter(sender As Object, e As EventArgs) Handles btnReset.MouseEnter
        btnReset.BackColor = Color.Tomato
    End Sub

    Private Sub btnReset_MouseLeave(sender As Object, e As EventArgs) Handles btnReset.MouseLeave
        btnReset.BackColor = Color.White
    End Sub
End Class
