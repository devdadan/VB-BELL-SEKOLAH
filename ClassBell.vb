Imports System.Security.Cryptography
Imports System.IO
Imports System.Management
Imports System.Text

Public Class ClassBell
    Public Shared Sub kill(namafile As String)
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = Application.StartupPath + "\" + namafile
        ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden
        Dim myProcess As Process = Process.Start(ProcessProperties)
    End Sub

    Private key() As Byte = {}

    Private IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}

    Private Const EncryptionKey As String = "asdfzxcv" ' 8 Characters ...
    Dim sdate As String = Format(Now, "yyyy-MM-dd")
    Private Function getCPU_ID() As String

        Dim cpuID As String = String.Empty
        Dim mc As ManagementClass = New ManagementClass("Win32_Processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances()

        For Each mo As ManagementObject In moc
            If (cpuID = String.Empty) Then
                cpuID = mo.Properties("ProcessorId").Value.ToString()
            End If
        Next

        Return cpuID

    End Function

    Public Function getAllReg()
        Dim spa As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\AplicationBel\", "serial", "")
        Return spa
    End Function
    Private Function GetMacAdress() As Long

        Dim mc As New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim mac As String = ""

        'Getting network adapters collection
        Dim moc As ManagementObjectCollection = mc.GetInstances

        'Here we iterate over available network adapters, 
        'picking the first possible one

        For Each mo As ManagementObject In moc
            If mo.Item("IPEnabled") Then
                mac = mo.Item("MacAddress").ToString
                Exit For
            End If
        Next

        mc.Dispose()


        Dim sum As Long = 0
        Dim index As Integer = 1
        For Each ch As Char In mac
            If Char.IsDigit(ch) Then
                sum += sum + Integer.Parse(ch) * (index * 2)
            ElseIf Char.IsLetter(ch) Then
                Select Case ch.ToString.ToUpper
                    Case "A"
                        sum += sum + 10 * (index * 2)
                    Case "B"
                        sum += sum + 11 * (index * 2)
                    Case "C"
                        sum += sum + 12 * (index * 2)
                    Case "D"
                        sum += sum + 13 * (index * 2)
                    Case "E"
                        sum += sum + 14 * (index * 2)
                    Case "F"
                        sum += sum + 15 * (index * 2)
                End Select
            End If

            index += 1
        Next

        Return sum

    End Function

    Private Function Encrypt(ByVal stringToEncrypt As String) As String

        Try
            key = System.Text.Encoding.UTF8.GetBytes(EncryptionKey)
            Dim des As New DESCryptoServiceProvider
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(stringToEncrypt)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
        Catch ex As Exception
            'oops - add your exception logic
        End Try

    End Function

    Private Function Decrypt(ByVal stringToDecrypt As String) As String

        Try
            Dim inputByteArray(stringToDecrypt.Length) As Byte
            key = System.Text.Encoding.UTF8.GetBytes(EncryptionKey)
            Dim des As New DESCryptoServiceProvider
            inputByteArray = Convert.FromBase64String(stringToDecrypt)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8
            Return encoding.GetString(ms.ToArray())
        Catch ex As Exception
            'oops - add your exception logic
        End Try

    End Function

    Public Function GetSerial() As String

        Return Encrypt(GetMacAdress)

    End Function

    Public Function GetKey(_Serail As String) As String

        Return Encrypt(_Serail)

    End Function
End Class
