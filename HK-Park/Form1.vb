Imports System.Data.OleDb
Imports System.Data



Public Class Form1


    Private Sub ConsultCar()
        Dim dr As OleDbDataReader = Nothing

        Using ins As OleDbConnection = GetConnectionAcess()
            Try

                ins.Open()

                Dim sql As String = "SELECT PLACA, HORAEN FROM AVULSO WHERE PLACA = '" & MskdBSai.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, ins)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    HoraEn = dr.Item("HORAEN")
                    BtnScart.Enabled = True
                    btnSdin.Enabled = True

                Else
                    MsgBox("veiculo não encontrado")
                    HoraEn = Now
                    BtnScart.Enabled = False
                    btnSdin.Enabled = False


                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ins.Close()
            End Try
        End Using
    End Sub


    Private Sub InseriCar()
        Using ins As OleDbConnection = GetConnectionAcess()
            Try

                ins.Open()

                Dim sql As String = "INSERT INTO AVULSO(PLACA,HORAEN) VALUES ('" & MktxtPlaent.Text & "','" & Now & "')"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, ins)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtgrPatio.DataSource = dt
                AtualizPat()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ins.Close()
            End Try
        End Using
    End Sub

    Private Sub SaidaCar()
        Using ins As OleDbConnection = GetConnectionAcess()
            Try

                ins.Open()
                Dim sql As String = "INSERT INTO AVU_SAIDA(PLACA,HORAEN,HORASAI,PAGAMENTO,VALORPG) VALUES ('" & MskdBSai.Text & "','" & HoraEn & "', '" & HoraSai & "','" & TIPOPAG & "', '" & ValorPg & "')"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, ins)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtgrPatio.DataSource = dt
                AtualizPat()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ins.Close()
            End Try
        End Using
    End Sub
    Private Sub ExcludeCar()
        Using ins As OleDbConnection = GetConnectionAcess()
            Try

                ins.Open()
                Dim sql As String = "DELETE * FROM AVULSO WHERE PLACA = '" & MskdBSai.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, ins)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtgrPatio.DataSource = dt
                AtualizPat()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ins.Close()
            End Try
        End Using
    End Sub
    Private Sub SaidaCarHot()
        Using ins As OleDbConnection = GetConnectionAcess()
            Try

                ins.Open()
                Dim sql As String = "UPDATE AVULSO SET SITUACAO = 'Hotel', HORASAI ='" & HoraSai & "',VALORPG ='" & ValorPg & "' WHERE PLACA = '" & MskdBSai.Text & "' "
                Dim cmd As OleDbCommand = New OleDbCommand(sql, ins)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtgrPatio.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ins.Close()
            End Try
        End Using
    End Sub
    Private Sub AtualizPat()
        Using ins As OleDbConnection = GetConnectionAcess()
            Try
                ins.Open()
                Dim sql As String = "SELECT PLACA, HORAEN as DIA_HORA FROM AVULSO"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, ins)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtgrPatio.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ins.Close()
            End Try
        End Using
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        Consulta_Mensa.Show()
    End Sub

    Private Sub CadastrarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarUsuárioToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MktxtPlaent.Text <> "" Then
            InseriCar()
            MktxtPlaent.Text = ""
        Else
            MsgBox("Preencha a Placa do Veiculo")
        End If




    End Sub

    Private Sub TimerSis_Tick(sender As Object, e As EventArgs) Handles TimerSis.Tick
        lblhora.Text = TimeString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldta.Text = Today
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim result As Integer

        ConsultCar()

        HoraSai = Now

            result = DateDiff("n", HoraEn, HoraSai)


            If RdBCarG.Checked Then

            If result < 2 Then
                Lbltotal.Text = "0,00"
                TIPOPAG = "Cartão"
                ValorPg = 0
                SaidaCar()
                ExcludeCar()
                MskdBSai.Text = ""
            ElseIf result > 2 And result < 15 Then
                Lbltotal.Text = "2,00"
                ValorPg = 2
            ElseIf result >= 15 And result < 35 Then
                Lbltotal.Text = "5,00"
                ValorPg = 5
            ElseIf result >= 35 And result < 65 Then
                Lbltotal.Text = "7,00"
                ValorPg = 7
            ElseIf result >= 65 Then
                Lbltotal.Text = "12,00"
                ValorPg = 12

            End If


            ElseIf RdBCarP.Checked Then
                If result < 2 Then
                Lbltotal.Text = "0,00"
                TIPOPAG = "Carência"
                ValorPg = 0
                SaidaCar()
                ExcludeCar()
                MskdBSai.Text = ""
                ElseIf result > 2 And result < 15 Then
                    Lbltotal.Text = "2,00"
                    ValorPg = 2
                ElseIf result >= 15 And result < 35 Then
                    Lbltotal.Text = "3,00"
                    ValorPg = 5
                ElseIf result >= 35 And result < 65 Then
                    Lbltotal.Text = "5,00"
                    ValorPg = 7
                ElseIf result >= 65 Then
                    Lbltotal.Text = "10,00"
                    ValorPg = 12

                End If

            ElseIf RdBHot.Checked Then
                MsgBox("NÃO COBRAR")
                Lbltotal.Text = "0,00"
                ValorPg = 0
                SaidaCarHot()
                MskdBSai.Text = ""

            ElseIf RdBPern.Checked Then
                Lbltotal.Text = "12,00"
            ValorPg = 12
            SaidaCarHot()
            MskdBSai.Text = ""


            ElseIf RdBMot.Checked Then
                If result < 2 Then
                Lbltotal.Text = "0,00"
                ValorPg = 0
                SaidaCar()
                ExcludeCar()
                MskdBSai.Text = ""

                ElseIf result >= 2 And result < 60 Then
                    Lbltotal.Text = "3,00"
                    ValorPg = 3
                ElseIf result >= 65 And result < 125 Then
                    Lbltotal.Text = "5,00"
                    ValorPg = 5
                ElseIf result >= 125 Then
                    Lbltotal.Text = "7,00"
                    ValorPg = 7

                End If
            Else
                MsgBox("Selecione o tipo de saída")

            End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSdin.Click
        TIPOPAG = "Dinheiro"
        SaidaCar()
        ExcludeCar()
        AtualizPat()
        MskdBSai.Text = ""
        ValorPg = 0
        Lbltotal.Text = "0,00"
        BtnScart.Enabled = False
        btnSdin.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnScart.Click

        TIPOPAG = "Cartão"
        SaidaCar()
        ExcludeCar()
        AtualizPat()
        MskdBSai.Text = ""
        ValorPg = 0
        Lbltotal.Text = "0,00"
        BtnScart.Enabled = False
        btnSdin.Enabled = False
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        txtBcadMensV3.Show()
    End Sub
End Class
