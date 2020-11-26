Public Class frmLoguin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenacomboTipoUsuario()
    End Sub

    Private Sub llenacomboTipoUsuario()
        adaptador.SelectCommand = comando
        adaptador.SelectCommand.Connection = conexion
        comando.CommandText = "SELECT * FROM tipoUsuario ORDER BY nombre"
        tabladedatos = New DataTable
        adaptador.Fill(tabladedatos)
        With cboTipoLog
            .DataSource = tabladedatos
            .DisplayMember = "nombre"
            .ValueMember = "idTipoUsuario"
        End With
        cboTipoLog.Text = ""
        cboTipoLog.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtUsuario.Text = ""
        txtContra.Text = ""
        cboTipoLog.Text = ""
        txtUsuario.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If dgvGrillaUsuarios.Rows.Count <> 0 Then
            seteodedatos.Tables("Usuarios").Clear()
        End If

        adaptador.SelectCommand = comando
        adaptador.SelectCommand.Connection = conexion
        comando.CommandText = "SELECT nombre, clave FROM usuarios WHERE nombre = '" & txtUsuario.Text & "' AND clave = '" & txtContra.Text & "'"
        adaptador.Fill(seteodedatos, "Usuarios")
        dgvGrillaUsuarios.DataSource = seteodedatos.Tables("Usuarios")
        dgvGrillaUsuarios.Columns(0).HeaderText = "Usuario"
        dgvGrillaUsuarios.Columns(1).HeaderText = "Password"

        dgvGrillaUsuarios.Columns(0).Width = 200
        dgvGrillaUsuarios.Columns(1).Width = 200

        If dgvGrillaUsuarios.Rows.Count <> 0 Then
            frmMenuPrincipal.Show()
        Else
            MsgBox("CONTRASEÑA INCORRECTA: INGRESE NUEVAMENTE SU CONTRASEÑA", MsgBoxStyle.Exclamation + vbOKOnly, "Contraseña incorrecta")
            txtUsuario.Text = ""
            txtContra.Text = ""
            cboTipoLog.Text = ""
            txtUsuario.Focus()
        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

End Class