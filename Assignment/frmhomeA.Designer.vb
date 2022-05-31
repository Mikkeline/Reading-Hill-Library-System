<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhomeA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhomeA))
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btnfinecheck = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnissuerecord = New System.Windows.Forms.Button()
        Me.btnissue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblwelcome.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.Location = New System.Drawing.Point(126, 67)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(592, 72)
        Me.lblwelcome.TabIndex = 24
        Me.lblwelcome.Text = "Hi, Admin! Welcome to Reading Hill Library!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We are here to ease your book issue " &
    "process." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the following button to perform the task you want! "
        Me.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnlogout.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(343, 433)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(214, 94)
        Me.btnlogout.TabIndex = 23
        Me.btnlogout.Text = "Log Out "
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnexit.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(567, 433)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(214, 94)
        Me.btnexit.TabIndex = 22
        Me.btnexit.Text = "&Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnuser
        '
        Me.btnuser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnuser.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.Location = New System.Drawing.Point(118, 433)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(214, 94)
        Me.btnuser.TabIndex = 21
        Me.btnuser.Text = "&Manage User"
        Me.btnuser.UseVisualStyleBackColor = False
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnreport.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.Location = New System.Drawing.Point(567, 315)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(214, 94)
        Me.btnreport.TabIndex = 20
        Me.btnreport.Text = "&View Report"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'btnfinecheck
        '
        Me.btnfinecheck.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnfinecheck.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinecheck.Location = New System.Drawing.Point(567, 201)
        Me.btnfinecheck.Name = "btnfinecheck"
        Me.btnfinecheck.Size = New System.Drawing.Size(214, 94)
        Me.btnfinecheck.TabIndex = 19
        Me.btnfinecheck.Text = "&Fine Check"
        Me.btnfinecheck.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndelete.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(343, 315)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(214, 94)
        Me.btndelete.TabIndex = 18
        Me.btndelete.Text = "Boo&k Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsearch.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(118, 315)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(214, 94)
        Me.btnsearch.TabIndex = 17
        Me.btnsearch.Text = "Book &Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnissuerecord
        '
        Me.btnissuerecord.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnissuerecord.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnissuerecord.Location = New System.Drawing.Point(343, 201)
        Me.btnissuerecord.Name = "btnissuerecord"
        Me.btnissuerecord.Size = New System.Drawing.Size(214, 94)
        Me.btnissuerecord.TabIndex = 16
        Me.btnissuerecord.Text = "&Issue Record"
        Me.btnissuerecord.UseVisualStyleBackColor = False
        '
        'btnissue
        '
        Me.btnissue.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnissue.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnissue.Location = New System.Drawing.Point(118, 201)
        Me.btnissue.Name = "btnissue"
        Me.btnissue.Size = New System.Drawing.Size(214, 94)
        Me.btnissue.TabIndex = 15
        Me.btnissue.Text = "Issue &Book "
        Me.btnissue.UseVisualStyleBackColor = False
        '
        'frmhomeA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.homebg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(912, 614)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnuser)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnfinecheck)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnissuerecord)
        Me.Controls.Add(Me.btnissue)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmhomeA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblwelcome As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnuser As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents btnfinecheck As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnissuerecord As Button
    Friend WithEvents btnissue As Button
End Class
