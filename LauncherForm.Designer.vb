<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LauncherForm
    Inherits Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Expansions_Label = New System.Windows.Forms.Label()
        Me.Play_Button = New System.Windows.Forms.Button()
        Me.EP1_Image = New System.Windows.Forms.PictureBox()
        Me.EP2_Image = New System.Windows.Forms.PictureBox()
        Me.EP3_Image = New System.Windows.Forms.PictureBox()
        Me.EP4_Image = New System.Windows.Forms.PictureBox()
        Me.EP5_Image = New System.Windows.Forms.PictureBox()
        Me.EP6_Image = New System.Windows.Forms.PictureBox()
        Me.EP7_Image = New System.Windows.Forms.PictureBox()
        Me.EP8_Image = New System.Windows.Forms.PictureBox()
        Me.Accessories_Label = New System.Windows.Forms.Label()
        Me.SP1_Image = New System.Windows.Forms.PictureBox()
        Me.SP2_Image = New System.Windows.Forms.PictureBox()
        Me.SP4_Image = New System.Windows.Forms.PictureBox()
        Me.SP5_Image = New System.Windows.Forms.PictureBox()
        Me.SP6_Image = New System.Windows.Forms.PictureBox()
        Me.SP7_Image = New System.Windows.Forms.PictureBox()
        Me.SP8_Image = New System.Windows.Forms.PictureBox()
        Me.EP9_Image = New System.Windows.Forms.PictureBox()
        Me.Base_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.App_Title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Settings_Button = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CC_Button = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.EP1_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP2_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP3_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP4_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP5_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP6_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP7_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP8_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP1_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP2_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP4_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP5_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP6_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP7_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP8_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP9_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Expansions_Label
        '
        Me.Expansions_Label.AutoSize = True
        Me.Expansions_Label.BackColor = System.Drawing.Color.Transparent
        Me.Expansions_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Expansions_Label.Location = New System.Drawing.Point(150, 70)
        Me.Expansions_Label.Name = "Expansions_Label"
        Me.Expansions_Label.Size = New System.Drawing.Size(131, 16)
        Me.Expansions_Label.TabIndex = 0
        Me.Expansions_Label.Text = "Expansion Packs:"
        '
        'Play_Button
        '
        Me.Play_Button.BackColor = System.Drawing.Color.Transparent
        Me.Play_Button.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.play
        Me.Play_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Play_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Play_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Play_Button.FlatAppearance.BorderSize = 0
        Me.Play_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Play_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Play_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Play_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Play_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Play_Button.Location = New System.Drawing.Point(144, 233)
        Me.Play_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Play_Button.Name = "Play_Button"
        Me.Play_Button.Size = New System.Drawing.Size(423, 102)
        Me.Play_Button.TabIndex = 1
        Me.Play_Button.Text = " Play"
        Me.Play_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Play_Button.UseVisualStyleBackColor = False
        '
        'EP1_Image
        '
        Me.EP1_Image.BackColor = System.Drawing.Color.Transparent
        Me.EP1_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2EP1
        Me.EP1_Image.Location = New System.Drawing.Point(153, 89)
        Me.EP1_Image.Name = "EP1_Image"
        Me.EP1_Image.Size = New System.Drawing.Size(48, 48)
        Me.EP1_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EP1_Image.TabIndex = 2
        Me.EP1_Image.TabStop = False
        Me.EP1_Image.Tag = "Icon"
        '
        'EP2_Image
        '
        Me.EP2_Image.BackColor = System.Drawing.Color.Transparent
        Me.EP2_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2EP2
        Me.EP2_Image.Location = New System.Drawing.Point(204, 89)
        Me.EP2_Image.Name = "EP2_Image"
        Me.EP2_Image.Size = New System.Drawing.Size(48, 48)
        Me.EP2_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EP2_Image.TabIndex = 3
        Me.EP2_Image.TabStop = False
        Me.EP2_Image.Tag = "Icon"
        '
        'EP3_Image
        '
        Me.EP3_Image.BackColor = System.Drawing.Color.Transparent
        Me.EP3_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2EP3
        Me.EP3_Image.Location = New System.Drawing.Point(255, 89)
        Me.EP3_Image.Name = "EP3_Image"
        Me.EP3_Image.Size = New System.Drawing.Size(48, 48)
        Me.EP3_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EP3_Image.TabIndex = 4
        Me.EP3_Image.TabStop = False
        Me.EP3_Image.Tag = "Icon"
        '
        'EP4_Image
        '
        Me.EP4_Image.BackColor = System.Drawing.Color.Transparent
        Me.EP4_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2EP4
        Me.EP4_Image.Location = New System.Drawing.Point(306, 89)
        Me.EP4_Image.Name = "EP4_Image"
        Me.EP4_Image.Size = New System.Drawing.Size(48, 48)
        Me.EP4_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EP4_Image.TabIndex = 5
        Me.EP4_Image.TabStop = False
        Me.EP4_Image.Tag = "Icon"
        '
        'EP5_Image
        '
        Me.EP5_Image.BackColor = System.Drawing.Color.Transparent
        Me.EP5_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2EP5
        Me.EP5_Image.Location = New System.Drawing.Point(357, 89)
        Me.EP5_Image.Name = "EP5_Image"
        Me.EP5_Image.Size = New System.Drawing.Size(48, 48)
        Me.EP5_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EP5_Image.TabIndex = 6
        Me.EP5_Image.TabStop = False
        Me.EP5_Image.Tag = "Icon"
        '
        'EP6_Image
        '
        Me.EP6_Image.BackColor = System.Drawing.Color.Transparent
        Me.EP6_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2EP6
        Me.EP6_Image.Location = New System.Drawing.Point(408, 89)
        Me.EP6_Image.Name = "EP6_Image"
        Me.EP6_Image.Size = New System.Drawing.Size(48, 48)
        Me.EP6_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EP6_Image.TabIndex = 7
        Me.EP6_Image.TabStop = False
        Me.EP6_Image.Tag = "Icon"
        '
        'EP7_Image
        '
        Me.EP7_Image.BackColor = System.Drawing.Color.Transparent
        Me.EP7_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2EP7
        Me.EP7_Image.Location = New System.Drawing.Point(459, 89)
        Me.EP7_Image.Name = "EP7_Image"
        Me.EP7_Image.Size = New System.Drawing.Size(48, 48)
        Me.EP7_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EP7_Image.TabIndex = 8
        Me.EP7_Image.TabStop = False
        Me.EP7_Image.Tag = "Icon"
        '
        'EP8_Image
        '
        Me.EP8_Image.BackColor = System.Drawing.Color.Transparent
        Me.EP8_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2EP8
        Me.EP8_Image.Location = New System.Drawing.Point(510, 89)
        Me.EP8_Image.Name = "EP8_Image"
        Me.EP8_Image.Size = New System.Drawing.Size(48, 48)
        Me.EP8_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EP8_Image.TabIndex = 9
        Me.EP8_Image.TabStop = False
        Me.EP8_Image.Tag = "Icon"
        '
        'Accessories_Label
        '
        Me.Accessories_Label.AutoSize = True
        Me.Accessories_Label.BackColor = System.Drawing.Color.Transparent
        Me.Accessories_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Accessories_Label.Location = New System.Drawing.Point(150, 160)
        Me.Accessories_Label.Name = "Accessories_Label"
        Me.Accessories_Label.Size = New System.Drawing.Size(89, 16)
        Me.Accessories_Label.TabIndex = 10
        Me.Accessories_Label.Text = "Stuff Packs:"
        '
        'SP1_Image
        '
        Me.SP1_Image.BackColor = System.Drawing.Color.Transparent
        Me.SP1_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2SP1
        Me.SP1_Image.Location = New System.Drawing.Point(153, 179)
        Me.SP1_Image.Name = "SP1_Image"
        Me.SP1_Image.Size = New System.Drawing.Size(48, 48)
        Me.SP1_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SP1_Image.TabIndex = 11
        Me.SP1_Image.TabStop = False
        Me.SP1_Image.Tag = "Icon"
        '
        'SP2_Image
        '
        Me.SP2_Image.BackColor = System.Drawing.Color.Transparent
        Me.SP2_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2SP2
        Me.SP2_Image.Location = New System.Drawing.Point(204, 179)
        Me.SP2_Image.Name = "SP2_Image"
        Me.SP2_Image.Size = New System.Drawing.Size(48, 48)
        Me.SP2_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SP2_Image.TabIndex = 12
        Me.SP2_Image.TabStop = False
        Me.SP2_Image.Tag = "Icon"
        '
        'SP4_Image
        '
        Me.SP4_Image.BackColor = System.Drawing.Color.Transparent
        Me.SP4_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2SP4
        Me.SP4_Image.Location = New System.Drawing.Point(255, 179)
        Me.SP4_Image.Name = "SP4_Image"
        Me.SP4_Image.Size = New System.Drawing.Size(48, 48)
        Me.SP4_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SP4_Image.TabIndex = 13
        Me.SP4_Image.TabStop = False
        Me.SP4_Image.Tag = "Icon"
        '
        'SP5_Image
        '
        Me.SP5_Image.BackColor = System.Drawing.Color.Transparent
        Me.SP5_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2SP5
        Me.SP5_Image.Location = New System.Drawing.Point(306, 179)
        Me.SP5_Image.Name = "SP5_Image"
        Me.SP5_Image.Size = New System.Drawing.Size(48, 48)
        Me.SP5_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SP5_Image.TabIndex = 14
        Me.SP5_Image.TabStop = False
        Me.SP5_Image.Tag = "Icon"
        '
        'SP6_Image
        '
        Me.SP6_Image.BackColor = System.Drawing.Color.Transparent
        Me.SP6_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2SP6
        Me.SP6_Image.Location = New System.Drawing.Point(357, 179)
        Me.SP6_Image.Name = "SP6_Image"
        Me.SP6_Image.Size = New System.Drawing.Size(48, 48)
        Me.SP6_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SP6_Image.TabIndex = 15
        Me.SP6_Image.TabStop = False
        Me.SP6_Image.Tag = "Icon"
        '
        'SP7_Image
        '
        Me.SP7_Image.BackColor = System.Drawing.Color.Transparent
        Me.SP7_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2SP7
        Me.SP7_Image.Location = New System.Drawing.Point(408, 179)
        Me.SP7_Image.Name = "SP7_Image"
        Me.SP7_Image.Size = New System.Drawing.Size(48, 48)
        Me.SP7_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SP7_Image.TabIndex = 16
        Me.SP7_Image.TabStop = False
        Me.SP7_Image.Tag = "Icon"
        '
        'SP8_Image
        '
        Me.SP8_Image.BackColor = System.Drawing.Color.Transparent
        Me.SP8_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2SP8
        Me.SP8_Image.Location = New System.Drawing.Point(459, 179)
        Me.SP8_Image.Name = "SP8_Image"
        Me.SP8_Image.Size = New System.Drawing.Size(48, 48)
        Me.SP8_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SP8_Image.TabIndex = 17
        Me.SP8_Image.TabStop = False
        Me.SP8_Image.Tag = "Icon"
        '
        'EP9_Image
        '
        Me.EP9_Image.BackColor = System.Drawing.Color.Transparent
        Me.EP9_Image.Image = Global.Sims2Launcher.My.Resources.Resources.Sims2EP9
        Me.EP9_Image.Location = New System.Drawing.Point(510, 179)
        Me.EP9_Image.Name = "EP9_Image"
        Me.EP9_Image.Size = New System.Drawing.Size(48, 48)
        Me.EP9_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EP9_Image.TabIndex = 18
        Me.EP9_Image.TabStop = False
        Me.EP9_Image.Tag = "Icon"
        '
        'Base_Label
        '
        Me.Base_Label.AutoSize = True
        Me.Base_Label.BackColor = System.Drawing.Color.Transparent
        Me.Base_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Base_Label.Location = New System.Drawing.Point(38, 243)
        Me.Base_Label.Name = "Base_Label"
        Me.Base_Label.Size = New System.Drawing.Size(84, 16)
        Me.Base_Label.TabIndex = 19
        Me.Base_Label.Text = "Body Shop"
        '
        'Timer1
        '
        '
        'Close_Button
        '
        Me.Close_Button.BackColor = System.Drawing.Color.Transparent
        Me.Close_Button.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.close
        Me.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Close_Button.FlatAppearance.BorderSize = 0
        Me.Close_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_Button.ForeColor = System.Drawing.Color.Black
        Me.Close_Button.Location = New System.Drawing.Point(540, 10)
        Me.Close_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(40, 40)
        Me.Close_Button.TabIndex = 22
        Me.Close_Button.UseVisualStyleBackColor = False
        '
        'App_Title
        '
        Me.App_Title.BackColor = System.Drawing.Color.Transparent
        Me.App_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.App_Title.ForeColor = System.Drawing.Color.White
        Me.App_Title.Location = New System.Drawing.Point(50, 0)
        Me.App_Title.Name = "App_Title"
        Me.App_Title.Size = New System.Drawing.Size(407, 60)
        Me.App_Title.TabIndex = 23
        Me.App_Title.Text = "The Sims™ 2 Launcher"
        Me.App_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.Sims2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(10, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Settings_Button
        '
        Me.Settings_Button.BackColor = System.Drawing.Color.Transparent
        Me.Settings_Button.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.settings
        Me.Settings_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Settings_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Settings_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Settings_Button.FlatAppearance.BorderSize = 0
        Me.Settings_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Settings_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Settings_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings_Button.ForeColor = System.Drawing.Color.Black
        Me.Settings_Button.Location = New System.Drawing.Point(500, 10)
        Me.Settings_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Settings_Button.Name = "Settings_Button"
        Me.Settings_Button.Size = New System.Drawing.Size(40, 40)
        Me.Settings_Button.TabIndex = 25
        Me.Settings_Button.UseVisualStyleBackColor = False
        '
        'CC_Button
        '
        Me.CC_Button.BackColor = System.Drawing.Color.Transparent
        Me.CC_Button.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.cc
        Me.CC_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CC_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CC_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CC_Button.FlatAppearance.BorderSize = 0
        Me.CC_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CC_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CC_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CC_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CC_Button.ForeColor = System.Drawing.Color.Black
        Me.CC_Button.Location = New System.Drawing.Point(460, 10)
        Me.CC_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.CC_Button.Name = "CC_Button"
        Me.CC_Button.Size = New System.Drawing.Size(40, 40)
        Me.CC_Button.TabIndex = 26
        Me.CC_Button.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Sims2Launcher.My.Resources.Resources.BodyShop_big
        Me.PictureBox2.Location = New System.Drawing.Point(50, 262)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = Global.Sims2Launcher.My.Resources.Resources.anim1
        Me.PictureBox3.Location = New System.Drawing.Point(10, 67)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(143, 160)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'Timer2
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(419, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "MTS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LauncherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(590, 355)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CC_Button)
        Me.Controls.Add(Me.Settings_Button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.App_Title)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.Base_Label)
        Me.Controls.Add(Me.EP9_Image)
        Me.Controls.Add(Me.SP8_Image)
        Me.Controls.Add(Me.SP7_Image)
        Me.Controls.Add(Me.SP6_Image)
        Me.Controls.Add(Me.SP5_Image)
        Me.Controls.Add(Me.SP4_Image)
        Me.Controls.Add(Me.SP2_Image)
        Me.Controls.Add(Me.SP1_Image)
        Me.Controls.Add(Me.Accessories_Label)
        Me.Controls.Add(Me.EP8_Image)
        Me.Controls.Add(Me.EP7_Image)
        Me.Controls.Add(Me.EP6_Image)
        Me.Controls.Add(Me.EP5_Image)
        Me.Controls.Add(Me.EP4_Image)
        Me.Controls.Add(Me.EP3_Image)
        Me.Controls.Add(Me.EP2_Image)
        Me.Controls.Add(Me.EP1_Image)
        Me.Controls.Add(Me.Play_Button)
        Me.Controls.Add(Me.Expansions_Label)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Sims2Launcher.My.Resources.Resources.Icon
        Me.MaximizeBox = False
        Me.Name = "LauncherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Sims™ 2 Launcher"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.EP1_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP2_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP3_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP4_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP5_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP6_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP7_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP8_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP1_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP2_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP4_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP5_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP6_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP7_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP8_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP9_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Expansions_Label As Label
    Friend WithEvents Play_Button As Button
    Friend WithEvents EP1_Image As PictureBox
    Friend WithEvents EP2_Image As PictureBox
    Friend WithEvents EP3_Image As PictureBox
    Friend WithEvents EP4_Image As PictureBox
    Friend WithEvents EP5_Image As PictureBox
    Friend WithEvents EP6_Image As PictureBox
    Friend WithEvents EP7_Image As PictureBox
    Friend WithEvents EP8_Image As PictureBox
    Friend WithEvents Accessories_Label As Label
    Friend WithEvents SP1_Image As PictureBox
    Friend WithEvents SP2_Image As PictureBox
    Friend WithEvents SP4_Image As PictureBox
    Friend WithEvents SP5_Image As PictureBox
    Friend WithEvents SP6_Image As PictureBox
    Friend WithEvents SP7_Image As PictureBox
    Friend WithEvents SP8_Image As PictureBox
    Friend WithEvents EP9_Image As PictureBox
    Friend WithEvents Base_Label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Close_Button As Button
    Friend WithEvents App_Title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Settings_Button As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents CC_Button As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
End Class
