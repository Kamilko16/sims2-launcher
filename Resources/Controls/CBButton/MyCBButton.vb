Public Class MyCBButton

    Private varchecked As Boolean = False
    Public Property Checked() As Boolean
        Get
            Checked = varchecked
        End Get
        Set(ByVal value As Boolean)
            varchecked = value
            OnChange()
        End Set
    End Property

    Private Sub OnChange()
        If varchecked Then
            PictureBox1.BackgroundImage = My.Resources.checkbox_checked
        Else
            PictureBox1.BackgroundImage = My.Resources.checkbox
        End If
    End Sub
    Private Sub MyCBButton_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter, MyBase.MouseEnter, CB_Value.MouseEnter
        If varchecked Then
            PictureBox1.BackgroundImage = My.Resources.checkbox_checked_hover
        Else
            PictureBox1.BackgroundImage = My.Resources.checkbox_hover
        End If
    End Sub

    Private Sub MyCBButton_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave, MyBase.MouseLeave, CB_Value.MouseLeave
        If varchecked Then
            PictureBox1.BackgroundImage = My.Resources.checkbox_checked
        Else
            PictureBox1.BackgroundImage = My.Resources.checkbox
        End If
    End Sub

    Private Sub MyCBButton_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, MyBase.MouseDown, CB_Value.MouseDown
        If varchecked Then
            PictureBox1.BackgroundImage = My.Resources.checkbox_checked_click
            varchecked = False
        Else
            PictureBox1.BackgroundImage = My.Resources.checkbox_click
            varchecked = True
        End If
    End Sub

    Private Sub MyCBButton_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp, MyBase.MouseUp, CB_Value.MouseUp
        If varchecked Then
            PictureBox1.BackgroundImage = My.Resources.checkbox_checked_hover
        Else
            PictureBox1.BackgroundImage = My.Resources.checkbox_hover
        End If
    End Sub

End Class
