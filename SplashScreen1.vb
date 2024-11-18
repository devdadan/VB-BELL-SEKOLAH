Imports MySql.Data.MySqlClient
Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_produc.Text = "Sistem Bell Otomatis v." + Application.ProductVersion
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Pb_Loading.Value < 100 Then

            Pb_Loading.Value += 2

        ElseIf Pb_Loading.Value = 100 Then
            Timer1.Stop()
            cekdlu()
            Form_depan.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub cekdlu()
        Dim ini As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL", "host", "")
        If ini = "" Then

            Dim tanya As DialogResult = MessageBox.Show("Database belum disetting,setting sekarang", "WARNING", MessageBoxButtons.YesNo)
            If (tanya = DialogResult.Yes) Then
                Form_db.ShowDialog()
            Else
                Me.Close()
            End If
        End If
        koneksi()
        Try
            sql = "CREATE TABLE if not exists `jadwal` (
                      `Id` int(11) NOT NULL AUTO_INCREMENT,
                      `Hari` varchar(10) NOT NULL,
                      `Keterangan` varchar(300) NOT NULL DEFAULT '',
                      `Jam` time NOT NULL,
                      `AudioFile` varchar(200) NOT NULL DEFAULT '',
                      KEY `Id` (`Id`)
                    ) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1"
            Cmd = New MySqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()
            Cmd.Dispose()


            sql = "CREATE TABLE if not exists `pengaturan` (
                  `flag_hari` varchar(20) NOT NULL,
                  `hari` varchar(20) DEFAULT NULL,
                  PRIMARY KEY (`flag_hari`)
                ) ENGINE=InnoDB DEFAULT CHARSET=latin1"
            Cmd = New MySqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()
            Cmd.Dispose()

            sql = "select count(*) from pengaturan"
            Cmd = New MySqlCommand(sql, Conn)
            If Cmd.ExecuteScalar() = 0 Then
                sql = "insert into pengaturan (flag_hari) values ('1')"
                Cmd = New MySqlCommand(sql, Conn)
                Cmd.ExecuteNonQuery()

            End If

        Catch ex As Exception
            MsgBox("KESALAHAN SAAT CEK DATA MASTER", MsgBoxStyle.Critical, "WARNING")
            Me.Close()
        End Try
    End Sub
End Class
