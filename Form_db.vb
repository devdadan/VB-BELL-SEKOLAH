Imports MySql.Data.MySqlClient
Public Class Form_db
    Private Sub Form_db_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilreg()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If txt_host.Text = "" Or txt_user.Text = "" Or txt_db.Text = "" Then
            MsgBox("Harap lengkapi data", MsgBoxStyle.Critical, "WARNING")
        Else
            Try
                Dim MyDB As String = "Server=" + txt_host.Text + ";user id=" + txt_user.Text + ";password=" + txt_pass.Text + ";database=" + txt_db.Text + ""
                Conn = New MySqlConnection(MyDB)
                If Conn.State = ConnectionState.Closed Then Conn.Open()


                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Host", txt_host.Text)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "User", txt_user.Text)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Pass", txt_pass.Text)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Db", txt_db.Text)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "SEKOLAH", txt_namasekolah.Text)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "LOGO", TextBox2.Text)

                MsgBox("Selesai simpan data,aplikasi akan direstart", MsgBoxStyle.Information, "INFO")
                tampilreg()
                ClassBell.kill("Restart.bat")
            Catch ex As Exception
                MsgBox("Tidak bisa terkoneksi ke database, harap pastikan koneksi sudah benar", MsgBoxStyle.Critical, "WARNING")
                txt_db.Clear()
                txt_host.Clear()
                txt_user.Clear()
                txt_pass.Clear()
            End Try
        End If
    End Sub
    Sub tampilreg()
        txt_host.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Host", Nothing)
        txt_user.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "User", Nothing)
        txt_pass.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Pass", Nothing)
        txt_db.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Db", Nothing)
        txt_namasekolah.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "SEKOLAH", Nothing)
        TextBox2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Logo", Nothing)

    End Sub


    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox2.MouseClick
        OpenFileDialog1.Filter = "*.jpg|"
        OpenFileDialog1.ShowDialog()
        TextBox2.Text = OpenFileDialog1.FileName

    End Sub
End Class