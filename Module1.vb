Imports MySql.Data.MySqlClient
Module Module1
    Public Conn As New MySqlConnection
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public RD As MySqlDataReader
    Public Cmd As MySqlCommand
    Public MyDB As String
    Public sql As String
    Public Sub koneksi()
        Try

            Dim host1 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Host", Nothing)
            Dim User1 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "User", Nothing)
            Dim Pass As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Pass", Nothing)
            Dim Db1 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\BELL\", "Db", Nothing)
            Dim MyDB As String = "Server=" + host1.ToString + ";user id=" + User1.ToString + ";password=" + Pass.ToString + ";database=" + Db1.ToString + ""
            Conn = New MySqlConnection(MyDB)
            If Conn.State = ConnectionState.Closed Then Conn.Open()

        Catch ex As Exception
            MsgBox("Something whene wrong!")
        End Try


    End Sub

End Module
