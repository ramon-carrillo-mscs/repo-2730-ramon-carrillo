<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtProjIncrease = New System.Windows.Forms.TextBox()
        Me.lblCurrentSales = New System.Windows.Forms.Label()
        Me.lblProjectedSales = New System.Windows.Forms.Label()
        Me.lblStraw = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRas = New System.Windows.Forms.Label()
        Me.txtRas = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtStraw = New System.Windows.Forms.TextBox()
        Me.lblProjRas = New System.Windows.Forms.Label()
        Me.lblProjBlue = New System.Windows.Forms.Label()
        Me.lblProjStraw = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRetirement = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 28)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Projected increase % :"
        '
        'txtProjIncrease
        '
        Me.txtProjIncrease.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjIncrease.Location = New System.Drawing.Point(447, 37)
        Me.txtProjIncrease.Name = "txtProjIncrease"
        Me.txtProjIncrease.Size = New System.Drawing.Size(100, 30)
        Me.txtProjIncrease.TabIndex = 0
        Me.txtProjIncrease.Text = ".05"
        Me.txtProjIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrentSales
        '
        Me.lblCurrentSales.AutoSize = True
        Me.lblCurrentSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSales.Location = New System.Drawing.Point(249, 113)
        Me.lblCurrentSales.Name = "lblCurrentSales"
        Me.lblCurrentSales.Size = New System.Drawing.Size(126, 28)
        Me.lblCurrentSales.TabIndex = 11
        Me.lblCurrentSales.Text = "Current Sales"
        '
        'lblProjectedSales
        '
        Me.lblProjectedSales.AutoSize = True
        Me.lblProjectedSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectedSales.Location = New System.Drawing.Point(410, 112)
        Me.lblProjectedSales.Name = "lblProjectedSales"
        Me.lblProjectedSales.Size = New System.Drawing.Size(144, 28)
        Me.lblProjectedSales.TabIndex = 12
        Me.lblProjectedSales.Text = "Projected Sales"
        '
        'lblStraw
        '
        Me.lblStraw.AutoSize = True
        Me.lblStraw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraw.Location = New System.Drawing.Point(113, 165)
        Me.lblStraw.Name = "lblStraw"
        Me.lblStraw.Size = New System.Drawing.Size(123, 28)
        Me.lblStraw.TabIndex = 1
        Me.lblStraw.Text = "&Strawberries:"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(113, 238)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(112, 28)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "&Blueberries:"
        '
        'lblRas
        '
        Me.lblRas.AutoSize = True
        Me.lblRas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRas.Location = New System.Drawing.Point(113, 316)
        Me.lblRas.Name = "lblRas"
        Me.lblRas.Size = New System.Drawing.Size(117, 28)
        Me.lblRas.TabIndex = 5
        Me.lblRas.Text = "&Raspberries:"
        '
        'txtRas
        '
        Me.txtRas.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRas.Location = New System.Drawing.Point(254, 323)
        Me.txtRas.Name = "txtRas"
        Me.txtRas.Size = New System.Drawing.Size(100, 30)
        Me.txtRas.TabIndex = 6
        '
        'txtBlue
        '
        Me.txtBlue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlue.Location = New System.Drawing.Point(254, 245)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(100, 30)
        Me.txtBlue.TabIndex = 4
        '
        'txtStraw
        '
        Me.txtStraw.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStraw.Location = New System.Drawing.Point(254, 172)
        Me.txtStraw.Name = "txtStraw"
        Me.txtStraw.Size = New System.Drawing.Size(100, 30)
        Me.txtStraw.TabIndex = 2
        '
        'lblProjRas
        '
        Me.lblProjRas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjRas.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjRas.Location = New System.Drawing.Point(412, 325)
        Me.lblProjRas.Name = "lblProjRas"
        Me.lblProjRas.Size = New System.Drawing.Size(100, 30)
        Me.lblProjRas.TabIndex = 15
        '
        'lblProjBlue
        '
        Me.lblProjBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjBlue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjBlue.Location = New System.Drawing.Point(412, 247)
        Me.lblProjBlue.Name = "lblProjBlue"
        Me.lblProjBlue.Size = New System.Drawing.Size(100, 30)
        Me.lblProjBlue.TabIndex = 14
        '
        'lblProjStraw
        '
        Me.lblProjStraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjStraw.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjStraw.Location = New System.Drawing.Point(412, 174)
        Me.lblProjStraw.Name = "lblProjStraw"
        Me.lblProjStraw.Size = New System.Drawing.Size(100, 30)
        Me.lblProjStraw.TabIndex = 13
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(71, 418)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 33)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(356, 418)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 33)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(479, 418)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 33)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "E&xit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.rcarrillo1f1.My.Resources.Resources.berries
        Me.PictureBox1.Location = New System.Drawing.Point(25, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "(in decimal form)"
        '
        'btnRetirement
        '
        Me.btnRetirement.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetirement.Location = New System.Drawing.Point(185, 418)
        Me.btnRetirement.Name = "btnRetirement"
        Me.btnRetirement.Size = New System.Drawing.Size(154, 33)
        Me.btnRetirement.TabIndex = 16
        Me.btnRetirement.Text = "Retirement Form"
        Me.btnRetirement.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 485)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRetirement)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblProjStraw)
        Me.Controls.Add(Me.lblProjBlue)
        Me.Controls.Add(Me.lblProjRas)
        Me.Controls.Add(Me.txtStraw)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtRas)
        Me.Controls.Add(Me.lblRas)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblStraw)
        Me.Controls.Add(Me.lblProjectedSales)
        Me.Controls.Add(Me.lblCurrentSales)
        Me.Controls.Add(Me.txtProjIncrease)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtProjIncrease As TextBox
    Friend WithEvents lblCurrentSales As Label
    Friend WithEvents lblProjectedSales As Label
    Friend WithEvents lblStraw As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblRas As Label
    Friend WithEvents txtRas As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtStraw As TextBox
    Friend WithEvents lblProjRas As Label
    Friend WithEvents lblProjBlue As Label
    Friend WithEvents lblProjStraw As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRetirement As Button
End Class
