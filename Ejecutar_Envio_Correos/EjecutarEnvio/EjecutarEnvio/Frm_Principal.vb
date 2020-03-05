Public Class Frm_Principal
    Dim segundos As Integer = 0
    Dim minutos As Integer = 0
    Dim horas As Integer = 0
    Dim horaLimite As String
    Dim horaInicio As String
    Dim estadoSys = "Pausar"
    Dim estadoBorrarTodo As String = "SI"

    Private Sub Frm_Principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer_eliminar_temporal.Start()
        Timer_contar_segundos.Start()
        Timer_Envia_Correos.Start()
        iniciarenvio()
    End Sub

    Private Sub Timer_contar_segundos_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_contar_segundos.Tick
        segundos = segundos + 1

        If segundos > 59 Then
            minutos = minutos + 1
            segundos = 0
        End If

        If minutos > 59 Then
            horas = horas + 1
            minutos = 0
        End If

        lbltiempo.Text = Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00")
    End Sub

    Private Sub Timer_Envia_Correos_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Envia_Correos.Tick
        iniciarenvio()
    End Sub

    Private Sub iniciarenvio()
        'DESTRUIR PROCESOS DEL SISTEMA DE ENVIO DE EMAIL'
        Dim p As Process
        For Each p In Process.GetProcesses()
            If Not p Is Nothing And p.ProcessName.Trim.Contains("SistemaEnvioCorreos") Then
                p.Kill() 'Cierra el proceso
            End If
        Next
        Dim ruta_relativa As String = ""
        ruta_relativa = My.Computer.FileSystem.CurrentDirectory + "\Sistema de Envio de Correos\PreparacionDePedidos\bin\Debug\SistemaEnvioCorreos.exe"
        ruta_relativa = "C:\Users\Administrador.USUARIO-X578PNA\Desktop\Sistema de Envio de Correos\PreparacionDePedidos\bin\Debug\SistemaEnvioCorreos.exe"
        ruta_relativa = "C:\Users\WEBMASTER\Desktop\Sistema de Envio de Correos\PreparacionDePedidos\bin\Debug\SistemaEnvioCorreos.exe"
        System.Diagnostics.Process.Start(ruta_relativa)
    End Sub

    Private Sub Frm_Principal_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Minimized Then
            Hide()
        End If
    End Sub

    Private Sub Frm_Principal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        NotifyIcon1.Dispose()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Show()
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub pausa()
        If estadoSys = "Pausar" Then
            Dim resp = MessageBox.Show("¿Desea pausar el proceso de envío de correos?", "¿Está seguro?", MessageBoxButtons.YesNo)
            If (resp = MsgBoxResult.Yes) Then
                Timer_contar_segundos.Stop()
                Timer_Envia_Correos.Stop()
                estadoSys = "Reanudar"
                lblejec.Text = "Tiempo de ejecución (PAUSADO):"
            End If
        Else
            Timer_contar_segundos.Start()
            Timer_Envia_Correos.Start()
            estadoSys = "Pausar"
            lblejec.Text = "Tiempo de ejecución (EJECUTANDO):"
        End If
    End Sub

    Private Sub btn_pauini_Click(sender As System.Object, e As System.EventArgs)
        pausa()
    End Sub

    Private Sub btn_inipau_Click(sender As System.Object, e As System.EventArgs) Handles btn_inipau.Click
        pausa()
    End Sub

    Private Sub btn_enviar_Click(sender As System.Object, e As System.EventArgs) Handles btn_enviar.Click
        Dim resp = MessageBox.Show("Usar esta acción pausara el sistema durante 5 minutos, luego se reanudara automaticamente. ¿Desea continuar?", "¿Está seguro?", MessageBoxButtons.YesNo)
        If (resp = MsgBoxResult.Yes) Then
            Timer_contar_segundos.Stop()
            Timer_Envia_Correos.Stop()
            estadoSys = "Reanudar"
            lblejec.Text = "Tiempo de ejecución (PAUSADO):"
            btn_enviar.Enabled = False
            btn_inipau.Enabled = False
            'MsgBox("Usar esta acción pausara el sistema durante 5 minutos, luego se reanudara automaticamente", MsgBoxStyle.Information, "Aviso")
            iniciarenvio()
            Timer_desbloquear_envio.Start()
        End If
    End Sub

    Private Sub Timer_desbloquear_envio_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_desbloquear_envio.Tick
        pausa()
        btn_enviar.Enabled = True
        btn_inipau.Enabled = True
        Timer_desbloquear_envio.Stop()
    End Sub

    Private Sub Timer_eliminar_temporal_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_eliminar_temporal.Tick
        If chktemporal.Checked = True Then
            'EJECUTA ARCHIVO BAT QUE ELIMINA TEMPORAL'
            Dim Activo As Integer = 0
            Dim currentTime As Date
            Dim Hora As Integer
            currentTime = TimeOfDay
            Hora = currentTime.Hour.ToString

            Dim p As Process
            For Each p In Process.GetProcesses()
                If Not p Is Nothing And p.ProcessName.Trim.Contains("SistemaEnvioCorreos") Then
                    Activo = Activo + 1
                End If
            Next
            If Activo = 0 Then

                If Hora = 2 And estadoBorrarTodo = "NO" Then
                    estadoBorrarTodo = "SI"
                End If

                If Hora = 1 And estadoBorrarTodo = "SI" Then
                    estadoBorrarTodo = "NO"
                    Shell("del_temp_all.bat", AppWinStyle.Hide, True)
                Else
                    Shell("del_temp_rpt.bat", AppWinStyle.Hide, True)
                End If
            End If
        End If
    End Sub
End Class
