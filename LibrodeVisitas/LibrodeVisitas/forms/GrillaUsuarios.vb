Public Class GrillaUsuarios

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
    '    FrmUsuarios.lblseñal.Text = "AGREGAR"
    '    FrmUsuarios.Show()
    'End Sub

    'Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
    '    FrmUsuarios.Show()
    '    FrmUsuarios.lblseñal.Text = "Modificar"
    '    FrmUsuarios.txtIdUsuario.Enabled = False
    '    Me.Enabled = False

    '    FrmUsuarios.txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells(0).Value
    '    FrmUsuarios.txtNombre.Text = dgvUsuarios.CurrentRow.Cells(1).Value
    '    FrmUsuarios.txtClave.Text = dgvUsuarios.CurrentRow.Cells(2).Value
    '    FrmUsuarios.txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells(3).Value
    'End Sub

    'Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
    '    FrmUsuarios.Show()
    '    FrmUsuarios.lblseñal.Text = "Eliminar"
    '    FrmUsuarios.txtIdUsuario.Enabled = False
    '    FrmUsuarios.txtNombre.Enabled = False
    '    FrmUsuarios.txtClave.Enabled = False
    '    FrmUsuarios.txtTipo.Enabled = False
    '    Me.Enabled = False

    '    FrmUsuarios.txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells(0).Value
    '    FrmUsuarios.txtNombre.Text = dgvUsuarios.CurrentRow.Cells(1).Value
    '    FrmUsuarios.txtClave.Text = dgvUsuarios.CurrentRow.Cells(2).Value
    '    FrmUsuarios.txtTipo.Text = dgvUsuarios.CurrentRow.Cells(3).Value
    'End Sub


End Class