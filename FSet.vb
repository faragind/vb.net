Imports System.Data.SqlClient
Public Class FSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpNo.Text = My.Settings.EmpX
        Me.TxtEmpN.Text = My.Settings.EmpN
        Me.TxtAEmail.Text = My.Settings.AEmail
        Me.TxtFEmail.Text = My.Settings.FEmail
        Me.TxtStmpH.Text = My.Settings.StmpH
        Me.TxtStmpU.Text = My.Settings.StmpU
        Me.TxtStmpP.Text = My.Settings.StmpP
        Me.TxtStmpR.Text = My.Settings.StmpR
        Me.TJob1.Checked = My.Settings.Job1
        Me.TJob2.Checked = My.Settings.Job2
    End Sub
    Private Sub Exit__Click(sender As Object, e As EventArgs) Handles Exit_.Click
        My.Settings.EmpX = Me.EmpNo.Text
        My.Settings.EmpN = Me.TxtEmpN.Text
        My.Settings.AEmail = Me.TxtAEmail.Text
        My.Settings.FEmail = Me.TxtFEmail.Text
        My.Settings.StmpH = Me.TxtStmpH.Text
        My.Settings.StmpU = Me.TxtStmpU.Text
        My.Settings.StmpP = Me.TxtStmpP.Text
        My.Settings.StmpR = Me.TxtStmpR.Text
        My.Settings.Job1 = Me.TJob1.Checked
        My.Settings.Job2 = Me.TJob2.Checked
        Me.Close()
    End Sub

    Private Sub TxtAEmail_Leave(sender As Object, e As EventArgs)
        My.Settings.AEmail = Me.TxtAEmail.Text
    End Sub

    Private Sub EmpNo_Leave(sender As Object, e As EventArgs) Handles EmpNo.Leave

        Dim SqlComm As New SqlCommand
        sqlCon = New SqlConnection(strConn)
        sqlCon.Open()
        SqlComm.Connection = sqlCon
        SqlComm.CommandText = "SELECT User_RealName FROM dbo.Int_user  WHERE(User_id = N'" & Me.EmpNo.Text & "')" 'save start job
        SqlComm.CommandType = CommandType.Text
        SqlComm.ExecuteNonQuery()
        Dim reader As SqlDataReader = SqlComm.ExecuteReader
        reader.Read()
        My.Settings.EmpN = reader(0)
        My.Settings.EmpX = Me.EmpNo.Text
        Me.TxtEmpN.Text = My.Settings.EmpN
        SqlComm = Nothing
        sqlCon.Close()
        SqlConnection.ClearPool(sqlCon)
    End Sub

    Private Sub EmpNo_TextChanged(sender As Object, e As EventArgs) Handles EmpNo.TextChanged
        Me.Button3.BackgroundImage = My.Resources.recorange
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Button3.BackgroundImage = My.Resources.recgreen
    End Sub

End Class