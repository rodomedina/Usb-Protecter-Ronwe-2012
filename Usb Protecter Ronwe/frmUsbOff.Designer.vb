'
' Creado por Ronwe en Sharpdevelop
' Fecha: 04/06/2012
'
Partial Class frmUsbOff
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
		Me.components = New System.ComponentModel.Container
		Me.btnDesactivar = New System.Windows.Forms.Button
		Me.GroupBox4 = New System.Windows.Forms.GroupBox
		Me.GroupBox3 = New System.Windows.Forms.GroupBox
		Me.label5 = New System.Windows.Forms.Label
		Me.label7 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
		Me.btnActivar = New System.Windows.Forms.Button
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.TextBox2 = New System.Windows.Forms.TextBox
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
		Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
		Me.GroupBox3.SuspendLayout
		Me.GroupBox1.SuspendLayout
		Me.SuspendLayout
		'
		'btnDesactivar
		'
		Me.btnDesactivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.btnDesactivar.FlatAppearance.BorderSize = 0
		Me.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDesactivar.Font = New System.Drawing.Font("Lucida Sans", 9!, System.Drawing.FontStyle.Bold)
		Me.btnDesactivar.ForeColor = System.Drawing.Color.Red
		Me.btnDesactivar.Location = New System.Drawing.Point(444, 267)
		Me.btnDesactivar.Name = "btnDesactivar"
		Me.btnDesactivar.Size = New System.Drawing.Size(92, 20)
		Me.btnDesactivar.TabIndex = 20
		Me.btnDesactivar.Text = "Desactivar"
		Me.btnDesactivar.UseVisualStyleBackColor = true
		AddHandler Me.btnDesactivar.Click, AddressOf Me.BtnDesactivarClick
		'
		'GroupBox4
		'
		Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox4.Location = New System.Drawing.Point(2, 95)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(534, 16)
		Me.GroupBox4.TabIndex = 24
		Me.GroupBox4.TabStop = false
		'
		'GroupBox3
		'
		Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox3.Controls.Add(Me.label5)
		Me.GroupBox3.Controls.Add(Me.label7)
		Me.GroupBox3.Controls.Add(Me.Label4)
		Me.GroupBox3.Controls.Add(Me.Label2)
		Me.GroupBox3.Controls.Add(Me.Label1)
		Me.GroupBox3.Controls.Add(Me.ProgressBar1)
		Me.GroupBox3.Location = New System.Drawing.Point(3, -3)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(533, 95)
		Me.GroupBox3.TabIndex = 23
		Me.GroupBox3.TabStop = false
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(8, 15)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(54, 12)
		Me.label5.TabIndex = 13
		Me.label5.Text = "Estado:"
		'
		'label7
		'
		Me.label7.AutoSize = true
		Me.label7.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.ForeColor = System.Drawing.Color.DarkGray
		Me.label7.Location = New System.Drawing.Point(61, 16)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(0, 12)
		Me.label7.TabIndex = 14
		'
		'Label4
		'
		Me.Label4.AutoSize = true
		Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Green
		Me.Label4.Location = New System.Drawing.Point(72, 64)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(84, 12)
		Me.Label4.TabIndex = 12
		Me.Label4.Text = "Sin acciones."
		'
		'Label2
		'
		Me.Label2.AutoSize = true
		Me.Label2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label2.Location = New System.Drawing.Point(6, 64)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(75, 12)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "Progreso: "
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = true
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(506, 39)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(21, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "0%"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.ProgressBar1.Location = New System.Drawing.Point(8, 39)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(492, 13)
		Me.ProgressBar1.TabIndex = 8
		'
		'btnActivar
		'
		Me.btnActivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.btnActivar.FlatAppearance.BorderSize = 0
		Me.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnActivar.Font = New System.Drawing.Font("Lucida Sans", 9!, System.Drawing.FontStyle.Bold)
		Me.btnActivar.ForeColor = System.Drawing.Color.Red
		Me.btnActivar.Location = New System.Drawing.Point(3, 267)
		Me.btnActivar.Name = "btnActivar"
		Me.btnActivar.Size = New System.Drawing.Size(81, 20)
		Me.btnActivar.TabIndex = 19
		Me.btnActivar.Text = "Activar"
		Me.btnActivar.UseVisualStyleBackColor = true
		AddHandler Me.btnActivar.Click, AddressOf Me.BtnActivarClick
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Location = New System.Drawing.Point(3, 110)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(533, 151)
		Me.GroupBox1.TabIndex = 21
		Me.GroupBox1.TabStop = false
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.White
		Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox2.Font = New System.Drawing.Font("Lucida Sans", 8.25!)
		Me.TextBox2.Location = New System.Drawing.Point(8, 104)
		Me.TextBox2.Multiline = true
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = true
		Me.TextBox2.Size = New System.Drawing.Size(485, 33)
		Me.TextBox2.TabIndex = 0
		Me.TextBox2.TabStop = false
		Me.TextBox2.Text = "Desactivar Este modo, volverá a la habilitación de la lectura de unidades de alma"& _ 
		"cenamiento usb como lo tenia antes."
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.White
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.TextBox1.Location = New System.Drawing.Point(8, 34)
		Me.TextBox1.Multiline = true
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = true
		Me.TextBox1.Size = New System.Drawing.Size(485, 38)
		Me.TextBox1.TabIndex = 0
		Me.TextBox1.TabStop = false
		Me.TextBox1.Text = "Activando el modo USB Off Conseguira que su PC no detecte ningun dispositivo de a"& _ 
		"lmacenamiento usb en su maquina."
		'
		'Label6
		'
		Me.Label6.AutoSize = true
		Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Green
		Me.Label6.Location = New System.Drawing.Point(8, 84)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(207, 12)
		Me.Label6.TabIndex = 14
		Me.Label6.Text = "Desactivar Modo Usb Puertos Off"
		'
		'Label3
		'
		Me.Label3.AutoSize = true
		Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Green
		Me.Label3.Location = New System.Drawing.Point(9, 16)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(185, 12)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Activar Modo Usb Puertos Off"
		'
		'tmr1
		'
		AddHandler Me.tmr1.Tick, AddressOf Me.Tmr1Tick
		'
		'tmr2
		'
		AddHandler Me.tmr2.Tick, AddressOf Me.Tmr2Tick
		'
		'frmUsbOff
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(542, 299)
		Me.Controls.Add(Me.btnDesactivar)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.btnActivar)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmUsbOff"
		Me.ShowIcon = false
		AddHandler Load, AddressOf Me.FrmUsbOffLoad
		Me.GroupBox3.ResumeLayout(false)
		Me.GroupBox3.PerformLayout
		Me.GroupBox1.ResumeLayout(false)
		Me.GroupBox1.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Friend label7 As System.Windows.Forms.Label
	Friend label5 As System.Windows.Forms.Label
	Private tmr2 As System.Windows.Forms.Timer
	Private tmr1 As System.Windows.Forms.Timer
	Friend Label3 As System.Windows.Forms.Label
	Friend Label6 As System.Windows.Forms.Label
	Friend TextBox1 As System.Windows.Forms.TextBox
	Friend TextBox2 As System.Windows.Forms.TextBox
	Friend GroupBox1 As System.Windows.Forms.GroupBox
	Friend btnActivar As System.Windows.Forms.Button
	Friend ProgressBar1 As System.Windows.Forms.ProgressBar
	Friend Label1 As System.Windows.Forms.Label
	Friend Label2 As System.Windows.Forms.Label
	Friend Label4 As System.Windows.Forms.Label
	Friend GroupBox3 As System.Windows.Forms.GroupBox
	Friend GroupBox4 As System.Windows.Forms.GroupBox
	Friend btnDesactivar As System.Windows.Forms.Button
End Class
