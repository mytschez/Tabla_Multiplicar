<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTablaMultiplicar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtTabla = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTablaCompleta = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTabla
        '
        Me.txtTabla.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTabla.Location = New System.Drawing.Point(288, 44)
        Me.txtTabla.Name = "txtTabla"
        Me.txtTabla.Size = New System.Drawing.Size(76, 37)
        Me.txtTabla.TabIndex = 0
        Me.txtTabla.Text = "0"
        Me.txtTabla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalcular
        '
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(382, 40)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(140, 48)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumero.Location = New System.Drawing.Point(12, 51)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(259, 25)
        Me.lblnumero.TabIndex = 3
        Me.lblnumero.Text = "Introduzca un número: "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtTablaCompleta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 464)
        Me.Panel1.TabIndex = 2
        '
        'txtTablaCompleta
        '
        Me.txtTablaCompleta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTablaCompleta.Location = New System.Drawing.Point(-2, -2)
        Me.txtTablaCompleta.Multiline = True
        Me.txtTablaCompleta.Name = "txtTablaCompleta"
        Me.txtTablaCompleta.ReadOnly = True
        Me.txtTablaCompleta.Size = New System.Drawing.Size(548, 463)
        Me.txtTablaCompleta.TabIndex = 0
        '
        'frmTablaMultiplicar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 582)
        Me.Controls.Add(Me.lblnumero)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtTabla)
        Me.Name = "frmTablaMultiplicar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla de multiplicar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTabla As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblnumero As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTablaCompleta As TextBox
End Class
