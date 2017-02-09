Imports System.IO.File

Module bas_General

    Public Sub BackupFile(ByVal str_PathedFileName_Orig As String)

        '-----------------------------------------------------------------------------------------------------
        ' Make a backup copy of a file.
        '-----------------------------------------------------------------------------------------------------
        '
        ' Required parameters:
        '   str_PathedFileName_Orig
        '
        ' Optional parameters:
        '   none
        '
        ' Exceptions:
        '   If backup file #999 exists, we will not make any more backups.
        '
        ' Notes:
        '   The name of the backup file will be the name of the original file, plus ".bak", plus the backup
        '      number.  For example, the first backup of "Names.txt" will be called "Names.txt.bak.001",
        '      and the second will be called "Names.txt.bak.002".
        '
        ' Credits:
        '   Original code by Mike Adams
        '
        ' Author:    Mike Adams
        ' Date:      2004-02-12
        '
        ' Status:    Tested
        '
        '-----------------------------------------------------------------------------------------------------

        Dim str_PathedFileName_Backup As String
        Dim i_BackupNo As Long
        Dim str_BackupNo As String


        '// Find the backup file name:
        i_BackupNo = 999
        str_BackupNo = Format(i_BackupNo, "000")
        str_PathedFileName_Backup = str_PathedFileName_Orig + ".bak." + str_BackupNo

        '// If "~~~.bak.999" exists, then we will not back up the file.
        If Exists(str_PathedFileName_Backup) Then Exit Sub

        Do Until i_BackupNo = 0 Or Exists(str_PathedFileName_Backup)

            '// Find the next backup file name:
            i_BackupNo = i_BackupNo - 1
            str_BackupNo = Format(i_BackupNo, "000")
            str_PathedFileName_Backup = str_PathedFileName_Orig + ".bak." + str_BackupNo

        Loop

        '// Find the backup file name:
        i_BackupNo = i_BackupNo + 1
        str_BackupNo = Format(i_BackupNo, "000")
        str_PathedFileName_Backup = str_PathedFileName_Orig + ".bak." + str_BackupNo

        FileCopy(str_PathedFileName_Orig, str_PathedFileName_Backup)


    End Sub

    Public Function NormalizePath(ByVal str_FilePath As String) As String

        '-----------------------------------------------------------------------------------------------------
        ' Make sure that a string has a trailing backslash.
        '-----------------------------------------------------------------------------------------------------
        '
        ' Returns string:
        '   path to a subdirectory ending with "\"
        '
        ' Required parameters:
        '   str_FilePath
        '     path to a subdirectory
        '
        ' Optional parameters:
        '   none
        '
        ' Notes:
        '
        ' See also:
        '
        ' Credits:
        '
        ' Author:    Mike Adams
        ' Date:      2007-07-18
        '
        ' Status:    Tested
        '
        '-----------------------------------------------------------------------------------------------------


        If (Len(str_FilePath) > 0) Then
            If (str_FilePath.EndsWith("\")) Then
                NormalizePath = str_FilePath
            Else
                NormalizePath = (str_FilePath + "\")
            End If
        End If

    End Function

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

    Public Function RemoveFileExtension(ByVal str_FileName As String) As String

        '-----------------------------------------------------------------------------------------------------
        ' Remove the extension from a file name.
        '-----------------------------------------------------------------------------------------------------
        '
        ' Returns string:
        '   If the unpathed file name contains a ".":
        '     Every character before the last "."
        '   If the unpathed file name DOES NOT contain a ".":
        '     The entire file name as input
        '
        ' Required parameters:
        '   str_FileName
        '     un-pathed name of the file
        '
        ' Optional parameters:
        '   none
        '
        ' Notes:
        '   The extension is not limited to three characters; it may be any length.
        '
        ' Credits:
        '   Original code by Mike Adams
        '
        ' Author:    Mike Adams
        ' Date:      2009-03-22
        '
        ' Status:    Converting
        '
        '-----------------------------------------------------------------------------------------------------

        Dim i_Pos As Long


        '// Find the position of the last "." in the un-pathed file name.
        i_Pos = InStrRev(str_FileName, ".")

        If (i_Pos = 0) Then
            RemoveFileExtension = str_FileName
        Else
            RemoveFileExtension = Mid$(str_FileName, 1, i_Pos - 1)
        End If


    End Function

End Module
