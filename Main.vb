Public Class CryptArch
    Private Sub CryptArch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusTextBox.Text = ">Initialized at :" + Now.ToLongTimeString
    End Sub
End Class