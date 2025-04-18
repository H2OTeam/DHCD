<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MeetingList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Meetingcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Meetingname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Meetingaddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.meetingtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Period = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MettingType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearMeeting = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1197, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.pmDHCD.My.Resources.Resources.Add
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(90, 24)
        Me.ToolStripButton1.Text = "Thêm(A)"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.pmDHCD.My.Resources.Resources.Document
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(76, 24)
        Me.ToolStripButton2.Text = "Sửa(E)"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.pmDHCD.My.Resources.Resources.Delete
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(80, 24)
        Me.ToolStripButton3.Text = "Xóa(D)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(95, 24)
        Me.ToolStripLabel1.Text = "Mã cuộc họp"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(132, 27)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.pmDHCD.My.Resources.Resources.Search
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(58, 24)
        Me.ToolStripButton4.Text = "Tìm"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.pmDHCD.My.Resources.Resources.officemac01
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(206, 24)
        Me.ToolStripButton5.Text = "Chọn cuộc họp(S or Enter)"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 512)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1197, 26)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(134, 20)
        Me.ToolStripStatusLabel1.Text = "Số lượng bản ghi : "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 20)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Meetingcode, Me.Meetingname, Me.CompanyName, Me.CompanyAddress, Me.Meetingaddress, Me.meetingtime, Me.Period, Me.MettingType, Me.YearMeeting})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 27)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1197, 485)
        Me.DataGridView1.TabIndex = 4
        '
        'Meetingcode
        '
        Me.Meetingcode.DataPropertyName = "Meetingcode"
        Me.Meetingcode.FillWeight = 59.37841!
        Me.Meetingcode.HeaderText = "Mã cuộc họp"
        Me.Meetingcode.MinimumWidth = 6
        Me.Meetingcode.Name = "Meetingcode"
        Me.Meetingcode.ReadOnly = True
        '
        'Meetingname
        '
        Me.Meetingname.DataPropertyName = "Meetingname"
        Me.Meetingname.FillWeight = 65.68176!
        Me.Meetingname.HeaderText = "Tên cuộc họp"
        Me.Meetingname.MinimumWidth = 100
        Me.Meetingname.Name = "Meetingname"
        Me.Meetingname.ReadOnly = True
        '
        'CompanyName
        '
        Me.CompanyName.DataPropertyName = "CompanyName"
        Me.CompanyName.FillWeight = 138.3765!
        Me.CompanyName.HeaderText = "Tên công ty"
        Me.CompanyName.MinimumWidth = 8
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.ReadOnly = True
        '
        'CompanyAddress
        '
        Me.CompanyAddress.DataPropertyName = "CompanyAddress"
        Me.CompanyAddress.FillWeight = 79.50503!
        Me.CompanyAddress.HeaderText = "Đ/C công ty"
        Me.CompanyAddress.MinimumWidth = 6
        Me.CompanyAddress.Name = "CompanyAddress"
        Me.CompanyAddress.ReadOnly = True
        '
        'Meetingaddress
        '
        Me.Meetingaddress.DataPropertyName = "Meetingaddress"
        Me.Meetingaddress.FillWeight = 24.77251!
        Me.Meetingaddress.HeaderText = "Địa điểm tổ chức"
        Me.Meetingaddress.MinimumWidth = 6
        Me.Meetingaddress.Name = "Meetingaddress"
        Me.Meetingaddress.ReadOnly = True
        Me.Meetingaddress.Visible = False
        '
        'meetingtime
        '
        Me.meetingtime.DataPropertyName = "meetingtime"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.meetingtime.DefaultCellStyle = DataGridViewCellStyle2
        Me.meetingtime.FillWeight = 38.75047!
        Me.meetingtime.HeaderText = "Thời gian tổ chức"
        Me.meetingtime.MinimumWidth = 6
        Me.meetingtime.Name = "meetingtime"
        Me.meetingtime.ReadOnly = True
        '
        'Period
        '
        Me.Period.DataPropertyName = "Period"
        Me.Period.HeaderText = "Nhiệm kỳ"
        Me.Period.MinimumWidth = 6
        Me.Period.Name = "Period"
        Me.Period.ReadOnly = True
        '
        'MettingType
        '
        Me.MettingType.DataPropertyName = "MettingType"
        Me.MettingType.HeaderText = "Loại hình"
        Me.MettingType.MinimumWidth = 6
        Me.MettingType.Name = "MettingType"
        Me.MettingType.ReadOnly = True
        '
        'YearMeeting
        '
        Me.YearMeeting.DataPropertyName = "YearMeeting"
        Me.YearMeeting.HeaderText = "Năm"
        Me.YearMeeting.MinimumWidth = 6
        Me.YearMeeting.Name = "YearMeeting"
        Me.YearMeeting.ReadOnly = True
        Me.YearMeeting.Visible = False
        '
        'MeetingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 538)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MeetingList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách cuộc họp"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Meetingcode As DataGridViewTextBoxColumn
    Friend WithEvents Meetingname As DataGridViewTextBoxColumn
    Friend WithEvents CompanyName As DataGridViewTextBoxColumn
    Friend WithEvents CompanyAddress As DataGridViewTextBoxColumn
    Friend WithEvents Meetingaddress As DataGridViewTextBoxColumn
    Friend WithEvents meetingtime As DataGridViewTextBoxColumn
    Friend WithEvents Period As DataGridViewTextBoxColumn
    Friend WithEvents MettingType As DataGridViewTextBoxColumn
    Friend WithEvents YearMeeting As DataGridViewTextBoxColumn
End Class
