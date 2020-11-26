<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrillaVisitas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvGrillaVisitas = New System.Windows.Forms.DataGridView()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbRubro = New System.Windows.Forms.RadioButton()
        Me.rbApellido = New System.Windows.Forms.RadioButton()
        Me.btnReporte = New System.Windows.Forms.Button()
        CType(Me.dgvGrillaVisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGrillaVisitas
        '
        Me.dgvGrillaVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrillaVisitas.Location = New System.Drawing.Point(12, 121)
        Me.dgvGrillaVisitas.Name = "dgvGrillaVisitas"
        Me.dgvGrillaVisitas.Size = New System.Drawing.Size(733, 284)
        Me.dgvGrillaVisitas.TabIndex = 0
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(12, 61)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(74, 17)
        Me.rbFecha.TabIndex = 1
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Por Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'rbRubro
        '
        Me.rbRubro.AutoSize = True
        Me.rbRubro.Location = New System.Drawing.Point(162, 61)
        Me.rbRubro.Name = "rbRubro"
        Me.rbRubro.Size = New System.Drawing.Size(73, 17)
        Me.rbRubro.TabIndex = 2
        Me.rbRubro.TabStop = True
        Me.rbRubro.Text = "Por Rubro"
        Me.rbRubro.UseVisualStyleBackColor = True
        '
        'rbApellido
        '
        Me.rbApellido.AutoSize = True
        Me.rbApellido.Location = New System.Drawing.Point(323, 61)
        Me.rbApellido.Name = "rbApellido"
        Me.rbApellido.Size = New System.Drawing.Size(81, 17)
        Me.rbApellido.TabIndex = 3
        Me.rbApellido.TabStop = True
        Me.rbApellido.Text = "Por Apellido"
        Me.rbApellido.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(637, 33)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(108, 72)
        Me.btnReporte.TabIndex = 4
        Me.btnReporte.Text = "Generar Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'frmGrillaVisitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 417)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.rbApellido)
        Me.Controls.Add(Me.rbRubro)
        Me.Controls.Add(Me.rbFecha)
        Me.Controls.Add(Me.dgvGrillaVisitas)
        Me.Name = "frmGrillaVisitas"
        Me.Text = "GrillaVisitas"
        CType(Me.dgvGrillaVisitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGrillaVisitas As DataGridView
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents rbRubro As RadioButton
    Friend WithEvents rbApellido As RadioButton
    Friend WithEvents btnReporte As Button
End Class
