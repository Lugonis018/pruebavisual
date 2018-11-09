'Imports System.Data.OracleClient

Imports Oracle.ManagedDataAccess.Client


Public Class Aumentar_Sueldo

    Dim sql As String


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Agregar_Sueldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1Oracle.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.DataSet1Oracle.EMPLEADO)

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim IdEmpleado, Cantidad As String
        IdEmpleado = cboEmpleado.SelectedValue.ToString
        Cantidad = TextBox1.Text


        sp_aumentar_sueldo(IdEmpleado, Cantidad)

        TextBox1.Text = ""
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        sql = "Select * from EMPLEADO"
        llenarDataGridView(dgv2, sql)
    End Sub








End Class