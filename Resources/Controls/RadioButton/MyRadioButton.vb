Public Class MyRadioButton
    Private selected As Boolean = False
    Private Sub MyRadioButton_Click(sender As Object, e As EventArgs) Handles MyBase.Click, Radio_Value.Click, Radio_Picture.Click
        CType(Me.Parent.Parent.Parent, MyListBox).SelectItem(Me)
    End Sub

    Public Sub SelectMe()
        selected = True
        Radio_Picture.BackgroundImage = My.Resources.radio_checked
    End Sub

    Public Sub DeselectMe()
        selected = False
        Radio_Picture.BackgroundImage = My.Resources.radio
    End Sub

    Private Sub MyRadioButton_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, Radio_Value.MouseEnter, Radio_Picture.MouseEnter
        If selected Then
            Radio_Picture.BackgroundImage = My.Resources.radio_checked_hover
        Else
            Radio_Picture.BackgroundImage = My.Resources.radio_hover
        End If
    End Sub

    Private Sub MyRadioButton_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, Radio_Value.MouseLeave, Radio_Picture.MouseLeave
        If selected Then
            Radio_Picture.BackgroundImage = My.Resources.radio_checked
        Else
            Radio_Picture.BackgroundImage = My.Resources.radio
        End If
    End Sub

    Private Sub MyRadioButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Radio_Value.MouseDown, Radio_Picture.MouseDown
        If selected Then
            Radio_Picture.BackgroundImage = My.Resources.radio_checked_click
        Else
            Radio_Picture.BackgroundImage = My.Resources.radio_click
        End If
    End Sub

    Private Sub MyRadioButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Radio_Value.MouseUp, Radio_Picture.MouseUp
        If selected Then
            Radio_Picture.BackgroundImage = My.Resources.radio_checked_hover
        Else
            Radio_Picture.BackgroundImage = My.Resources.radio_hover
        End If
    End Sub
End Class
