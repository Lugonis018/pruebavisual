Public Class FrmPrincipal
    Dim consulta As String
    Private Sub VerEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerEmpleadosToolStripMenuItem.Click
        consulta = "Select * from EMPLEADO"
        llenarDataGridView(dgv, consulta)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()

    End Sub

    Private Sub VerRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerRegistroToolStripMenuItem.Click
        consulta = "SELECT IDEMPLEADO, EMPLEADO.NOMBRE, SUELDO, DEPARTAMENTO.NOMBRE FROM EMPLEADO INNER JOIN DEPARTAMENTO ON EMPLEADO.IDDPTO=DEPARTAMENTO.IDDEPARTAMENTO"
        llenarDataGridView(dgv, consulta)

    End Sub

    Private Sub VerDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerDepartamentoToolStripMenuItem.Click
        consulta = "Select * from DEPARTAMENTO"
        llenarDataGridView(dgv, consulta)
    End Sub

    Private Sub AdministrarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarEmpleadosToolStripMenuItem.Click
        Call frmAdmEmpleados.Show()
    End Sub

    Private Sub AdministrarDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarDepartamentoToolStripMenuItem.Click
        Call frmAdmDepartamento.Show()
    End Sub

    Private Sub SPDisminuirMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPDisminuirMatriculaToolStripMenuItem.Click
        Call Aumentar_Sueldo.Show()
    End Sub
End Class