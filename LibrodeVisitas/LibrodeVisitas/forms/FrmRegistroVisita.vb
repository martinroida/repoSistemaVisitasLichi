Public Class frmRegistroVisita
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If lblSignal.Text = "Agregar" Then
            Try
                Dim Consulta As String
                Consulta = "INSERT INTO visitas (idVisita, apellido, nombre, rubro, fecha, hora, comentarios) VALUES ('" & txtIdVisita.Text & "', '" & txtApellido.Text & "', '" & txtNombre.Text & "', '" & txtRubro.Text & "', '" & dtpFecha.Text & "', '" & dtpHora.Value.ToString & "', '" & txtComentarios.Text & "')"
                comando.Connection = conexion
                comando.CommandType = CommandType.Text
                comando.CommandText = Consulta
                comando.ExecuteNonQuery()
                MsgBox("Datos guardados", MsgBoxStyle.Information + vbOKOnly, "Confirmación")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        Try
            Dim Consulta As String
            Consulta = ""
            Consulta = "UPDATE parametros SET nroVisitas = " & Val(txtIdVisita.Text) + 1 & ""
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = Consulta
            comando.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Me.Close()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Close()
    End Sub
End Class