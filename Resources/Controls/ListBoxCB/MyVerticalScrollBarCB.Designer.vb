<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyVerticalScrollBarCB
    Inherits System.Windows.Forms.UserControl

    'UserControl przesłania metodę dispose, aby wyczyścić listę składników.
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
        Me.ScrollButton = New System.Windows.Forms.PictureBox()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.ScrollButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScrollButton
        '
        Me.ScrollButton.BackColor = System.Drawing.Color.Transparent
        Me.ScrollButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ScrollButton.Location = New System.Drawing.Point(0, 0)
        Me.ScrollButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ScrollButton.Name = "ScrollButton"
        Me.ScrollButton.Size = New System.Drawing.Size(12, 100)
        Me.ScrollButton.TabIndex = 1
        Me.ScrollButton.TabStop = False
        '
        'Background
        '
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Margin = New System.Windows.Forms.Padding(0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(12, 100)
        Me.Background.TabIndex = 0
        Me.Background.TabStop = False
        '
        'MyVerticalScrollBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ScrollButton)
        Me.Controls.Add(Me.Background)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "MyVerticalScrollBar"
        Me.Size = New System.Drawing.Size(12, 100)
        CType(Me.ScrollButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Background As PictureBox
    Friend WithEvents ScrollButton As PictureBox
End Class
