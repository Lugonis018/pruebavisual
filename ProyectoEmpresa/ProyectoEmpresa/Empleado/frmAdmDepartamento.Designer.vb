<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmDepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmDepartamento))
        Dim IDDEPARTAMENTOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Me.DataSet1Oracle = New ProyectoEmpresa.DataSet1Oracle()
        Me.DEPARTAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEPARTAMENTOTableAdapter = New ProyectoEmpresa.DataSet1OracleTableAdapters.DEPARTAMENTOTableAdapter()
        Me.TableAdapterManager = New ProyectoEmpresa.DataSet1OracleTableAdapters.TableAdapterManager()
        Me.DEPARTAMENTOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DEPARTAMENTOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDDEPARTAMENTOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        IDDEPARTAMENTOLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1Oracle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPARTAMENTOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DEPARTAMENTOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet1Oracle
        '
        Me.DataSet1Oracle.DataSetName = "DataSet1Oracle"
        Me.DataSet1Oracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DEPARTAMENTOBindingSource
        '
        Me.DEPARTAMENTOBindingSource.DataMember = "DEPARTAMENTO"
        Me.DEPARTAMENTOBindingSource.DataSource = Me.DataSet1Oracle
        '
        'DEPARTAMENTOTableAdapter
        '
        Me.DEPARTAMENTOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DEPARTAMENTOTableAdapter = Me.DEPARTAMENTOTableAdapter
        Me.TableAdapterManager.EMPLEADOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoEmpresa.DataSet1OracleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DEPARTAMENTOBindingNavigator
        '
        Me.DEPARTAMENTOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DEPARTAMENTOBindingNavigator.BindingSource = Me.DEPARTAMENTOBindingSource
        Me.DEPARTAMENTOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DEPARTAMENTOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DEPARTAMENTOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DEPARTAMENTOBindingNavigatorSaveItem})
        Me.DEPARTAMENTOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DEPARTAMENTOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DEPARTAMENTOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DEPARTAMENTOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DEPARTAMENTOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DEPARTAMENTOBindingNavigator.Name = "DEPARTAMENTOBindingNavigator"
        Me.DEPARTAMENTOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DEPARTAMENTOBindingNavigator.Size = New System.Drawing.Size(612, 25)
        Me.DEPARTAMENTOBindingNavigator.TabIndex = 0
        Me.DEPARTAMENTOBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'DEPARTAMENTOBindingNavigatorSaveItem
        '
        Me.DEPARTAMENTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DEPARTAMENTOBindingNavigatorSaveItem.Image = CType(resources.GetObject("DEPARTAMENTOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DEPARTAMENTOBindingNavigatorSaveItem.Name = "DEPARTAMENTOBindingNavigatorSaveItem"
        Me.DEPARTAMENTOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DEPARTAMENTOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IDDEPARTAMENTOLabel
        '
        IDDEPARTAMENTOLabel.AutoSize = True
        IDDEPARTAMENTOLabel.Location = New System.Drawing.Point(102, 83)
        IDDEPARTAMENTOLabel.Name = "IDDEPARTAMENTOLabel"
        IDDEPARTAMENTOLabel.Size = New System.Drawing.Size(111, 13)
        IDDEPARTAMENTOLabel.TabIndex = 1
        IDDEPARTAMENTOLabel.Text = "IDDEPARTAMENTO:"
        '
        'IDDEPARTAMENTOTextBox
        '
        Me.IDDEPARTAMENTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DEPARTAMENTOBindingSource, "IDDEPARTAMENTO", True))
        Me.IDDEPARTAMENTOTextBox.Location = New System.Drawing.Point(219, 80)
        Me.IDDEPARTAMENTOTextBox.Name = "IDDEPARTAMENTOTextBox"
        Me.IDDEPARTAMENTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDDEPARTAMENTOTextBox.TabIndex = 2
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(102, 109)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 3
        NOMBRELabel.Text = "NOMBRE:"
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DEPARTAMENTOBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(219, 106)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRETextBox.TabIndex = 4
        '
        'frmAdmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 321)
        Me.Controls.Add(IDDEPARTAMENTOLabel)
        Me.Controls.Add(Me.IDDEPARTAMENTOTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(Me.DEPARTAMENTOBindingNavigator)
        Me.Name = "frmAdmEmpleado"
        Me.Text = "frmAdmEmpleado"
        CType(Me.DataSet1Oracle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPARTAMENTOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DEPARTAMENTOBindingNavigator.ResumeLayout(False)
        Me.DEPARTAMENTOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1Oracle As DataSet1Oracle
    Friend WithEvents DEPARTAMENTOBindingSource As BindingSource
    Friend WithEvents DEPARTAMENTOTableAdapter As DataSet1OracleTableAdapters.DEPARTAMENTOTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1OracleTableAdapters.TableAdapterManager
    Friend WithEvents DEPARTAMENTOBindingNavigator As BindingNavigator
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
    Friend WithEvents DEPARTAMENTOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDDEPARTAMENTOTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
End Class
