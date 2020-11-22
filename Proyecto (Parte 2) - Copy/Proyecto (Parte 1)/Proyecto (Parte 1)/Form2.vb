Option Explicit On
Option Strict On
Option Infer Off

Public Class Form2
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Está seguro que desea salir del programa?", CType(vbQuestion + vbYesNo, MsgBoxStyle), "Mujer Virtuosa") = vbNo Then

        Else
            Application.Exit()
        End If
    End Sub

    Sub switchPanel(panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MsgBox("¿Está seguro que desea cerrar sesión?", CType(vbQuestion + vbYesNo, MsgBoxStyle), "Mujer Virtuosa") = vbNo Then

        Else
            Me.Hide()
            Form1.Show()
        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAnadirPaciente.Visible = False
        btnEditarPaciente.Visible = False
        btnBorrarTodo.Visible = False
        btnBorrarPaciente.Visible = False
        btnBuscar.Visible = False
        btnImprimir.Visible = False




    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        switchPanel(menu1)
        btnAnadirPaciente.Visible = True
        btnEditarPaciente.Visible = False
        btnBorrarTodo.Visible = True
        btnBorrarPaciente.Visible = False
        btnBuscar.Visible = False
        btnImprimir.Visible = False




    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        switchPanel(menu2)
        btnAnadirPaciente.Visible = False
        btnEditarPaciente.Visible = True
        btnBorrarTodo.Visible = False
        btnBorrarPaciente.Visible = True
        btnBuscar.Visible = False
        btnImprimir.Visible = False



    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        switchPanel(menu3)
        btnAnadirPaciente.Visible = False
        btnEditarPaciente.Visible = False
        btnBorrarTodo.Visible = False
        btnBorrarPaciente.Visible = True
        btnBuscar.Visible = True
        btnImprimir.Visible = True




    End Sub

    Private Sub btnHabitaciones_Click(sender As Object, e As EventArgs) Handles btnHabitaciones.Click
        switchPanel(menu4)
        btnAnadirPaciente.Visible = False
        btnEditarPaciente.Visible = False
        btnBorrarTodo.Visible = False
        btnBorrarPaciente.Visible = False
        btnBuscar.Visible = False
        btnImprimir.Visible = False




    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnUtilidades.Click
        switchPanel(menu5)
        btnAnadirPaciente.Visible = False
        btnEditarPaciente.Visible = False
        btnBorrarTodo.Visible = False
        btnBorrarPaciente.Visible = False
        btnBuscar.Visible = False
        btnImprimir.Visible = False


    End Sub

    Private Sub btnAnadirPaciente_Click(sender As Object, e As EventArgs) Handles btnAnadirPaciente.Click
        btnEditarPaciente.Visible = False
        MessageBox.Show("Los datos se añadieron con éxito.")




    End Sub

    Private Sub btnEditarPaciente_Click(sender As Object, e As EventArgs) Handles btnEditarPaciente.Click
        MessageBox.Show("Los datos se editaron con éxito.")

    End Sub

    Private Sub btnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarTodo.Click
        If MsgBox("¿Está seguro que desea borrar todo?", CType(vbQuestion + vbYesNo, MsgBoxStyle), "Mujer Virtuosa") = vbNo Then

        Else
            menu1.txtNombrePaciente.Clear()
            menu1.txtFecha.Clear()
            menu1.txtTelefono.Clear()
            menu1.ComboBox1.Text = " "
            menu1.ComboBox2.Text = " "
            menu1.txtMedicoPrimario.Clear()
            menu1.txtPlanMedico.Clear()
            menu1.txtTutorLegal.Clear()
            menu1.txtDireccion.Clear()

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MessageBox.Show("Busqueda ha sido realizada con éxito")
    End Sub

    Private Sub btnBorrarPaciente_Click(sender As Object, e As EventArgs) Handles btnBorrarPaciente.Click
        If MsgBox("¿Está seguro que desea borrar este paciente?", CType(vbQuestion + vbYesNo, MsgBoxStyle), "Mujer Virtuosa") = vbNo Then

        Else
            MessageBox.Show("Paciente borrado con éxito")


        End If
    End Sub




End Class