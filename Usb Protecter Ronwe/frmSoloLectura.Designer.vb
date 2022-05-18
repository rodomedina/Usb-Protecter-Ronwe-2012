'
' Creado por Ronwe en Sharpdevelop
' Fecha: 04/06/2012
'
Partial Class frmSoloLectura
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoloLectura))
		Me.btnDesactivar = New System.Windows.Forms.Button
		Me.GroupBox3 = New System.Windows.Forms.GroupBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.lblEstado = New System.Windows.Forms.Label
		Me.lblestado2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
		Me.btnActivar = New System.Windows.Forms.Button
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.TextBox2 = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.TextBox1 = New System.Windows.Forms.TextBox
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
		Me.btnDesactivar.Location = New System.Drawing.Point(446, 267)
		Me.btnDesactivar.Name = "btnDesactivar"
		Me.btnDesactivar.Size = New System.Drawing.Size(92, 20)
		Me.btnDesactivar.TabIndex = 26
		Me.btnDesactivar.Text = "Desactivar"
		Me.btnDesactivar.UseVisualStyleBackColor = true
		AddHandler Me.btnDesactivar.Click, AddressOf Me.BtnDesactivarClick
		'
		'GroupBox3
		'
		Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox3.Controls.Add(Me.Label4)
		Me.GroupBox3.Controls.Add(Me.Label2)
		Me.GroupBox3.Controls.Add(Me.lblEstado)
		Me.GroupBox3.Controls.Add(Me.lblestado2)
		Me.GroupBox3.Controls.Add(Me.Label1)
		Me.GroupBox3.Controls.Add(Me.ProgressBar1)
		Me.GroupBox3.Location = New System.Drawing.Point(3, -3)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(533, 95)
		Me.GroupBox3.TabIndex = 28
		Me.GroupBox3.TabStop = false
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
		'lblEstado
		'
		Me.lblEstado.AutoSize = true
		Me.lblEstado.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblEstado.Location = New System.Drawing.Point(8, 15)
		Me.lblEstado.Name = "lblEstado"
		Me.lblEstado.Size = New System.Drawing.Size(54, 12)
		Me.lblEstado.TabIndex = 9
		Me.lblEstado.Text = "Estado:"
		'
		'lblestado2
		'
		Me.lblestado2.AutoSize = true
		Me.lblestado2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblestado2.ForeColor = System.Drawing.Color.DarkGray
		Me.lblestado2.Location = New System.Drawing.Point(61, 16)
		Me.lblestado2.Name = "lblestado2"
		Me.lblestado2.Size = New System.Drawing.Size(0, 12)
		Me.lblestado2.TabIndex = 10
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
		Me.btnActivar.Font = New System.Drawing.Font("Lucida Sans", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnActivar.ForeColor = System.Drawing.Color.Red
		Me.btnActivar.Location = New System.Drawing.Point(3, 267)
		Me.btnActivar.Name = "btnActivar"
		Me.btnActivar.Size = New System.Drawing.Size(81, 20)
		Me.btnActivar.TabIndex = 25
		Me.btnActivar.Text = "Activar"
		Me.btnActivar.UseVisualStyleBackColor = true
		AddHandler Me.btnActivar.Click, AddressOf Me.BtnActivarClick
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Location = New System.Drawing.Point(3, 95)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(535, 171)
		Me.GroupBox1.TabIndex = 27
		Me.GroupBox1.TabStop = false
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.White
		Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox2.Font = New System.Drawing.Font("Lucida Sans", 8.25!)
		Me.TextBox2.Location = New System.Drawing.Point(7, 137)
		Me.TextBox2.Multiline = true
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = true
		Me.TextBox2.Size = New System.Drawing.Size(513, 18)
		Me.TextBox2.TabIndex = 16
		Me.TextBox2.TabStop = false
		Me.TextBox2.Text = "Deja la lectura de usb tal como estaba antes de aplicar el programa."
		'
		'Label6
		'
		Me.Label6.AutoSize = true
		Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Green
		Me.Label6.Location = New System.Drawing.Point(8, 117)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(215, 12)
		Me.Label6.TabIndex = 15
		Me.Label6.Text = "Desactivar Modo Usb Solo Lectura"
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.White
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.TextBox1.Location = New System.Drawing.Point(6, 34)
		Me.TextBox1.Multiline = true
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = true
		Me.TextBox1.Size = New System.Drawing.Size(514, 76)
		Me.TextBox1.TabIndex = 12
		Me.TextBox1.TabStop = false
		Me.TextBox1.Text = resources.GetString("TextBox1.Text")
		'
		'Label3
		'
		Me.Label3.AutoSize = true
		Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Green
		Me.Label3.Location = New System.Drawing.Point(8, 16)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(193, 12)
		Me.Label3.TabIndex = 13
		Me.Label3.Text = "Activar Modo Usb Solo Lectura"
		'
		'tmr1
		'
		AddHandler Me.tmr1.Tick, AddressOf Me.Tmr1Tick
		'
		'tmr2
		'
		AddHandler Me.tmr2.Tick, AddressOf Me.Tmr2Tick
		'
		'frmSoloLectura
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(542, 299)
		Me.Controls.Add(Me.btnDesactivar)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.btnActivar)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmSoloLectura"
		Me.ShowIcon = false
		AddHandler Load, AddressOf Me.FrmSoloLecturaLoad
		Me.GroupBox3.ResumeLayout(false)
		Me.GroupBox3.PerformLayout
		Me.GroupBox1.ResumeLayout(false)
		Me.GroupBox1.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private tmr2 As System.Windows.Forms.Timer
	Private tmr1 As System.Windows.Forms.Timer
	Friend Label3 As System.Windows.Forms.Label
	Friend TextBox1 As System.Windows.Forms.TextBox
	Friend Label6 As System.Windows.Forms.Label
	Friend TextBox2 As System.Windows.Forms.TextBox
	Friend GroupBox1 As System.Windows.Forms.GroupBox
	Friend btnActivar As System.Windows.Forms.Button
	Friend ProgressBar1 As System.Windows.Forms.ProgressBar
	Friend Label1 As System.Windows.Forms.Label
	Friend lblestado2 As System.Windows.Forms.Label
	Friend lblEstado As System.Windows.Forms.Label
	Friend Label2 As System.Windows.Forms.Label
	Friend Label4 As System.Windows.Forms.Label
	Friend GroupBox3 As System.Windows.Forms.GroupBox
	Friend btnDesactivar As System.Windows.Forms.Button
End Class
