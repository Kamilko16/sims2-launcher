<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomContentForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomContentForm))
        Me.Search_Box = New System.Windows.Forms.TextBox()
        Me.CC_Label = New System.Windows.Forms.Label()
        Me.MainBW = New System.ComponentModel.BackgroundWorker()
        Me.Search_Tip = New System.Windows.Forms.Label()
        Me.SearchBW = New System.ComponentModel.BackgroundWorker()
        Me.Cancel_Button = New Sims2Launcher.MyButton()
        Me.Save_Button = New Sims2Launcher.MyButton()
        Me.MyPanel1 = New Sims2Launcher.MyPanel()
        Me.CC_ListBox = New Sims2Launcher.MyListBoxCB()
        Me.SuspendLayout()
        '
        'Search_Box
        '
        Me.Search_Box.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Search_Box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Search_Box.Location = New System.Drawing.Point(23, 49)
        Me.Search_Box.Name = "Search_Box"
        Me.Search_Box.Size = New System.Drawing.Size(310, 13)
        Me.Search_Box.TabIndex = 3
        Me.Search_Box.Text = "Search"
        '
        'CC_Label
        '
        Me.CC_Label.AutoSize = True
        Me.CC_Label.BackColor = System.Drawing.Color.Transparent
        Me.CC_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CC_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.CC_Label.Location = New System.Drawing.Point(13, 4)
        Me.CC_Label.Name = "CC_Label"
        Me.CC_Label.Size = New System.Drawing.Size(144, 24)
        Me.CC_Label.TabIndex = 28
        Me.CC_Label.Text = "Custom Content"
        '
        'MainBW
        '
        Me.MainBW.WorkerReportsProgress = True
        '
        'Search_Tip
        '
        Me.Search_Tip.BackColor = System.Drawing.Color.Transparent
        Me.Search_Tip.Location = New System.Drawing.Point(42, 198)
        Me.Search_Tip.Name = "Search_Tip"
        Me.Search_Tip.Size = New System.Drawing.Size(270, 23)
        Me.Search_Tip.TabIndex = 25
        Me.Search_Tip.Text = "Loading..."
        Me.Search_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchBW
        '
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.BackgroundImage = CType(resources.GetObject("Cancel_Button.BackgroundImage"), System.Drawing.Image)
        Me.Cancel_Button.Button_Text = "Cancel"
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(184, 369)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(66, 36)
        Me.Cancel_Button.TabIndex = 30
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Save_Button
        '
        Me.Save_Button.BackColor = System.Drawing.Color.Transparent
        Me.Save_Button.BackgroundImage = CType(resources.GetObject("Save_Button.BackgroundImage"), System.Drawing.Image)
        Me.Save_Button.Button_Text = "Save"
        Me.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save_Button.FlatAppearance.BorderSize = 0
        Me.Save_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Save_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Button.Location = New System.Drawing.Point(108, 369)
        Me.Save_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(66, 36)
        Me.Save_Button.TabIndex = 29
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = False
        '
        'MyPanel1
        '
        Me.MyPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MyPanel1.BackgroundImage = CType(resources.GetObject("MyPanel1.BackgroundImage"), System.Drawing.Image)
        Me.MyPanel1.Location = New System.Drawing.Point(18, 40)
        Me.MyPanel1.Name = "MyPanel1"
        Me.MyPanel1.Size = New System.Drawing.Size(320, 30)
        Me.MyPanel1.TabIndex = 2
        '
        'CC_ListBox
        '
        Me.CC_ListBox.BackColor = System.Drawing.Color.Transparent
        Me.CC_ListBox.BackgroundImage = CType(resources.GetObject("CC_ListBox.BackgroundImage"), System.Drawing.Image)
        Me.CC_ListBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CC_ListBox.Location = New System.Drawing.Point(18, 76)
        Me.CC_ListBox.Name = "CC_ListBox"
        Me.CC_ListBox.SelectedItem = ""
        Me.CC_ListBox.Size = New System.Drawing.Size(320, 280)
        Me.CC_ListBox.TabIndex = 32
        '
        'CustomContentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.cc_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(357, 410)
        Me.Controls.Add(Me.Search_Tip)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.CC_Label)
        Me.Controls.Add(Me.Search_Box)
        Me.Controls.Add(Me.MyPanel1)
        Me.Controls.Add(Me.CC_ListBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Sims2Launcher.My.Resources.Resources.cc_icon
        Me.Name = "CustomContentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomContentForm"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyPanel1 As MyPanel
    Friend WithEvents Search_Box As TextBox
    Friend WithEvents CC_Label As Label
    Friend WithEvents Save_Button As MyButton
    Friend WithEvents Cancel_Button As MyButton
    Friend WithEvents MainBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Search_Tip As Label
    Friend WithEvents CC_ListBox As MyListBoxCB
    Friend WithEvents SearchBW As System.ComponentModel.BackgroundWorker
End Class
