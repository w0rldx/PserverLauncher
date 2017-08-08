Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO

Public Class ManagerForm
    Dim isrunning As Boolean
    Dim accountserverrunning As Boolean
    Dim Databaseserverisrunning As Boolean
    Dim coreserverisrunning As Boolean
    Dim certifierisrunning As Boolean
    Dim cacheserverisrunning As Boolean
    Dim loginserverisrunning As Boolean
    Dim worldserverisrunning As Boolean
    Dim AccountServer As New Process()
    Dim DatabaseServer As New Process()
    Dim CoreServer As New Process()
    Dim Certifier As New Process()
    Dim CacheServer As New Process()
    Dim LoginServer As New Process()
    Dim WorldServer As New Process()
    Dim defaultstatus As String = "Offline"
    Dim Onlinestatus As String = "Online"
    Dim CurrentPath As String = Application.StartupPath
    Dim path As String = Directory.GetCurrentDirectory()

    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkrunning()
        Me.BackgroundWorker1.RunWorkerAsync(2000)
    End Sub

    Private Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton1.Click
        Me.BackgroundWorker2.RunWorkerAsync()
    End Sub
    Private Sub checkrunning()
        If Process.GetProcessesByName("AccountServer").Length > 0 Then
            CarbonFiberLabel8.Text = Onlinestatus
            accountserverrunning = True
        Else
            CarbonFiberLabel8.Text = defaultstatus
            accountserverrunning = False
        End If

        If Process.GetProcessesByName("Certifier").Length > 0 Then
            CarbonFiberLabel9.Text = Onlinestatus
            certifierisrunning = True
        Else
            CarbonFiberLabel9.Text = defaultstatus
            certifierisrunning = False
        End If

        If Process.GetProcessesByName("DatabaseServer").Length > 0 Then
            CarbonFiberLabel10.Text = Onlinestatus
            Databaseserverisrunning = True
        Else
            CarbonFiberLabel10.Text = defaultstatus
            Databaseserverisrunning = False
        End If

        If Process.GetProcessesByName("CoreServer").Length > 0 Then
            CarbonFiberLabel11.Text = Onlinestatus
            coreserverisrunning = True
        Else
            CarbonFiberLabel11.Text = defaultstatus
            coreserverisrunning = False
        End If

        If Process.GetProcessesByName("LoginServer").Length > 0 Then
            CarbonFiberLabel12.Text = Onlinestatus
            loginserverisrunning = True
        Else
            CarbonFiberLabel12.Text = defaultstatus
            loginserverisrunning = False
        End If

        If Process.GetProcessesByName("CacheServer").Length > 0 Then
            CarbonFiberLabel13.Text = Onlinestatus
            cacheserverisrunning = True
        Else
            CarbonFiberLabel13.Text = defaultstatus
            cacheserverisrunning = False
        End If

        If Process.GetProcessesByName("WorldServer").Length > 0 Then
            CarbonFiberLabel14.Text = Onlinestatus
            worldserverisrunning = True
        Else
            CarbonFiberLabel14.Text = defaultstatus
            worldserverisrunning = False
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do
            checkrunning()
            System.Threading.Thread.Sleep(2000)
        Loop
    End Sub

    Private Sub CarbonFiberButton2_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton2.Click
        Me.BackgroundWorker3.RunWorkerAsync()
    End Sub
    Private Sub starting()
        If Not accountserverrunning = True Then
            AccountServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            AccountServer.StartInfo.FileName = CurrentPath & "\Program\AccountServer.exe"
            If My.Computer.FileSystem.FileExists(path + "\Program\AccountServer.exe") Then
                AccountServer.Start()
                accountserverrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe ob sich die datei im /Program Ordner befindet", MsgBoxStyle.Critical, "Accountserver.exe")
                Return
            End If
            System.Threading.Thread.Sleep(1000)
        End If

        If Not certifierisrunning = True Then
            Certifier.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            Certifier.StartInfo.FileName = CurrentPath & "\Program\Certifier.exe"
            If My.Computer.FileSystem.FileExists(path + "\Program\Certifier.exe") Then
                Certifier.Start()
                certifierisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe ob sich die datei im /Program Ordner befindet", MsgBoxStyle.Critical, "Certifier.exe")
                Return
            End If
            System.Threading.Thread.Sleep(1000)
        End If

        If Not Databaseserverisrunning = True Then
            DatabaseServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            DatabaseServer.StartInfo.FileName = CurrentPath & "\Program\DatabaseServer.exe"
            If My.Computer.FileSystem.FileExists(path + "\Program\DatabaseServer.exe") Then
                DatabaseServer.Start()
                Databaseserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe ob sich die datei im /Program Ordner befindet", MsgBoxStyle.Critical, "DatabaseServer.exe")
                Return
            End If
            System.Threading.Thread.Sleep(5000)
        End If

        If Not coreserverisrunning = True Then
            CoreServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            CoreServer.StartInfo.FileName = CurrentPath & "\Program\CoreServer.exe"
            If My.Computer.FileSystem.FileExists(path + "\Program\CoreServer.exe") Then
                CoreServer.Start()
                coreserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe ob sich die datei im /Program Ordner befindet", MsgBoxStyle.Critical, "CoreServer.exe")
                Return
            End If
            System.Threading.Thread.Sleep(1000)
        End If

        If Not loginserverisrunning = True Then
            LoginServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            LoginServer.StartInfo.FileName = CurrentPath & "\Program\LoginServer.exe"
            If My.Computer.FileSystem.FileExists(path + "\Program\LoginServer.exe") Then
                LoginServer.Start()
                loginserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe ob sich die datei im /Program Ordner befindet", MsgBoxStyle.Critical, "LoginServer.exe")
                Return
            End If
            System.Threading.Thread.Sleep(1000)
        End If

        If Not cacheserverisrunning = True Then
            CacheServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            CacheServer.StartInfo.FileName = CurrentPath & "\Program\CacheServer.exe"
            If My.Computer.FileSystem.FileExists(path + "\Program\CacheServer.exe") Then
                CacheServer.Start()
                cacheserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe ob sich die datei im /Program Ordner befindet", MsgBoxStyle.Critical, "CacheServer.exe")
                Return
            End If
            System.Threading.Thread.Sleep(1000)
        End If

        If Not worldserverisrunning = True Then
            WorldServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            WorldServer.StartInfo.FileName = CurrentPath & "\Program\WorldServer.exe"
            If My.Computer.FileSystem.FileExists(path + "\Program\WorldServer.exe") Then
                WorldServer.Start()
                worldserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe ob sich die datei im /Program Ordner befindet", MsgBoxStyle.Critical, "WorldServer.exe")
                Return
            End If
            System.Threading.Thread.Sleep(1000)
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        starting()
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        stoping()
    End Sub
    Public Sub stoping()
        If worldserverisrunning = True Then
            WorldServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            WorldServer.StartInfo.FileName = CurrentPath & "\Program\WorldServer.exe"
            WorldServer.CloseMainWindow()
            worldserverisrunning = False
        End If

        If cacheserverisrunning = True Then
            CacheServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            CacheServer.StartInfo.FileName = CurrentPath & "\Program\CacheServer.exe"
            CacheServer.CloseMainWindow()
            cacheserverisrunning = False
        End If

        If loginserverisrunning = True Then
            LoginServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            LoginServer.StartInfo.FileName = CurrentPath & "\Program\LoginServer.exe"
            LoginServer.CloseMainWindow()
            loginserverisrunning = False
        End If

        If coreserverisrunning = True Then
            CoreServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            CoreServer.StartInfo.FileName = CurrentPath & "\Program\CoreServer.exe"
            CoreServer.CloseMainWindow()
            coreserverisrunning = False
        End If

        If Databaseserverisrunning = True Then
            DatabaseServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            DatabaseServer.StartInfo.FileName = CurrentPath & "\Program\DatabaseServer.exe"
            DatabaseServer.CloseMainWindow()
            Databaseserverisrunning = False
        End If

        If certifierisrunning = True Then
            Certifier.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            Certifier.StartInfo.FileName = CurrentPath & "\Program\Certifier.exe"
            Certifier.CloseMainWindow()
            certifierisrunning = False
        End If

        If accountserverrunning = True Then
            AccountServer.StartInfo.WorkingDirectory = CurrentPath & "\Program"
            AccountServer.StartInfo.FileName = CurrentPath & "\Program\AccountServer.exe"
            AccountServer.CloseMainWindow()
            accountserverrunning = False
        End If
    End Sub
End Class