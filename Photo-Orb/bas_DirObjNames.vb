Module bas_DirObjNames

    ''' <summary>
    ''' Pull the extension from a file name.
    ''' </summary>
    ''' <param name="str_FileName">name of file with optional path</param>
    ''' <returns>Every character past the last "."</returns>
    ''' <remarks>Periods in the file path are ignored.</remarks>
    ''' <credits>Original code by Mike Adams</credits>
    Public Property FileExtension(ByVal str_FileName As String) As String

        Get

            Dim i_Pos As Long
            Dim str_UnpathedFileName As String


            '// Find the un-pathed file name.
            str_UnpathedFileName = FileName(str_FileName)

            '// Find the position of the last "." in the un-pathed file name.
            i_Pos = InStrRev(str_UnpathedFileName, ".")

            If (i_Pos = 0) Then
                FileExtension = vbNullString
            Else
                FileExtension = Mid$(str_UnpathedFileName, i_Pos + 1)
            End If

        End Get

        Set(ByVal str_Value As String)

            str_FileName = RemoveFileExtension(str_FileName) + "." + str_Value

        End Set

    End Property

    Public Property FileName(ByVal str_PathedFileName As String) As String

        Get

            '-----------------------------------------------------------------------------------------------------
            ' Remove the path from a pathed file name.
            '-----------------------------------------------------------------------------------------------------
            '
            ' Returns string:
            '    Unpathed file name
            '
            ' Required parameters:
            '    str_PathedFileName
            '       name of file including its path
            '
            ' Optional parameters:
            '   none
            '
            ' Notes:
            '
            '-----------------------------------------------------------------------------------------------------

            Dim Pos As Integer

            '// Find the position of the last "\" in the pathed file name.
            Pos = InStrRev(str_PathedFileName, "\")

            FileName = str_PathedFileName.Substring(Pos)

        End Get

        Set(ByVal str_Value As String)

            str_PathedFileName = Path(str_PathedFileName) + str_Value

        End Set

    End Property

    Public Function FolderName(ByVal str_Object As String) As String

        '-----------------------------------------------------------------------------------------------------
        ' Retrieve the lowest level folder name from a path or a pathed file name.
        '-----------------------------------------------------------------------------------------------------
        '
        ' Returns string:
        '   name of the lowest level folder
        '
        ' Required parameters:
        '   str_Object
        '     path or pathed file name
        '
        ' Optional parameters:
        '   none
        '
        ' Examples:
        '   FolderName("D:\MyFiles\PD\LX Demo\03\Test.bas") returns "03"
        '   FolderName("D:\MyFiles\PD\LX Demo\03\")         returns "03"
        '   FolderName("D:\MyFiles\PD\LX Demo\03")          returns "LX Demo"
        '   FolderName("D:MyFiles\info.txt")                returns "D:MyFiles"
        '   FolderName("MyFiles\info.txt")                  returns "MyFiles"
        '   FolderName("\info.txt")                         returns "\"
        '   FolderName("info.txt")                          returns ""
        '
        ' Demo project:
        '   ShareDemo_DirObjNames.vbp
        '
        ' Notes:
        '   If str_Object ends with "\", it is assumed to be a path.  If it does not, it is assumed to be
        '      a pathed file name.  Therefore, you should ensure that a path is normalized before using it
        '      as a parameter for this function.
        '
        ' Credits:
        '   Original code by Mike Adams
        '
        '-----------------------------------------------------------------------------------------------------

        Dim i_Pos_Begin As Long
        Dim i_Pos_End As Long

        If (InStr(str_Object, "\") = 0) Then

            FolderName = ""

        Else

            '// Find the position of the last "\".
            i_Pos_End = InStrRev(str_Object, "\") - 1

            If (i_Pos_End = 0) Then
                '// If the first character is the only "\" in the string ...

                'Return the root directory.
                FolderName = "\"

            Else

                '// Find the position of the next-to-last "\".
                i_Pos_Begin = InStrRev(str_Object, "\", i_Pos_End - 1)

                FolderName = str_Object.Substring(i_Pos_Begin, i_Pos_End - i_Pos_Begin)

            End If

        End If

    End Function

    Public Property Path(ByVal str_PathedFileName As String) As String

        '-----------------------------------------------------------------------------------------------------
        ' Pull the path from a pathed file name. This includes the drive letter, if any.
        '-----------------------------------------------------------------------------------------------------
        '
        ' Returns string:
        '   Path portion of a pathed file name
        '
        ' Required parameters:
        '   str_PathedFileName (ByRef)
        '
        ' Optional parameters:
        '   none
        '
        ' Examples:
        '   Path("D:\My Documents\Listings\Players.txt")
        '     returns "D:\My Documents\Listings\"
        '   Path("Documents\Notices\Out to lunch.wpd")
        '     returns "Documents\Notices\"
        '   Path("Food.jpeg")
        '     returns ""
        '
        ' Notes:
        '
        '-----------------------------------------------------------------------------------------------------

        Get

            Dim Pos As Integer
            Dim str_FileName As String

            On Error GoTo EH

            str_FileName = FileName(str_PathedFileName)

            If (Len(str_FileName) = 0) Then
                Path = ""
            Else
                Pos = InStr(str_PathedFileName, str_FileName)
                Path = str_PathedFileName.Substring(0, Pos - 1)
            End If

            Exit Property

            '-----------------------------------------------------------------------------------------------------

EH:

            Path = ""

            Exit Property

        End Get

        Set(ByVal str_Value As String)

            str_PathedFileName = str_Value + FileName(str_PathedFileName)

        End Set

    End Property

    ''' <summary>
    ''' Make sure that a string ends with a backslash.
    ''' </summary>
    ''' <param name="Path">path to a subdirectory</param>
    ''' <returns>path to a subdirectory ending with "\"</returns>
    Public Function NormalizePath(ByVal Path As String) As String

        If (Len(Path) > 0) Then
            If (Path.EndsWith("\")) Then
                Return Path
            Else
                Return Path + "\"
            End If
        End If

        Return ""

    End Function

    ''' <summary>
    ''' Determine the path to the parent of a specified folder.
    ''' </summary>
    ''' <param name="Path_Orig"></param>
    ''' <returns></returns>
    Public Function GetParentPath(Path_Orig As String) As String

        Dim NPath_Orig As String = NormalizePath(Path_Orig)

        If (NPath_Orig.Length < 3) Then
            Return NPath_Orig
        Else
            Dim i_Pos As Integer = NPath_Orig.LastIndexOf("\", NPath_Orig.Length - 2)
            Return NPath_Orig.Substring(0, i_Pos) + "\"
        End If

    End Function

    ''' <summary>
    ''' Remove the extension from a file name.
    ''' </summary>
    ''' <param name="str_FileName">un-pathed name of the file</param>
    ''' <returns>Every character before the last ".", if any</returns>
    ''' <credits>Original code by Mike Adams</credits>
    Public Function RemoveFileExtension(ByVal str_FileName As String) As String

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
