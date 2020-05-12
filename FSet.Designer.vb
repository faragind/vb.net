<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FSet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSet))
        Me.TJob1 = New System.Windows.Forms.CheckBox()
        Me.Exit_ = New System.Windows.Forms.Button()
        Me.TxtFEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SettingA = New System.Windows.Forms.TabControl()
        Me.Emails = New System.Windows.Forms.TabPage()
        Me.TxtAEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Stmps = New System.Windows.Forms.TabPage()
        Me.TxtStmpH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtStmpR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtStmpP = New System.Windows.Forms.TextBox()
        Me.TxtStmpU = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.JobEnb = New System.Windows.Forms.TabPage()
        Me.TJob2 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Emplbl = New System.Windows.Forms.ToolStripLabel()
        Me.EmpNo = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TxtEmpN = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SettingA.SuspendLayout()
        Me.Emails.SuspendLayout()
        Me.Stmps.SuspendLayout()
        Me.JobEnb.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TJob1
        '
        Me.TJob1.AutoSize = True
        Me.TJob1.Location = New System.Drawing.Point(6, 70)
        Me.TJob1.Name = "TJob1"
        Me.TJob1.Size = New System.Drawing.Size(177, 25)
        Me.TJob1.TabIndex = 41
        Me.TJob1.Text = "Update Works /Day"
        Me.TJob1.UseVisualStyleBackColor = True
        '
        'Exit_
        '
        Me.Exit_.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exit_.BackColor = System.Drawing.Color.Transparent
        Me.Exit_.BackgroundImage = Global.AtriiV2.My.Resources.Resources.recpurple
        Me.Exit_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Exit_.FlatAppearance.BorderSize = 0
        Me.Exit_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_.ForeColor = System.Drawing.Color.DarkBlue
        Me.Exit_.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Exit_.ImageKey = "exit48.ico"
        Me.Exit_.ImageList = Me.ImageList1
        Me.Exit_.Location = New System.Drawing.Point(648, 335)
        Me.Exit_.Name = "Exit_"
        Me.Exit_.Size = New System.Drawing.Size(131, 48)
        Me.Exit_.TabIndex = 2
        Me.Exit_.Tag = "Exit"
        Me.Exit_.Text = "Exit"
        Me.Exit_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Exit_.UseVisualStyleBackColor = True
        '
        'TxtFEmail
        '
        Me.TxtFEmail.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFEmail.Location = New System.Drawing.Point(175, 43)
        Me.TxtFEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtFEmail.Name = "TxtFEmail"
        Me.TxtFEmail.Size = New System.Drawing.Size(432, 29)
        Me.TxtFEmail.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Send From:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SettingA
        '
        Me.SettingA.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.SettingA.Controls.Add(Me.Emails)
        Me.SettingA.Controls.Add(Me.Stmps)
        Me.SettingA.Controls.Add(Me.JobEnb)
        Me.SettingA.ImageList = Me.ImageList1
        Me.SettingA.Location = New System.Drawing.Point(12, 12)
        Me.SettingA.Name = "SettingA"
        Me.SettingA.SelectedIndex = 0
        Me.SettingA.Size = New System.Drawing.Size(752, 293)
        Me.SettingA.TabIndex = 15
        '
        'Emails
        '
        Me.Emails.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Emails.Controls.Add(Me.TxtAEmail)
        Me.Emails.Controls.Add(Me.Label1)
        Me.Emails.Controls.Add(Me.Label3)
        Me.Emails.Controls.Add(Me.TxtFEmail)
        Me.Emails.ImageKey = "Email (21).ico"
        Me.Emails.Location = New System.Drawing.Point(4, 42)
        Me.Emails.Name = "Emails"
        Me.Emails.Padding = New System.Windows.Forms.Padding(3)
        Me.Emails.Size = New System.Drawing.Size(744, 247)
        Me.Emails.TabIndex = 1
        Me.Emails.Text = "Email"
        '
        'TxtAEmail
        '
        Me.TxtAEmail.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAEmail.Location = New System.Drawing.Point(175, 9)
        Me.TxtAEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtAEmail.Name = "TxtAEmail"
        Me.TxtAEmail.Size = New System.Drawing.Size(432, 29)
        Me.TxtAEmail.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Admin Email:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Stmps
        '
        Me.Stmps.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Stmps.Controls.Add(Me.TxtStmpH)
        Me.Stmps.Controls.Add(Me.Label2)
        Me.Stmps.Controls.Add(Me.TxtStmpR)
        Me.Stmps.Controls.Add(Me.Label4)
        Me.Stmps.Controls.Add(Me.Label6)
        Me.Stmps.Controls.Add(Me.TxtStmpP)
        Me.Stmps.Controls.Add(Me.TxtStmpU)
        Me.Stmps.Controls.Add(Me.Label5)
        Me.Stmps.ImageKey = "Server.bmp"
        Me.Stmps.Location = New System.Drawing.Point(4, 42)
        Me.Stmps.Name = "Stmps"
        Me.Stmps.Padding = New System.Windows.Forms.Padding(3)
        Me.Stmps.Size = New System.Drawing.Size(744, 247)
        Me.Stmps.TabIndex = 0
        Me.Stmps.Text = "Stmp"
        '
        'TxtStmpH
        '
        Me.TxtStmpH.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStmpH.Location = New System.Drawing.Point(125, 9)
        Me.TxtStmpH.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtStmpH.Name = "TxtStmpH"
        Me.TxtStmpH.Size = New System.Drawing.Size(482, 29)
        Me.TxtStmpH.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Port:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtStmpR
        '
        Me.TxtStmpR.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStmpR.Location = New System.Drawing.Point(125, 97)
        Me.TxtStmpR.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtStmpR.Name = "TxtStmpR"
        Me.TxtStmpR.Size = New System.Drawing.Size(482, 29)
        Me.TxtStmpR.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "PassWord:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Host:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtStmpP
        '
        Me.TxtStmpP.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStmpP.Location = New System.Drawing.Point(125, 67)
        Me.TxtStmpP.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtStmpP.Name = "TxtStmpP"
        Me.TxtStmpP.Size = New System.Drawing.Size(482, 29)
        Me.TxtStmpP.TabIndex = 17
        '
        'TxtStmpU
        '
        Me.TxtStmpU.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStmpU.Location = New System.Drawing.Point(125, 38)
        Me.TxtStmpU.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtStmpU.Name = "TxtStmpU"
        Me.TxtStmpU.Size = New System.Drawing.Size(482, 29)
        Me.TxtStmpU.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 41)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "UserName:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'JobEnb
        '
        Me.JobEnb.Controls.Add(Me.TJob2)
        Me.JobEnb.Controls.Add(Me.Label7)
        Me.JobEnb.Controls.Add(Me.TJob1)
        Me.JobEnb.Controls.Add(Me.ToolStrip1)
        Me.JobEnb.ImageKey = "jokosher.png"
        Me.JobEnb.Location = New System.Drawing.Point(4, 42)
        Me.JobEnb.Name = "JobEnb"
        Me.JobEnb.Padding = New System.Windows.Forms.Padding(3)
        Me.JobEnb.Size = New System.Drawing.Size(744, 247)
        Me.JobEnb.TabIndex = 2
        Me.JobEnb.Text = "Job"
        Me.JobEnb.UseVisualStyleBackColor = True
        '
        'TJob2
        '
        Me.TJob2.AutoSize = True
        Me.TJob2.Location = New System.Drawing.Point(6, 101)
        Me.TJob2.Name = "TJob2"
        Me.TJob2.Size = New System.Drawing.Size(186, 25)
        Me.TJob2.TabIndex = 43
        Me.TJob2.Text = "Complains Distribute"
        Me.TJob2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 27)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Job Enabled"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Emplbl, Me.EmpNo, Me.ToolStripSeparator1, Me.Button3, Me.ToolStripSeparator2, Me.TxtEmpN, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(738, 29)
        Me.ToolStrip1.TabIndex = 40
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Emplbl
        '
        Me.Emplbl.ActiveLinkColor = System.Drawing.Color.White
        Me.Emplbl.BackColor = System.Drawing.Color.Lime
        Me.Emplbl.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Emplbl.Name = "Emplbl"
        Me.Emplbl.Size = New System.Drawing.Size(223, 26)
        Me.Emplbl.Text = "رقم كود المستخدم المسؤل عن سوء المعاملة"
        Me.Emplbl.VisitedLinkColor = System.Drawing.Color.White
        '
        'EmpNo
        '
        Me.EmpNo.BackColor = System.Drawing.Color.Lime
        Me.EmpNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.EmpNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EmpNo.MaxLength = 5
        Me.EmpNo.Name = "EmpNo"
        Me.EmpNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EmpNo.Size = New System.Drawing.Size(60, 29)
        Me.EmpNo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'Button3
        '
        Me.Button3.AutoSize = False
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.AtriiV2.My.Resources.Resources.recgreen
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.Button3.Image = Global.AtriiV2.My.Resources.Resources.recblue
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.ImageTransparentColor = System.Drawing.Color.Lime
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 25)
        Me.Button3.Tag = "أكد الإدخال"
        Me.Button3.Text = "أكد الإدخال"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'TxtEmpN
        '
        Me.TxtEmpN.BackColor = System.Drawing.Color.Lime
        Me.TxtEmpN.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.TxtEmpN.Name = "TxtEmpN"
        Me.TxtEmpN.ReadOnly = True
        Me.TxtEmpN.Size = New System.Drawing.Size(200, 29)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.SystemColors.Control
        Me.ImageList1.Images.SetKeyName(0, "Server.bmp")
        Me.ImageList1.Images.SetKeyName(1, "Email (21).ico")
        Me.ImageList1.Images.SetKeyName(2, "jokosher.png")
        Me.ImageList1.Images.SetKeyName(3, "exit48.ico")
        '
        'FSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AtriiV2.My.Resources.Resources.ArtiiP4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(791, 395)
        Me.Controls.Add(Me.SettingA)
        Me.Controls.Add(Me.Exit_)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        Me.TopMost = True
        Me.SettingA.ResumeLayout(False)
        Me.Emails.ResumeLayout(False)
        Me.Emails.PerformLayout()
        Me.Stmps.ResumeLayout(False)
        Me.Stmps.PerformLayout()
        Me.JobEnb.ResumeLayout(False)
        Me.JobEnb.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Exit_ As Button
    Friend WithEvents TxtFEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SettingA As TabControl
    Friend WithEvents Stmps As TabPage
    Friend WithEvents TxtStmpH As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtStmpR As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtStmpP As TextBox
    Friend WithEvents TxtStmpU As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Emails As TabPage
    Friend WithEvents TxtAEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents JobEnb As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Emplbl As ToolStripLabel
    Friend WithEvents EmpNo As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Button3 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TxtEmpN As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TJob2 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TJob1 As CheckBox
    Friend WithEvents ImageList1 As ImageList
End Class
