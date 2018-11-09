Imports System.Data.OracleClient
'Imports Oracle.ManagedDataAccess.Client

Module conexion

    Public cn As OracleConnection
    Public adaptador As OracleDataAdapter
    Public comando As OracleCommand

    Friend Function conectar() As Oracle.ManagedDataAccess.Client.OracleConnection
        Throw New NotImplementedException()
    End Function

    Public dt As DataTable

    Sub abrirConexion()
        Try
            cn = New OracleConnection("DATA SOURCE=197.168.1.8:1521/xe;PASSWORD=UEMPRESA;USER ID=UEMPRESA")
            cn.Open()
            MessageBox.Show("CONECTADO")
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar:" + ex.ToString)
        End Try
    End Sub

    Sub llenarDataGridView(ByVal dgv As DataGridView, consulta As String)
        Try
            adaptador = New OracleDataAdapter(consulta, cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se llenar la tabla:" + ex.ToString)
        End Try

    End Sub
    Sub sp_aumentar_sueldo(IdEmpleado As Integer, Cantidad As Integer)
        Try
            comando = New OracleCommand("SP_AUMENTAR_SUELDO", cn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("P_IDEMPLEADO", IdEmpleado)
            comando.Parameters.AddWithValue("P_AUMENTO", Cantidad)

            comando.ExecuteNonQuery()
            MsgBox("SUELDO AUMENTADO CORRECTAMENTE")
        Catch ex As Exception
            MessageBox.Show("ERROR")
        End Try
    End Sub

End Module
