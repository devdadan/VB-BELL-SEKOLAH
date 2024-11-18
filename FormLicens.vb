Imports System.IO
Imports Microsoft.Win32
Public Class FormLicens
    Dim clasSK As New ClassBell
    Public PathRegistryKey As String = "SOFTWARE\AplicationBel"
    Public RegKey As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(PathRegistryKey, True)
    Public isTrial As Boolean
    Public DiffDay As Integer
    Public isActiveted As Boolean
    Dim BtnCloseClicked As Boolean = False
    Private Sub FormLicens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = clasSK.GetSerial()
        CheckActivate()
        trial()
    End Sub
    Sub CheckActivate()

        Try
            If RegKey Is Nothing Then

            Else
                Dim RegKeySerial As String = (RegKey.GetValue("Serial"))
                Dim RegKeyFirstDate As DateTime = CDate(RegKey.GetValue("FirstDate"))
                Dim RegKeyLastDate As DateTime = CDate(RegKey.GetValue("LastDate"))
                DiffDay = DateDiff(DateInterval.Day, RegKeyFirstDate, Now)

                If DiffDay > 30 Then

                    isTrial = False

                Else

                    isTrial = True

                End If

            End If


        Catch ex As Exception

        End Try

    End Sub
    Private Sub trial()
        If RegKey IsNot Nothing Then

            BtnTrial.Enabled = False

            If isTrial Then

                BtnTrial.Visible = True

                If DiffDay >= 0 And DiffDay <= 30 Then
                    BtnTrial.Text = String.Format("Trial ({0})", 30 - DiffDay)
                End If

            Else

                BtnTrial.Visible = False

            End If

        Else

            BtnTrial.Text = ("Trial (30)")

        End If
    End Sub

    Private Sub btn_aktiv_Click(sender As Object, e As EventArgs) Handles btn_aktiv.Click

        Dim Key As String = clasSK.GetKey(TextBox1.Text)

        If Key = TextBox2.Text.Trim Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\AplicationBel\", "serial", TextBox2.Text.Trim)
            MsgBox("AKTIVASI BERHASIL ...", MsgBoxStyle.Information, "INFO")
            isActiveted = True
            Me.Close()
        Else
            MsgBox("KODE AKTIVASI SALAH ...", MsgBoxStyle.Critical, "WARNING")
        End If
    End Sub
    Private Sub FormLicens_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try

            If Not isActiveted Then

                If isTrial = False Then

                    '   Double Click [X] to Closed ...

                    If BtnCloseClicked = False Then

                        '   Keep Open [Acticate Form]

                        e.Cancel = True
                        BtnCloseClicked = True

                        ToolTip1.RemoveAll()
                        ToolTip1.Show("Active Your System !", btn_aktiv, 2000)

                    Else

                        End

                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTrial_Click(sender As Object, e As EventArgs) Handles btnTrial.Click

        Try

            If RegKey Is Nothing Then

                Dim Reg = My.Computer.Registry.CurrentUser.CreateSubKey(PathRegistryKey)

                Reg.SetValue("FirstDate", Now) ' .ToString("dd-MM-yyyy HH:mm:ss")
                Reg.SetValue("LastDate", Now)
                Reg.Close()

                isTrial = True

                Me.Close()

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class