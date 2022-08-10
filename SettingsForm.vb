Imports System.IO
Imports System.Resources
Public Class SettingsForm

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
        LauncherForm.BringToFront()
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        LauncherForm.settings("fullscreen") = FullScreen_CheckBox.Checked
        LauncherForm.settings("splash") = Splash_CheckBox.Checked
        LauncherForm.settings("language") = Language_ListBox.SelectedItem
        LauncherForm.settings("resolution") = Resolution_ListBox.SelectedItem
        LauncherForm.settings("rpc") = RPC_CheckBox.Checked
        LauncherForm.settings("rpcargs") = RPC_Args_Box.Text
        LauncherForm.RM = New ResourceManager("Sims2Launcher.LauncherStrings_" & LauncherForm.languages(Array.IndexOf(LauncherForm.languages, LauncherForm.settings("language")) + 1), GetType(LauncherForm).Assembly)
        Functions.SetStringsLauncher()
        Dim File As StreamWriter = New StreamWriter("settings.ini")
        For Each element In LauncherForm.settings
            File.WriteLine(element.Key + "=" + element.Value)
        Next
        File.Close()
        Me.Close()
        LauncherForm.BringToFront()
    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Functions.SetStringsSettings()

        FullScreen_CheckBox.Left = FullScreen_Label.Left + FullScreen_Label.Width
        Splash_CheckBox.Left = Splash_Label.Left + Splash_Label.Width
        RPC_CheckBox.Left = RPC_Label.Left + RPC_Label.Width
        Settings_Label.Left = (Me.Width / 2) - (Settings_Label.Width / 2)

        For Each el In LauncherForm.resolutions
            Resolution_ListBox.AddItem(el)
        Next

        Resolution_ListBox.ScrollBar.CalculateHeight(LauncherForm.resolutions.Count)

        For i As Integer = 0 To (LauncherForm.languages.Length / 2 - 1)
            Language_ListBox.AddItem(LauncherForm.languages(i * 2))
        Next

        Language_ListBox.ScrollBar.CalculateHeight(LauncherForm.languages.Length / 2)

        Resolution_ListBox.SelectedItem = LauncherForm.settings("resolution")
        Language_ListBox.SelectedItem = LauncherForm.settings("language")

        FullScreen_CheckBox.Checked = LauncherForm.settings("fullscreen")
        Splash_CheckBox.Checked = LauncherForm.settings("splash")
        RPC_CheckBox.Checked = LauncherForm.settings("rpc")
        RPC_Args_Box.Text = LauncherForm.settings("rpcargs")

        If LauncherForm.rpc = False Then
            RPC_CheckBox.CBEnabled = False
            RPC_Args_Box.Enabled = False
        End If

    End Sub

    Private Sub Cancel_Button_MouseEnter(sender As Object, e As EventArgs) Handles Cancel_Button.MouseEnter
        Cancel_Button.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub Cancel_Button_MouseLeave(sender As Object, e As EventArgs) Handles Cancel_Button.MouseLeave
        Cancel_Button.BackgroundImage = My.Resources.button
    End Sub

    Private Sub Cancel_Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel_Button.MouseDown
        Cancel_Button.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub Cancel_Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Cancel_Button.MouseUp
        Cancel_Button.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub Save_Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Save_Button.MouseDown
        Save_Button.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub Save_Button_MouseEnter(sender As Object, e As EventArgs) Handles Save_Button.MouseEnter
        Save_Button.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub Save_Button_MouseLeave(sender As Object, e As EventArgs) Handles Save_Button.MouseLeave
        Save_Button.BackgroundImage = My.Resources.button
    End Sub

    Private Sub Save_Button_MouseUp(sender As Object, e As MouseEventArgs) Handles Save_Button.MouseUp
        Save_Button.BackgroundImage = My.Resources.button_hover
    End Sub

End Class