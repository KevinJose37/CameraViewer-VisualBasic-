Imports System
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports Ozeki.Camera
Imports Ozeki.Media
Imports Ozeki.VoIP

Partial Public Class MainForm
    Inherits Form
    Private _model As IpCameraHandler

    Private _myCameraUrlBuilder As CameraURLBuilderWF
    Private _snapshotHandler As SnapshotHandler

    Private _imageProvider As DrawingImageProvider
    Private _connector As MediaConnector
    Private _videoViewerWf As VideoViewerWF
    Private zoom As Zoom

    Public Sub New()
        InitializeComponent()
        _myCameraUrlBuilder = New CameraURLBuilderWF()
        _imageProvider = New DrawingImageProvider()
        _connector = New MediaConnector()
        _snapshotHandler = New SnapshotHandler()
        _videoViewerWf = New VideoViewerWF()
        zoom = New Zoom()


    End Sub



    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        _model.Stop()
    End Sub

    Private Sub ModelCameraStateChanged(sender As Object, e As CameraStateEventArgs)
        InvokeGuiThread(Sub()
                            AddMessageToLog("Camera state: " & e.State.ToString())

                            Select Case e.State
                            ' The list of streams become available at the Streaming state.
                                Case CameraState.Streaming
                                    button_Connect.Enabled = False

                                    videoViewerWF1.Start()
                                    ClearFields()
                                    'GetCameraStreams()

                                    button_Disconnect.Enabled = True

                                    If _model.Camera.UriType <> CameraUriType.RTSP Then
                                        'InitializeTrackBars()
                                    End If

                                Case CameraState.Disconnected
                                    button_Disconnect.Enabled = False
                                    videoViewerWF1.Stop()
                                    button_Connect.Enabled = True
                            End Select
                        End Sub)
    End Sub


    Private Sub ModelCameraErrorOccurred(sender As Object, e As CameraErrorEventArgs)
        InvokeGuiThread(Sub() AddMessageToLog("Camera error: " & If(e.Details, e.Error.ToString())))
    End Sub

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim link As New LinkLabel.Link With {.LinkData = "http://www.camera-sdk.com/"}

        If link.LinkData IsNot Nothing Then
            Process.Start(link.LinkData.ToString())
        End If
    End Sub

#Region "Connect - Disconnect"

    Private Sub button_Connect_Click_1(sender As Object, e As EventArgs) Handles button_Connect.Click
        ClearFields()
        ' ONVIF
        If tb_cameraUrl.Text.ToUpper().Trim().StartsWith("RTSP://") Then
            AddMessageToLog("Connecting to a stream of ONVIF device by RTSP")
        ElseIf tb_cameraUrl.Text.ToUpper().Trim().StartsWith("HTTP://") Then
            AddMessageToLog("Connecting to ONVIF device by HTTP")
        ElseIf tb_cameraUrl.Text.ToUpper().Trim().StartsWith("USB://") Then
            AddMessageToLog("Connecting to an USB device")
        End If
        ConnectIpCam()
    End Sub

    Private Sub button_Disconnect_Click_1(sender As Object, e As EventArgs)
        If _model.Camera IsNot Nothing Then
            _model.Disconnect()
        End If

        ClearFields()
    End Sub
    Private Sub button_Disconnect_Click(sender As Object, e As EventArgs) Handles button_Disconnect.Click
        If _model.Camera IsNot Nothing Then
            _model.Disconnect()
        End If

        ClearFields()
    End Sub
    Private Sub ConnectIpCam()
        _model.ConnectOnvifCamera(_myCameraUrlBuilder.CameraURL)
        videoViewerWF1.Start()
    End Sub

#End Region

#Region "LOG"

    Private Sub AddMessageToLog(message As String)
        ' Asegúrate de que la actualización de la interfaz de usuario se haga en el hilo correcto
        If InvokeRequired Then
            Invoke(Sub() AddMessageToLog(message))
        Else
            logListBox.Items.Add(message)
            ' Opcional: desplazar automáticamente al último mensaje
            logListBox.SelectedIndex = logListBox.Items.Count - 1
            logListBox.SelectedIndex = -1
        End If
    End Sub


