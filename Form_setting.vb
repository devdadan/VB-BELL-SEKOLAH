Imports System.IO
Imports MySql.Data.MySqlClient
Imports NAudio.Wave

Public Class Form_setting
    Dim wplayer As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer()
    Private Sub Form_utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage1.Text = "HOME"
        TabPage2.Text = "SETTING JADWAL"
        TabPage3.Text = "DATABASE"
        TabPage4.Text = "DATA"
        tampilsound()
        tampilkegrid()
        tampilreg()
        rb_backup.Checked = True

        aktif()
    End Sub
    Sub aktif()
        cb_hari.Enabled = True
        ck_hari.Enabled = True
        CheckBox1.Enabled = True
        txt_jam.Text = ""
        txt_menit.Text = ""
        txt_keter.Text = ""
        cb_audio.SelectedItem = ""
        btn_simpan.Text = "SIMPAN"
        lbl_info.Visible = False
        cb_hari.SelectedItem = ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
    Public Function rubahtgl(ByVal tgl As String)
        Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(tgl, "Sunday", "Minggu"), "Monday", "Senin"), "Tuesday", "Selasa"), "Wednesday", "Rabu"), "Thursday", "Kamis"), "Friday", "Jumat"), "Saturday", "Sabtu")
    End Function



    Private Sub cb_hari_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_hari.SelectedValueChanged
        If cb_hari.SelectedItem = "SEMUA HARI" Then
            Dim checked As Boolean = True   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
        ElseIf cb_hari.SelectedItem = "SENIN" Then
            Dim checked As Boolean = False   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
            ck_hari.SetItemChecked(0, True)
        ElseIf cb_hari.SelectedItem = "SELASA" Then
            Dim checked As Boolean = False   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
            ck_hari.SetItemChecked(1, True)
        ElseIf cb_hari.SelectedItem = "RABU" Then
            Dim checked As Boolean = False   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
            ck_hari.SetItemChecked(2, True)
        ElseIf cb_hari.SelectedItem = "KAMIS" Then
            Dim checked As Boolean = False   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
            ck_hari.SetItemChecked(3, True)
        ElseIf cb_hari.SelectedItem = "JUMAT" Then
            Dim checked As Boolean = False   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
            ck_hari.SetItemChecked(4, True)
        ElseIf cb_hari.SelectedItem = "SABTU" Then
            Dim checked As Boolean = False   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
            ck_hari.SetItemChecked(5, True)
        ElseIf cb_hari.SelectedItem = "MINGGU" Then
            Dim checked As Boolean = False   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
            ck_hari.SetItemChecked(6, True)

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim checked As Boolean = True   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
        Else
            Dim checked As Boolean = False   ' Set to True or False, as required.
            For i As Integer = 0 To ck_hari.Items.Count - 1
                ck_hari.SetItemChecked(i, checked)
            Next
        End If
    End Sub

    Private Sub txt_jam_TextChanged(sender As Object, e As EventArgs) Handles txt_jam.TextChanged
        If txt_jam.TextLength = 2 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_jam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jam.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub


    Private Sub txt_menit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_menit.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub tampilsound()
        Try
            cb_audio.Items.Clear()
            Dim folderInfo As New IO.DirectoryInfo(Application.StartupPath + "\Audio\")
            Dim arrFilesInFolder() As IO.FileInfo
            Dim fileInFolder As IO.FileInfo
            arrFilesInFolder = folderInfo.GetFiles("*.mp3")
            For Each fileInFolder In arrFilesInFolder
                cb_audio.Items.Add(fileInFolder.Name)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            wplayer.URL = Application.StartupPath + "\Audio\" + cb_audio.Text
            If cb_audio.Text = "" Then
            Else
                wplayer.controls.play()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "SIMPAN" Then
            If cb_audio.Text = "" Or txt_detik.Text = "" Or txt_jam.Text = "" Or txt_keter.Text = "" Then
                MsgBox("Mohon lengkapi data", MsgBoxStyle.Critical, "WARNING")
            Else
                Dim tanya As DialogResult = MessageBox.Show("ANDA YAKIN AKAN SIMPAN PENGATURAN ?", "PENGATURAN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = DialogResult.Yes Then
                    simpan()

                End If
            End If
        Else
            If cb_audio.Text = "" Or txt_detik.Text = "" Or txt_jam.Text = "" Or txt_keter.Text = "" Then
                MsgBox("Mohon lengkapi data", MsgBoxStyle.Critical, "WARNING")
            Else
                Dim tanya As DialogResult = MessageBox.Show("ANDA YAKIN AKAN UPDATE PENGATURAN ?", "PENGATURAN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = DialogResult.Yes Then
                    update()

                End If
            End If
        End If


    End Sub
    Private Sub simpan()
        Try
            koneksi()
            For i As Integer = 0 To ck_hari.CheckedItems.Count - 1
                sql = "INSERT IGNORE JADWAL (hari,jam,keterangan,audiofile)"
                sql += " values ('" + ck_hari.CheckedItems(i).ToString + "',"
                sql += "'" + txt_jam.Text + ":" + txt_menit.Text + ":" + txt_detik.Text + "',"
                sql += """" + txt_keter.Text + """,""" + cb_audio.Text + """)"
                Cmd = New MySqlCommand(sql, Conn)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()


            Next
            MsgBox("BERHASIL INPUT DATA,APLIKASI AKAN DIRESTART", MsgBoxStyle.Information, "INFORMASI")
            tampilkegrid()
            clear()
            ClassBell.kill("Restart.bat")
        Catch ex As Exception
            MsgBox(ex.Message + sql)
        End Try
    End Sub
    Private Sub update()
        Try
            koneksi()
            sql = "UPDATE JADWAL "
            sql += " SET JAM='" + txt_jam.Text + ":" + txt_menit.Text + ":" + txt_detik.Text + "',KETERANGAN="
            sql += """" + txt_keter.Text + """,AUDIOFILE=""" + cb_audio.Text + """ WHERE ID='" + lbl_id.Text + "' and hari='" + cb_hari.Text + "'"
            Cmd = New MySqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()
            Cmd.Dispose()
            MsgBox("BERHASIL UPDATE DATA,AKAN DI RESTART", MsgBoxStyle.Information, "INFORMASI")
            tampilkegrid()
            clear()
            ClassBell.kill("Restart.bat")
        Catch ex As Exception
            MsgBox(ex.Message + sql)
        End Try
    End Sub
    Private Sub tampilkegrid()
        Try
            koneksi()
            dg_jadwal1.DataSource = Nothing
            dg_jadwal1.Columns.Clear()
            dg_jadwal1.Refresh()
            sql = "SELECT HARI,JAM,KETERANGAN,AUDIOFILE,ID FROM jadwal ORDER BY HARI,JAM"
            Da = New MySqlDataAdapter(sql, Conn)
            Ds = New DataSet
            Da.Fill(Ds, "jadwal")
            dg_jadwal1.DataSource = Ds.Tables("jadwal")
            aturdg()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub aturdg()
        dg_jadwal1.Columns(0).Width = 60
        dg_jadwal1.Columns(1).Width = 60
        dg_jadwal1.Columns(2).Width = 280
        dg_jadwal1.Columns(3).Width = 0
        dg_jadwal1.Columns(4).Width = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tampilkegrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tanya As DialogResult = MessageBox.Show("Apakah anda yakin akan hapus semua data?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (tanya = DialogResult.Yes) Then
            Try
                koneksi()
                sql = "Delete from jadwal"
                Cmd = New MySqlCommand(sql, Conn)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                tampilkegrid()
                MsgBox("Berhasil hapus jadwal, aplikasi akan di restart", MsgBoxStyle.Information, "INFO")
                ClassBell.kill("Restart.bat")
            Catch ex As Exception
                MsgBox("Kesalahan hapus data :" + ex.Message)
            End Try
        End If
    End Sub
    Sub clear()
        cb_hari.SelectedItem = ""
        Dim checked As Boolean = False   ' Set to True or False, as required.
        For i As Integer = 0 To ck_hari.Items.Count - 1
            ck_hari.SetItemChecked(i, checked)
        Next

        txt_jam.Text = ""
        txt_menit.Text = ""
        txt_keter.Text = ""

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

                MsgBox("Selesai simpan data", MsgBoxStyle.Information, "INFO")
                tampilreg()
                MsgBox("Berhasil simpan pengaturan, aplikasi akan di restart", MsgBoxStyle.Information, "INFO")
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
        lbl_namasekolah.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "SEKOLAH", Nothing)
        TextBox2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "LOGO", Nothing)
        pb_logo.ImageLocation = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "LOGO", Nothing)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.lbl_namasekolah.Left < 820 Then
            Me.lbl_namasekolah.Left = Me.lbl_namasekolah.Left + 10
        Else
            Me.lbl_namasekolah.Left = Me.lbl_namasekolah.Left - 1000
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        wplayer.URL = Application.StartupPath + "\Audio\" + cb_audio.Text
        wplayer.controls.stop()
    End Sub



    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox2.MouseClick
        OpenFileDialog1.Filter = "*.jpg|"
        OpenFileDialog1.ShowDialog()
        TextBox2.Text = OpenFileDialog1.FileName
        pb_logo.ImageLocation = TextBox2.Text
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub rb_backup_CheckedChanged(sender As Object, e As EventArgs) Handles rb_backup.CheckedChanged
        If rb_backup.Checked = True Then
            lbl_path.Text = "Lokasi Simpan"
            txt_pathsumber.Visible = False
            btn_pathsumber.Visible = False
            lbl_path.Visible = False
        Else
            lbl_path.Text = "File tersimpan"
            txt_pathsumber.Visible = True
            btn_pathsumber.Visible = True
            lbl_path.Visible = True
        End If
    End Sub

    Private Sub rb_restore_CheckedChanged(sender As Object, e As EventArgs) Handles rb_restore.CheckedChanged
        If rb_restore.Checked = True Then
            lbl_path.Text = "File tersimpan"
            txt_pathsumber.Visible = True
            btn_pathsumber.Visible = True
            lbl_path.Visible = True
        Else
            lbl_path.Text = "Lokasi Tersimpan"
            txt_pathsumber.Visible = False
            btn_pathsumber.Visible = False
            lbl_path.Visible = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_pathsumber.Click
        If rb_restore.Checked = True Then

            OpenFileDialog1.Title = "FILE BACKUP"
            OpenFileDialog1.InitialDirectory = Application.StartupPath + "\Data\"
            OpenFileDialog1.FileName = "JADWAL.CSV"
            OpenFileDialog1.ShowDialog()
            txt_pathsumber.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dg_jadwal1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_jadwal1.CellContentClick

    End Sub
    Dim rowsindexx As Integer
    Private Sub dg_jadwal1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_jadwal1.CellMouseUp

        If e.Button = MouseButtons.Right Then

            Me.dg_jadwal1.Rows(e.RowIndex).Selected = True
            rowsindexx = e.RowIndex
            Me.dg_jadwal1.CurrentCell = Me.dg_jadwal1.Rows(e.RowIndex).Cells(1)
            Me.ContextMenuStrip1.Show(Me.dg_jadwal1, e.Location)
            Me.ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TabControl1.SelectedTab = TabPage2
        btn_simpan.Text = "UPDATE"
        cb_hari.SelectedItem = dg_jadwal1.SelectedCells(0).Value.ToString()
        txt_jam.Text = Microsoft.VisualBasic.Left(dg_jadwal1.SelectedCells(1).Value.ToString(), 2)
        txt_menit.Text = Microsoft.VisualBasic.Mid(dg_jadwal1.SelectedCells(1).Value.ToString(), 4, 2)
        cb_audio.SelectedItem = dg_jadwal1.SelectedCells(3).Value.ToString()
        txt_keter.Text = dg_jadwal1.SelectedCells(2).Value.ToString()
        lbl_id.Text = dg_jadwal1.SelectedCells(4).Value.ToString()
        ck_hari.Enabled = False
        cb_hari.Enabled = False
        lbl_info.Visible = True
        CheckBox1.Enabled = False
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage2 Then
            aktif()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub btn_backrest_Click(sender As Object, e As EventArgs) Handles btn_backrest.Click
        Dim filebackup As String = Application.StartupPath + "\Data\JADWAL.CSV"
        If rb_backup.Checked = True Then

            If File.Exists(filebackup) Then
                File.Delete(filebackup)
            End If
            Dim filejadwal As String = Replace(filebackup, "\", "/")
            Try
                Dim tanya As DialogResult = MessageBox.Show("ANDA YAKIN AKAN BACKUP FILE JADWAL? DATA SEBELUMNYA AKAN DI HAPUS", "BACKUP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (tanya = DialogResult.Yes) Then

                    Try
                        koneksi()
                        sql = "SELECT * FROM jadwal INTO OUTFILE '" + filejadwal.ToString + "' FIELDS TERMINATED BY '|' LINES TERMINATED BY '\r\n';"
                        Cmd = New MySqlCommand(sql, Conn)
                        Cmd.ExecuteNonQuery()

                        If File.Exists(filebackup) Then
                            sql = "DELETE FROM JADWAL"
                            Cmd = New MySqlCommand(sql, Conn)
                            Cmd.ExecuteNonQuery()

                            MsgBox("BERHASIL BACKUP FILE KE " + filebackup, MsgBoxStyle.Information, "BACKUP")
                            tampilkegrid()
                            Form_depan.data()
                        End If
                    Catch ex As Exception
                        MsgBox("KESALAHAN :" + ex.Message)
                    End Try

                Else

                End If


            Catch ex As Exception
                MsgBox("KESALAHAN :" + ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            Try
                koneksi()
                Dim Sumber As String = Replace(txt_pathsumber.Text, "\", "/")
                sql = "LOAD DATA LOCAL INFILE '" + Sumber.ToString + "' into table jadwal FIELDS TERMINATED BY '|'"
                Cmd = New MySqlCommand(sql, Conn)
                Cmd.ExecuteNonQuery()

                MsgBox("BERHASIL RESTORE FILE BACKUP", MsgBoxStyle.Information, "RESTORE")
                tampilkegrid()
                Form_depan.data()
            Catch ex As Exception
                MsgBox("KESALAHAN :" + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim tanya As DialogResult = MessageBox.Show("ANDA YAKIN AKAN HAPUS JADWAL BERIKUT ?" + vbNewLine + "Hari :" + dg_jadwal1.SelectedCells(0).Value.ToString() + vbNewLine + "Jam :" + dg_jadwal1.SelectedCells(1).Value.ToString() + vbNewLine + "Ket :" + dg_jadwal1.SelectedCells(2).Value.ToString(), "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (tanya = DialogResult.Yes) Then
                Try
                    koneksi()
                    Dim hjam As String = dg_jadwal1.SelectedCells(1).Value.ToString()
                    Dim hhari As String = dg_jadwal1.SelectedCells(0).Value.ToString()
                    Dim hket As String = dg_jadwal1.SelectedCells(2).Value.ToString()
                    sql = "DELETE FROM  jadwal where hari='" + hhari.ToString + "' and jam='" + hjam.ToString + "' and keterangan='" + hket.ToString + "'"
                    Cmd = New MySqlCommand(sql, Conn)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()

                    MsgBox("BERHASIL HAPUS DATA", MsgBoxStyle.Information, "HAPUS")
                    tampilkegrid()
                    Form_depan.data()
                Catch ex As Exception
                    MsgBox("KESALAHAN :" + ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class