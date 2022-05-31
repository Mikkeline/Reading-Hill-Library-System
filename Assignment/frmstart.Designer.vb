<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmstart))
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.btnloginstu = New System.Windows.Forms.Button()
        Me.btnloginlibra = New System.Windows.Forms.Button()
        Me.btnloginadmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblwelcome.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.Location = New System.Drawing.Point(147, 78)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(536, 70)
        Me.lblwelcome.TabIndex = 25
        Me.lblwelcome.Text = "Welcome to Reading Hill Library!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please Choose :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnloginstu
        '
        Me.btnloginstu.BackColor = System.Drawing.Color.White
        Me.btnloginstu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloginstu.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloginstu.ForeColor = System.Drawing.Color.Black
        Me.btnloginstu.Location = New System.Drawing.Point(290, 380)
        Me.btnloginstu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnloginstu.Name = "btnloginstu"
        Me.btnloginstu.Size = New System.Drawing.Size(206, 81)
        Me.btnloginstu.TabIndex = 45
        Me.btnloginstu.Text = "&Student Login"
        Me.btnloginstu.UseVisualStyleBackColor = False
        '
        'btnloginlibra
        '
        Me.btnloginlibra.BackColor = System.Drawing.Color.White
        Me.btnloginlibra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloginlibra.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloginlibra.ForeColor = System.Drawing.Color.Black
        Me.btnloginlibra.Location = New System.Drawing.Point(290, 291)
        Me.btnloginlibra.Margin = New System.Windows.Forms.Padding(4)
        Me.btnloginlibra.Name = "btnloginlibra"
        Me.btnloginlibra.Size = New System.Drawing.Size(206, 81)
        Me.btnloginlibra.TabIndex = 44
        Me.btnloginlibra.Text = "&Librarian Login"
        Me.btnloginlibra.UseVisualStyleBackColor = False
        '
        'btnloginadmin
        '
        Me.btnloginadmin.BackColor = System.Drawing.Color.White
        Me.btnloginadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloginadmin.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloginadmin.ForeColor = System.Drawing.Color.Black
        Me.btnloginadmin.Location = New System.Drawing.Point(290, 202)
        Me.btnloginadmin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnloginadmin.Name = "btnloginadmin"
        Me.btnloginadmin.Size = New System.Drawing.Size(206, 81)
        Me.btnloginadmin.TabIndex = 43
        Me.btnloginadmin.Text = "&Admin Login"
        Me.btnloginadmin.UseVisualStyleBackColor = False
        '
        'frmstart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.loginwallpaper_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(818, 521)
        Me.Controls.Add(Me.btnloginstu)
        Me.Controls.Add(Me.btnloginlibra)
        Me.Controls.Add(Me.btnloginadmin)
        Me.Controls.Add(Me.lblwelcome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmstart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblwelcome As Label
    Friend WithEvents btnloginstu As Button
    Friend WithEvents btnloginlibra As Button
    Friend WithEvents btnloginadmin As Button
End Class
