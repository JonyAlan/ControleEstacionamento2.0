
Imports System.Data.OleDb


Module mdlAcesso

    Public tempS As String
    Public HoraEn As Date
    Public HoraSai As Date
    Public ValorPg As Integer
    Public TIPOPAG As String



    Public Function GetConnectionAcess() As OleDbConnection

        Dim sql As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Anonimous\Documents\Visual Studio 2013\Projects\HK-Park\dados.accdb.accdb"
        Return New OleDbConnection(sql)


    End Function



End Module
