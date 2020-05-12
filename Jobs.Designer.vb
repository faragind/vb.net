<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jobs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jobs))
        Dim Needle1 As Syncfusion.Windows.Forms.Gauge.Needle = New Syncfusion.Windows.Forms.Gauge.Needle()
        Dim Needle2 As Syncfusion.Windows.Forms.Gauge.Needle = New Syncfusion.Windows.Forms.Gauge.Needle()
        Dim Range1 As Syncfusion.Windows.Forms.Gauge.Range = New Syncfusion.Windows.Forms.Gauge.Range()
        Dim Range2 As Syncfusion.Windows.Forms.Gauge.Range = New Syncfusion.Windows.Forms.Gauge.Range()
        Dim Range3 As Syncfusion.Windows.Forms.Gauge.Range = New Syncfusion.Windows.Forms.Gauge.Range()
        Dim Range4 As Syncfusion.Windows.Forms.Gauge.Range = New Syncfusion.Windows.Forms.Gauge.Range()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ImgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.LbRWDU = New System.Windows.Forms.Label()
        Me.LbDsCmO = New System.Windows.Forms.Label()
        Me.LbDsCmA = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LbMain = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LbFootStatus = New System.Windows.Forms.StatusStrip()
        Me.LbFoot = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PrgrBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.RadialGauge1 = New Syncfusion.Windows.Forms.Gauge.RadialGauge()
        Me.ArtiiGrView = New System.Windows.Forms.DataGridView()
        Me.LbFootStatus.SuspendLayout()
        CType(Me.ArtiiGrView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.AtriiV2.My.Resources.Resources.recblue
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImgLst
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 41)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Setting"
        Me.Button3.UseMnemonic = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ImgLst
        '
        Me.ImgLst.ImageStream = CType(resources.GetObject("ImgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgLst.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgLst.Images.SetKeyName(0, "Calc48..bmp")
        Me.ImgLst.Images.SetKeyName(1, "exit48.bmp")
        Me.ImgLst.Images.SetKeyName(2, "SpCat48.bmp")
        Me.ImgLst.Images.SetKeyName(3, "Ger048.bmp")
        '
        'LbRWDU
        '
        Me.LbRWDU.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LbRWDU.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.LbRWDU.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbRWDU.Location = New System.Drawing.Point(195, 100)
        Me.LbRWDU.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbRWDU.Name = "LbRWDU"
        Me.LbRWDU.Size = New System.Drawing.Size(722, 20)
        Me.LbRWDU.TabIndex = 45
        Me.LbRWDU.Text = "Waiting to Star Job"
        '
        'LbDsCmO
        '
        Me.LbDsCmO.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LbDsCmO.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.LbDsCmO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbDsCmO.Location = New System.Drawing.Point(195, 184)
        Me.LbDsCmO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbDsCmO.Name = "LbDsCmO"
        Me.LbDsCmO.Size = New System.Drawing.Size(722, 20)
        Me.LbDsCmO.TabIndex = 44
        Me.LbDsCmO.Text = "Waiting to Star Job"
        '
        'LbDsCmA
        '
        Me.LbDsCmA.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LbDsCmA.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.LbDsCmA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbDsCmA.Location = New System.Drawing.Point(195, 162)
        Me.LbDsCmA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbDsCmA.Name = "LbDsCmA"
        Me.LbDsCmA.Size = New System.Drawing.Size(722, 20)
        Me.LbDsCmA.TabIndex = 43
        Me.LbDsCmA.Text = "Waiting to Star Job"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.AtriiV2.My.Resources.Resources.recyellow
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Brown
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageKey = "SpCat48.bmp"
        Me.Button2.ImageList = Me.ImgLst
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(12, 162)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Button2.Size = New System.Drawing.Size(175, 52)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "          Distribute Complains"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LbMain
        '
        Me.LbMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LbMain.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.LbMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbMain.Location = New System.Drawing.Point(12, 56)
        Me.LbMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbMain.Name = "LbMain"
        Me.LbMain.Size = New System.Drawing.Size(902, 20)
        Me.LbMain.TabIndex = 41
        Me.LbMain.Text = "Waiting to Star Job"
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.AtriiV2.My.Resources.Resources.recyellow
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Brown
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageKey = "Calc48..bmp"
        Me.Button1.ImageList = Me.ImgLst
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(12, 100)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Button1.Size = New System.Drawing.Size(175, 52)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "      Updating Works day Manual"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'LbFootStatus
        '
        Me.LbFootStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbFootStatus.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFootStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LbFoot, Me.PrgrBar1})
        Me.LbFootStatus.Location = New System.Drawing.Point(0, 685)
        Me.LbFootStatus.Name = "LbFootStatus"
        Me.LbFootStatus.Size = New System.Drawing.Size(1212, 24)
        Me.LbFootStatus.TabIndex = 47
        Me.LbFootStatus.Text = "StatusStrip1"
        '
        'LbFoot
        '
        Me.LbFoot.ForeColor = System.Drawing.Color.Navy
        Me.LbFoot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LbFoot.Name = "LbFoot"
        Me.LbFoot.Size = New System.Drawing.Size(645, 19)
        Me.LbFoot.Spring = True
        Me.LbFoot.Text = "..."
        Me.LbFoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrgrBar1
        '
        Me.PrgrBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PrgrBar1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrgrBar1.Name = "PrgrBar1"
        Me.PrgrBar1.Size = New System.Drawing.Size(550, 18)
        Me.PrgrBar1.Step = 1
        Me.PrgrBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PrgrBar1.ToolTipText = "Progressing"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3600000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 300000
        '
        'RadialGauge1
        '
        Me.RadialGauge1.ArcThickness = 2.0!
        Me.RadialGauge1.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadialGauge1.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadialGauge1.EnableCustomNeedles = False
        Me.RadialGauge1.FillColor = System.Drawing.Color.Transparent
        Me.RadialGauge1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadialGauge1.FrameThickness = 12
        Me.RadialGauge1.GaugeArcColor = System.Drawing.Color.Yellow
        Me.RadialGauge1.GaugeLabel = "%"
        Me.RadialGauge1.GaugeLableColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadialGauge1.GaugeLableFont = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadialGauge1.GaugeValueColor = System.Drawing.Color.White
        Me.RadialGauge1.GaugeValueFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadialGauge1.InnerFrameGradientEndColor = System.Drawing.Color.LemonChiffon
        Me.RadialGauge1.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadialGauge1.InterLinesColor = System.Drawing.Color.Red
        Me.RadialGauge1.Location = New System.Drawing.Point(980, -6)
        Me.RadialGauge1.MajorDifference = 10.0!
        Me.RadialGauge1.MajorTickMarkColor = System.Drawing.Color.Maroon
        Me.RadialGauge1.MaximumValue = 100.0!
        Me.RadialGauge1.MinimumSize = New System.Drawing.Size(125, 125)
        Me.RadialGauge1.MinorTickMarkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadialGauge1.Name = "RadialGauge1"
        Needle1.Name = "Needle1"
        Needle1.NeedleColor = System.Drawing.Color.Gray
        Needle1.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced
        Needle1.Value = 0!
        Needle2.Name = "Needle2"
        Needle2.NeedleColor = System.Drawing.Color.DarkRed
        Needle2.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced
        Needle2.Value = 30.0!
        Me.RadialGauge1.NeedleCollection.Add(Needle1)
        Me.RadialGauge1.NeedleCollection.Add(Needle2)
        Me.RadialGauge1.NeedleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadialGauge1.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced
        Me.RadialGauge1.OuterFrameGradientEndColor = System.Drawing.Color.Khaki
        Me.RadialGauge1.OuterFrameGradientStartColor = System.Drawing.Color.LemonChiffon
        Range1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Range1.EndValue = 30.0!
        Range1.Height = 5
        Range1.InRange = False
        Range1.Name = "GaugeRange1"
        Range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside
        Range1.StartValue = 0!
        Range2.Color = System.Drawing.Color.Lime
        Range2.EndValue = 60.0!
        Range2.Height = 5
        Range2.InRange = False
        Range2.Name = "GaugeRange2"
        Range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside
        Range2.StartValue = 30.0!
        Range3.Color = System.Drawing.Color.Yellow
        Range3.EndValue = 90.0!
        Range3.Height = 5
        Range3.InRange = False
        Range3.Name = "GaugeRange3"
        Range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside
        Range3.StartValue = 60.0!
        Range4.Color = System.Drawing.Color.Red
        Range4.EndValue = 100.0!
        Range4.Height = 5
        Range4.InRange = False
        Range4.Name = "GaugeRange4"
        Range4.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside
        Range4.StartValue = 90.0!
        Me.RadialGauge1.Ranges.Add(Range1)
        Me.RadialGauge1.Ranges.Add(Range2)
        Me.RadialGauge1.Ranges.Add(Range3)
        Me.RadialGauge1.Ranges.Add(Range4)
        Me.RadialGauge1.ScaleLabelColor = System.Drawing.Color.Red
        Me.RadialGauge1.ShowTicks = True
        Me.RadialGauge1.Size = New System.Drawing.Size(232, 232)
        Me.RadialGauge1.StartAngle = 115
        Me.RadialGauge1.SweepAngle = 310
        Me.RadialGauge1.TabIndex = 48
        Me.RadialGauge1.TextOrientation = Syncfusion.Windows.Forms.Gauge.TextOrientation.SlideOver
        Me.RadialGauge1.ThemeStyle.ArcColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadialGauge1.ThemeStyle.ArcThickness = 20.0!
        '
        'ArtiiGrView
        '
        Me.ArtiiGrView.AllowUserToAddRows = False
        Me.ArtiiGrView.AllowUserToDeleteRows = False
        Me.ArtiiGrView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ArtiiGrView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ArtiiGrView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ArtiiGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArtiiGrView.Location = New System.Drawing.Point(0, 223)
        Me.ArtiiGrView.MultiSelect = False
        Me.ArtiiGrView.Name = "ArtiiGrView"
        Me.ArtiiGrView.ReadOnly = True
        Me.ArtiiGrView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.ArtiiGrView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Transparent
        Me.ArtiiGrView.RowTemplate.Height = 30
        Me.ArtiiGrView.RowTemplate.ReadOnly = True
        Me.ArtiiGrView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ArtiiGrView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ArtiiGrView.Size = New System.Drawing.Size(1212, 459)
        Me.ArtiiGrView.TabIndex = 49
        Me.ArtiiGrView.TabStop = False
        '
        'Jobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1212, 709)
        Me.Controls.Add(Me.ArtiiGrView)
        Me.Controls.Add(Me.RadialGauge1)
        Me.Controls.Add(Me.LbFootStatus)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LbRWDU)
        Me.Controls.Add(Me.LbDsCmO)
        Me.Controls.Add(Me.LbDsCmA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LbMain)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Jobs"
        Me.Text = "Job"
        Me.LbFootStatus.ResumeLayout(False)
        Me.LbFootStatus.PerformLayout()
        CType(Me.ArtiiGrView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents LbRWDU As Label
    Friend WithEvents LbDsCmO As Label
    Friend WithEvents LbDsCmA As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents LbMain As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ImgLst As ImageList
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents LbFootStatus As StatusStrip
    Friend WithEvents LbFoot As ToolStripStatusLabel
    Friend WithEvents PrgrBar1 As ToolStripProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents RadialGauge1 As Syncfusion.Windows.Forms.Gauge.RadialGauge
    Friend WithEvents ArtiiGrView As DataGridView
End Class
