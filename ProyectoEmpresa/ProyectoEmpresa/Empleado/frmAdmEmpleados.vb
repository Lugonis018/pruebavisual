Public Class frmAdmEmpleados
    Private Sub EMPLEADOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EMPLEADOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMPLEADOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1Oracle)

    End Sub

    Private Sub frmVerEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1Oracle.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.DataSet1Oracle.EMPLEADO)

    End Sub
End Class