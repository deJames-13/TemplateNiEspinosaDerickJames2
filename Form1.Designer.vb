<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.mainFrame = New System.Windows.Forms.Panel()
        Me.myPanel1 = New System.Windows.Forms.Panel()
        Me.formContainer = New System.Windows.Forms.Panel()
        Me.formWrapper = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mainFrame.SuspendLayout()
        Me.myPanel1.SuspendLayout()
        Me.formContainer.SuspendLayout()
        Me.formWrapper.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.header.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainFrame
        '
        Me.mainFrame.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mainFrame.Controls.Add(Me.myPanel1)
        Me.mainFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mainFrame.Location = New System.Drawing.Point(2, 2)
        Me.mainFrame.Name = "mainFrame"
        Me.mainFrame.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.mainFrame.Size = New System.Drawing.Size(340, 557)
        Me.mainFrame.TabIndex = 0
        '
        'myPanel1
        '
        Me.myPanel1.BackColor = System.Drawing.Color.Transparent
        Me.myPanel1.BackgroundImage = Global.templateNanaman.My.Resources.Resources.formBox1
        Me.myPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.myPanel1.Controls.Add(Me.formContainer)
        Me.myPanel1.Controls.Add(Me.header)
        Me.myPanel1.Location = New System.Drawing.Point(20, 20)
        Me.myPanel1.Margin = New System.Windows.Forms.Padding(20)
        Me.myPanel1.Name = "myPanel1"
        Me.myPanel1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.myPanel1.Size = New System.Drawing.Size(300, 500)
        Me.myPanel1.TabIndex = 0
        '
        'formContainer
        '
        Me.formContainer.Controls.Add(Me.formWrapper)
        Me.formContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.formContainer.Location = New System.Drawing.Point(10, 47)
        Me.formContainer.Name = "formContainer"
        Me.formContainer.Padding = New System.Windows.Forms.Padding(10, 30, 10, 20)
        Me.formContainer.Size = New System.Drawing.Size(280, 434)
        Me.formContainer.TabIndex = 1
        '
        'formWrapper
        '
        Me.formWrapper.BackgroundImage = Global.templateNanaman.My.Resources.Resources.formContainer
        Me.formWrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formWrapper.Controls.Add(Me.Panel3)
        Me.formWrapper.Controls.Add(Me.Panel5)
        Me.formWrapper.Controls.Add(Me.Panel4)
        Me.formWrapper.Controls.Add(Me.Panel2)
        Me.formWrapper.Controls.Add(Me.Panel1)
        Me.formWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formWrapper.Location = New System.Drawing.Point(10, 30)
        Me.formWrapper.Name = "formWrapper"
        Me.formWrapper.Padding = New System.Windows.Forms.Padding(15, 30, 15, 30)
        Me.formWrapper.Size = New System.Drawing.Size(260, 384)
        Me.formWrapper.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.templateNanaman.My.Resources.Resources.formInput
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(15, 132)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 8, 5, 10)
        Me.Panel3.Size = New System.Drawing.Size(230, 42)
        Me.Panel3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Ivory
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(5, 8)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 24)
        Me.TextBox2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(15, 314)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel5.Size = New System.Drawing.Size(230, 40)
        Me.Panel5.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Ivory
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Roboto Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(224, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(15, 102)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel4.Size = New System.Drawing.Size(230, 30)
        Me.Panel4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.templateNanaman.My.Resources.Resources.formInput
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(15, 60)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5, 8, 5, 10)
        Me.Panel2.Size = New System.Drawing.Size(230, 42)
        Me.Panel2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Ivory
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(5, 8)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 24)
        Me.TextBox1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(15, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(230, 30)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'header
        '
        Me.header.Controls.Add(Me.Label1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(10, 5)
        Me.header.Name = "header"
        Me.header.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.header.Size = New System.Drawing.Size(280, 42)
        Me.header.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TitleBox"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(344, 561)
        Me.Controls.Add(Me.mainFrame)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Window Forms"
        Me.mainFrame.ResumeLayout(False)
        Me.myPanel1.ResumeLayout(False)
        Me.formContainer.ResumeLayout(False)
        Me.formWrapper.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainFrame As Panel
    Friend WithEvents myPanel1 As Panel
    Friend WithEvents header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents formContainer As Panel
    Friend WithEvents formWrapper As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox2 As TextBox
End Class
