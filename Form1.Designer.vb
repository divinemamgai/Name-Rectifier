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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AutoStepModeButton = New System.Windows.Forms.Button()
        Me.PrecedeWithZeroButton = New System.Windows.Forms.Button()
        Me.NumberOfFilesLabel = New System.Windows.Forms.Label()
        Me.ExcludeFileTypesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ExcludeFileTypesLabel = New System.Windows.Forms.Label()
        Me.FileNameFormatTextBox = New System.Windows.Forms.TextBox()
        Me.FileNameFormatLabel = New System.Windows.Forms.Label()
        Me.SelectFilesButton = New System.Windows.Forms.Button()
        Me.ProcessRectificationButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.FilesDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderDialogs = New System.Windows.Forms.OpenFileDialog()
        Me.LogGroupBox = New System.Windows.Forms.GroupBox()
        Me.CloseLogButton = New System.Windows.Forms.Button()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProcessRectification = New System.ComponentModel.BackgroundWorker()
        Me.DuplicateChecker = New System.ComponentModel.BackgroundWorker()
        Me.ProcessExclusion = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.LogGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.AutoStepModeButton)
        Me.GroupBox1.Controls.Add(Me.PrecedeWithZeroButton)
        Me.GroupBox1.Controls.Add(Me.NumberOfFilesLabel)
        Me.GroupBox1.Controls.Add(Me.ExcludeFileTypesRichTextBox)
        Me.GroupBox1.Controls.Add(Me.ExcludeFileTypesLabel)
        Me.GroupBox1.Controls.Add(Me.FileNameFormatTextBox)
        Me.GroupBox1.Controls.Add(Me.FileNameFormatLabel)
        Me.GroupBox1.Controls.Add(Me.SelectFilesButton)
        Me.GroupBox1.Controls.Add(Me.ProcessRectificationButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Rectifier"
        '
        'AutoStepModeButton
        '
        Me.AutoStepModeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutoStepModeButton.Location = New System.Drawing.Point(368, 154)
        Me.AutoStepModeButton.Name = "AutoStepModeButton"
        Me.AutoStepModeButton.Size = New System.Drawing.Size(127, 27)
        Me.AutoStepModeButton.TabIndex = 15
        Me.AutoStepModeButton.Text = "Auto Step Mode"
        Me.AutoStepModeButton.UseVisualStyleBackColor = True
        '
        'PrecedeWithZeroButton
        '
        Me.PrecedeWithZeroButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrecedeWithZeroButton.Location = New System.Drawing.Point(276, 21)
        Me.PrecedeWithZeroButton.Name = "PrecedeWithZeroButton"
        Me.PrecedeWithZeroButton.Size = New System.Drawing.Size(132, 27)
        Me.PrecedeWithZeroButton.TabIndex = 14
        Me.PrecedeWithZeroButton.Text = "Precede With 0 - On"
        Me.ToolTip.SetToolTip(Me.PrecedeWithZeroButton, "Precedes with zero when calculating any expression if the digits are less then th" & _
        "e maximum number of digits expected.")
        Me.PrecedeWithZeroButton.UseVisualStyleBackColor = True
        Me.PrecedeWithZeroButton.Visible = False
        '
        'NumberOfFilesLabel
        '
        Me.NumberOfFilesLabel.AutoSize = True
        Me.NumberOfFilesLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfFilesLabel.Location = New System.Drawing.Point(8, 27)
        Me.NumberOfFilesLabel.Name = "NumberOfFilesLabel"
        Me.NumberOfFilesLabel.Size = New System.Drawing.Size(106, 15)
        Me.NumberOfFilesLabel.TabIndex = 13
        Me.NumberOfFilesLabel.Text = "Number Of Files : "
        Me.NumberOfFilesLabel.Visible = False
        '
        'ExcludeFileTypesRichTextBox
        '
        Me.ExcludeFileTypesRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExcludeFileTypesRichTextBox.Location = New System.Drawing.Point(7, 54)
        Me.ExcludeFileTypesRichTextBox.Name = "ExcludeFileTypesRichTextBox"
        Me.ExcludeFileTypesRichTextBox.Size = New System.Drawing.Size(488, 63)
        Me.ExcludeFileTypesRichTextBox.TabIndex = 12
        Me.ExcludeFileTypesRichTextBox.Text = ""
        '
        'ExcludeFileTypesLabel
        '
        Me.ExcludeFileTypesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExcludeFileTypesLabel.AutoSize = True
        Me.ExcludeFileTypesLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExcludeFileTypesLabel.Location = New System.Drawing.Point(8, 75)
        Me.ExcludeFileTypesLabel.Name = "ExcludeFileTypesLabel"
        Me.ExcludeFileTypesLabel.Size = New System.Drawing.Size(464, 15)
        Me.ExcludeFileTypesLabel.TabIndex = 12
        Me.ExcludeFileTypesLabel.Text = "Exclude File Types : [Format : srt,flv {This will exclude files having types - sr" & _
    "t and flv.}]"
        '
        'FileNameFormatTextBox
        '
        Me.FileNameFormatTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileNameFormatTextBox.Location = New System.Drawing.Point(120, 125)
        Me.FileNameFormatTextBox.Name = "FileNameFormatTextBox"
        Me.FileNameFormatTextBox.Size = New System.Drawing.Size(242, 23)
        Me.FileNameFormatTextBox.TabIndex = 9
        '
        'FileNameFormatLabel
        '
        Me.FileNameFormatLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FileNameFormatLabel.AutoSize = True
        Me.FileNameFormatLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileNameFormatLabel.Location = New System.Drawing.Point(8, 128)
        Me.FileNameFormatLabel.Name = "FileNameFormatLabel"
        Me.FileNameFormatLabel.Size = New System.Drawing.Size(112, 15)
        Me.FileNameFormatLabel.TabIndex = 8
        Me.FileNameFormatLabel.Text = "File Name Format :"
        '
        'SelectFilesButton
        '
        Me.SelectFilesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectFilesButton.Location = New System.Drawing.Point(414, 21)
        Me.SelectFilesButton.Name = "SelectFilesButton"
        Me.SelectFilesButton.Size = New System.Drawing.Size(81, 27)
        Me.SelectFilesButton.TabIndex = 2
        Me.SelectFilesButton.Text = "Select Files"
        Me.SelectFilesButton.UseVisualStyleBackColor = True
        '
        'ProcessRectificationButton
        '
        Me.ProcessRectificationButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessRectificationButton.Location = New System.Drawing.Point(368, 123)
        Me.ProcessRectificationButton.Name = "ProcessRectificationButton"
        Me.ProcessRectificationButton.Size = New System.Drawing.Size(127, 27)
        Me.ProcessRectificationButton.TabIndex = 0
        Me.ProcessRectificationButton.Text = "Process Rectification"
        Me.ProcessRectificationButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.RichTextBox3)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(501, 221)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "File Name Format Functions"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox3.Location = New System.Drawing.Point(7, 22)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(488, 193)
        Me.RichTextBox3.TabIndex = 11
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        '
        'FilesDialog
        '
        Me.FilesDialog.Multiselect = True
        '
        'FolderDialogs
        '
        Me.FolderDialogs.Multiselect = True
        '
        'LogGroupBox
        '
        Me.LogGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogGroupBox.Controls.Add(Me.CloseLogButton)
        Me.LogGroupBox.Controls.Add(Me.Log)
        Me.LogGroupBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.LogGroupBox.Name = "LogGroupBox"
        Me.LogGroupBox.Size = New System.Drawing.Size(502, 415)
        Me.LogGroupBox.TabIndex = 3
        Me.LogGroupBox.TabStop = False
        Me.LogGroupBox.Text = "Log"
        '
        'CloseLogButton
        '
        Me.CloseLogButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseLogButton.Location = New System.Drawing.Point(6, 379)
        Me.CloseLogButton.Name = "CloseLogButton"
        Me.CloseLogButton.Size = New System.Drawing.Size(490, 30)
        Me.CloseLogButton.TabIndex = 1
        Me.CloseLogButton.Text = "Close Log"
        Me.CloseLogButton.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Log.Location = New System.Drawing.Point(6, 22)
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.Size = New System.Drawing.Size(490, 354)
        Me.Log.TabIndex = 0
        Me.Log.Text = ""
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        '
        'ProcessRectification
        '
        '
        'DuplicateChecker
        '
        '
        'ProcessExclusion
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 439)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LogGroupBox)
        Me.Name = "Form1"
        Me.Text = "Name Rectifier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.LogGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProcessRectificationButton As System.Windows.Forms.Button
    Friend WithEvents SelectFilesButton As System.Windows.Forms.Button
    Friend WithEvents FileNameFormatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FileNameFormatLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents FilesDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderDialogs As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ExcludeFileTypesLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfFilesLabel As System.Windows.Forms.Label
    Friend WithEvents ExcludeFileTypesRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents LogGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents CloseLogButton As System.Windows.Forms.Button
    Friend WithEvents PrecedeWithZeroButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ProcessRectification As System.ComponentModel.BackgroundWorker
    Friend WithEvents DuplicateChecker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProcessExclusion As System.ComponentModel.BackgroundWorker
    Friend WithEvents AutoStepModeButton As System.Windows.Forms.Button

End Class
