Public Class Mattervote_ins_update
    Dim controlcode As String
    Dim updatemattercode As Integer
    Dim updatedelegatecode As Integer
    Dim isLoading As Boolean = True
    Public Sub New(ByVal controlcode As String, ByVal mattercode As Integer, ByVal delegatecode As Integer)
        Me.controlcode = controlcode
        Me.updatemattercode = mattercode
        Me.updatedelegatecode = delegatecode
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Mattervote_ins_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoading = True
        MaskedTextBox1.Text = Mainform.workingmeeting
        NumericUpDown1.Value = CDec(1)

        If controlcode = "Update" Then
            Button1.Text = "Cập nhật"
            Me.Text = "Cập nhật phiếu biểu quyết"
            Dim dt1 As New DataTable
            Try
                dt1 = Mainform.BenlyDal.Matter_getlist(Mainform.workingmeeting, updatemattercode)
            Catch ex As Exception
                MsgBox("Lỗi :" + ex.Message)
                Exit Sub
            End Try
            Dim dt2 As New DataTable
            Try
                dt2 = Mainform.BenlyDal.Delegate_getlist(Mainform.workingmeeting, updatedelegatecode, "")
            Catch ex As Exception
                MsgBox("Lỗi :" + ex.Message)
                Exit Sub
            End Try
            'NumericUpDown1.Value = CDec(dt1.Rows(0).Item("Mattercode"))
            Dim val = dt1.Rows(0).Item("Mattercode")
            If Not IsDBNull(val) AndAlso IsNumeric(val.ToString()) Then
                NumericUpDown1.Value = CDec(val)
            Else
                NumericUpDown1.Value = 1
            End If
            MaskedTextBox3.Text = dt1.Rows(0).Item("Mattername")
            NumericUpDown1.ReadOnly = True


            Dim delegatecode = dt2.Rows(0).Item("Delegatecode")
            HolderCodeMaskedTextBox.Text = delegatecode
            HolderIdentifyMaskedTextBox2.Text = dt2.Rows(0).Item("IdentityCard")
            MaskedTextBox4.Text = dt2.Rows(0).Item("Delegatename")
            HolderCodeMaskedTextBox.ReadOnly = True
            HolderIdentifyMaskedTextBox2.ReadOnly = True

            Try
                Dim dt3 As New DataTable
                dt3 = Mainform.BenlyDal.MatterVotes_getlist(Mainform.workingmeeting, updatemattercode, "", delegatecode)
                RadioButton1.Checked = dt3.Rows(0).Item("Agree")
                RadioButton2.Checked = dt3.Rows(0).Item("DisAgree")
                RadioButton3.Checked = dt3.Rows(0).Item("Noidea")
                RadioButton3.Checked = dt3.Rows(0).Item("Illegal")
            Catch ex As Exception
                MsgBox("Lỗi :" + ex.Message)
                Exit Sub
            End Try
            Button2.Visible = False
            CheckBox1.Visible = False

        End If
        isLoading = False
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Dim dt As New DataTable

        Try
            dt = Mainform.BenlyDal.Matter_getlist(Mainform.workingmeeting, NumericUpDown1.Value)
        Catch ex As Exception
            MsgBox("Lỗi :" + ex.Message)
            Exit Sub
        End Try
        If dt.Rows.Count = 1 Then
            MaskedTextBox3.Text = dt.Rows(0).Item("Mattername")
            If Not IsDBNull(dt.Rows(0).Item("Mattercode")) AndAlso IsNumeric(dt.Rows(0).Item("Mattercode")) Then
                NumericUpDown1.Value = Convert.ToDecimal(dt.Rows(0).Item("Mattercode"))
            Else
                NumericUpDown1.Value = 1
            End If

            If isLoading Then Exit Sub
        Else
            MaskedTextBox3.Text = ""
        End If
    End Sub

    Private Sub MaskedTextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles HolderCodeMaskedTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt As New DataTable
            Try
                dt = Mainform.BenlyDal.Delegate_getlist(Mainform.workingmeeting, HolderCodeMaskedTextBox.Text, "")
            Catch ex As Exception
                MsgBox("Lỗi :" + ex.Message)
                Exit Sub
            End Try
            If dt.Rows.Count = 1 Then
                HolderCodeMaskedTextBox.Text = dt.Rows(0).Item("Delegatecode")
                HolderIdentifyMaskedTextBox2.Text = dt.Rows(0).Item("IdentityCard")
                MaskedTextBox4.Text = dt.Rows(0).Item("Delegatename")
                StockTextBox1.Text = dt.Rows(0).Item("voterights")
            Else
                HolderCodeMaskedTextBox.Text = ""
                HolderIdentifyMaskedTextBox2.Text = ""
                MaskedTextBox4.Text = ""
                StockTextBox1.Text = ""
            End If

            If CheckBox1.Checked = True Then
                insert()
                HolderCodeMaskedTextBox.Focus()
                HolderCodeMaskedTextBox.SelectAll()
            Else
                Button1.Focus()
            End If

        End If
    End Sub


    Private Sub MaskedTextBox5_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HolderCodeMaskedTextBox.Leave
        Dim dt As New DataTable
        If String.IsNullOrEmpty(HolderCodeMaskedTextBox.Text) Then
            Exit Sub
        End If
        Try
            dt = Mainform.BenlyDal.Delegate_getlist(Mainform.workingmeeting, HolderCodeMaskedTextBox.Text, "")
        Catch ex As Exception
            MsgBox("Lỗi :" + ex.Message)
            Exit Sub
        End Try
        If dt.Rows.Count = 1 Then
            HolderCodeMaskedTextBox.Text = dt.Rows(0).Item("Delegatecode")
            HolderIdentifyMaskedTextBox2.Text = dt.Rows(0).Item("IdentityCard")
            MaskedTextBox4.Text = dt.Rows(0).Item("Delegatename")
            StockTextBox1.Text = dt.Rows(0).Item("voterights")
        Else
            HolderCodeMaskedTextBox.Text = ""
            HolderIdentifyMaskedTextBox2.Text = ""
            MaskedTextBox4.Text = ""
            StockTextBox1.Text = ""
        End If

    End Sub

    Private Sub insert()
        Try
            Dim meetingcode As String = Mainform.workingmeeting
            Dim mattercode As Decimal = NumericUpDown1.Value
            Dim HolderCode As Decimal = 0 'CDec(HolderCodeMaskedTextBox.Text)
            Dim DelegateCode As Decimal = CDec(HolderCodeMaskedTextBox.Text)
            Dim Agree As Boolean
            Dim disAgree As Boolean
            Dim noidea As Boolean
            Dim illegal As Boolean
            Mainform.BenlyDal.MatterVotes_insert(meetingcode, mattercode, HolderCode, DelegateCode, RadioButton1.Checked, RadioButton2.Checked, RadioButton3.Checked, rbillegal.Enabled)

        Catch ex As Exception
            MsgBox("Lỗi :" + ex.Message)
        End Try
    End Sub
    Private Sub Updatemattervote()
        Try
            Mainform.BenlyDal.MatterVotes_update(Mainform.workingmeeting, NumericUpDown1.Value, HolderCodeMaskedTextBox.Text, RadioButton1.Checked, RadioButton2.Checked, RadioButton3.Checked, rbillegal.Checked)
        Catch ex As Exception
            MsgBox("Lỗi :" + ex.Message)
        End Try
    End Sub
    Private Sub MaskedTextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles HolderIdentifyMaskedTextBox2.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Not HolderIdentifyMaskedTextBox2.Text Is Nothing AndAlso HolderIdentifyMaskedTextBox2.Text <> "" Then
                Me.TimDaiBieu()
            End If

            'Dim dt As New DataTable
            'Try
            '    dt = Mainform.BenlyDal.Delegate_getlist(Mainform.workingmeeting, 0, MaskedTextBox2.Text)
            'Catch ex As Exception
            '    MsgBox("Lỗi :" + ex.Message)
            '    Exit Sub
            'End Try
            'If dt.Rows.Count = 1 Then
            '    MaskedTextBox5.Text = dt.Rows(0).Item("Delegatecode")
            '    MaskedTextBox2.Text = dt.Rows(0).Item("IdentityCard")
            '    MaskedTextBox4.Text = dt.Rows(0).Item("Delegatename")
            '    StockTextBox1.Text = dt.Rows(0).Item("voterights")
            'Else
            '    MaskedTextBox5.Text = ""
            '    MaskedTextBox2.Text = ""
            '    MaskedTextBox4.Text = ""
            '    StockTextBox1.Text = ""
            'End If

            If CheckBox1.Checked = True Then
                insert()
                HolderCodeMaskedTextBox.Focus()
            Else
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub TimDaiBieu()
        Dim daibieu As New DataTable
        Try
            'daibieu = Mainform.BenlyDal.Delegate_getlist(Mainform.workingmeeting, 0, MaskedTextBox3.Text)
            'daibieu = Mainform.BenlyDal.Delegate_getlist(Mainform.workingmeeting, 0, MaskedTextBox2.Text)
            daibieu = Mainform.BenlyDal.Authorizations_getlist(Mainform.workingmeeting, 0, "", delegateIdentityTextBox.Text, HolderIdentifyMaskedTextBox2.Text)
        Catch ex As Exception
            MsgBox("Lỗi" + ex.Message)
            Exit Sub
        End Try
        If daibieu.Rows.Count = 1 Then
            HolderCodeMaskedTextBox.Text = daibieu.Rows(0).Item("HolderCode")
            delegateCodeMaskedTextBox.Text = daibieu.Rows(0).Item("DelegateCode")
            HolderIdentifyMaskedTextBox2.Text = daibieu.Rows(0).Item("HolderIdentity")
            MaskedTextBox4.Text = daibieu.Rows(0).Item("HolderName")
            StockTextBox1.Text = daibieu.Rows(0).Item("Delegateright")
            delegateIdentityTextBox.Text = "" 'daibieu.Rows(0).Item("IdentityCard")
            delegateNameTextbox.Text = daibieu.Rows(0).Item("DelegateName")

        ElseIf daibieu.Rows.Count > 1 Then
            Dim objListForSelect As New AuthorizationListForSelect()
            objListForSelect.HolderIdentifyCard = HolderIdentifyMaskedTextBox2.Text
            objListForSelect.DelegateIdentifyCard = delegateIdentityTextBox.Text
            objListForSelect.ShowDialog()
            HolderIdentifyMaskedTextBox2.Text = objListForSelect.DataGridView1.CurrentRow.Cells("HolderIdentity").Value.ToString()
            delegateIdentityTextBox.Text = objListForSelect.DataGridView1.CurrentRow.Cells("IdentityCard").Value.ToString()
            TimDaiBieu()
        ElseIf daibieu.Rows.Count = 0 Then
            MessageBox.Show("Không tìm thấy đại biểu !")
            HolderCodeMaskedTextBox.Text = ""
            HolderIdentifyMaskedTextBox2.Text = ""
            MaskedTextBox4.Text = ""
            StockTextBox1.Text = ""
            HolderCodeMaskedTextBox.Focus()
            HolderCodeMaskedTextBox.SelectAll()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(HolderCodeMaskedTextBox.Text) Then
            HolderCodeMaskedTextBox.Focus()
            Exit Sub
        End If
        If controlcode = "Add" Then

            insert()
            Button2.Focus()
            Button2.Enabled = True
            Button1.Enabled = False
        ElseIf controlcode = "Update" Then
            Updatemattervote()
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        HolderCodeMaskedTextBox.Text = ""
        HolderIdentifyMaskedTextBox2.Text = ""
        MaskedTextBox4.Text = ""
        StockTextBox1.Text = ""
        delegateNameTextbox.Text = ""
        HolderCodeMaskedTextBox.Focus()
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim f As New MatterVotes_ins_remain(NumericUpDown1.Value)
        f.ShowDialog()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub MaskedTextBox5_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub Mattervote_ins_update_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub NumericUpDown1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NumericUpDown1.Validating
        If NumericUpDown1.Text = "" Then
            NumericUpDown1.Value = CDec(1)
        End If
    End Sub
End Class