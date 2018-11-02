<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SPDisminuirMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SPDisminuirSueldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SPAumentarSueldo2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem, Me.DepartamentoToolStripMenuItem, Me.VerRegistroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerEmpleadosToolStripMenuItem, Me.AdministrarEmpleadosToolStripMenuItem})
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'VerEmpleadosToolStripMenuItem
        '
        Me.VerEmpleadosToolStripMenuItem.Name = "VerEmpleadosToolStripMenuItem"
        Me.VerEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VerEmpleadosToolStripMenuItem.Text = "Ver Empleados"
        '
        'AdministrarEmpleadosToolStripMenuItem
        '
        Me.AdministrarEmpleadosToolStripMenuItem.Name = "AdministrarEmpleadosToolStripMenuItem"
        Me.AdministrarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AdministrarEmpleadosToolStripMenuItem.Text = "Administrar Empleados"
        '
        'DepartamentoToolStripMenuItem
        '
        Me.DepartamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerDepartamentoToolStripMenuItem, Me.AdministrarDepartamentoToolStripMenuItem})
        Me.DepartamentoToolStripMenuItem.Name = "DepartamentoToolStripMenuItem"
        Me.DepartamentoToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.DepartamentoToolStripMenuItem.Text = "Departamento"
        '
        'VerDepartamentoToolStripMenuItem
        '
        Me.VerDepartamentoToolStripMenuItem.Name = "VerDepartamentoToolStripMenuItem"
        Me.VerDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.VerDepartamentoToolStripMenuItem.Text = "Ver Departamento"
        '
        'AdministrarDepartamentoToolStripMenuItem
        '
        Me.AdministrarDepartamentoToolStripMenuItem.Name = "AdministrarDepartamentoToolStripMenuItem"
        Me.AdministrarDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AdministrarDepartamentoToolStripMenuItem.Text = "Administrar Departamento"
        '
        'VerRegistroToolStripMenuItem
        '
        Me.VerRegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SPDisminuirMatriculaToolStripMenuItem, Me.SPDisminuirSueldoToolStripMenuItem, Me.SPAumentarSueldo2ToolStripMenuItem})
        Me.VerRegistroToolStripMenuItem.Name = "VerRegistroToolStripMenuItem"
        Me.VerRegistroToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.VerRegistroToolStripMenuItem.Text = "Ver Registro"
        '
        'SPDisminuirMatriculaToolStripMenuItem
        '
        Me.SPDisminuirMatriculaToolStripMenuItem.Name = "SPDisminuirMatriculaToolStripMenuItem"
        Me.SPDisminuirMatriculaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SPDisminuirMatriculaToolStripMenuItem.Text = "SP_Aumentar_Sueldo"
        '
        'SPDisminuirSueldoToolStripMenuItem
        '
        Me.SPDisminuirSueldoToolStripMenuItem.Name = "SPDisminuirSueldoToolStripMenuItem"
        Me.SPDisminuirSueldoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SPDisminuirSueldoToolStripMenuItem.Text = "SP_Disminuir_Sueldo"
        '
        'SPAumentarSueldo2ToolStripMenuItem
        '
        Me.SPAumentarSueldo2ToolStripMenuItem.Name = "SPAumentarSueldo2ToolStripMenuItem"
        Me.SPAumentarSueldo2ToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SPAumentarSueldo2ToolStripMenuItem.Text = "SP_Aumentar_Sueldo2"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 24)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(684, 302)
        Me.dgv.TabIndex = 1
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 326)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgv As DataGridView
    Friend WithEvents SPDisminuirMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SPDisminuirSueldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SPAgregarDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SPAgregarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SPAumentarSueldo2ToolStripMenuItem As ToolStripMenuItem
End Class
