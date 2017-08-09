Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Globalization
Imports nUpdate.Updating
Imports System.Threading

Public Class ManagerForm
    Dim isrunning As Boolean
    Dim accountserverisrunning As Boolean
    Dim Databaseserverisrunning As Boolean
    Dim coreserverisrunning As Boolean
    Dim certifierisrunning As Boolean
    Dim cacheserverisrunning As Boolean
    Dim loginserverisrunning As Boolean
    Dim worldserverisrunning As Boolean
    Dim AccountServer As New System.Diagnostics.Process()
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
    Dim workingpfad As String
    Dim workingfile As System.IO.FileInfo
    Dim processname As String
    Dim processend As String
    Dim accountserverstring As String


    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim updaterUI As New UpdaterUI(manager, SynchronizationContext.Current)
        updaterUI.ShowUserInterface()
        updaterUI.UseHiddenSearch = True
        checkrunning()
        Me.BackgroundWorker1.RunWorkerAsync(2000)
    End Sub

    Private Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton1.Click
        Me.BackgroundWorker2.RunWorkerAsync()
    End Sub
    Private Sub checkrunning()

        processname = System.IO.Path.GetFileNameWithoutExtension(My.Settings.Pfad1)
        If Process.GetProcessesByName(processname).Count > 0 Then
            CarbonFiberLabel8.Text = Onlinestatus
            accountserverisrunning = True
        Else
            CarbonFiberLabel8.Text = defaultstatus
            accountserverisrunning = False
        End If

        processname = System.IO.Path.GetFileNameWithoutExtension(My.Settings.Pfad2)
        If Process.GetProcessesByName(processname).Count > 0 Then
            CarbonFiberLabel9.Text = Onlinestatus
            certifierisrunning = True
        Else
            CarbonFiberLabel9.Text = defaultstatus
            certifierisrunning = False
        End If

        processname = System.IO.Path.GetFileNameWithoutExtension(My.Settings.Pfad3)
        If Process.GetProcessesByName(processname).Count > 0 Then
            CarbonFiberLabel10.Text = Onlinestatus
            Databaseserverisrunning = True
        Else
            CarbonFiberLabel10.Text = defaultstatus
            Databaseserverisrunning = False
        End If

        processname = System.IO.Path.GetFileNameWithoutExtension(My.Settings.Pfad4)
        If Process.GetProcessesByName(processname).Count > 0 Then
            CarbonFiberLabel11.Text = Onlinestatus
            coreserverisrunning = True
        Else
            CarbonFiberLabel11.Text = defaultstatus
            coreserverisrunning = False
        End If

        processname = System.IO.Path.GetFileNameWithoutExtension(My.Settings.Pfad5)
        If Process.GetProcessesByName(processname).Count > 0 Then
            CarbonFiberLabel12.Text = Onlinestatus
            loginserverisrunning = True
        Else
            CarbonFiberLabel12.Text = defaultstatus
            loginserverisrunning = False
        End If

        processname = System.IO.Path.GetFileNameWithoutExtension(My.Settings.Pfad6)
        If Process.GetProcessesByName(processname).Count > 0 Then
            CarbonFiberLabel13.Text = Onlinestatus
            cacheserverisrunning = True
        Else
            CarbonFiberLabel13.Text = defaultstatus
            cacheserverisrunning = False
        End If

        processname = System.IO.Path.GetFileNameWithoutExtension(My.Settings.Pfad7)
        If Process.GetProcessesByName(processname).Count > 0 Then
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
        If Not accountserverisrunning = True Then
            workingfile = My.Computer.FileSystem.GetFileInfo(My.Settings.Pfad1)
            workingpfad = workingfile.DirectoryName
            AccountServer.StartInfo.WorkingDirectory = workingpfad
            AccountServer.StartInfo.FileName = My.Settings.Pfad1
            If My.Computer.FileSystem.FileExists(My.Settings.Pfad1) Then
                AccountServer.Start()
                accountserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe die Pfad Einstellungen", MsgBoxStyle.Critical, "Accountserver")
                Return
            End If
            System.Threading.Thread.Sleep(My.Settings.verzögerung1)
        End If

        If Not certifierisrunning = True Then
            workingfile = My.Computer.FileSystem.GetFileInfo(My.Settings.Pfad2)
            workingpfad = workingfile.DirectoryName
            Certifier.StartInfo.WorkingDirectory = workingpfad
            Certifier.StartInfo.FileName = My.Settings.Pfad2
            If My.Computer.FileSystem.FileExists(My.Settings.Pfad2) Then
                Certifier.Start()
                certifierisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe die Pfad Einstellungen", MsgBoxStyle.Critical, "Certifier")
                Return
            End If
            System.Threading.Thread.Sleep(My.Settings.verzögerung2)
        End If

        If Not Databaseserverisrunning = True Then
            workingfile = My.Computer.FileSystem.GetFileInfo(My.Settings.Pfad3)
            workingpfad = workingfile.DirectoryName
            DatabaseServer.StartInfo.WorkingDirectory = workingpfad
            DatabaseServer.StartInfo.FileName = My.Settings.Pfad3
            If My.Computer.FileSystem.FileExists(My.Settings.Pfad3) Then
                DatabaseServer.Start()
                Databaseserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe die Pfad Einstellungen", MsgBoxStyle.Critical, "DatabaseServer")
                Return
            End If
            System.Threading.Thread.Sleep(My.Settings.verzögerung3)
        End If

        If Not coreserverisrunning = True Then
            workingfile = My.Computer.FileSystem.GetFileInfo(My.Settings.Pfad4)
            workingpfad = workingfile.DirectoryName
            CoreServer.StartInfo.WorkingDirectory = workingpfad
            CoreServer.StartInfo.FileName = My.Settings.Pfad4
            If My.Computer.FileSystem.FileExists(My.Settings.Pfad4) Then
                CoreServer.Start()
                coreserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe die Pfad Einstellungen", MsgBoxStyle.Critical, "CoreServer")
                Return
            End If
            System.Threading.Thread.Sleep(My.Settings.verzögerung4)
        End If

        If Not loginserverisrunning = True Then
            workingfile = My.Computer.FileSystem.GetFileInfo(My.Settings.Pfad5)
            workingpfad = workingfile.DirectoryName
            LoginServer.StartInfo.WorkingDirectory = workingpfad
            LoginServer.StartInfo.FileName = My.Settings.Pfad5
            If My.Computer.FileSystem.FileExists(My.Settings.Pfad5) Then
                LoginServer.Start()
                loginserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe die Pfad Einstellungen", MsgBoxStyle.Critical, "LoginServer")
                Return
            End If
            System.Threading.Thread.Sleep(My.Settings.verzögerung5)
        End If

        If Not cacheserverisrunning = True Then
            workingfile = My.Computer.FileSystem.GetFileInfo(My.Settings.Pfad6)
            workingpfad = workingfile.DirectoryName
            CacheServer.StartInfo.WorkingDirectory = workingpfad
            CacheServer.StartInfo.FileName = My.Settings.Pfad6
            If My.Computer.FileSystem.FileExists(My.Settings.Pfad6) Then
                CacheServer.Start()
                cacheserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe die Pfad Einstellungen", MsgBoxStyle.Critical, "CacheServer")
                Return
            End If
            System.Threading.Thread.Sleep(My.Settings.verzögerung6)
        End If

        If Not worldserverisrunning = True Then
            workingfile = My.Computer.FileSystem.GetFileInfo(My.Settings.Pfad7)
            workingpfad = workingfile.DirectoryName
            WorldServer.StartInfo.WorkingDirectory = workingpfad
            WorldServer.StartInfo.FileName = My.Settings.Pfad7
            If My.Computer.FileSystem.FileExists(My.Settings.Pfad7) Then
                WorldServer.Start()
                worldserverisrunning = True
            Else
                MsgBox("Die Datei wurde nicht gefunden oder existiert nicht" & vbCrLf & "Bitte überprüfe die Pfad Einstellungen", MsgBoxStyle.Critical, "WorldServer")
                Return
            End If
            System.Threading.Thread.Sleep(My.Settings.verzögerung7)
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
            processend = System.IO.Path.GetFileName(My.Settings.Pfad7)
            WorldServer.StartInfo.FileName = My.Settings.Pfad7
            WorldServer.CloseMainWindow()
            If WorldServer.HasExited = False Then
                WorldServer.Kill()
            End If
            worldserverisrunning = False
        End If

        If cacheserverisrunning = True Then
            processend = System.IO.Path.GetFileName(My.Settings.Pfad6)
            CacheServer.StartInfo.FileName = My.Settings.Pfad6
            CacheServer.CloseMainWindow()
            If CacheServer.HasExited = False Then
                CacheServer.Kill()
            End If
            cacheserverisrunning = False
        End If

        If loginserverisrunning = True Then
            processend = System.IO.Path.GetFileName(My.Settings.Pfad5)
            LoginServer.StartInfo.FileName = My.Settings.Pfad5
            LoginServer.CloseMainWindow()
            If LoginServer.HasExited = False Then
                LoginServer.Kill()
            End If
            loginserverisrunning = False
        End If

        If coreserverisrunning = True Then
            processend = System.IO.Path.GetFileName(My.Settings.Pfad4)
            CoreServer.StartInfo.FileName = My.Settings.Pfad4
            CoreServer.CloseMainWindow()
            If CoreServer.HasExited = False Then
                CoreServer.Kill()
            End If
            coreserverisrunning = False
        End If

        If Databaseserverisrunning = True Then
            processend = System.IO.Path.GetFileName(My.Settings.Pfad3)
            DatabaseServer.StartInfo.FileName = My.Settings.Pfad3
            DatabaseServer.CloseMainWindow()
            If DatabaseServer.HasExited = False Then
                DatabaseServer.Kill()
            End If
            Databaseserverisrunning = False
        End If

        If certifierisrunning = True Then
            processend = System.IO.Path.GetFileName(My.Settings.Pfad2)
            Certifier.StartInfo.FileName = My.Settings.Pfad2
            Certifier.CloseMainWindow()
            If Certifier.HasExited = False Then
                Certifier.Kill()
            End If
            certifierisrunning = False
        End If


        If accountserverisrunning = True Then
            processend = System.IO.Path.GetFileName(My.Settings.Pfad1)
            Certifier.StartInfo.FileName = My.Settings.Pfad1
            AccountServer.CloseMainWindow()
            If AccountServer.HasExited = False Then
                AccountServer.Kill()
            End If
            accountserverisrunning = False
        End If
    End Sub

    Private Sub CarbonFiberButton3_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton3.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub CarbonFiberControlButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberControlButton1.Click
        Application.Exit()
    End Sub
End Class