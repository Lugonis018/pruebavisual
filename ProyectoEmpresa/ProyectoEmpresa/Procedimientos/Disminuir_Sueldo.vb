Public Class Disminuir_Sueldo
    Dim Sql As String


    Private Sub EMPLEADOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EMPLEADOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1Oracle)

    End Sub

    Private Sub Disminuir_Sueldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1Oracle.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.DataSet1Oracle.EMPLEADO)
        Sql = "Select * from EMPLEADO"
        llenarDataGridView(dgv3, Sql)
        txtSueldoD.Text = ""
    End Sub

    Private Sub btnDescontar_Click(sender As Object, e As EventArgs) Handles btnDescontar.Click
        Dim IdEmpleado, Cantidad As String
        IdEmpleado = cboEmpleadoD.SelectedValue.ToString
        Cantidad = txtSueldoD.Text


        sp_disminuir_sueldo(IdEmpleado, Cantidad)

        txtSueldoD.Text = ""
        Sql = "Select * from EMPLEADO"
        llenarDataGridView(dgv3, Sql)
    End Sub
End Class