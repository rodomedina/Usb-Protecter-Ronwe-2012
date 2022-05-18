'
' Creado por Ronwe en Sharpdevelop
' Fecha: 04/06/2012
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		     Panel2.Controls.Clear()
        frmHome.TopLevel = False
        frmHome.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmHome.Dock = DockStyle.Fill
        Panel2.Controls.Add(frmHome)
        frmHome.Show()
	End Sub
End Class
