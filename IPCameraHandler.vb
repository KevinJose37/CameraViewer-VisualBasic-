Imports System
Imports System.Text
Imports Ozeki.Camera
Imports Ozeki.Media
Imports Ozeki.VoIP
Imports System.Drawing
Class IpCameraHandler
    Private Connector As MediaConnector

    Public Property Camera As OzekiCamera
    Public Property ImageProvider As DrawingImageProvider
    Public Property Snapshot As SnapshotHandler

    Private _mpeg4Recorder As MPEG4Recorder

    Public Event CameraStateChanged As EventHandler(Of CameraStateEventArgs)
    Public Event CameraErrorOccurred As EventHandler(Of CameraErrorEventArgs)

    Public Sub New()
        ImageProvider = New DrawingImageProvider()
        Snapshot = New SnapshotHandler()
        Connector = New MediaConnector()

    End Sub

    Public Sub ConnectOnvifCamera(cameraUrl As String)
        If Camera IsNot Nothing Then
            CloseCamera()
        End If

        ' Obtener la cámara, que se puede alcanzar por la dirección y requiere autenticación.
        Camera = New OzekiCamera(cameraUrl)


        If Camera Is Nothing Then
            Return
        End If

        Connector.Connect(Camera.VideoChannel, ImageProvider)
        Connector.Connect(Camera.VideoChannel, Snapshot)


        AddHandler Camera.CameraStateChanged, AddressOf Camera_CameraStateChanged
        AddHandler Camera.CameraErrorOccurred, AddressOf Camera_CameraErrorOccurred
        _Camera.Start()
        Camera.Start()
    End Sub

    Private Sub Camera_CameraErrorOccurred(sender As Object, e As CameraErrorEventArgs)
        ' Notificar a la GUI
        RaiseEvent CameraErrorOccurred(Me, e)
    End Sub

    Private Sub Camera_CameraStateChanged(sender As Object, e As CameraStateEventArgs)
        ' Notificar a la GUI
        RaiseEvent CameraStateChanged(Me, e)
    End Sub


    Public Sub Disconnect()
        CloseCamera()
    End Sub

    Private Sub CloseCamera()
        If Camera Is Nothing Then
            Return
        End If

        Connector.Disconnect(Camera.VideoChannel, ImageProvider)
        Connector.Disconnect(Camera.VideoChannel, Snapshot)
        Camera.Disconnect()
        RemoveHandler Camera.CameraStateChanged, AddressOf Camera_CameraStateChanged
        RemoveHandler Camera.CameraErrorOccurred, AddressOf Camera_CameraErrorOccurred
        Camera = Nothing
    End Sub

    Public Sub [Stop]()
        If Camera IsNot Nothing Then
            StopVideoCapture()
            CloseCamera()
            Connector.Dispose()
            ImageProvider.Dispose()
            Snapshot.Dispose()
        End If
    End Sub



    Public Sub Move(direction As String)
        If Camera Is Nothing Then
            Return
        End If

        Select Case direction
            Case "Up Left"
                Camera.CameraMovement.ContinuousMove(MoveDirection.LeftUp)
            Case "Up"
                Camera.CameraMovement.ContinuousMove(MoveDirection.Up)
            Case "Up Right"
                Camera.CameraMovement.ContinuousMove(MoveDirection.RightUp)
            Case "Left"
                Camera.CameraMovement.ContinuousMove(MoveDirection.Left)
            Case "Right"
                Camera.CameraMovement.ContinuousMove(MoveDirection.Right)
            Case "Down Left"
                Camera.CameraMovement.ContinuousMove(MoveDirection.LeftDown)
            Case "Down"
                Camera.CameraMovement.ContinuousMove(MoveDirection.Down)
            Case "Down Right"
                Camera.CameraMovement.ContinuousMove(MoveDirection.RightDown)
            Case "Set home"
                Camera.CameraMovement.SetHome()
            Case "In"
                Camera.CameraMovement.Zoom(MoveDirection.In)
            Case "Out"
                Camera.CameraMovement.Zoom(MoveDirection.Out)
        End Select
    End Sub



    Public Sub StartVideoCapture(path As String)
        If Camera Is Nothing Then
            Return
        End If

        Dim dateStr = DateTime.Now.Year & "y-" & DateTime.Now.Month & "m-" & DateTime.Now.Day & "d-" &
                      DateTime.Now.Hour & "h-" & DateTime.Now.Minute & "m-" & DateTime.Now.Second & "s"

        Dim currentPath As String
        If String.IsNullOrEmpty(path) Then
            currentPath = AppDomain.CurrentDomain.BaseDirectory & dateStr & ".mp4"
        Else
            currentPath = path & "\" & dateStr & ".mp4"
        End If

        _mpeg4Recorder = New MPEG4Recorder(currentPath)
        AddHandler _mpeg4Recorder.MultiplexFinished, AddressOf Mpeg4Recorder_MultiplexFinished

        Connector.Connect(Camera.AudioChannel, _mpeg4Recorder.AudioRecorder)
        Connector.Connect(Camera.VideoChannel, _mpeg4Recorder.VideoRecorder)

        System.Diagnostics.Debug.WriteLine("Video capture has been started")
        System.Diagnostics.Debug.WriteLine("The captured video will be saved: " & currentPath)
    End Sub

    Private Sub Mpeg4Recorder_MultiplexFinished(sender As Object, e As VoIPEventArgs(Of Boolean))
        Dim recorder = TryCast(sender, MPEG4Recorder)
        If recorder Is Nothing Then
            Return
        End If

        Connector.Disconnect(Camera.AudioChannel, recorder.AudioRecorder)
        Connector.Disconnect(Camera.VideoChannel, recorder.VideoRecorder)

        recorder.Dispose()

        System.Diagnostics.Debug.WriteLine("The captured video has been saved")
    End Sub

    Public Sub StopVideoCapture()
        If Camera Is Nothing OrElse _mpeg4Recorder Is Nothing Then
            Return
        End If

        _mpeg4Recorder.Multiplex()

        Connector.Disconnect(Camera.AudioChannel, _mpeg4Recorder.AudioRecorder)
        Connector.Disconnect(Camera.VideoChannel, _mpeg4Recorder.VideoRecorder)

        System.Diagnostics.Debug.WriteLine("Video capture has been stopped")
    End Sub
End Class

