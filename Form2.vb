Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ipfsver As String


        StatusTextBox.Text = ">Initialized at : " + Now.ToLongTimeString
        Me.ActiveControl = FocusLabel


        'getting ipfs version
        ipfsver = Shell("ipfs version")
        StatusTextBox.Text = ipfsver.ToString

    End Sub
End Class