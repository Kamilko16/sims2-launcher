Imports System.IO
Imports System.Threading
Imports System.Globalization
Imports System.Reflection

Module Functions
    Public Sub DoubleBufferedPanel(ByVal myPanel As Control, ByVal setting As Boolean)
        Dim panType As Type = myPanel.[GetType]()
        Dim pi As PropertyInfo = panType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(myPanel, setting, Nothing)
    End Sub
    Public Function CreateDialogBackground(ByVal width As Integer, ByVal height As Integer) As Image

        Dim bmp As Bitmap = New Bitmap(width + 46, 179, Imaging.PixelFormat.Format32bppArgb)

        Dim g As Graphics = Graphics.FromImage(bmp)

        g.DrawImage(My.Resources.dialog_luc, 0, 0)

        g.DrawImage(My.Resources.dialog_lbc, 0, height + 23)

        g.DrawImage(My.Resources.dialog_ruc, width + 23, 0)

        g.DrawImage(My.Resources.dialog_rbc, width + 23, height + 23)

        For x As Integer = 0 To (width - 1)

            g.DrawImage(My.Resources.dialog_up, x + 23, 0)

            g.DrawImage(My.Resources.dialog_down, x + 23, height + 23)

        Next

        For y As Integer = 0 To (height - 1)

            g.DrawImage(My.Resources.dialog_left, 0, y + 23)

            g.DrawImage(My.Resources.dialog_right, width + 23, y + 23)

        Next

        g.FillRectangle(New SolidBrush(Color.FromArgb(255, 156, 173, 227)), 23, 23, width, height)

        g.Dispose()

        Return bmp
    End Function

    Public Sub SetStringsLauncher()
        LauncherForm.Text = LauncherForm.RM.GetString("Title")
        LauncherForm.App_Title.Text = LauncherForm.RM.GetString("Title")
        LauncherForm.Play_Button.Text = " " & LauncherForm.RM.GetString("Play")
        LauncherForm.Expansions_Label.Text = LauncherForm.RM.GetString("Expansions")
        LauncherForm.Accessories_Label.Text = LauncherForm.RM.GetString("Accessories")
    End Sub

    Public Sub SetStringsSettings()
        SettingsForm.Text = LauncherForm.RM.GetString("Settings")
        SettingsForm.Settings_Label.Text = LauncherForm.RM.GetString("Settings")
        SettingsForm.Resolution_Label.Text = LauncherForm.RM.GetString("Resolution")
        SettingsForm.Save_Button.Text = LauncherForm.RM.GetString("Save")
        SettingsForm.Cancel_Button.Text = LauncherForm.RM.GetString("Cancel")
        SettingsForm.FullScreen_Label.Text = LauncherForm.RM.GetString("FullScreen")
        SettingsForm.Language_Label.Text = LauncherForm.RM.GetString("Language")
        SettingsForm.Splash_Label.Text = LauncherForm.RM.GetString("Splash")
    End Sub

    Public Sub SetStringsCC()
        CustomContentForm.Save_Button.Text = LauncherForm.RM.GetString("Save")
        CustomContentForm.Cancel_Button.Text = LauncherForm.RM.GetString("Cancel")
        CustomContentForm.Search_Box.Text = LauncherForm.RM.GetString("Search")
        CustomContentForm.CC_Label.Text = LauncherForm.RM.GetString("CC")
    End Sub

    Public Function CreateDialog(ByVal width As Integer, ByVal text As String, ByVal type As Integer) As Form
        Dim font As Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Dim f As New Form
        Dim TextBox As New System.Windows.Forms.Label With {
            .Text = text,
            .Location = New Point(23, 23),
            .BackColor = Color.Transparent,
            .Font = font
        }

        Dim g As Graphics = Graphics.FromHwnd(TextBox.Handle)
        TextBox.Size = New Size(width, g.MeasureString(text, font, width).Height + 4)

        Dim hoverstart = Sub(ss As Object, es As EventArgs)
                             ss.BackgroundImage = My.Resources.button_hover
                         End Sub

        Dim hoverend = Sub(ss As Object, es As EventArgs)
                           ss.BackgroundImage = My.Resources.button
                       End Sub

        Dim hoverdown = Sub(ss As Object, es As EventArgs)
                            ss.BackgroundImage = My.Resources.button_click
                        End Sub

        Dim hoverup = Sub(ss As Object, es As EventArgs)
                          ss.BackgroundImage = My.Resources.button_hover
                      End Sub

        If type = 1 Then
            Dim btn As New System.Windows.Forms.Button With {
            .Size = New Size(66, 36),
            .Text = LauncherForm.RM.GetString("Ok"),
            .Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte)),
            .ForeColor = System.Drawing.Color.FromArgb(0, 48, 98),
            .BackgroundImage = My.Resources.button,
            .Location = New Point((width + 46) / 2 - 33, TextBox.Height + 23 + 17),
            .Cursor = Cursors.Hand,
            .FlatStyle = FlatStyle.Flat,
            .BackColor = Color.Transparent
        }
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0)
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent

            AddHandler CType(btn, Control).MouseEnter, hoverstart
            AddHandler CType(btn, Control).MouseLeave, hoverend
            AddHandler CType(btn, Control).MouseDown, hoverdown
            AddHandler CType(btn, Control).MouseUp, hoverup

            f.Controls.Add(btn)

        Else
            Dim btn As New System.Windows.Forms.Button With {
            .Size = New Size(66, 36),
            .Text = LauncherForm.RM.GetString("Yes"),
            .Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte)),
            .ForeColor = System.Drawing.Color.FromArgb(0, 48, 98),
            .BackgroundImage = My.Resources.button,
            .Location = New Point((width + 46) / 2 - 66 - 5, 138),
            .Cursor = Cursors.Hand,
            .FlatStyle = FlatStyle.Flat,
            .BackColor = Color.Transparent
        }
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0)
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent



            Dim btn2 As New System.Windows.Forms.Button With {
                .Size = New Size(66, 36),
                .Text = LauncherForm.RM.GetString("No"),
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte)),
                .ForeColor = System.Drawing.Color.FromArgb(0, 48, 98),
                .BackgroundImage = My.Resources.button,
                .Location = New Point((width + 46) / 2 + 5, 138),
                .Cursor = Cursors.Hand,
                .FlatStyle = FlatStyle.Flat,
                .BackColor = Color.Transparent
            }
            btn2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0)
            btn2.FlatAppearance.BorderSize = 0
            btn2.FlatAppearance.MouseOverBackColor = Color.Transparent
            btn2.FlatAppearance.MouseDownBackColor = Color.Transparent

            AddHandler CType(btn, Control).MouseEnter, hoverstart
            AddHandler CType(btn2, Control).MouseEnter, hoverstart
            AddHandler CType(btn, Control).MouseLeave, hoverend
            AddHandler CType(btn2, Control).MouseLeave, hoverend
            AddHandler CType(btn, Control).MouseDown, hoverdown
            AddHandler CType(btn2, Control).MouseDown, hoverdown
            AddHandler CType(btn, Control).MouseUp, hoverup
            AddHandler CType(btn2, Control).MouseUp, hoverup

            f.Controls.Add(btn)
            f.Controls.Add(btn2)
        End If


        f.Controls.Add(TextBox)

        f.FormBorderStyle = FormBorderStyle.None
        f.BackColor = Color.Magenta
        f.TransparencyKey = Color.Magenta
        f.BackgroundImage = CreateDialogBackground(width, TextBox.Height)
        f.ShowIcon = False
        f.ShowInTaskbar = False
        f.StartPosition = FormStartPosition.CenterScreen
        'f.SetBitmap(255)
        f.Size = New Size(width + 46, TextBox.Height + 23 + 58)
        f.Show()
        Return f
    End Function

    Public Function ImageParser(ByRef data() As Byte, ByVal w As Integer, ByVal h As Integer) As Image
        Dim index As Integer = 14
        Dim bmp As Bitmap = New Bitmap(w, h, Imaging.PixelFormat.Format32bppArgb)

        For y As Integer = (bmp.Height - 1) To 0 Step -1

            For x As Integer = 0 To (bmp.Width - 1)

                Dim b As Byte
                Dim g As Byte
                Dim r As Byte
                Dim a As Byte

                b = data(index)
                index += 1
                g = data(index)
                index += 1
                r = data(index)
                index += 1
                a = data(index)
                index += 1

                bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b))

            Next
        Next

        Return bmp
    End Function

    Public Function LoadSplash(ByVal path As String, ByVal instance As Integer) As Image

        If My.Computer.FileSystem.FileExists(path) Then

            Dim file As New FileStream(path, FileMode.Open)
            Dim br As New BinaryReader(file)

            file.Position = 36
            Dim elements = br.ReadUInt32
            file.Position = 40
            Dim firstel = br.ReadUInt32
            file.Position = 44
            Dim entrysize = br.ReadUInt32
            file.Position = firstel

            Dim dirlocation As Integer
            Dim dirsize As Integer
            Dim splashcompressed As Boolean = False
            Dim splashlocation As Integer

            For i As Integer = 1 To elements
                file.Position += 8
                Dim id As Integer = br.ReadInt32

                If id = 678108931 Then
                    dirlocation = br.ReadInt32
                    dirsize = br.ReadInt32
                End If

                If id = instance Then
                    splashlocation = file.Position
                End If

                If splashlocation <> Nothing And dirlocation <> Nothing Then
                    Exit For
                End If
                file.Position = firstel + (i * 20)
            Next
            file.Position = dirlocation
            For i As Integer = 0 To (dirsize / 16)
                file.Position += 8
                If br.ReadInt32 = instance Then
                    splashcompressed = True
                End If
                file.Position = dirlocation + (i * 16)
            Next

            file.Position = splashlocation

            If splashcompressed Then
                Dim loc As Integer = br.ReadInt32
                Dim size As Integer = br.ReadInt32

                file.Position = loc + 6

                Dim fullsize() As Byte = br.ReadBytes(3)
                Dim result As Integer = (CType(fullsize(0), Integer) << 16) + (CType(fullsize(1), Integer) << 8) + CType(fullsize(2), Integer)
                Dim index As Integer = 0
                Dim data() As Byte = br.ReadBytes(size)

                file.Dispose()

                Dim uncdata(result) As Byte

                Dim uncindex As Integer = 0
                Dim plaincount As Integer
                Dim copycount As Integer
                Dim copyoffset As Integer
                Dim cc As Integer
                Dim cc1 As Integer
                Dim cc2 As Integer
                Dim cc3 As Integer
                Dim source As Integer

                While (index < data.Length And data(index) < &HFC)
                    cc = data(index)
                    index += 1

                    If ((cc And &H80) = 0) Then

                        cc1 = data(index)
                        index += 1
                        plaincount = (cc And &H3)
                        copycount = ((cc And &H1C) >> 2) + 3
                        copyoffset = ((cc And &H60) << 3) + cc1 + 1

                    ElseIf ((cc And &H40) = 0) Then

                        cc1 = data(index)
                        index += 1
                        cc2 = data(index)
                        index += 1
                        plaincount = (cc1 And &HC0) >> 6
                        copycount = (cc And &H3F) + 4
                        copyoffset = ((cc1 And &H3F) << 8) + cc2 + 1

                    ElseIf ((cc And &H20) = 0) Then

                        cc1 = data(index)
                        index += 1
                        cc2 = data(index)
                        index += 1
                        cc3 = data(index)
                        index += 1
                        plaincount = (cc And &H3)
                        copycount = ((cc And &HC) << 6) + cc3 + 5
                        copyoffset = ((cc And &H10) << 12) + (cc1 << 8) + cc2 + 1

                    Else

                        plaincount = (cc - &HDF) << 2
                        copycount = 0
                        copyoffset = 0

                    End If

                    For j As Integer = 0 To (plaincount - 1)
                        uncdata(uncindex) = data(index)
                        uncindex += 1
                        index += 1
                    Next

                    source = uncindex - copyoffset

                    For j As Integer = 0 To (copycount - 1)

                        uncdata(uncindex) = uncdata(source)
                        uncindex += 1
                        source += 1
                    Next


                End While

                If index < data.Length Then

                    plaincount = (data(index) And &H3)
                    index += 1
                    For j As Integer = 0 To (plaincount - 1)

                        If uncindex >= uncdata.Length Then
                            Exit For
                        End If
                        uncdata(uncindex) = data(index)
                        uncindex += 1
                        index += 1
                    Next
                End If

                Return ImageParser(uncdata, 500, 500)

            Else
                Dim loc As Integer = br.ReadInt32
                Dim size As Integer = br.ReadInt32
                file.Position = loc
                Dim data() As Byte = br.ReadBytes(size)

                file.Dispose()

                Dim mStream As New MemoryStream(data)

                Return Image.FromStream(mStream)

            End If

            file.Dispose()

        End If

        Return Nothing

    End Function

    Public Function GetRegistry(Optional ByVal ea As Boolean = True) As String
        Dim registry As String = "HKEY_LOCAL_MACHINE\SOFTWARE\"

        If Environment.Is64BitOperatingSystem Then
            registry &= "WOW6432Node\"
        End If

        If ea = True Then
            registry &= "EA GAMES\"
        End If

        Return registry
    End Function

    Public Function GetLanguage() As String
        Dim lang As String = My.Computer.Registry.GetValue(GetRegistry() & "The Sims 2", "Language", Nothing)
        If IsNothing(lang) Then
            Dim index As Integer = Array.IndexOf(LauncherForm.languages, System.Threading.Thread.CurrentThread.CurrentUICulture.Name)
            If index = -1 Then
                Return "English"
            Else
                Return LauncherForm.languages(index - 1)
            End If
        Else
            Dim index As Integer = Array.IndexOf(LauncherForm.languages, lang)
            If index = -1 Then
                Return "English"
            Else
                Return lang
            End If
        End If
    End Function

    Public Function GetExpansions() As String()
        Dim epsreg = My.Computer.Registry.GetValue(GetRegistry() & "The Sims 2", "EPsInstalled", Nothing)
        Dim eps() As String = Split(epsreg, ",")
        Return eps
    End Function

    Public Function GetLatestExpansion(ByRef eps() As String) As String
        Dim latest As String = ""
        For Each el In eps
            If el <> "" Then
                latest = el
            End If
        Next
        If latest = "" Then
            Return latest
        Else
            Return latest.Substring(5, 3)
        End If
    End Function

    Public Function GetPath(ByVal ep As String) As String
        Return My.Computer.Registry.GetValue(GetRegistry(False) & "Microsoft\Windows\CurrentVersion\App Paths\Sims2" & ep & ".exe", "Path", Nothing)
    End Function
    Public Function GetExePath(ByVal ep As String) As String
        Return My.Computer.Registry.GetValue(GetRegistry(False) & "Microsoft\Windows\CurrentVersion\App Paths\Sims2" & ep & ".exe", "", Nothing)
    End Function

    Public Sub LoadSettings(ByRef settings As Dictionary(Of String, String))
        If Not My.Computer.FileSystem.FileExists("settings.ini") Then
            Dim file As StreamWriter = New StreamWriter("settings.ini")
            file.WriteLine("splash=True")
            settings.Add("splash", "True")
            file.WriteLine("fullscreen=True")
            settings.Add("fullscreen", "True")
            file.WriteLine("resolution=" & LauncherForm.resolutions(LauncherForm.resolutions.Count - 1))
            settings.Add("resolution", LauncherForm.resolutions(LauncherForm.resolutions.Count - 1))
            file.WriteLine("language=" & GetLanguage())
            settings.Add("language", GetLanguage)
            file.WriteLine("rpc=False")
            settings.Add("rpc", "False")
            file.WriteLine("rpcargs=-hide")
            settings.Add("rpcargs", "")
            file.Close()
        Else
            Dim file As StreamReader = New StreamReader("settings.ini")
            Dim line = file.ReadLine()
            While (line <> Nothing)
                Dim setting() As String = Split(line, "=")
                If Not setting.Length <> 2 Then
                    settings.Add(setting(0), setting(1))
                End If
                line = file.ReadLine()
            End While
            file.Close()
        End If
    End Sub

    Public Sub SetIcons(ByRef form As Form, ByRef eps() As String)
        For Each picbox In form.Controls
            If picbox.Tag = "Icon" Then
                Dim epname As String = picbox.Name.Substring(0, 3)

                If Not eps.Contains("Sims2" & epname & ".exe", StringComparer.OrdinalIgnoreCase) Then

                    Dim pic As Bitmap = picbox.Image
                    Dim gray = New Bitmap(pic.Width, pic.Height)

                    For x As Integer = 0 To (pic.Width) - 1
                        For y As Integer = 0 To (pic.Height) - 1
                            Dim c As Color = pic.GetPixel(x, y)
                            If c.A = 255 Then
                                Dim r As Single = c.R
                                Dim g As Single = c.G
                                Dim b As Single = c.B
                                Dim d As Integer = CInt(r * 0.3 + g * 0.59 + b * 0.11)
                                gray.SetPixel(x, y, Color.FromArgb(d, d, d))
                            End If
                        Next
                    Next
                    picbox.Image = gray

                End If
            End If

        Next
    End Sub

End Module
