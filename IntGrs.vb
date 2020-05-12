Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Net.Mail
Module IntGrs
    Public Errmsg As String          ' Handel error message
    Public RepCount As Integer       ' Handel Report Counter
    Public Cnt_ As Integer = 0       ' Just Temp counter should't use out for-next
    Public PbAbuse As Integer = 0    ' Count Abuse complain Reset every 24 hours
    Public PbComp As Integer = 0     ' Count Other complain Reset every 24 hours
    Public strConn As String = "Data Source=HOSPC\HOSPCSQLSRV;Initial Catalog=CSSYS;User ID=sa;Password=Hemonad105046"
    Public sqlCon As SqlConnection
    Public HndlMsg As String
    Public sqlComm As New SqlCommand
    Public RsvTableAdapter As New SqlDataAdapter
    Public ArtiiTblAdptr As New SqlDataAdapter
    Public sqlComm1 As New SqlCommand
    Public Rsv As New DataTable
    Public SqlStr As String

    Public Function SEmail(ETo As String, Optional ECc As String = "", Optional EBc As String = "", Optional Esub As String = "", Optional EMsg As String = "", Optional ETch As String = "X", Optional EPri As String = "N") As Integer
        '   Email Function Ver. 4.0
        Dim Smtp_Server As New SmtpClient
        Dim E_mail As New MailMessage()

        Try
            Smtp_Server.Host = My.Settings.StmpH
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(My.Settings.StmpU, My.Settings.StmpP)
            Smtp_Server.Port = My.Settings.StmpR ';    //alternative port number Is 8889
            Smtp_Server.EnableSsl = False

            E_mail = New MailMessage()
            E_mail.From = New MailAddress(My.Settings.FEmail)
            For Each ETo In ETo.Split({";"}, StringSplitOptions.RemoveEmptyEntries)
                E_mail.To.Add(ETo)
            Next
            For Each ECc In ECc.Split({";"}, StringSplitOptions.RemoveEmptyEntries)
                E_mail.CC.Add(ECc)
            Next
            For Each EBc In EBc.Split({";"}, StringSplitOptions.RemoveEmptyEntries)
                E_mail.Bcc.Add(EBc)
            Next
            Select Case EPri
                Case EPri = "H"
                    E_mail.Priority = MailPriority.High
                Case EPri = "L"
                    E_mail.Priority = MailPriority.Low
                Case Else
                    E_mail.Priority = MailPriority.Normal
            End Select
            E_mail.Subject = Esub
            If ETch <> "X" Then
                E_mail.Attachments.Add(New Attachment(ETch))
            End If
            E_mail.IsBodyHtml = False
            E_mail.Body = EMsg
            Smtp_Server.Send(E_mail)
            SEmail = 1

        Catch error_t As Exception
            Errmsg = error_t.Message & ", " & error_t.InnerException.Message
            SEmail = 0
        End Try
        Return SEmail
    End Function


    Function OsIP() As String              'Returns the Ip address 
#Disable Warning BC40000 ' Type or member is obsolete
        OsIP = Net.Dns.GetHostByName("").AddressList(0).ToString()
#Enable Warning BC40000 ' Type or member is obsolete
    End Function

End Module