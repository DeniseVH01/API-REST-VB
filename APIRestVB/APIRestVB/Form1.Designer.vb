<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.BTNbuscar = New System.Windows.Forms.Button()
        Me.TXTbuscar = New System.Windows.Forms.TextBox()
        Me.BTNaceptar = New System.Windows.Forms.Button()
        Me.DGVlista = New System.Windows.Forms.DataGridView()
        Me.userId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.body = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(23, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(296, 23)
        Me.label1.TabIndex = 10
        Me.label1.Text = "API REST JSON PLACE HOLDER"
        '
        'BTNbuscar
        '
        Me.BTNbuscar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTNbuscar.Location = New System.Drawing.Point(605, 11)
        Me.BTNbuscar.Name = "BTNbuscar"
        Me.BTNbuscar.Size = New System.Drawing.Size(75, 32)
        Me.BTNbuscar.TabIndex = 9
        Me.BTNbuscar.Text = "BUSCAR"
        Me.BTNbuscar.UseVisualStyleBackColor = True
        '
        'TXTbuscar
        '
        Me.TXTbuscar.Location = New System.Drawing.Point(346, 19)
        Me.TXTbuscar.Name = "TXTbuscar"
        Me.TXTbuscar.Size = New System.Drawing.Size(253, 20)
        Me.TXTbuscar.TabIndex = 8
        '
        'BTNaceptar
        '
        Me.BTNaceptar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTNaceptar.Location = New System.Drawing.Point(605, 471)
        Me.BTNaceptar.Name = "BTNaceptar"
        Me.BTNaceptar.Size = New System.Drawing.Size(75, 34)
        Me.BTNaceptar.TabIndex = 7
        Me.BTNaceptar.Text = "LISTAR"
        Me.BTNaceptar.UseVisualStyleBackColor = True
        '
        'DGVlista
        '
        Me.DGVlista.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.DGVlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.userId, Me.Id, Me.title, Me.body})
        Me.DGVlista.Location = New System.Drawing.Point(23, 49)
        Me.DGVlista.Name = "DGVlista"
        Me.DGVlista.ReadOnly = True
        Me.DGVlista.Size = New System.Drawing.Size(657, 416)
        Me.DGVlista.TabIndex = 6
        '
        'userId
        '
        Me.userId.DataPropertyName = "userIdL"
        Me.userId.HeaderText = "Usuario"
        Me.userId.Name = "userId"
        Me.userId.ReadOnly = True
        Me.userId.Width = 80
        '
        'Id
        '
        Me.Id.DataPropertyName = "IdL"
        Me.Id.HeaderText = "Identificador"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 80
        '
        'title
        '
        Me.title.DataPropertyName = "titleL"
        Me.title.HeaderText = "Titulo"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        Me.title.Width = 200
        '
        'body
        '
        Me.body.DataPropertyName = "bodyL"
        Me.body.HeaderText = "Contenido"
        Me.body.Name = "body"
        Me.body.ReadOnly = True
        Me.body.Width = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(702, 510)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.BTNbuscar)
        Me.Controls.Add(Me.TXTbuscar)
        Me.Controls.Add(Me.BTNaceptar)
        Me.Controls.Add(Me.DGVlista)
        Me.Name = "Form1"
        Me.Text = "API REST"
        CType(Me.DGVlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents BTNbuscar As Button
    Friend WithEvents TXTbuscar As TextBox
    Friend WithEvents BTNaceptar As Button
    Friend WithEvents DGVlista As DataGridView
    Friend WithEvents userId As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents body As DataGridViewTextBoxColumn
End Class
