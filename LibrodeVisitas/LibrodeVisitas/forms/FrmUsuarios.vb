Public Class FrmUsuarios
    Private Sub llenacomboTipoUsuario()
        adaptador.SelectCommand = comando
        adaptador.SelectCommand.Connection = conexion
        comando.CommandText = "Select * from TipoUsuario order by Nombre"
        tabladedatos = New DataTable
        adaptador.Fill(tabladedatos)
        With cbotipo
            .DataSource = tabladedatos
            .DisplayMember = "Nombre"
            .ValueMember = "IdTipoUsuario"
        End With
        cbotipo.Text = ""
        cbotipo.SelectedIndex = -1
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Try
            Dim CONSULTA As String
            CONSULTA = "INSERT INTO Usuarios (IdUsuario,Nombre,Clave,IdTipoUsuario)VALUES('" & txtIdUsuario.Text & "','" & txtNombre.Text & "','" & txtClave.Text & "', '" & cbotipo.SelectedValue & "')"
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = CONSULTA
            comando.ExecuteNonQuery()
            MsgBox("UD YA SE ENCUENTRA REGISTRADO", vbOKOnly)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        txtIdUsuario.Text = ""
        txtNombre.Text = ""
        txtClave.Text = ""
        txtTipo.Text = ""
        txtIdUsuario.Focus()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenacomboTipoUsuario()
    End Sub
End Class