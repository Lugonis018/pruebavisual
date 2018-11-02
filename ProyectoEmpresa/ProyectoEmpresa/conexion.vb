'Imports System.Data.OracleClient
Imports Oracle.ManagedDataAccess.Client

Module conexion

    Public cn As OracleConnection
    Public adaptador As OracleDataAdapter

    Friend Function conectar() As Oracle.ManagedDataAccess.Client.OracleConnection
        Throw New NotImplementedException()
    End Function

    Public dt As DataTable

    Sub abrirConexion()
        Try
            cn = New OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=UEMPRESA;USER ID=UEMPRESA")
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


End Module
