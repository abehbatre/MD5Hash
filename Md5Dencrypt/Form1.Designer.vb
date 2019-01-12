<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Saya = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MD5 "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(406, 93)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RichTextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 172)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ASCII"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox2.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(403, 153)
        Me.RichTextBox2.TabIndex = 0
        Me.RichTextBox2.Text = ""
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 137)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(309, 13)
        Me.ProgressBar1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Progress [ - / - ]"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(334, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(434, 362)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ProgressBar1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(426, 336)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "  --  MD5 TO ASCII  --  "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.ProgressBar2)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(426, 336)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  --  ASCII TO MD5  --  "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Progress"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "START"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(6, 314)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(311, 13)
        Me.ProgressBar2.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RichTextBox4)
        Me.GroupBox4.Location = New System.Drawing.Point(145, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(275, 288)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MD5"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.Location = New System.Drawing.Point(537, 189)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox5.TabIndex = 1
        Me.RichTextBox5.Text = ""
        Me.RichTextBox5.Visible = False
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox4.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(269, 269)
        Me.RichTextBox4.TabIndex = 0
        Me.RichTextBox4.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RichTextBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 288)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ASCII"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox3.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(127, 269)
        Me.RichTextBox3.TabIndex = 1
        Me.RichTextBox3.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(537, 163)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Saya)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(426, 336)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "  --  ABOUT  --  "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Saya
        '
        Me.Saya.AutoSize = True
        Me.Saya.Location = New System.Drawing.Point(17, 40)
        Me.Saya.Name = "Saya"
        Me.Saya.Size = New System.Drawing.Size(226, 78)
        Me.Saya.TabIndex = 1
        Me.Saya.Text = resources.GetString("Saya.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Program Maker"
        '
        'BackgroundWorker2
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(441, 372)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "MD5 Tools 0.1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Saya As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
End Class
