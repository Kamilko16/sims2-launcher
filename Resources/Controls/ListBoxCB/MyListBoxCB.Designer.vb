<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyListBoxCB
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
        Me.Radio_External_Container = New System.Windows.Forms.Panel()
        Me.Radio_Internal_Container = New System.Windows.Forms.Panel()
        Me.ScrollBar = New Sims2Launcher.MyVerticalScrollBarCB()
        Me.Radio_External_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Radio_External_Container
        '
        Me.Radio_External_Container.Controls.Add(Me.Radio_Internal_Container)
        Me.Radio_External_Container.Location = New System.Drawing.Point(5, 5)
        Me.Radio_External_Container.Margin = New System.Windows.Forms.Padding(0)
        Me.Radio_External_Container.Name = "Radio_External_Container"
        Me.Radio_External_Container.Size = New System.Drawing.Size(90, 90)
        Me.Radio_External_Container.TabIndex = 0
        '
        'Radio_Internal_Container
        '
        Me.Radio_Internal_Container.AutoSize = True
        Me.Radio_Internal_Container.Location = New System.Drawing.Point(0, 0)
        Me.Radio_Internal_Container.Margin = New System.Windows.Forms.Padding(0)
        Me.Radio_Internal_Container.Name = "Radio_Internal_Container"
        Me.Radio_Internal_Container.Size = New System.Drawing.Size(90, 90)
        Me.Radio_Internal_Container.TabIndex = 0
        '
        'ScrollBar
        '
        Me.ScrollBar.Location = New System.Drawing.Point(103, 0)
        Me.ScrollBar.Margin = New System.Windows.Forms.Padding(0)
        Me.ScrollBar.Name = "ScrollBar"
        Me.ScrollBar.Size = New System.Drawing.Size(12, 100)
        Me.ScrollBar.TabIndex = 1
        '
        'MyListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.ScrollBar)
        Me.Controls.Add(Me.Radio_External_Container)
        Me.DoubleBuffered = True
        Me.Name = "MyListBox"
        Me.Size = New System.Drawing.Size(115, 100)
        Me.Radio_External_Container.ResumeLayout(False)
        Me.Radio_External_Container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Radio_External_Container As Panel
    Friend WithEvents Radio_Internal_Container As Panel
    Friend WithEvents ScrollBar As MyVerticalScrollBarCB
End Class
