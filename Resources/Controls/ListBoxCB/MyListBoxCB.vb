Public Class MyListBoxCB
    Private allitems As Integer = 0
    Private selected As Object
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Public Sub SelectItem(ByRef sender As Object)
        If Not IsNothing(selected) Then
            CType(selected, MyRadioButton).DeselectMe()
        End If

        selected = sender
        CType(selected, MyRadioButton).SelectMe()
    End Sub

    Public Sub Clear()
        allitems = 0
        Radio_Internal_Container.Controls.Clear()
        ScrollBar.CalculateHeight(1)
    End Sub

    Public Property SelectedItem() As String
        Get
            If IsNothing(selected) Then
                SelectedItem = ""
            Else
                SelectedItem = CType(selected, MyRadioButton).Radio_Value.Text
            End If

        End Get
        Set(ByVal value As String)
            For Each el In Radio_Internal_Container.Controls
                If CType(el, MyRadioButton).Radio_Value.Text = value Then
                    SelectItem(el)
                    Radio_Internal_Container.Top = Math.Max(-Radio_Internal_Container.Height + Radio_External_Container.Height, Math.Min(0, -CType(el, MyRadioButton).Location.Y))
                    RefreshScrollBar()
                End If
            Next
        End Set
    End Property


    Public ReadOnly Property Items() As Integer
        Get
            Items = allitems
        End Get
    End Property

    Private Sub GenerateBackground()

        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height, Imaging.PixelFormat.Format32bppArgb)

        Dim g As Graphics = Graphics.FromImage(bmp)

        g.DrawImage(My.Resources.listbox_background_luc, 0, 0)
        g.DrawImage(My.Resources.listbox_background_lbc, 0, Me.Height - 6)
        g.DrawImage(My.Resources.listbox_background_ruc, Me.Width - 20, 0)
        g.DrawImage(My.Resources.listbox_background_rbc, Me.Width - 20, Me.Height - 6)

        For i As Integer = 0 To (Me.Width - 27)
            g.DrawImage(My.Resources.listbox_background_up, i + 6, 0)
            g.DrawImage(My.Resources.listbox_background_bottom, i + 6, Me.Height - 6)
        Next

        For i As Integer = 0 To (Me.Height - 13)
            g.DrawImage(My.Resources.listbox_background_left, 0, i + 6)
            g.DrawImage(My.Resources.listbox_background_right, Me.Width - 20, i + 6)
        Next

        g.FillRectangle(New SolidBrush(Color.FromArgb(179, 148, 172, 221)), 6, 6, Me.Width - 26, Me.Height - 12)

        g.Dispose()

        Me.BackgroundImage = bmp

    End Sub

    Public Sub AddItem(ByVal name As String, ByVal checked As Boolean)
        Dim cb As New MyCBButton
        cb.CB_Value.Text = name
        cb.Checked = checked
        cb.Location = New Point(0, allitems * 15)
        Radio_Internal_Container.Controls.Add(cb)
        allitems += 1
    End Sub

    Private Sub MyListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateBackground()
        'Background.Height = Me.Height
        Radio_External_Container.Size = New Size(Me.Width - 25, Me.Height - 10)
        Radio_Internal_Container.Size = New Size(Me.Width - 25, Me.Height - 10)
        ScrollBar.Location = New Point(Me.Width - 12, 0)
        ScrollBar.Height = Me.Height
        ScrollBar.InitScrollBar()
        'ScrollBar.ScrollButton.Height = 0
    End Sub

    Public Sub RefreshScrollBar()
        ScrollBar.ScrollButton.Top = (ScrollBar.Height - ScrollBar.ScrollButton.Height) / (Items - (Radio_External_Container.Height / 15)) * -(Radio_Internal_Container.Top / 15)
    End Sub

    Public Sub ScrollUp()
        Radio_Internal_Container.Top = Math.Max(-Radio_Internal_Container.Height + Radio_External_Container.Height, Math.Min(0, Radio_Internal_Container.Top + 15))
    End Sub

    Public Sub ScrollDown()
        Radio_Internal_Container.Top = Math.Max(-Radio_Internal_Container.Height + Radio_External_Container.Height, Math.Min(0, Radio_Internal_Container.Top - 15))

    End Sub

    Private Sub MyListBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles MyBase.MouseWheel
        If e.Delta > 0 Then
            Me.ScrollUp()
        Else
            Me.ScrollDown()
        End If
        RefreshScrollBar()
    End Sub

End Class
