<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
      Me.btnFord = New System.Windows.Forms.Button()
      Me.txtFord = New System.Windows.Forms.TextBox()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.txtUser = New System.Windows.Forms.TextBox()
      Me.txtPass = New System.Windows.Forms.TextBox()
      Me.lblUser = New System.Windows.Forms.Label()
      Me.lblPass = New System.Windows.Forms.Label()
      Me.txtTicker = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'btnFord
      '
      Me.btnFord.Location = New System.Drawing.Point(12, 104)
      Me.btnFord.Name = "btnFord"
      Me.btnFord.Size = New System.Drawing.Size(75, 23)
      Me.btnFord.TabIndex = 0
      Me.btnFord.Text = "git"
      Me.btnFord.UseVisualStyleBackColor = True
      '
      'txtFord
      '
      Me.txtFord.Location = New System.Drawing.Point(52, 74)
      Me.txtFord.Name = "txtFord"
      Me.txtFord.ReadOnly = True
      Me.txtFord.Size = New System.Drawing.Size(559, 20)
      Me.txtFord.TabIndex = 1
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(536, 104)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(75, 23)
      Me.btnExit.TabIndex = 2
      Me.btnExit.Text = "dip"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'btnSave
      '
      Me.btnSave.Location = New System.Drawing.Point(536, 12)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(75, 46)
      Me.btnSave.TabIndex = 3
      Me.btnSave.Text = "Save Credentials"
      Me.btnSave.UseVisualStyleBackColor = True
      '
      'txtUser
      '
      Me.txtUser.Location = New System.Drawing.Point(282, 12)
      Me.txtUser.Name = "txtUser"
      Me.txtUser.Size = New System.Drawing.Size(248, 20)
      Me.txtUser.TabIndex = 4
      Me.txtUser.UseSystemPasswordChar = True
      '
      'txtPass
      '
      Me.txtPass.Location = New System.Drawing.Point(282, 38)
      Me.txtPass.Name = "txtPass"
      Me.txtPass.Size = New System.Drawing.Size(248, 20)
      Me.txtPass.TabIndex = 5
      Me.txtPass.UseSystemPasswordChar = True
      '
      'lblUser
      '
      Me.lblUser.AutoSize = True
      Me.lblUser.Location = New System.Drawing.Point(221, 15)
      Me.lblUser.Name = "lblUser"
      Me.lblUser.Size = New System.Drawing.Size(55, 13)
      Me.lblUser.TabIndex = 6
      Me.lblUser.Text = "Username"
      '
      'lblPass
      '
      Me.lblPass.AutoSize = True
      Me.lblPass.Location = New System.Drawing.Point(221, 41)
      Me.lblPass.Name = "lblPass"
      Me.lblPass.Size = New System.Drawing.Size(53, 13)
      Me.lblPass.TabIndex = 7
      Me.lblPass.Text = "Password"
      '
      'txtTicker
      '
      Me.txtTicker.Location = New System.Drawing.Point(52, 45)
      Me.txtTicker.Name = "txtTicker"
      Me.txtTicker.Size = New System.Drawing.Size(77, 20)
      Me.txtTicker.TabIndex = 8
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(9, 48)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(40, 13)
      Me.Label3.TabIndex = 9
      Me.Label3.Text = "Ticker:"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(12, 77)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(34, 13)
      Me.Label4.TabIndex = 10
      Me.Label4.Text = "Price:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(90, 109)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(235, 13)
      Me.Label1.TabIndex = 11
      Me.Label1.Text = "please dont fucking spam this button you dweeb"
      '
      'MainForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(626, 139)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.txtTicker)
      Me.Controls.Add(Me.lblPass)
      Me.Controls.Add(Me.lblUser)
      Me.Controls.Add(Me.txtPass)
      Me.Controls.Add(Me.txtUser)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.txtFord)
      Me.Controls.Add(Me.btnFord)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
      Me.Name = "MainForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents btnFord As Button
   Friend WithEvents txtFord As TextBox
   Friend WithEvents btnExit As Button
   Friend WithEvents btnSave As Button
   Friend WithEvents txtUser As TextBox
   Friend WithEvents txtPass As TextBox
   Friend WithEvents lblUser As Label
   Friend WithEvents lblPass As Label
   Friend WithEvents txtTicker As TextBox
   Friend WithEvents Label3 As Label
   Friend WithEvents Label4 As Label
   Friend WithEvents Label1 As Label
End Class
