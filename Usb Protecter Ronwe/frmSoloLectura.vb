'
' Creado por Ronwe en Sharpdevelop
' Fecha: 04/06/2012
'
Imports Microsoft.Win32
Public Partial Class frmSoloLectura
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnActivarClick(sender As Object, e As EventArgs)
		
		    If MsgBox("Retire cualquier dispositivo usb de almacenamiento, ya sea disco duros, pendrive, celulares antes de proseguir. Luego seleccione si", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ProgressBar1.Value = 0
            tmr1.Enabled = True
       	    End If
       
	End Sub
	
	Sub BtnDesactivarClick(sender As Object, e As EventArgs)
		
		If MsgBox("Retire cualquier dispositivo usb de almacenamiento, ya sea disco duros, pendrive, celulares antes de proseguir. Luego seleccione si", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ProgressBar1.Value = 0
            tmr2.Enabled = True
        End If
		
	End Sub
	
	Sub Tmr1Tick(sender As Object, e As EventArgs)
			      Label1.Text = CStr(ProgressBar1.Value) + "%"
        If ProgressBar1.Value = 100 Then
            Label1.Text = "100%"
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorageDevicePolicies", _
       "WriteProtect", "00000001", RegistryValueKind.DWord)
            tmr1.Enabled = False
            btnDesactivar.Enabled = True
            btnActivar.Enabled = False
            lblestado2.Text = "ACTIVADO"
            MsgBox("Cambios Completados. Modo Usb Solo Lectura Activado.")
        Else
        	If progressbar1.Value=1 Then
        		label4.text="Recopilando información del sistema"
        	End If
        	If progressbar1.Value=10 Then
        		label4.text="Recopilando información del sistema."
        	End If
        	If progressbar1.Value=14 Then
        		label4.text="Recopilando información del sistema.."
        	End If
        	If progressbar1.Value=20 Then
        		label4.text="Recopilando información del sistema..."
        	End If
        	If progressbar1.Value=25 Then
        		label4.text="Aplicando cambios en el sistema"
        	End If
        	If progressbar1.Value=32 Then
        		label4.text="Aplicando cambios en el sistema."
        	End If
        	If progressbar1.Value=41 Then
        		label4.text="Aplicando cambios en el sistema.."
        	End If
        	If progressbar1.Value=45 Then
        		label4.text="Aplicando cambios en el sistema..."
        	End If
        	If progressbar1.Value=50 Then
        		label4.text="Actualizando registros"
        	End If
        	If progressbar1.Value=59 Then
        		label4.text="Actualizando registros."
        	End If
        	If progressbar1.Value=65 Then
        		label4.text="Actualizando registros.."
        	End If
        	If progressbar1.Value=70 Then
        		label4.text="Actualizando registros..."
        	End If
        	If progressbar1.Value=75 Then
        		label4.text="Guardando los cambios aplicados"
        	End If
        	If progressbar1.Value=82 Then
        		label4.text="Guardando los cambios aplicados."
        	End If
        	If progressbar1.Value=89 Then
        		label4.text="Guardando los cambios aplicados.."
        	End If
        	If progressbar1.Value=97 Then
        		label4.text="Guardando los cambios aplicados..."
        	End If
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
	End Sub
	
	Sub Tmr2Tick(sender As Object, e As EventArgs)
		     Label1.Text = CStr(ProgressBar1.Value) + "%"
        If ProgressBar1.Value = 100 Then
            Label1.Text = "100%"
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorageDevicePolicies", _
            "WriteProtect", "00000000", RegistryValueKind.DWord)
            tmr2.Enabled = False
            btnDesactivar.Enabled = False
            btnActivar.Enabled = True
            lblestado2.Text = "DESACTIVADO"
            MsgBox("Cambios Completados. Modo Usb Solo Lectura Desactivado.")
        Else
        	If progressbar1.Value=1 Then
        		label4.text="Recopilando información del sistema"
        	End If
        	If progressbar1.Value=9 Then
        		label4.text="Recopilando información del sistema."
        	End If
        	If progressbar1.Value=11 Then
        		label4.text="Recopilando información del sistema.."
        	End If
        	If progressbar1.Value=20 Then
        		label4.text="Recopilando información del sistema..."
        	End If
        	If progressbar1.Value=25 Then
        		label4.text="Revirtiendo cambios aplicados anteriormente"
        	End If
        	If progressbar1.Value=32 Then
        		label4.text="Revirtiendo cambios aplicados anteriormente."
        	End If
        	If progressbar1.Value=40 Then
        		label4.text="Revirtiendo cambios aplicados anteriormente.."
        	End If
        	If progressbar1.Value=45 Then
        		label4.text="Revirtiendo cambios aplicados anteriormente..."
        	End If
        	If progressbar1.Value=50 Then
        		label4.text="Actualizando registros"
        	End If
        	If progressbar1.Value=58 Then
        		label4.text="Actualizando registros."
        	End If
        	If progressbar1.Value=62 Then
        		label4.text="Actualizando registros.."
        	End If
        	If progressbar1.Value=71 Then
        		label4.text="Actualizando registros..."
        	End If
        	If progressbar1.Value=75 Then
        		label4.text="Guardando los cambios aplicados"
        	End If
        	If progressbar1.Value=82 Then
        		label4.text="Guardando los cambios aplicados."
        	End If
        	If progressbar1.Value=90Then
        		label4.text="Guardando los cambios aplicados.."
        	End If
        	If progressbar1.Value=95 Then
        		label4.text="Guardando los cambios aplicados..."
        	End If
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
	End Sub
	
	Sub FrmSoloLecturaLoad(sender As Object, e As EventArgs)
		  Dim readValue As String
        readValue = CStr(My.Computer.Registry.GetValue _
        ("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorageDevicePolicies", "WriteProtect", Nothing))
        If CDbl(readValue) = 1 Then
            btnDesactivar.Enabled = True
            btnActivar.Enabled = False
            lblestado2.Text = "ACTIVADO"
        Else
              btnDesactivar.Enabled = False
            btnActivar.Enabled = True
            lblestado2.Text = "DESACTIVADO"
        End If
	End Sub

End Class
