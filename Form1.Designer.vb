﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Title = New System.Windows.Forms.Label()
        Me.closeWindow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.startDual = New System.Windows.Forms.Button()
        Me.pro = New System.Windows.Forms.ProgressBar()
        Me.switchSingle = New System.Windows.Forms.Button()
        Me.switchDual = New System.Windows.Forms.Button()
        Me.startSingle = New System.Windows.Forms.Button()
        Me.meta = New System.Windows.Forms.Button()
        Me.ZilliqaLogo = New System.Windows.Forms.PictureBox()
        CType(Me.ZilliqaLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.ForeColor = System.Drawing.Color.Aqua
        Me.Title.Location = New System.Drawing.Point(99, 27)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(146, 45)
        Me.Title.TabIndex = 0
        Me.Title.Text = "zilminerGUI"
        '
        'closeWindow
        '
        Me.closeWindow.BackColor = System.Drawing.Color.Red
        Me.closeWindow.FlatAppearance.BorderSize = 0
        Me.closeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeWindow.Location = New System.Drawing.Point(612, 12)
        Me.closeWindow.Name = "closeWindow"
        Me.closeWindow.Size = New System.Drawing.Size(50, 50)
        Me.closeWindow.TabIndex = 1
        Me.closeWindow.Text = "❌"
        Me.closeWindow.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1. Where is the other miner's .bat file?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(11, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(650, 109)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Locate file..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "2. What is your pool URL?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(501, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "(usually start.bat)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Type it here:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 300)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "ex: as1-zil.shardpool.io, eu.ezil.me"
        Me.TextBox1.Size = New System.Drawing.Size(525, 26)
        Me.TextBox1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(282, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "3. What is the connection port?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 26)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Type it here:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(136, 379)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PlaceholderText = "ex: 5000/api, 1287"
        Me.TextBox2.Size = New System.Drawing.Size(525, 26)
        Me.TextBox2.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 429)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(335, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "4. What is your Zilliqa wallet address?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 455)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 26)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Type it here:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(136, 455)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PlaceholderText = "ex: zil1fzksh..., zil28ydha..."
        Me.TextBox3.Size = New System.Drawing.Size(525, 26)
        Me.TextBox3.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 502)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(312, 26)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "5. What is your pool worker name?"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 531)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 26)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Type it here:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(136, 531)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PlaceholderText = "If you have a pool user ID enter that, else you can type anything here..."
        Me.TextBox4.Size = New System.Drawing.Size(525, 26)
        Me.TextBox4.TabIndex = 17
        '
        'startDual
        '
        Me.startDual.BackColor = System.Drawing.Color.Aqua
        Me.startDual.FlatAppearance.BorderSize = 0
        Me.startDual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startDual.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startDual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.startDual.Location = New System.Drawing.Point(11, 581)
        Me.startDual.Name = "startDual"
        Me.startDual.Size = New System.Drawing.Size(147, 101)
        Me.startDual.TabIndex = 18
        Me.startDual.Text = "Start Dual Mining"
        Me.startDual.UseVisualStyleBackColor = False
        '
        'pro
        '
        Me.pro.Location = New System.Drawing.Point(11, 688)
        Me.pro.Name = "pro"
        Me.pro.Size = New System.Drawing.Size(653, 43)
        Me.pro.TabIndex = 19
        '
        'switchSingle
        '
        Me.switchSingle.BackColor = System.Drawing.Color.Aqua
        Me.switchSingle.FlatAppearance.BorderSize = 0
        Me.switchSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.switchSingle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.switchSingle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.switchSingle.Location = New System.Drawing.Point(164, 581)
        Me.switchSingle.Name = "switchSingle"
        Me.switchSingle.Size = New System.Drawing.Size(147, 101)
        Me.switchSingle.TabIndex = 20
        Me.switchSingle.Text = "Switch to single mining"
        Me.switchSingle.UseVisualStyleBackColor = False
        '
        'switchDual
        '
        Me.switchDual.BackColor = System.Drawing.Color.Aqua
        Me.switchDual.FlatAppearance.BorderSize = 0
        Me.switchDual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.switchDual.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.switchDual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.switchDual.Location = New System.Drawing.Point(317, 581)
        Me.switchDual.Name = "switchDual"
        Me.switchDual.Size = New System.Drawing.Size(147, 101)
        Me.switchDual.TabIndex = 21
        Me.switchDual.Text = "Switch to dual mining"
        Me.switchDual.UseVisualStyleBackColor = False
        '
        'startSingle
        '
        Me.startSingle.BackColor = System.Drawing.Color.Aqua
        Me.startSingle.FlatAppearance.BorderSize = 0
        Me.startSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startSingle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startSingle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.startSingle.Location = New System.Drawing.Point(470, 581)
        Me.startSingle.Name = "startSingle"
        Me.startSingle.Size = New System.Drawing.Size(147, 101)
        Me.startSingle.TabIndex = 22
        Me.startSingle.Text = "Start Single Mining"
        Me.startSingle.UseVisualStyleBackColor = False
        '
        'meta
        '
        Me.meta.BackColor = System.Drawing.Color.Aqua
        Me.meta.FlatAppearance.BorderSize = 0
        Me.meta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.meta.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.meta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meta.Location = New System.Drawing.Point(623, 581)
        Me.meta.Name = "meta"
        Me.meta.Size = New System.Drawing.Size(41, 101)
        Me.meta.TabIndex = 23
        Me.meta.Text = "»"
        Me.meta.UseVisualStyleBackColor = False
        '
        'ZilliqaLogo
        '
        Me.ZilliqaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ZilliqaLogo.ErrorImage = CType(resources.GetObject("ZilliqaLogo.ErrorImage"), System.Drawing.Image)
        Me.ZilliqaLogo.Image = CType(resources.GetObject("ZilliqaLogo.Image"), System.Drawing.Image)
        Me.ZilliqaLogo.InitialImage = CType(resources.GetObject("ZilliqaLogo.InitialImage"), System.Drawing.Image)
        Me.ZilliqaLogo.Location = New System.Drawing.Point(13, 13)
        Me.ZilliqaLogo.Name = "ZilliqaLogo"
        Me.ZilliqaLogo.Size = New System.Drawing.Size(80, 78)
        Me.ZilliqaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ZilliqaLogo.TabIndex = 24
        Me.ZilliqaLogo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 743)
        Me.Controls.Add(Me.ZilliqaLogo)
        Me.Controls.Add(Me.meta)
        Me.Controls.Add(Me.startSingle)
        Me.Controls.Add(Me.switchDual)
        Me.Controls.Add(Me.switchSingle)
        Me.Controls.Add(Me.pro)
        Me.Controls.Add(Me.startDual)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeWindow)
        Me.Controls.Add(Me.Title)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ZilliqaLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents closeWindow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents startDual As Button
    Friend WithEvents pro As ProgressBar
    Friend WithEvents switchSingle As Button
    Friend WithEvents switchDual As Button
    Friend WithEvents startSingle As Button
    Friend WithEvents meta As Button
    Friend WithEvents ZilliqaLogo As PictureBox
End Class