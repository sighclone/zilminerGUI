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
    Dim stoploc As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As New OpenFileDialog
        file.Filter = "BAT file (*.bat)|*.bat"
        Dim result As DialogResult = file.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            dirloc = file.FileName.ToString
            MessageBox.Show("You have chosen " + dirloc + " as the start file!" + Environment.NewLine + "Just double checking...", "Batch file confirmation")
            dirconf.Text = "file selection done!"
        End If
    End Sub

    'Now we have the location of the .bat file

    Dim counter As Integer = 0

    Private Sub switchSingle_Click(sender As Object, e As EventArgs) Handles switchSingle.Click
        Label1.Hide()
        Label3.Hide()
        Button1.Hide()
        dirconf.Hide()
        stopconf.Hide()
        Label3.Hide()
        Button2.Hide()
        counter = 1
    End Sub

    Private Sub switchDual_Click(sender As Object, e As EventArgs) Handles switchDual.Click
        Label1.Show()
        Label3.Show()
        Button1.Show()
        dirconf.Show()
        stopconf.Show()
        Label3.Show()
        Button2.Show()
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
            Dim zilcmd As String = "--pow-start " + dirloc + " --pow-end " + stoploc + " " + DAGstatus + " " + " -P zil://" + wallet + "." + worker + "@" + URL + ":" + port
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
        If counter = 1 Then
            'make zil info
            pro.Increment(25)
            Dim wallet As String = TextBox3.Text
            Dim URL As String = TextBox1.Text
            Dim port As String = TextBox2.Text
            Dim worker As String = TextBox4.Text
            pro.Increment(25)
            Dim zilcmd As String = " " + DAGstatus + " -P zil://" + wallet + "." + worker + "@" + URL + ":" + port + " --report-hr=1 --work-timeout=99998 --retry-delay=998 --farm-retries=99998"
            pro.Increment(25)
            Process.Start("savefiles\zilminer.exe", zilcmd)
            pro.Increment(25)
            IO.File.WriteAllText("savefiles\info.txt", zilcmd)
        Else
            MessageBox.Show("You are in dual mining mode! Please switch to single mining mode to start single mining", "Mining mode mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub meta_Click(sender As Object, e As EventArgs) Handles meta.Click
        MessageBox.Show("This program is made by:" + Environment.NewLine + Environment.NewLine + "github.com/sighclone" + Environment.NewLine + Environment.NewLine + "If you liked this program, please consider donating! Every 0.000~1 ZIL counts!" + Environment.NewLine + Environment.NewLine + "My ZIL wallet address: zil1fzkshmcu7ud7s2k8ct6pkffntet9700kfh8gf2" + Environment.NewLine + Environment.NewLine + "NOTE: This is not zilminer nor is zilminer integrated into this! This is only a GUI that operates zilminer on your behalf. So, feel free to close the zilminerGUI window once zilminer starts.", "Meta", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pro.Minimum = 0
        pro.Maximum = 100
        Dim fileReader As String
        pro.Increment(33)
        Try
            fileReader = My.Computer.FileSystem.ReadAllText("savefiles\info.txt")
            pro.Increment(33)
            Process.Start("savefiles\zilminer.exe", fileReader)
            pro.Increment(33)
        Catch ex As Exception
        End Try
        pro.Value = 0
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim file As New OpenFileDialog
        file.Filter = "BAT file (*.bat)|*.bat"
        Dim result As DialogResult = file.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            stoploc = file.FileName.ToString
            MessageBox.Show("You have chosen " + stoploc + " as the stop file!" + Environment.NewLine + "Just double checking...", "Batch file confirmation")
            stopconf.Text = "file selection done!"
        End If
    End Sub

    Dim checkDAG As Boolean = False
    Dim DAGstatus As String = ""
    Private Sub DAGClearButton_Click(sender As Object, e As EventArgs) Handles DAGClearButton.Click
        If checkDAG = False Then
            DAGClearButton.Text = "My GPU's memory is sufficient!"
            DAGClearStatus.Text = "DAG clearing enabled"
            DAGstatus = "--clear-dag"
            checkDAG = True
        Else
            DAGClearButton.Text = "My GPU's memory is insufficient!"
            DAGClearStatus.Text = "DAG clearing disabled"
            DAGstatus = ""
            checkDAG = False
        End If
    End Sub

    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class