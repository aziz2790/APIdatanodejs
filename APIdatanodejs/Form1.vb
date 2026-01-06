Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Data

Public Class txtItemNamaCustomer

    Private token As String = ""
    Private Sub btnget_Click(sender As Object, e As EventArgs) Handles btnget.Click
        If token = "" Then
            MessageBox.Show("Silakan login terlebih dahulu.")
            Return
        End If

        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://localhost:5000/api/auth/datapasien"), HttpWebRequest)
            request.Method = "GET"
            request.Headers.Add("Authorization", "Bearer " & token)

            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

            Using reader As New StreamReader(response.GetResponseStream())
                Dim jsonResponse As String = reader.ReadToEnd()

                Dim serializer As New JavaScriptSerializer()
                Dim pasien As List(Of Dictionary(Of String, Object)) = serializer.Deserialize(Of List(Of Dictionary(Of String, Object)))(jsonResponse)

                Dim table As New DataTable()
                table.Columns.Add("NoMR")
                table.Columns.Add("NamaPasien")
                table.Columns.Add("Tanggal")
                table.Columns.Add("namacustumer")

                For Each user In pasien
                    Dim noMR As String = If(user.ContainsKey("NoMR"), user("NoMR").ToString(), "")
                    Dim nama As String = If(user.ContainsKey("NamaPasien"), user("NamaPasien").ToString(), "")
                    Dim rawDate As String = If(user.ContainsKey("Tanggal"), user("Tanggal").ToString(), "")
                    Dim formattedDate As String = ""
                    If rawDate <> "" Then
                        Dim dt As DateTime
                        If DateTime.TryParse(rawDate, dt) Then
                            formattedDate = dt.ToString("dd/MM/yyyy")
                        End If
                    End If
                    Dim customer As String = If(user.ContainsKey("namacustumer") AndAlso user("namacustumer") IsNot Nothing, user("namacustumer").ToString(), "")

                    table.Rows.Add(noMR, nama, formattedDate, customer)
                Next

                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If txtuser.Text = "" Or txtpasword.Text = "" Then
                MessageBox.Show("Silakan masukan username dan password ")
                Return
            End If
            Dim loginUrl As String = "http://localhost:5000/api/auth/login"
            Dim loginJson As String = "{""username"":""" & txtuser.Text & """, ""password"":""" & txtpasword.Text & """}"

            Dim loginRequest As HttpWebRequest = DirectCast(WebRequest.Create(loginUrl), HttpWebRequest)
            loginRequest.Method = "POST"
            loginRequest.ContentType = "application/json"

            Using writer As New StreamWriter(loginRequest.GetRequestStream())
                writer.Write(loginJson)
            End Using

            Dim loginResponse As HttpWebResponse = DirectCast(loginRequest.GetResponse(), HttpWebResponse)

            Using reader As New StreamReader(loginResponse.GetResponseStream())
                Dim result As String = reader.ReadToEnd()

                ' Ambil token dari response JSON
                Dim serializer As New JavaScriptSerializer()
                Dim responseData As Dictionary(Of String, Object) = serializer.Deserialize(Of Dictionary(Of String, Object))(result)
                token = responseData("token").ToString()

                ' Tampilkan status login
                Label6.Text = txtuser.Text & " Login Aktif"
                Label6.ForeColor = Color.Green
                txtuser.Clear()
                txtpasword.Clear()

                MessageBox.Show("Login berhasil. Token disimpan.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Login gagal: " & ex.Message)
        End Try
    End Sub
    Private Sub btngetinput_Click(sender As Object, e As EventArgs) Handles btngetinput.Click
        If token = "" Then
            MessageBox.Show("Silakan login terlebih dahulu.")
            Return
        End If

        If txtnomr.Text = "" Then
            MessageBox.Show("Silakan isi ID terlebih dahulu.")
            Return
        End If

        Try
            Dim userId As String = txtnomr.Text
            Dim url As String = txturl.Text & userId

            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Headers.Add("Authorization", "Bearer " & token)

            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

            Using reader As New StreamReader(response.GetResponseStream())
                Dim result As String = reader.ReadToEnd()

                ' Jika response kosong, tampilkan pesan error
                If String.IsNullOrEmpty(result) Then
                    MessageBox.Show("Respons dari server kosong. Data user tidak ditemukan.")
                    Return
                End If

                Dim serializer As New JavaScriptSerializer()
                Dim userData As Dictionary(Of String, Object) = serializer.Deserialize(Of Dictionary(Of String, Object))(result)

                ' Validasi apakah userData berisi key yang dibutuhkan
                If userData Is Nothing OrElse Not userData.ContainsKey("NamaPasien") Then
                    MessageBox.Show("Data user tidak ditemukan. Pastikan ID yang dimasukkan benar.")
                    Return
                End If

                ' Set textBox dengan pengecekan agar tidak terjadi NullReferenceException
                txtnama.Text = If(userData("NamaPasien") IsNot Nothing, userData("NamaPasien").ToString(), "")
                If userData("Tanggal") IsNot Nothing Then
                    Dim rawTanggal As String = userData("Tanggal").ToString()
                    Dim tanggalFormatted As String = DateTime.Parse(rawTanggal).ToString("dd/MM/yyyy")
                    txttanggal.Text = tanggalFormatted
                Else
                    txttanggal.Text = ""
                End If

                txtrumahsakit.Text = If(userData("namacustumer") IsNot Nothing, userData("namacustumer").ToString(), "")
            End Using

        Catch ex As WebException
            Dim httpResponse As HttpWebResponse = TryCast(ex.Response, HttpWebResponse)

            ' Jika server mengembalikan 404 Not Found
            If httpResponse IsNot Nothing AndAlso httpResponse.StatusCode = HttpStatusCode.NotFound Then
                MessageBox.Show("ID tidak ditemukan di database.")
            Else
                MessageBox.Show("Gagal mengambil data: " & ex.Message)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi error: " & ex.Message)
        End Try
    End Sub
    Private Sub txtpasword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpasword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnlogin.PerformClick()
        End If
    End Sub
    Public Sub SetToken(ByVal newToken As String, ByVal username As String)
        token = newToken
        Label6.Text = username & " Aktif Login"
        Label6.ForeColor = Color.Green
    End Sub
    Private Sub btnfromlogin_Click(sender As Object, e As EventArgs) Handles btnfromlogin.Click
        Dim loginForm As New LoginForm()
        loginForm.ShowDialog()
    End Sub
    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomr.KeyPress
        If e.KeyChar = Chr(13) Then
            btngetinput.PerformClick()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CekKoneksiAPI()
        tampildata()
    End Sub
    Private Sub CekKoneksiAPI()
        Dim apiUrl As String = "http://localhost:5000/api/auth/ping" ' endpoint dummy yang ringan
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(apiUrl), HttpWebRequest)
            request.Method = "GET"
            request.Timeout = 3000 ' 3 detik timeout cepat

            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then
                Label7.Text = "Terkoneksi ke API"
                Label7.ForeColor = Color.Green
            Else
                Label7.Text = "API tidak merespon"
                Label7.ForeColor = Color.Orange
            End If
        Catch ex As Exception
            Label7.Text = "Tidak dapat terhubung ke API"
            Label7.ForeColor = Color.Red
        End Try
    End Sub
    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If txtnama.Text = "" Then
            MessageBox.Show("Silakan GET data terlebih dahulu.")
            Return
        End If
        ' Ambil nilai dari textbox
        Dim noMR As String = txtnomr.Text.PadLeft(8, "0"c)
        Dim nama As String = txtnama.Text
        Dim tanggal As String = txttanggal.Text
        Dim rumahSakit As String = txtrumahsakit.Text

        ' Tambahkan ke baris baru di DataGridView2
        DataGridView2.Rows.Add(noMR, nama, tanggal, rumahSakit)

        ' (Opsional) Kosongkan textbox setelah tambah
        txtnomr.Clear()
        txtnama.Clear()
        txttanggal.Clear()
        txtrumahsakit.Clear()
    End Sub
    Private Sub tampildata()
        With DataGridView2
            .Columns.Add("NoMR", "NoMR")
            .Columns.Add("NamaPasien", "Nama Pasien")
            .Columns.Add("Tanggal", "Tanggal")
            .Columns.Add("RumahSakit", "Rumah Sakit")
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim nomr As String = txtnomr.Text
            Dim url As String = "http://localhost:5000/api/auth/apiKey/datapasien/" & nomr

            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Headers.Add("x-api-key", "rahasiabanget123")


            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

            Using reader As New StreamReader(response.GetResponseStream())
                Dim result As String = reader.ReadToEnd()

                ' Jika response kosong, tampilkan pesan error
                If String.IsNullOrEmpty(result) Then
                    MessageBox.Show("Respons dari server kosong. Data user tidak ditemukan.")
                    Return
                End If

                Dim serializer As New JavaScriptSerializer()
                Dim userData As Dictionary(Of String, Object) = serializer.Deserialize(Of Dictionary(Of String, Object))(result)

                ' Validasi apakah userData berisi key yang dibutuhkan
                If userData Is Nothing OrElse Not userData.ContainsKey("NamaPasien") Then
                    MessageBox.Show("Data user tidak ditemukan. Pastikan ID yang dimasukkan benar.")
                    Return
                End If

                ' Set textBox dengan pengecekan agar tidak terjadi NullReferenceException
                txtnama.Text = If(userData("NamaPasien") IsNot Nothing, userData("NamaPasien").ToString(), "")
                If userData("Tanggal") IsNot Nothing Then
                    Dim rawTanggal As String = userData("Tanggal").ToString()
                    Dim tanggalFormatted As String = DateTime.Parse(rawTanggal).ToString("dd/MM/yyyy")
                    txttanggal.Text = tanggalFormatted
                Else
                    txttanggal.Text = ""
                End If

                txtrumahsakit.Text = If(userData("namacustumer") IsNot Nothing, userData("namacustumer").ToString(), "")
            End Using

        Catch ex As WebException
            Dim httpResponse As HttpWebResponse = TryCast(ex.Response, HttpWebResponse)

            ' Jika server mengembalikan 404 Not Found
            If httpResponse IsNot Nothing AndAlso httpResponse.StatusCode = HttpStatusCode.NotFound Then
                MessageBox.Show("ID tidak ditemukan di database.")
            Else
                MessageBox.Show("Gagal mengambil data: " & ex.Message)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnsetingapi_Click(sender As Object, e As EventArgs) Handles btnsetingapi.Click
        FormSettingAPI.Show()
    End Sub
End Class
