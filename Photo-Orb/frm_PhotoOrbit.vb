Imports System.IO
Imports System.IO.File
Imports System.Drawing.Imaging

Public Class frm_PhotoOrbit

    Private Sub frm_PhotoOrbit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        Dim img_01 As Image
        Dim oEncoderParameters_01 As EncoderParameters
        Dim oImageCodecInfo_01 As ImageCodecInfo

        Select Case e.KeyCode

            Case Keys.F11

                oEncoderParameters_01 = New EncoderParameters(1)
                oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

                img_01 = pic_01.Image

                '// Rotate the image.
                img_01.RotateFlip(RotateFlipType.Rotate270FlipNone)

                '// Unload the picture:
                pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
                pic_01.Refresh()

                '// Save the image to the file:
                oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
                img_01.Save(NormalizePath(m_oFileListBox_01.Path) + m_oFileListBox_01.FileName, oImageCodecInfo_01, oEncoderParameters_01)

                '// Re-display the image:
                Call DisplayFile()
                m_oFileListBox_01.Focus()

            Case Keys.F12

                oEncoderParameters_01 = New EncoderParameters(1)
                oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

                img_01 = pic_01.Image

                '// Rotate the image.
                img_01.RotateFlip(RotateFlipType.Rotate90FlipNone)

                '// Unload the picture:
                pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
                pic_01.Refresh()

                '// Save the image to the file:
                oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
                img_01.Save(NormalizePath(m_oFileListBox_01.Path) + m_oFileListBox_01.FileName, oImageCodecInfo_01, oEncoderParameters_01)

                '// Re-display the image:
                Call DisplayFile()
                m_oFileListBox_01.Focus()

            Case Else

        End Select

    End Sub

    Private Sub frm_PhotoOrb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dirtree_01.Path = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))

        '// Maximize the application.
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub frm_PhotoOrbit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Call SaveInfoFile()

    End Sub

    Private Sub cmdbtn_RotateLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_RotateLeft.Click

        Dim img_01 As Image
        Dim oEncoderParameters_01 As EncoderParameters
        Dim oImageCodecInfo_01 As ImageCodecInfo

        oEncoderParameters_01 = New EncoderParameters(1)
        oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

        img_01 = pic_01.Image

        '// Rotate the image.
        img_01.RotateFlip(RotateFlipType.Rotate270FlipNone)

        '// Unload the picture:
        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
        pic_01.Refresh()

        '// Save the image to the file:
        oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
        img_01.Save(NormalizePath(m_oFileListBox_01.Path) + m_oFileListBox_01.FileName, oImageCodecInfo_01, oEncoderParameters_01)

        '// Reload the picture:
        pic_01.Load(NormalizePath(m_oFileListBox_01.Path) + m_oFileListBox_01.FileName)
        pic_01.Refresh()

        m_oFileListBox_01.Focus()

    End Sub

    Private Sub cmdbtn_RotateRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_RotateRight.Click

        Dim img_01 As Image
        Dim oEncoderParameters_01 As EncoderParameters
        Dim oImageCodecInfo_01 As ImageCodecInfo

        oEncoderParameters_01 = New EncoderParameters(1)
        oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

        img_01 = pic_01.Image

        '// Rotate the image.
        img_01.RotateFlip(RotateFlipType.Rotate90FlipNone)

        '// Unload the picture:
        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
        pic_01.Refresh()

        '// Save the image to the file:
        oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
        img_01.Save(NormalizePath(m_oFileListBox_01.Path) + m_oFileListBox_01.FileName, oImageCodecInfo_01, oEncoderParameters_01)

        '// Reload the picture:
        pic_01.Load(NormalizePath(m_oFileListBox_01.Path) + m_oFileListBox_01.FileName)
        pic_01.Refresh()

        m_oFileListBox_01.Focus()

    End Sub

    Private Sub cmdbtn_Rename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_Rename.Click

        Dim str_Prompt As String
        Dim oMsgBoxStyle_01 As MsgBoxStyle
        Dim oMsgBoxResult_01 As MsgBoxResult

        str_Prompt = "This will rename the files to ''001'', ''002'', ''003'', etc."
        oMsgBoxStyle_01 = MsgBoxStyle.OkCancel

        '// Display the message.
        oMsgBoxResult_01 = MsgBox(str_Prompt, oMsgBoxStyle_01, My.Application.Info.ProductName)

        If oMsgBoxResult_01 = MsgBoxResult.Ok Then
            Call RenameFiles()
        End If

    End Sub

    Private Sub dirtree_01_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles dirtree_01.Change

        Call SaveInfoFile()

        '// Close the "Info" file.
        oTextBox_Info.Text = ""
        m_text_PathedFileName_Info.Text = ""

        '// Disable the "CopyText" controls:
        lbl_textbox_TextToCopy_01.Enabled = False
        textbox_TextToCopy_01.Enabled = False
        lbl_textbox_CopyLineCount_01.Enabled = False
        textbox_CopyLineCount_01.Enabled = False
        cmdbtn_Copy_01.Enabled = False
        lbl_textbox_TextToCopy_02.Enabled = False
        textbox_TextToCopy_02.Enabled = False
        lbl_textbox_CopyLineCount_02.Enabled = False
        textbox_CopyLineCount_02.Enabled = False
        cmdbtn_Copy_02.Enabled = False
        lbl_textbox_TextToCopy_03.Enabled = False
        textbox_TextToCopy_03.Enabled = False
        lbl_textbox_CopyLineCount_03.Enabled = False
        textbox_CopyLineCount_03.Enabled = False
        cmdbtn_Copy_03.Enabled = False
        lbl_textbox_TextToCopy_04.Enabled = False
        textbox_TextToCopy_04.Enabled = False
        lbl_textbox_CopyLineCount_04.Enabled = False
        textbox_CopyLineCount_04.Enabled = False
        cmdbtn_Copy_04.Enabled = False
        lbl_textbox_TextToCopy_05.Enabled = False
        textbox_TextToCopy_05.Enabled = False
        lbl_textbox_CopyLineCount_05.Enabled = False
        textbox_CopyLineCount_05.Enabled = False
        cmdbtn_Copy_05.Enabled = False
        lbl_textbox_TextToCopy_06.Enabled = False
        textbox_TextToCopy_06.Enabled = False
        lbl_textbox_CopyLineCount_06.Enabled = False
        textbox_CopyLineCount_06.Enabled = False
        cmdbtn_Copy_06.Enabled = False

        m_oFileListBox_01.Path = dirtree_01.Path
        m_oFileListBox_01.Refresh()

        Call DisplayInfo()

    End Sub

    Private Sub filelst_01_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles m_oFileListBox_01.KeyUp

        Dim str_Prompt As String
        Dim oMsgBoxStyle_01 As MsgBoxStyle
        Dim oMsgBoxResult_01 As MsgBoxResult
        Dim str_PathedFileName_Old As String
        Dim str_FileName_New As String
        Dim i_SelItemIndex As Int32


        Select Case e.KeyCode

            Case Keys.Delete

                '// Remember which item was selected:
                i_SelItemIndex = m_oFileListBox_01.SelectedIndex

                str_Prompt = "This will delete ''" + m_oFileListBox_01.FileName + "''."
                oMsgBoxStyle_01 = MsgBoxStyle.OkCancel

                '// Display the message.
                oMsgBoxResult_01 = MsgBox(str_Prompt, oMsgBoxStyle_01, My.Application.Info.ProductName)

                If oMsgBoxResult_01 = MsgBoxResult.Ok Then

                    '// Unload the picture:
                    pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
                    pic_01.Refresh()

                    '// Rename the file to "ZZZ_...":
                    str_PathedFileName_Old = NormalizePath(dirtree_01.Path) + m_oFileListBox_01.FileName
                    str_FileName_New = "ZZZ_" + m_oFileListBox_01.FileName
                    My.Computer.FileSystem.RenameFile(str_PathedFileName_Old, "ZZZ_" + m_oFileListBox_01.FileName)

                    m_oFileListBox_01.Refresh()

                End If

                '// Restore the selection:
                m_oFileListBox_01.SelectedIndex = i_SelItemIndex

            Case Else

                If Len(m_oFileListBox_01.FileName) > 0 Then
                    DisplayFile()
                End If

        End Select

    End Sub

    Private Sub filelst_01_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles m_oFileListBox_01.MouseUp

        If Len(m_oFileListBox_01.FileName) > 0 Then
            DisplayFile()
        End If

    End Sub

    Private Sub cmdbtn_CreateInfoFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_CreateInfoFile.Click

        Call CreateNewInfoFile()

    End Sub

    Private Sub CreateNewInfoFile()

        Dim str_PathedFileName_Info As String
        Dim oFileInfo_Folder As FileInfo
        Dim str_InfoFileText As String
        Dim i_PhotoNum As Long


        oFileInfo_Folder = New FileInfo(m_oFileListBox_01.Path)
        str_PathedFileName_Info = NormalizePath(m_oFileListBox_01.Path) + "info.txt"

        '// Add the first lines to the file text:
        str_InfoFileText = oFileInfo_Folder.Directory.Parent.Name + "-" + oFileInfo_Folder.Directory.Name.Substring(0, 2) + "-" + oFileInfo_Folder.Name + vbCrLf
        str_InfoFileText = str_InfoFileText + vbCrLf

        '// Add the rest of the lines to the file text:
        For i_PhotoNum = 1 To m_oFileListBox_01.Items.Count
            str_InfoFileText = str_InfoFileText + Format(i_PhotoNum, "000") + " " + vbCrLf
        Next i_PhotoNum

        '// Save the new info file:
        Call SetFileContents(str_PathedFileName_Info, str_InfoFileText)

        '// Display the new info file:
        Call DisplayInfo()

    End Sub

    Private Sub DisplayInfo()

        Dim str_PathedFileName_Info As String

        str_PathedFileName_Info = NormalizePath(m_oFileListBox_01.Path) + "info.txt"

        If Exists(str_PathedFileName_Info) Then

            oTextBox_Info.Visible = True
            oTextBox_Info.Text = GetFileContents(str_PathedFileName_Info)
            m_text_PathedFileName_Info.Text = str_PathedFileName_Info

            cmdbtn_CreateInfoFile.Visible = False

            '// Enable the "CopyText" controls:
            lbl_textbox_TextToCopy_01.Enabled = True
            textbox_TextToCopy_01.Enabled = True
            lbl_textbox_CopyLineCount_01.Enabled = True
            textbox_CopyLineCount_01.Enabled = True
            cmdbtn_Copy_01.Enabled = True
            lbl_textbox_TextToCopy_02.Enabled = True
            textbox_TextToCopy_02.Enabled = True
            lbl_textbox_CopyLineCount_02.Enabled = True
            textbox_CopyLineCount_02.Enabled = True
            cmdbtn_Copy_02.Enabled = True
            lbl_textbox_TextToCopy_03.Enabled = True
            textbox_TextToCopy_03.Enabled = True
            lbl_textbox_CopyLineCount_03.Enabled = True
            textbox_CopyLineCount_03.Enabled = True
            cmdbtn_Copy_03.Enabled = True
            lbl_textbox_TextToCopy_04.Enabled = True
            textbox_TextToCopy_04.Enabled = True
            lbl_textbox_CopyLineCount_04.Enabled = True
            textbox_CopyLineCount_04.Enabled = True
            cmdbtn_Copy_04.Enabled = True
            lbl_textbox_TextToCopy_05.Enabled = True
            textbox_TextToCopy_05.Enabled = True
            lbl_textbox_CopyLineCount_05.Enabled = True
            textbox_CopyLineCount_05.Enabled = True
            cmdbtn_Copy_05.Enabled = True
            lbl_textbox_TextToCopy_06.Enabled = True
            textbox_TextToCopy_06.Enabled = True
            lbl_textbox_CopyLineCount_06.Enabled = True
            textbox_CopyLineCount_06.Enabled = True
            cmdbtn_Copy_06.Enabled = True

        Else

            oTextBox_Info.Visible = False
            oTextBox_Info.Text = ""
            m_text_PathedFileName_Info.Text = ""

            cmdbtn_CreateInfoFile.Visible = True

            '// Disable the "CopyText" controls:
            lbl_textbox_TextToCopy_01.Enabled = False
            textbox_TextToCopy_01.Enabled = False
            lbl_textbox_CopyLineCount_01.Enabled = False
            textbox_CopyLineCount_01.Enabled = False
            cmdbtn_Copy_01.Enabled = False
            lbl_textbox_TextToCopy_02.Enabled = False
            textbox_TextToCopy_02.Enabled = False
            lbl_textbox_CopyLineCount_02.Enabled = False
            textbox_CopyLineCount_02.Enabled = False
            cmdbtn_Copy_02.Enabled = False
            lbl_textbox_TextToCopy_03.Enabled = False
            textbox_TextToCopy_03.Enabled = False
            lbl_textbox_CopyLineCount_03.Enabled = False
            textbox_CopyLineCount_03.Enabled = False
            cmdbtn_Copy_03.Enabled = False
            lbl_textbox_TextToCopy_04.Enabled = False
            textbox_TextToCopy_04.Enabled = False
            lbl_textbox_CopyLineCount_04.Enabled = False
            textbox_CopyLineCount_04.Enabled = False
            cmdbtn_Copy_04.Enabled = False
            lbl_textbox_TextToCopy_05.Enabled = False
            textbox_TextToCopy_05.Enabled = False
            lbl_textbox_CopyLineCount_05.Enabled = False
            textbox_CopyLineCount_05.Enabled = False
            cmdbtn_Copy_05.Enabled = False
            lbl_textbox_TextToCopy_06.Enabled = False
            textbox_TextToCopy_06.Enabled = False
            lbl_textbox_CopyLineCount_06.Enabled = False
            textbox_CopyLineCount_06.Enabled = False
            cmdbtn_Copy_06.Enabled = False

        End If

    End Sub

    Private Function GetEncoderInfo(ByVal mimeType As String) As ImageCodecInfo

        Dim j As Integer
        Dim encoders As ImageCodecInfo()

        encoders = ImageCodecInfo.GetImageEncoders()
        For j = 0 To encoders.Length
            If encoders(j).MimeType = mimeType Then
                Return encoders(j)
            End If
        Next j
        Return Nothing

    End Function

    ''' <summary>
    ''' Rename the files to "001.jpeg", "002.jpeg", "003.jpeg", etc.
    ''' </summary>
    Private Sub RenameFiles()

        Dim str_FileName_Old As String
        Dim str_FileName_New As String
        Dim str_PathedFileName_Old As String
        Dim str_PathedFileName_New As String

        Dim i_Consecution As Long
        Dim i_FileNum As Long

        i_FileNum = 0

        '// Unload the picture:
        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
        pic_01.Refresh()

        For i_Consecution = 0 To m_oFileListBox_01.Items.Count - 1

            str_FileName_Old = m_oFileListBox_01.Items(i_Consecution)

            '// If this file has NOT been deleted ...
            If Not str_FileName_Old.StartsWith("ZZZ", StringComparison.CurrentCultureIgnoreCase) Then

                '// If this file fits the criteria for renaming ...
                If str_FileName_Old.EndsWith(".jpg", StringComparison.CurrentCultureIgnoreCase) _
                    Or str_FileName_Old.EndsWith(".jpeg", StringComparison.CurrentCultureIgnoreCase) _
                    Or str_FileName_Old.EndsWith(".avi", StringComparison.CurrentCultureIgnoreCase) _
                    Or str_FileName_Old.EndsWith(".mpeg", StringComparison.CurrentCultureIgnoreCase) _
                    Or str_FileName_Old.EndsWith(".mp4", StringComparison.CurrentCultureIgnoreCase) _
                    Or str_FileName_Old.EndsWith(".mov", StringComparison.CurrentCultureIgnoreCase) Then

                    '// Determine the old and new pathed file names:
                    i_FileNum = i_FileNum + 1
                    str_PathedFileName_Old = NormalizePath(dirtree_01.Path) + str_FileName_Old
                    str_FileName_New = Format$(i_FileNum, "000")
                    If str_FileName_Old.EndsWith(".avi", StringComparison.CurrentCultureIgnoreCase) Then
                        str_PathedFileName_New = NormalizePath(dirtree_01.Path) + str_FileName_New + ".avi"
                    ElseIf str_FileName_Old.EndsWith(".mpeg", StringComparison.CurrentCultureIgnoreCase) Then
                        str_PathedFileName_New = NormalizePath(dirtree_01.Path) + str_FileName_New + ".mpeg"
                    ElseIf str_FileName_Old.EndsWith(".mp4", StringComparison.CurrentCultureIgnoreCase) Then
                        str_PathedFileName_New = NormalizePath(dirtree_01.Path) + str_FileName_New + ".mp4"
                    ElseIf str_FileName_Old.EndsWith(".mov", StringComparison.CurrentCultureIgnoreCase) Then
                        str_PathedFileName_New = NormalizePath(dirtree_01.Path) + str_FileName_New + ".mov"
                    Else
                        str_PathedFileName_New = NormalizePath(dirtree_01.Path) + str_FileName_New + ".jpeg"
                    End If

                    Rename(str_PathedFileName_Old, str_PathedFileName_New)

                End If
                '// ... if this file fits the criteria for renaming.

            End If
            '// ... if this file has not been deleted.

        Next i_Consecution

        m_oFileListBox_01.Refresh()

    End Sub

    Private Sub SaveInfoFile()

        If (oTextBox_Info.Visible And Len(m_text_PathedFileName_Info.Text) > 0) Then
            Call SetFileContents(m_text_PathedFileName_Info.Text, oTextBox_Info.Text)
        End If

    End Sub

    Private Sub m_cmdbtn_GatherSubFolderFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmdbtn_GatherSubFolderFiles.Click

        Dim i_01 As Int32
        Dim i_02 As Int32
        Dim str_PathedFileName_Old As String
        Dim str_PathedFileName_New As String

        Me.Cursor = Cursors.WaitCursor

        For i_01 = 0 To dirtree_01.DirListCount - 1
            m_oFileListBox_01.Path = dirtree_01.DirList(i_01)
            For i_02 = 0 To m_oFileListBox_01.Items.Count - 1
                If m_oFileListBox_01.Items(i_02).Substring(0, 3) <> "ZZZ" Then
                    str_PathedFileName_Old = NormalizePath(m_oFileListBox_01.Path) + m_oFileListBox_01.Items(i_02)
                    str_PathedFileName_New = NormalizePath(dirtree_01.Path) + FolderName(NormalizePath(m_oFileListBox_01.Path)) + "_" + m_oFileListBox_01.Items(i_02)
                    FileCopy(str_PathedFileName_Old, str_PathedFileName_New)
                End If
            Next
        Next

        m_oFileListBox_01.Path = dirtree_01.Path
        m_oFileListBox_01.Refresh()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdbtn_Copy_01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_Copy_01.Click

        Dim str_FileTitle_Photo As String

        Dim i_PhotoNum As Int32
        Dim i_CopyLineCount As Int32

        Dim str_Line As String
        Dim i_LineNum As Int32
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Int32 = 0


        i_CopyLineCount = Val(textbox_CopyLineCount_01.Text)
        If i_CopyLineCount < 1 Then i_CopyLineCount = 1

        For i_PhotoNum = 1 To i_CopyLineCount

            str_NewText = ""

            str_FileTitle_Photo = RemoveFileExtension(m_oFileListBox_01.FileName)

            For i_LineNum = 0 To oTextBox_Info.Lines.Length - 2

                str_Line = oTextBox_Info.Lines(i_LineNum)

                If str_Line.StartsWith(str_FileTitle_Photo + " ") Then
                    str_NewText += str_Line + textbox_TextToCopy_01.Text + vbCrLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbCrLf
                End If

            Next i_LineNum

            oTextBox_Info.Text = str_NewText

            '// Move down one file if possible:
            If (m_oFileListBox_01.SelectedIndex < m_oFileListBox_01.Items.Count - 1) Then
                m_oFileListBox_01.SelectedIndex = m_oFileListBox_01.SelectedIndex + 1
            End If

            '// Display the selected file:
            If Len(m_oFileListBox_01.FileName) > 0 Then
                DisplayFile()
            End If

        Next i_PhotoNum

        If (i_LastChangedLineNum > 0) Then
            GoToLine(i_LastChangedLineNum + 2)
        End If

        textbox_CopyLineCount_01.Text = "1"

        m_oFileListBox_01.Focus()

    End Sub

    Private Sub cmdbtn_Copy_02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_Copy_02.Click

        Dim str_FileTitle_Photo As String

        Dim i_PhotoNum As Int32
        Dim i_CopyLineCount As Int32

        Dim str_Line As String
        Dim i_LineNum As Int32
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Int32 = 0


        i_CopyLineCount = Val(textbox_CopyLineCount_02.Text)
        If i_CopyLineCount < 1 Then i_CopyLineCount = 1

        For i_PhotoNum = 1 To i_CopyLineCount

            str_NewText = ""

            str_FileTitle_Photo = RemoveFileExtension(m_oFileListBox_01.FileName)

            For i_LineNum = 0 To oTextBox_Info.Lines.Length - 1

                str_Line = oTextBox_Info.Lines(i_LineNum)

                If str_Line.StartsWith(str_FileTitle_Photo + " ") Then
                    str_NewText += str_Line + textbox_TextToCopy_02.Text + vbCrLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbCrLf
                End If

            Next i_LineNum

            oTextBox_Info.Text = str_NewText

            '// Move down one file if possible:
            If (m_oFileListBox_01.SelectedIndex < m_oFileListBox_01.Items.Count - 1) Then
                m_oFileListBox_01.SelectedIndex = m_oFileListBox_01.SelectedIndex + 1
            End If

            '// Display the selected file:
            If Len(m_oFileListBox_01.FileName) > 0 Then
                DisplayFile()
            End If

        Next i_PhotoNum

        If (i_LastChangedLineNum > 0) Then
            GoToLine(i_LastChangedLineNum + 2)
        End If

        textbox_CopyLineCount_02.Text = "1"

        m_oFileListBox_01.Focus()

    End Sub

    Private Sub cmdbtn_Copy_03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_Copy_03.Click

        Dim str_FileTitle_Photo As String

        Dim i_PhotoNum As Int32
        Dim i_CopyLineCount As Int32

        Dim str_Line As String
        Dim i_LineNum As Int32
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Int32 = 0


        i_CopyLineCount = Val(textbox_CopyLineCount_03.Text)
        If i_CopyLineCount < 1 Then i_CopyLineCount = 1

        For i_PhotoNum = 1 To i_CopyLineCount

            str_NewText = ""

            str_FileTitle_Photo = RemoveFileExtension(m_oFileListBox_01.FileName)

            For i_LineNum = 0 To oTextBox_Info.Lines.Length - 1

                str_Line = oTextBox_Info.Lines(i_LineNum)

                If str_Line.StartsWith(str_FileTitle_Photo + " ") Then
                    str_NewText += str_Line + textbox_TextToCopy_03.Text + vbCrLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbCrLf
                End If

            Next i_LineNum

            oTextBox_Info.Text = str_NewText

            '// Move down one file if possible:
            If (m_oFileListBox_01.SelectedIndex < m_oFileListBox_01.Items.Count - 1) Then
                m_oFileListBox_01.SelectedIndex = m_oFileListBox_01.SelectedIndex + 1
            End If

            '// Display the selected file:
            If Len(m_oFileListBox_01.FileName) > 0 Then
                DisplayFile()
            End If

        Next i_PhotoNum

        If (i_LastChangedLineNum > 0) Then
            GoToLine(i_LastChangedLineNum + 2)
        End If

        textbox_CopyLineCount_03.Text = "1"

        m_oFileListBox_01.Focus()

    End Sub

    Private Sub cmdbtn_Copy_04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_Copy_04.Click

        Dim str_FileTitle_Photo As String

        Dim i_PhotoNum As Int32
        Dim i_CopyLineCount As Int32

        Dim str_Line As String
        Dim i_LineNum As Int32
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Int32 = 0


        i_CopyLineCount = Val(textbox_CopyLineCount_04.Text)
        If i_CopyLineCount < 1 Then i_CopyLineCount = 1

        For i_PhotoNum = 1 To i_CopyLineCount

            str_NewText = ""

            str_FileTitle_Photo = RemoveFileExtension(m_oFileListBox_01.FileName)

            For i_LineNum = 0 To oTextBox_Info.Lines.Length - 1

                str_Line = oTextBox_Info.Lines(i_LineNum)

                If str_Line.StartsWith(str_FileTitle_Photo + " ") Then
                    str_NewText += str_Line + textbox_TextToCopy_04.Text + vbCrLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbCrLf
                End If

            Next i_LineNum

            oTextBox_Info.Text = str_NewText

            '// Move down one file if possible:
            If (m_oFileListBox_01.SelectedIndex < m_oFileListBox_01.Items.Count - 1) Then
                m_oFileListBox_01.SelectedIndex = m_oFileListBox_01.SelectedIndex + 1
            End If

            '// Display the selected file:
            If Len(m_oFileListBox_01.FileName) > 0 Then
                DisplayFile()
            End If

        Next i_PhotoNum

        If (i_LastChangedLineNum > 0) Then
            GoToLine(i_LastChangedLineNum + 2)
        End If

        textbox_CopyLineCount_04.Text = "1"

        m_oFileListBox_01.Focus()

    End Sub

    Private Sub cmdbtn_Copy_05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_Copy_05.Click

        Dim str_FileTitle_Photo As String

        Dim i_PhotoNum As Int32
        Dim i_CopyLineCount As Int32

        Dim str_Line As String
        Dim i_LineNum As Int32
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Int32 = 0


        i_CopyLineCount = Val(textbox_CopyLineCount_05.Text)
        If i_CopyLineCount < 1 Then i_CopyLineCount = 1

        For i_PhotoNum = 1 To i_CopyLineCount

            str_NewText = ""

            str_FileTitle_Photo = RemoveFileExtension(m_oFileListBox_01.FileName)

            For i_LineNum = 0 To oTextBox_Info.Lines.Length - 1

                str_Line = oTextBox_Info.Lines(i_LineNum)

                If str_Line.StartsWith(str_FileTitle_Photo + " ") Then
                    str_NewText += str_Line + textbox_TextToCopy_05.Text + vbCrLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbCrLf
                End If

            Next i_LineNum

            oTextBox_Info.Text = str_NewText

            '// Move down one file if possible:
            If (m_oFileListBox_01.SelectedIndex < m_oFileListBox_01.Items.Count - 1) Then
                m_oFileListBox_01.SelectedIndex = m_oFileListBox_01.SelectedIndex + 1
            End If

            '// Display the selected file:
            If Len(m_oFileListBox_01.FileName) > 0 Then
                DisplayFile()
            End If

        Next i_PhotoNum

        If (i_LastChangedLineNum > 0) Then
            GoToLine(i_LastChangedLineNum + 2)
        End If

        textbox_CopyLineCount_05.Text = "1"

        m_oFileListBox_01.Focus()

    End Sub

    Private Sub cmdbtn_Copy_06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_Copy_06.Click

        Dim str_FileTitle_Photo As String

        Dim i_PhotoNum As Int32
        Dim i_CopyLineCount As Int32

        Dim str_Line As String
        Dim i_LineNum As Int32
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Int32 = 0


        i_CopyLineCount = Val(textbox_CopyLineCount_06.Text)
        If i_CopyLineCount < 1 Then i_CopyLineCount = 1

        For i_PhotoNum = 1 To i_CopyLineCount

            str_NewText = ""

            str_FileTitle_Photo = RemoveFileExtension(m_oFileListBox_01.FileName)

            For i_LineNum = 0 To oTextBox_Info.Lines.Length - 1

                str_Line = oTextBox_Info.Lines(i_LineNum)

                If str_Line.StartsWith(str_FileTitle_Photo + " ") Then
                    str_NewText += str_Line + textbox_TextToCopy_06.Text + vbCrLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbCrLf
                End If

            Next i_LineNum

            oTextBox_Info.Text = str_NewText

            '// Move down one file if possible:
            If (m_oFileListBox_01.SelectedIndex < m_oFileListBox_01.Items.Count - 1) Then
                m_oFileListBox_01.SelectedIndex = m_oFileListBox_01.SelectedIndex + 1
            End If

            '// Display the selected file:
            If Len(m_oFileListBox_01.FileName) > 0 Then
                DisplayFile()
            End If

        Next i_PhotoNum

        If (i_LastChangedLineNum > 0) Then
            GoToLine(i_LastChangedLineNum + 2)
        End If

        textbox_CopyLineCount_06.Text = "1"

        m_oFileListBox_01.Focus()

    End Sub

    ''' <summary>
    ''' Move the caret in a text box to a specific line.
    ''' </summary>
    ''' <param name="line_number"></param>
    Private Sub GoToLine(ByVal line_number As Integer)

        Dim txt As String
        Dim i As Integer
        Dim pos As Integer

        '// Find the line's position:
        txt = oTextBox_Info.Text
        pos = 1
        For i = 2 To line_number
            pos = InStr(pos, txt, vbCrLf)
            If pos = 0 Then
                pos = 1
                Exit For
            End If
            pos = pos + 2
        Next i

        '// Go to this position:
        oTextBox_Info.SelectionStart = Len(txt)
        oTextBox_Info.SelectionStart = pos - 1
        oTextBox_Info.SelectionLength = 0
        oTextBox_Info.ScrollToCaret()

    End Sub

    Private Sub DisplayFile()

        Dim str_FileName_Selected As String
        Dim str_PathedFileName_Selected As String
        Dim str_FileExtension_Selected As String
        Dim oFileInfo_Pic As FileInfo
        Dim str_DisplayVal As String
        Dim i_ItemNum As Int32


        str_FileName_Selected = m_oFileListBox_01.SelectedItem.ToString
        str_FileExtension_Selected = FileExtension(str_FileName_Selected)
        str_PathedFileName_Selected = NormalizePath(m_oFileListBox_01.Path) + str_FileName_Selected

        oListBox_Properties.Items.Clear()

        Select Case LCase$(str_FileExtension_Selected)

            Case "bmp", "jpg", "jpeg", "png"
                pic_01.Visible = True
                pic_01.Load(str_PathedFileName_Selected)
                mplayer_01.Visible = False
                mplayer_01.URL = ""

                oFileInfo_Pic = New FileInfo(str_PathedFileName_Selected)

                Using image As Bitmap = New Bitmap(str_PathedFileName_Selected)

                    '// Get the PropertyItems property from image.
                    Dim propItems As PropertyItem() = image.PropertyItems

                    Dim count As Integer = 0
                    Dim propItem As PropertyItem
                    For Each propItem In propItems
                        count += 1
                    Next propItem
                    Dim encoding As New System.Text.ASCIIEncoding()

                    For i_ItemNum = 0 To count - 1
                        propItem = propItems(i_ItemNum)
                        oListBox_Properties.Items.Add("Type " + propItem.Type.ToString())

                        Select Case propItem.Type
                            Case 2 '// (string)
                                str_DisplayVal = "  " + encoding.GetString(propItem.Value)
                                oListBox_Properties.Items.Add(str_DisplayVal)
                            Case 3 '// (16-bit integer)
                                Dim i_Len As Int32 = encoding.GetString(propItem.Value).Length
                                str_DisplayVal = "  Length=" + i_Len.ToString()
                                If (i_Len = 2) Then
                                    str_DisplayVal += ": " + propItem.Value(0).ToString() + ", " + propItem.Value(1).ToString()
                                End If
                                oListBox_Properties.Items.Add(str_DisplayVal)
                        End Select
                    Next i_ItemNum

                End Using

            Case "mov", "avi", "mpeg", "mp4"
                mplayer_01.Visible = True
                mplayer_01.URL = str_PathedFileName_Selected
                pic_01.Visible = False

            Case Else
                pic_01.Visible = False
                mplayer_01.Visible = False
                mplayer_01.URL = ""

        End Select

    End Sub

    Private Sub m_cmdbtn_BackupFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmdbtn_BackupFile.Click

        Call BackupFile(m_text_PathedFileName_Info.Text)
        m_oFileListBox_01.Refresh()

    End Sub

    Private Sub btn_Now_Click(sender As Object, e As EventArgs) Handles btn_Now.Click

        Dim str_CurrentYear As String = DateTime.Now.Year.ToString()
        Dim str_CurrentMonth As String = DateTime.Now.Month.ToString()
        Dim ItemNum_01 As Int32 = 0
        Dim ItemNum_02 As Int32 = 0
        Dim DirObjName_01 As String

        SaveInfoFile()

        If (str_CurrentMonth.Length = 1) Then str_CurrentMonth = "0" + str_CurrentMonth

        '// Set to the default path for pictures:
        m_text_PathedFileName_Info.Text = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))
        dirtree_01.Path = m_text_PathedFileName_Info.Text

        '// Look for the current year:
        For ItemNum_01 = 0 To dirtree_01.Items.Count - 1
            DirObjName_01 = dirtree_01.Items(ItemNum_01)
            If DirObjName_01 = str_CurrentYear Then
                m_text_PathedFileName_Info.Text += DirObjName_01 + "\"
            End If
        Next ItemNum_01

        dirtree_01.Path = m_text_PathedFileName_Info.Text

        '// Look for the current month:
        For ItemNum_01 = 0 To dirtree_01.Items.Count - 1
            DirObjName_01 = dirtree_01.Items(ItemNum_01)
            If DirObjName_01.StartsWith(str_CurrentMonth) Then
                m_text_PathedFileName_Info.Text = NormalizePath(dirtree_01.Path) + DirObjName_01 + "\"
            End If
        Next ItemNum_01

        dirtree_01.Path = m_text_PathedFileName_Info.Text

    End Sub
End Class