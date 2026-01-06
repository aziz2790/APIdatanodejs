Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization

Public Class LoginForm
    Public token As String = ""
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                MessageBox.Show("Silakan masukkan username dan password.")
                Return
            End If

            Dim loginUrl As String = "http://localhost:5000/api/auth/login"
            Dim loginJson As String = "{""username"":""" & UsernameTextBox.Text & """, ""password"":""" & PasswordTextBox.Text & """}"

            Dim loginRequest As HttpWebRequest = DirectCast(WebRequest.Create(loginUrl), HttpWebRequest)
            loginRequest.Method = "POST"
            loginRequest.ContentType = "application/json"

            Using writer As New StreamWriter(loginRequest.GetRequestStream())
                writer.Write(loginJson)
            End Using

            Dim loginResponse As HttpWebResponse = DirectCast(loginRequest.GetResponse(), HttpWebResponse)

            Using reader As New StreamReader(loginResponse.GetResponseStream())
                Dim result As String = reader.ReadToEnd()

                Dim serializer As New JavaScriptSerializer()
                Dim responseData As Dictionary(Of String, Object) = serializer.Deserialize(Of Dictionary(Of String, Object))(result)

                token = responseData("token").ToString()

                ' Beri tahu Form1 tokennya
                txtItemNamaCustomer.SetToken(token, UsernameTextBox.Text)

                MessageBox.Show("Login berhasil.")
                Me.Close() ' Tutup LoginForm setelah login sukses
            End Using

        Catch ex As Exception
            MessageBox.Show("Login gagal: " & ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
