'Imports System.Data.OracleClient

Imports Oracle.ManagedDataAccess.Client


Public Class Aumentar_Sueldo
    Public conexion As OracleConnection
    Dim sql As String
    Dim com As OracleCommand, dr As OracleDataReader

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Agregar_Sueldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1Oracle.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.DataSet1Oracle.EMPLEADO)

    End Sub

    Public Sub conectar()
        conexion = New OracleConnection
        conexion.ConnectionString = ("DATA SOURCE=localhost:1521/xe;PASSWORD=UEMPRESA;USER ID=UEMPRESA")
        conexion.Open()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim IdEmpleado As String
        IdEmpleado = cboEmpleado.SelectedValue.ToString
        Dim Cantidad As String
        Cantidad = txtCantidad.Text
        Try

            sql = "EXECUTE SP_AUMENTAR_SUELDO( '" + IdEmpleado + "','" + Cantidad + "')"


            conectar()
            com = New OracleCommand(sql, conexion)
            dr = com.ExecuteReader

            MsgBox("Se aumentó el sueldo correctamente", MessageBoxButtons.OK)
        Catch ex As Exception
            MsgBox("No se realizo el aumento de sueldo correctamente", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        sql = "Select * from EMPLEADO"
        llenarDataGridView(dgv2, sql)
    End Sub








End Class