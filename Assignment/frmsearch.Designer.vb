<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsearch))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnseach = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.lblbookid = New System.Windows.Forms.Label()
        Me.LMSDataSet = New Assignment.LMSDataSet()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableAdapter = New Assignment.LMSDataSetTableAdapters.BookTableAdapter()
        Me.TableAdapterManager = New Assignment.LMSDataSetTableAdapters.TableAdapterManager()
        Me.BookDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtboookid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbookname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtquicksearch = New System.Windows.Forms.TextBox()
        Me.btnquicksearch = New System.Windows.Forms.Button()
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(837, 253)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 43)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnseach
        '
        Me.btnseach.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnseach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnseach.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseach.Location = New System.Drawing.Point(837, 124)
        Me.btnseach.Margin = New System.Windows.Forms.Padding(4)
        Me.btnseach.Name = "btnseach"
        Me.btnseach.Size = New System.Drawing.Size(212, 43)
        Me.btnseach.TabIndex = 69
        Me.btnseach.Text = "&Search"
        Me.btnseach.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 38)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Book Search"
        '
        'txtauthor
        '
        Me.txtauthor.BackColor = System.Drawing.SystemColors.Window
        Me.txtauthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtauthor.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtauthor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtauthor.Location = New System.Drawing.Point(299, 127)
        Me.txtauthor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(373, 30)
        Me.txtauthor.TabIndex = 67
        '
        'lblbookid
        '
        Me.lblbookid.AutoSize = True
        Me.lblbookid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblbookid.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookid.Location = New System.Drawing.Point(46, 127)
        Me.lblbookid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbookid.Name = "lblbookid"
        Me.lblbookid.Size = New System.Drawing.Size(110, 29)
        Me.lblbookid.TabIndex = 66
        Me.lblbookid.Text = "Author:"
        '
        'LMSDataSet
        '
        Me.LMSDataSet.DataSetName = "LMSDataSet"
        Me.LMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.LMSDataSet
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Me.BookTableAdapter
        Me.TableAdapterManager.IssueTableAdapter = Nothing
        Me.TableAdapterManager.LibrarianTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Assignment.LMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BookDataGridView
        '
        Me.BookDataGridView.AutoGenerateColumns = False
        Me.BookDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.BookDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.BookDataGridView.DataSource = Me.BookBindingSource
        Me.BookDataGridView.Location = New System.Drawing.Point(22, 350)
        Me.BookDataGridView.Name = "BookDataGridView"
        Me.BookDataGridView.RowHeadersWidth = 50
        Me.BookDataGridView.RowTemplate.Height = 24
        Me.BookDataGridView.Size = New System.Drawing.Size(1027, 325)
        Me.BookDataGridView.TabIndex = 71
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BookName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BookName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BookID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BookID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "subject"
        Me.DataGridViewTextBoxColumn3.HeaderText = "subject"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "author"
        Me.DataGridViewTextBoxColumn4.HeaderText = "author"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cost"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cost"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'txtboookid
        '
        Me.txtboookid.BackColor = System.Drawing.SystemColors.Window
        Me.txtboookid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboookid.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboookid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtboookid.Location = New System.Drawing.Point(299, 36)
        Me.txtboookid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboookid.Name = "txtboookid"
        Me.txtboookid.Size = New System.Drawing.Size(373, 30)
        Me.txtboookid.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 29)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Book ID:"
        '
        'txtbookname
        '
        Me.txtbookname.BackColor = System.Drawing.SystemColors.Window
        Me.txtbookname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbookname.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbookname.Location = New System.Drawing.Point(299, 79)
        Me.txtbookname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbookname.Name = "txtbookname"
        Me.txtbookname.Size = New System.Drawing.Size(373, 30)
        Me.txtbookname.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 29)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Book Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtquicksearch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtbookname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtboookid)
        Me.GroupBox1.Controls.Add(Me.lblbookid)
        Me.GroupBox1.Controls.Add(Me.txtauthor)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(22, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 249)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 179)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 29)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Quick Search:"
        '
        'txtquicksearch
        '
        Me.txtquicksearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtquicksearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtquicksearch.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquicksearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtquicksearch.Location = New System.Drawing.Point(299, 179)
        Me.txtquicksearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquicksearch.Name = "txtquicksearch"
        Me.txtquicksearch.Size = New System.Drawing.Size(373, 30)
        Me.txtquicksearch.TabIndex = 77
        '
        'btnquicksearch
        '
        Me.btnquicksearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnquicksearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquicksearch.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquicksearch.Location = New System.Drawing.Point(837, 191)
        Me.btnquicksearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnquicksearch.Name = "btnquicksearch"
        Me.btnquicksearch.Size = New System.Drawing.Size(212, 43)
        Me.btnquicksearch.TabIndex = 77
        Me.btnquicksearch.Text = "&Quick Search"
        Me.btnquicksearch.UseVisualStyleBackColor = False
        '
        'frmsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.homebg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1062, 696)
        Me.Controls.Add(Me.btnquicksearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BookDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnseach)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmsearch"
        Me.Text = "Book Search"
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button1 As Button
    Private WithEvents btnseach As Button
    Private WithEvents Label1 As Label
    Private WithEvents txtauthor As TextBox
    Private WithEvents lblbookid As Label
    Friend WithEvents LMSDataSet As LMSDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As LMSDataSetTableAdapters.BookTableAdapter
    Friend WithEvents TableAdapterManager As LMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BookDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Private WithEvents txtboookid As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents txtbookname As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label4 As Label
    Private WithEvents txtquicksearch As TextBox
    Private WithEvents btnquicksearch As Button
End Class
