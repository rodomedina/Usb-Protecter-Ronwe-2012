'
' Creado por Ronwe en Sharpdevelop
' Fecha: 04/06/2012
'
Partial Class frmCreditos
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditos))
		Me.groupBox1 = New System.Windows.Forms.GroupBox
		Me.pictureBox1 = New System.Windows.Forms.PictureBox
		Me.groupBox2 = New System.Windows.Forms.GroupBox
		Me.GroupBox7 = New System.Windows.Forms.GroupBox
		Me.groupBox8 = New System.Windows.Forms.GroupBox
		Me.groupBox6 = New System.Windows.Forms.GroupBox
		Me.groupBox5 = New System.Windows.Forms.GroupBox
		Me.groupBox3 = New System.Windows.Forms.GroupBox
		Me.textBox5 = New System.Windows.Forms.TextBox
		Me.TextBox4 = New System.Windows.Forms.TextBox
		Me.GroupBox4 = New System.Windows.Forms.GroupBox
		Me.textBox3 = New System.Windows.Forms.TextBox
		Me.TextBox2 = New System.Windows.Forms.TextBox
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.textBox6 = New System.Windows.Forms.TextBox
		Me.textBox7 = New System.Windows.Forms.TextBox
		Me.textBox8 = New System.Windows.Forms.TextBox
		Me.groupBox1.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.GroupBox7.SuspendLayout
		Me.GroupBox4.SuspendLayout
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox1.Controls.Add(Me.pictureBox1)
		Me.groupBox1.Controls.Add(Me.groupBox2)
		Me.groupBox1.Controls.Add(Me.GroupBox7)
		Me.groupBox1.Controls.Add(Me.GroupBox4)
		Me.groupBox1.Location = New System.Drawing.Point(1, -2)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(539, 299)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(11, 27)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(52, 54)
		Me.pictureBox1.TabIndex = 26
		Me.pictureBox1.TabStop = false
		'
		'groupBox2
		'
		Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox2.Location = New System.Drawing.Point(7, 95)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(526, 16)
		Me.groupBox2.TabIndex = 25
		Me.groupBox2.TabStop = false
		'
		'GroupBox7
		'
		Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox7.Controls.Add(Me.groupBox8)
		Me.GroupBox7.Controls.Add(Me.groupBox6)
		Me.GroupBox7.Controls.Add(Me.groupBox5)
		Me.GroupBox7.Controls.Add(Me.groupBox3)
		Me.GroupBox7.Controls.Add(Me.textBox5)
		Me.GroupBox7.Controls.Add(Me.TextBox4)
		Me.GroupBox7.Location = New System.Drawing.Point(5, 114)
		Me.GroupBox7.Name = "GroupBox7"
		Me.GroupBox7.Size = New System.Drawing.Size(529, 178)
		Me.GroupBox7.TabIndex = 24
		Me.GroupBox7.TabStop = false
		'
		'groupBox8
		'
		Me.groupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox8.Location = New System.Drawing.Point(9, 32)
		Me.groupBox8.Name = "groupBox8"
		Me.groupBox8.Size = New System.Drawing.Size(515, 16)
		Me.groupBox8.TabIndex = 28
		Me.groupBox8.TabStop = false
		'
		'groupBox6
		'
		Me.groupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox6.Location = New System.Drawing.Point(9, 134)
		Me.groupBox6.Name = "groupBox6"
		Me.groupBox6.Size = New System.Drawing.Size(515, 16)
		Me.groupBox6.TabIndex = 28
		Me.groupBox6.TabStop = false
		'
		'groupBox5
		'
		Me.groupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox5.Location = New System.Drawing.Point(9, 154)
		Me.groupBox5.Name = "groupBox5"
		Me.groupBox5.Size = New System.Drawing.Size(515, 16)
		Me.groupBox5.TabIndex = 27
		Me.groupBox5.TabStop = false
		'
		'groupBox3
		'
		Me.groupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox3.Location = New System.Drawing.Point(9, 13)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(515, 16)
		Me.groupBox3.TabIndex = 26
		Me.groupBox3.TabStop = false
		'
		'textBox5
		'
		Me.textBox5.BackColor = System.Drawing.Color.White
		Me.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBox5.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox5.ForeColor = System.Drawing.Color.Green
		Me.textBox5.Location = New System.Drawing.Point(6, 54)
		Me.textBox5.Multiline = true
		Me.textBox5.Name = "textBox5"
		Me.textBox5.ReadOnly = true
		Me.textBox5.Size = New System.Drawing.Size(492, 18)
		Me.textBox5.TabIndex = 1
		Me.textBox5.Text = "Usb Protecter Ronwe V1.0 es un programa gratuito "
		'
		'TextBox4
		'
		Me.TextBox4.BackColor = System.Drawing.Color.White
		Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox4.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.TextBox4.Location = New System.Drawing.Point(6, 78)
		Me.TextBox4.Multiline = true
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.ReadOnly = true
		Me.TextBox4.Size = New System.Drawing.Size(492, 50)
		Me.TextBox4.TabIndex = 0
		Me.TextBox4.Text = "Esta aplicación es creada con fines educativos. No me hago cargo del mal uso o pr"& _ 
		"oblemas que se puedan ocasionar, el usuario corre este programa bajo su propio r"& _ 
		"iesgo."
		'
		'GroupBox4
		'
		Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.GroupBox4.Controls.Add(Me.textBox8)
		Me.GroupBox4.Controls.Add(Me.textBox7)
		Me.GroupBox4.Controls.Add(Me.textBox6)
		Me.GroupBox4.Controls.Add(Me.textBox3)
		Me.GroupBox4.Controls.Add(Me.TextBox2)
		Me.GroupBox4.Controls.Add(Me.TextBox1)
		Me.GroupBox4.Location = New System.Drawing.Point(69, 12)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(465, 81)
		Me.GroupBox4.TabIndex = 22
		Me.GroupBox4.TabStop = false
		'
		'textBox3
		'
		Me.textBox3.BackColor = System.Drawing.Color.White
		Me.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBox3.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox3.Location = New System.Drawing.Point(6, 35)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.ReadOnly = true
		Me.textBox3.Size = New System.Drawing.Size(55, 18)
		Me.textBox3.TabIndex = 2
		Me.textBox3.Text = "Nick:"
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.White
		Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.TextBox2.Location = New System.Drawing.Point(6, 56)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = true
		Me.TextBox2.Size = New System.Drawing.Size(116, 18)
		Me.TextBox2.TabIndex = 1
		Me.TextBox2.Text = "Direccion Web:"
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.White
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.TextBox1.Location = New System.Drawing.Point(6, 15)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = true
		Me.TextBox1.Size = New System.Drawing.Size(55, 18)
		Me.TextBox1.TabIndex = 0
		Me.TextBox1.Text = "Autor:"
		'
		'textBox6
		'
		Me.textBox6.BackColor = System.Drawing.Color.White
		Me.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBox6.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
		Me.textBox6.ForeColor = System.Drawing.Color.Green
		Me.textBox6.Location = New System.Drawing.Point(58, 17)
		Me.textBox6.Name = "textBox6"
		Me.textBox6.ReadOnly = true
		Me.textBox6.Size = New System.Drawing.Size(159, 16)
		Me.textBox6.TabIndex = 3
		Me.textBox6.Text = "Medina, Rodolfo"
		'
		'textBox7
		'
		Me.textBox7.BackColor = System.Drawing.Color.White
		Me.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBox7.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
		Me.textBox7.ForeColor = System.Drawing.Color.Green
		Me.textBox7.Location = New System.Drawing.Point(48, 37)
		Me.textBox7.Name = "textBox7"
		Me.textBox7.ReadOnly = true
		Me.textBox7.Size = New System.Drawing.Size(159, 16)
		Me.textBox7.TabIndex = 4
		Me.textBox7.Text = "Ronwe"
		'
		'textBox8
		'
		Me.textBox8.BackColor = System.Drawing.Color.White
		Me.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBox8.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox8.ForeColor = System.Drawing.Color.Green
		Me.textBox8.Location = New System.Drawing.Point(128, 58)
		Me.textBox8.Name = "textBox8"
		Me.textBox8.ReadOnly = true
		Me.textBox8.Size = New System.Drawing.Size(323, 16)
		Me.textBox8.TabIndex = 5
		Me.textBox8.Text = "http://www.taringa.net/Ronwe"
		'
		'frmCreditos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(542, 299)
		Me.Controls.Add(Me.groupBox1)
		Me.Name = "frmCreditos"
		Me.ShowIcon = false
		Me.groupBox1.ResumeLayout(false)
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.GroupBox7.ResumeLayout(false)
		Me.GroupBox7.PerformLayout
		Me.GroupBox4.ResumeLayout(false)
		Me.GroupBox4.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Friend textBox6 As System.Windows.Forms.TextBox
	Friend textBox7 As System.Windows.Forms.TextBox
	Friend textBox8 As System.Windows.Forms.TextBox
	Friend textBox5 As System.Windows.Forms.TextBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private groupBox5 As System.Windows.Forms.GroupBox
	Private groupBox6 As System.Windows.Forms.GroupBox
	Private groupBox8 As System.Windows.Forms.GroupBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Friend textBox3 As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Friend TextBox1 As System.Windows.Forms.TextBox
	Friend TextBox2 As System.Windows.Forms.TextBox
	Friend GroupBox4 As System.Windows.Forms.GroupBox
	Friend TextBox4 As System.Windows.Forms.TextBox
	Friend GroupBox7 As System.Windows.Forms.GroupBox
End Class
