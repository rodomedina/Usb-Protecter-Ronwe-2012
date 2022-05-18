'
' Creado por Ronwe en Sharpdevelop
' Fecha: 04/06/2012
'
Partial Class frmNoDisponible
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
		Me.groupBox1 = New System.Windows.Forms.GroupBox
		Me.groupBox2 = New System.Windows.Forms.GroupBox
		Me.groupBox3 = New System.Windows.Forms.GroupBox
		Me.groupBox5 = New System.Windows.Forms.GroupBox
		Me.groupBox6 = New System.Windows.Forms.GroupBox
		Me.groupBox7 = New System.Windows.Forms.GroupBox
		Me.textBox2 = New System.Windows.Forms.TextBox
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.groupBox1.SuspendLayout
		Me.groupBox7.SuspendLayout
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox1.Controls.Add(Me.groupBox5)
		Me.groupBox1.Controls.Add(Me.groupBox6)
		Me.groupBox1.Controls.Add(Me.groupBox7)
		Me.groupBox1.Controls.Add(Me.groupBox3)
		Me.groupBox1.Controls.Add(Me.groupBox2)
		Me.groupBox1.Location = New System.Drawing.Point(2, -1)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(536, 299)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		'
		'groupBox2
		'
		Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox2.Location = New System.Drawing.Point(6, 268)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(524, 20)
		Me.groupBox2.TabIndex = 19
		Me.groupBox2.TabStop = false
		'
		'groupBox3
		'
		Me.groupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox3.Location = New System.Drawing.Point(6, 242)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(524, 20)
		Me.groupBox3.TabIndex = 20
		Me.groupBox3.TabStop = false
		'
		'groupBox5
		'
		Me.groupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox5.Location = New System.Drawing.Point(4, 13)
		Me.groupBox5.Name = "groupBox5"
		Me.groupBox5.Size = New System.Drawing.Size(524, 20)
		Me.groupBox5.TabIndex = 22
		Me.groupBox5.TabStop = false
		'
		'groupBox6
		'
		Me.groupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox6.Location = New System.Drawing.Point(4, 39)
		Me.groupBox6.Name = "groupBox6"
		Me.groupBox6.Size = New System.Drawing.Size(524, 20)
		Me.groupBox6.TabIndex = 23
		Me.groupBox6.TabStop = false
		'
		'groupBox7
		'
		Me.groupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.groupBox7.Controls.Add(Me.textBox2)
		Me.groupBox7.Controls.Add(Me.TextBox1)
		Me.groupBox7.Controls.Add(Me.Label6)
		Me.groupBox7.Location = New System.Drawing.Point(4, 65)
		Me.groupBox7.Name = "groupBox7"
		Me.groupBox7.Size = New System.Drawing.Size(524, 171)
		Me.groupBox7.TabIndex = 21
		Me.groupBox7.TabStop = false
		'
		'textBox2
		'
		Me.textBox2.BackColor = System.Drawing.Color.White
		Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBox2.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
		Me.textBox2.Location = New System.Drawing.Point(3, 111)
		Me.textBox2.Multiline = true
		Me.textBox2.Name = "textBox2"
		Me.textBox2.ReadOnly = true
		Me.textBox2.Size = New System.Drawing.Size(518, 29)
		Me.textBox2.TabIndex = 21
		Me.textBox2.TabStop = false
		Me.textBox2.Text = "Si desea utilizar este modo, desactive el modo Usb Off y vuelva a intentarlo."
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.White
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
		Me.TextBox1.Location = New System.Drawing.Point(3, 66)
		Me.TextBox1.Multiline = true
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = true
		Me.TextBox1.Size = New System.Drawing.Size(518, 54)
		Me.TextBox1.TabIndex = 20
		Me.TextBox1.TabStop = false
		Me.TextBox1.Text = "Este modo queda bloqueado hasta que desactive el modo Usb Off, ya que no tiene se"& _ 
		"ntido el modo solo lectura si la maquina no puede reconocer los dispositivos de "& _ 
		"almacenamientos vía usb."
		'
		'Label6
		'
		Me.Label6.AutoSize = true
		Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Green
		Me.Label6.Location = New System.Drawing.Point(132, 30)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(264, 15)
		Me.Label6.TabIndex = 19
		Me.Label6.Text = "Modo Usb Solo Lectura No Disponible"
		'
		'frmNoDisponible
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(542, 299)
		Me.Controls.Add(Me.groupBox1)
		Me.Name = "frmNoDisponible"
		Me.ShowIcon = false
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox7.ResumeLayout(false)
		Me.groupBox7.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private groupBox7 As System.Windows.Forms.GroupBox
	Private groupBox6 As System.Windows.Forms.GroupBox
	Private groupBox5 As System.Windows.Forms.GroupBox
	Friend TextBox1 As System.Windows.Forms.TextBox
	Friend textBox2 As System.Windows.Forms.TextBox
	Friend Label6 As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
End Class
