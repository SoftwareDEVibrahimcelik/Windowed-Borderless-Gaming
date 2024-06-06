Imports System.Runtime.InteropServices
Imports System.Management
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Media
Public Class ibrahimcelik


    'Patreon: https://www.patreon.com/devibrahimcelik  // For Donation
    'YouTube: https://www.youtube.com/@devibrahimcelik/
    'Github: https://github.com/SoftwareDEVibrahimcelik



    Private Declare Function EnumWindows Lib "user32" (ByVal lpEnumFunc As EnumWindowsProc, ByVal lParam As IntPtr) As Boolean
    Private Delegate Function EnumWindowsProc(ByVal hWnd As IntPtr, ByVal lParam As IntPtr) As Boolean
    Private Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hWnd As IntPtr, ByVal lpString As String, ByVal nMaxCount As Integer) As Integer
    Private Declare Function GetWindowTextLength Lib "user32" Alias "GetWindowTextLengthA" (ByVal hWnd As IntPtr) As Integer
    Private Declare Function IsWindowVisible Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowLong(hWnd As IntPtr, nIndex As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean
    End Function

    Private Const GWL_STYLE As Integer = -16
    Private Const WS_CAPTION As Integer = &HC00000
    Private Const SW_RESTORE As Integer = 9
    Private Const SW_MAXIMIZE As Integer = 3

    ''ibrahimcelik8696
    ''Instagram: @softwaredevic
    Dim player As New SoundPlayer()


    <DllImport("steam_api.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SteamAPI_Init() As Boolean
    End Function

    <DllImport("steam_api.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Sub SteamAPI_Shutdown()
    End Sub

    <DllImport("steam_api.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SteamAPI_RestartAppIfNecessary(ByVal appId As Integer) As Integer
    End Function

    Private Sub ibrahimcelik_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DEVELOPED by IBRAHIM CELIK - Instagram: @softwaredevic
        'YouTube: https://www.youtube.com/@devibrahimcelik/
        'Patreon: https://www.patreon.com/devibrahimcelik



        Bildirim.BalloonTipTitle = Label3.Text
        Bildirim.BalloonTipText = "Welcome to Windowed Borderless Gaming "
        Bildirim.ShowBalloonTip(1000)


        ListBox1.Items.Clear()
        EnumerateWindows()
        player.Stream = My.Resources.ibrahimcelik
    End Sub

    Private Sub EnumerateWindows()
        Dim enumFunc As EnumWindowsProc = AddressOf EnumWindow
        EnumWindows(enumFunc, IntPtr.Zero)
    End Sub

    Private Function EnumWindow(ByVal hWnd As IntPtr, ByVal lParam As IntPtr) As Boolean
        If IsWindowVisible(hWnd) Then
            Dim titleLength As Integer = GetWindowTextLength(hWnd) + 1
            Dim title As String = Space(titleLength)
            GetWindowText(hWnd, title, titleLength)

            If Not String.IsNullOrEmpty(title.Trim()) Then
                ListBox1.Items.Add(title)
            End If
        End If
        Return True
    End Function

    Private Sub tamekran_Click(sender As Object, e As EventArgs) Handles tamekran.Click
        player.Play()
        Dim targetWindow As IntPtr = FindWindow(Nothing, softwaredevic.Text)
        If targetWindow <> IntPtr.Zero Then
            Dim currentStyle As Integer = GetWindowLong(targetWindow, GWL_STYLE)
            If (currentStyle And WS_CAPTION) <> 0 Then
                SetWindowLong(targetWindow, GWL_STYLE, currentStyle And Not WS_CAPTION)
                ShowWindow(targetWindow, SW_MAXIMIZE)
                '
                ListBox1.Items.Clear()
                EnumerateWindows()
            Else
                SetWindowLong(targetWindow, GWL_STYLE, currentStyle Or WS_CAPTION)
                ShowWindow(targetWindow, SW_RESTORE)
            End If
        Else
            MessageBox.Show("No target windows were found" & vbCrLf + "Please Select on list ( Click )")
        End If
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        player.Play()
        ListBox1.Items.Clear()
        EnumerateWindows()
    End Sub

    Private Sub windowed_Click(sender As Object, e As EventArgs) Handles windowed.Click
        player.Play()
        Dim targetWindow As IntPtr = FindWindow(Nothing, softwaredevic.Text)
        If targetWindow <> IntPtr.Zero Then
            Dim currentStyle As Integer = GetWindowLong(targetWindow, GWL_STYLE)
            If (currentStyle And WS_CAPTION) <> 0 Then
                SetWindowLong(targetWindow, GWL_STYLE, currentStyle And Not WS_CAPTION)
                ShowWindow(targetWindow, SW_RESTORE)
                '
                ListBox1.Items.Clear()
                EnumerateWindows()
            Else
                SetWindowLong(targetWindow, GWL_STYLE, currentStyle Or WS_CAPTION)
                ShowWindow(targetWindow, SW_RESTORE)
            End If
        Else
            MessageBox.Show("No target windows were found" & vbCrLf + "Please Select on list ( Click )")
        End If



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        softwaredevic.Text = ListBox1.SelectedItem.ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next

        Dim itemsToRemove As New List(Of Object)()

        For i As Integer = ListBox1.Items.Count - 1 To 0 Step -1
            Dim itemText As String = ListBox1.Items(i).ToString()
            If String.IsNullOrWhiteSpace(itemText) OrElse itemText.Length < 2 Then
                itemsToRemove.Add(ListBox1.Items(i))
            End If
        Next

        For Each itemToRemove As Object In itemsToRemove
            ListBox1.Items.Remove(itemToRemove)
        Next

        Dim random As New Random()
        Dim red As Integer = random.Next(256)
        Dim green As Integer = random.Next(256)
        Dim blue As Integer = random.Next(256)

        ' Label3.ForeColor = Color.FromArgb(red, green, blue)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        System.Diagnostics.Process.Start("https://store.steampowered.com/app/2923480/")
        MsgBox("Developed by IBRAHIM CELIK" & vbCrLf & "Instagram: @softwaredevic" & vbCrLf & "YouTube: @devibrahimcelik")
        System.Diagnostics.Process.Start("https://www.youtube.com/@devibrahimcelik/")
    End Sub

    Private Sub Bildirim_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Bildirim.MouseDoubleClick

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.patreon.com/devibrahimcelik")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://store.steampowered.com/app/2923480/")
    End Sub




End Class