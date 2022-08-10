<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyRadioButton
    Inherits System.Windows.Forms.UserControl

    'UserControl przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Radio_Value = New System.Windows.Forms.Label()
        Me.Radio_Picture = New System.Windows.Forms.PictureBox()
        CType(Me.Radio_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Radio_Value
        '
        Me.Radio_Value.AutoSize = True
        Me.Radio_Value.BackColor = System.Drawing.Color.Transparent
        Me.Radio_Value.Location = New System.Drawing.Point(15, 1)
        Me.Radio_Value.Margin = New System.Windows.Forms.Padding(0)
        Me.Radio_Value.Name = "Radio_Value"
        Me.Radio_Value.Size = New System.Drawing.Size(34, 13)
        Me.Radio_Value.TabIndex = 0
        Me.Radio_Value.Text = "Value"
        '
        'Radio_Picture
        '
        Me.Radio_Picture.BackgroundImage = Global.Sims2Launcher.My.Resources.Resources.radio
        Me.Radio_Picture.Location = New System.Drawing.Point(0, 0)
        Me.Radio_Picture.Margin = New System.Windows.Forms.Padding(0)
        Me.Radio_Picture.Name = "Radio_Picture"
        Me.Radio_Picture.Size = New System.Drawing.Size(15, 15)
        Me.Radio_Picture.TabIndex = 1
        Me.Radio_Picture.TabStop = False
        '
        'MyRadioButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Radio_Picture)
        Me.Controls.Add(Me.Radio_Value)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "MyRadioButton"
        Me.Size = New System.Drawing.Size(49, 15)
        CType(Me.Radio_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Radio_Value As Label
    Friend WithEvents Radio_Picture As PictureBox
End Class
