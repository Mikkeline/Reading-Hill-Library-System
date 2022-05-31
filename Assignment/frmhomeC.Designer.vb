<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhomeC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhomeC))
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.btngeneratereports = New System.Windows.Forms.Button()
        Me.btnfinecheck = New System.Windows.Forms.Button()
        Me.btnissuerecord = New System.Windows.Forms.Button()
        Me.btnbooksearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnexit.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(527, 441)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(182, 95)
        Me.btnexit.TabIndex = 19
        Me.btnexit.Text = "&Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnlogout.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(92, 441)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(182, 95)
        Me.btnlogout.TabIndex = 18
        Me.btnlogout.Text = "&Log Out "
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblwelcome.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.Location = New System.Drawing.Point(54, 47)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(592, 72)
        Me.lblwelcome.TabIndex = 17
        Me.lblwelcome.Text = "Hi, Student! Welcome to Reading Hill Library!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We are here to ease your book issu" &
    "e process." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the following button to perform the task you want! "
        Me.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btngeneratereports
        '
        Me.btngeneratereports.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btngeneratereports.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngeneratereports.Location = New System.Drawing.Point(527, 298)
        Me.btngeneratereports.Name = "btngeneratereports"
        Me.btngeneratereports.Size = New System.Drawing.Size(182, 95)
        Me.btngeneratereports.TabIndex = 16
        Me.btngeneratereports.Text = "&Generate Report"
        Me.btngeneratereports.UseVisualStyleBackColor = False
        '
        'btnfinecheck
        '
        Me.btnfinecheck.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnfinecheck.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinecheck.Location = New System.Drawing.Point(527, 175)
        Me.btnfinecheck.Name = "btnfinecheck"
        Me.btnfinecheck.Size = New System.Drawing.Size(182, 95)
        Me.btnfinecheck.TabIndex = 15
        Me.btnfinecheck.Text = "&Fine Check"
        Me.btnfinecheck.UseVisualStyleBackColor = False
        '
        'btnissuerecord
        '
        Me.btnissuerecord.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnissuerecord.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnissuerecord.Location = New System.Drawing.Point(92, 298)
        Me.btnissuerecord.Name = "btnissuerecord"
        Me.btnissuerecord.Size = New System.Drawing.Size(182, 95)
        Me.btnissuerecord.TabIndex = 14
        Me.btnissuerecord.Text = "&Issue Record"
        Me.btnissuerecord.UseVisualStyleBackColor = False
        '
        'btnbooksearch
        '
        Me.btnbooksearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbooksearch.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbooksearch.Location = New System.Drawing.Point(92, 175)
        Me.btnbooksearch.Name = "btnbooksearch"
        Me.btnbooksearch.Size = New System.Drawing.Size(182, 95)
        Me.btnbooksearch.TabIndex = 13
        Me.btnbooksearch.Text = "&Book Search"
        Me.btnbooksearch.UseVisualStyleBackColor = False
        '
        'frmhomeC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.homebg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(872, 551)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.btngeneratereports)
        Me.Controls.Add(Me.btnfinecheck)
        Me.Controls.Add(Me.btnissuerecord)
        Me.Controls.Add(Me.btnbooksearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmhomeC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnexit As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents lblwelcome As Label
    Friend WithEvents btngeneratereports As Button
    Friend WithEvents btnfinecheck As Button
    Friend WithEvents btnissuerecord As Button
    Friend WithEvents btnbooksearch As Button
End Class
