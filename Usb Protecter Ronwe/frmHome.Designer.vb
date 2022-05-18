'
' Creado por Ronwe en Sharpdevelop
' Fecha: 04/06/2012
'
Partial Class frmhome
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhome))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.GroupBox6 = New System.Windows.Forms.GroupBox
		Me.GroupBox4 = New System.Windows.Forms.GroupBox
		Me.GroupBox8 = New System.Windows.Forms.GroupBox
		Me.lblUsboff = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.GroupBox5 = New System.Windows.Forms.GroupBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.lbllectura = New System.Windows.Forms.Label
		Me.GroupBox3 = New System.Windows.Forms.GroupBox
		Me.TextBox2 = New System.Windows.Forms.TextBox
		Me.PictureBox1 = New System.Windows.Forms.PictureBox
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.groupBox7 = New System.Windows.Forms.GroupBox
		Me.GroupBox1.SuspendLayout
		Me.GroupBox4.SuspendLayout
		Me.GroupBox8.SuspendLayout
		Me.GroupBox5.SuspendLayout
		Me.GroupBox3.SuspendLayout
		CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.groupBox7)
		Me.GroupBox1.Controls.Add(Me.GroupBox6)
		Me.GroupBox1.Controls.Add(Me.GroupBox4)
		Me.GroupBox1.Controls.Add(Me.GroupBox3)
		Me.GroupBox1.Controls.Add(Me.GroupBox2)
		Me.GroupBox1.Location = New System.Drawing.Point(7, 1)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(523, 286)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = false
		'
		'GroupBox6
		'
		Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox6.Location = New System.Drawing.Point(7, 138)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(510, 16)
		Me.GroupBox6.TabIndex = 1
		Me.GroupBox6.TabStop = false
		'
		'GroupBox4
		'
		Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox4.Controls.Add(Me.GroupBox8)
		Me.GroupBox4.Controls.Add(Me.GroupBox5)
		Me.GroupBox4.Location = New System.Drawing.Point(7, 158)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(510, 93)
		Me.GroupBox4.TabIndex = 2
		Me.GroupBox4.TabStop = false
		Me.GroupBox4.Text = "Estado de los servicios"
		'
		'GroupBox8
		'
		Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox8.Controls.Add(Me.lblUsboff)
		Me.GroupBox8.Controls.Add(Me.Label2)
		Me.GroupBox8.Location = New System.Drawing.Point(7, 49)
		Me.GroupBox8.Name = "GroupBox8"
		Me.GroupBox8.Size = New System.Drawing.Size(497, 30)
		Me.GroupBox8.TabIndex = 3
		Me.GroupBox8.TabStop = false
		'
		'lblUsboff
		'
		Me.lblUsboff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.lblUsboff.AutoSize = true
		Me.lblUsboff.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblUsboff.ForeColor = System.Drawing.Color.Red
		Me.lblUsboff.Location = New System.Drawing.Point(393, 12)
		Me.lblUsboff.Name = "lblUsboff"
		Me.lblUsboff.Size = New System.Drawing.Size(94, 12)
		Me.lblUsboff.TabIndex = 3
		Me.lblUsboff.Text = "No Disponible."
		'
		'Label2
		'
		Me.Label2.AutoSize = true
		Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label2.Location = New System.Drawing.Point(7, 12)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Usb Off :"
		'
		'GroupBox5
		'
		Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox5.Controls.Add(Me.Label1)
		Me.GroupBox5.Controls.Add(Me.lbllectura)
		Me.GroupBox5.Location = New System.Drawing.Point(7, 19)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(497, 30)
		Me.GroupBox5.TabIndex = 0
		Me.GroupBox5.TabStop = false
		'
		'Label1
		'
		Me.Label1.AutoSize = true
		Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label1.Location = New System.Drawing.Point(6, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(122, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Usb Solo Lectura:"
		'
		'lbllectura
		'
		Me.lbllectura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.lbllectura.AutoSize = true
		Me.lbllectura.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbllectura.ForeColor = System.Drawing.Color.Red
		Me.lbllectura.Location = New System.Drawing.Point(394, 12)
		Me.lbllectura.Name = "lbllectura"
		Me.lbllectura.Size = New System.Drawing.Size(94, 12)
		Me.lbllectura.TabIndex = 2
		Me.lbllectura.Text = "No Disponible."
		'
		'GroupBox3
		'
		Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox3.Controls.Add(Me.TextBox2)
		Me.GroupBox3.Controls.Add(Me.PictureBox1)
		Me.GroupBox3.Controls.Add(Me.TextBox1)
		Me.GroupBox3.Location = New System.Drawing.Point(7, 38)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(510, 96)
		Me.GroupBox3.TabIndex = 0
		Me.GroupBox3.TabStop = false
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.White
		Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.TextBox2.Location = New System.Drawing.Point(65, 34)
		Me.TextBox2.Multiline = true
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = true
		Me.TextBox2.Size = New System.Drawing.Size(415, 42)
		Me.TextBox2.TabIndex = 0
		Me.TextBox2.TabStop = false
		Me.TextBox2.Text = "Con este Software podra bloquear y desbloquear puertos usb y ademas tambien podra"& _ 
		" cuidar de que una maquina infectada de virus contagie su pendrive."
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(14, 34)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(45, 48)
		Me.PictureBox1.TabIndex = 3
		Me.PictureBox1.TabStop = false
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.White
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.TextBox1.ForeColor = System.Drawing.Color.Green
		Me.TextBox1.Location = New System.Drawing.Point(6, 12)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = true
		Me.TextBox1.Size = New System.Drawing.Size(289, 16)
		Me.TextBox1.TabIndex = 0
		Me.TextBox1.TabStop = false
		Me.TextBox1.Text = "Bienvenidos a Usb Protecter Ronwe V1.0"
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Location = New System.Drawing.Point(7, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(510, 23)
		Me.GroupBox2.TabIndex = 0
		Me.GroupBox2.TabStop = false
		'
		'groupBox7
		'
		Me.groupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox7.Location = New System.Drawing.Point(7, 255)
		Me.groupBox7.Name = "groupBox7"
		Me.groupBox7.Size = New System.Drawing.Size(510, 23)
		Me.groupBox7.TabIndex = 1
		Me.groupBox7.TabStop = false
		'
		'frmhome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(542, 299)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmhome"
		Me.ShowIcon = false
		AddHandler Load, AddressOf Me.FrmhomeLoad
		Me.GroupBox1.ResumeLayout(false)
		Me.GroupBox4.ResumeLayout(false)
		Me.GroupBox8.ResumeLayout(false)
		Me.GroupBox8.PerformLayout
		Me.GroupBox5.ResumeLayout(false)
		Me.GroupBox5.PerformLayout
		Me.GroupBox3.ResumeLayout(false)
		Me.GroupBox3.PerformLayout
		CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Friend groupBox7 As System.Windows.Forms.GroupBox
	Friend GroupBox2 As System.Windows.Forms.GroupBox
	Friend TextBox1 As System.Windows.Forms.TextBox
	Friend PictureBox1 As System.Windows.Forms.PictureBox
	Friend TextBox2 As System.Windows.Forms.TextBox
	Friend GroupBox3 As System.Windows.Forms.GroupBox
	Friend lbllectura As System.Windows.Forms.Label
	Friend Label1 As System.Windows.Forms.Label
	Friend GroupBox5 As System.Windows.Forms.GroupBox
	Friend Label2 As System.Windows.Forms.Label
	Friend lblUsboff As System.Windows.Forms.Label
	Friend GroupBox8 As System.Windows.Forms.GroupBox
	Friend GroupBox4 As System.Windows.Forms.GroupBox
	Friend GroupBox6 As System.Windows.Forms.GroupBox
	Friend GroupBox1 As System.Windows.Forms.GroupBox
	
	Sub FrmhomeLoad(sender As Object, e As EventArgs)
		        Dim leo As String
        leo = CStr(My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorageDevicePolicies", "WriteProtect", Nothing))
        If CDbl(leo) = 0 Then

            lbllectura.Text = "DESACTIVADO."
        Else

            lbllectura.Text = "ACTIVADO."
        End If

        Dim leo2 As String
        leo2 = CStr(My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", Nothing))
        If CDbl(leo2) = 3 Then
            lblUsboff.Text = "DESACTIVADO."
        Else
            lblUsboff.Text = "ACTIVADO."
        End If
    End Sub
	
End Class
