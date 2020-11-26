Public Class FrmRubro
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        txtIdRubro.Text = ""
        txtDescripcion.Text = ""
        txtIdRubro.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If lblseñal.Text = "AGREGAR" Then
            Try
                Dim CONSULTA As String
                CONSULTA = "INSERT INTO Rubros (IdRubro,Descripcion)VALUES('" & txtIdRubro.Text & "','" & txtDescripcion.Text & "')"
                comando.Connection = conexion
                comando.CommandType = CommandType.Text
                comando.CommandText = CONSULTA
                comando.ExecuteNonQuery()
                MsgBox("Datos guardados", vbOKOnly)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If



        If lblseñal.Text = "MODIFICAR" Then
            Try
                Dim CONSULTA As String
                CONSULTA = "UPDATE Rubros SET IdRubro = '" & txtIdRubro.Text & "',  Descripcion ='" & txtDescripcion.Text & "' where IdRubro = " & Val(txtIdRubro.Text) & ""
                comando.Connection = conexion
                comando.CommandType = CommandType.Text
                comando.CommandText = CONSULTA
                comando.ExecuteNonQuery()
                MsgBox(" DATOS GUARDADOS")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        If lblseñal.Text = "BORRAR" Then
            Dim result As Integer = MessageBox.Show("Ud va a eliminar los datos... Desea Continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    Dim CONSULTA As String
                    CONSULTA = "delete from Rubros WHERE IdRubro = " & Val(txtIdRubro.Text) & ""
                    comando.Connection = conexion
                    comando.CommandType = CommandType.Text
                    comando.CommandText = CONSULTA
                    comando.ExecuteNonQuery()
                    MsgBox(" DATOS ELIMINADOS ")

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub
End Class