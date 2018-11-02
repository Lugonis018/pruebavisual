<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmEmpleados
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmEmpleados))
        Dim IDEMPLEADOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim SUELDOLabel As System.Windows.Forms.Label
        Dim IDSUPERVISORLabel As System.Windows.Forms.Label
        Dim IDDPTOLabel As System.Windows.Forms.Label
        Me.DataSet1Oracle = New ProyectoEmpresa.DataSet1Oracle()
        Me.EMPLEADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADOTableAdapter = New ProyectoEmpresa.DataSet1OracleTableAdapters.EMPLEADOTableAdapter()
        Me.TableAdapterManager = New ProyectoEmpresa.DataSet1OracleTableAdapters.TableAdapterManager()
        Me.EMPLEADOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EMPLEADOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDEMPLEADOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.SUELDOTextBox = New System.Windows.Forms.TextBox()
        Me.IDSUPERVISORTextBox = New System.Windows.Forms.TextBox()
        Me.IDDPTOTextBox = New System.Windows.Forms.TextBox()
        IDEMPLEADOLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        SUELDOLabel = New System.Windows.Forms.Label()
        IDSUPERVISORLabel = New System.Windows.Forms.Label()
        IDDPTOLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1Oracle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMPLEADOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        'EMPLEADOBindingNavigator
        '
        Me.EMPLEADOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EMPLEADOBindingNavigator.BindingSource = Me.EMPLEADOBindingSource
        Me.EMPLEADOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EMPLEADOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EMPLEADOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EMPLEADOBindingNavigatorSaveItem})
        Me.EMPLEADOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EMPLEADOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EMPLEADOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EMPLEADOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EMPLEADOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EMPLEADOBindingNavigator.Name = "EMPLEADOBindingNavigator"
        Me.EMPLEADOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EMPLEADOBindingNavigator.Size = New System.Drawing.Size(599, 25)
        Me.EMPLEADOBindingNavigator.TabIndex = 0
        Me.EMPLEADOBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EMPLEADOBindingNavigatorSaveItem
        '
        Me.EMPLEADOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EMPLEADOBindingNavigatorSaveItem.Image = CType(resources.GetObject("EMPLEADOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EMPLEADOBindingNavigatorSaveItem.Name = "EMPLEADOBindingNavigatorSaveItem"
        Me.EMPLEADOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EMPLEADOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IDEMPLEADOLabel
        '
        IDEMPLEADOLabel.AutoSize = True
        IDEMPLEADOLabel.Location = New System.Drawing.Point(211, 101)
        IDEMPLEADOLabel.Name = "IDEMPLEADOLabel"
        IDEMPLEADOLabel.Size = New System.Drawing.Size(80, 13)
        IDEMPLEADOLabel.TabIndex = 1
        IDEMPLEADOLabel.Text = "IDEMPLEADO:"
        '
        'IDEMPLEADOTextBox
        '
        Me.IDEMPLEADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IDEMPLEADO", True))
        Me.IDEMPLEADOTextBox.Location = New System.Drawing.Point(308, 98)
        Me.IDEMPLEADOTextBox.Name = "IDEMPLEADOTextBox"
        Me.IDEMPLEADOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDEMPLEADOTextBox.TabIndex = 2
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(211, 127)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 3
        NOMBRELabel.Text = "NOMBRE:"
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(308, 124)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRETextBox.TabIndex = 4
        '
        'SUELDOLabel
        '
        SUELDOLabel.AutoSize = True
        SUELDOLabel.Location = New System.Drawing.Point(211, 153)
        SUELDOLabel.Name = "SUELDOLabel"
        SUELDOLabel.Size = New System.Drawing.Size(54, 13)
        SUELDOLabel.TabIndex = 5
        SUELDOLabel.Text = "SUELDO:"
        '
        'SUELDOTextBox
        '
        Me.SUELDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "SUELDO", True))
        Me.SUELDOTextBox.Location = New System.Drawing.Point(308, 150)
        Me.SUELDOTextBox.Name = "SUELDOTextBox"
        Me.SUELDOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SUELDOTextBox.TabIndex = 6
        '
        'IDSUPERVISORLabel
        '
        IDSUPERVISORLabel.AutoSize = True
        IDSUPERVISORLabel.Location = New System.Drawing.Point(211, 179)
        IDSUPERVISORLabel.Name = "IDSUPERVISORLabel"
        IDSUPERVISORLabel.Size = New System.Drawing.Size(91, 13)
        IDSUPERVISORLabel.TabIndex = 7
        IDSUPERVISORLabel.Text = "IDSUPERVISOR:"
        '
        'IDSUPERVISORTextBox
        '
        Me.IDSUPERVISORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IDSUPERVISOR", True))
        Me.IDSUPERVISORTextBox.Location = New System.Drawing.Point(308, 176)
        Me.IDSUPERVISORTextBox.Name = "IDSUPERVISORTextBox"
        Me.IDSUPERVISORTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDSUPERVISORTextBox.TabIndex = 8
        '
        'IDDPTOLabel
        '
        IDDPTOLabel.AutoSize = True
        IDDPTOLabel.Location = New System.Drawing.Point(211, 205)
        IDDPTOLabel.Name = "IDDPTOLabel"
        IDDPTOLabel.Size = New System.Drawing.Size(51, 13)
        IDDPTOLabel.TabIndex = 9
        IDDPTOLabel.Text = "IDDPTO:"
        '
        'IDDPTOTextBox
        '
        Me.IDDPTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IDDPTO", True))
        Me.IDDPTOTextBox.Location = New System.Drawing.Point(308, 202)
        Me.IDDPTOTextBox.Name = "IDDPTOTextBox"
        Me.IDDPTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDDPTOTextBox.TabIndex = 10
        '
        'frmAdmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 325)
        Me.Controls.Add(IDEMPLEADOLabel)
        Me.Controls.Add(Me.IDEMPLEADOTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(SUELDOLabel)
        Me.Controls.Add(Me.SUELDOTextBox)
        Me.Controls.Add(IDSUPERVISORLabel)
        Me.Controls.Add(Me.IDSUPERVISORTextBox)
        Me.Controls.Add(IDDPTOLabel)
        Me.Controls.Add(Me.IDDPTOTextBox)
        Me.Controls.Add(Me.EMPLEADOBindingNavigator)
        Me.Name = "frmAdmEmpleados"
        Me.Text = "frmVerEmpleados"
        CType(Me.DataSet1Oracle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMPLEADOBindingNavigator.ResumeLayout(False)
        Me.EMPLEADOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1Oracle As DataSet1Oracle
    Friend WithEvents EMPLEADOBindingSource As BindingSource
    Friend WithEvents EMPLEADOTableAdapter As DataSet1OracleTableAdapters.EMPLEADOTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1OracleTableAdapters.TableAdapterManager
    Friend WithEvents EMPLEADOBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EMPLEADOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDEMPLEADOTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents SUELDOTextBox As TextBox
    Friend WithEvents IDSUPERVISORTextBox As TextBox
    Friend WithEvents IDDPTOTextBox As TextBox
End Class
