<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.relativeBtn = New System.Windows.Forms.RadioButton()
        Me.shorttimeBtn = New System.Windows.Forms.RadioButton()
        Me.fulltimeBtn = New System.Windows.Forms.RadioButton()
        Me.shortdateBtn = New System.Windows.Forms.RadioButton()
        Me.fulldateBtn = New System.Windows.Forms.RadioButton()
        Me.dateandtimeBtn = New System.Windows.Forms.RadioButton()
        Me.daydateandtimeBtn = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(198, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.daydateandtimeBtn)
        Me.Panel1.Controls.Add(Me.dateandtimeBtn)
        Me.Panel1.Controls.Add(Me.fulldateBtn)
        Me.Panel1.Controls.Add(Me.relativeBtn)
        Me.Panel1.Controls.Add(Me.shortdateBtn)
        Me.Panel1.Controls.Add(Me.fulltimeBtn)
        Me.Panel1.Controls.Add(Me.shorttimeBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 93)
        Me.Panel1.TabIndex = 1
        '
        'relativeBtn
        '
        Me.relativeBtn.AutoSize = True
        Me.relativeBtn.Location = New System.Drawing.Point(81, 49)
        Me.relativeBtn.Name = "relativeBtn"
        Me.relativeBtn.Size = New System.Drawing.Size(64, 17)
        Me.relativeBtn.TabIndex = 0
        Me.relativeBtn.Text = "Relative"
        Me.relativeBtn.UseVisualStyleBackColor = True
        '
        'shorttimeBtn
        '
        Me.shorttimeBtn.AutoSize = True
        Me.shorttimeBtn.Checked = True
        Me.shorttimeBtn.Location = New System.Drawing.Point(3, 3)
        Me.shorttimeBtn.Name = "shorttimeBtn"
        Me.shorttimeBtn.Size = New System.Drawing.Size(72, 17)
        Me.shorttimeBtn.TabIndex = 1
        Me.shorttimeBtn.TabStop = True
        Me.shorttimeBtn.Text = "Short time"
        Me.shorttimeBtn.UseVisualStyleBackColor = True
        '
        'fulltimeBtn
        '
        Me.fulltimeBtn.AutoSize = True
        Me.fulltimeBtn.Location = New System.Drawing.Point(3, 26)
        Me.fulltimeBtn.Name = "fulltimeBtn"
        Me.fulltimeBtn.Size = New System.Drawing.Size(63, 17)
        Me.fulltimeBtn.TabIndex = 2
        Me.fulltimeBtn.Text = "Full time"
        Me.fulltimeBtn.UseVisualStyleBackColor = True
        '
        'shortdateBtn
        '
        Me.shortdateBtn.AutoSize = True
        Me.shortdateBtn.Location = New System.Drawing.Point(3, 49)
        Me.shortdateBtn.Name = "shortdateBtn"
        Me.shortdateBtn.Size = New System.Drawing.Size(74, 17)
        Me.shortdateBtn.TabIndex = 3
        Me.shortdateBtn.Text = "Short date"
        Me.shortdateBtn.UseVisualStyleBackColor = True
        '
        'fulldateBtn
        '
        Me.fulldateBtn.AutoSize = True
        Me.fulldateBtn.Location = New System.Drawing.Point(3, 72)
        Me.fulldateBtn.Name = "fulldateBtn"
        Me.fulldateBtn.Size = New System.Drawing.Size(65, 17)
        Me.fulldateBtn.TabIndex = 4
        Me.fulldateBtn.Text = "Full date"
        Me.fulldateBtn.UseVisualStyleBackColor = True
        '
        'dateandtimeBtn
        '
        Me.dateandtimeBtn.AutoSize = True
        Me.dateandtimeBtn.Location = New System.Drawing.Point(81, 3)
        Me.dateandtimeBtn.Name = "dateandtimeBtn"
        Me.dateandtimeBtn.Size = New System.Drawing.Size(91, 17)
        Me.dateandtimeBtn.TabIndex = 5
        Me.dateandtimeBtn.Text = "Date and time"
        Me.dateandtimeBtn.UseVisualStyleBackColor = True
        '
        'daydateandtimeBtn
        '
        Me.daydateandtimeBtn.AutoSize = True
        Me.daydateandtimeBtn.Location = New System.Drawing.Point(81, 26)
        Me.daydateandtimeBtn.Name = "daydateandtimeBtn"
        Me.daydateandtimeBtn.Size = New System.Drawing.Size(114, 17)
        Me.daydateandtimeBtn.TabIndex = 6
        Me.daydateandtimeBtn.Text = "Day, date and time"
        Me.daydateandtimeBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 113)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(214, 152)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(214, 152)
        Me.Name = "Form1"
        Me.Text = "Timestamp generator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents daydateandtimeBtn As RadioButton
    Friend WithEvents dateandtimeBtn As RadioButton
    Friend WithEvents fulldateBtn As RadioButton
    Friend WithEvents shortdateBtn As RadioButton
    Friend WithEvents fulltimeBtn As RadioButton
    Friend WithEvents shorttimeBtn As RadioButton
    Friend WithEvents relativeBtn As RadioButton
    Friend WithEvents TextBox1 As TextBox
End Class
