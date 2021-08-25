Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Navigate("www.gmail.com")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Navigate("www.google.com")
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.Navigate(TextBox1.Text)

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox.Text = ""
    End Sub
End Class


Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    WebBrowser1.Navigate("www.google.com")
End Sub
Private Sub TextBox1_KeyDown(ByVal sender As System.Object, e As EventArgs) Handles TextBox1.KeyDown
    If e.KeyCode = Keys.Enter Then
        WebBrowser1.Navigate(TextBox1.Text)

    End If
End Sub