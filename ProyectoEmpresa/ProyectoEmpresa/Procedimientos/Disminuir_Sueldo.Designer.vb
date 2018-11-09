<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disminuir_Sueldo
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
        Dim IDEMPLEADOLabel As System.Windows.Forms.Label
        Dim SUELDOLabel As System.Windows.Forms.Label
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.DataSet1Oracle = New ProyectoEmpresa.DataSet1Oracle()
        Me.EMPLEADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADOTableAdapter = New ProyectoEmpresa.DataSet1OracleTableAdapters.EMPLEADOTableAdapter()
        Me.TableAdapterManager = New ProyectoEmpresa.DataSet1OracleTableAdapters.TableAdapterManager()
        Me.cboEmpleadoD = New System.Windows.Forms.ComboBox()
        Me.txtSueldoD = New System.Windows.Forms.TextBox()
        Me.btnDescontar = New System.Windows.Forms.Button()
        Me.DataSet1OracleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        IDEMPLEADOLabel = New System.Windows.Forms.Label()
        SUELDOLabel = New System.Windows.Forms.Label()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1Oracle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1OracleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDEMPLEADOLabel
        '
        IDEMPLEADOLabel.AutoSize = True
        IDEMPLEADOLabel.Location = New System.Drawing.Point(71, 16)
        IDEMPLEADOLabel.Name = "IDEMPLEADOLabel"
        IDEMPLEADOLabel.Size = New System.Drawing.Size(80, 13)
        IDEMPLEADOLabel.TabIndex = 2
        IDEMPLEADOLabel.Text = "IDEMPLEADO:"
        '
        'SUELDOLabel
        '
        SUELDOLabel.AutoSize = True
        SUELDOLabel.Location = New System.Drawing.Point(97, 65)
        SUELDOLabel.Name = "SUELDOLabel"
        SUELDOLabel.Size = New System.Drawing.Size(54, 13)
        SUELDOLabel.TabIndex = 4
        SUELDOLabel.Text = "SUELDO:"
        '
        'dgv3
        '
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3.Location = New System.Drawing.Point(12, 135)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.Size = New System.Drawing.Size(331, 276)
        Me.dgv3.TabIndex = 0
        '
        'DataSet1Oracle
        '
        Me.DataSet1Oracle.DataSetName = "DataSet1Oracle"
        Me.DataSet1Oracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADOBindingSource
        '
        Me.EMPLEADOBindingSource.DataMember = "EMPLEADO"
        Me.EMPLEADOBindingSource.DataSource = Me.DataSet1Oracle
        '
        'EMPLEADOTableAdapter
        '
        Me.EMPLEADOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DEPARTAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOTableAdapter = Me.EMPLEADOTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProyectoEmpresa.DataSet1OracleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cboEmpleadoD
        '
        Me.cboEmpleadoD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IDEMPLEADO", True))
        Me.cboEmpleadoD.DataSource = Me.EMPLEADOBindingSource1
        Me.cboEmpleadoD.DisplayMember = "IDEMPLEADO"
        Me.cboEmpleadoD.FormattingEnabled = True
        Me.cboEmpleadoD.Location = New System.Drawing.Point(157, 13)
        Me.cboEmpleadoD.Name = "cboEmpleadoD"
        Me.cboEmpleadoD.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpleadoD.TabIndex = 3
        Me.cboEmpleadoD.ValueMember = "IDEMPLEADO"
        '
        'txtSueldoD
        '
        Me.txtSueldoD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "SUELDO", True))
        Me.txtSueldoD.Location = New System.Drawing.Point(157, 62)
        Me.txtSueldoD.Name = "txtSueldoD"
        Me.txtSueldoD.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldoD.TabIndex = 5
        '
        'btnDescontar
        '
        Me.btnDescontar.Location = New System.Drawing.Point(138, 101)
        Me.btnDescontar.Name = "btnDescontar"
        Me.btnDescontar.Size = New System.Drawing.Size(75, 23)
        Me.btnDescontar.TabIndex = 6
        Me.btnDescontar.Text = "Actualizar"
        Me.btnDescontar.UseVisualStyleBackColor = True
        '
        'DataSet1OracleBindingSource
        '
        Me.DataSet1OracleBindingSource.DataSource = Me.DataSet1Oracle
        Me.DataSet1OracleBindingSource.Position = 0
        '
        'EMPLEADOBindingSource1
        '
        Me.EMPLEADOBindingSource1.DataMember = "EMPLEADO"
        Me.EMPLEADOBindingSource1.DataSource = Me.DataSet1OracleBindingSource
        '
        'Disminuir_Sueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 431)
        Me.Controls.Add(Me.btnDescontar)
        Me.Controls.Add(SUELDOLabel)
        Me.Controls.Add(Me.txtSueldoD)
        Me.Controls.Add(IDEMPLEADOLabel)
        Me.Controls.Add(Me.cboEmpleadoD)
        Me.Controls.Add(Me.dgv3)
        Me.Name = "Disminuir_Sueldo"
        Me.Text = "Disminuir_Sueldo"
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1Oracle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1OracleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv3 As DataGridView
    Friend WithEvents DataSet1Oracle As DataSet1Oracle
    Friend WithEvents EMPLEADOBindingSource As BindingSource
    Friend WithEvents EMPLEADOTableAdapter As DataSet1OracleTableAdapters.EMPLEADOTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1OracleTableAdapters.TableAdapterManager
    Friend WithEvents cboEmpleadoD As ComboBox
    Friend WithEvents txtSueldoD As TextBox
    Friend WithEvents btnDescontar As Button
    Friend WithEvents EMPLEADOBindingSource1 As BindingSource
    Friend WithEvents DataSet1OracleBindingSource As BindingSource
End Class
