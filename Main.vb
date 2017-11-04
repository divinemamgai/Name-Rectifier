Imports Eval3
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text

Public Class Main

    Dim FilePaths() As String = Nothing,
        FileFolderPaths() As String = Nothing,
        FileNames() As String = Nothing,
        ProcessedFileNames() As String = Nothing,
        FileTypes() As String = Nothing,
        NumberOfFiles As Integer = 0,
        PrecedeWithZero As Boolean = True,
        FileTypeCase As Integer = 0,
        MathFunctionRegex As Regex = New Regex("\?([^\?]*)\?"),
        StringFunctionRegex As Regex = New Regex("\|([^\|]*)\|"),
        StringExpressionRegexs() As Regex = {New Regex("F\/(\d+)"),
                                             New Regex("F\\(\d+)"),
                                             New Regex("F\>(.*)"),
                                             New Regex("F\<(.*)"),
                                             New Regex("F:(.*)\>(.*)"),
                                             New Regex("F*W"),
                                             New Regex("F*w"),
                                             New Regex("F\*(.*)\>(.*)"),
                                             New Regex("F\*(.*)\<(.*)"),
                                             New Regex("F")},
        ExcludeFileTypesRaw As String = Nothing,
        ExcludeFileTypes() As String = Nothing,
        ExclusionArray() As Boolean = Nothing,
        ExclusionCount As Integer = 0,
        ProcessExclusionFlag As Boolean = False,
        ForceRename As Boolean = False

    Public Sub EnableDisableFileRectifier(ByVal Enable As Boolean)
        ExcludeFileTypesLabel.Enabled = Enable
        ExcludeFileTypesRichTextBox.Enabled = Enable
        FileNameFormatLabel.Enabled = Enable
        FileNameFormatTextBox.Enabled = Enable
        PrecedeWithZeroButton.Enabled = Enable
        FileTypeCaseButton.Enabled = Enable
        ProcessRectificationButton.Enabled = Enable
        AutoStepModeButton.Enabled = Enable
    End Sub

    Public Sub ProcessFilePaths()
        Dim Extent As Integer = NumberOfFiles - 1,
            PositionOfBackSlash As Integer = 0,
            PositionOfDot As Integer = 0,
            FilePath As String = Nothing
        For Count As Integer = 0 To Extent
            FilePath = FilePaths(Count)
            PositionOfBackSlash = FilePath.LastIndexOf("\")
            PositionOfDot = FilePath.LastIndexOf(".")
            ReDim Preserve FileNames(Count),
                           FileTypes(Count),
                           FileFolderPaths(Count)
            FileNames(Count) = FilePath.Substring(PositionOfBackSlash + 1, PositionOfDot - PositionOfBackSlash - 1)
            FileTypes(Count) = FilePath.Substring(PositionOfDot + 1, FilePath.Length - PositionOfDot - 1)
            FileFolderPaths(Count) = FilePath.Substring(0, PositionOfBackSlash + 1)
        Next
    End Sub

    Public Function NumberOfDigits(ByVal Input As Integer) As Integer
        Return CStr(Input).Length
    End Function

    Enum ExtendTo
        Right = 1
        Left = 2
    End Enum

    Private Function ExtendString(ByVal Input As String, ByVal ExtendChar As String, ByVal Length As Integer,
                                  Optional ByVal ExtendToType As Integer = ExtendTo.Left) As String
        Dim Result As New StringBuilder()
        If Input.Length >= Length Then
            Return Input
        Else
            If ExtendToType = ExtendTo.Right Then
                Result.Append(Input)
            End If
            For Count As Integer = 1 To Length - Input.Length
                Result.Append(ExtendChar)
            Next
            If ExtendToType = ExtendTo.Left Then
                Result.Append(Input)
            End If
            Return Result.ToString
        End If
    End Function

    Private Sub ProcessExclusionDoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ProcessExclusion.DoWork
        ExclusionCount = 0
        If ProcessExclusionFlag = True Then
            ExcludeFileTypes = ExcludeFileTypesRaw.Split(",")
            Dim ExtentFileTypes As Integer = NumberOfFiles - 1,
                ExtentExcludeFileTypes As Integer = ExcludeFileTypes.Length - 1,
                FileType As String = Nothing
            For OutterCount As Integer = 0 To ExtentFileTypes
                FileType = FileTypes(OutterCount)
                ReDim Preserve ExclusionArray(OutterCount)
                ExclusionArray(OutterCount) = False
                For InnerCount As Integer = 0 To ExtentExcludeFileTypes
                    If String.Compare(FileType, ExcludeFileTypes(InnerCount)) = False Then
                        ExclusionArray(OutterCount) = True
                        ExclusionCount = ExclusionCount + 1
                        Exit For
                    End If
                Next
            Next
        Else
            Dim ExtentFileTypes As Integer = NumberOfFiles - 1
            For OutterCount As Integer = 0 To ExtentFileTypes
                ReDim Preserve ExclusionArray(OutterCount)
                ExclusionArray(OutterCount) = False
            Next
        End If
    End Sub

    Private Sub ProcessExclusionCompleted(ByVal sender As System.Object,
                                          ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ProcessExclusion.RunWorkerCompleted
        If ProcessExclusionFlag = True Then
            AddToLog("     Done, Number Of Files To Be Excluded : " & CStr(ExclusionCount))
        End If
        If FileNameFormatTextBox.TextLength <> 0 Then
            AddToLog("Processing File Names...")
            ProcessRectification.RunWorkerAsync()
        Else
            MessageBox.Show("Please provide a file name format.", "No File Name Format Provided!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function UpperCaseFirstLetter(ByVal Input As String) As String
        Dim StringArray() As Char = Input.ToCharArray()
        StringArray(0) = Char.ToUpper(StringArray(0))
        Return New String(StringArray)
    End Function

    Private Function LowerCaseFirstLetter(ByVal Input As String) As String
        Dim StringArray() As Char = Input.ToCharArray()
        StringArray(0) = Char.ToLower(StringArray(0))
        Return New String(StringArray)
    End Function

    Private Sub FileTypeCaseButtonClick(sender As Object, e As EventArgs) Handles FileTypeCaseButton.Click
        FileTypeCase = (FileTypeCase + 1) Mod 3
        Select Case FileTypeCase
            Case 0
                FileTypeCaseButton.Text = "File Type Letter-Case - Off"
            Case 1
                FileTypeCaseButton.Text = "File Type Letter-Case - Lower"
            Case 2
                FileTypeCaseButton.Text = "File Type Letter-Case - Upper"
        End Select
    End Sub

    Private Sub ProcessRectificationDoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ProcessRectification.DoWork
        Dim FileNameFormat As String = FileNameFormatTextBox.Text,
            Extent As Integer = NumberOfFiles - 1,
            MathFunctionMatch As Match = Nothing,
            MathFunction As String = Nothing,
            MathFunctionEvaluator As New Evaluator,
            MathFunctionValue As Integer = Nothing,
            MathMaxFunctionValue As Integer = Nothing,
            StringFunctionMatch As Match = Nothing,
            StringFunction As String = Nothing,
            StringFunctionValue As String = Nothing,
            StringExpressionMatch As Match = Nothing,
            StringExpressionValues() As String = Nothing,
            FileName As String = Nothing,
            CurrentFileName As String = Nothing
        For Count As Integer = 0 To Extent
            If ExclusionArray(Count) = False Then
                FileName = FileNameFormat
                CurrentFileName = FileNames(Count)
                ' Processing mathematical expression.
                MathFunctionMatch = MathFunctionRegex.Match(FileName)
                While MathFunctionMatch.Success = True
                    MathFunction = MathFunctionMatch.Groups(1).Value
                    Try
                        MathFunctionValue = MathFunctionEvaluator.Parse(MathFunction.Replace("N", CStr(Count + 1))).value
                    Catch ex As Exception
                        MathFunctionValue = 0
                    End Try
                    If PrecedeWithZero = True Then
                        Try
                            MathMaxFunctionValue = MathFunctionEvaluator.Parse(MathFunction.Replace("N", CStr(NumberOfFiles))).value
                        Catch ex As Exception
                            MathMaxFunctionValue = 0
                        End Try
                        FileName = FileName.Replace(MathFunctionMatch.Value, ExtendString(CStr(MathFunctionValue), "0", NumberOfDigits(CStr(MathMaxFunctionValue))))
                    Else
                        FileName = FileName.Replace(MathFunctionMatch.Value, CStr(MathFunctionValue))
                    End If
                    MathFunctionMatch = MathFunctionMatch.NextMatch()
                End While
                ' Processing string expression.
                StringFunctionMatch = StringFunctionRegex.Match(FileName)
                While StringFunctionMatch.Success = True
                    StringFunction = StringFunctionMatch.Value
                    StringFunctionValue = StringFunctionMatch.Groups(1).Value
                    For RegexCount As Integer = 0 To StringExpressionRegexs.Length - 1
                        StringExpressionMatch = StringExpressionRegexs(RegexCount).Match(StringFunctionValue)
                        While StringExpressionMatch.Success = True
                            For MatchCount As Integer = 1 To StringExpressionMatch.Groups.Count
                                ReDim Preserve StringExpressionValues(MatchCount - 1)
                                StringExpressionValues(MatchCount - 1) = CStr(StringExpressionMatch.Groups(MatchCount).Value)
                            Next
                            Select Case RegexCount
                                Case 0
                                    Dim Temp As Integer = CInt(StringExpressionValues(0))
                                    If Temp < 0 Or Temp >= CurrentFileName.Length Then
                                        FileName = FileName.Replace(StringFunction, CurrentFileName)
                                    Else
                                        FileName = FileName.Replace(StringFunction,
                                                                    CurrentFileName.Substring(Temp, CurrentFileName.Length - Temp))
                                    End If
                                Case 1
                                    Dim Temp As Integer = CInt(StringExpressionValues(0))
                                    If Temp < 0 Or Temp >= CurrentFileName.Length Then
                                        FileName = FileName.Replace(StringFunction, CurrentFileName)
                                    Else
                                        FileName = FileName.Replace(StringFunction,
                                                                    CurrentFileName.Substring(0, CurrentFileName.Length - Temp))
                                    End If
                                Case 2
                                    FileName = FileName.Replace(StringFunction, CurrentFileName + StringExpressionValues(0))
                                Case 3
                                    FileName = FileName.Replace(StringFunction, StringExpressionValues(0) + CurrentFileName)
                                Case 4
                                    FileName = FileName.Replace(StringFunction, CurrentFileName.Replace(StringExpressionValues(0),
                                                                                                                              StringExpressionValues(1)))
                                Case 5
                                    ForceRename = True
                                    Dim StringWords() As String = CurrentFileName.Split(New Char() {" "c}),
                                        NewFileNameBuilder As New StringBuilder
                                    For WordCount As Integer = 0 To StringWords.Length - 1
                                        NewFileNameBuilder.Append(UpperCaseFirstLetter(StringWords(WordCount)))
                                        If WordCount <> StringWords.Length - 1 Then
                                            NewFileNameBuilder.Append(" ")
                                        End If
                                    Next
                                    FileName = FileName.Replace(StringFunction, NewFileNameBuilder.ToString())
                                Case 6
                                    ForceRename = True
                                    Dim StringWords() As String = CurrentFileName.Split(New Char() {" "c}),
                                        NewFileNameBuilder As New StringBuilder
                                    For WordCount As Integer = 0 To StringWords.Length - 1
                                        NewFileNameBuilder.Append(LowerCaseFirstLetter(StringWords(WordCount)))
                                        If WordCount <> StringWords.Length - 1 Then
                                            NewFileNameBuilder.Append(" ")
                                        End If
                                    Next
                                    FileName = FileName.Replace(StringFunction, NewFileNameBuilder.ToString())
                                Case 7
                                    ForceRename = True
                                    Dim ReplaceRegex As Regex = Nothing,
                                        ReplaceMatch As Match = Nothing,
                                        ReplaceName As String = CurrentFileName
                                    Try
                                        ReplaceRegex = New Regex(StringExpressionValues(0))
                                        ReplaceMatch = ReplaceRegex.Match(ReplaceName)
                                        While ReplaceMatch.Success = True
                                            ReplaceName = ReplaceName.Replace(ReplaceMatch.Value, StringExpressionValues(1))
                                            ReplaceMatch = ReplaceMatch.NextMatch()
                                        End While
                                    Catch ex As Exception
                                        MessageBox.Show("Invalid Regex, please try again with a valid regex.\nInformation: " & ex.Message, "Regex Error!",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                    FileName = FileName.Replace(StringFunction, ReplaceName)
                                Case 8
                                    ForceRename = True
                                    Dim ReplaceRegex As Regex = Nothing,
                                        ReplaceMatch As Match = Nothing,
                                        ReplaceName As String = CurrentFileName
                                    Try
                                        ReplaceRegex = New Regex(StringExpressionValues(0))
                                        ReplaceMatch = ReplaceRegex.Match(ReplaceName)
                                        While ReplaceMatch.Success = True
                                            Dim ReplaceMatchExtent As Integer = ReplaceMatch.Groups.Count
                                            For ReplaceMatchCount As Integer = 1 To ReplaceMatchExtent
                                                ReplaceName = ReplaceName.Replace(ReplaceMatch.Groups(ReplaceMatchCount).Value, StringExpressionValues(1))
                                            Next
                                            ReplaceMatch = ReplaceMatch.NextMatch()
                                        End While
                                    Catch ex As Exception
                                        MessageBox.Show("Invalid Regex, please try again with a valid regex.\nInformation: " & ex.Message, "Regex Error!",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                    FileName = FileName.Replace(StringFunction, ReplaceName)
                                Case 9
                                    FileName = FileName.Replace(StringFunction, CurrentFileName)
                            End Select
                            StringExpressionMatch = StringExpressionMatch.NextMatch()
                        End While
                    Next
                    StringFunctionMatch = StringFunctionMatch.NextMatch()
                End While
                ReDim Preserve ProcessedFileNames(Count)
                ProcessedFileNames(Count) = FileName
                Select Case FileTypeCase
                    Case 1
                        FileTypes(Count) = FileTypes(Count).ToLower()
                    Case 2
                        FileTypes(Count) = FileTypes(Count).ToUpper()
                End Select
            End If
        Next
    End Sub

    Private Sub ProcessRectificationCompleted(ByVal sender As System.Object,
                                              ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ProcessRectification.RunWorkerCompleted
        AddToLog("     Done!")
        AddToLog("Checking For Duplicacy In File Names...")
        DuplicateChecker.RunWorkerAsync()
    End Sub

    Private Sub DuplicateCheckerDoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles DuplicateChecker.DoWork
        Dim Extent As Integer = NumberOfFiles - 1
        For OuterCount As Integer = 0 To Extent
            For InnerCount As Integer = 0 To Extent
                If OuterCount <> InnerCount Then
                    If String.Compare(ProcessedFileNames(OuterCount), ProcessedFileNames(InnerCount)) = False Then
                        MessageBox.Show("Current file format is generating duplicate file names. Please cross-check the file format expressions.",
                                        "Duplicate File Names!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub DuplicateCheckerCompleted(ByVal sender As System.Object,
                                          ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles DuplicateChecker.RunWorkerCompleted
        AddToLog("No Duplicates Found, Proceeding With Rectification...")
        Dim Extent As Integer = NumberOfFiles - 1
        For Count As Integer = 0 To Extent
            AddToLog("     " & CStr(Count + 1) & ". File Path : """ & CompressedFilePath(FilePaths(Count)) & """")
            AddToLog("          Old Name : """ & FileNames(Count) & """")
            AddToLog("          File Type : " & FileTypes(Count))
            If ExclusionArray(Count) = False Then
                AddToLog("          New Name : """ & ProcessedFileNames(Count) & """")
                AddToLog("          Rectifying...")
                If File.Exists(FilePaths(Count)) Then
                    If ForceRename = True Then
                        Dim NameTryCount As Integer = 0,
                            NameTried As String = Nothing,
                            IsNameAvailable As Boolean = False
                        While IsNameAvailable = False
                            Try
                                NameTried = ProcessedFileNames(Count) & "_" & CStr(NameTryCount) & "." & FileTypes(Count)
                                My.Computer.FileSystem.RenameFile(FilePaths(Count), NameTried)
                                IsNameAvailable = True
                            Catch ex As Exception
                                NameTryCount = NameTryCount + 1
                                IsNameAvailable = False
                            End Try
                        End While
                        Try
                            My.Computer.FileSystem.RenameFile(FileFolderPaths(Count) + NameTried, ProcessedFileNames(Count) & "." & FileTypes(Count))
                            AddToLog("               Done!")
                        Catch ex As Exception
                            AddToLog("               Error : " & ex.Message)
                        End Try
                    Else
                        Try
                            My.Computer.FileSystem.RenameFile(FilePaths(Count), ProcessedFileNames(Count) & "." & FileTypes(Count))
                            AddToLog("               Done!")
                        Catch ex As Exception
                            AddToLog("               Error : " & ex.Message)
                        End Try
                    End If
                Else
                    AddToLog("               Error: File already exists with that name.")
                End If
            Else
                AddToLog("          File Excluded!")
            End If
        Next
    End Sub

    Private Sub RenewData()
        ForceRename = False
        FileNames = ProcessedFileNames
        Dim Extent As Integer = NumberOfFiles - 1
        For Count As Integer = 0 To Extent
            If ExclusionArray(Count) = False Then
                FilePaths(Count) = FileFolderPaths(Count) + FileNames(Count) + "." + FileTypes(Count)
            End If
        Next
    End Sub

    Private Sub SelectFilesButtonClick(sender As Object, e As EventArgs) Handles SelectFilesButton.Click
        FilesDialog.Title = "Load Files"
        Try
            If FilesDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                NumberOfFilesLabel.Text = "Number Of Files : " + CStr(FilesDialog.FileNames.Length)
                NumberOfFilesLabel.Show()
                EnableDisableFileRectifier(True)
                FilePaths = FilesDialog.FileNames
                NumberOfFiles = FilePaths.Length
                ProcessFilePaths()
            Else
                NumberOfFilesLabel.Hide()
                EnableDisableFileRectifier(False)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the files!" & vbCrLf & vbCrLf & "Exception.Message : " + ex.Message, "Error In Opening Files!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogGroupBox.Hide()
        LogGroupBox.SendToBack()
        EnableDisableFileRectifier(False)
    End Sub

    Private Sub PrecedeWithZeroButonClick(sender As Object, e As EventArgs) Handles PrecedeWithZeroButton.Click
        If PrecedeWithZero = False Then
            PrecedeWithZero = True
            PrecedeWithZeroButton.Text = "Precede With 0 - On"
        Else
            PrecedeWithZero = False
            PrecedeWithZeroButton.Text = "Precede With 0 - Off"
        End If
    End Sub

    Private Sub AddToLog(ByVal Input As String)
        Dim LogBuilder As New StringBuilder()
        LogBuilder.Append(Log.Text)
        LogBuilder.Append(vbCrLf)
        LogBuilder.Append(Input)
        Log.Text = LogBuilder.ToString()
    End Sub

    Private Function CompressedFilePath(ByVal Input As String, Optional ByVal MaxLength As Integer = 100) As String
        Dim Output As String = ""
        If Input.Length > MaxLength Then
            Output = Input.Substring(0, (MaxLength / 2) - 3)
            Output = Output + "..."
            Output = Output + Input.Substring(Input.Length - (MaxLength / 2) - 1, MaxLength / 2)
        Else
            Return Input
        End If
        Return Output
    End Function

    Private Sub ProcessRectificationButtonClick(sender As Object, e As EventArgs) Handles ProcessRectificationButton.Click
        If NumberOfFiles <> 0 And FileNameFormatTextBox.TextLength <> 0 Then
            LogGroupBox.Show()
            LogGroupBox.BringToFront()
            Log.Text = "Starting Rectification Of Files..."
            If ProcessExclusionFlag = True Then
                AddToLog("Processing Exclusion Types...")
            End If
            ProcessExclusion.RunWorkerAsync()
        Else
            MessageBox.Show("File name format cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LogChange(sender As Object, e As EventArgs) Handles Log.TextChanged
        Log.SelectionStart = Log.Text.Length
        Log.ScrollToCaret()
    End Sub
    Private Sub ExcludeFileTypesRichTextBoxTextChanged(sender As Object, e As EventArgs) Handles ExcludeFileTypesRichTextBox.TextChanged
        ExcludeFileTypesRaw = ExcludeFileTypesRichTextBox.Text
        If ExcludeFileTypesRichTextBox.TextLength <> 0 Then
            ProcessExclusionFlag = True
        Else
            ProcessExclusionFlag = False
        End If
    End Sub

    Private Sub CloseLogButtonClick(sender As Object, e As EventArgs) Handles CloseLogButton.Click
        RenewData()
        LogGroupBox.Hide()
        LogGroupBox.SendToBack()
    End Sub

    Private Sub AutoStepModeButtonClick(sender As Object, e As EventArgs) Handles AutoStepModeButton.Click
        AutoStepMode.ShowDialog()
    End Sub
End Class
