<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtItemNamaCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnget = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtpasword = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnomr = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.txtrumahsakit = New System.Windows.Forms.TextBox()
        Me.btngetinput = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnsetingapi = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnfromlogin = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btninput = New System.Windows.Forms.Button()
        Me.txturl = New System.Windows.Forms.TextBox()
        Me.txtItemNama = New System.Windows.Forms.TextBox()
        Me.txtItemTanggal = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(187, 210)
        Me.DataGridView1.TabIndex = 0
        '
        'btnget
        '
        Me.btnget.Location = New System.Drawing.Point(12, 163)
        Me.btnget.Name = "btnget"
        Me.btnget.Size = New System.Drawing.Size(75, 23)
        Me.btnget.TabIndex = 1
        Me.btnget.Text = "Ambil Data"
        Me.btnget.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(76, 102)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(100, 23)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'txtpasword
        '
        Me.txtpasword.Location = New System.Drawing.Point(76, 63)
        Me.txtpasword.Name = "txtpasword"
        Me.txtpasword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txtpasword.Size = New System.Drawing.Size(100, 20)
        Me.txtpasword.TabIndex = 4
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(76, 26)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(100, 20)
        Me.txtuser.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'txtnomr
        '
        Me.txtnomr.Location = New System.Drawing.Point(89, 9)
        Me.txtnomr.Name = "txtnomr"
        Me.txtnomr.Size = New System.Drawing.Size(280, 20)
        Me.txtnomr.TabIndex = 7
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(8, 12)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(41, 13)
        Me.id.TabIndex = 8
        Me.id.Text = "No MR"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(89, 64)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(280, 20)
        Me.txtnama.TabIndex = 9
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(89, 92)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(280, 20)
        Me.txttanggal.TabIndex = 10
        '
        'txtrumahsakit
        '
        Me.txtrumahsakit.Location = New System.Drawing.Point(89, 119)
        Me.txtrumahsakit.Name = "txtrumahsakit"
        Me.txtrumahsakit.Size = New System.Drawing.Size(280, 20)
        Me.txtrumahsakit.TabIndex = 11
        '
        'btngetinput
        '
        Me.btngetinput.Location = New System.Drawing.Point(277, 35)
        Me.btngetinput.Name = "btngetinput"
        Me.btngetinput.Size = New System.Drawing.Size(92, 23)
        Me.btngetinput.TabIndex = 12
        Me.btngetinput.Text = "GET use Login"
        Me.btngetinput.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Rumah sakit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(91, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Belum ada yang login"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtuser)
        Me.Panel1.Controls.Add(Me.txtpasword)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Location = New System.Drawing.Point(326, 236)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 151)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnsetingapi)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.txtrumahsakit)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btngetinput)
        Me.Panel2.Controls.Add(Me.txtnomr)
        Me.Panel2.Controls.Add(Me.txttanggal)
        Me.Panel2.Controls.Add(Me.id)
        Me.Panel2.Controls.Add(Me.txtnama)
        Me.Panel2.Location = New System.Drawing.Point(215, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 152)
        Me.Panel2.TabIndex = 18
        '
        'btnsetingapi
        '
        Me.btnsetingapi.Location = New System.Drawing.Point(8, 38)
        Me.btnsetingapi.Name = "btnsetingapi"
        Me.btnsetingapi.Size = New System.Drawing.Size(75, 23)
        Me.btnsetingapi.TabIndex = 22
        Me.btnsetingapi.Text = "Setting API"
        Me.btnsetingapi.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "GET use KEY API"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnfromlogin
        '
        Me.btnfromlogin.Location = New System.Drawing.Point(12, 124)
        Me.btnfromlogin.Name = "btnfromlogin"
        Me.btnfromlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnfromlogin.TabIndex = 19
        Me.btnfromlogin.Text = "Login"
        Me.btnfromlogin.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Label7"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(215, 193)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(385, 209)
        Me.DataGridView2.TabIndex = 20
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(215, 164)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(385, 23)
        Me.btninput.TabIndex = 16
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'txturl
        '
        Me.txturl.Location = New System.Drawing.Point(12, 408)
        Me.txturl.Name = "txturl"
        Me.txturl.ReadOnly = True
        Me.txturl.Size = New System.Drawing.Size(304, 20)
        Me.txturl.TabIndex = 21
        Me.txturl.Text = "http://localhost:5000/api/auth/datapasien/"
        '
        'txtItemNama
        '
        Me.txtItemNama.Location = New System.Drawing.Point(15, 32)
        Me.txtItemNama.Name = "txtItemNama"
        Me.txtItemNama.Size = New System.Drawing.Size(100, 20)
        Me.txtItemNama.TabIndex = 22
        Me.txtItemNama.Text = "NamaPasien"
        '
        'txtItemTanggal
        '
        Me.txtItemTanggal.Location = New System.Drawing.Point(15, 58)
        Me.txtItemTanggal.Name = "txtItemTanggal"
        Me.txtItemTanggal.Size = New System.Drawing.Size(100, 20)
        Me.txtItemTanggal.TabIndex = 23
        Me.txtItemTanggal.Text = "Tanggal"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Text = "namacustumer"
        '
        'txtItemNamaCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 431)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtItemTanggal)
        Me.Controls.Add(Me.txtItemNama)
        Me.Controls.Add(Me.txturl)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnfromlogin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnget)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "txtItemNamaCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnget As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents txtpasword As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnomr As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtrumahsakit As System.Windows.Forms.TextBox
    Friend WithEvents btngetinput As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnfromlogin As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btninput As System.Windows.Forms.Button
    Friend WithEvents txturl As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnsetingapi As System.Windows.Forms.Button
    Friend WithEvents txtItemNama As System.Windows.Forms.TextBox
    Friend WithEvents txtItemTanggal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
