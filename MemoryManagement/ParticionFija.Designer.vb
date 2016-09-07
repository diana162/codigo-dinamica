<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParticionFija
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParticionFija))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMemoria = New System.Windows.Forms.Label()
        Me.lblParticiones = New System.Windows.Forms.Label()
        Me.dgvProcesos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvParticiones = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tamaño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcesoN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcesoT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSalida = New System.Windows.Forms.RichTextBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTerminarProceso = New System.Windows.Forms.Button()
        Me.btnAgregarProceso = New System.Windows.Forms.Button()
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParticiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Partición Fija"
        '
        'lblMemoria
        '
        Me.lblMemoria.AutoSize = True
        Me.lblMemoria.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemoria.ForeColor = System.Drawing.Color.Purple
        Me.lblMemoria.Location = New System.Drawing.Point(24, 108)
        Me.lblMemoria.Name = "lblMemoria"
        Me.lblMemoria.Size = New System.Drawing.Size(225, 30)
        Me.lblMemoria.TabIndex = 1
        Me.lblMemoria.Text = "Memoria Ram ~ 600kb"
        '
        'lblParticiones
        '
        Me.lblParticiones.AutoSize = True
        Me.lblParticiones.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParticiones.ForeColor = System.Drawing.Color.DimGray
        Me.lblParticiones.Location = New System.Drawing.Point(27, 142)
        Me.lblParticiones.Name = "lblParticiones"
        Me.lblParticiones.Size = New System.Drawing.Size(104, 15)
        Me.lblParticiones.TabIndex = 1
        Me.lblParticiones.Text = "P1: 50kb | P2: 15kb"
        '
        'dgvProcesos
        '
        Me.dgvProcesos.AllowUserToAddRows = False
        Me.dgvProcesos.AllowUserToDeleteRows = False
        Me.dgvProcesos.AllowUserToOrderColumns = True
        Me.dgvProcesos.AllowUserToResizeColumns = False
        Me.dgvProcesos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProcesos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProcesos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.EstadoP})
        Me.dgvProcesos.Location = New System.Drawing.Point(530, 219)
        Me.dgvProcesos.MultiSelect = False
        Me.dgvProcesos.Name = "dgvProcesos"
        Me.dgvProcesos.ReadOnly = True
        Me.dgvProcesos.RowHeadersVisible = False
        Me.dgvProcesos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProcesos.Size = New System.Drawing.Size(237, 299)
        Me.dgvProcesos.TabIndex = 9
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Proceso"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tamaño"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'EstadoP
        '
        Me.EstadoP.HeaderText = "Estado"
        Me.EstadoP.Name = "EstadoP"
        Me.EstadoP.ReadOnly = True
        Me.EstadoP.Width = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Particiones"
        '
        'dgvParticiones
        '
        Me.dgvParticiones.AllowUserToAddRows = False
        Me.dgvParticiones.AllowUserToDeleteRows = False
        Me.dgvParticiones.AllowUserToResizeColumns = False
        Me.dgvParticiones.AllowUserToResizeRows = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvParticiones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvParticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParticiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.Direccion, Me.Tamaño, Me.ProcesoN, Me.ProcesoT, Me.Estado})
        Me.dgvParticiones.Location = New System.Drawing.Point(29, 219)
        Me.dgvParticiones.MultiSelect = False
        Me.dgvParticiones.Name = "dgvParticiones"
        Me.dgvParticiones.ReadOnly = True
        Me.dgvParticiones.RowHeadersVisible = False
        Me.dgvParticiones.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvParticiones.Size = New System.Drawing.Size(482, 146)
        Me.dgvParticiones.TabIndex = 10
        '
        'Numero
        '
        Me.Numero.HeaderText = "N"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        Me.Numero.Width = 40
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 85
        '
        'Tamaño
        '
        Me.Tamaño.HeaderText = "Tamaño"
        Me.Tamaño.Name = "Tamaño"
        Me.Tamaño.ReadOnly = True
        Me.Tamaño.Width = 85
        '
        'ProcesoN
        '
        Me.ProcesoN.HeaderText = "Proceso N"
        Me.ProcesoN.Name = "ProcesoN"
        Me.ProcesoN.ReadOnly = True
        Me.ProcesoN.Width = 85
        '
        'ProcesoT
        '
        Me.ProcesoT.HeaderText = "Proceso T"
        Me.ProcesoT.Name = "ProcesoT"
        Me.ProcesoT.ReadOnly = True
        Me.ProcesoT.Width = 85
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 85
        '
        'txtSalida
        '
        Me.txtSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalida.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalida.Location = New System.Drawing.Point(31, 411)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.Size = New System.Drawing.Size(484, 107)
        Me.txtSalida.TabIndex = 11
        Me.txtSalida.Text = ""
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEjecutar.FlatAppearance.BorderSize = 0
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEjecutar.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.Location = New System.Drawing.Point(403, 54)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(233, 97)
        Me.btnEjecutar.TabIndex = 14
        Me.btnEjecutar.Text = "Haga click aqui para iniciar..."
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Purple
        Me.btnCerrar.Location = New System.Drawing.Point(746, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 33)
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add (2).png")
        Me.ImageList1.Images.SetKeyName(1, "delete (2).png")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Purple
        Me.Label7.Location = New System.Drawing.Point(525, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 30)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Procesos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Purple
        Me.Label8.Location = New System.Drawing.Point(24, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Particiones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(26, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 30)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Log"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(27, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Algoritmo de Asignación -> Primer Ajuste"
        '
        'btnTerminarProceso
        '
        Me.btnTerminarProceso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTerminarProceso.FlatAppearance.BorderSize = 0
        Me.btnTerminarProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminarProceso.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminarProceso.ForeColor = System.Drawing.Color.Purple
        Me.btnTerminarProceso.Location = New System.Drawing.Point(742, 175)
        Me.btnTerminarProceso.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTerminarProceso.Name = "btnTerminarProceso"
        Me.btnTerminarProceso.Size = New System.Drawing.Size(25, 41)
        Me.btnTerminarProceso.TabIndex = 19
        Me.btnTerminarProceso.Text = "-"
        Me.btnTerminarProceso.UseVisualStyleBackColor = True
        '
        'btnAgregarProceso
        '
        Me.btnAgregarProceso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarProceso.FlatAppearance.BorderSize = 0
        Me.btnAgregarProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProceso.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProceso.ForeColor = System.Drawing.Color.Purple
        Me.btnAgregarProceso.Location = New System.Drawing.Point(710, 175)
        Me.btnAgregarProceso.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregarProceso.Name = "btnAgregarProceso"
        Me.btnAgregarProceso.Size = New System.Drawing.Size(25, 41)
        Me.btnAgregarProceso.TabIndex = 20
        Me.btnAgregarProceso.Text = "+"
        Me.btnAgregarProceso.UseVisualStyleBackColor = True
        '
        'ParticionFija
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTerminarProceso)
        Me.Controls.Add(Me.btnAgregarProceso)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtSalida)
        Me.Controls.Add(Me.dgvParticiones)
        Me.Controls.Add(Me.dgvProcesos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblParticiones)
        Me.Controls.Add(Me.lblMemoria)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ParticionFija"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParticiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMemoria As Label
    Friend WithEvents lblParticiones As Label
    Friend WithEvents dgvProcesos As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvParticiones As DataGridView
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Tamaño As DataGridViewTextBoxColumn
    Friend WithEvents ProcesoN As DataGridViewTextBoxColumn
    Friend WithEvents ProcesoT As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents txtSalida As RichTextBox
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoP As DataGridViewTextBoxColumn
    Friend WithEvents btnTerminarProceso As Button
    Friend WithEvents btnAgregarProceso As Button
End Class
