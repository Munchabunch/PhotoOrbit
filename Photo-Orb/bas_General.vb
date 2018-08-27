Imports System.IO.File

Module bas_General

    ''' <summary>
    ''' Make a backup copy of a file.
    ''' </summary>
    ''' <param name="str_PathedFileName_Orig"></param>
    ''' <remarks></remarks>
    Public Sub BackupFile(ByVal str_PathedFileName_Orig As String)

        '-----------------------------------------------------------------------------------------------------
        '
        ' Exceptions:
        '   If backup file #999 exists, we will not make any more backups.
        '
        ' Notes:
        '   The name of the backup file will be the name of the original file, plus ".bak", plus the backup
        '      number.  For example, the first backup of "Names.txt" will be called "Names.txt.bak.001",
        '      and the second will be called "Names.txt.bak.002".
        '
        '-----------------------------------------------------------------------------------------------------

        Dim str_PathedFileName_Backup As String
        Dim i_BackupNum As Long
        Dim str_BackupNum As String


        '// Find the backup file name:
        i_BackupNum = 999
        str_BackupNum = Format(i_BackupNum, "000")
        str_PathedFileName_Backup = str_PathedFileName_Orig + ".bak." + str_BackupNum

        '// If "~~~.bak.999" exists, then we will not back up the file.
        If Exists(str_PathedFileName_Backup) Then Exit Sub

        Do Until i_BackupNum = 0 Or Exists(str_PathedFileName_Backup)

            '// Find the next backup file name:
            i_BackupNum = i_BackupNum - 1
            str_BackupNum = Format(i_BackupNum, "000")
            str_PathedFileName_Backup = str_PathedFileName_Orig + ".bak." + str_BackupNum

        Loop

        '// Find the backup file name:
        i_BackupNum = i_BackupNum + 1
        str_BackupNum = Format(i_BackupNum, "000")
        str_PathedFileName_Backup = str_PathedFileName_Orig + ".bak." + str_BackupNum

        FileCopy(str_PathedFileName_Orig, str_PathedFileName_Backup)

    End Sub

    ''' <summary>
    ''' Return a file's text contents.
    ''' </summary>
    ''' <param name="str_PathedFileName"></param>
    ''' <returns></returns>
    Public Function GetFileContents(ByVal str_PathedFileName As String) As String

        Dim oStreamReader_01 As New IO.StreamReader(str_PathedFileName)
        Dim str_Text As String = oStreamReader_01.ReadToEnd()

        oStreamReader_01.Close()

        Return str_Text

    End Function

    ''' <summary>
    ''' Write a text string to a file.
    ''' </summary>
    ''' <param name="str_PathedFileName"></param>
    ''' <param name="str_FileText"></param>
    Public Sub SetFileContents(ByVal str_PathedFileName As String, ByVal str_FileText As String)

        Dim oStreamWriter_01 As New IO.StreamWriter(str_PathedFileName, False)

        oStreamWriter_01.Write(str_FileText)
        oStreamWriter_01.Close()

    End Sub

    ''' <summary>
    ''' Determine whether the specified file has a graphic-file extension.
    ''' </summary>
    ''' <param name="FileName">file name, with or without a path</param>
    ''' <returns></returns>
    Public Function IsGraphicFile(FileName) As Boolean

        Dim Extension As String

        Extension = FileExtension(FileName)

        If (Extension = "bmp" _
                Or Extension = "gif" _
                Or Extension = "png" _
                Or Extension = "jpg" _
                Or Extension = "jpeg") Then
            IsGraphicFile = True
        Else
            IsGraphicFile = False
        End If

    End Function

    ''' <summary>
    ''' Determine whether the specified file has a video-file extension.
    ''' </summary>
    ''' <param name="FileName">file name, with or without a path</param>
    ''' <returns></returns>
    Public Function IsVideoFile(FileName) As Boolean

        Dim Extension As String

        Extension = FileExtension(FileName)

        If (Extension = "avi" _
                Or Extension = "mpeg" _
                Or Extension = "mp4" _
                Or Extension = "mov") Then
            IsVideoFile = True
        Else
            IsVideoFile = False
        End If

    End Function

    ''' <summary>
    ''' Move and resize the specified controls to fit within the specified width.
    ''' </summary>
    ''' <param name="ctrls">array of controls</param>
    ''' <param name="TotalWidth_New"></param>
    Public Sub ResizeUniformly_Horizontal(ctrls As Control(), TotalWidth_New As Integer)

        Dim ctrl_Working As Control
        Dim ctrl_Previous As Control
        Dim CtrlWidth_Old As Integer
        Dim CtrlWidth_New As Integer
        Dim GutterWidth As Integer
        Dim CombinedGutterWidth As Integer
        Dim TotalWidth_Old As Integer
        Dim i_CtrlNum As Integer


        CtrlWidth_Old = ctrls(0).Width
        GutterWidth = ctrls(1).Left - ctrls(0).Right
        CombinedGutterWidth = GutterWidth * (ctrls.Length - 1)
        TotalWidth_Old = (CtrlWidth_Old * ctrls.Length) + CombinedGutterWidth

        CtrlWidth_New = (TotalWidth_New - CombinedGutterWidth) \ ctrls.Length

        '// Resize the first control:
        ctrls(0).Width = CtrlWidth_New
        ctrl_Previous = ctrls(0)

        '// Move and resize the rest of the controls:
        For i_CtrlNum = 1 To ctrls.Length - 1
            ctrl_Working = ctrls(i_CtrlNum)
            ctrl_Working.Width = CtrlWidth_New
            ctrl_Working.Left = ctrl_Previous.Right + GutterWidth
            ctrl_Previous = ctrl_Working
        Next i_CtrlNum

    End Sub

    ''' <summary>
    ''' Move and resize the specified controls to fit within the specified width.
    ''' </summary>
    ''' <param name="ctrls">array of controls</param>
    ''' <param name="TotalHeight_New"></param>
    Public Sub ResizeUniformly_Vertical(ctrls As Control(), TotalHeight_New As Integer)

        Dim ctrl_Working As Control
        Dim ctrl_Previous As Control
        Dim CtrlHeight_Old As Integer
        Dim CtrlHeight_New As Integer
        Dim GutterHeight As Integer
        Dim CombinedGutterHeight As Integer
        Dim TotalHeight_Old As Integer
        Dim i_CtrlNum As Integer


        CtrlHeight_Old = ctrls(0).Height
        GutterHeight = ctrls(1).Top - ctrls(0).Bottom
        CombinedGutterHeight = GutterHeight * (ctrls.Length - 1)
        TotalHeight_Old = (CtrlHeight_Old * ctrls.Length) + CombinedGutterHeight

        CtrlHeight_New = (TotalHeight_New - CombinedGutterHeight) \ ctrls.Length

        '// Resize the first control:
        ctrls(0).Height = CtrlHeight_New
        ctrl_Previous = ctrls(0)

        '// Move and resize the rest of the controls:
        For i_CtrlNum = 1 To ctrls.Length - 1
            ctrl_Working = ctrls(i_CtrlNum)
            ctrl_Working.Height = CtrlHeight_New
            ctrl_Working.Top = ctrl_Previous.Bottom + GutterHeight
            ctrl_Previous = ctrl_Working
        Next i_CtrlNum

    End Sub

End Module
