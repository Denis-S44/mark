﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblentermarks = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtEnterMarks = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblentermarks
        '
        Me.lblentermarks.AutoSize = True
        Me.lblentermarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblentermarks.Location = New System.Drawing.Point(308, 80)
        Me.lblentermarks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblentermarks.Name = "lblentermarks"
        Me.lblentermarks.Size = New System.Drawing.Size(117, 22)
        Me.lblentermarks.TabIndex = 0
        Me.lblentermarks.Text = "Enter Marks"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(324, 165)
        Me.lblGrade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(65, 22)
        Me.lblGrade.TabIndex = 1
        Me.lblGrade.Text = "Grade"
        '
        'txtEnterMarks
        '
        Me.txtEnterMarks.Location = New System.Drawing.Point(488, 80)
        Me.txtEnterMarks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEnterMarks.Name = "txtEnterMarks"
        Me.txtEnterMarks.Size = New System.Drawing.Size(277, 26)
        Me.txtEnterMarks.TabIndex = 2
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(494, 165)
        Me.txtGrade.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(271, 26)
        Me.txtGrade.TabIndex = 3
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluate.Location = New System.Drawing.Point(418, 268)
        Me.btnEvaluate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(230, 58)
        Me.btnEvaluate.TabIndex = 4
        Me.btnEvaluate.Text = "Evaluate"
        Me.btnEvaluate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtEnterMarks)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblentermarks)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "SSEBULIBA DENIS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblentermarks As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents txtEnterMarks As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnEvaluate As Button
End Class