Public Class GrillaRubros
    Private Sub GrillaRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarubros()
    End Sub
    Public Sub cargarubros()
        If dgvRubros.Rows.Count <> 0 Then
            seteodedatos.Tables("Rubros").Clear()
        End If
        adaptador.SelectCommand = comando
        adaptador.SelectCommand.Connection = conexion
        comando.CommandText = "Select IdRubro,Descripcion from Rubros order by IdRubro"
        adaptador.Fill(seteodedatos, "Rubros")
        dgvRubros.DataSource = seteodedatos.Tables("Rubros")

        dgvRubros.Columns(0).HeaderText = "Id Rubro"
        dgvRubros.Columns(1).HeaderText = "Descripcion"


        dgvRubros.Columns(0).Width = 50
        dgvRubros.Columns(1).Width = 300

    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmRubro.lblseñal.Text = "AGREGAR"
        FrmRubro.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        FrmRubro.Show()
        FrmRubro.lblseñal.Text = "Modificar"
        FrmRubro.txtIdRubro.Enabled = False
        Me.Enabled = False

        FrmRubro.txtIdRubro.Text = dgvRubros.CurrentRow.Cells(0).Value
        FrmRubro.txtDescripcion.Text = dgvRubros.CurrentRow.Cells(1).Value

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        FrmRubro.Show()
        FrmRubro.lblseñal.Text = "Eliminar"
        FrmRubro.txtIdRubro.Enabled = False
        FrmRubro.txtDescripcion.Enabled = False

        Me.Enabled = False

        FrmRubro.txtIdRubro.Text = dgvRubros.CurrentRow.Cells(0).Value
        FrmRubro.txtDescripcion.Text = dgvRubros.CurrentRow.Cells(1).Value

    End Sub
End Class