#End Region

    Private Sub ClearFields()
        InvokeGuiThread(Sub()
                            'StreamCombo.Items.Clear()
                            'AudioInfoText.Clear()
                            'VideoInfoText.Clear()
                            'DetailsText.Clear()
                            'StreamCombo.Text = String.Empty
                        End Sub)
    End Sub


    Private Sub InvokeGuiThread(action As Action)
        BeginInvoke(action)
    End Sub

    Private Sub Flip(sender As Object, e As EventArgs)
        Dim flippedX As Boolean = HorizontalFlipCheck.Checked
        Dim flippedY As Boolean = VerticalFlipCheck.Checked

        If flippedX AndAlso flippedY Then
            videoViewerWF1.FlipMode = FlipMode.FlipXY
            Return
        End If

        If flippedX Then
            videoViewerWF1.FlipMode = FlipMode.FlipX
            Return
        End If

        If flippedY Then
            videoViewerWF1.FlipMode = FlipMode.FlipY
            Return
        End If

        videoViewerWF1.FlipMode = FlipMode.None
    End Sub

    Private Sub MouseDownMove(sender As Object, e As MouseEventArgs)
        Dim button As Button = TryCast(sender, Button)
        If button IsNot Nothing Then _model.Move(button.Text)
    End Sub

    Private Sub MouseUpMove(sender As Object, e As MouseEventArgs)
        If _model.Camera Is Nothing Then Return
        _model.Camera.CameraMovement.StopMovement()
    End Sub

    Private Sub button_Home_Click(sender As Object, e As EventArgs)
        If _model.Camera Is Nothing Then Return
        _model.Camera.CameraMovement.GoToHome()
    End Sub

    Private Sub button_SetHome_Click(sender As Object, e As EventArgs)
        If _model.Camera Is Nothing Then Return
        _model.Camera.CameraMovement.SetHome()
    End Sub


    Private Sub button_ScanStop_Click(sender As Object, e As EventArgs)
        If _model.Camera Is Nothing Then Return
        _model.Camera.CameraMovement.StopMovement()
    End Sub

    Private Sub btn_compose_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = _myCameraUrlBuilder.ShowDialog()

        If result <> DialogResult.OK Then Return

        tb_cameraUrl.Text = _myCameraUrlBuilder.CameraURL

        button_Connect.Enabled = True
    End Sub

    Private Sub btn_compose_Click_1(sender As Object, e As EventArgs) Handles btn_compose.Click
        Dim result As DialogResult = _myCameraUrlBuilder.ShowDialog()

        If result <> DialogResult.OK Then Return

        tb_cameraUrl.Text = _myCameraUrlBuilder.CameraURL

        button_Connect.Enabled = True
    End Sub

    Private Sub MainForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        _model = New IpCameraHandler()
        AddHandler _model.CameraStateChanged, AddressOf ModelCameraStateChanged
        AddHandler _model.CameraErrorOccurred, AddressOf ModelCameraErrorOccurred

        _myCameraUrlBuilder = New CameraURLBuilderWF()


        videoViewerWF1.SetImageProvider(_model.ImageProvider)

    End Sub

    Private Sub HorizontalFlipCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HorizontalFlipCheck.CheckedChanged
        Flip(sender, e)
    End Sub

    Private Sub VerticalFlipCheck_CheckedChanged(sender As Object, e As EventArgs) Handles VerticalFlipCheck.CheckedChanged
        Flip(sender, e)
    End Sub

    Private Sub button_SaveTo1_Click(sender As Object, e As EventArgs) Handles button_SaveTo1.Click
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()
        If result = DialogResult.OK Then
            textBox_SaveTo.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub button_CaptureVideo1Start_Click(sender As Object, e As EventArgs) Handles button_CaptureVideo1Start.Click
        Dim Path As String

        Path = textBox_SaveTo.Text
        _model.StartVideoCapture(Path)
        RecordingStatus.Text = "Recording now..."


    End Sub

    Private Sub button_CaptureVideo1Stop_Click(sender As Object, e As EventArgs) Handles button_CaptureVideo1Stop.Click
        _model.StopVideoCapture()
        RecordingStatus.Text = ""
    End Sub
    Private Sub GuiThread(action As Action)
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(Sub() action()))
        Else
            action()
        End If
    End Sub
    Private Sub GetUsbCameras()
        Dim usbList = WebCameraFactory.GetDevices()
        For Each device In usbList
            GuiThread(Sub() DiscoveredDeviceList.Items.Add("[USB] Name: " & device.Name))
        Next
    End Sub

    Private Sub GetIpCameras()
        AddHandler IPCameraFactory.DeviceDiscovered, AddressOf IPCameraFactory_DeviceDiscovered
        IPCameraFactory.DiscoverDevices()
    End Sub

    Private Sub IPCameraFactory_DeviceDiscovered(sender As Object, e As DiscoveryEventArgs)
        GuiThread(Sub() DiscoveredDeviceList.Items.Add("[IPCamera] Host: " & e.Device.Host & " Port: " & e.Device.Port))
    End Sub

    Private Sub DiscoverButton_Click(sender As Object, e As EventArgs) Handles DiscoverButton.Click
        DiscoveredDeviceList.Items.Clear()
        RemoveHandler IPCameraFactory.DeviceDiscovered, AddressOf IPCameraFactory_DeviceDiscovered

        GetUsbCameras()
        GetIpCameras()
    End Sub

    Private Sub button_ZoomIn_Click(sender As Object, e As EventArgs) Handles button_ZoomIn.Click
        Zoom.In()
    End Sub

    Private Sub button_ZoomOut_Click(sender As Object, e As EventArgs) Handles button_ZoomOut.Click
        zoom.Out()
    End Sub
End Class
