Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices


#Region "Win32 Class"
Friend Class Win32

#Region "常量"
    Public Const ULW_COLORKEY As Int32 = &H1
    Public Const ULW_ALPHA As Int32 = &H2
    Public Const ULW_OPAQUE As Int32 = &H4
    Public Const WS_EX_LAYERED As Int32 = &H80000
    Public Const AC_SRC_OVER As Byte = &H0
    Public Const AC_SRC_ALPHA As Byte = &H1
#End Region

#Region "枚举"
    Public Enum Bool
        [False] = 0
        [True]
    End Enum
#End Region

#Region "结构"
    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Private Structure ARGB
        Public Blue As Byte
        Public Green As Byte
        Public Red As Byte
        Public Alpha As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure Size
        Public cx As Int32
        Public cy As Int32

        Public Sub New(ByVal cx As Int32, ByVal cy As Int32)
            Me.cx = cx
            Me.cy = cy
        End Sub
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure Point
        Public x As Int32
        Public y As Int32

        Public Sub New(ByVal x As Int32, ByVal y As Int32)
            Me.x = x
            Me.y = y
        End Sub
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure BLENDFUNCTION
        Public BlendOp As Byte
        Public BlendFlags As Byte
        Public SourceConstantAlpha As Byte
        Public AlphaFormat As Byte
    End Structure
#End Region

#Region "API"

    Public Declare Auto Function GetDC Lib "user32.dll" (ByVal hWnd As IntPtr) As IntPtr

    Public Declare Auto Function CreateCompatibleDC Lib "gdi32.dll" (ByVal hDC As IntPtr) As IntPtr

    Public Declare Auto Function SelectObject Lib "gdi32.dll" (ByVal hDC As IntPtr, ByVal hObject As IntPtr) As IntPtr

    Public Declare Auto Function UpdateLayeredWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal hdcDst As IntPtr, ByRef pptDst As Point, ByRef psize As Size, ByVal hdcSrc As IntPtr, ByRef pprSrc As Point, ByVal crKey As Int32, ByRef pblend As BLENDFUNCTION, ByVal dwFlags As Int32) As Bool

    Public Declare Auto Function ReleaseDC Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Integer

    Public Declare Auto Function DeleteObject Lib "gdi32.dll" (ByVal hObject As IntPtr) As Bool

    Public Declare Auto Function DeleteDC Lib "gdi32.dll" (ByVal hdc As IntPtr) As Bool
#End Region
End Class

#End Region

Public Class AlphaForm
    Inherits Form

    Public Sub SetBitmap(ByVal opacity As Byte)
        Dim bmp As Bitmap = Me.BackgroundImage
        If bmp.PixelFormat <> PixelFormat.Format32bppArgb Then
            Throw New ApplicationException("Błąd")
        End If

        Me.Size = bmp.Size

        Dim hDC1 As IntPtr = Win32.GetDC(IntPtr.Zero)
        Dim hDC2 As IntPtr = Win32.CreateCompatibleDC(hDC1)
        Dim hBitmap1 As IntPtr = IntPtr.Zero
        Dim hBitmap2 As IntPtr = IntPtr.Zero

        Try
            hBitmap1 = bmp.GetHbitmap(Color.FromArgb(0))
            hBitmap2 = Win32.SelectObject(hDC2, hBitmap1)

            Dim blend As New Win32.BLENDFUNCTION()
            With blend
                .BlendOp = Win32.AC_SRC_OVER
                .BlendFlags = 0
                .AlphaFormat = Win32.AC_SRC_ALPHA
                .SourceConstantAlpha = opacity
            End With

            Call Win32.UpdateLayeredWindow(Me.Handle, hDC1, New Win32.Point(Left, Top),
                                           New Win32.Size(Me.Size.Width, Me.Size.Height), hDC2,
                                           New Win32.Point(0, 0), 0, blend, Win32.ULW_ALPHA)

        Finally
            Call Win32.ReleaseDC(IntPtr.Zero, hDC1)
            If hBitmap1 <> IntPtr.Zero Then
                Call Win32.SelectObject(hDC2, hBitmap2)
                Call Win32.DeleteObject(hBitmap1)
            End If
            Call Win32.DeleteDC(hDC2)
        End Try
    End Sub

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            If Not DesignMode Then
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ExStyle = cp.ExStyle Or Win32.WS_EX_LAYERED
                Return cp
            Else
                Return MyBase.CreateParams
            End If
        End Get
    End Property

End Class