Public Class Jobs
    Dim AriiTbl As New DataTable
    Private Sub Jobss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSSYSDataSet1.ArtInt15' table. You can move, or remove it, as needed.

        sqlCon = New SqlConnection(strConn)
        sqlCon.Open()
        sqlComm.Connection = sqlCon
        ArtiiTblAdptr.SelectCommand = sqlComm

        sqlComm.CommandText = "SELECT TOP (15) AiSql, AISTime, AIJob FROM dbo.ArtInt ORDER BY AISTime DESC"                                                ' Levels Count

        'sqlComm.ExecuteNonQuery()
        AriiTbl.Clear()
        ArtiiTblAdptr.Fill(AriiTbl)
        ArtiiGrView.DataSource = AriiTbl
        'SqlStr = "SELECT RsvID, Rsv_ad_Date, Rsv_Days FROM Rsv WHERE (RsvID > 59684) AND (RsvType1 = 'محجوز') AND (RsvOut = 0) AND (RsvRec = 0) AND (RsvStart = 0) AND (RsvType < 3)"
        'sqlComm.CommandText = SqlStr                                                ' Levels Count
        'Rsv.Clear()
        'RsvTableAdapter.Fill(Rsv)

        With RadialGauge1
            .BackgroundGradientEndColor = Color.FromArgb(255, 255, 192)
            .BackgroundGradientStartColor = Color.FromArgb(128, 128, 255)
            .FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.FullCircle
            .GaugeArcColor = Color.Yellow
            .GaugeLableColor = Color.FromArgb(192, 0, 0)
            .InnerFrameGradientEndColor = Color.LemonChiffon
            .InnerFrameGradientStartColor = Color.FromArgb(244, 244, 244)
            .InterLinesColor = Color.Red
            .LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Inside
            .MajorTickMarkColor = Color.Maroon
            .MinorTickMarkColor = Color.FromArgb(255, 128, 128)
            .NeedleColor = Color.FromArgb(0, 0, 192)
            .NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced
            .OuterFrameGradientEndColor = Color.Khaki
            .OuterFrameGradientStartColor = Color.LemonChiffon
            .ScaleLabelColor = Color.Red
            .TextOrientation = Syncfusion.Windows.Forms.Gauge.TextOrientation.SlideOver
            .TickPlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside
            .ArcThickness = 2
            .MajorDifference = 10
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.Job1 = False Then Exit Sub
        Dim EmMsg As String
        Dim SqlArtiiUp As New SqlCommand
        Dim Msg1 As String = "Job RWDU started By User at " & Now
        EmMsg = Msg1
        sqlCon = New SqlConnection(strConn)
        Me.LbFootStatus.Text = Msg1
        Me.Refresh()

        '*****************************
        sqlCon.Open()
        sqlComm.Connection = sqlCon
        sqlComm.CommandText = "ACalRsvDate" '   Call external Procedure qury that do the job
        sqlComm.CommandType = CommandType.StoredProcedure
        Dim RwsAffec As Integer = sqlComm.ExecuteNonQuery()
        Me.LbMain.Text = "Job RWDU Have " & RwsAffec / 2 & " record for updating WorksDay..."
        Me.Refresh()
        SqlArtiiUp.Connection = sqlCon
        EmMsg = "insert into ArtInt (AIJob) values('" & Msg1 & " With " & RwsAffec / 2 & " record(s) for updating WorksDay..., and finish at  " & Now & "');"
        SqlArtiiUp.CommandText = EmMsg 'save start job
        SqlArtiiUp.CommandType = CommandType.Text
        SqlArtiiUp.ExecuteNonQuery()
        EmMsg = Msg1 & " With " & RwsAffec / 2 & " record(s) for updating WorksDay..., and finish at  " & Now
        Me.LbFootStatus.Text = "Sending Email ..."     ' Start sending mail
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)
        For Cnt_ = 1 To 100
            RadialGauge1.Value = Cnt_
        Next Cnt_


        If SEmail(My.Settings.AEmail,,, "Job Status", EmMsg) = 1 Then
            Msg1 = "Job RWDU Sending Email To Admin at  " & Now
        Else
            Msg1 = "Job RWDU fail to Send Email To Admin at  " & Now & " Because. " & Errmsg
        End If
        EmMsg = EmMsg & vbNewLine & Msg1

        NotifyIcon1.Icon = SystemIcons.Information
        NotifyIcon1.BalloonTipTitle = "Job Alarm"
        NotifyIcon1.BalloonTipText = EmMsg
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.Visible = True
        SqlArtiiUp.CommandText = "insert into ArtInt (AIJob) values('" & Msg1 & "');" 'save Email Success / failed
        SqlArtiiUp.CommandType = CommandType.Text
        SqlArtiiUp.ExecuteNonQuery()

        Me.LbFootStatus.Text = "Finish Job ..."
        Me.LbRWDU.Text = "Job RWDU saved the amount of " & RwsAffec / 2 & " records Today"
        Me.LbMain.Text = "Waiting to Start Job"
        ' close connetion for arti table

        ArtiiTblAdptr.SelectCommand = sqlComm
        sqlComm.CommandText = "SELECT TOP (15) AiSql, AISTime, AIJob FROM dbo.ArtInt ORDER BY AISTime DESC"                                                ' Levels Count
        sqlComm.CommandType = CommandType.Text

        AriiTbl.Clear()
        ArtiiTblAdptr.Fill(AriiTbl)
        For Cnt_ = 20 To 0 Step -1
            RadialGauge1.Value = Cnt_ * 5
        Next Cnt_
        SqlArtiiUp = Nothing
        sqlCon.Close()
        SqlConnection.ClearPool(sqlCon)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '   Rsv Works Day Update (RWDU) handling this job here between 1:00 and 1:59
        If My.Settings.Job1 = False Then Exit Sub
        Dim EmMsg As String
        Dim SqlArtiiUp As New SqlCommand
        Dim Msg1 As String = "Job RWDU started Automatic at " & Now
        EmMsg = Msg1
        sqlCon = New SqlConnection(strConn)
        Me.LbFootStatus.Text = Msg1
        Me.Refresh()

        '*****************************
        sqlCon.Open()
        sqlComm.Connection = sqlCon
        sqlComm.CommandText = "ACalRsvDate" '   Call external Procedure qury that do the job
        sqlComm.CommandType = CommandType.StoredProcedure
        Dim RwsAffec As Integer = sqlComm.ExecuteNonQuery()
        Me.LbMain.Text = "Job RWDU Have " & RwsAffec / 2 & " record for updating WorksDay..."
        Me.Refresh()
        SqlArtiiUp.Connection = sqlCon
        EmMsg = "insert into ArtInt (AIJob) values('" & Msg1 & " With " & RwsAffec / 2 & " record(s) for updating WorksDay..., and finish at  " & Now & "');"
        SqlArtiiUp.CommandText = EmMsg 'save start job
        SqlArtiiUp.CommandType = CommandType.Text
        SqlArtiiUp.ExecuteNonQuery()
        EmMsg = Msg1 & " With " & RwsAffec / 2 & " record(s) for updating WorksDay..., and finish at  " & Now
        Me.LbFootStatus.Text = "Sending Email ..."     ' Start sending mail
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)
        For Cnt_ = 1 To 100
            RadialGauge1.Value = Cnt_
        Next Cnt_


        If SEmail(My.Settings.AEmail,,, "Job Status", EmMsg) = 1 Then
            Msg1 = "Job RWDU Sending Email To Admin at  " & Now
        Else
            Msg1 = "Job RWDU fail to Send Email To Admin at  " & Now & " Because. " & Errmsg
        End If
        EmMsg = EmMsg & vbNewLine & Msg1

        NotifyIcon1.Icon = SystemIcons.Information
        NotifyIcon1.BalloonTipTitle = "Job Alarm"
        NotifyIcon1.BalloonTipText = EmMsg
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.Visible = True
        SqlArtiiUp.CommandText = "insert into ArtInt (AIJob) values('" & Msg1 & "');" 'save Email Success / failed
        SqlArtiiUp.CommandType = CommandType.Text
        SqlArtiiUp.ExecuteNonQuery()

        Me.LbFootStatus.Text = "Finish Job ..."
        Me.LbRWDU.Text = "Job RWDU saved the amount of " & RwsAffec / 2 & " records Today"
        Me.LbMain.Text = "Waiting to Start Job"
        ' close connetion for arti table

        ArtiiTblAdptr.SelectCommand = sqlComm
        sqlComm.CommandText = "SELECT TOP (15) AiSql, AISTime, AIJob FROM dbo.ArtInt ORDER BY AISTime DESC"                                                ' Levels Count
        sqlComm.CommandType = CommandType.Text

        AriiTbl.Clear()
        ArtiiTblAdptr.Fill(AriiTbl)
        For Cnt_ = 20 To 0 Step -1
            RadialGauge1.Value = Cnt_ * 5
        Next Cnt_
        SqlArtiiUp = Nothing
        sqlCon.Close()
        SqlConnection.ClearPool(sqlCon)
        PbAbuse = 0
        PbComp = 0

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick, Button2.Click
        If My.Settings.Job2 = False Then Exit Sub

        '        Dim EmMsg As String
        '        Dim EOfCnt As Integer = 0
        '        Dim CnPrg As Integer
        '        Dim RowAf As Integer
        '        Dim DisAb As New SqlCommand
        '        Dim SqlArtiiUp As New SqlCommand
        '        Dim SqlComm As New SqlCommand
        '        Dim DisCom As New SqlCommand
        '        sqlCon = New SqlConnection(strConn)
        '        Dim Msg1 As String = ""
        '        EmMsg = Msg1
        '        Me.LbMain.Text = Msg1
        '        Dim PrgBar As Double
        '        Me.Dis_CompTableAdapter.FillAbuse(Me.CSSYSDataSet1.Dis_Comp)  'Fill abuse complain
        '        'On Error GoTo DistrbuteAbuse_Error
        '        DisAb.Connection = sqlCon
        '        DisAb.CommandText = "insert into CompUpdate (RelationID,UpdateTxt,UpdateUser,User_IP) values(@CC1,@CC2,@CC3,@CC4);" 'save start job
        '        DisAb.CommandType = CommandType.Text
        '        DisAb.Parameters.Add("@CC1", SqlDbType.Int)
        '        DisAb.Parameters.Add("@CC2", SqlDbType.NVarChar)
        '        DisAb.Parameters.Add("@CC3", SqlDbType.NVarChar)
        '        DisAb.Parameters.Add("@CC4", SqlDbType.NVarChar)
        '        sqlCon.Open()
        '        Me.LbFootStatus.Text = "Calculating Abuse Complain ..."
        '        CnPrg = 0 '                                                      ************
        '        If CSSYSDataSet1.Dis_Comp.Count = 0 Then       ' divide the progressBar on the amount of abuse complain
        '            PrgBar = 0
        '            Me.PrgrBar1.Value = PrgBar
        '            Msg1 = "Job DsCm started at " & Now & "  Phase 1 Done as there is no complain to distribute"
        '            EmMsg = EmMsg + vbNewLine + Msg1
        '        Else
        '            Msg1 = "Job DsCm started at " & Now & "  Phase 1"
        '            PrgBar = 100 / CSSYSDataSet1.Dis_Comp.Count
        '            For Cnt_ = 0 To CSSYSDataSet1.Dis_Comp.Count - 1
        '                DisAb.Parameters.Item("@CC1").Value = CSSYSDataSet1.Tables("Dis_Comp").Rows(Cnt_).Item(0)
        '                DisAb.Parameters.Item("@CC2").Value = "The Complain has been Sent To " & My.Settings.EmpN
        '                DisAb.Parameters.Item("@CC3").Value = "ADM"
        '                DisAb.Parameters.Item("@CC4").Value = OsIP()
        '                DisAb.ExecuteNonQuery()
        '                Me.PrgrBar1.Value = CnPrg
        '                CnPrg = CnPrg + PrgBar
        '            Next
        '        End If
        '        SqlComm.Connection = sqlCon '                       Start execute target abuse user in strore procedure
        '        SqlComm.CommandText = "DistrAbuse"
        '        SqlComm.CommandType = CommandType.StoredProcedure
        '        SqlComm.Parameters.AddWithValue("@p1", My.Settings.EmpX)
        '        'SqlComm.Parameters.Add("@return_value", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
        '        SqlComm.ExecuteNonQuery()
        '        Msg1 = "Job DsCm Distribute " & CSSYSDataSet1.Dis_Comp.Count & " Record(s) for Abuse Complain(s) at " & Now
        '        EmMsg = EmMsg + vbNewLine + Msg1
        '        SqlArtiiUp.Connection = sqlCon
        '        SqlArtiiUp.CommandText = "insert into ArtInt (AIJob) values('" & Msg1 & "');" 'save Amount job
        '        SqlArtiiUp.CommandType = CommandType.Text
        '        SqlArtiiUp.ExecuteNonQuery()
        '        PbAbuse = PbAbuse + CSSYSDataSet1.Dis_Comp.Count
        '        Me.LbMain.Text = Msg1
        '        Me.LbFootStatus.Text = "Finish Phase 1 ... Starting Next Phase"
        '        Me.PrgrBar1.Value = 0
        '        Me.LbDsCmA.Text = "Job DsCm Distribute " & PbAbuse & " Record(s) for Abuse Complain(s) Today"
        '        CnPrg = 0
        '        DisCom.Connection = sqlCon
        '        DisCom.CommandText = "DistrComp"
        '        DisCom.CommandType = CommandType.StoredProcedure
        '        DisCom.Parameters.Add("@p0", SqlDbType.Int)
        '        DisCom.Parameters.Add("@p1", SqlDbType.Int)
        '        DisCom.Parameters.Add("@return_value", SqlDbType.Int).Direction = ParameterDirection.ReturnValue

        '        '                                                         Start Distribure the rest complain by Maneger
        '        Me.Dis_CompTableAdapter.Fill(Me.CSSYSDataSet1.Dis_Comp) ' Fill Rest complain
        '        If CSSYSDataSet1.Dis_Comp.Count = 0 Then                ' divide the progressBar on the amount of Rest complain
        '            PrgBar = 0
        '            Msg1 = "Job DsCm Has Stopped as there is no Complain to Distribute to any User"
        '            EmMsg = EmMsg + vbNewLine + Msg1
        '        Else
        '            PrgBar = 100 / CSSYSDataSet1.Dis_Comp.Count
        '            For Cnt_ = 0 To CSSYSDataSet1.Dis_Comp.Count - 1

        '                DisAb.Parameters.Item("@CC1").Value = CSSYSDataSet1.Tables("Dis_Comp").Rows(Cnt_).Item(0)
        '                DisAb.Parameters.Item("@CC2").Value = "The Complain has been Sent To " & CSSYSDataSet1.Tables("Dis_Comp").Rows(Cnt_).Item(6)
        '                DisAb.Parameters.Item("@CC3").Value = "ADM"
        '                DisAb.Parameters.Item("@CC4").Value = OsIP()
        '                DisAb.ExecuteNonQuery()
        '                '                               strat target other user in strore procedure
        '                DisCom.Parameters.Item("@p0").Value = CSSYSDataSet1.Tables("Dis_Comp").Rows(Cnt_).Item(0)
        '                DisCom.Parameters.Item("@p1").Value = CSSYSDataSet1.Tables("Dis_Comp").Rows(Cnt_).Item(5)
        '                DisCom.ExecuteNonQuery()
        '                Me.PrgrBar1.Value = CnPrg
        '                CnPrg = CnPrg + PrgBar
        '                Msg1 = "Job DsCm Has Distribute " & CSSYSDataSet1.Dis_Comp.Count & " Complain to Several Users at " & Now
        '                EmMsg = EmMsg + vbNewLine + Msg1
        '            Next
        '        End If
        '        PbComp = PbComp + CSSYSDataSet1.Dis_Comp.Count
        '        SqlArtiiUp.CommandText = "insert into ArtInt (AIJob) values('" & Msg1 & "');" 'save Amount job
        '        SqlArtiiUp.CommandType = CommandType.Text
        '        SqlArtiiUp.ExecuteNonQuery()
        '        Me.LbMain.Text = Msg1
        '        Me.LbFootStatus.Text = "Finish Phase 2 Job Finish ..."
        '        Me.LbDsCmO.Text = "Job DsCm Distribute " & PbComp & " Complains for several users Today"
        '        Me.PrgrBar1.Value = 0

        '        Msg1 = "Job DsCm Has Finish at " & Now
        '        EmMsg = EmMsg & vbNewLine & Msg1
        '        SqlArtiiUp.CommandText = "insert into ArtInt (AIJob) values('" & Msg1 & "');" 'save Finish end job
        '        SqlArtiiUp.CommandType = CommandType.Text
        '        SqlArtiiUp.ExecuteNonQuery()
        '        '                            If want to send email every 10 min stat here

        '        WinPop("Job Alarm", EmMsg)
        '        SqlArtiiUp = Nothing
        '        DisCom = Nothing
        '        DisAb = Nothing
        '        sqlCon.Close()
        '        SqlConnection.ClearPool(sqlCon)
        '        'End Using

        'DistrbuteAbuse_Exit:
        '        Me.ArtInt15TableAdapter.Fill(Me.CSSYSDataSet1.ArtInt15)
        '        Exit Sub
        'DistrbuteAbuse_Error: ' what ever error else can happen handel here
        '        MessageBox.Show("Error " & Err.Description, "What Ever error")
        '        Resume DistrbuteAbuse_Exit
        '        Me.ArtInt15TableAdapter.Fill(Me.CSSYSDataSet1.ArtInt15)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FSet.Show()
    End Sub
End Class
