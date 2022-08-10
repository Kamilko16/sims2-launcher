Imports System.IO
Public Class CustomContentForm

    Private loaded = False

    Private pkgs As New Dictionary(Of String, String)
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub CustomContentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Functions.SetStringsCC()
        Functions.DoubleBufferedPanel(MyPanel1, True)
        Functions.DoubleBufferedPanel(CC_ListBox.Radio_External_Container, True)
        Functions.DoubleBufferedPanel(CC_ListBox.Radio_Internal_Container, True)
        CC_Label.Left = (Me.Width / 2) - (CC_Label.Width / 2)
        Search_Tip.Parent = CC_ListBox
        Search_Tip.Left = (CC_ListBox.Width / 2) - (Search_Tip.Width / 2)
        Search_Tip.Top = (CC_ListBox.Height / 2) - (Search_Tip.Height / 2)
        Search_Tip.BringToFront()

        Me.Enabled = False

        MainBW.RunWorkerAsync()
    End Sub

    Private Sub Search_Box_Enter(sender As Object, e As EventArgs) Handles Search_Box.Enter
        If Search_Box.Text = LauncherForm.RM.GetString("Search") Then
            Search_Box.Text = ""
        End If
    End Sub

    Private Sub Search_Box_Leave(sender As Object, e As EventArgs) Handles Search_Box.Leave
        If Search_Box.Text = "" Then
            Search_Box.Text = LauncherForm.RM.GetString("Search")
        End If
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        For Each el As MyCBButton In CC_ListBox.Radio_Internal_Container.Controls
            Dim name = el.CB_Value.Text
            If pkgs(name).Substring(pkgs(name).Length - 8, 8) = "disabled" Then
                If el.Checked = True Then
                    My.Computer.FileSystem.RenameFile(pkgs(name), name & ".package")
                End If
            Else
                If el.Checked = False Then
                    My.Computer.FileSystem.RenameFile(pkgs(name), name & ".package.disabled")
                End If
            End If

        Next
        Me.Close()
        LauncherForm.BringToFront()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
        LauncherForm.BringToFront()
    End Sub

    Private Sub MainBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles MainBW.DoWork
        MainBW.ReportProgress(0)

        Dim uf = My.Computer.Registry.GetValue(Functions.GetRegistry() & "The Sims 2", "DisplayName", Nothing)

        Dim path = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EA Games\" & uf & "\Downloads"

        If Directory.Exists(path) Then
            Dim perc = 0
            Dim pkg() As String = Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EA Games\" & uf & "\Downloads", "*.package*", SearchOption.AllDirectories)
            For Each el As String In pkg
                perc += 1
                MainBW.ReportProgress(Int(perc / pkg.Length * 100))
                Dim elpath As String() = el.Split("\")
                Dim name = elpath(elpath.Length - 1)
                If name.Substring(name.Length - 7, 7) = "package" Then
                    name = name.Substring(0, name.Length - 8)
                    If Not pkgs.ContainsKey(name) Then
                        pkgs.Add(name, el)
                    End If

                Else
                    name = name.Substring(0, name.Length - 17)
                    If Not pkgs.ContainsKey(name) Then
                        pkgs.Add(name, el)
                    End If
                End If

            Next

        End If

        MainBW.ReportProgress(100)
    End Sub

    Private Sub MainBW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles MainBW.RunWorkerCompleted
        If CC_ListBox.Items > 0 Then
            CC_ListBox.ScrollBar.CalculateHeight(CC_ListBox.Items)
        End If
        Search_Tip.Text = "Try searching for something"
        Me.Enabled = True
        loaded = True
    End Sub

    Private Sub MainBW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles MainBW.ProgressChanged
        Search_Tip.Text = "Loading packages " & e.ProgressPercentage & "%..."
    End Sub

    Private Sub Search_Box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Search_Box.KeyPress
        If e.KeyChar = vbCr Then
            CC_ListBox.Clear()
            e.Handled = True
            If Search_Box.Text <> "" Then
                Search_Tip.Text = "Loading..."
                Search_Tip.Show()
                SearchBW.RunWorkerAsync()
            Else
                Search_Tip.Text = "Try searching for something"
                Search_Tip.Show()
            End If
        End If
    End Sub

    Private Sub SearchBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SearchBW.DoWork
        e.Result = pkgs.ToList.FindAll(Function(p) p.Key.ToLower.Contains(Search_Box.Text.ToLower))
    End Sub

    Private Sub SearchBW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles SearchBW.RunWorkerCompleted
        For Each el In e.Result
            If pkgs(el.Key).Substring(pkgs(el.Key).Length - 8, 8) = "disabled" Then
                CC_ListBox.AddItem(el.Key, False)
            Else
                CC_ListBox.AddItem(el.Key, True)
            End If

        Next
        If CC_ListBox.Items <> 0 Then
            Search_Tip.Hide()
            CC_ListBox.ScrollBar.CalculateHeight(CC_ListBox.Items)
        Else
            CC_ListBox.ScrollBar.CalculateHeight(1)
            Search_Tip.Text = "Nothing was found"
            Search_Tip.Show()
        End If
    End Sub
End Class