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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPayRate = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblFWT = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(209, 245)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 38)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(454, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 38)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(334, 245)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 38)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(170, 28)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 28)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name"
        '
        'lblPayRate
        '
        Me.lblPayRate.AutoSize = True
        Me.lblPayRate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayRate.Location = New System.Drawing.Point(526, 28)
        Me.lblPayRate.Name = "lblPayRate"
        Me.lblPayRate.Size = New System.Drawing.Size(86, 28)
        Me.lblPayRate.TabIndex = 8
        Me.lblPayRate.Text = "Pay Rate"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(449, 28)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(64, 28)
        Me.lblHours.TabIndex = 7
        Me.lblHours.Text = "Hours"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(175, 69)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(260, 34)
        Me.txtName.TabIndex = 0
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(454, 69)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(71, 34)
        Me.txtHours.TabIndex = 1
        Me.txtHours.Text = "0.00"
        '
        'txtPayRate
        '
        Me.txtPayRate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayRate.Location = New System.Drawing.Point(531, 69)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(81, 34)
        Me.txtPayRate.TabIndex = 2
        Me.txtPayRate.Text = "0.00"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(356, 130)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(52, 28)
        Me.lbl3.TabIndex = 11
        Me.lbl3.Text = "FICA"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(448, 130)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(56, 28)
        Me.lbl4.TabIndex = 12
        Me.lbl4.Text = "State"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(263, 130)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(51, 28)
        Me.lbl2.TabIndex = 10
        Me.lbl2.Text = "FWT"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(170, 130)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(61, 28)
        Me.lbl1.TabIndex = 9
        Me.lbl1.Text = "Gross"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(537, 130)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(44, 28)
        Me.lbl5.TabIndex = 13
        Me.lbl5.Text = "Net"
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(173, 182)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(89, 28)
        Me.lblGross.TabIndex = 14
        '
        'lblFWT
        '
        Me.lblFWT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFWT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFWT.Location = New System.Drawing.Point(268, 182)
        Me.lblFWT.Name = "lblFWT"
        Me.lblFWT.Size = New System.Drawing.Size(87, 28)
        Me.lblFWT.TabIndex = 15
        '
        'lblFICA
        '
        Me.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFICA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.Location = New System.Drawing.Point(361, 182)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(86, 28)
        Me.lblFICA.TabIndex = 16
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(453, 182)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(83, 28)
        Me.lblState.TabIndex = 17
        '
        'lblNet
        '
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.Location = New System.Drawing.Point(542, 182)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(81, 28)
        Me.lblNet.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.rcarrillo1h1.My.Resources.Resources.paycheck
        Me.PictureBox1.Location = New System.Drawing.Point(9, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 312)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblFWT)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblPayRate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblPayRate As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtPayRate As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents lblFWT As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
