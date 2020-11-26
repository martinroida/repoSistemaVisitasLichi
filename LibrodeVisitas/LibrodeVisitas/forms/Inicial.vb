Public Class frmInicio

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        frmRegistroVisita.Show()
        frmRegistroVisita.lblSignal.Text = "Agregar"

        'Para agregar un número al txt id de visita
        Try
            Dim Consulta As String
            Consulta = ""
            Consulta = "SELECT MAX(nroVisita) FROM parametros"
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = Consulta
            lectorDatos = comando.ExecuteReader

            If lectorDatos.Read Then
                frmRegistroVisita.txtIdVisita.Text = lectorDatos(0)
            End If
        Catch ex As Exception

        End Try
        lectorDatos.Close()

    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        frmLoguin.Show()
    End Sub

End Class