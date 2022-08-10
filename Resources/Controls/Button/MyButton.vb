Public Class MyButton

    Property Button_Text As String
        Get
            Return Me.Text
        End Get
        Set(value As String)
            Me.Text = value
        End Set
    End Property

    Private Sub Button_Label_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub Button_Label_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackgroundImage = My.Resources.button
    End Sub

    Private Sub Button_Label_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Me.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub Button_Label_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Me.BackgroundImage = My.Resources.button_hover
    End Sub

End Class
