Imports System.Windows.Forms
Imports System
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine

Public Class PrintHolders

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim dt As New DataTable
        Try
            dt = Mainform.BenlyDal.Holder_getListLimited(Mainform.workingmeeting, Convert.ToInt32(txtFromHolder.Text), Convert.ToInt32(txtToHolder.Text))
            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i)("VoteRights") = Mainform.addthousandseperator(dt.Rows(i)("VoteRights").ToString().Trim())
            Next

            ' Dim cr_thebieuquyet As New thebieuquyet
            Dim cr_thebieuquyet As New ReportDocument()
            'cr_thebieuquyet.Load("~/Report/thebieuquyet.rpt")
            Dim reportPath As String = IO.Path.Combine(Application.StartupPath, "Report\thebieuquyet.rpt")
            If Not IO.File.Exists(reportPath) Then
                MessageBox.Show("Không tìm thấy file báo cáo: " & reportPath)
                Exit Sub
            End If
            cr_thebieuquyet.Load(reportPath)
            cr_thebieuquyet.SetDataSource(dt)
            Dim logoPath As String = IO.Path.Combine(Application.StartupPath, "Resources\Logo.jpg")
            cr_thebieuquyet.SetParameterValue("LogoPath", logoPath)
            cr_thebieuquyet.SetParameterValue("DateMeeting", Mainform.dateMeeting)
            cr_thebieuquyet.SetParameterValue("MettingType", Mainform.mettingType)
            ReportViewer.LoadReport(cr_thebieuquyet, HolderList)
        Catch ex As Exception
            MsgBox("Lỗi :" + ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
