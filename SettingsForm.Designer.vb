<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.FullScreen_Label = New System.Windows.Forms.Label()
        Me.Settings_Label = New System.Windows.Forms.Label()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Language_Label = New System.Windows.Forms.Label()
        Me.Resolution_Label = New System.Windows.Forms.Label()
        Me.Language_ListBox = New Sims2Launcher.MyListBox()
        Me.Resolution_ListBox = New Sims2Launcher.MyListBox()
        Me.FullScreen_CheckBox = New Sims2Launcher.MyCheckBox()
        Me.Splash_Label = New System.Windows.Forms.Label()
        Me.Splash_CheckBox = New Sims2Launcher.MyCheckBox()
        Me.RPC_CheckBox = New Sims2Launcher.MyCheckBox()
        Me.RPC_Label = New System.Windows.Forms.Label()
        Me.MyPanel1 = New Sims2Launcher.MyPanel()
        Me.RPC_Args_Box = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'FullScreen_Label
        '
        Me.FullScreen_Label.AutoSize = True
        Me.FullScreen_Label.BackColor = System.Drawing.Color.Transparent
        Me.FullScreen_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FullScreen_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.FullScreen_Label.Location = New System.Drawing.Point(14, 36)
        Me.FullScreen_Label.Name = "FullScreen_Label"
        Me.FullScreen_Label.Size = New System.Drawing.Size(84, 18)
        Me.FullScreen_Label.TabIndex = 25
        Me.FullScreen_Label.Text = "Full screen:"
        '
        'Settings_Label
        '
        Me.Settings_Label.AutoSize = True
        Me.Settings_Label.BackColor = System.Drawing.Color.Transparent
        Me.Settings_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Settings_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Settings_Label.Location = New System.Drawing.Point(13, 4)
        Me.Settings_Label.Name = "Settings_Label"
        Me.Settings_Label.Size = New System.Drawing.Size(76, 24)
        Me.Settings_Label.TabIndex = 27
        Me.Settings_Label.Text = "Settings"
        '
        'Save_Button
        '
        Me.Save_Button.BackColor = System.Drawing.Color.Transparent
        Me.Save_Button.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.button
        Me.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Save_Button.FlatAppearance.BorderSize = 0
        Me.Save_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Save_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Button.Location = New System.Drawing.Point(107, 209)
        Me.Save_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(66, 36)
        Me.Save_Button.TabIndex = 28
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.button
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(183, 209)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(66, 36)
        Me.Cancel_Button.TabIndex = 29
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Language_Label
        '
        Me.Language_Label.AutoSize = True
        Me.Language_Label.BackColor = System.Drawing.Color.Transparent
        Me.Language_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Language_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Language_Label.Location = New System.Drawing.Point(191, 64)
        Me.Language_Label.Name = "Language_Label"
        Me.Language_Label.Size = New System.Drawing.Size(76, 18)
        Me.Language_Label.TabIndex = 30
        Me.Language_Label.Text = "Language:"
        '
        'Resolution_Label
        '
        Me.Resolution_Label.AutoSize = True
        Me.Resolution_Label.BackColor = System.Drawing.Color.Transparent
        Me.Resolution_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Resolution_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Resolution_Label.Location = New System.Drawing.Point(14, 64)
        Me.Resolution_Label.Name = "Resolution_Label"
        Me.Resolution_Label.Size = New System.Drawing.Size(83, 18)
        Me.Resolution_Label.TabIndex = 37
        Me.Resolution_Label.Text = "Resolution:"
        '
        'Language_ListBox
        '
        Me.Language_ListBox.BackColor = System.Drawing.Color.Transparent
        Me.Language_ListBox.BackgroundImage = CType(resources.GetObject("Language_ListBox.BackgroundImage"), System.Drawing.Image)
        Me.Language_ListBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Language_ListBox.Location = New System.Drawing.Point(194, 85)
        Me.Language_ListBox.Name = "Language_ListBox"
        Me.Language_ListBox.SelectedItem = ""
        Me.Language_ListBox.Size = New System.Drawing.Size(145, 70)
        Me.Language_ListBox.TabIndex = 36
        '
        'Resolution_ListBox
        '
        Me.Resolution_ListBox.BackColor = System.Drawing.Color.Transparent
        Me.Resolution_ListBox.BackgroundImage = CType(resources.GetObject("Resolution_ListBox.BackgroundImage"), System.Drawing.Image)
        Me.Resolution_ListBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Resolution_ListBox.Location = New System.Drawing.Point(17, 85)
        Me.Resolution_ListBox.Name = "Resolution_ListBox"
        Me.Resolution_ListBox.SelectedItem = ""
        Me.Resolution_ListBox.Size = New System.Drawing.Size(100, 70)
        Me.Resolution_ListBox.TabIndex = 35
        '
        'FullScreen_CheckBox
        '
        Me.FullScreen_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.FullScreen_CheckBox.Checked = False
        Me.FullScreen_CheckBox.Location = New System.Drawing.Point(103, 39)
        Me.FullScreen_CheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.FullScreen_CheckBox.Name = "FullScreen_CheckBox"
        Me.FullScreen_CheckBox.Size = New System.Drawing.Size(15, 15)
        Me.FullScreen_CheckBox.TabIndex = 31
        '
        'Splash_Label
        '
        Me.Splash_Label.AutoSize = True
        Me.Splash_Label.BackColor = System.Drawing.Color.Transparent
        Me.Splash_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Splash_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Splash_Label.Location = New System.Drawing.Point(191, 36)
        Me.Splash_Label.Name = "Splash_Label"
        Me.Splash_Label.Size = New System.Drawing.Size(57, 18)
        Me.Splash_Label.TabIndex = 38
        Me.Splash_Label.Text = "Splash:"
        '
        'Splash_CheckBox
        '
        Me.Splash_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Splash_CheckBox.Checked = False
        Me.Splash_CheckBox.Location = New System.Drawing.Point(252, 39)
        Me.Splash_CheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.Splash_CheckBox.Name = "Splash_CheckBox"
        Me.Splash_CheckBox.Size = New System.Drawing.Size(15, 15)
        Me.Splash_CheckBox.TabIndex = 39
        '
        'RPC_CheckBox
        '
        Me.RPC_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.RPC_CheckBox.Checked = False
        Me.RPC_CheckBox.Location = New System.Drawing.Point(62, 172)
        Me.RPC_CheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.RPC_CheckBox.Name = "RPC_CheckBox"
        Me.RPC_CheckBox.Size = New System.Drawing.Size(15, 15)
        Me.RPC_CheckBox.TabIndex = 40
        '
        'RPC_Label
        '
        Me.RPC_Label.AutoSize = True
        Me.RPC_Label.BackColor = System.Drawing.Color.Transparent
        Me.RPC_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RPC_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.RPC_Label.Location = New System.Drawing.Point(14, 169)
        Me.RPC_Label.Name = "RPC_Label"
        Me.RPC_Label.Size = New System.Drawing.Size(44, 18)
        Me.RPC_Label.TabIndex = 41
        Me.RPC_Label.Text = "RPC:"
        '
        'MyPanel1
        '
        Me.MyPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel1.BackgroundImage = CType(resources.GetObject("MyPanel1.BackgroundImage"), System.Drawing.Image)
        Me.MyPanel1.Location = New System.Drawing.Point(80, 164)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(259, 30)
        Me.MyPanel1.TabIndex = 42
        '
        'RPC_Args_Box
        '
        Me.RPC_Args_Box.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.RPC_Args_Box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RPC_Args_Box.Location = New System.Drawing.Point(85, 172)
        Me.RPC_Args_Box.Name = "RPC_Args_Box"
        Me.RPC_Args_Box.Size = New System.Drawing.Size(249, 13)
        Me.RPC_Args_Box.TabIndex = 43
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.settings_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(357, 250)
        Me.Controls.Add(Me.RPC_Args_Box)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.RPC_Label)
        Me.Controls.Add(Me.RPC_CheckBox)
        Me.Controls.Add(Me.Splash_CheckBox)
        Me.Controls.Add(Me.Splash_Label)
        Me.Controls.Add(Me.Resolution_Label)
        Me.Controls.Add(Me.Language_ListBox)
        Me.Controls.Add(Me.Resolution_ListBox)
        Me.Controls.Add(Me.FullScreen_CheckBox)
        Me.Controls.Add(Me.Language_Label)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.Settings_Label)
        Me.Controls.Add(Me.FullScreen_Label)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Sims2Launcher.My.Resources.Resources.settings_icon
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FullScreen_Label As Label
    Friend WithEvents Settings_Label As Label
    Friend WithEvents Save_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Language_Label As Label
    Friend WithEvents FullScreen_CheckBox As MyCheckBox
    Friend WithEvents Resolution_ListBox As MyListBox
    Friend WithEvents Language_ListBox As MyListBox
    Friend WithEvents Resolution_Label As Label
    Friend WithEvents Splash_Label As Label
    Friend WithEvents Splash_CheckBox As MyCheckBox
    Friend WithEvents RPC_CheckBox As MyCheckBox
    Friend WithEvents RPC_Label As Label
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents RPC_Args_Box As TextBox
End Class
