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
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.pbwebcam = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnstopalarm = New System.Windows.Forms.Button()
        Me.btntriggeralarm = New System.Windows.Forms.Button()
        Me.btnrecord = New System.Windows.Forms.Button()
        Me.btncapture = New System.Windows.Forms.Button()
        Me.grpboxdatetime = New System.Windows.Forms.GroupBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timerdatetime = New System.Windows.Forms.Timer(Me.components)
        Me.timerwebcam = New System.Windows.Forms.Timer(Me.components)
        Me.grpboxconnect = New System.Windows.Forms.GroupBox()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.tbSerialMonitor = New System.Windows.Forms.TextBox()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.rtTypeCommand = New System.Windows.Forms.RichTextBox()
        Me.lblbaud = New System.Windows.Forms.Label()
        Me.lblport = New System.Windows.Forms.Label()
        Me.cbbaudrate = New System.Windows.Forms.ComboBox()
        Me.cbserialport = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.pbwebcam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpboxdatetime.SuspendLayout()
        Me.grpboxconnect.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltitle.Font = New System.Drawing.Font("Copperplate Gothic Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltitle.Location = New System.Drawing.Point(166, 29)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(679, 33)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "WVSU Accounting Anti-Burglary System"
        '
        'pbwebcam
        '
        Me.pbwebcam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbwebcam.Location = New System.Drawing.Point(44, 85)
        Me.pbwebcam.Name = "pbwebcam"
        Me.pbwebcam.Size = New System.Drawing.Size(734, 242)
        Me.pbwebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbwebcam.TabIndex = 1
        Me.pbwebcam.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnstopalarm)
        Me.GroupBox1.Controls.Add(Me.btntriggeralarm)
        Me.GroupBox1.Controls.Add(Me.btnrecord)
        Me.GroupBox1.Controls.Add(Me.btncapture)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(800, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 223)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manual Override Webcam"
        '
        'btnstopalarm
        '
        Me.btnstopalarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnstopalarm.Location = New System.Drawing.Point(36, 165)
        Me.btnstopalarm.Name = "btnstopalarm"
        Me.btnstopalarm.Size = New System.Drawing.Size(91, 23)
        Me.btnstopalarm.TabIndex = 3
        Me.btnstopalarm.Text = "Stop Alarm"
        Me.btnstopalarm.UseVisualStyleBackColor = True
        '
        'btntriggeralarm
        '
        Me.btntriggeralarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btntriggeralarm.Location = New System.Drawing.Point(37, 124)
        Me.btntriggeralarm.Name = "btntriggeralarm"
        Me.btntriggeralarm.Size = New System.Drawing.Size(91, 23)
        Me.btntriggeralarm.TabIndex = 2
        Me.btntriggeralarm.Text = "Trigger Alarm"
        Me.btntriggeralarm.UseVisualStyleBackColor = True
        '
        'btnrecord
        '
        Me.btnrecord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnrecord.Location = New System.Drawing.Point(37, 78)
        Me.btnrecord.Name = "btnrecord"
        Me.btnrecord.Size = New System.Drawing.Size(91, 23)
        Me.btnrecord.TabIndex = 1
        Me.btnrecord.Text = "Start Webcam"
        Me.btnrecord.UseVisualStyleBackColor = True
        '
        'btncapture
        '
        Me.btncapture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncapture.Location = New System.Drawing.Point(36, 40)
        Me.btncapture.Name = "btncapture"
        Me.btncapture.Size = New System.Drawing.Size(91, 23)
        Me.btncapture.TabIndex = 0
        Me.btncapture.Text = "Capture"
        Me.btncapture.UseVisualStyleBackColor = True
        '
        'grpboxdatetime
        '
        Me.grpboxdatetime.Controls.Add(Me.lbltime)
        Me.grpboxdatetime.Controls.Add(Me.lbldate)
        Me.grpboxdatetime.Controls.Add(Me.Label2)
        Me.grpboxdatetime.Controls.Add(Me.Label1)
        Me.grpboxdatetime.ForeColor = System.Drawing.Color.Lime
        Me.grpboxdatetime.Location = New System.Drawing.Point(44, 373)
        Me.grpboxdatetime.Name = "grpboxdatetime"
        Me.grpboxdatetime.Size = New System.Drawing.Size(390, 102)
        Me.grpboxdatetime.TabIndex = 3
        Me.grpboxdatetime.TabStop = False
        Me.grpboxdatetime.Text = "Date and Time"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbltime.Location = New System.Drawing.Point(58, 68)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(30, 13)
        Me.lbltime.TabIndex = 4
        Me.lbltime.Text = "Time"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbldate.Location = New System.Drawing.Point(58, 30)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(30, 13)
        Me.lbldate.TabIndex = 2
        Me.lbldate.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(19, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date:"
        '
        'timerdatetime
        '
        Me.timerdatetime.Enabled = True
        Me.timerdatetime.Interval = 1000
        '
        'timerwebcam
        '
        Me.timerwebcam.Enabled = True
        Me.timerwebcam.Interval = 50
        '
        'grpboxconnect
        '
        Me.grpboxconnect.Controls.Add(Me.btnDisconnect)
        Me.grpboxconnect.Controls.Add(Me.tbSerialMonitor)
        Me.grpboxconnect.Controls.Add(Me.btnExecute)
        Me.grpboxconnect.Controls.Add(Me.rtTypeCommand)
        Me.grpboxconnect.Controls.Add(Me.lblbaud)
        Me.grpboxconnect.Controls.Add(Me.lblport)
        Me.grpboxconnect.Controls.Add(Me.cbbaudrate)
        Me.grpboxconnect.Controls.Add(Me.cbserialport)
        Me.grpboxconnect.Controls.Add(Me.btnConnect)
        Me.grpboxconnect.ForeColor = System.Drawing.Color.Lime
        Me.grpboxconnect.Location = New System.Drawing.Point(455, 347)
        Me.grpboxconnect.Name = "grpboxconnect"
        Me.grpboxconnect.Size = New System.Drawing.Size(502, 159)
        Me.grpboxconnect.TabIndex = 4
        Me.grpboxconnect.TabStop = False
        Me.grpboxconnect.Text = "Device Connection"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDisconnect.Location = New System.Drawing.Point(98, 128)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(122, 23)
        Me.btnDisconnect.TabIndex = 8
        Me.btnDisconnect.Text = "Disconnect Device"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'tbSerialMonitor
        '
        Me.tbSerialMonitor.BackColor = System.Drawing.SystemColors.GrayText
        Me.tbSerialMonitor.Location = New System.Drawing.Point(293, 78)
        Me.tbSerialMonitor.Multiline = True
        Me.tbSerialMonitor.Name = "tbSerialMonitor"
        Me.tbSerialMonitor.Size = New System.Drawing.Size(155, 64)
        Me.tbSerialMonitor.TabIndex = 7
        '
        'btnExecute
        '
        Me.btnExecute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExecute.Location = New System.Drawing.Point(293, 45)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(155, 23)
        Me.btnExecute.TabIndex = 6
        Me.btnExecute.Text = "Execute Command"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'rtTypeCommand
        '
        Me.rtTypeCommand.Location = New System.Drawing.Point(293, 18)
        Me.rtTypeCommand.Name = "rtTypeCommand"
        Me.rtTypeCommand.Size = New System.Drawing.Size(155, 21)
        Me.rtTypeCommand.TabIndex = 5
        Me.rtTypeCommand.Text = "Type Your Command Here"
        '
        'lblbaud
        '
        Me.lblbaud.AutoSize = True
        Me.lblbaud.Location = New System.Drawing.Point(34, 62)
        Me.lblbaud.Name = "lblbaud"
        Me.lblbaud.Size = New System.Drawing.Size(61, 13)
        Me.lblbaud.TabIndex = 4
        Me.lblbaud.Text = "Baud Rate:"
        '
        'lblport
        '
        Me.lblport.AutoSize = True
        Me.lblport.Location = New System.Drawing.Point(34, 26)
        Me.lblport.Name = "lblport"
        Me.lblport.Size = New System.Drawing.Size(58, 13)
        Me.lblport.TabIndex = 3
        Me.lblport.Text = "Serial Port:"
        '
        'cbbaudrate
        '
        Me.cbbaudrate.FormattingEnabled = True
        Me.cbbaudrate.Items.AddRange(New Object() {"9600", "38400", "57600", "115200"})
        Me.cbbaudrate.Location = New System.Drawing.Point(98, 59)
        Me.cbbaudrate.Name = "cbbaudrate"
        Me.cbbaudrate.Size = New System.Drawing.Size(122, 21)
        Me.cbbaudrate.TabIndex = 2
        '
        'cbserialport
        '
        Me.cbserialport.FormattingEnabled = True
        Me.cbserialport.Location = New System.Drawing.Point(98, 23)
        Me.cbserialport.Name = "cbserialport"
        Me.cbserialport.Size = New System.Drawing.Size(122, 21)
        Me.cbserialport.TabIndex = 1
        '
        'btnConnect
        '
        Me.btnConnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnConnect.Location = New System.Drawing.Point(98, 94)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(122, 23)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect to Device"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'SerialPort
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(987, 518)
        Me.Controls.Add(Me.grpboxconnect)
        Me.Controls.Add(Me.grpboxdatetime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbwebcam)
        Me.Controls.Add(Me.lbltitle)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "WVSU Accounting Anti-Burglary System"
        CType(Me.pbwebcam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.grpboxdatetime.ResumeLayout(False)
        Me.grpboxdatetime.PerformLayout()
        Me.grpboxconnect.ResumeLayout(False)
        Me.grpboxconnect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents pbwebcam As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnstopalarm As System.Windows.Forms.Button
    Friend WithEvents btntriggeralarm As System.Windows.Forms.Button
    Friend WithEvents btnrecord As System.Windows.Forms.Button
    Friend WithEvents btncapture As System.Windows.Forms.Button
    Friend WithEvents grpboxdatetime As System.Windows.Forms.GroupBox
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timerdatetime As System.Windows.Forms.Timer
    Friend WithEvents timerwebcam As System.Windows.Forms.Timer
    Friend WithEvents grpboxconnect As System.Windows.Forms.GroupBox
    Friend WithEvents lblbaud As System.Windows.Forms.Label
    Friend WithEvents lblport As System.Windows.Forms.Label
    Friend WithEvents cbbaudrate As System.Windows.Forms.ComboBox
    Friend WithEvents cbserialport As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents tbSerialMonitor As System.Windows.Forms.TextBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents rtTypeCommand As System.Windows.Forms.RichTextBox
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort

End Class
