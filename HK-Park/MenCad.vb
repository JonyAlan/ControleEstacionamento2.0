Imports System.Data.OleDb
Imports System.Data

Public Class txtBcadMensV3

    Private Sub InseriMens()
        Using ins As OleDbConnection = GetConnectionAcess()
            Try

                ins.Open()

                Dim sql As String = "INSERT INTO MENSALISTAS(NOME,CPFMENS,DIAVENCIMENTO,VALOR,TELEFONE) VALUES ('" & txtCadMenNo.Text & "','" & mskBcadMenCpf.Text & "','" & txtBcadMenDiaV.Text & "','" & MskBcadMensV.Text & "','" & mskBcadMenTel.Text & "')"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, ins)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)



            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ins.Close()
            End Try
        End Using
    End Sub

    Private Sub InseriCarMens()
        Using ins As OleDbConnection = GetConnectionAcess()
            Try

                ins.Open()

                Dim sql As String = "INSERT INTO VEICULOMENS(CPFMENS,MODELOCARMENS,PLACAMENS) VALUES ('" & mskBcadMenCpf.Text & "','" & txtBcadMenModelC.Text & "','" & mskBcadMenPla1.Text & "')"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, ins)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                ins.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGravarMens.Click

        If txtCadMenNo.Text = "" Then
            MsgBox("Preencha o Nome")

        ElseIf mskBcadMenCpf.Text.Trim = "" Then
            MsgBox("Preencha o CPF")

        ElseIf mskBcadMenTel.Text.Trim = "" Then
            MsgBox("preecha o numero de Telefone")

        ElseIf MskBcadMensV.Text.Trim = "" Then
            MsgBox("Preencha o Valor da mensalidade")

        ElseIf txtBcadMenDiaV.Text = "" Then
            MsgBox("Preencha o dia de vencimento")
        Else
            InseriMens()
            gpBVeiculo.Enabled = True
            txtCadMenNo.Enabled = False
            mskBcadMenCpf.Enabled = False
            mskBcadMenTel.Enabled = False
            MskBcadMensV.Enabled = False
            txtBcadMenDiaV.Enabled = False
            btnGravarMens.Enabled = False
            btnLimparMens.Enabled = False
            btnFinalizarMens.Enabled = False


        End If




    End Sub

    Private Sub txtBcadMensV3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnFinalizarMens.Click

        txtCadMenNo.Text = ""
        mskBcadMenCpf.Text = ""
        mskBcadMenTel.Text = ""
        MskBcadMensV.Text = ""
        txtBcadMenDiaV.Text = ""

        gpBVeiculo.Enabled = False
        btnGravarMens.Enabled = True
        btnLimparMens.Enabled = True
        btnFinalizarMens.Enabled = True

        gpBVeiculo.Enabled = False
        txtCadMenNo.Enabled = True
        mskBcadMenCpf.Enabled = True
        mskBcadMenTel.Enabled = True
        MskBcadMensV.Enabled = True
        txtBcadMenDiaV.Enabled = True



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLimparMens.Click
        txtCadMenNo.Text = ""
        mskBcadMenCpf.Text = ""
        mskBcadMenTel.Text = ""
        MskBcadMensV.Text = ""
        txtBcadMenDiaV.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnInser.Click

        InseriCarMens()
        MsgBox("Veiculo Grvado !!!")
        txtBcadMenModelC.Text = ""
        mskBcadMenPla1.Text = ""
        btnFinalizarMens.Enabled = True

    End Sub
End Class