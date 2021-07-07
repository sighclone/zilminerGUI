Imports System.IO

Public Class Form1
    Private Sub closeWindow_Click(sender As Object, e As EventArgs) Handles closeWindow.Click
        Me.Close()
    End Sub

    Private Sub closeWindow_Hover(sender As Object, e As EventArgs) Handles closeWindow.MouseHover
        closeWindow.BackColor = Color.Pink
    End Sub

    Private Sub closeWindow_Leave(sender As Object, e As EventArgs) Handles closeWindow.MouseLeave
        closeWindow.BackColor = Color.Red
    End Sub

    Dim dirloc As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As New OpenFileDialog
        file.Filter = "BAT file (*.bat)|*.bat"
        Dim result As DialogResult = file.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            dirloc = file.FileName.ToString
            MessageBox.Show("You have chosen " + dirloc + " as the bat file!" + Environment.NewLine + "Just double checking...", "Batch file confirmation")
        End If
    End Sub

    'Now we have the location of the .bat file

    Dim counter As Integer = 0

    Private Sub switchSingle_Click(sender As Object, e As EventArgs) Handles switchSingle.Click
        Label1.Hide()
        Label3.Hide()
        Button1.Hide()
        counter = 1
    End Sub

    Private Sub switchDual_Click(sender As Object, e As EventArgs) Handles switchDual.Click
        Label1.Show()
        Label3.Show()
        Button1.Show()
        counter = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles startDual.Click
        pro.Increment(25)
        If counter = 0 Then
            'make zil info
            Dim wallet As String = TextBox3.Text
            Dim URL As String = TextBox1.Text
            Dim port As String = TextBox2.Text
            Dim worker As String = TextBox4.Text
            pro.Increment(25)
            Dim zilcmd As String = "--pow-start " + dirloc + " --pow-end " + dirloc + " -P zil://" + wallet + "." + worker + "@" + URL + ":" + port
            pro.Increment(25)
            Process.Start("savefiles/zilminer.exe", zilcmd)
            pro.Increment(25)
            My.Computer.FileSystem.WriteAllText("savefiles\info.txt", zilcmd, True)
            pro.Value = 0
        Else
            MessageBox.Show("You are in single mining mode! Please switch to dual mining mode to start dual mining", "Mining mode mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub startSingle_Click(sender As Object, e As EventArgs) Handles startSingle.Click
        pro.Increment(25)
        If counter = 1 Then
            'make zil info
            Dim wallet As String = TextBox3.Text
            Dim URL As String = TextBox1.Text
            Dim port As String = TextBox2.Text
            Dim worker As String = TextBox4.Text
            pro.Increment(25)
            Dim zilcmd As String = " -P zil://" + wallet + "." + worker + "@" + URL + ":" + port + " --report-hr=1 --work-timeout=99998 --retry-delay=998 --farm-retries=99998"
            pro.Increment(25)
            Process.Start("savefiles/zilminer.exe", zilcmd)
            pro.Increment(25)
            My.Computer.FileSystem.WriteAllText("savefiles\info.txt", zilcmd, True)
        Else
            MessageBox.Show("You are in dual mining mode! Please switch to single mining mode to start single mining", "Mining mode mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        pro.Value = 0
    End Sub

    Private Sub meta_Click(sender As Object, e As EventArgs) Handles meta.Click
        MessageBox.Show("This program is made by:" + Environment.NewLine + Environment.NewLine + "github.com/sighclone" + Environment.NewLine + "Donate: zil1fzkshmcu7ud7s2k8ct6pkffntet9700kfh8gf2" + Environment.NewLine + Environment.NewLine + "NOTE: This is not zilminer nor is zilminer integrated into this! This is only a GUI that starts zilminer. So, feel free to close this window once zilminer starts.", "Meta")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pro.Minimum = 0
        pro.Maximum = 100
        Dim fileReader As String
        pro.Increment(33)
        Try
            fileReader = My.Computer.FileSystem.ReadAllText("savefiles\info.txt")
            pro.Increment(33)
            Process.Start("savefiles/zilminer.exe", fileReader)
            pro.Increment(33)
        Catch ex As Exception
        End Try
        pro.Value = 0
    End Sub
End Class