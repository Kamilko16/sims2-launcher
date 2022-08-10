Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace ListResolutions
    Friend Class Program
        <DllImport("user32.dll")>
        Public Shared Function EnumDisplaySettings(ByVal deviceName As String, ByVal modeNum As Integer, ByRef devMode As DEVMODE) As Boolean
        End Function

        Const ENUM_CURRENT_SETTINGS As Integer = -1
        Const ENUM_REGISTRY_SETTINGS As Integer = -2

        <StructLayout(LayoutKind.Sequential)>
        Public Structure DEVMODE
            Private Const CCHDEVICENAME As Integer = &H20
            Private Const CCHFORMNAME As Integer = &H20
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=&H20)>
            Public dmDeviceName As String
            Public dmSpecVersion As Short
            Public dmDriverVersion As Short
            Public dmSize As Short
            Public dmDriverExtra As Short
            Public dmFields As Integer
            Public dmPositionX As Integer
            Public dmPositionY As Integer
            Public dmDisplayOrientation As ScreenOrientation
            Public dmDisplayFixedOutput As Integer
            Public dmColor As Short
            Public dmDuplex As Short
            Public dmYResolution As Short
            Public dmTTOption As Short
            Public dmCollate As Short
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=&H20)>
            Public dmFormName As String
            Public dmLogPixels As Short
            Public dmBitsPerPel As Integer
            Public dmPelsWidth As Integer
            Public dmPelsHeight As Integer
            Public dmDisplayFlags As Integer
            Public dmDisplayFrequency As Integer
            Public dmICMMethod As Integer
            Public dmICMIntent As Integer
            Public dmMediaType As Integer
            Public dmDitherType As Integer
            Public dmReserved1 As Integer
            Public dmReserved2 As Integer
            Public dmPanningWidth As Integer
            Public dmPanningHeight As Integer
        End Structure

        Public Function Main() As ArrayList
            Dim resolutions As New ArrayList
            Dim vDevMode As DEVMODE = New DEVMODE()
            Dim i As Integer = 0

            While EnumDisplaySettings(Nothing, i, vDevMode)
                If vDevMode.dmPelsWidth >= 800 Then
                    If Not resolutions.Contains(vDevMode.dmPelsWidth & "x" & vDevMode.dmPelsHeight) Then
                        resolutions.Add(vDevMode.dmPelsWidth & "x" & vDevMode.dmPelsHeight)
                    End If
                End If
                i += 1
            End While

            Return resolutions

        End Function
    End Class
End Namespace