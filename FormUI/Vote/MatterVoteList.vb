Public Class MatterVoteList


    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        filldgv()
    End Sub

    Private Sub MatterVoteList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainform
        filldgv()
    End Sub
    Private Sub filldgv()
        Dim t As New DataTable
        Try
            Dim HolderIdentify As String
            Dim mattcode As Integer = 0
            Dim delecode As Integer = 0
            Try
                mattcode = ToolStripTextBox1.Text
            Catch ex As Exception
                mattcode = 0
            End Try
            Try
                HolderIdentify = ToolStripTextBox2.Text
            Catch ex As Exception
                HolderIdentify = ""
            End Try
            Try
                delecode = ToolStriptxtDbCode.Text
            Catch ex As Exception
                delecode = 0
            End Try

            t = Mainform.BenlyDal.MatterVotes_getlist(Mainform.workingmeeting, mattcode, HolderIdentify, delecode)

        Catch ex As Exception
            MsgBox("Lỗi :" + ex.Message)
        End Try

        Dim totalright As Decimal = 0
        Dim agreecount As Decimal = 0
        Dim agreeright As Decimal = 0
        Dim disagreecount As Decimal = 0
        Dim disagreeright As Decimal = 0
        Dim noideacount As Decimal = 0
        Dim noidearight As Decimal = 0
        Dim illegalacount As Decimal = 0
        Dim illegalright As Decimal = 0

        For Each dr As DataRow In t.Rows

            Try
                totalright = totalright + dr.Item("Voterights")
            Catch ex As Exception
                MsgBox("Lỗi :" + ex.Message)
            End Try

            If dr.Item("Agree") = True Then
                agreecount = agreecount + 1
                agreeright = agreeright + dr.Item("Voterights")
            ElseIf dr.Item("DisAgree") = True Then
                disagreecount = disagreecount + 1
                disagreeright = disagreeright + dr.Item("Voterights")
            ElseIf dr.Item("NoIdea") = True Then
                noideacount = noideacount + 1
                noidearight = noidearight + dr.Item("NoIdea")
            ElseIf dr.Item("Illegal") = True Then
                illegalacount = illegalacount + 1
                illegalright = illegalright + dr.Item("Voterights")
            End If
        Next
        DataGridView1.DataSource = t
        ToolStripStatusLabel2.Text = DataGridView1.RowCount
        ToolStripStatusLabel16.Text = Mainform.addthousandseperator(totalright.ToString)

        '--------
        ToolStripStatusLabel4.Text = Mainform.addthousandseperator(agreecount.ToString) + " -- "
        ToolStripStatusLabel5.Text = Mainform.addthousandseperator(agreeright.ToString) + " -- "
        ToolStripStatusLabel8.Text = Mainform.addthousandseperator(disagreecount.ToString) + " -- "
        ToolStripStatusLabel9.Text = Mainform.addthousandseperator(disagreeright.ToString) + " -- "

        ToolStripStatusLabel12.Text = Mainform.addthousandseperator(noideacount.ToString) + " -- "
        ToolStripStatusLabel13.Text = Mainform.addthousandseperator(noidearight.ToString) + " -- "


        If totalright > 0 Then
            ToolStripStatusLabel6.Text = (Math.Round(((agreeright / totalright) * 100), 2)).ToString + "% "
            ToolStripStatusLabel10.Text = (Math.Round(((disagreeright / totalright) * 100), 2)).ToString + "% "
            ToolStripStatusLabel14.Text = (Math.Round(((noidearight / totalright) * 100), 2)).ToString + "% "
            Dim tyleIllegal As Decimal = Math.Round(((illegalright / totalright) * 100), 2)
            '--------Hop lệ
            txtCounthople.Text = "Số phiếu hợp lệ:" + (DataGridView1.RowCount - illegalacount).ToString() + "đại biểu - với tổng số quyền hợp lệ: " + (totalright - illegalright).ToString("#,###") + " - chiếm tỷ lệ:" + (100 - tyleIllegal).ToString() + "% "
            '--------Không Hoplệ
            txtRighthl.Text = "Số phiếu hợp lệ:" + illegalacount.ToString() + " đại biểu - với tống số quyền không hợp lệ: " + illegalright.ToString("#,###") + " - chiếm tỷ lệ:" + tyleIllegal.ToString() + "% "
        Else
            ToolStripStatusLabel6.Text = ""
            ToolStripStatusLabel10.Text = ""
            ToolStripStatusLabel14.Text = ""
            txtCounthople.Text = ""
            txtRighthl.Text = ""
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim matcode As Integer = 0
        Dim delecode As Integer = 0
        Try
            matcode = ToolStripTextBox1.Text
        Catch ex As Exception
            matcode = 0
        End Try
        Try
            delecode = ToolStripTextBox2.Text
        Catch ex As Exception
            delecode = 0
        End Try
        Dim f As New Mattervote_ins_update("Add", matcode, delecode)
        f.ShowDialog()
        filldgv()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim f As New Mattervote_ins_update("Update", DataGridView1.CurrentRow.Cells("Mattercode").Value, DataGridView1.CurrentRow.Cells("delegatecode").Value)
        f.ShowDialog()
        filldgv()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Bạn phải chọn ít nhất một bản ghi")
            Exit Sub
        End If
        If MsgBox("Bạn có chắc chắn XÓA Phiếu biểu quyết vấn đề :" + DataGridView1.CurrentRow.Cells("mattername").Value + " của đb " + DataGridView1.CurrentRow.Cells("Delegatename").Value, MsgBoxStyle.OkCancel + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal + MsgBoxStyle.DefaultButton2, "XÓA PHIẾU BIỂU QUYẾT") = MsgBoxResult.Ok Then
            Try
                Mainform.BenlyDal.MatterVotes_delete(Mainform.workingmeeting, DataGridView1.CurrentRow.Cells("Mattercode").Value, DataGridView1.CurrentRow.Cells("delegatecode").Value, DataGridView1.CurrentRow.Cells("HolderCode").Value)
            Catch ex As Exception
                MsgBox("Lỗi :" + ex.Message)
            End Try
        End If
        filldgv()
    End Sub

    Private Sub MatterVoteList_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If Not (ToolStripTextBox1.Focused Or ToolStripTextBox2.Focused) Then
            Select Case e.KeyCode
                Case Keys.A
                    ToolStripButton1_Click(sender, e)
                Case Keys.E
                    ToolStripButton2_Click(sender, e)
                Case Keys.D
                    ToolStripButton3_Click(sender, e)
                Case Keys.Escape
                    Me.Close()
            End Select
        End If

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim colName = DataGridView1.Columns(e.ColumnIndex).Name
            If colName = "Agree" OrElse colName = "Disagree" OrElse colName = "Noidea" OrElse colName = "Illegal" Then
                Try
                    ' mattercode As Decimal, ByVal delegatecode As Decimal, ByVal Agree As Boolean, ByVal disAgree As Boolean, ByVal noidea As Boolean)
                    Dim row = DataGridView1.Rows(e.RowIndex)
                    Dim mattercode = row.Cells("Mattercode").Value
                    Dim delegatecode = row.Cells("DelegateCode").Value
                    Dim agree = False
                    Dim disagree = False
                    Dim noidea = False
                    Dim illegal = False
                    ' Nếu chọn Agree
                    If colName = "Agree" AndAlso CBool(row.Cells("Agree").Value) = True Then
                        row.Cells("Disagree").Value = False
                        row.Cells("Noidea").Value = False
                        row.Cells("Illegal").Value = False
                        agree = True
                        noidea = False
                        disagree = False
                        illegal = False
                        ' Nếu chọn Disagree
                    ElseIf colName = "Disagree" AndAlso CBool(row.Cells("Disagree").Value) = True Then
                        row.Cells("Agree").Value = False
                        row.Cells("Noidea").Value = False
                        row.Cells("Illegal").Value = False
                        disagree = True
                        noidea = False
                        agree = False
                        illegal = False
                        ' Nếu chọn Noidea
                    ElseIf colName = "Noidea" AndAlso CBool(row.Cells("Noidea").Value) = True Then
                        row.Cells("Agree").Value = False
                        row.Cells("Disagree").Value = False
                        row.Cells("Illegal").Value = False
                        noidea = True
                        disagree = False
                        agree = False
                        illegal = False
                        ' Nếu chọn Illegal
                    ElseIf colName = "Illegal" AndAlso CBool(row.Cells("Illegal").Value) = True Then
                        row.Cells("Agree").Value = False
                        row.Cells("Disagree").Value = False
                        row.Cells("Noidea").Value = False
                        illegal = True
                        disagree = False
                        agree = False
                        noidea = False
                    End If
                    Mainform.BenlyDal.MatterVotes_update(Mainform.workingmeeting, mattercode, delegatecode, agree, disagree, noidea, illegal)
                    filldgv()
                    DataGridView1.Refresh()
                Catch ex As Exception
                    MsgBox("Lỗi :" + ex.Message)
                End Try

            End If
        End If
    End Sub


    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripButton4_Click(sender, e)
        End If
    End Sub

    Private Sub ToolStripTextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripButton4_Click(sender, e)
        End If
    End Sub

    Private Sub ToolStriptxtDbCode_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStriptxtDbCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripButton4_Click(sender, e)
        End If
    End Sub
End Class