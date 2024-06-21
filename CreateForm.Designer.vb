<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNo = New Label()
        lblGithubLink = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNo = New TextBox()
        txtGithubLink = New TextBox()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        txtStopwatch = New TextBox()
        timer = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(145, 86)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(150, 136)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNo
        ' 
        lblPhoneNo.AutoSize = True
        lblPhoneNo.Location = New Point(118, 200)
        lblPhoneNo.Name = "lblPhoneNo"
        lblPhoneNo.Size = New Size(86, 25)
        lblPhoneNo.TabIndex = 4
        lblPhoneNo.Text = "PhoneNo"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(103, 263)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(101, 25)
        lblGithubLink.TabIndex = 6
        lblGithubLink.Text = "Github Link"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(227, 80)
        txtName.Name = "txtName"
        txtName.Size = New Size(239, 31)
        txtName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(227, 133)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(239, 31)
        txtEmail.TabIndex = 3
        ' 
        ' txtPhoneNo
        ' 
        txtPhoneNo.Location = New Point(227, 194)
        txtPhoneNo.Name = "txtPhoneNo"
        txtPhoneNo.Size = New Size(239, 31)
        txtPhoneNo.TabIndex = 5
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(227, 257)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(239, 31)
        txtGithubLink.TabIndex = 7
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(145, 383)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(233, 59)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Location = New Point(54, 316)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(150, 34)
        btnToggleStopwatch.TabIndex = 11
        btnToggleStopwatch.Text = "Stopwatch Time"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(227, 316)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.Size = New Size(239, 31)
        txtStopwatch.TabIndex = 12
        ' 
        ' timer
        ' 
        timer.Enabled = True
        timer.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(129, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 45)
        Label1.TabIndex = 13
        Label1.Text = "Add Submission"
        ' 
        ' CreateForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(521, 470)
        Controls.Add(Label1)
        Controls.Add(txtStopwatch)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(txtGithubLink)
        Controls.Add(lblGithubLink)
        Controls.Add(txtPhoneNo)
        Controls.Add(lblPhoneNo)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Name = "CreateForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents timer As Timer
    Friend WithEvents Label1 As Label
End Class
