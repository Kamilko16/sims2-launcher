Imports System.Net
Imports System.IO
Imports System.Text.Json
Public Class MTS

    ReadOnly mtsstring = "Mod The Sims"
    ReadOnly mtsrecent = "Recent Uploads"
    Public Class MTSDATA_File
        Public Property filename As String
        Public Property size As String
        Public Property url As String
        Public Property uploaddate As String
        Public Property downloads As Integer
        Public Property description As String
    End Class

    Public Class MTSDATA_Counters
        Public Property Thanks As Integer
        Public Property Favorited As Integer
        Public Property Downloads As Integer
        Public Property Views As Integer
    End Class

    Public Class MTSDATA_Icon
        Public Property name As String
        Public Property icon As String
    End Class

    Public Class MTSDATA_Upload
        Public Property Title As String
        Public Property Game As Integer
        Public Property Author As String
        Public Property AuthorId As Integer
        Public Property Thumbnail As String
        Public Property LargeThumbnail As String
        Public Property Id As Integer
        Public Property Files As MTSDATA_File()
        Public Property Uploaded As String
        Public Property UploadedDateTime As String
        Public Property Upuploaddated As String
        Public Property ShortDesc As String
        Public Property Counters As MTSDATA_Counters
        Public Property Keywords As String
        Public Property Icons As MTSDATA_Icon()
    End Class

    Public Class MTSDATA
        Public Property Uploads As MTSDATA_Upload()
        Public Property ThumbsBase As String
        Public Property IconBase As String
        Public Property TotalUploads As String
        Public Property PageNumber As String
        Public Property TotalPages As Integer
    End Class

    Private selected As MTSDATA_Upload

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub MTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create new Task.
        ' ... Use AddressOf to reference a method.
        'Dim t As Task = New Task(AddressOf DownloadPageAsync)
        ' Start the task.
        't.Start()
        ' Print a message as the page downloads.

        'DownloadPageAsync()
        MainBW.RunWorkerAsync()
    End Sub

    Dim currpage As Integer = 1

    Function RecentUploads()
        Dim page As String = "https://modthesims.info/api/browse.php?v=2&g=1&page=" + currpage.ToString
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Using wc = New WebClient()

            wc.Headers.Add("user-agent", "Other")

            Dim data = wc.DownloadString(page)

            data = data.Replace("date", "uploaddate")

            Dim output = JsonSerializer.Deserialize(Of MTSDATA)(data)

            Dim left = 0
            Dim top = 0

            Dim panel As New Panel
            Functions.DoubleBufferedPanel(panel, True)
            Dim backbtn As New Button
            Dim nextbtn As New Button
            backbtn.Text = "Previous"
            backbtn.Left = 500
            backbtn.Top = 300
            nextbtn.Text = "Next"
            nextbtn.Left = 600
            nextbtn.Top = 300
            If output.PageNumber = 1 Then
                backbtn.Enabled = False
            End If

            Dim f1 = Sub()
                         currpage -= 1
                         Me.Controls.Remove(Me.Controls.Find("MainPanel", False)(0))
                         MainBW.RunWorkerAsync()
                     End Sub

            Dim f2 = Sub()
                         currpage += 1
                         Me.Controls.Remove(Me.Controls.Find("MainPanel", False)(0))
                         MainBW.RunWorkerAsync()
                     End Sub

            AddHandler backbtn.Click, f1
            AddHandler nextbtn.Click, f2

            panel.Controls.Add(nextbtn)
            panel.Controls.Add(backbtn)

            For Each el In output.Uploads

                Dim pan As New Panel
                Functions.DoubleBufferedPanel(pan, True)
                pan.Width = 175
                pan.Height = 120

                Dim tImage As Bitmap = My.Resources.close

                Try
                    tImage = Bitmap.FromStream(New MemoryStream(wc.DownloadData(output.ThumbsBase + "/" + el.Thumbnail)))
                Catch ex As NullReferenceException
                End Try
                Dim lab As New Label
                lab.Text = el.Title
                lab.Name = "SingleName"
                lab.Width = 175
                lab.Top = 100
                Dim pic As New PictureBox
                pic.Image = tImage
                pic.BackColor = Color.Transparent
                pic.BackgroundImage = My.Resources.mts_item_background
                pic.SizeMode = PictureBoxSizeMode.Zoom
                pic.Width = 175
                pic.Height = 100
                pan.Left = left
                pan.Top = top
                pan.Tag = el
                AddHandler pic.Click, AddressOf ImageClick
                AddHandler lab.Click, AddressOf ImageClick
                pan.Cursor = Cursors.Hand
                pan.Controls.Add(pic)
                pan.Controls.Add(lab)
                panel.Controls.Add(pan)
                left += 195
                If left = 780 Then
                    left = 0
                    top += 140
                End If
            Next

            Return panel


        End Using

    End Function

    Function SingleItem(ByVal item As Object)

        Dim el As MTSDATA_Upload = CType(CType(item, Control).Parent.Tag, MTSDATA_Upload)

        Dim panel As New Panel

        Dim progrr As New ProgressBar

        progrr.Left = 600

        progrr.Style = ProgressBarStyle.Continuous

        progrr.ForeColor = Color.ForestGreen

        progrr.Step = 1

        Functions.DoubleBufferedPanel(progrr, True)

        progrr.Name = "ProgBar"

        Dim lab As New Label

        Dim back As New Button

        back.Text = "Back"

        back.Left = 500

        Dim top = 0

        For Each it As MTSDATA_File In el.Files
            Dim down As New Button
            down.AutoSize = True
            down.Tag = it.url + "|" + it.filename
            down.Left = 100
            down.Top = top
            top += 50
            down.Text = it.filename
            AddHandler down.Click, AddressOf DownloadFile
            AddHandler back.Click, AddressOf GoBack
            panel.Controls.Add(down)
        Next

        lab.Text = CType(CType(item, Control).Parent.Tag, MTSDATA_Upload).Author

        panel.Controls.Add(lab)

        panel.Controls.Add(back)
        panel.Controls.Add(progrr)

        panel.Name = "SinglePagePanel"

        Functions.DoubleBufferedPanel(panel, True)
        panel.BackColor = Color.Transparent
        panel.Width = 760
        panel.Left = 20
        panel.Height = 410
        panel.Top = 70

        Return panel
    End Function

    Private Sub MainBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles MainBW.DoWork
        e.Result = RecentUploads()
    End Sub

    Private Sub MainBW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles MainBW.RunWorkerCompleted
        Dim panel As Panel = e.Result
        Functions.DoubleBufferedPanel(panel, True)
        App_Title.Text = mtsstring & " > " & mtsrecent & " > " & currpage.ToString
        panel.BackColor = Color.Transparent
        panel.Width = 760
        panel.Left = 20
        panel.Height = 410
        panel.Top = 70
        panel.Name = "MainPanel"
        Me.Controls.Add(panel)
    End Sub

    Private Sub ImageClick(sender As Object, e As EventArgs)
        Me.Controls.Find("MainPanel", False)(0).Hide()
        Me.Controls.Add(SingleItem(sender))
        Dim el = CType(CType(sender, Control).Parent.Tag, MTSDATA_Upload)
        App_Title.Text = mtsstring & " > " & el.Author & " > " & el.Title
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GoBack(sender As Object, e As EventArgs)
        Me.Controls.Remove(CType(sender, Control).Parent)
        Me.Controls.Find("MainPanel", False)(0).Show()
        App_Title.Text = mtsstring & " > " & mtsrecent & " > " & currpage.ToString
    End Sub

    Private Sub DownloadFile(sender As Object, e As EventArgs)
        Dim link = CType(CType(sender, Button).Tag, String).Split("|")

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Dim wc As New WebClient()

        AddHandler wc.DownloadProgressChanged, AddressOf DownloadProgress

        wc.Headers.Add("user-agent", "Other")

        wc.DownloadFileAsync(New Uri(link(0)), link(1))


    End Sub

    Private Sub DownloadProgress(sender As Object, e As DownloadProgressChangedEventArgs)
        CType(Me.Controls.Find("SinglePagePanel", False)(0).Controls.Find("ProgBar", False)(0), ProgressBar).Value = e.ProgressPercentage
    End Sub

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Close_Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Close_Button.MouseDown
        Close_Button.BackgroundImage = My.Resources.close_click
    End Sub

    Private Sub Close_Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Close_Button.MouseUp
        Close_Button.BackgroundImage = My.Resources.close_hover
    End Sub

    Private Sub Close_Button_MouseLeave(sender As Object, e As EventArgs) Handles Close_Button.MouseLeave
        Close_Button.BackgroundImage = My.Resources.close
    End Sub

    Private Sub Close_Button_MouseEnter(sender As Object, e As EventArgs) Handles Close_Button.MouseEnter
        Close_Button.BackgroundImage = My.Resources.close_hover
    End Sub

End Class