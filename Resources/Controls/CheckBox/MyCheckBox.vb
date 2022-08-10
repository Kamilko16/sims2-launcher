Public Class MyCheckBox
    Private varchecked As Boolean = False
    Private varenabled As Boolean = True

    Public Property Checked() As Boolean
        Get
            Return varchecked
        End Get
        Set(ByVal value As Boolean)
            varchecked = value
            OnChange()
        End Set
    End Property

    Public Property CBEnabled As Boolean
        Get
            Return varenabled
        End Get
        Set(value As Boolean)
            varenabled = value
            OnChange()
        End Set
    End Property


    Private Sub OnChange()
        If varchecked Then
            If varenabled Then
                PictureBox1.Cursor = Cursors.Hand
                PictureBox1.BackgroundImage = My.Resources.checkbox_checked
            Else
                PictureBox1.Cursor = Cursors.Default
                PictureBox1.BackgroundImage = My.Resources.checkbox_checked_disabled
            End If
        Else
            If varenabled Then
                PictureBox1.Cursor = Cursors.Hand
                PictureBox1.BackgroundImage = My.Resources.checkbox
            Else
                PictureBox1.Cursor = Cursors.Default
                PictureBox1.BackgroundImage = My.Resources.checkbox_disabled
            End If
        End If
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        If varenabled Then
            If varchecked Then
                PictureBox1.BackgroundImage = My.Resources.checkbox_checked_hover
            Else
                PictureBox1.BackgroundImage = My.Resources.checkbox_hover
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        If varenabled Then
            If varchecked Then
                PictureBox1.BackgroundImage = My.Resources.checkbox_checked
            Else
                PictureBox1.BackgroundImage = My.Resources.checkbox
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If varenabled Then
            If varchecked Then
                PictureBox1.BackgroundImage = My.Resources.checkbox_checked_click
                varchecked = False
            Else
                PictureBox1.BackgroundImage = My.Resources.checkbox_click
                varchecked = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If varenabled Then
            If varchecked Then
                PictureBox1.BackgroundImage = My.Resources.checkbox_checked_hover
            Else
                PictureBox1.BackgroundImage = My.Resources.checkbox_hover
            End If
        End If
    End Sub

End Class
