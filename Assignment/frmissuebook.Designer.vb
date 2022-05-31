<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmissuebook
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmissuebook))
        Me.cbxstatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerdue = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerissue = New System.Windows.Forms.DateTimePicker()
        Me.lbldue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstudentid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnissue = New System.Windows.Forms.Button()
        Me.txtbookid = New System.Windows.Forms.TextBox()
        Me.lblbookid = New System.Windows.Forms.Label()
        Me.LMSDataSet = New Assignment.LMSDataSet()
        Me.IssueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueTableAdapter = New Assignment.LMSDataSetTableAdapters.IssueTableAdapter()
        Me.TableAdapterManager = New Assignment.LMSDataSetTableAdapters.TableAdapterManager()
        Me.IssueDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfine = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxstatus
        '
        Me.cbxstatus.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxstatus.FormattingEnabled = True
        Me.cbxstatus.Items.AddRange(New Object() {"Issued", "Returned", "Missing"})
        Me.cbxstatus.Location = New System.Drawing.Point(8, 325)
        Me.cbxstatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxstatus.Name = "cbxstatus"
        Me.cbxstatus.Size = New System.Drawing.Size(391, 28)
        Me.cbxstatus.TabIndex = 82
        Me.cbxstatus.Text = "Issued"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 300)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Status:"
        '
        'DateTimePickerdue
        '
        Me.DateTimePickerdue.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerdue.Location = New System.Drawing.Point(8, 253)
        Me.DateTimePickerdue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerdue.Name = "DateTimePickerdue"
        Me.DateTimePickerdue.Size = New System.Drawing.Size(391, 27)
        Me.DateTimePickerdue.TabIndex = 80
        '
        'DateTimePickerissue
        '
        Me.DateTimePickerissue.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerissue.Location = New System.Drawing.Point(8, 184)
        Me.DateTimePickerissue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerissue.Name = "DateTimePickerissue"
        Me.DateTimePickerissue.Size = New System.Drawing.Size(391, 27)
        Me.DateTimePickerissue.TabIndex = 79
        '
        'lbldue
        '
        Me.lbldue.AutoSize = True
        Me.lbldue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbldue.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldue.Location = New System.Drawing.Point(3, 231)
        Me.lbldue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldue.Name = "lbldue"
        Me.lbldue.Size = New System.Drawing.Size(98, 20)
        Me.lbldue.TabIndex = 78
        Me.lbldue.Text = "Due Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Issue Date:"
        '
        'txtstudentid
        '
        Me.txtstudentid.BackColor = System.Drawing.SystemColors.Window
        Me.txtstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstudentid.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtstudentid.Location = New System.Drawing.Point(8, 118)
        Me.txtstudentid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstudentid.Name = "txtstudentid"
        Me.txtstudentid.Size = New System.Drawing.Size(392, 27)
        Me.txtstudentid.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "StudentID:"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltitle.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(132, 18)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(183, 35)
        Me.lbltitle.TabIndex = 74
        Me.lbltitle.Text = "Issue Book"
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreset.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(226, 514)
        Me.btnreset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(186, 50)
        Me.btnreset.TabIndex = 73
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnissue
        '
        Me.btnissue.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnissue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnissue.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnissue.Location = New System.Drawing.Point(20, 514)
        Me.btnissue.Margin = New System.Windows.Forms.Padding(4)
        Me.btnissue.Name = "btnissue"
        Me.btnissue.Size = New System.Drawing.Size(185, 50)
        Me.btnissue.TabIndex = 72
        Me.btnissue.Text = "&Issue"
        Me.btnissue.UseVisualStyleBackColor = False
        '
        'txtbookid
        '
        Me.txtbookid.BackColor = System.Drawing.SystemColors.Window
        Me.txtbookid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbookid.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbookid.Location = New System.Drawing.Point(7, 52)
        Me.txtbookid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.Size = New System.Drawing.Size(392, 27)
        Me.txtbookid.TabIndex = 71
        '
        'lblbookid
        '
        Me.lblbookid.AutoSize = True
        Me.lblbookid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblbookid.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookid.Location = New System.Drawing.Point(3, 28)
        Me.lblbookid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbookid.Name = "lblbookid"
        Me.lblbookid.Size = New System.Drawing.Size(88, 20)
        Me.lblbookid.TabIndex = 70
        Me.lblbookid.Text = "Book ID:"
        '
        'LMSDataSet
        '
        Me.LMSDataSet.DataSetName = "LMSDataSet"
        Me.LMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IssueBindingSource
        '
        Me.IssueBindingSource.DataMember = "Issue"
        Me.IssueBindingSource.DataSource = Me.LMSDataSet
        '
        'IssueTableAdapter
        '
        Me.IssueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.IssueTableAdapter = Me.IssueTableAdapter
        Me.TableAdapterManager.LibrarianTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Assignment.LMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IssueDataGridView
        '
        Me.IssueDataGridView.AllowUserToOrderColumns = True
        Me.IssueDataGridView.AutoGenerateColumns = False
        Me.IssueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.IssueDataGridView.DataSource = Me.IssueBindingSource
        Me.IssueDataGridView.Location = New System.Drawing.Point(456, 40)
        Me.IssueDataGridView.Name = "IssueDataGridView"
        Me.IssueDataGridView.RowTemplate.Height = 24
        Me.IssueDataGridView.Size = New System.Drawing.Size(663, 501)
        Me.IssueDataGridView.TabIndex = 84
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BookID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BookID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "issue_date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "issue_date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "due_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "due_date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fine"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fine"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtfine)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtbookid)
        Me.GroupBox1.Controls.Add(Me.lblbookid)
        Me.GroupBox1.Controls.Add(Me.cbxstatus)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtstudentid)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerdue)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerissue)
        Me.GroupBox1.Controls.Add(Me.lbldue)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 435)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please Fill in All the Details:"
        '
        'txtfine
        '
        Me.txtfine.BackColor = System.Drawing.SystemColors.Window
        Me.txtfine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfine.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtfine.Location = New System.Drawing.Point(7, 394)
        Me.txtfine.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfine.Name = "txtfine"
        Me.txtfine.Size = New System.Drawing.Size(392, 27)
        Me.txtfine.TabIndex = 84
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 370)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Fine:"
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(227, 572)
        Me.btnrefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(185, 43)
        Me.btnrefresh.TabIndex = 86
        Me.btnrefresh.Text = "&Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(20, 572)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(185, 43)
        Me.btnupdate.TabIndex = 87
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'frmissuebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.homebg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1137, 634)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IssueDataGridView)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnissue)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmissuebook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issue book"
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxstatus As ComboBox
    Private WithEvents Label3 As Label
    Friend WithEvents DateTimePickerdue As DateTimePicker
    Friend WithEvents DateTimePickerissue As DateTimePicker
    Private WithEvents lbldue As Label
    Private WithEvents Label2 As Label
    Private WithEvents txtstudentid As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents lbltitle As Label
    Private WithEvents btnreset As Button
    Private WithEvents btnissue As Button
    Private WithEvents txtbookid As TextBox
    Private WithEvents lblbookid As Label
    Friend WithEvents LMSDataSet As LMSDataSet
    Friend WithEvents IssueBindingSource As BindingSource
    Friend WithEvents IssueTableAdapter As LMSDataSetTableAdapters.IssueTableAdapter
    Friend WithEvents TableAdapterManager As LMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IssueDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents btnrefresh As Button
    Private WithEvents btnupdate As Button
    Private WithEvents txtfine As TextBox
    Private WithEvents Label4 As Label
End Class
