Public Class MyPanel
    Private Sub GenerateBackground()

        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height, Imaging.PixelFormat.Format32bppArgb)

        Dim g As Graphics = Graphics.FromImage(bmp)

        g.DrawImage(My.Resources.listbox_background_luc, 0, 0)
        g.DrawImage(My.Resources.listbox_background_lbc, 0, Me.Height - 6)
        g.DrawImage(My.Resources.listbox_background_ruc, Me.Width - 6, 0)
        g.DrawImage(My.Resources.listbox_background_rbc, Me.Width - 6, Me.Height - 6)

        For i As Integer = 0 To (Me.Width - 13)
            g.DrawImage(My.Resources.listbox_background_up, i + 6, 0)
            g.DrawImage(My.Resources.listbox_background_bottom, i + 6, Me.Height - 6)
        Next

        For i As Integer = 0 To (Me.Height - 13)
            g.DrawImage(My.Resources.listbox_background_left, 0, i + 6)
            g.DrawImage(My.Resources.listbox_background_right, Me.Width - 6, i + 6)
        Next

        g.FillRectangle(New SolidBrush(Color.FromArgb(179, 148, 172, 221)), 6, 6, Me.Width - 12, Me.Height - 12)

        g.Dispose()

        Me.BackgroundImage = bmp

    End Sub

    Private Sub MyPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateBackground()
    End Sub
End Class
