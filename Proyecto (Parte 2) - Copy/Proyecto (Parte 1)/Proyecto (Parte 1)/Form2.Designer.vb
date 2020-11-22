<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnBorrarPaciente = New System.Windows.Forms.Button()
        Me.btnAnadirPaciente = New System.Windows.Forms.Button()
        Me.btnEditarPaciente = New System.Windows.Forms.Button()
        Me.btnBorrarTodo = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.btnUtilidades = New System.Windows.Forms.Button()
        Me.btnHabitaciones = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAnadir)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnLista)
        Me.Panel1.Controls.Add(Me.btnUtilidades)
        Me.Panel1.Controls.Add(Me.btnHabitaciones)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 71)
        Me.Panel1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(705, 396)
        Me.Panel2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(3, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(591, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Presione los botones del menú superior para navegar el programa."
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnImprimir.AutoSize = True
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.printer1
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(723, 245)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(174, 63)
        Me.btnImprimir.TabIndex = 21
        Me.btnImprimir.Text = "Imprimir Reporte"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscar.AutoSize = True
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.search
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(723, 107)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(174, 63)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnBorrarPaciente
        '
        Me.btnBorrarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBorrarPaciente.AutoSize = True
        Me.btnBorrarPaciente.BackColor = System.Drawing.Color.IndianRed
        Me.btnBorrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarPaciente.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.delete
        Me.btnBorrarPaciente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrarPaciente.Location = New System.Drawing.Point(723, 176)
        Me.btnBorrarPaciente.Name = "btnBorrarPaciente"
        Me.btnBorrarPaciente.Size = New System.Drawing.Size(174, 63)
        Me.btnBorrarPaciente.TabIndex = 19
        Me.btnBorrarPaciente.Text = "Borrar Paciente"
        Me.btnBorrarPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrarPaciente.UseVisualStyleBackColor = False
        '
        'btnAnadirPaciente
        '
        Me.btnAnadirPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAnadirPaciente.AutoSize = True
        Me.btnAnadirPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnadirPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnadirPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirPaciente.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.add2
        Me.btnAnadirPaciente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnadirPaciente.Location = New System.Drawing.Point(723, 107)
        Me.btnAnadirPaciente.Name = "btnAnadirPaciente"
        Me.btnAnadirPaciente.Size = New System.Drawing.Size(174, 63)
        Me.btnAnadirPaciente.TabIndex = 16
        Me.btnAnadirPaciente.Text = "Añadir Paciente"
        Me.btnAnadirPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnadirPaciente.UseVisualStyleBackColor = False
        '
        'btnEditarPaciente
        '
        Me.btnEditarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditarPaciente.AutoSize = True
        Me.btnEditarPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEditarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPaciente.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.edit
        Me.btnEditarPaciente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditarPaciente.Location = New System.Drawing.Point(723, 107)
        Me.btnEditarPaciente.Name = "btnEditarPaciente"
        Me.btnEditarPaciente.Size = New System.Drawing.Size(174, 63)
        Me.btnEditarPaciente.TabIndex = 17
        Me.btnEditarPaciente.Text = "Editar Paciente"
        Me.btnEditarPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditarPaciente.UseVisualStyleBackColor = False
        '
        'btnBorrarTodo
        '
        Me.btnBorrarTodo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBorrarTodo.AutoSize = True
        Me.btnBorrarTodo.BackColor = System.Drawing.Color.IndianRed
        Me.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrarTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarTodo.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.clear
        Me.btnBorrarTodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrarTodo.Location = New System.Drawing.Point(723, 245)
        Me.btnBorrarTodo.Name = "btnBorrarTodo"
        Me.btnBorrarTodo.Size = New System.Drawing.Size(172, 63)
        Me.btnBorrarTodo.TabIndex = 18
        Me.btnBorrarTodo.Text = "Borrar Todo"
        Me.btnBorrarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrarTodo.UseVisualStyleBackColor = False
        '
        'btnAnadir
        '
        Me.btnAnadir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAnadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadir.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.add2
        Me.btnAnadir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnadir.Location = New System.Drawing.Point(12, 3)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAnadir.Size = New System.Drawing.Size(159, 58)
        Me.btnAnadir.TabIndex = 0
        Me.btnAnadir.Text = "Añadir un paciente"
        Me.btnAnadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnadir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.edit
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(177, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(159, 57)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar un paciente"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnLista
        '
        Me.btnLista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLista.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.list
        Me.btnLista.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLista.Location = New System.Drawing.Point(342, 4)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(190, 57)
        Me.btnLista.TabIndex = 2
        Me.btnLista.Text = "Lista y datos de paciente"
        Me.btnLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'btnUtilidades
        '
        Me.btnUtilidades.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUtilidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUtilidades.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.utilities
        Me.btnUtilidades.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUtilidades.Location = New System.Drawing.Point(737, 5)
        Me.btnUtilidades.Name = "btnUtilidades"
        Me.btnUtilidades.Size = New System.Drawing.Size(114, 56)
        Me.btnUtilidades.TabIndex = 4
        Me.btnUtilidades.Text = "Utilidades"
        Me.btnUtilidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUtilidades.UseVisualStyleBackColor = True
        '
        'btnHabitaciones
        '
        Me.btnHabitaciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHabitaciones.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.rooms
        Me.btnHabitaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHabitaciones.Location = New System.Drawing.Point(538, 5)
        Me.btnHabitaciones.Name = "btnHabitaciones"
        Me.btnHabitaciones.Size = New System.Drawing.Size(193, 57)
        Me.btnHabitaciones.TabIndex = 3
        Me.btnHabitaciones.Text = "Monitorear Habitaciones"
        Me.btnHabitaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHabitaciones.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.AutoSize = True
        Me.btnCerrar.BackColor = System.Drawing.Color.IndianRed
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.Proyecto__Parte_1_.My.Resources.Resources.logout_icon
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(737, 327)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(143, 63)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "Cerrar Sesion"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Proyecto__Parte_1_.My.Resources.Resources._exit
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(760, 396)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(106, 53)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(909, 461)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnBorrarPaciente)
        Me.Controls.Add(Me.btnAnadirPaciente)
        Me.Controls.Add(Me.btnEditarPaciente)
        Me.Controls.Add(Me.btnBorrarTodo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mujer Virtuosa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnadir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnLista As Button
    Friend WithEvents btnHabitaciones As Button
    Friend WithEvents btnUtilidades As Button
    Private WithEvents btnSalir As Button
    Private WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private WithEvents btnAnadirPaciente As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private WithEvents btnEditarPaciente As Button
    Friend WithEvents Label1 As Label
    Private WithEvents btnBorrarTodo As Button
    Private WithEvents btnBorrarPaciente As Button
    Private WithEvents btnBuscar As Button
    Private WithEvents btnImprimir As Button
End Class
