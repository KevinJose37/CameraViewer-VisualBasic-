<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.button_Connect = New System.Windows.Forms.Button()
        Me.button_Disconnect = New System.Windows.Forms.Button()
        Me.tb_cameraUrl = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_compose = New System.Windows.Forms.Button()
        Me.CameraBox = New System.Windows.Forms.GroupBox()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.videoViewerWF1 = New Ozeki.Media.VideoViewerWF()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.logListBox = New System.Windows.Forms.ListBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PTZTab = New System.Windows.Forms.TabPage()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.VerticalFlipCheck = New System.Windows.Forms.CheckBox()
        Me.HorizontalFlipCheck = New System.Windows.Forms.CheckBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.button_ZoomOut = New System.Windows.Forms.Button()
        Me.button_ZoomIn = New System.Windows.Forms.Button()
        Me.groupBox12 = New System.Windows.Forms.GroupBox()
        Me.button_DownRight = New System.Windows.Forms.Button()
        Me.button_Right = New System.Windows.Forms.Button()
        Me.button_UpRight = New System.Windows.Forms.Button()
        Me.button_Down = New System.Windows.Forms.Button()
        Me.button_Home = New System.Windows.Forms.Button()
        Me.button_DownLeft = New System.Windows.Forms.Button()
        Me.button_Left = New System.Windows.Forms.Button()
        Me.button_Up = New System.Windows.Forms.Button()
        Me.button_UpLeft = New System.Windows.Forms.Button()
        Me.button_CaptureVideo1Stop = New System.Windows.Forms.Button()
        Me.textBox_SaveTo = New System.Windows.Forms.TextBox()
        Me.button_SaveTo1 = New System.Windows.Forms.Button()
        Me.button_CaptureVideo1Start = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.RecordingStatus = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DiscoverButton = New System.Windows.Forms.Button()
        Me.DiscoveredDeviceList = New System.Windows.Forms.ListBox()
        Me.groupBox1.SuspendLayout()
        Me.CameraBox.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.PTZTab.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox12.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.button_Connect)
        Me.groupBox1.Controls.Add(Me.button_Disconnect)
        Me.groupBox1.Controls.Add(Me.tb_cameraUrl)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.btn_compose)
        Me.groupBox1.Location = New System.Drawing.Point(6, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(450, 86)
        Me.groupBox1.TabIndex = 53
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Connect"
        '
        'button_Connect
        '
        Me.button_Connect.Enabled = False
        Me.button_Connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_Connect.ForeColor = System.Drawing.Color.Black
        Me.button_Connect.Location = New System.Drawing.Point(147, 43)
        Me.button_Connect.Name = "button_Connect"
        Me.button_Connect.Size = New System.Drawing.Size(80, 23)
        Me.button_Connect.TabIndex = 18
        Me.button_Connect.Text = "Connect"
        Me.button_Connect.UseVisualStyleBackColor = True
        '
        'button_Disconnect
        '
        Me.button_Disconnect.Enabled = False
        Me.button_Disconnect.Location = New System.Drawing.Point(233, 43)
        Me.button_Disconnect.Name = "button_Disconnect"
        Me.button_Disconnect.Size = New System.Drawing.Size(75, 23)
        Me.button_Disconnect.TabIndex = 22
        Me.button_Disconnect.Text = "Disconnect"
        Me.button_Disconnect.UseVisualStyleBackColor = True
        '
        'tb_cameraUrl
        '
        Me.tb_cameraUrl.Location = New System.Drawing.Point(83, 17)
        Me.tb_cameraUrl.Name = "tb_cameraUrl"
        Me.tb_cameraUrl.ReadOnly = True
        Me.tb_cameraUrl.Size = New System.Drawing.Size(280, 20)
        Me.tb_cameraUrl.TabIndex = 21
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 13)
        Me.label1.TabIndex = 20
        Me.label1.Text = "Camera URL:"
        '
        'btn_compose
        '
        Me.btn_compose.Location = New System.Drawing.Point(369, 15)
        Me.btn_compose.Name = "btn_compose"
        Me.btn_compose.Size = New System.Drawing.Size(75, 23)
        Me.btn_compose.TabIndex = 19
        Me.btn_compose.Text = "Compose"
        Me.btn_compose.UseVisualStyleBackColor = True
        '
        'CameraBox
        '
        Me.CameraBox.Controls.Add(Me.stateLabel)
        Me.CameraBox.Controls.Add(Me.videoViewerWF1)
        Me.CameraBox.Location = New System.Drawing.Point(6, 104)
        Me.CameraBox.Name = "CameraBox"
        Me.CameraBox.Size = New System.Drawing.Size(450, 360)
        Me.CameraBox.TabIndex = 47
        Me.CameraBox.TabStop = False
        Me.CameraBox.Text = "Live camera "
        '
        'stateLabel
        '
        Me.stateLabel.AutoSize = True
        Me.stateLabel.Location = New System.Drawing.Point(4, 341)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(0, 13)
        Me.stateLabel.TabIndex = 1
        '
        'videoViewerWF1
        '
        Me.videoViewerWF1.BackColor = System.Drawing.Color.Black
        Me.videoViewerWF1.ContextMenuEnabled = True
        Me.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None
        Me.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform
        Me.videoViewerWF1.FullScreenEnabled = True
        Me.videoViewerWF1.Location = New System.Drawing.Point(7, 20)
        Me.videoViewerWF1.Name = "videoViewerWF1"
        Me.videoViewerWF1.RotateAngle = 0
        Me.videoViewerWF1.Size = New System.Drawing.Size(437, 320)
        Me.videoViewerWF1.TabIndex = 0
        Me.videoViewerWF1.Text = "videoViewerWF1"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.logListBox)
        Me.groupBox3.Location = New System.Drawing.Point(6, 470)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(450, 156)
        Me.groupBox3.TabIndex = 46
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Event log"
        '
        'logListBox
        '
        Me.logListBox.FormattingEnabled = True
        Me.logListBox.HorizontalScrollbar = True
        Me.logListBox.Location = New System.Drawing.Point(6, 19)
        Me.logListBox.Name = "logListBox"
        Me.logListBox.Size = New System.Drawing.Size(438, 134)
        Me.logListBox.TabIndex = 0
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.PTZTab)
        Me.TabControl.Location = New System.Drawing.Point(462, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(253, 283)
        Me.TabControl.TabIndex = 54
        '
        'PTZTab
        '
        Me.PTZTab.Controls.Add(Me.groupBox6)
        Me.PTZTab.Controls.Add(Me.groupBox4)
        Me.PTZTab.Controls.Add(Me.groupBox12)
        Me.PTZTab.Location = New System.Drawing.Point(4, 22)
        Me.PTZTab.Name = "PTZTab"
        Me.PTZTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PTZTab.Size = New System.Drawing.Size(245, 257)
        Me.PTZTab.TabIndex = 3
        Me.PTZTab.Text = "Camera control"
        Me.PTZTab.UseVisualStyleBackColor = True
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.VerticalFlipCheck)
        Me.groupBox6.Controls.Add(Me.HorizontalFlipCheck)
        Me.groupBox6.Location = New System.Drawing.Point(6, 189)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(226, 54)
        Me.groupBox6.TabIndex = 7
        Me.groupBox6.TabStop = False
        Me.groupBox6.Text = "Flip"
        '
        'VerticalFlipCheck
        '
        Me.VerticalFlipCheck.Appearance = System.Windows.Forms.Appearance.Button
        Me.VerticalFlipCheck.AutoSize = True
        Me.VerticalFlipCheck.Location = New System.Drawing.Point(142, 19)
        Me.VerticalFlipCheck.Name = "VerticalFlipCheck"
        Me.VerticalFlipCheck.Size = New System.Drawing.Size(52, 23)
        Me.VerticalFlipCheck.TabIndex = 12
        Me.VerticalFlipCheck.Text = "Vertical"
        Me.VerticalFlipCheck.UseVisualStyleBackColor = True
        '
        'HorizontalFlipCheck
        '
        Me.HorizontalFlipCheck.Appearance = System.Windows.Forms.Appearance.Button
        Me.HorizontalFlipCheck.AutoSize = True
        Me.HorizontalFlipCheck.Location = New System.Drawing.Point(28, 19)
        Me.HorizontalFlipCheck.Name = "HorizontalFlipCheck"
        Me.HorizontalFlipCheck.Size = New System.Drawing.Size(64, 23)
        Me.HorizontalFlipCheck.TabIndex = 11
        Me.HorizontalFlipCheck.Text = "Horizontal"
        Me.HorizontalFlipCheck.UseVisualStyleBackColor = True
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.button_ZoomOut)
        Me.groupBox4.Controls.Add(Me.button_ZoomIn)
        Me.groupBox4.Location = New System.Drawing.Point(175, 6)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(57, 177)
        Me.groupBox4.TabIndex = 5
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Zoom"
        '
        'button_ZoomOut
        '
        Me.button_ZoomOut.Location = New System.Drawing.Point(7, 122)
        Me.button_ZoomOut.Name = "button_ZoomOut"
        Me.button_ZoomOut.Size = New System.Drawing.Size(45, 45)
        Me.button_ZoomOut.TabIndex = 1
        Me.button_ZoomOut.Text = "Out"
        Me.button_ZoomOut.UseVisualStyleBackColor = True
        '
        'button_ZoomIn
        '
        Me.button_ZoomIn.Location = New System.Drawing.Point(7, 20)
        Me.button_ZoomIn.Name = "button_ZoomIn"
        Me.button_ZoomIn.Size = New System.Drawing.Size(45, 45)
        Me.button_ZoomIn.TabIndex = 0
        Me.button_ZoomIn.Text = "In"
        Me.button_ZoomIn.UseVisualStyleBackColor = True
        '
        'groupBox12
        '
        Me.groupBox12.Controls.Add(Me.button_DownRight)
        Me.groupBox12.Controls.Add(Me.button_Right)
        Me.groupBox12.Controls.Add(Me.button_UpRight)
        Me.groupBox12.Controls.Add(Me.button_Down)
        Me.groupBox12.Controls.Add(Me.button_Home)
        Me.groupBox12.Controls.Add(Me.button_DownLeft)
        Me.groupBox12.Controls.Add(Me.button_Left)
        Me.groupBox12.Controls.Add(Me.button_Up)
        Me.groupBox12.Controls.Add(Me.button_UpLeft)
        Me.groupBox12.Location = New System.Drawing.Point(6, 6)
        Me.groupBox12.Name = "groupBox12"
        Me.groupBox12.Size = New System.Drawing.Size(162, 177)
        Me.groupBox12.TabIndex = 4
        Me.groupBox12.TabStop = False
        Me.groupBox12.Text = "Control"
        '
        'button_DownRight
        '
        Me.button_DownRight.Location = New System.Drawing.Point(109, 122)
        Me.button_DownRight.Name = "button_DownRight"
        Me.button_DownRight.Size = New System.Drawing.Size(45, 45)
        Me.button_DownRight.TabIndex = 8
        Me.button_DownRight.Text = "Down Right"
        Me.button_DownRight.UseVisualStyleBackColor = True
        '
        'button_Right
        '
        Me.button_Right.Location = New System.Drawing.Point(109, 71)
        Me.button_Right.Name = "button_Right"
        Me.button_Right.Size = New System.Drawing.Size(45, 45)
        Me.button_Right.TabIndex = 7
        Me.button_Right.Text = "Right"
        Me.button_Right.UseVisualStyleBackColor = True
        '
        'button_UpRight
        '
        Me.button_UpRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_UpRight.Location = New System.Drawing.Point(109, 20)
        Me.button_UpRight.Name = "button_UpRight"
        Me.button_UpRight.Size = New System.Drawing.Size(45, 45)
        Me.button_UpRight.TabIndex = 6
        Me.button_UpRight.Text = "Up Right"
        Me.button_UpRight.UseVisualStyleBackColor = True
        '
        'button_Down
        '
        Me.button_Down.Location = New System.Drawing.Point(58, 122)
        Me.button_Down.Name = "button_Down"
        Me.button_Down.Size = New System.Drawing.Size(45, 45)
        Me.button_Down.TabIndex = 5
        Me.button_Down.Text = "Down"
        Me.button_Down.UseVisualStyleBackColor = True
        '
        'button_Home
        '
        Me.button_Home.Location = New System.Drawing.Point(58, 71)
        Me.button_Home.Name = "button_Home"
        Me.button_Home.Size = New System.Drawing.Size(45, 45)
        Me.button_Home.TabIndex = 4
        Me.button_Home.Text = "Home"
        Me.button_Home.UseVisualStyleBackColor = True
        '
        'button_DownLeft
        '
        Me.button_DownLeft.Location = New System.Drawing.Point(7, 122)
        Me.button_DownLeft.Name = "button_DownLeft"
        Me.button_DownLeft.Size = New System.Drawing.Size(45, 45)
        Me.button_DownLeft.TabIndex = 3
        Me.button_DownLeft.Text = "Down Left"
        Me.button_DownLeft.UseVisualStyleBackColor = True
        '
        'button_Left
        '
        Me.button_Left.Location = New System.Drawing.Point(6, 71)
        Me.button_Left.Name = "button_Left"
        Me.button_Left.Size = New System.Drawing.Size(45, 45)
        Me.button_Left.TabIndex = 2
        Me.button_Left.Text = "Left"
        Me.button_Left.UseVisualStyleBackColor = True
        '
        'button_Up
        '
        Me.button_Up.Location = New System.Drawing.Point(58, 20)
        Me.button_Up.Name = "button_Up"
        Me.button_Up.Size = New System.Drawing.Size(45, 45)
        Me.button_Up.TabIndex = 1
        Me.button_Up.Text = "Up"
        Me.button_Up.UseVisualStyleBackColor = True
        '
        'button_UpLeft
        '
        Me.button_UpLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_UpLeft.Location = New System.Drawing.Point(7, 20)
        Me.button_UpLeft.Name = "button_UpLeft"
        Me.button_UpLeft.Size = New System.Drawing.Size(45, 45)
        Me.button_UpLeft.TabIndex = 0
        Me.button_UpLeft.Text = "Up Left"
        Me.button_UpLeft.UseVisualStyleBackColor = True
        '
        'button_CaptureVideo1Stop
        '
        Me.button_CaptureVideo1Stop.Location = New System.Drawing.Point(161, 19)
        Me.button_CaptureVideo1Stop.Name = "button_CaptureVideo1Stop"
        Me.button_CaptureVideo1Stop.Size = New System.Drawing.Size(75, 40)
        Me.button_CaptureVideo1Stop.TabIndex = 36
        Me.button_CaptureVideo1Stop.Text = "Stop recording"
        Me.button_CaptureVideo1Stop.UseVisualStyleBackColor = True
        '
        'textBox_SaveTo
        '
        Me.textBox_SaveTo.Location = New System.Drawing.Point(87, 83)
        Me.textBox_SaveTo.Name = "textBox_SaveTo"
        Me.textBox_SaveTo.Size = New System.Drawing.Size(144, 20)
        Me.textBox_SaveTo.TabIndex = 35
        '
        'button_SaveTo1
        '
        Me.button_SaveTo1.Location = New System.Drawing.Point(6, 81)
        Me.button_SaveTo1.Name = "button_SaveTo1"
        Me.button_SaveTo1.Size = New System.Drawing.Size(75, 23)
        Me.button_SaveTo1.TabIndex = 34
        Me.button_SaveTo1.Text = "Save to:"
        Me.button_SaveTo1.UseVisualStyleBackColor = True
        '
        'button_CaptureVideo1Start
        '
        Me.button_CaptureVideo1Start.Location = New System.Drawing.Point(10, 19)
        Me.button_CaptureVideo1Start.Name = "button_CaptureVideo1Start"
        Me.button_CaptureVideo1Start.Size = New System.Drawing.Size(75, 40)
        Me.button_CaptureVideo1Start.TabIndex = 33
        Me.button_CaptureVideo1Start.Text = "Start recording"
        Me.button_CaptureVideo1Start.UseVisualStyleBackColor = True
        '
        'RecordingStatus
        '
        Me.RecordingStatus.AutoSize = True
        Me.RecordingStatus.Location = New System.Drawing.Point(462, 399)
        Me.RecordingStatus.Name = "RecordingStatus"
        Me.RecordingStatus.Size = New System.Drawing.Size(0, 13)
        Me.RecordingStatus.TabIndex = 55
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.button_CaptureVideo1Start)
        Me.GroupBox2.Controls.Add(Me.button_CaptureVideo1Stop)
        Me.GroupBox2.Controls.Add(Me.button_SaveTo1)
        Me.GroupBox2.Controls.Add(Me.textBox_SaveTo)
        Me.GroupBox2.Location = New System.Drawing.Point(462, 301)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 114)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recording section"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DiscoverButton)
        Me.GroupBox5.Controls.Add(Me.DiscoveredDeviceList)
        Me.GroupBox5.Location = New System.Drawing.Point(462, 422)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(260, 204)
        Me.GroupBox5.TabIndex = 57
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Discovery Dispositives"
        '
        'DiscoverButton
        '
        Me.DiscoverButton.Location = New System.Drawing.Point(89, 19)
        Me.DiscoverButton.Name = "DiscoverButton"
        Me.DiscoverButton.Size = New System.Drawing.Size(75, 23)
        Me.DiscoverButton.TabIndex = 1
        Me.DiscoverButton.Text = "Discover"
        Me.DiscoverButton.UseVisualStyleBackColor = True
        '
        'DiscoveredDeviceList
        '
        Me.DiscoveredDeviceList.FormattingEnabled = True
        Me.DiscoveredDeviceList.Location = New System.Drawing.Point(5, 51)
        Me.DiscoveredDeviceList.Name = "DiscoveredDeviceList"
        Me.DiscoveredDeviceList.Size = New System.Drawing.Size(249, 147)
        Me.DiscoveredDeviceList.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 638)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RecordingStatus)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.CameraBox)
        Me.Controls.Add(Me.groupBox3)
        Me.Name = "MainForm"
        Me.Text = "SecurityCameras"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.CameraBox.ResumeLayout(False)
        Me.CameraBox.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.PTZTab.ResumeLayout(False)
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox6.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox12.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents button_Connect As Button
    Private WithEvents button_Disconnect As Button
    Private WithEvents tb_cameraUrl As TextBox
    Private WithEvents label1 As Label
    Private WithEvents btn_compose As Button
    Private WithEvents CameraBox As GroupBox
    Private WithEvents stateLabel As Label
    Private WithEvents videoViewerWF1 As Ozeki.Media.VideoViewerWF
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents logListBox As ListBox
    Private WithEvents TabControl As TabControl
    Private WithEvents PTZTab As TabPage
    Private WithEvents groupBox4 As GroupBox
    Private WithEvents button_ZoomOut As Button
    Private WithEvents button_ZoomIn As Button
    Private WithEvents groupBox12 As GroupBox
    Private WithEvents button_DownRight As Button
    Private WithEvents button_Right As Button
    Private WithEvents button_UpRight As Button
    Private WithEvents button_Down As Button
    Private WithEvents button_Home As Button
    Private WithEvents button_DownLeft As Button
    Private WithEvents button_Left As Button
    Private WithEvents button_Up As Button
    Private WithEvents button_UpLeft As Button
    Private WithEvents groupBox6 As GroupBox
    Private WithEvents VerticalFlipCheck As CheckBox
    Private WithEvents HorizontalFlipCheck As CheckBox
    Private WithEvents button_CaptureVideo1Stop As Button
    Private WithEvents textBox_SaveTo As TextBox
    Private WithEvents button_SaveTo1 As Button
    Private WithEvents button_CaptureVideo1Start As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents RecordingStatus As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DiscoveredDeviceList As ListBox
    Friend WithEvents DiscoverButton As Button
End Class
