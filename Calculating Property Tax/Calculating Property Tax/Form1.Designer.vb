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
        Me.btnCalculatePropertyTax = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAssessmentValue = New System.Windows.Forms.Label()
        Me.lblPropertyTax = New System.Windows.Forms.Label()
        Me.txtActualPropertyValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculatePropertyTax
        '
        Me.btnCalculatePropertyTax.Location = New System.Drawing.Point(28, 182)
        Me.btnCalculatePropertyTax.Name = "btnCalculatePropertyTax"
        Me.btnCalculatePropertyTax.Size = New System.Drawing.Size(75, 42)
        Me.btnCalculatePropertyTax.TabIndex = 0
        Me.btnCalculatePropertyTax.Text = "Calculate Property Tax"
        Me.btnCalculatePropertyTax.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(132, 182)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 42)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(238, 182)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 42)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Actual Property Value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Assessment Value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Property Tax:"
        '
        'lblAssessmentValue
        '
        Me.lblAssessmentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAssessmentValue.Location = New System.Drawing.Point(143, 105)
        Me.lblAssessmentValue.Name = "lblAssessmentValue"
        Me.lblAssessmentValue.Size = New System.Drawing.Size(170, 20)
        Me.lblAssessmentValue.TabIndex = 6
        '
        'lblPropertyTax
        '
        Me.lblPropertyTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPropertyTax.Location = New System.Drawing.Point(143, 136)
        Me.lblPropertyTax.Name = "lblPropertyTax"
        Me.lblPropertyTax.Size = New System.Drawing.Size(170, 20)
        Me.lblPropertyTax.TabIndex = 7
        '
        'txtActualPropertyValue
        '
        Me.txtActualPropertyValue.Location = New System.Drawing.Point(143, 67)
        Me.txtActualPropertyValue.Name = "txtActualPropertyValue"
        Me.txtActualPropertyValue.Size = New System.Drawing.Size(170, 20)
        Me.txtActualPropertyValue.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 246)
        Me.Controls.Add(Me.txtActualPropertyValue)
        Me.Controls.Add(Me.lblPropertyTax)
        Me.Controls.Add(Me.lblAssessmentValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculatePropertyTax)
        Me.Name = "Form1"
        Me.Text = "Property Tax Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculatePropertyTax As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAssessmentValue As Label
    Friend WithEvents lblPropertyTax As Label
    Friend WithEvents txtActualPropertyValue As TextBox
End Class
