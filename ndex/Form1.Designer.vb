<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnltopp = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.minimize = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.power = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.login = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.verify = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.pnlbott = New System.Windows.Forms.Panel()
        Me.pnlmenuu = New System.Windows.Forms.Panel()
        Me.pnltopp.SuspendLayout()
        Me.pnlmenuu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnltopp
        Me.BunifuDragControl1.Vertical = True
        '
        'pnltopp
        '
        Me.pnltopp.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnltopp.Controls.Add(Me.Label2)
        Me.pnltopp.Controls.Add(Me.minimize)
        Me.pnltopp.Controls.Add(Me.Label1)
        Me.pnltopp.Controls.Add(Me.power)
        Me.pnltopp.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltopp.Location = New System.Drawing.Point(0, 0)
        Me.pnltopp.Name = "pnltopp"
        Me.pnltopp.Size = New System.Drawing.Size(388, 37)
        Me.pnltopp.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fira Sans Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(80, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "App"
        '
        'minimize
        '
        Me.minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize.FlatAppearance.BorderSize = 0
        Me.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimize.ForeColor = System.Drawing.Color.White
        Me.minimize.Image = Global.ndex.My.Resources.Resources.vb_mini
        Me.minimize.Location = New System.Drawing.Point(323, 6)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(23, 26)
        Me.minimize.TabIndex = 5
        Me.minimize.Text = "   "
        Me.minimize.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Sans", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "perpus"
        '
        'power
        '
        Me.power.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.power.Cursor = System.Windows.Forms.Cursors.Hand
        Me.power.FlatAppearance.BorderSize = 0
        Me.power.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.power.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.power.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.power.ForeColor = System.Drawing.Color.White
        Me.power.Image = Global.ndex.My.Resources.Resources.vb_powerr2
        Me.power.Location = New System.Drawing.Point(352, 4)
        Me.power.Name = "power"
        Me.power.Size = New System.Drawing.Size(22, 28)
        Me.power.TabIndex = 6
        Me.power.Text = "    "
        Me.power.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fira Sans", 20.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(150, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "LOGIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fira Sans", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(116, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "As User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fira Sans", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(96, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 14)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Please verified if you're not a user"
        '
        'username
        '
        Me.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.username.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.Enabled = False
        Me.username.Font = New System.Drawing.Font("Fira Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.username.HintForeColor = System.Drawing.Color.DarkGray
        Me.username.HintText = "Username"
        Me.username.isPassword = False
        Me.username.LineFocusedColor = System.Drawing.Color.Transparent
        Me.username.LineIdleColor = System.Drawing.Color.Transparent
        Me.username.LineMouseHoverColor = System.Drawing.Color.Transparent
        Me.username.LineThickness = 1
        Me.username.Location = New System.Drawing.Point(90, 125)
        Me.username.Margin = New System.Windows.Forms.Padding(4)
        Me.username.MaxLength = 30
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(205, 29)
        Me.username.TabIndex = 1
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'login
        '
        Me.login.ActiveBorderThickness = 1
        Me.login.ActiveCornerRadius = 20
        Me.login.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.login.ActiveForecolor = System.Drawing.Color.White
        Me.login.ActiveLineColor = System.Drawing.Color.White
        Me.login.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.login.BackgroundImage = CType(resources.GetObject("login.BackgroundImage"), System.Drawing.Image)
        Me.login.ButtonText = "Login"
        Me.login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.White
        Me.login.IdleBorderThickness = 1
        Me.login.IdleCornerRadius = 20
        Me.login.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.login.IdleForecolor = System.Drawing.Color.White
        Me.login.IdleLineColor = System.Drawing.Color.Transparent
        Me.login.Location = New System.Drawing.Point(90, 261)
        Me.login.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(205, 46)
        Me.login.TabIndex = 4
        Me.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'verify
        '
        Me.verify.BackColor = System.Drawing.Color.LightGray
        Me.verify.ChechedOffColor = System.Drawing.Color.LightGray
        Me.verify.Checked = False
        Me.verify.CheckedOnColor = System.Drawing.Color.RoyalBlue
        Me.verify.ForeColor = System.Drawing.Color.White
        Me.verify.Location = New System.Drawing.Point(90, 222)
        Me.verify.Name = "verify"
        Me.verify.Size = New System.Drawing.Size(20, 20)
        Me.verify.TabIndex = 3
        '
        'password
        '
        Me.password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.password.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.Enabled = False
        Me.password.Font = New System.Drawing.Font("Fira Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.password.HintForeColor = System.Drawing.Color.DarkGray
        Me.password.HintText = "Password ..."
        Me.password.isPassword = True
        Me.password.LineFocusedColor = System.Drawing.Color.Transparent
        Me.password.LineIdleColor = System.Drawing.Color.Transparent
        Me.password.LineMouseHoverColor = System.Drawing.Color.Transparent
        Me.password.LineThickness = 1
        Me.password.Location = New System.Drawing.Point(88, 163)
        Me.password.Margin = New System.Windows.Forms.Padding(5)
        Me.password.MaxLength = 30
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(207, 37)
        Me.password.TabIndex = 2
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlbott
        '
        Me.pnlbott.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlbott.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbott.Location = New System.Drawing.Point(0, 361)
        Me.pnlbott.Name = "pnlbott"
        Me.pnlbott.Size = New System.Drawing.Size(388, 10)
        Me.pnlbott.TabIndex = 23
        '
        'pnlmenuu
        '
        Me.pnlmenuu.AllowDrop = True
        Me.pnlmenuu.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlmenuu.Controls.Add(Me.pnlbott)
        Me.pnlmenuu.Controls.Add(Me.password)
        Me.pnlmenuu.Controls.Add(Me.verify)
        Me.pnlmenuu.Controls.Add(Me.login)
        Me.pnlmenuu.Controls.Add(Me.username)
        Me.pnlmenuu.Controls.Add(Me.Label5)
        Me.pnlmenuu.Controls.Add(Me.Label4)
        Me.pnlmenuu.Controls.Add(Me.Label3)
        Me.pnlmenuu.Controls.Add(Me.pnltopp)
        Me.pnlmenuu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlmenuu.Location = New System.Drawing.Point(0, 0)
        Me.pnlmenuu.Name = "pnlmenuu"
        Me.pnlmenuu.Size = New System.Drawing.Size(388, 371)
        Me.pnlmenuu.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(388, 371)
        Me.Controls.Add(Me.pnlmenuu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form2"
        Me.pnltopp.ResumeLayout(False)
        Me.pnltopp.PerformLayout()
        Me.pnlmenuu.ResumeLayout(False)
        Me.pnlmenuu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnltopp As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents minimize As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents power As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents login As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents verify As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents pnlbott As Panel
    Friend WithEvents pnlmenuu As Panel
End Class
