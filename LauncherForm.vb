Imports System.Resources
Imports Sims2Launcher.ListResolutions
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.InteropServices

Public Class LauncherForm
    Dim eps() As String
    Dim sims2installed As Boolean = True
    Public ReadOnly languages() As String = {"Brazilian Portuguese", "pt-BR", "Czech", "cs-CZ", "Danish", "da-DK", "Dutch", "nl-NL", "English", "en-US", "Finnish", "fi-FI", "French", "fr-FR", "German", "de-DE", "Hungarian", "hu-HU", "Italian", "it-IT", "Japanese", "ja-JP", "Korean", "ko-KR", "Norwegian", "nb-NO", "Polish", "pl-PL", "Portuguese", "pt-PT", "Russian", "ru-RU", "Simplified Chinese", "zh-CN", "Spanish", "es-ES", "Swedish", "sv-SE", "Thai", "th-TH", "Traditional Chinese", "zh-TW", "UK English", "en-GB"}
    Dim basename As String = ""
    Dim latestep As String
    Dim base As String = ""
    Dim splash As Image
    Public resolutions As New ArrayList
    Public settings As New Dictionary(Of String, String)
    Public RM As ResourceManager
    Public rpc As Boolean = False

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer2.Start()

        Dim test As New Program
        resolutions = test.Main()

        eps = Functions.GetExpansions

        latestep = Functions.GetLatestExpansion(eps)

        Functions.LoadSettings(settings)

        RM = New ResourceManager("Sims2Launcher.LauncherStrings_" & languages(Array.IndexOf(languages, settings("language")) + 1), GetType(LauncherForm).Assembly)

        Functions.SetStringsLauncher()

        base = My.Computer.Registry.GetValue(Functions.GetRegistry() & "The Sims 2\1.0", "DisplayName", Nothing)

        If IsNothing(base) Then
            basename = RM.GetString("Base")
        ElseIf base.Contains("Double Deluxe") Then
            basename = RM.GetString("Base_DD")
        ElseIf base.Contains("Deluxe") Then
            basename = RM.GetString("Base_D")
        Else
            basename = RM.GetString("Base")
        End If

        If IsNothing(Functions.GetExePath("")) Then
            sims2installed = False
            Play_Button.Cursor = Cursors.Default
            Play_Button.BackgroundImage = My.Resources.play_disabled
            Play_Button.ForeColor = Color.Black
        End If

        If My.Computer.FileSystem.FileExists(Functions.GetPath(latestep) & "\TSBin\Sims2RPC.exe") Then
            rpc = True
        End If

        Functions.SetIcons(Me, eps)

    End Sub

    Private Sub Play_Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Play_Button.MouseDown
        If sims2installed Then
            Play_Button.BackgroundImage = My.Resources.play_click
        End If
    End Sub

    Private Sub Play_Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Play_Button.MouseUp
        If sims2installed Then
            Play_Button.BackgroundImage = My.Resources.play_hover
        End If
    End Sub

    Private Sub Play_Button_Click(sender As Object, e As EventArgs) Handles Play_Button.Click

        If sims2installed Then

            If Not My.Computer.FileSystem.FileExists(Functions.GetExePath(Functions.GetLatestExpansion(eps))) Then

                Dim name = RM.GetString(UCase(latestep))

                If name = "" Then
                    name = basename
                End If

                Dim text As String = RM.GetString("NotInstalled").Replace("%s", name)

                Dim dialog As Form = Functions.CreateDialog(500, text, 1)
                dialog.Icon = My.Resources.Icon
                dialog.ShowIcon = True
                dialog.Text = "Komunikat"

                Dim f1 = Sub()
                             dialog.Close()
                             Me.Close()
                         End Sub
                Dim btn = CType(dialog.Controls(0), Button)
                AddHandler CType(btn, Control).Click, f1
                Me.Hide()
            Else
                If settings("splash") = "True" Then
                    If settings("language") = "English" Or Functions.GetLatestExpansion(eps) = "" Then
                        splash = Functions.LoadSplash(Functions.GetPath(Functions.GetLatestExpansion(eps)) & "\TSData\Res\UI\ui.package", -1933864157)
                    Else
                        splash = Functions.LoadSplash(Functions.GetPath(Functions.GetLatestExpansion(eps)) & "\TSData\Res\Locale\" & settings("language") & "\UI\ui.package", -1933864157)
                    End If
                End If
                Dim args As String = ""
                If settings("fullscreen") = "False" Then
                    args &= "-w "
                End If

                args &= "-r" & settings("resolution") & " -l:" & settings("language")

                If Not IsNothing(splash) Then
                    Me.Hide()
                    Dim f As New AlphaForm With {
                    .BackgroundImage = splash,
                    .ShowIcon = False,
                    .ShowInTaskbar = False,
                    .StartPosition = FormStartPosition.CenterScreen
                    }
                    f.SetBitmap(255)
                    f.Size = New Size(splash.Width, splash.Height)
                    f.Show()
                    Timer1.Start()
                    If rpc = True And settings("rpc") = "True" Then
                        Process.Start(Functions.GetPath(latestep) & "\TSBin\Sims2RPC.exe", settings("rpcargs") & " -l:" & settings("language"))
                    Else
                        Process.Start(Functions.GetExePath(latestep), args)
                    End If

                Else
                    If rpc = True And settings("rpc") = "True" Then
                        Process.Start(Functions.GetPath(latestep) & "\TSBin\Sims2RPC.exe", settings("rpcargs") & " -l:" & settings("language"))
                    Else
                        Process.Start(Functions.GetExePath(latestep), args)
                    End If
                    Me.Close()
                End If

            End If

        End If

    End Sub

    Private Sub EP1_Image_MouseHover(sender As Object, e As EventArgs) Handles EP1_Image.MouseHover
        ToolTip.Show(RM.GetString("EP1"), EP1_Image)
    End Sub

    Private Sub EP2_Image_MouseHover(sender As Object, e As EventArgs) Handles EP2_Image.MouseHover
        ToolTip.Show(RM.GetString("EP2"), EP2_Image)
    End Sub

    Private Sub EP3_Image_MouseHover(sender As Object, e As EventArgs) Handles EP3_Image.MouseHover
        ToolTip.Show(RM.GetString("EP3"), EP3_Image)
    End Sub

    Private Sub EP4_Image_MouseHover(sender As Object, e As EventArgs) Handles EP4_Image.MouseHover
        ToolTip.Show(RM.GetString("EP4"), EP4_Image)
    End Sub

    Private Sub EP5_Image_MouseHover(sender As Object, e As EventArgs) Handles EP5_Image.MouseHover
        ToolTip.Show(RM.GetString("EP5"), EP5_Image)
    End Sub

    Private Sub EP6_Image_MouseHover(sender As Object, e As EventArgs) Handles EP6_Image.MouseHover
        ToolTip.Show(RM.GetString("EP6"), EP6_Image)
    End Sub

    Private Sub EP7_Image_MouseHover(sender As Object, e As EventArgs) Handles EP7_Image.MouseHover
        ToolTip.Show(RM.GetString("EP7"), EP7_Image)
    End Sub

    Private Sub EP8_Image_MouseHover(sender As Object, e As EventArgs) Handles EP8_Image.MouseHover
        ToolTip.Show(RM.GetString("EP8"), EP8_Image)
    End Sub

    Private Sub EP9_Image_MouseHover(sender As Object, e As EventArgs) Handles EP9_Image.MouseHover
        ToolTip.Show(RM.GetString("EP9"), EP9_Image)
    End Sub

    Private Sub SP1_Image_MouseHover(sender As Object, e As EventArgs) Handles SP1_Image.MouseHover
        ToolTip.Show(RM.GetString("SP1"), SP1_Image)
    End Sub

    Private Sub SP2_Image_MouseHover(sender As Object, e As EventArgs) Handles SP2_Image.MouseHover
        ToolTip.Show(RM.GetString("SP2"), SP2_Image)
    End Sub

    Private Sub SP4_Image_MouseHover(sender As Object, e As EventArgs) Handles SP4_Image.MouseHover
        ToolTip.Show(RM.GetString("SP4"), SP4_Image)
    End Sub

    Private Sub SP5_Image_MouseHover(sender As Object, e As EventArgs) Handles SP5_Image.MouseHover
        ToolTip.Show(RM.GetString("SP5"), SP5_Image)
    End Sub

    Private Sub SP6_Image_MouseHover(sender As Object, e As EventArgs) Handles SP6_Image.MouseHover
        ToolTip.Show(RM.GetString("SP6"), SP6_Image)
    End Sub

    Private Sub SP7_Image_MouseHover(sender As Object, e As EventArgs) Handles SP7_Image.MouseHover
        ToolTip.Show(RM.GetString("SP7"), SP7_Image)
    End Sub

    Private Sub SP8_Image_MouseHover(sender As Object, e As EventArgs) Handles SP8_Image.MouseHover
        ToolTip.Show(RM.GetString("SP8"), SP8_Image)
    End Sub

    Dim t = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If t = 5000 Then
            Me.Close()
        End If
        t += 100
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

    Dim loc As Point
    Dim down = False
    Private Sub App_Title_MouseDown(sender As Object, e As MouseEventArgs) Handles App_Title.MouseDown
        loc = e.Location
        down = True
    End Sub

    Private Sub App_Title_MouseUp(sender As Object, e As MouseEventArgs) Handles App_Title.MouseUp
        loc = MousePosition
        down = False
    End Sub

    Private Sub App_Title_MouseMove(sender As Object, e As MouseEventArgs) Handles App_Title.MouseMove
        If down = True Then
            Me.Location += (e.Location - loc)
        End If
    End Sub

    Private Sub Settings_Button_MouseEnter(sender As Object, e As EventArgs) Handles Settings_Button.MouseEnter
        Settings_Button.BackgroundImage = My.Resources.settings_hover
    End Sub

    Private Sub Settings_Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Settings_Button.MouseDown
        Settings_Button.BackgroundImage = My.Resources.settings_click
    End Sub

    Private Sub Settings_Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Settings_Button.MouseUp
        Settings_Button.BackgroundImage = My.Resources.settings_hover
    End Sub

    Private Sub Settings_Button_MouseLeave(sender As Object, e As EventArgs) Handles Settings_Button.MouseLeave
        Settings_Button.BackgroundImage = My.Resources.settings
    End Sub

    Private Sub Settings_Button_Click(sender As Object, e As EventArgs) Handles Settings_Button.Click
        Settings_Button.Cursor = Cursors.WaitCursor
        SettingsForm.Show()
        Settings_Button.Cursor = Cursors.Hand
    End Sub

    Private Sub CC_Button_MouseEnter(sender As Object, e As EventArgs) Handles CC_Button.MouseEnter
        CC_Button.BackgroundImage = My.Resources.cc_hover
    End Sub

    Private Sub CC_Button_Click(sender As Object, e As EventArgs) Handles CC_Button.Click
        CC_Button.Cursor = Cursors.WaitCursor
        CustomContentForm.Show()
        CC_Button.Cursor = Cursors.Hand
    End Sub

    Private Sub CC_Button_MouseDown(sender As Object, e As MouseEventArgs) Handles CC_Button.MouseDown
        CC_Button.BackgroundImage = My.Resources.cc_click
    End Sub

    Private Sub CC_Button_MouseLeave(sender As Object, e As EventArgs) Handles CC_Button.MouseLeave
        CC_Button.BackgroundImage = My.Resources.cc
    End Sub

    Private Sub CC_Button_MouseUp(sender As Object, e As MouseEventArgs) Handles CC_Button.MouseUp
        CC_Button.BackgroundImage = My.Resources.cc_hover
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start(Functions.GetPath(latestep) & "\CSBin\TS2BodyShop.exe", "-l:" & settings("language"))
        Me.Close()
    End Sub

    Private Sub Play_Button_MouseEnter(sender As Object, e As EventArgs) Handles Play_Button.MouseEnter
        If sims2installed Then
            Play_Button.BackgroundImage = My.Resources.play_hover
        End If
    End Sub

    Private Sub Play_Button_MouseLeave(sender As Object, e As EventArgs) Handles Play_Button.MouseLeave
        If sims2installed Then
            Play_Button.BackgroundImage = My.Resources.play
        End If
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackgroundImage = My.Resources.BodyShop_big_hover
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackgroundImage = My.Resources.BodyShop_big
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        PictureBox2.BackgroundImage = My.Resources.BodyShop_big_click
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        PictureBox2.BackgroundImage = My.Resources.BodyShop_big_hover
    End Sub

    Dim num = 1
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        PictureBox3.Image = My.Resources.ResourceManager.GetObject("anim" & num)

        num += 1

        If num = 7 Then
            num = 1
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MTS.Show()
    End Sub

    Private Sub CCWB_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
End Class
