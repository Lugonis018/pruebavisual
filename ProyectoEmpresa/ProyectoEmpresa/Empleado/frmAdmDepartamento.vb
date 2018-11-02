Public Class frmAdmDepartamento
    Private Sub DEPARTAMENTOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DEPARTAMENTOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DEPARTAMENTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1Oracle)

    End Sub

    Private Sub frmAdmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1Oracle.DEPARTAMENTO' Puede moverla o quitarla según sea necesario.
        Me.DEPARTAMENTOTableAdapter.Fill(Me.DataSet1Oracle.DEPARTAMENTO)

    End Sub
End Class