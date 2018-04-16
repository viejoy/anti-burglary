Imports Emgu.CV
Imports Emgu.CV.UI
Imports Emgu.CV.Structure
Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Diagnostics
Public Class Form1
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)

    Dim myvariablecapture As New Capture

   


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerwebcam.Start()
        myPort = IO.Ports.SerialPort.GetPortNames()
        cbserialport.Items.AddRange(CType(myPort, Object()))




    End Sub


    Private Sub btncapture_Cllick(sender As Object, e As EventArgs) Handles btncapture.Click
        timerwebcam.Stop()
    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles timerdatetime.Tick
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
        lbldate.Text = Date.Now.ToString("dd-MM-yyy")

    End Sub

    Private Sub btnrecord_Click(sender As Object, e As EventArgs) Handles btnrecord.Click
        timerwebcam.Start()
    End Sub

    Private Sub timerwebcam_Tick(sender As Object, e As EventArgs) Handles timerwebcam.Tick
        pbwebcam.Image = myvariablecapture.QueryFrame.ToBitmap
    End Sub

    Private Sub btntriggeralarm_Click(sender As Object, e As EventArgs) Handles btntriggeralarm.Click
        My.Computer.Audio.Play("C:\Users\User\Documents\Albastro and Mesina - BSCS 3A\WVSU Acounting Anti-Burglary System\Fire_Alarm.wav")
        timerwebcam.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        SerialPort.PortName = cbserialport.Text
        SerialPort.BaudRate = CInt(cbbaudrate.Text)
        SerialPort.Open()
    End Sub

    Private Sub cbserialport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbserialport.SelectedIndexChanged

    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        SerialPort.Write(rtTypeCommand.Text & vbCr)

    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        ReceivedText(SerialPort.ReadExisting())
    End Sub
    Private Sub ReceivedText(ByVal [text] As String)
        If Me.tbSerialMonitor.InvokeRequired Then
            Dim y As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(y, New Object() {(text)})
        Else
            Me.tbSerialMonitor.Text &= text
            Me.tbSerialMonitor.AppendText(text)

        End If


    End Sub


    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        SerialPort.Close()
    End Sub



    Private Sub btnstopalarm_Click(sender As Object, e As EventArgs) Handles btnstopalarm.Click
        My.Computer.Audio.Stop()
    End Sub

    
    Private Sub tbSerialMonitor_TextChanged(sender As Object, e As EventArgs) Handles tbSerialMonitor.TextChanged
        My.Computer.Audio.Play("C:\Users\User\Documents\Albastro and Mesina - BSCS 3A\WVSU Acounting Anti-Burglary SystemFire_Alarm.wav")
        timerwebcam.Stop()
    End Sub

   
End Class
