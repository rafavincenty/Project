Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged


    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Está seguro que desea salir del programa?", CType(vbQuestion + vbYesNo, MsgBoxStyle), "Mujer Virtuosa") = vbNo Then

        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs)

        If txtUsuario.Text = "admin" And txtContrasena.Text = "admin" Then
            MessageBox.Show("Bienvenido.")
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("El nombre de usuario o contraseña es incorrecta, por favor, intentelo de nuevo.")
            txtUsuario.Clear()
            txtContrasena.Clear()
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        If txtUsuario.Text = "admin" And txtContrasena.Text = "admin" Then 'Esto solo sera para la primera parte'
            MessageBox.Show("Bienvenido.")
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("El nombre de usuario o contraseña es incorrecta, por favor, intentelo de nuevo.")
            txtUsuario.Clear()
            txtContrasena.Clear()
        End If
    End Sub

    Private Sub txtTitulo_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
