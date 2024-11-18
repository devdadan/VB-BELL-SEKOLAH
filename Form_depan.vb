Imports System.IO
Imports MySql.Data.MySqlClient
Imports NAudio.Wave
Public Class Form_depan
    Dim wplayer As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer()
    Dim hari As String
    Dim fhari As String
    Dim class1 As New ClassBell
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_jam.Text = Format(TimeOfDay, "HH:mm:ss")
        lbl_tgl.Text = rubahtgl(Format(CDate(Date.Now), "dd MMMM yyyy"))
        lblhari.Text = rubahtgl(Format(CDate(Date.Now), "dddd"))
        hari = rubahtgl(Format(CDate(Date.Now), "dddd"))
        If lblhari.Text = fhari Then
        Else
            Try
                koneksi()
                sql = "UPDATE PENGATURAN SET HARI='" + lblhari.Text + "' WHERE FLAG_HARI='1'"
                Cmd = New MySqlCommand(sql, Conn)
                Cmd.ExecuteNonQuery()
                Conn.Close()
                'ClassBell.kill("Restart.bat")
                data()
            Catch ex As Exception

            End Try
        End If

        If dg_antrian.Rows.Count > 0 Then
            Dim a As Integer
            For a = 0 To dg_antrian.Rows.Count - 1
                If lbl_jam.Text = dg_antrian.Rows(a).Cells("JAM").Value.ToString Then
                    Timer1.Stop()
                    txt_ket.Text = dg_antrian.Rows(a).Cells("KETERANGAN").Value.ToString
                    wplayer.URL = Application.StartupPath + "\Audio\" + dg_antrian.Rows(a).Cells("AUDIOFILE").Value.ToString
                    wplayer.controls.stop()
                    wplayer.controls.play()
                    Timer1.Start()
                    txt_ket.Text = "BELUM ADA JADWAL"

                End If
            Next
        End If

    End Sub
    Public Function rubahtgl(ByVal tgl As String)
        Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(tgl, "Sunday", "Minggu"), "Monday", "Senin"), "Tuesday", "Selasa"), "Wednesday", "Rabu"), "Thursday", "Kamis"), "Friday", "Jumat"), "Saturday", "Sabtu")
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_versi.Text = "Sistem Bell Otomatis v" + Application.ProductVersion
        Timer1.Start()
        data()
        PictureBox1.ImageLocation = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "LOGO", Nothing)
        lbl_instansi.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "SEKOLAH", Nothing)
        Dim stpath As String = class1.getAllReg()
        Dim serial As String = class1.GetSerial
        Dim Keys As String = class1.GetKey(serial)
        If Keys = stpath Then

        Else
            FormLicens.ShowDialog()
        End If
    End Sub
    Public Sub data()
        Try

            koneksi()
            sql = "SELECT ifnull(HARI,'') FROM PENGATURAN"
            Cmd = New MySqlCommand(sql, Conn)
            RD = Cmd.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                fhari = RD.Item(0)
            End If
            RD.Close()
            Try
                dg_antrian.DataSource = Nothing
                sql = "SELECT HARI,JAM,KETERANGAN,AUDIOFILE FROM jadwal where hari='" + fhari.ToString + "'"
                sql += " order by jam"
                Da = New MySqlDataAdapter(sql, Conn)
                Ds = New DataSet
                Da.Fill(Ds, "jadwal")
                dg_antrian.DataSource = Ds.Tables("jadwal")
                aturdg()
            Catch ex As Exception
                MsgBox(ex.Message + ex.StackTrace)
            End Try

            gboc_dg.Text = "Jadwal Bel hari " + fhari

        Catch ex As Exception
            MsgBox(ex.Message + ex.StackTrace)
        End Try
    End Sub
    Private Sub cekkedb()
        Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Sub aturdg()
        dg_antrian.Columns(0).Width = 80
        dg_antrian.Columns(1).Width = 50
        dg_antrian.Columns(2).Width = 330
        dg_antrian.Columns(3).Width = 0
        dg_antrian.AllowUserToResizeColumns = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        If e.Button = MouseButtons.Right Then
            Me.ContextMenuStrip1.Show(Me.PictureBox1, e.Location)
            Me.ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub SETTINGDATABASEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SETTINGDATABASEToolStripMenuItem.Click
        Form_setting.ShowDialog()
    End Sub

    Private Sub dg_antrian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_antrian.CellContentClick

    End Sub
    Dim rowsindexx As Integer
    Private Sub dg_antrian_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_antrian.CellMouseUp
        If e.Button = MouseButtons.Right Then

            Me.dg_antrian.Rows(e.RowIndex).Selected = True
            rowsindexx = e.RowIndex
            Me.dg_antrian.CurrentCell = Me.dg_antrian.Rows(e.RowIndex).Cells(1)
            Me.ContextMenuStrip2.Show(Me.dg_antrian, e.Location)
            Me.ContextMenuStrip2.Show(Cursor.Position)
        End If
    End Sub

    Private Sub BunyikanBelManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BunyikanBelManualToolStripMenuItem.Click
        'MsgBox(dg_antrian.SelectedCells(2).Value)
        txt_ket.Text = dg_antrian.SelectedCells(2).Value.ToString
        wplayer.URL = Application.StartupPath + "\Audio\" + dg_antrian.SelectedCells(3).Value.ToString
        wplayer.controls.stop()
        wplayer.controls.play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        SplashScreen1.Close()
    End Sub
End Class