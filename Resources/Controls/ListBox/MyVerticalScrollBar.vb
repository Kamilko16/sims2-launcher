Public Class MyVerticalScrollBar

    Dim image_normal As Image
    Dim image_hover As Image
    Dim image_click As Image

    Private Function CreateBackground(ByVal height As Integer) As Image
        Dim bmp As Bitmap = New Bitmap(12, Math.Max(12, height), Imaging.PixelFormat.Format32bppArgb)

        Dim g As Graphics = Graphics.FromImage(bmp)

        g.DrawImage(My.Resources.verticalscrollbar_background_top, 0, 0)

        For i As Integer = 0 To (height - 13)
            g.DrawImage(My.Resources.verticalscrollbar_background_middle, 0, 6 + i)
        Next

        g.DrawImage(My.Resources.verticalscrollbar_background_bottom, 0, height - 6)

        g.Dispose()

        Return bmp
    End Function

    Private Sub CreateScrollBar(ByVal height As Integer)

        Dim bmp As Bitmap = New Bitmap(12, Math.Max(12, height), Imaging.PixelFormat.Format32bppArgb)

        Dim g As Graphics = Graphics.FromImage(bmp)

        g.DrawImage(My.Resources.verticalscrollbar_top, 0, 0)

        For i As Integer = 0 To (height - 13)
            g.DrawImage(My.Resources.verticalscrollbar_middle, 0, i + 6)
        Next

        g.DrawImage(My.Resources.verticalscrollbar_bottom, 0, height - 6)

        g.Dispose()

        image_normal = bmp

        bmp = New Bitmap(12, Math.Max(12, height), Imaging.PixelFormat.Format32bppArgb)

        g = Graphics.FromImage(bmp)

        g.DrawImage(My.Resources.verticalscrollbar_top_hover, 0, 0)

        For i As Integer = 0 To (height - 13)
            g.DrawImage(My.Resources.verticalscrollbar_middle_hover, 0, i + 6)
        Next

        g.DrawImage(My.Resources.verticalscrollbar_bottom_hover, 0, height - 6)

        g.Dispose()

        image_hover = bmp

        bmp = New Bitmap(12, Math.Max(12, height), Imaging.PixelFormat.Format32bppArgb)

        g = Graphics.FromImage(bmp)

        g.DrawImage(My.Resources.verticalscrollbar_top_click, 0, 0)

        For i As Integer = 0 To (height - 13)
            g.DrawImage(My.Resources.verticalscrollbar_middle_click, 0, i + 6)
        Next

        g.DrawImage(My.Resources.verticalscrollbar_bottom_click, 0, height - 6)

        g.Dispose()

        image_click = bmp

    End Sub

    Public Sub InitScrollBar()
        Background.Height = Me.Height
        Background.BackgroundImage = CreateBackground(Me.Height)
        CreateScrollBar(Me.Height)
        CalculateHeight(1)
    End Sub

    Public Sub CalculateHeight(ByVal items As Integer)
        CreateScrollBar(Math.Max(12, Me.Height - Math.Max(0, (15 * (items - (CType(Me.Parent, MyListBox).Radio_External_Container.Height / 15)) / items * Math.Sqrt(CType(Me.Parent, MyListBox).Items)))))
        ScrollButton.Height = Math.Max(12, Me.Height - Math.Max(0, (15 * (items - (CType(Me.Parent, MyListBox).Radio_External_Container.Height / 15)) / items * Math.Sqrt(CType(Me.Parent, MyListBox).Items))))
        ScrollButton.BackgroundImage = image_normal
    End Sub



    Private Sub MyVerticalScrollBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScrollButton.Parent = Background

    End Sub

    Dim MouseYLocation As Integer
    Dim IsMouseDown As Boolean = False
    Dim ScrollButtonPos As Integer


    Private Sub ScrollButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ScrollButton.MouseDown
        ScrollButton.BackgroundImage = image_click
        MouseYLocation = Me.PointToClient(Me.MousePosition).Y
        ScrollButtonPos = ScrollButton.Top
        IsMouseDown = True
    End Sub

    Private Sub ScrollButton_MouseMove(sender As Object, e As MouseEventArgs) Handles ScrollButton.MouseMove
        If IsMouseDown Then

            Dim test As Double = (Me.Height - ScrollButton.Height) / ((CType(Me.Parent, MyListBox).Items - (CType(Me.Parent, MyListBox).Radio_External_Container.Height / 15)))

            ScrollButton.Top = CInt(Math.Max(Math.Min(ScrollButtonPos + Me.PointToClient(Me.MousePosition).Y - MouseYLocation, Me.Height - ScrollButton.Height), 0) / test) * test

            CType(Me.Parent, MyListBox).Radio_Internal_Container.Top = Math.Max(Math.Round((-ScrollButton.Top * Math.Sqrt(CType(Me.Parent, MyListBox).Items)) / 15) * 15, -CType(Me.Parent, MyListBox).Radio_Internal_Container.Height + CType(Me.Parent, MyListBox).Radio_External_Container.Height)

        End If
    End Sub

    Private Sub ScrollButton_MouseUp(sender As Object, e As MouseEventArgs) Handles ScrollButton.MouseUp
        ScrollButton.BackgroundImage = image_hover
        IsMouseDown = False
    End Sub

    Private Sub ScrollButton_MouseEnter(sender As Object, e As EventArgs) Handles ScrollButton.MouseEnter
        ScrollButton.BackgroundImage = image_hover
    End Sub

    Private Sub ScrollButton_MouseLeave(sender As Object, e As EventArgs) Handles ScrollButton.MouseLeave
        ScrollButton.BackgroundImage = image_normal
    End Sub

End Class
