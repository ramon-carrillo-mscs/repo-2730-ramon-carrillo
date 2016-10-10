<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtweeklypay = New System.Windows.Forms.TextBox()
        Me.txtEmployeerate = New System.Windows.Forms.TextBox()
        Me.txtEmployerrate = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEmployercon = New System.Windows.Forms.Label()
        Me.lblEmployeecon = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gross Weekly Pay:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee contribution rate(decimal form)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employer contribution rate(decimal form)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee annual contribution:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Employer annual contribution:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total annual contribution:"
        '
        'txtweeklypay
        '
        Me.txtweeklypay.Location = New System.Drawing.Point(164, 42)
        Me.txtweeklypay.Name = "txtweeklypay"
        Me.txtweeklypay.Size = New System.Drawing.Size(100, 22)
        Me.txtweeklypay.TabIndex = 7
        Me.txtweeklypay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployeerate
        '
        Me.txtEmployeerate.Location = New System.Drawing.Point(303, 83)
        Me.txtEmployeerate.Name = "txtEmployeerate"
        Me.txtEmployeerate.Size = New System.Drawing.Size(100, 22)
        Me.txtEmployeerate.TabIndex = 8
        Me.txtEmployeerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployerrate
        '
        Me.txtEmployerrate.Location = New System.Drawing.Point(300, 130)
        Me.txtEmployerrate.Name = "txtEmployerrate"
        Me.txtEmployerrate.Size = New System.Drawing.Size(100, 22)
        Me.txtEmployerrate.TabIndex = 9
        Me.txtEmployerrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(214, 281)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(122, 363)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(104, 35)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(344, 363)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 35)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmployercon
        '
        Me.lblEmployercon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployercon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployercon.Location = New System.Drawing.Point(232, 223)
        Me.lblEmployercon.Name = "lblEmployercon"
        Me.lblEmployercon.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployercon.TabIndex = 16
        Me.lblEmployercon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEmployeecon
        '
        Me.lblEmployeecon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeecon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeecon.Location = New System.Drawing.Point(235, 173)
        Me.lblEmployeecon.Name = "lblEmployeecon"
        Me.lblEmployeecon.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeecon.TabIndex = 17
        Me.lblEmployeecon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Clear
        '
        Me.Clear.AutoSize = True
        Me.Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(235, 363)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(104, 35)
        Me.Clear.TabIndex = 18
        Me.Clear.Text = "C&lear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 430)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.lblEmployeecon)
        Me.Controls.Add(Me.lblEmployercon)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtEmployerrate)
        Me.Controls.Add(Me.txtEmployeerate)
        Me.Controls.Add(Me.txtweeklypay)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtweeklypay As TextBox
    Friend WithEvents txtEmployeerate As TextBox
    Friend WithEvents txtEmployerrate As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEmployercon As Label
    Friend WithEvents lblEmployeecon As Label
    Friend WithEvents Clear As Button
End Class
