Imports MySql.Data.MySqlClient
Public Class ConexaoBanco
    Public cn As New MySqlConnection
    Public status As String = ""

    Public Sub conectar()
        Dim stringConnection As String = ""
        stringConnection = "server=localhost; Database=consulta_cep; Uid=root; Pwd=eagle;"
        cn.ConnectionString = stringConnection
        cn.Open()
    End Sub
    Public Sub desconectar()
        cn.Clone()
        status = "Conexão Fechada"
    End Sub

End Class
