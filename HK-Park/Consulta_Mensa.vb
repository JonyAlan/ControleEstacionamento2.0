Imports System.Data.OleDb


Public Class Consulta_Mensa

    Private Sub ConsultAb()
        Using con As OleDbConnection = GetConnectionAcess()
            Try
                con.Open()
                Dim sql As String = "SELECT Nome, Placa, DiaVencimento as Dia, Telefone, Valor FROM MENSALISTAS WHERE Situacao is NULL "
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DtGdados.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub


    Private Sub ConsultPG()
        Using con As OleDbConnection = GetConnectionAcess()
            Try
                con.Open()
                Dim sql As String = "SELECT Nome, Placa,DiaVencimento as Dia, Telefone, Valor FROM MENSALISTAS WHERE Situacao = 'PG' "
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DtGdados.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ConsultTt()
        Using con As OleDbConnection = GetConnectionAcess()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM MENSALISTAS"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DtGdados.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RdBAberto.Checked Then
            ConsultAb()
        End If

        If RdBPagos.Checked Then
            ConsultPG()
        End If

        If RdBtodos.Checked Then
            ConsultTt()
        End If

    End Sub

End Class