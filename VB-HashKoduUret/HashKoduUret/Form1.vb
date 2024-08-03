Imports System.Security.Cryptography
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HashAlgoritmaCBox.SelectedIndex = 0
    End Sub

    Private Sub HashAlgoritmaCBox_DropDownClosed(sender As Object, e As EventArgs) Handles HashAlgoritmaCBox.DropDownClosed
        Dim Metin As String = MetinTBox.Text
        Dim Kod As String = ""
        Dim Uzunluk As Integer
        Select Case HashAlgoritmaCBox.SelectedItem.ToString.Trim
            Case "MD5"
                Kod = HashAlgoritmasiUret(Metin, MD5.Create)
            Case "SHA1"
                Kod = HashAlgoritmasiUret(Metin, SHA1.Create)
            Case "SHA256"
                Kod = HashAlgoritmasiUret(Metin, SHA256.Create)
            Case "SHA384"
                Kod = HashAlgoritmasiUret(Metin, SHA384.Create)
            Case "SHA512"
                Kod = HashAlgoritmasiUret(Metin, SHA512.Create)
            Case Else
                MessageBox.Show("Bir algoritma seçimi yapılmadı. Lütfen bir algoritma seçiniz.", "Uyarı")
        End Select
        Uzunluk = Kod.Length
        HashKoduTBox.Text = Kod
        UzunlukTBox.Text = Uzunluk
        HashAlgoritmaCBox.SelectedIndex = 0
    End Sub

    Private Sub KopyalaBtn_Click(sender As Object, e As EventArgs) Handles KopyalaBtn.Click
        Clipboard.SetText(HashKoduTBox.Text)
    End Sub
End Class
