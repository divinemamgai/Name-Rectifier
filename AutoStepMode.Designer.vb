<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoStepMode
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
        Me.CurrentStepsGroupBox = New System.Windows.Forms.GroupBox()
        Me.AddStepsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddCountType1Button = New System.Windows.Forms.Button()
        Me.ProcessStepsButton = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CurrentStepsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddStepsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CurrentStepsGroupBox.SuspendLayout()
        Me.AddStepsGroupBox.SuspendLayout()
        Me.AddStepsFlowLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CurrentStepsGroupBox
        '
        Me.CurrentStepsGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentStepsGroupBox.Controls.Add(Me.CurrentStepsFlowLayoutPanel)
        Me.CurrentStepsGroupBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentStepsGroupBox.Location = New System.Drawing.Point(354, 48)
        Me.CurrentStepsGroupBox.Name = "CurrentStepsGroupBox"
        Me.CurrentStepsGroupBox.Size = New System.Drawing.Size(325, 353)
        Me.CurrentStepsGroupBox.TabIndex = 2
        Me.CurrentStepsGroupBox.TabStop = False
        Me.CurrentStepsGroupBox.Text = "Current Steps"
        '
        'AddStepsGroupBox
        '
        Me.AddStepsGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddStepsGroupBox.Controls.Add(Me.AddStepsFlowLayoutPanel)
        Me.AddStepsGroupBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStepsGroupBox.Location = New System.Drawing.Point(12, 48)
        Me.AddStepsGroupBox.Name = "AddStepsGroupBox"
        Me.AddStepsGroupBox.Size = New System.Drawing.Size(325, 353)
        Me.AddStepsGroupBox.TabIndex = 1
        Me.AddStepsGroupBox.TabStop = False
        Me.AddStepsGroupBox.Text = "Add Steps"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(3, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(290, 30)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "Remove Matched Values Using Regex"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(3, 75)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(290, 30)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Replace Matched Group Values Using Regex"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(3, 111)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(290, 30)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Replace Matched Values Using Regex"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(3, 147)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(290, 30)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Lowercase Every Word's First Character"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(3, 183)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(290, 30)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Uppercase Every Word's First Character"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(3, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(290, 30)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Append String"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 255)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(290, 30)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Prepend String"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(290, 30)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Replace A String With Another One"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(290, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add Count Type Two [Eg.: 1)]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddCountType1Button
        '
        Me.AddCountType1Button.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCountType1Button.Location = New System.Drawing.Point(3, 363)
        Me.AddCountType1Button.Name = "AddCountType1Button"
        Me.AddCountType1Button.Size = New System.Drawing.Size(290, 30)
        Me.AddCountType1Button.TabIndex = 6
        Me.AddCountType1Button.Text = "Add Count Type One [Eg.: 1.]"
        Me.AddCountType1Button.UseVisualStyleBackColor = True
        '
        'ProcessStepsButton
        '
        Me.ProcessStepsButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessStepsButton.Location = New System.Drawing.Point(18, 12)
        Me.ProcessStepsButton.Name = "ProcessStepsButton"
        Me.ProcessStepsButton.Size = New System.Drawing.Size(661, 30)
        Me.ProcessStepsButton.TabIndex = 5
        Me.ProcessStepsButton.Text = "Process Steps"
        Me.ProcessStepsButton.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(3, 39)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(290, 30)
        Me.Button10.TabIndex = 16
        Me.Button10.Text = "Remove Matched Group Values Using Regex"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'CurrentStepsFlowLayoutPanel
        '
        Me.CurrentStepsFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentStepsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CurrentStepsFlowLayoutPanel.Location = New System.Drawing.Point(7, 22)
        Me.CurrentStepsFlowLayoutPanel.Name = "CurrentStepsFlowLayoutPanel"
        Me.CurrentStepsFlowLayoutPanel.Size = New System.Drawing.Size(312, 324)
        Me.CurrentStepsFlowLayoutPanel.TabIndex = 0
        '
        'AddStepsFlowLayoutPanel
        '
        Me.AddStepsFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddStepsFlowLayoutPanel.AutoScroll = True
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button9)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button10)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button8)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button7)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button6)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button5)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button4)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button3)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button2)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.Button1)
        Me.AddStepsFlowLayoutPanel.Controls.Add(Me.AddCountType1Button)
        Me.AddStepsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.AddStepsFlowLayoutPanel.Location = New System.Drawing.Point(6, 22)
        Me.AddStepsFlowLayoutPanel.Name = "AddStepsFlowLayoutPanel"
        Me.AddStepsFlowLayoutPanel.Size = New System.Drawing.Size(313, 324)
        Me.AddStepsFlowLayoutPanel.TabIndex = 0
        Me.AddStepsFlowLayoutPanel.WrapContents = False
        '
        'AutoStepMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 413)
        Me.Controls.Add(Me.ProcessStepsButton)
        Me.Controls.Add(Me.CurrentStepsGroupBox)
        Me.Controls.Add(Me.AddStepsGroupBox)
        Me.Name = "AutoStepMode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Auto Step Mode"
        Me.CurrentStepsGroupBox.ResumeLayout(False)
        Me.AddStepsGroupBox.ResumeLayout(False)
        Me.AddStepsFlowLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CurrentStepsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AddStepsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ProcessStepsButton As System.Windows.Forms.Button
    Friend WithEvents AddCountType1Button As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents CurrentStepsFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents AddStepsFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
End Class
