﻿Public Class frmGrillaVisitas
    Private Sub frmGrillaVisitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaVisitasPorId()
    End Sub

    Private Sub cargaVisitasPorId()
        If dgvGrillaVisitas.Rows.Count <> 0 Then
            seteodedatos.Tables("Visitas").Clear()
        End If

        adaptador.SelectCommand = comando
        adaptador.SelectCommand.Connection = conexion
        comando.CommandText = "SELECT idVisita, apellido, nombre, rubro, fecha, hora, comentarios FROM visitas ORDER BY idVisita"
        adaptador.Fill(seteodedatos, "Visitas")
        dgvGrillaVisitas.DataSource = seteodedatos.Tables("Visitas")
        dgvGrillaVisitas.Columns(0).HeaderText = "id"
        dgvGrillaVisitas.Columns(1).HeaderText = "Apellido"
        dgvGrillaVisitas.Columns(2).HeaderText = "Nombre"
        dgvGrillaVisitas.Columns(3).HeaderText = "Rubro"
        dgvGrillaVisitas.Columns(4).HeaderText = "Fecha"
        dgvGrillaVisitas.Columns(5).HeaderText = "Hora"
        dgvGrillaVisitas.Columns(6).HeaderText = "Comentarios"

        dgvGrillaVisitas.Columns(0).Width = 50
        dgvGrillaVisitas.Columns(1).Width = 100
        dgvGrillaVisitas.Columns(2).Width = 100
        dgvGrillaVisitas.Columns(3).Width = 100
        dgvGrillaVisitas.Columns(4).Width = 100
        dgvGrillaVisitas.Columns(5).Width = 100
        dgvGrillaVisitas.Columns(6).Width = 100
    End Sub

    Private Sub cargaVisitasPorRubro()
        If dgvGrillaVisitas.Rows.Count <> 0 Then
            seteodedatos.Tables("Visitas").Clear()
        End If

        adaptador.SelectCommand = comando
        adaptador.SelectCommand.Connection = conexion
        comando.CommandText = "SELECT idVisita, apellido, nombre, rubro, fecha, hora, comentarios FROM visitas ORDER BY rubro"
        adaptador.Fill(seteodedatos, "Visitas")
        dgvGrillaVisitas.DataSource = seteodedatos.Tables("Visitas")
        dgvGrillaVisitas.Columns(0).HeaderText = "id"
        dgvGrillaVisitas.Columns(1).HeaderText = "Apellido"
        dgvGrillaVisitas.Columns(2).HeaderText = "Nombre"
        dgvGrillaVisitas.Columns(3).HeaderText = "Rubro"
        dgvGrillaVisitas.Columns(4).HeaderText = "Fecha"
        dgvGrillaVisitas.Columns(5).HeaderText = "Hora"
        dgvGrillaVisitas.Columns(6).HeaderText = "Comentarios"

        dgvGrillaVisitas.Columns(0).Width = 50
        dgvGrillaVisitas.Columns(1).Width = 100
        dgvGrillaVisitas.Columns(2).Width = 100
        dgvGrillaVisitas.Columns(3).Width = 100
        dgvGrillaVisitas.Columns(4).Width = 100
        dgvGrillaVisitas.Columns(5).Width = 100
        dgvGrillaVisitas.Columns(6).Width = 100
    End Sub

    Private Sub cargaVisitasPorApellido()
        If dgvGrillaVisitas.Rows.Count <> 0 Then
            seteodedatos.Tables("Visitas").Clear()
        End If

        adaptador.SelectCommand = comando
        adaptador.SelectCommand.Connection = conexion
        comando.CommandText = "SELECT idVisita, apellido, nombre, rubro, fecha, hora, comentarios FROM visitas ORDER BY apellido"
        adaptador.Fill(seteodedatos, "Visitas")
        dgvGrillaVisitas.DataSource = seteodedatos.Tables("Visitas")
        dgvGrillaVisitas.Columns(0).HeaderText = "id"
        dgvGrillaVisitas.Columns(1).HeaderText = "Apellido"
        dgvGrillaVisitas.Columns(2).HeaderText = "Nombre"
        dgvGrillaVisitas.Columns(3).HeaderText = "Rubro"
        dgvGrillaVisitas.Columns(4).HeaderText = "Fecha"
        dgvGrillaVisitas.Columns(5).HeaderText = "Hora"
        dgvGrillaVisitas.Columns(6).HeaderText = "Comentarios"

        dgvGrillaVisitas.Columns(0).Width = 50
        dgvGrillaVisitas.Columns(1).Width = 100
        dgvGrillaVisitas.Columns(2).Width = 100
        dgvGrillaVisitas.Columns(3).Width = 100
        dgvGrillaVisitas.Columns(4).Width = 100
        dgvGrillaVisitas.Columns(5).Width = 100
        dgvGrillaVisitas.Columns(6).Width = 100
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        cargaVisitasPorId()
    End Sub

    Private Sub rbRubro_CheckedChanged(sender As Object, e As EventArgs) Handles rbRubro.CheckedChanged
        cargaVisitasPorRubro()
    End Sub

    Private Sub rbApellido_CheckedChanged(sender As Object, e As EventArgs) Handles rbApellido.CheckedChanged
        cargaVisitasPorApellido()
    End Sub
End Class