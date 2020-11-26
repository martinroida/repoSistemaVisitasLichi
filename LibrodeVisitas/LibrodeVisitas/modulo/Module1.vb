Module Module1
    Public conexion As New SqlClient.SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbLibroVisitas;Data Source=PC-ROIDA-PEÑALV\SQLEXPRESS")

    'PARA DEFINIR LOS COMANDOS ADAPTADORES Y DATAREADER CON SQL

    Public comando As New SqlClient.SqlCommand
    Public adaptador As New SqlClient.SqlDataAdapter
    Public datareader As SqlClient.SqlDataReader
    Public seteodedatos As New DataSet
    Public tabladedatos As New DataTable
    Public lectorDatos As SqlClient.SqlDataReader

End Module
