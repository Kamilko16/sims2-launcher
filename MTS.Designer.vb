<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MTS
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
        Me.MainBW = New System.ComponentModel.BackgroundWorker()
        Me.App_Title = New System.Windows.Forms.Label()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MainBW
        '
        '
        'App_Title
        '
        Me.App_Title.BackColor = System.Drawing.Color.Transparent
        Me.App_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.App_Title.ForeColor = System.Drawing.Color.White
        Me.App_Title.Location = New System.Drawing.Point(10, 0)
        Me.App_Title.Name = "App_Title"
        Me.App_Title.Size = New System.Drawing.Size(738, 60)
        Me.App_Title.TabIndex = 25
        Me.App_Title.Text = "Mod The Sims"
        Me.App_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Close_Button.Location = New System.Drawing.Point(751, 9)
        Me.Close_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(40, 40)
        Me.Close_Button.TabIndex = 24
        Me.Close_Button.UseVisualStyleBackColor = False
        '
        'MTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.mts_background
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.App_Title)
        Me.Controls.Add(Me.Close_Button)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.Sims2Launcher.My.Resources.Resources.mts
        Me.MaximizeBox = False
        Me.Name = "MTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mod The Sims"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents App_Title As Label
    Friend WithEvents Close_Button As Button
End Class
