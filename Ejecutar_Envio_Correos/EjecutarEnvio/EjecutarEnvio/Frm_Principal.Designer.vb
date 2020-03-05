<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chktemporal = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.btn_inipau = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltiempo = New System.Windows.Forms.Label()
        Me.lblejec = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer_contar_segundos = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Envia_Correos = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_desbloquear_envio = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_eliminar_temporal = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chktemporal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_enviar)
        Me.Panel1.Controls.Add(Me.btn_inipau)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbltiempo)
        Me.Panel1.Controls.Add(Me.lblejec)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 152)
        Me.Panel1.TabIndex = 2
        '
        'chktemporal
        '
        Me.chktemporal.AutoSize = True
        Me.chktemporal.Checked = True
        Me.chktemporal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chktemporal.Location = New System.Drawing.Point(450, 7)
        Me.chktemporal.Name = "chktemporal"
        Me.chktemporal.Size = New System.Drawing.Size(15, 14)
        Me.chktemporal.TabIndex = 11
        Me.chktemporal.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(252, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Habilitar eliminación de temporal"
        '
        'btn_enviar
        '
        Me.btn_enviar.Image = Global.EjecutarEnvio.My.Resources.Resources.mail
        Me.btn_enviar.Location = New System.Drawing.Point(334, 87)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(68, 62)
        Me.btn_enviar.TabIndex = 9
        Me.btn_enviar.UseVisualStyleBackColor = True
        '
        'btn_inipau
        '
        Me.btn_inipau.Image = Global.EjecutarEnvio.My.Resources.Resources._27185
        Me.btn_inipau.Location = New System.Drawing.Point(403, 87)
        Me.btn_inipau.Name = "btn_inipau"
        Me.btn_inipau.Size = New System.Drawing.Size(68, 62)
        Me.btn_inipau.TabIndex = 8
        Me.btn_inipau.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EjecutarEnvio.My.Resources.Resources.logoorder
        Me.PictureBox1.Location = New System.Drawing.Point(6, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lbltiempo
        '
        Me.lbltiempo.AutoSize = True
        Me.lbltiempo.Location = New System.Drawing.Point(252, 103)
        Me.lbltiempo.Name = "lbltiempo"
        Me.lbltiempo.Size = New System.Drawing.Size(0, 13)
        Me.lbltiempo.TabIndex = 2
        '
        'lblejec
        '
        Me.lblejec.AutoSize = True
        Me.lblejec.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblejec.Location = New System.Drawing.Point(1, 101)
        Me.lblejec.Name = "lblejec"
        Me.lblejec.Size = New System.Drawing.Size(245, 13)
        Me.lblejec.TabIndex = 1
        Me.lblejec.Text = "Tiempo de ejecución (EJECUTANDO):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de Mensajería"
        '
        'Timer_contar_segundos
        '
        Me.Timer_contar_segundos.Interval = 1000
        '
        'Timer_Envia_Correos
        '
        Me.Timer_Envia_Correos.Interval = 300000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Sistema de ejecución de envio de mails"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(97, 26)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Timer_desbloquear_envio
        '
        Me.Timer_desbloquear_envio.Interval = 300000
        '
        'Timer_eliminar_temporal
        '
        Me.Timer_eliminar_temporal.Interval = 2000
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 152)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(490, 190)
        Me.MinimumSize = New System.Drawing.Size(490, 190)
        Me.Name = "Frm_Principal"
        Me.Text = "OorderBy E-mail (Up) v22.01.2019.12.00"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbltiempo As System.Windows.Forms.Label
    Friend WithEvents lblejec As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer_contar_segundos As System.Windows.Forms.Timer
    Friend WithEvents Timer_Envia_Correos As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_inipau As System.Windows.Forms.Button
    Friend WithEvents btn_enviar As System.Windows.Forms.Button
    Friend WithEvents Timer_desbloquear_envio As System.Windows.Forms.Timer
    Friend WithEvents Timer_eliminar_temporal As System.Windows.Forms.Timer
    Friend WithEvents chktemporal As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
