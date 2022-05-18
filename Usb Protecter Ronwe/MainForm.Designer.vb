'
' Creado por Ronwe en Sharpdevelop
' Fecha: 04/06/2012
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.panel1 = New System.Windows.Forms.Panel
		Me.label1 = New System.Windows.Forms.Label
		Me.panel2 = New System.Windows.Forms.Panel
		Me.button1 = New System.Windows.Forms.Button
		Me.button2 = New System.Windows.Forms.Button
		Me.button3 = New System.Windows.Forms.Button
		Me.button4 = New System.Windows.Forms.Button
		Me.panel1.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"),System.Drawing.Image)
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Location = New System.Drawing.Point(0, 1)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(658, 70)
		Me.panel1.TabIndex = 0
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.White
		Me.label1.Location = New System.Drawing.Point(92, 25)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(488, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Usb Protecter Ronwe V1.0 Modos para tu usb... "
		'
		'panel2
		'
		Me.panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.panel2.BackColor = System.Drawing.Color.White
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Location = New System.Drawing.Point(93, 77)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(558, 308)
		Me.panel2.TabIndex = 1
		'
		'button1
		'
		Me.button1.FlatAppearance.BorderSize = 0
		Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.ForeColor = System.Drawing.Color.White
		Me.button1.Image = CType(resources.GetObject("button1.Image"),System.Drawing.Image)
		Me.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.button1.Location = New System.Drawing.Point(3, 87)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(84, 64)
		Me.button1.TabIndex = 2
		Me.button1.Text = "&Home"
		Me.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.FlatAppearance.BorderSize = 0
		Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.ForeColor = System.Drawing.Color.White
		Me.button2.Image = CType(resources.GetObject("button2.Image"),System.Drawing.Image)
		Me.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.button2.Location = New System.Drawing.Point(2, 159)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(85, 74)
		Me.button2.TabIndex = 3
		Me.button2.Text = "Usb &Solo Lectura"
		Me.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button3
		'
		Me.button3.FlatAppearance.BorderSize = 0
		Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button3.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.ForeColor = System.Drawing.Color.White
		Me.button3.Image = CType(resources.GetObject("button3.Image"),System.Drawing.Image)
		Me.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.button3.Location = New System.Drawing.Point(2, 239)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(85, 65)
		Me.button3.TabIndex = 4
		Me.button3.Text = "Usb &Off"
		Me.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'button4
		'
		Me.button4.FlatAppearance.BorderSize = 0
		Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button4.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button4.ForeColor = System.Drawing.Color.White
		Me.button4.Image = CType(resources.GetObject("button4.Image"),System.Drawing.Image)
		Me.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.button4.Location = New System.Drawing.Point(3, 310)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(84, 75)
		Me.button4.TabIndex = 5
		Me.button4.Text = "&Acerca de.."
		Me.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'MainForm
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.ClientSize = New System.Drawing.Size(658, 397)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.MaximizeBox = false
		Me.MaximumSize = New System.Drawing.Size(674, 435)
		Me.MinimumSize = New System.Drawing.Size(674, 435)
		Me.Name = "MainForm"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Usb Protecter Ronwe V1.0"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.panel1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private label1 As System.Windows.Forms.Label
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	
	Sub Button4Click(sender As Object, e As EventArgs)
 Panel2.Controls.Clear()
        frmCreditos.TopLevel = False
        frmCreditos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmCreditos.Dock = DockStyle.Fill
        Panel2.Controls.Add(frmCreditos)
        frmCreditos.Show()
        frmHome.Close()
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		Panel2.Controls.Clear()
        frmHome.TopLevel = False
        frmHome.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmHome.Dock = DockStyle.Fill
        Panel2.Controls.Add(frmHome)
        frmHome.Show()
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		 Panel2.Controls.Clear()
        frmUsbOff.TopLevel = False
        frmUsbOff.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmUsbOff.Dock = DockStyle.Fill
        Panel2.Controls.Add(frmUsbOff)
        frmUsbOff.Show()
        frmHome.Close()
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
Dim readValue As String
        readValue = CStr(My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", Nothing))
        If CDbl(readValue) = 4 Then
        	Panel2.Controls.Clear()
        frmNoDisponible.TopLevel = False
        frmNoDisponible.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmNoDisponible.Dock = DockStyle.Fill
        Panel2.Controls.Add(frmNoDisponible)
        frmNoDisponible.Show()
        frmHome.Close()
       
        Else
     	Panel2.Controls.Clear()
        frmSoloLectura.TopLevel = False
        frmSoloLectura.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmSoloLectura.Dock = DockStyle.Fill
        Panel2.Controls.Add(frmSoloLectura)
        frmSoloLectura.Show()
        frmHome.Close()
        End If
	
	End Sub
End Class
