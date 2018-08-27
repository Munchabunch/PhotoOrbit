Imports System.IO
Imports System.IO.File
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions

Public Class frm_PhotoOrbit

    Private m_frmWebBrowser_01 As frm_WebBrowser
    Private m_Path_Displayed As String

#Region "Event procedures"

    Private Sub frm_PhotoOrb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        m_Path_Displayed = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))
        oDirListBox_01.Path = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))

        cbo_Path.Items.Add(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "2017 +\04 Apr\01 Sat\")

        m_frmWebBrowser_01 = New frm_WebBrowser

        '// TEST //
        oListView_Keys.Columns(0).ListView.Font = New Font(oListView_Keys.Columns(0).ListView.Font, FontStyle.Bold)

        FillKeysListView()

        '// If we have 3 monitors, use the one on the left:
        Dim numberofmonitors As Integer = Screen.AllScreens.Length
        If numberofmonitors > 2 Then
            Me.Bounds = Screen.AllScreens(1).Bounds
        End If

        '// Maximize the application.
        Me.WindowState = FormWindowState.Maximized

    End Sub

    ''' <summary>
    ''' Event is fired when a key is released.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frm_PhotoOrbit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        Dim img_01 As Image
        Dim EW As ExifWorks
        Dim oEncoderParameters_01 As EncoderParameters
        Dim oImageCodecInfo_01 As ImageCodecInfo

        Select Case e.KeyCode

            Case Keys.F11

                oEncoderParameters_01 = New EncoderParameters(1)
                oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

                img_01 = pic_01.Image
                EW = New ExifWorks(img_01)

                '// Rotate the image.
                img_01.RotateFlip(RotateFlipType.Rotate270FlipNone)

                '// Un-display the picture:
                pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
                pic_01.Refresh()

                '// Set the image's Orientation Exif property to normal.
                EW.SetPropertyInt16(ExifWorks.TagNames.Orientation, 1)

                '// Save the image to the file:
                oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
                img_01.Save(textbox_PathedFileName_Display.Text, oImageCodecInfo_01, oEncoderParameters_01)

                '// !! Important !! //
                EW.Dispose()

                '// Re-display the image:
                DisplayFile()

            Case Keys.F12

                oEncoderParameters_01 = New EncoderParameters(1)
                oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

                img_01 = pic_01.Image
                EW = New ExifWorks(img_01)

                '// Rotate the image.
                img_01.RotateFlip(RotateFlipType.Rotate90FlipNone)

                '// Un-display the picture:
                pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
                pic_01.Refresh()

                '// Set the image's Orientation Exif property to normal.
                EW.SetPropertyInt16(ExifWorks.TagNames.Orientation, 1)

                '// Save the image to the file:
                oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
                img_01.Save(textbox_PathedFileName_Display.Text, oImageCodecInfo_01, oEncoderParameters_01)

                '// !! Important !! //
                EW.Dispose()

                '// Re-display the image:
                DisplayFile()

            Case Else

        End Select

    End Sub

    ''' <summary>
    ''' Event occurs as the form is being closed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frm_PhotoOrbit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        SaveInfoFile()

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Rotate Left button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdbtn_RotateLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_RotateLeft.Click

        Dim img_01 As Image
        Dim EW As ExifWorks
        Dim oEncoderParameters_01 As EncoderParameters
        Dim oImageCodecInfo_01 As ImageCodecInfo


        oEncoderParameters_01 = New EncoderParameters(1)
        oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

        img_01 = pic_01.Image
        EW = New ExifWorks(img_01)

        '// Rotate the image.
        img_01.RotateFlip(RotateFlipType.Rotate270FlipNone)

        '// Un-display the picture:
        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
        pic_01.Refresh()

        '// Set the image's Orientation Exif property to normal.
        EW.SetPropertyInt16(ExifWorks.TagNames.Orientation, 1)

        '// Save the image to the file:
        oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
        img_01.Save(textbox_PathedFileName_Display.Text, oImageCodecInfo_01, oEncoderParameters_01)

        '// !! Important !! //
        EW.Dispose()

        '// Re-display the image:
        DisplayFile()

        oListView_Files.Focus()

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Rotate Left button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdbtn_RotateRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_RotateRight.Click

        Dim img_01 As Image
        Dim EW As ExifWorks
        Dim oEncoderParameters_01 As EncoderParameters
        Dim oImageCodecInfo_01 As ImageCodecInfo

        oEncoderParameters_01 = New EncoderParameters(1)
        oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

        img_01 = pic_01.Image
        EW = New ExifWorks(img_01)

        '// Rotate the image.
        img_01.RotateFlip(RotateFlipType.Rotate90FlipNone)

        '// Un-display the picture:
        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
        pic_01.Refresh()

        '// Set the image's Orientation Exif property to normal.
        EW.SetPropertyInt16(ExifWorks.TagNames.Orientation, 1)

        '// Save the image to the file:
        oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
        img_01.Save(textbox_PathedFileName_Display.Text, oImageCodecInfo_01, oEncoderParameters_01)

        '// !! Important !! //
        EW.Dispose()

        '// Re-display the image:
        DisplayFile()

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Enumerate button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Enumerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Enumerate.Click

        Dim str_Prompt As String
        Dim oMsgBoxStyle_01 As MsgBoxStyle
        Dim oMsgBoxResult_01 As MsgBoxResult

        str_Prompt = "This will rename the picture and video files to ''001'', ''002'', ''003'', etc."
        oMsgBoxStyle_01 = MsgBoxStyle.OkCancel

        '// Display the message.
        oMsgBoxResult_01 = MsgBox(str_Prompt, oMsgBoxStyle_01, My.Application.Info.ProductName)

        If oMsgBoxResult_01 = MsgBoxResult.Ok Then
            EnumerateFiles()
        End If

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Replace button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Replace_Click(sender As Object, e As EventArgs) Handles btn_Replace.Click

        Dim oDlgReplace_01 As New dlg_Replace
        Dim str_Find As String
        Dim str_Replace As String
        Dim Result As System.Windows.Forms.DialogResult

        '// Show oDlg_Replace_01 as a modal dialog
        Result = oDlgReplace_01.ShowDialog(Me)

        '// Read the contents of oDlg_Replace_01's text boxes:
        str_Find = oDlgReplace_01.m_text_Find.Text
        str_Replace = oDlgReplace_01.m_text_Replace.Text

        If (Result = System.Windows.Forms.DialogResult.OK And str_Find.Length > 0) Then

            textbox_Info.Text = textbox_Info.Text.Replace(str_Find, str_Replace)
            FillInfoListView()

        End If

        oDlgReplace_01.Dispose()

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Find Info button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_FindInfo_Click(sender As Object, e As EventArgs) Handles btn_FindInfo.Click

        Dim dlgFindInfo_01 As dlg_FindInfo
        Dim TextToSearchFor As String
        Dim Path_MyPictures As String
        Dim PathedFileNames_Info As New List(Of String)
        Dim PathedFileName_Info As String
        Dim lvi As ListViewItem
        Dim i As Integer


        Path_MyPictures = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))

        dlgFindInfo_01 = New dlg_FindInfo
        dlgFindInfo_01.ShowDialog()

        If (dlgFindInfo_01.DialogResult = DialogResult.OK) Then

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            TextToSearchFor = dlgFindInfo_01.oTextBox_TextToSearchFor.Text

            For Each PathedFileName_Info In My.Computer.FileSystem.GetFiles(
                My.Computer.FileSystem.SpecialDirectories.MyPictures,
                Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "info.txt")

                PathedFileNames_Info.Add(PathedFileName_Info)
            Next

            oListView_SearchResults.Items.Clear()

            For Each PathedFileName_Info In PathedFileNames_Info

                Dim lines = System.IO.File.ReadAllLines(PathedFileName_Info)

                For i = 0 To lines.Length - 1

                    If (dlgFindInfo_01.chkbox_StillPhotos.Checked And Not lines(i).Contains("[movie]")) _
                            Or (dlgFindInfo_01.chkbox_Movies.Checked And lines(i).Contains("[movie]")) Then

                        If (dlgFindInfo_01.chkbox_CaseSensitive.Checked And lines(i).Contains(TextToSearchFor)) _
                                Or (Not dlgFindInfo_01.chkbox_CaseSensitive.Checked And lines(i).ToLower.Contains(TextToSearchFor.ToLower)) Then

                            lvi = New ListViewItem(PathedFileName_Info)
                            lvi.SubItems.Add(lines(i))

                            oListView_SearchResults.Items.Add(lvi)

                        End If

                    End If

                Next

            Next

            If (oListView_SearchResults.Items.Count = 0) Then
                MsgBox("No results found.")
            Else
                oTabControl_01.SelectedTab = oTabPage_SearchResults
            End If

            Me.Cursor = System.Windows.Forms.Cursors.Default

        End If

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Map button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Map_Click(sender As Object, e As EventArgs) Handles btn_Map.Click

        Dim n_Latitude As Double = 33
        Dim n_Longitude As Double = -80
        Dim PropertyName As String
        Dim ItemNum As Integer


        For ItemNum = 1 To oListView_ExifData.Items.Count - 1
            PropertyName = oListView_ExifData.Items(ItemNum).Text
            If (PropertyName = "Latitude in decimal degrees") Then
                n_Latitude = oListView_ExifData.Items(ItemNum).SubItems(1).Text
            End If
        Next ItemNum

        For ItemNum = 1 To oListView_ExifData.Items.Count - 1
            PropertyName = oListView_ExifData.Items(ItemNum).Text
            If (PropertyName = "Longitude in decimal degrees") Then
                n_Longitude = oListView_ExifData.Items(ItemNum).SubItems(1).Text
            End If
        Next ItemNum

        If (Not m_frmWebBrowser_01.Visible) Then
            m_frmWebBrowser_01.Show(Me)
        End If
        m_frmWebBrowser_01.oWebBrowser_01.Navigate("https://www.openstreetmap.org/#map=17/" + n_Latitude.ToString + "/" + n_Longitude.ToString)

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the New Video Project button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_NewVideoProject_Click(sender As Object, e As EventArgs) Handles btn_NewVideoProject.Click

        Dim PathedFileName_Project As String
        Dim FileName_Project As String
        Dim oDlgTextString_01 As New dlg_TextString
        Dim Result As System.Windows.Forms.DialogResult

        oDlgTextString_01.lbl_Prompt.Text = "Enter Project Name: "

        '// Show text string dialog box modally:
        Result = oDlgTextString_01.ShowDialog(Me)

        If (Result = System.Windows.Forms.DialogResult.OK) Then

            m_Path_Displayed = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)) + "Projects\"

            FileName_Project = oDlgTextString_01.oTextBox_Entry.Text
            PathedFileName_Project = NormalizePath(m_Path_Displayed) + FileName_Project + "\"

            My.Computer.FileSystem.CreateDirectory(PathedFileName_Project)
            My.Computer.FileSystem.CreateDirectory(PathedFileName_Project + "Audio\")
            My.Computer.FileSystem.CreateDirectory(PathedFileName_Project + "Completed files\")
            My.Computer.FileSystem.CreateDirectory(PathedFileName_Project + "Draft files\")
            My.Computer.FileSystem.CreateDirectory(PathedFileName_Project + "Footage\")
            My.Computer.FileSystem.CreateDirectory(PathedFileName_Project + "Graphics\")
            My.Computer.FileSystem.CreateDirectory(PathedFileName_Project + "Project files\")

            m_Path_Displayed = PathedFileName_Project
            oDirListBox_01.Path = m_Path_Displayed

        End If

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the right-arrow (Go) button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Go_Click(sender As Object, e As EventArgs) Handles btn_Go.Click

        If Directory.Exists(cbo_Path.Text) Then
            oDirListBox_01.Path = cbo_Path.Text
            m_Path_Displayed = cbo_Path.Text
        End If

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <todo>Account for file extensions oother than jpeg.</todo>
    Private Sub oListView_SearchResults_DoubleClick(sender As Object, e As EventArgs) Handles oListView_SearchResults.DoubleClick

        Dim PathedFileName_Selected As String
        Dim FileName_Selected As String
        Dim FileTitle_Selected As String

        Dim str_Info As String
        Dim FileNum As Integer


        oDirListBox_01.Path = Path(oListView_SearchResults.SelectedItems(0).Text)
        m_Path_Displayed = oDirListBox_01.Path

        str_Info = oListView_SearchResults.SelectedItems(0).SubItems(1).Text
        FileTitle_Selected = str_Info.Substring(0, 3)
        FileName_Selected = FileTitle_Selected + ".jpeg"

        For FileNum = 0 To oListView_Files.Items.Count - 1
            If (oListView_Files.Items(FileNum).Text = FileName_Selected) Then
                PathedFileName_Selected = NormalizePath(m_Path_Displayed) + FileName_Selected
                textbox_PathedFileName_Display.Text = PathedFileName_Selected
                DisplayFile()
                HighlightDisplayedFile()
            End If
        Next FileNum

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub oListView_ExifData_DoubleClick(sender As Object, e As EventArgs) Handles oListView_ExifData.DoubleClick

        Dim oDlgTextString_01 As New dlg_TextString
        Dim Result As System.Windows.Forms.DialogResult
        Dim PropertyName As String
        Dim PropertyValue As String

        Dim img_01 As Image

        Dim FileName_Displayed As String
        Dim PathedFileName_Displayed As String
        Dim FileTitle_Displayed As String
        Dim FileExtension_Displayed As String
        Dim PathedFileName_New As String


        PathedFileName_Displayed = textbox_PathedFileName_Display.Text

        '↑↑ Exit if nothing is displayed.
        If PathedFileName_Displayed.Length < 1 Then Exit Sub

        FileName_Displayed = FileName(PathedFileName_Displayed)
        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)
        FileExtension_Displayed = FileExtension(FileName_Displayed)

        If (FileExtension_Displayed = "jpeg") Then

            Dim oEncoderParameters_01 As EncoderParameters
            Dim oImageCodecInfo_01 As ImageCodecInfo

            oEncoderParameters_01 = New EncoderParameters(1)
            oEncoderParameters_01.Param(0) = New EncoderParameter(Encoder.Quality, 75)
            oImageCodecInfo_01 = GetEncoderInfo("image/jpeg")

            PropertyName = oListView_ExifData.SelectedItems(0).Text

            Select Case PropertyName

                Case "Title", "Description", "Copyright", "Equipment Maker", "Equipment Model", "Software Used", "User Comment"

                    PropertyValue = oListView_ExifData.SelectedItems(0).SubItems(1).Text

                    oDlgTextString_01.lbl_Prompt.Text = "Enter New " + PropertyName + ": "
                    oDlgTextString_01.oTextBox_Entry.Text = PropertyValue

                    '// Show text string dialog box modally:
                    Result = oDlgTextString_01.ShowDialog(Me)

                    If (Result = System.Windows.Forms.DialogResult.OK) Then

                        Dim EW As New ExifWorks(PathedFileName_Displayed)

                        PropertyValue = oDlgTextString_01.oTextBox_Entry.Text

                        oListView_ExifData.SelectedItems(0).SubItems(1).Text = PropertyValue

                        Select Case PropertyName

                            Case "Title"

                                EW.SetPropertyString(ExifWorks.TagNames.ImageTitle, PropertyValue)

                            Case "Description"

                                EW.SetPropertyString(ExifWorks.TagNames.ImageDescription, PropertyValue)

                            Case "Copyright"

                                EW.SetPropertyString(ExifWorks.TagNames.Copyright, PropertyValue)

                            Case "Equipment Maker"

                                EW.SetPropertyString(ExifWorks.TagNames.EquipMake, PropertyValue)

                            Case "Equipment Model"

                                EW.SetPropertyString(ExifWorks.TagNames.EquipModel, PropertyValue)

                            Case "Software Used"

                                EW.SetPropertyString(ExifWorks.TagNames.SoftwareUsed, PropertyValue)

                            Case "User Comment"

                                EW.SetPropertyString(ExifWorks.TagNames.ExifUserComment, PropertyValue)

                        End Select

                        img_01 = EW.GetBitmap()

                        PathedFileName_New = NormalizePath(m_Path_Displayed) + FileTitle_Displayed + "_Edit." + FileExtension_Displayed

                        '// Un-display the picture:
                        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
                        pic_01.Refresh()

                        '// Save the image to the file:
                        img_01.Save(PathedFileName_New, oImageCodecInfo_01, oEncoderParameters_01)

                        '// !! Important !! //
                        EW.Dispose()

                        textbox_PathedFileName_Display.Text = PathedFileName_New

                        DisplayFile()

                        FillFileListView(m_Path_Displayed)

                        HighlightDisplayedFile()

                    End If

                Case "Latitude in DMS", "Longitude in DMS", "Latitude in decimal degrees", "Longitude in decimal degrees", "Altitude"

                    PropertyValue = oListView_ExifData.SelectedItems(0).SubItems(1).Text
                    My.Computer.Clipboard.SetText(PropertyValue)

            End Select

        End If

    End Sub

    ''' <summary>
    ''' Event occurs when the contents of a the DirListBox control has changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub oDirListBox_01_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles oDirListBox_01.Change

        m_Path_Displayed = oDirListBox_01.Path

        SaveInfoFile()

        '// Close the "Info" file.
        textbox_Info.Text = ""
        textbox_PathedFileName_Info.Text = ""

        '// Disable the "CopyText" controls:
        lbl_textbox_TextToCopy_01.Enabled = False
        textbox_TextToCopy_01.Enabled = False
        lbl_textbox_CopyLineCount_01.Enabled = False
        textbox_CopyLineCount_01.Enabled = False
        btn_Copy_01.Enabled = False
        btn_CopyDown_01.Enabled = False
        lbl_textbox_TextToCopy_02.Enabled = False
        textbox_TextToCopy_02.Enabled = False
        lbl_textbox_CopyLineCount_02.Enabled = False
        textbox_CopyLineCount_02.Enabled = False
        btn_Copy_02.Enabled = False
        btn_CopyDown_02.Enabled = False
        lbl_textbox_TextToCopy_03.Enabled = False
        textbox_TextToCopy_03.Enabled = False
        lbl_textbox_CopyLineCount_03.Enabled = False
        textbox_CopyLineCount_03.Enabled = False
        btn_Copy_03.Enabled = False
        btn_CopyDown_03.Enabled = False
        lbl_textbox_TextToCopy_04.Enabled = False
        textbox_TextToCopy_04.Enabled = False
        lbl_textbox_CopyLineCount_04.Enabled = False
        textbox_CopyLineCount_04.Enabled = False
        btn_Copy_04.Enabled = False
        btn_CopyDown_04.Enabled = False
        lbl_textbox_TextToCopy_05.Enabled = False
        textbox_TextToCopy_05.Enabled = False
        lbl_textbox_CopyLineCount_05.Enabled = False
        textbox_CopyLineCount_05.Enabled = False
        btn_Copy_05.Enabled = False
        btn_CopyDown_05.Enabled = False
        lbl_textbox_TextToCopy_06.Enabled = False
        textbox_TextToCopy_06.Enabled = False
        lbl_textbox_CopyLineCount_06.Enabled = False
        textbox_CopyLineCount_06.Enabled = False
        btn_Copy_06.Enabled = False
        btn_CopyDown_06.Enabled = False

        FillFileListView(m_Path_Displayed)

        DisplayInfo()

    End Sub

    ''' <summary>
    ''' Event is fired when a key is released and the file listview control box has the focus.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub oListView_Files_KeyUp(sender As Object, e As KeyEventArgs) Handles oListView_Files.KeyUp

        Dim str_Prompt As String
        Dim oMsgBoxStyle_01 As MsgBoxStyle
        Dim oMsgBoxResult_01 As MsgBoxResult
        Dim PathedFileName_Old As String
        Dim FileName_New As String
        Dim PathedFileName_New As String
        Dim SelectedItemIndex As Integer


        '↑↑ Exit if nothing is selected.
        If oListView_Files.SelectedItems.Count < 1 Then Exit Sub


        Select Case e.KeyCode

            Case Keys.Delete

                '// Remember which item was selected:
                SelectedItemIndex = oListView_Files.SelectedIndices(0)

                If (e.Modifiers = Keys.Shift) Then

                    '// Display the message.
                    str_Prompt = "This will PERMANENTLY delete ''" + oListView_Files.SelectedItems(0).Text + "''."
                    oMsgBoxStyle_01 = MsgBoxStyle.Exclamation Or MsgBoxStyle.OkCancel
                    oMsgBoxResult_01 = MsgBox(str_Prompt, oMsgBoxStyle_01, My.Application.Info.ProductName)

                    If oMsgBoxResult_01 = MsgBoxResult.Ok Then

                        '// Unload the picture:
                        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
                        pic_01.Refresh()

                        PathedFileName_Old = NormalizePath(m_Path_Displayed) + oListView_Files.SelectedItems(0).Text

                        Kill(PathedFileName_Old)

                        FillFileListView(m_Path_Displayed)

                    End If

                Else

                    '// Display the message.
                    str_Prompt = "This will delete ''" + oListView_Files.SelectedItems(0).Text + "''."
                    oMsgBoxStyle_01 = MsgBoxStyle.OkCancel
                    oMsgBoxResult_01 = MsgBox(str_Prompt, oMsgBoxStyle_01, My.Application.Info.ProductName)

                    If oMsgBoxResult_01 = MsgBoxResult.Ok Then

                        '// Unload the picture:
                        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
                        pic_01.Refresh()

                        PathedFileName_Old = NormalizePath(m_Path_Displayed) + oListView_Files.SelectedItems(0).Text
                        FileName_New = "Z_" + oListView_Files.SelectedItems(0).Text
                        PathedFileName_New = NormalizePath(m_Path_Displayed) + FileName_New

                        '// Make sure we aren't overwriting another file:
                        Do While (Exists(PathedFileName_New))
                            FileName_New = "Z" + FileName_New
                            PathedFileName_New = NormalizePath(m_Path_Displayed) + FileName_New
                        Loop

                        '// Rename the file:
                        My.Computer.FileSystem.RenameFile(PathedFileName_Old, FileName_New)

                        FillFileListView(m_Path_Displayed)

                    End If

                End If

            Case Keys.F2

                If (oListView_Files.SelectedIndices(0) <> -1) Then

                    '// Remember which item was selected:
                    SelectedItemIndex = oListView_Files.SelectedIndices(0)

                    Dim oDlgTextString_01 As New dlg_TextString
                    Dim Result As System.Windows.Forms.DialogResult

                    oDlgTextString_01.lbl_Prompt.Text = "Enter new file name:"
                    oDlgTextString_01.oTextBox_Entry.Text = oListView_Files.SelectedItems(0).Text

                    '// Show text string dialog box modally:
                    Result = oDlgTextString_01.ShowDialog(Me)

                    '// Read the contents of dialog box's text box:
                    FileName_New = oDlgTextString_01.oTextBox_Entry.Text

                    If (Result = System.Windows.Forms.DialogResult.OK) Then

                        PathedFileName_Old = NormalizePath(m_Path_Displayed) + oListView_Files.SelectedItems(0).Text
                        PathedFileName_New = NormalizePath(m_Path_Displayed) + FileName_New

                        '// Unload the picture:
                        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
                        pic_01.Refresh()

                        '// Rename the file:
                        My.Computer.FileSystem.RenameFile(PathedFileName_Old, FileName_New)

                        FillFileListView(m_Path_Displayed)

                        textbox_PathedFileName_Display.Text = PathedFileName_New
                        DisplayFile()
                        HighlightDisplayedFile()

                    End If

                    oDlgTextString_01.Dispose()

                End If

        End Select

    End Sub

    ''' <summary>
    ''' Event occurs when the user changes the selection in the File list view control.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub oListView_Files_SelectedIndexChanged(sender As Object, e As EventArgs) Handles oListView_Files.SelectedIndexChanged

        Dim FileName_Selected As String
        Dim PathedFileName_Selected As String
        Dim FileTitle_Selected As String
        Dim FileExtension_Selected As String

        '↑↑ Exit if nothing is selected.
        If oListView_Files.SelectedItems.Count < 1 Then Exit Sub

        FileName_Selected = oListView_Files.SelectedItems(0).Text
        FileExtension_Selected = FileExtension(FileName_Selected)
        PathedFileName_Selected = NormalizePath(m_Path_Displayed) + FileName_Selected
        FileTitle_Selected = RemoveFileExtension(FileName_Selected)

        textbox_PathedFileName_Display.Text = PathedFileName_Selected

        DisplayFile()

        HighlightDisplayedFile()

    End Sub

    Private Sub btn_CreateInfoFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CreateInfoFile.Click

        CreateNewInfoFile_V02()

    End Sub

    Private Sub btn_ConvertInfoFile_Click(sender As Object, e As EventArgs) Handles btn_ConvertInfoFile.Click

        ConvertInfoFile()

    End Sub

    Private Sub textbox_Info_KeyUp(sender As Object, e As KeyEventArgs) Handles textbox_Info.KeyUp

        If e.Control Then '// If the CTRL key is down ...

            Select Case e.KeyCode

                Case Keys.E '// (Echo current line)

                    Dim str_Line_Current As String
                    Dim LineNum_Current As Integer
                    Dim Pos_LineEnd As Integer

                    LineNum_Current = textbox_Info.GetLineFromCharIndex(textbox_Info.SelectionStart)

                    str_Line_Current = textbox_Info.Lines(LineNum_Current)

                    Pos_LineEnd = textbox_Info.GetFirstCharIndexFromLine(LineNum_Current + 1) - 1

                    '// Paste another copy of the current line after it:
                    textbox_Info.SelectionStart = Pos_LineEnd
                    textbox_Info.SelectionLength = 0
                    textbox_Info.SelectedText = vbCrLf + str_Line_Current

                    FillInfoListView()
                    HighlightDisplayedFile()

            End Select

        End If

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Gather Sub-folders button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub m_cmdbtn_GatherSubFolderFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmdbtn_GatherSubFolderFiles.Click

        Dim i_01 As Integer
        Dim i_02 As Integer
        Dim str_PathedFileName_Old As String
        Dim str_PathedFileName_New As String

        Me.Cursor = Cursors.WaitCursor

        For i_01 = 0 To oDirListBox_01.DirListCount - 1
            oDirListBox_01.Path = oDirListBox_01.DirList(i_01)
            m_Path_Displayed = oDirListBox_01.DirList(i_01)
            For i_02 = 0 To oListView_Files.Items.Count - 1
                If oListView_Files.Items(i_02).Text.Substring(0, 3) <> "ZZZ" Then
                    str_PathedFileName_Old = NormalizePath(m_Path_Displayed) + oListView_Files.Items(i_02).Text
                    str_PathedFileName_New = NormalizePath(m_Path_Displayed) + FolderName(NormalizePath(m_Path_Displayed)) + "_" + oListView_Files.Items(i_02).Text
                    FileCopy(str_PathedFileName_Old, str_PathedFileName_New)
                End If
            Next
        Next

        FillFileListView(m_Path_Displayed)

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub chkbtn_ShowDetails_CheckedChanged(sender As Object, e As EventArgs) Handles chkbtn_ShowDetails.CheckedChanged

        If (chkbtn_ShowDetails.Checked) Then
            oListView_Files.View = View.Details
        Else
            oListView_Files.View = View.List
        End If

    End Sub

    Private Sub btn_Copy_01_Click(sender As Object, e As EventArgs) Handles btn_Copy_01.Click

        Dim FileTitle_DisplayedPhoto As String

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        str_NewText = ""

        FileTitle_DisplayedPhoto = RemoveFileExtension(FileName(textbox_PathedFileName_Display.Text))

        For i_LineNum = 0 To textbox_Info.Lines.Length - 2

            str_Line = textbox_Info.Lines(i_LineNum)

            If (str_Line.StartsWith(FileTitle_DisplayedPhoto)) Then
                str_NewText += str_Line + textbox_TextToCopy_01.Text + vbLf
                i_LastChangedLineNum = i_LineNum
            Else
                str_NewText += str_Line + vbLf
            End If

        Next i_LineNum

        textbox_Info.Text = str_NewText

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_Copy_02_Click(sender As Object, e As EventArgs) Handles btn_Copy_02.Click

        Dim FileTitle_DisplayedPhoto As String

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        str_NewText = ""

        FileTitle_DisplayedPhoto = RemoveFileExtension(FileName(textbox_PathedFileName_Display.Text))

        For i_LineNum = 0 To textbox_Info.Lines.Length - 2

            str_Line = textbox_Info.Lines(i_LineNum)

            If (str_Line.StartsWith(FileTitle_DisplayedPhoto)) Then
                str_NewText += str_Line + textbox_TextToCopy_02.Text + vbLf
                i_LastChangedLineNum = i_LineNum
            Else
                str_NewText += str_Line + vbLf
            End If

        Next i_LineNum

        textbox_Info.Text = str_NewText

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_Copy_03_Click(sender As Object, e As EventArgs) Handles btn_Copy_03.Click

        Dim FileTitle_DisplayedPhoto As String

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        str_NewText = ""

        FileTitle_DisplayedPhoto = RemoveFileExtension(FileName(textbox_PathedFileName_Display.Text))

        For i_LineNum = 0 To textbox_Info.Lines.Length - 2

            str_Line = textbox_Info.Lines(i_LineNum)

            If (str_Line.StartsWith(FileTitle_DisplayedPhoto)) Then
                str_NewText += str_Line + textbox_TextToCopy_03.Text + vbLf
                i_LastChangedLineNum = i_LineNum
            Else
                str_NewText += str_Line + vbLf
            End If

        Next i_LineNum

        textbox_Info.Text = str_NewText

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_Copy_04_Click(sender As Object, e As EventArgs) Handles btn_Copy_04.Click

        Dim FileTitle_DisplayedPhoto As String

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        str_NewText = ""

        FileTitle_DisplayedPhoto = RemoveFileExtension(FileName(textbox_PathedFileName_Display.Text))

        For i_LineNum = 0 To textbox_Info.Lines.Length - 2

            str_Line = textbox_Info.Lines(i_LineNum)

            If (str_Line.StartsWith(FileTitle_DisplayedPhoto)) Then
                str_NewText += str_Line + textbox_TextToCopy_04.Text + vbLf
                i_LastChangedLineNum = i_LineNum
            Else
                str_NewText += str_Line + vbLf
            End If

        Next i_LineNum

        textbox_Info.Text = str_NewText

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_Copy_05_Click(sender As Object, e As EventArgs) Handles btn_Copy_05.Click

        Dim FileTitle_DisplayedPhoto As String

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        str_NewText = ""

        FileTitle_DisplayedPhoto = RemoveFileExtension(FileName(textbox_PathedFileName_Display.Text))

        For i_LineNum = 0 To textbox_Info.Lines.Length - 2

            str_Line = textbox_Info.Lines(i_LineNum)

            If (str_Line.StartsWith(FileTitle_DisplayedPhoto)) Then
                str_NewText += str_Line + textbox_TextToCopy_05.Text + vbLf
                i_LastChangedLineNum = i_LineNum
            Else
                str_NewText += str_Line + vbLf
            End If

        Next i_LineNum

        textbox_Info.Text = str_NewText

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_Copy_06_Click(sender As Object, e As EventArgs) Handles btn_Copy_06.Click

        Dim FileTitle_DisplayedPhoto As String

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        str_NewText = ""

        FileTitle_DisplayedPhoto = RemoveFileExtension(FileName(textbox_PathedFileName_Display.Text))

        For i_LineNum = 0 To textbox_Info.Lines.Length - 2

            str_Line = textbox_Info.Lines(i_LineNum)

            If (str_Line.StartsWith(FileTitle_DisplayedPhoto)) Then
                str_NewText += str_Line + textbox_TextToCopy_06.Text + vbLf
                i_LastChangedLineNum = i_LineNum
            Else
                str_NewText += str_Line + vbLf
            End If

        Next i_LineNum

        textbox_Info.Text = str_NewText

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_CopyDown_01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CopyDown_01.Click

        Dim FileName_Displayed As String
        Dim FileTitle_Displayed As String

        Dim i_PhotoNum As Integer
        Dim CopyLineCount As Integer

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0
        Dim lvi As ListViewItem


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        CopyLineCount = Val(textbox_CopyLineCount_01.Text)
        If CopyLineCount < 1 Then CopyLineCount = 1

        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)

        For i_PhotoNum = 1 To CopyLineCount

            str_NewText = ""

            For i_LineNum = 0 To textbox_Info.Lines.Length - 2

                str_Line = textbox_Info.Lines(i_LineNum)

                If (str_Line.StartsWith(FileTitle_Displayed)) Then
                    str_NewText += str_Line + textbox_TextToCopy_01.Text + vbLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbLf
                End If

            Next i_LineNum

            textbox_Info.Text = str_NewText

            '// Find the next file and put it in the textbox:
            oListView_Files.SelectedItems.Clear()
            For Each lvi In oListView_Files.Items
                If (lvi.Text = FileName_Displayed) Then
                    If (lvi.Index < oListView_Files.Items.Count - 1) Then
                        oListView_Files.Items(lvi.Index + 1).Selected = True
                        oListView_Files.Items(lvi.Index + 1).Focused = True
                        textbox_PathedFileName_Display.Text = NormalizePath(m_Path_Displayed) + oListView_Files.Items(lvi.Index + 1).Text
                        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
                        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)
                        Exit For
                    End If
                End If
            Next lvi

            '// Show the line in the Info text box if possible:
            If (i_LastChangedLineNum > 0) Then
                GoToLine(i_LastChangedLineNum + 1)
            End If

        Next i_PhotoNum

        textbox_CopyLineCount_01.Text = "1"

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_CopyDown_02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CopyDown_02.Click

        Dim FileName_Displayed As String
        Dim FileTitle_Displayed As String

        Dim i_PhotoNum As Integer
        Dim CopyLineCount As Integer

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0
        Dim lvi As ListViewItem


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        CopyLineCount = Val(textbox_CopyLineCount_02.Text)
        If CopyLineCount < 1 Then CopyLineCount = 1

        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)

        For i_PhotoNum = 1 To CopyLineCount

            str_NewText = ""

            For i_LineNum = 0 To textbox_Info.Lines.Length - 2

                str_Line = textbox_Info.Lines(i_LineNum)

                If (str_Line.StartsWith(FileTitle_Displayed)) Then
                    str_NewText += str_Line + textbox_TextToCopy_02.Text + vbLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbLf
                End If

            Next i_LineNum

            textbox_Info.Text = str_NewText

            '// Find the next file and put it in the textbox:
            oListView_Files.SelectedItems.Clear()
            For Each lvi In oListView_Files.Items
                If (lvi.Text = FileName_Displayed) Then
                    If (lvi.Index < oListView_Files.Items.Count - 1) Then
                        oListView_Files.Items(lvi.Index + 1).Selected = True
                        oListView_Files.Items(lvi.Index + 1).Focused = True
                        textbox_PathedFileName_Display.Text = NormalizePath(m_Path_Displayed) + oListView_Files.Items(lvi.Index + 1).Text
                        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
                        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)
                        Exit For
                    End If
                End If
            Next lvi

            '// Show the line in the Info text box if possible:
            If (i_LastChangedLineNum > 0) Then
                GoToLine(i_LastChangedLineNum + 1)
            End If

        Next i_PhotoNum

        textbox_CopyLineCount_02.Text = "1"

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_CopyDown_03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CopyDown_03.Click

        Dim FileName_Displayed As String
        Dim FileTitle_Displayed As String

        Dim i_PhotoNum As Integer
        Dim CopyLineCount As Integer

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0
        Dim lvi As ListViewItem


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        CopyLineCount = Val(textbox_CopyLineCount_03.Text)
        If CopyLineCount < 1 Then CopyLineCount = 1

        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)

        For i_PhotoNum = 1 To CopyLineCount

            str_NewText = ""

            For i_LineNum = 0 To textbox_Info.Lines.Length - 2

                str_Line = textbox_Info.Lines(i_LineNum)

                If (str_Line.StartsWith(FileTitle_Displayed)) Then
                    str_NewText += str_Line + textbox_TextToCopy_03.Text + vbLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbLf
                End If

            Next i_LineNum

            textbox_Info.Text = str_NewText

            '// Find the next file and put it in the textbox:
            oListView_Files.SelectedItems.Clear()
            For Each lvi In oListView_Files.Items
                If (lvi.Text = FileName_Displayed) Then
                    If (lvi.Index < oListView_Files.Items.Count - 1) Then
                        oListView_Files.Items(lvi.Index + 1).Selected = True
                        oListView_Files.Items(lvi.Index + 1).Focused = True
                        textbox_PathedFileName_Display.Text = NormalizePath(m_Path_Displayed) + oListView_Files.Items(lvi.Index + 1).Text
                        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
                        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)
                        Exit For
                    End If
                End If
            Next lvi

            '// Show the line in the Info text box if possible:
            If (i_LastChangedLineNum > 0) Then
                GoToLine(i_LastChangedLineNum + 1)
            End If

        Next i_PhotoNum

        textbox_CopyLineCount_03.Text = "1"

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_CopyDown_04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CopyDown_04.Click

        Dim FileName_Displayed As String
        Dim FileTitle_Displayed As String

        Dim i_PhotoNum As Integer
        Dim CopyLineCount As Integer

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0
        Dim lvi As ListViewItem


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        CopyLineCount = Val(textbox_CopyLineCount_04.Text)
        If CopyLineCount < 1 Then CopyLineCount = 1

        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)

        For i_PhotoNum = 1 To CopyLineCount

            str_NewText = ""

            For i_LineNum = 0 To textbox_Info.Lines.Length - 2

                str_Line = textbox_Info.Lines(i_LineNum)

                If (str_Line.StartsWith(FileTitle_Displayed)) Then
                    str_NewText += str_Line + textbox_TextToCopy_04.Text + vbLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbLf
                End If

            Next i_LineNum

            textbox_Info.Text = str_NewText

            '// Find the next file and put it in the textbox:
            oListView_Files.SelectedItems.Clear()
            For Each lvi In oListView_Files.Items
                If (lvi.Text = FileName_Displayed) Then
                    If (lvi.Index < oListView_Files.Items.Count - 1) Then
                        oListView_Files.Items(lvi.Index + 1).Selected = True
                        oListView_Files.Items(lvi.Index + 1).Focused = True
                        textbox_PathedFileName_Display.Text = NormalizePath(m_Path_Displayed) + oListView_Files.Items(lvi.Index + 1).Text
                        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
                        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)
                        Exit For
                    End If
                End If
            Next lvi

            '// Show the line in the Info text box if possible:
            If (i_LastChangedLineNum > 0) Then
                GoToLine(i_LastChangedLineNum + 1)
            End If

        Next i_PhotoNum

        textbox_CopyLineCount_04.Text = "1"

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_CopyDown_05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CopyDown_05.Click

        Dim FileName_Displayed As String
        Dim FileTitle_Displayed As String

        Dim i_PhotoNum As Integer
        Dim CopyLineCount As Integer

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0
        Dim lvi As ListViewItem


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        CopyLineCount = Val(textbox_CopyLineCount_05.Text)
        If CopyLineCount < 1 Then CopyLineCount = 1

        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)

        For i_PhotoNum = 1 To CopyLineCount

            str_NewText = ""

            For i_LineNum = 0 To textbox_Info.Lines.Length - 2

                str_Line = textbox_Info.Lines(i_LineNum)

                If (str_Line.StartsWith(FileTitle_Displayed)) Then
                    str_NewText += str_Line + textbox_TextToCopy_05.Text + vbLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbLf
                End If

            Next i_LineNum

            textbox_Info.Text = str_NewText

            '// Find the next file and put it in the textbox:
            oListView_Files.SelectedItems.Clear()
            For Each lvi In oListView_Files.Items
                If (lvi.Text = FileName_Displayed) Then
                    If (lvi.Index < oListView_Files.Items.Count - 1) Then
                        oListView_Files.Items(lvi.Index + 1).Selected = True
                        oListView_Files.Items(lvi.Index + 1).Focused = True
                        textbox_PathedFileName_Display.Text = NormalizePath(m_Path_Displayed) + oListView_Files.Items(lvi.Index + 1).Text
                        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
                        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)
                        Exit For
                    End If
                End If
            Next lvi

            '// Show the line in the Info text box if possible:
            If (i_LastChangedLineNum > 0) Then
                GoToLine(i_LastChangedLineNum + 1)
            End If

        Next i_PhotoNum

        textbox_CopyLineCount_05.Text = "1"

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub btn_CopyDown_06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CopyDown_06.Click

        Dim FileName_Displayed As String
        Dim FileTitle_Displayed As String

        Dim i_PhotoNum As Integer
        Dim CopyLineCount As Integer

        Dim str_Line As String
        Dim i_LineNum As Integer
        Dim str_NewText As String = ""
        Dim i_LastChangedLineNum As Integer = 0
        Dim lvi As ListViewItem


        '↑↑ Exit if no file is displayed.
        If (textbox_PathedFileName_Display.Text.Length = 0) Then Exit Sub

        CopyLineCount = Val(textbox_CopyLineCount_06.Text)
        If CopyLineCount < 1 Then CopyLineCount = 1

        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)

        For i_PhotoNum = 1 To CopyLineCount

            str_NewText = ""

            For i_LineNum = 0 To textbox_Info.Lines.Length - 2

                str_Line = textbox_Info.Lines(i_LineNum)

                If (str_Line.StartsWith(FileTitle_Displayed)) Then
                    str_NewText += str_Line + textbox_TextToCopy_06.Text + vbLf
                    i_LastChangedLineNum = i_LineNum
                Else
                    str_NewText += str_Line + vbLf
                End If

            Next i_LineNum

            textbox_Info.Text = str_NewText

            '// Find the next file and put it in the textbox:
            oListView_Files.SelectedItems.Clear()
            For Each lvi In oListView_Files.Items
                If (lvi.Text = FileName_Displayed) Then
                    If (lvi.Index < oListView_Files.Items.Count - 1) Then
                        oListView_Files.Items(lvi.Index + 1).Selected = True
                        oListView_Files.Items(lvi.Index + 1).Focused = True
                        textbox_PathedFileName_Display.Text = NormalizePath(m_Path_Displayed) + oListView_Files.Items(lvi.Index + 1).Text
                        FileName_Displayed = FileName(textbox_PathedFileName_Display.Text)
                        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)
                        Exit For
                    End If
                End If
            Next lvi

            '// Show the line in the Info text box if possible:
            If (i_LastChangedLineNum > 0) Then
                GoToLine(i_LastChangedLineNum + 1)
            End If

        Next i_PhotoNum

        textbox_CopyLineCount_06.Text = "1"

        '// Display the file:
        If Len(textbox_PathedFileName_Display.Text) > 0 Then
            DisplayFile()
            FillInfoListView()
            HighlightDisplayedFile()
        End If

        oListView_Files.Focus()

    End Sub

    Private Sub cmdbtn_BackupFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn_BackupFile.Click

        BackupFile(textbox_PathedFileName_Info.Text)
        FillFileListView(m_Path_Displayed)

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Pictures button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Folder_Pictures_Click(sender As Object, e As EventArgs) Handles btn_Folder_Pictures.Click

        m_Path_Displayed = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))
        oDirListBox_01.Path = m_Path_Displayed

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Videos button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Folder_Videos_Click(sender As Object, e As EventArgs) Handles btn_Folder_Videos.Click

        m_Path_Displayed = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos))
        oDirListBox_01.Path = m_Path_Displayed

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the up-arrow button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Up_Click(sender As Object, e As EventArgs) Handles btn_Up.Click

        Dim oFileInfo_Folder As FileInfo

        If (m_Path_Displayed.Length > 3) Then
            oFileInfo_Folder = New FileInfo(m_Path_Displayed)
            oDirListBox_01.Path = oFileInfo_Folder.Directory.FullName
            m_Path_Displayed = oFileInfo_Folder.Directory.FullName
        End If

    End Sub

    ''' <summary>
    ''' Event occurs when the user presses the Now button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Now_Click(sender As Object, e As EventArgs) Handles btn_Now.Click

        Dim Path_New As String
        Dim str_CurrentYear As String = DateTime.Now.Year.ToString()
        Dim str_CurrentMonth As String = DateTime.Now.Month.ToString()
        Dim ItemNum_01 As Integer = 0
        Dim DirObjName_01 As String


        SaveInfoFile()

        If (str_CurrentMonth.Length = 1) Then str_CurrentMonth = "0" + str_CurrentMonth

        '// Set to the default path for pictures:
        Path_New = NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))

        oDirListBox_01.Path = Path_New

        '// Look for the current year:
        For ItemNum_01 = 0 To oDirListBox_01.Items.Count - 1
            DirObjName_01 = oDirListBox_01.Items(ItemNum_01)
            If DirObjName_01 = str_CurrentYear Then
                Path_New += DirObjName_01 + "\"
            End If
        Next ItemNum_01

        oDirListBox_01.Path = Path_New

        '// Look for the current month:
        For ItemNum_01 = 0 To oDirListBox_01.Items.Count - 1
            DirObjName_01 = oDirListBox_01.Items(ItemNum_01)
            If DirObjName_01.StartsWith(str_CurrentMonth) Then
                Path_New = NormalizePath(oDirListBox_01.Path) + DirObjName_01 + "\"
            End If
        Next ItemNum_01

        oDirListBox_01.Path = Path_New
        m_Path_Displayed = Path_New

    End Sub

    Private Sub oListView_Info_SelectedIndexChanged(sender As Object, e As EventArgs) Handles oListView_Info.SelectedIndexChanged

        Dim PathedFileName_ToDisplay As String
        Dim FileTitle As String
        Dim FileExtension_ToDisplay As String
        Dim PicNum_Selected As Integer
        Dim PicNum As Integer
        Dim FileNum As Integer
        Dim lvi As ListViewItem

        Dim InfoFileVersion As Integer = textbox_Version.Text


        '// Un-highlight all items item in the Info listview:
        For Each lvi In oListView_Info.Items
            lvi.BackColor = SystemColors.Window
        Next lvi

        Select Case InfoFileVersion

            Case 1

                If (oListView_Info.SelectedItems.Count > 0) Then
                    If (IsNumeric(oListView_Info.SelectedItems(0).Text)) Then
                        PicNum_Selected = oListView_Info.SelectedItems(0).Text
                        For FileNum = 0 To oListView_Files.Items.Count - 1
                            FileTitle = RemoveFileExtension(oListView_Files.Items(FileNum).Text)
                            If (IsNumeric(FileTitle)) Then
                                PicNum = FileTitle
                                If (PicNum = PicNum_Selected) Then
                                    FileExtension_ToDisplay = FileExtension(oListView_Files.Items(FileNum).Text)
                                    PathedFileName_ToDisplay = NormalizePath(m_Path_Displayed) + FileTitle + "." + FileExtension_ToDisplay
                                    textbox_PathedFileName_Display.Text = PathedFileName_ToDisplay
                                    DisplayFile()
                                    HighlightDisplayedFile()
                                End If
                            End If
                        Next FileNum
                    End If
                End If

            Case 2

                If (oListView_Info.SelectedItems.Count > 0) Then
                    PathedFileName_ToDisplay = NormalizePath(m_Path_Displayed) + oListView_Info.SelectedItems(0).Text
                    If (Exists(PathedFileName_ToDisplay)) Then
                        textbox_PathedFileName_Display.Text = PathedFileName_ToDisplay
                        DisplayFile()
                        HighlightDisplayedFile()
                    End If
                End If

        End Select

    End Sub

    Private Sub textbox_PathedFileName_Display_TextChanged(sender As Object, e As EventArgs) Handles textbox_PathedFileName_Display.TextChanged

        DisplayFileProperties(textbox_PathedFileName_Display.Text)

    End Sub

    Private Sub oSplitContainer_Left_SplitterMoving(sender As Object, e As SplitterCancelEventArgs) Handles oSplitContainer_Left.SplitterMoving

        '// &&&& //

        '// WORKING //
        'ResizeUniformly_Horizontal({btn_Folder_Pictures, btn_Folder_Videos}, oSplitContainer_Left.Panel1.Width)

    End Sub

    Private Sub oSplitContainer_Left_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles oSplitContainer_Left.SplitterMoved

        '// WORKING //
        ResizeUniformly_Horizontal({btn_Folder_Pictures, btn_Folder_Videos}, oSplitContainer_Left.Panel1.Width)

    End Sub

#End Region


#Region "Private methods"

    ''' <summary>
    ''' Retrieve Image Codec Info data for the specified type.
    ''' </summary>
    ''' <param name="mimeType"></param>
    ''' <returns></returns>
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
    ''' Display the file named in the textbox in the picture box (or media player). Update the Properties list box and the Exif properties ListView control if applicable.
    ''' </summary>
    Private Sub DisplayFile()

        Dim PathedFileName_ToDisplay As String
        Dim FileExtension_ToDisplay As String

        Dim img_01 As Image
        Dim EW As ExifWorks
        Dim str_Orientation As String
        Dim rotateFlip = RotateFlipType.RotateNoneFlipNone


        PathedFileName_ToDisplay = textbox_PathedFileName_Display.Text

        '↑↑ Exit if no file is named in the textbox.
        If PathedFileName_ToDisplay.Length < 1 Then Exit Sub

        FileExtension_ToDisplay = FileExtension(PathedFileName_ToDisplay)

        Select Case LCase$(FileExtension_ToDisplay)

            Case "bmp", "gif", "png"

                pic_01.Visible = True
                pic_01.Load(PathedFileName_ToDisplay)
                mplayer_01.Visible = False
                mplayer_01.URL = ""

                ClearExifData()

            Case "jpg", "jpeg"

                EW = New ExifWorks(PathedFileName_ToDisplay)
                str_Orientation = [Enum].GetName(GetType(ExifWorks.Orientations), EW.Orientation)

                If (str_Orientation <> "TopLeft") Then

                    '// Correct the image's orientation:
                    Select Case str_Orientation
                        Case "TopRight"
                            rotateFlip = RotateFlipType.RotateNoneFlipX
                        Case "BottomRight"
                            rotateFlip = RotateFlipType.Rotate180FlipNone
                        Case "BottomLeft"
                            rotateFlip = RotateFlipType.Rotate180FlipX
                        Case "LeftTop"
                            rotateFlip = RotateFlipType.Rotate90FlipX
                        Case "RightTop"
                            rotateFlip = RotateFlipType.Rotate90FlipNone
                        Case "RightBottom"
                            rotateFlip = RotateFlipType.Rotate270FlipX
                        Case "LeftBottom"
                            rotateFlip = RotateFlipType.Rotate270FlipNone
                    End Select
                    img_01 = EW.GetBitmap()
                    img_01.RotateFlip(rotateFlip)

                    pic_01.Image = img_01

                Else

                    pic_01.Load(PathedFileName_ToDisplay)

                End If

                pic_01.Visible = True
                mplayer_01.Visible = False
                mplayer_01.URL = ""

                DisplayExifData(PathedFileName_ToDisplay)

                '// !! Important !! //
                EW.Dispose()

            Case "wav", "mid", "midi", "mp3"

                pic_01.Visible = False
                mplayer_01.Visible = True
                mplayer_01.URL = PathedFileName_ToDisplay

                ClearExifData()

            Case "mov", "avi", "mpg", "mpeg", "mp4", "wmv"

                pic_01.Visible = False
                mplayer_01.Visible = True
                mplayer_01.URL = PathedFileName_ToDisplay

                ClearExifData()

            Case Else

                pic_01.Visible = False
                mplayer_01.Visible = False
                mplayer_01.URL = ""

                ClearExifData()

        End Select

    End Sub

    ''' <summary>
    ''' Highlight the displayed file in both the File section and the Info section.
    ''' </summary>
    Private Sub HighlightDisplayedFile()

        Dim FileName_Displayed As String
        Dim PathedFileName_Displayed As String
        Dim FileTitle_Displayed As String
        Dim FileExtension_Displayed As String
        Dim lvi As ListViewItem


        PathedFileName_Displayed = textbox_PathedFileName_Display.Text

        '// Un-highlight all files:
        For Each lvi In oListView_Files.Items
            lvi.BackColor = SystemColors.Window
        Next lvi
        For Each lvi In oListView_Info.Items
            lvi.BackColor = SystemColors.Window
        Next lvi

        '↑↑ Exit if nothing is displayed.
        If PathedFileName_Displayed.Length < 1 Then Exit Sub

        FileName_Displayed = FileName(PathedFileName_Displayed)
        FileTitle_Displayed = RemoveFileExtension(FileName_Displayed)
        FileExtension_Displayed = FileExtension(FileName_Displayed)

        Select Case textbox_Version.Text

            Case 1

                Select Case LCase$(FileExtension_Displayed)

                    Case "bmp", "jpg", "jpeg", "png", "mov", "avi", "mpg", "mpeg", "mp4", "wmv"

                        '// Highlight the selected file in the File section:
                        For Each lvi In oListView_Files.Items
                            If (lvi.Text = FileName_Displayed) Then
                                '// Highlight the file.
                                lvi.BackColor = Color.Yellow
                                lvi.EnsureVisible()
                            Else
                                '// Un-highlight the file.
                                lvi.BackColor = SystemColors.Window
                            End If
                        Next lvi

                        '// Highlight the displayed file in the Info section:
                        For Each lvi In oListView_Info.Items
                            If (lvi.Text = FileTitle_Displayed) Then
                                '// Highlight the file.
                                lvi.BackColor = Color.Yellow
                                lvi.EnsureVisible()
                            Else
                                '// Un-highlight the file.
                                lvi.BackColor = SystemColors.Window
                            End If
                        Next lvi

                End Select

            Case 2

                Select Case LCase$(FileExtension_Displayed)

                    Case "bmp", "jpg", "jpeg", "png", "mov", "avi", "mpg", "mpeg", "mp4", "wmv"

                        '// Highlight the selected file in the File section:
                        For Each lvi In oListView_Files.Items
                            If (lvi.Text = FileName_Displayed) Then
                                '// Highlight the file.
                                lvi.BackColor = Color.Yellow
                                lvi.EnsureVisible()
                            Else
                                '// Un-highlight the file.
                                lvi.BackColor = SystemColors.Window
                            End If
                        Next lvi

                        '// Highlight the displayed file in the Info section:
                        For Each lvi In oListView_Info.Items
                            If (lvi.Text = FileName_Displayed) Then
                                '// Highlight the file.
                                lvi.BackColor = Color.Yellow
                                lvi.EnsureVisible()
                            Else
                                '// Un-highlight the file.
                                lvi.BackColor = SystemColors.Window
                            End If
                        Next lvi

                End Select

        End Select

    End Sub

    ''' <summary>
    ''' Display the info.txt file in the text box.
    ''' </summary>
    Private Sub DisplayInfo()

        Dim str_PathedFileName_Info As String

        str_PathedFileName_Info = NormalizePath(m_Path_Displayed) + "info.txt"

        '// Update the Path combo box:
        cbo_Path.Items.Insert(0, NormalizePath(m_Path_Displayed))
        cbo_Path.SelectedIndex = 0

        If Exists(str_PathedFileName_Info) Then

            textbox_Info.Visible = True
            textbox_Info.Text = GetFileContents(str_PathedFileName_Info)
            oListView_Info.Visible = True

            textbox_PathedFileName_Info.Text = str_PathedFileName_Info

            btn_CreateInfoFile.Enabled = False

            '// Enable the "CopyText" controls:
            lbl_textbox_TextToCopy_01.Enabled = True
            textbox_TextToCopy_01.Enabled = True
            lbl_textbox_CopyLineCount_01.Enabled = True
            textbox_CopyLineCount_01.Enabled = True
            btn_Copy_01.Enabled = True
            btn_CopyDown_01.Enabled = True
            lbl_textbox_TextToCopy_02.Enabled = True
            textbox_TextToCopy_02.Enabled = True
            lbl_textbox_CopyLineCount_02.Enabled = True
            textbox_CopyLineCount_02.Enabled = True
            btn_Copy_02.Enabled = True
            btn_CopyDown_02.Enabled = True
            lbl_textbox_TextToCopy_03.Enabled = True
            textbox_TextToCopy_03.Enabled = True
            lbl_textbox_CopyLineCount_03.Enabled = True
            textbox_CopyLineCount_03.Enabled = True
            btn_Copy_03.Enabled = True
            btn_CopyDown_03.Enabled = True
            lbl_textbox_TextToCopy_04.Enabled = True
            textbox_TextToCopy_04.Enabled = True
            lbl_textbox_CopyLineCount_04.Enabled = True
            textbox_CopyLineCount_04.Enabled = True
            btn_Copy_04.Enabled = True
            btn_CopyDown_04.Enabled = True
            lbl_textbox_TextToCopy_05.Enabled = True
            textbox_TextToCopy_05.Enabled = True
            lbl_textbox_CopyLineCount_05.Enabled = True
            textbox_CopyLineCount_05.Enabled = True
            btn_Copy_05.Enabled = True
            btn_CopyDown_05.Enabled = True
            lbl_textbox_TextToCopy_06.Enabled = True
            textbox_TextToCopy_06.Enabled = True
            lbl_textbox_CopyLineCount_06.Enabled = True
            textbox_CopyLineCount_06.Enabled = True
            btn_Copy_06.Enabled = True
            btn_CopyDown_06.Enabled = True

            FillInfoListView()

        Else

            textbox_Info.Visible = False
            textbox_Info.Text = ""
            oListView_Info.Visible = False

            textbox_PathedFileName_Info.Text = ""

            btn_CreateInfoFile.Enabled = True

            '// Disable the "CopyText" controls:
            lbl_textbox_TextToCopy_01.Enabled = False
            textbox_TextToCopy_01.Enabled = False
            lbl_textbox_CopyLineCount_01.Enabled = False
            textbox_CopyLineCount_01.Enabled = False
            btn_CopyDown_01.Enabled = False
            lbl_textbox_TextToCopy_02.Enabled = False
            textbox_TextToCopy_02.Enabled = False
            lbl_textbox_CopyLineCount_02.Enabled = False
            textbox_CopyLineCount_02.Enabled = False
            btn_CopyDown_02.Enabled = False
            lbl_textbox_TextToCopy_03.Enabled = False
            textbox_TextToCopy_03.Enabled = False
            lbl_textbox_CopyLineCount_03.Enabled = False
            textbox_CopyLineCount_03.Enabled = False
            btn_CopyDown_03.Enabled = False
            lbl_textbox_TextToCopy_04.Enabled = False
            textbox_TextToCopy_04.Enabled = False
            lbl_textbox_CopyLineCount_04.Enabled = False
            textbox_CopyLineCount_04.Enabled = False
            btn_CopyDown_04.Enabled = False
            lbl_textbox_TextToCopy_05.Enabled = False
            textbox_TextToCopy_05.Enabled = False
            lbl_textbox_CopyLineCount_05.Enabled = False
            textbox_CopyLineCount_05.Enabled = False
            btn_CopyDown_05.Enabled = False
            lbl_textbox_TextToCopy_06.Enabled = False
            textbox_TextToCopy_06.Enabled = False
            lbl_textbox_CopyLineCount_06.Enabled = False
            textbox_CopyLineCount_06.Enabled = False
            btn_CopyDown_06.Enabled = False

        End If

    End Sub

    ''' <summary>
    ''' Fill the file list view control.
    ''' </summary>
    ''' <param name="Path_01"></param>
    Private Sub FillFileListView(Path_01 As String)

        Dim PathedFileName_01 As String
        Dim FileName_01 As String
        Dim oFileInfo_01 As FileInfo
        Dim lvi As ListViewItem

        Dim oShell As Shell32.Shell = CType(CreateObject("Shell.Application"), Shell32.Shell)
        Dim oFolder As Shell32.Folder = CType(oShell.NameSpace(Path_01), Shell32.Folder)

        oListView_Files.Items.Clear()

        For Each PathedFileName_01 In My.Computer.FileSystem.GetFiles(Path_01)

            oFileInfo_01 = New FileInfo(PathedFileName_01)
            Dim sizeInBytes As Long = oFileInfo_01.Length

            FileName_01 = FileName(PathedFileName_01)

            lvi = New ListViewItem(FileName_01)

            Select Case (LCase(FileExtension(PathedFileName_01)))

                Case "bmp", "gif", "jpg", "jpeg", "png"
                    lvi.SubItems.Add("Picture")
                    lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                    lvi.ForeColor = Color.DarkRed

                Case "wav", "mid", "midi", "mp3"
                    lvi.SubItems.Add("Audio")
                    lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                    lvi.SubItems.Add(oFolder.GetDetailsOf(oFolder.ParseName(FileName_01), 27)) '// (duration)
                    lvi.ForeColor = Color.DarkBlue

                Case "mov", "avi", "mpg", "mpeg", "mp4", "wmv"
                    lvi.SubItems.Add("Video")
                    lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                    lvi.SubItems.Add(oFolder.GetDetailsOf(oFolder.ParseName(FileName_01), 27)) '// (duration)
                    lvi.ForeColor = Color.DarkGreen

                Case Else
                    lvi.SubItems.Add("other")
                    lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                    lvi.ForeColor = Color.DimGray

            End Select

            oListView_Files.Items.Add(lvi)

        Next

    End Sub


    ''' <summary>
    ''' Copy the info data from the textbox to the ListView control.
    ''' </summary>
    Private Sub FillInfoListView()

        Dim PathedFileName_01 As String
        Dim FileName_Pic As String
        Dim FileName_Found As String
        Dim FileTitle_Pic As String
        Dim str_PicNum As String
        Dim oFileInfo_01 As FileInfo

        Dim Country As String
        Dim StateAbbr As String
        Dim CountyAbbr As String
        Dim City As String
        Dim Descr As String

        Dim Version As Integer

        Dim str_Line As String
        Dim str_LineRemaining As String
        Dim i_LineNum As Integer
        Dim Pos As Integer
        Dim lvi As ListViewItem


        Dim oShell As Shell32.Shell = CType(CreateObject("Shell.Application"), Shell32.Shell)
        Dim oFolder As Shell32.Folder = CType(oShell.NameSpace(m_Path_Displayed), Shell32.Folder)

        oListView_Info.Items.Clear()

        '// Read the info file version:
        str_Line = textbox_Info.Lines(1)
        If (str_Line.Length = 0) Then
            Version = 1
        Else
            Version = Convert.ToInt32(str_Line.Substring(1, 2))
        End If

        textbox_Version.Text = Version

        Select Case Version

            Case 1

                For i_LineNum = 2 To textbox_Info.Lines.Length - 2

                    str_Line = textbox_Info.Lines(i_LineNum)

                    '// Remove bracketed text from the line.
                    str_LineRemaining = Regex.Replace(str_Line, " ?\[.*?\]", "")

                    Dim match As Match = Regex.Match(str_LineRemaining, "^\d\d\d +")
                    If match.Success Then

                        str_PicNum = Strings.Left(str_LineRemaining, 3)
                        str_LineRemaining = str_LineRemaining.Substring(4)

                        FileName_Found = ""
                        For Each lvi In oListView_Files.Items
                            FileName_Pic = lvi.Text
                            FileTitle_Pic = RemoveFileExtension(FileName_Pic)
                            If (FileTitle_Pic = str_PicNum) Then
                                FileName_Found = FileName_Pic
                            End If
                        Next

                        PathedFileName_01 = NormalizePath(m_Path_Displayed) + FileName_Found

                        oFileInfo_01 = New FileInfo(PathedFileName_01)
                        Dim sizeInBytes As Long = oFileInfo_01.Length

                        lvi = New ListViewItem(FileName_Found)

                        Select Case (LCase(FileExtension(FileName_Found)))

                            Case "bmp", "gif", "jpg", "jpeg", "png"
                                lvi.SubItems.Add("Picture")
                                lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                                lvi.ForeColor = Color.DarkRed

                            Case "wav", "mid", "midi", "mp3"
                                lvi.SubItems.Add("Audio")
                                lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                                lvi.SubItems.Add(oFolder.GetDetailsOf(oFolder.ParseName(FileName_Found), 27)) '// (duration)
                                lvi.ForeColor = Color.DarkBlue

                            Case "mov", "avi", "mpg", "mpeg", "mp4", "wmv"
                                lvi.SubItems.Add("Video")
                                lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                                lvi.SubItems.Add(oFolder.GetDetailsOf(oFolder.ParseName(FileName_Found), 27)) '// (duration)
                                lvi.ForeColor = Color.DarkGreen

                            Case Else
                                lvi.SubItems.Add("other")
                                lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                                lvi.ForeColor = Color.DimGray

                        End Select

                        lvi.SubItems.Add("USA")

                        Dim match_02 As Match = Regex.Match(str_LineRemaining, "^[A-Z][A-Z] ` +")
                        StateAbbr = ""
                        If match_02.Success Then '// If we found a state abbreviation ...
                            StateAbbr = str_LineRemaining.Substring(0, 2)
                            lvi.SubItems.Add(StateAbbr)
                            str_LineRemaining = str_LineRemaining.Substring(5)
                        Else '// If we found NO state abbreviation ...
                            lvi.SubItems.Add("")
                        End If

                        Dim match_03 As Match = Regex.Match(str_LineRemaining, "^[A-Z][A-Z][A-Z] ` +")
                        If match_03.Success Then '// If we found a county abbreviation ...
                            CountyAbbr = str_LineRemaining.Substring(0, 3)
                            lvi.SubItems.Add(CountyAbbr)
                            str_LineRemaining = str_LineRemaining.Substring(6)
                        Else '// If we found NO county abbreviation ...
                            lvi.SubItems.Add("")
                        End If

                        Pos = InStr(str_LineRemaining, "`")
                        If (StateAbbr = "DC") Then
                            City = "Washington"
                            lvi.SubItems.Add(City)
                        ElseIf (Pos > 0) Then '// If we found a city name ...
                            City = str_LineRemaining.Substring(0, Pos - 2)
                            lvi.SubItems.Add(City)
                            str_LineRemaining = str_LineRemaining.Substring(Pos + 1)
                        Else '// If we found NO city name ...
                            lvi.SubItems.Add("")
                        End If

                        Descr = str_LineRemaining
                        lvi.SubItems.Add(Descr)

                        oListView_Info.Items.Add(lvi)
                    End If

                Next i_LineNum

                btn_ConvertInfoFile.Enabled = True

            Case 2

                For i_LineNum = 2 To textbox_Info.Lines.Length - 2

                    str_Line = textbox_Info.Lines(i_LineNum)

                    If (str_Line.Length > 0) Then

                        str_LineRemaining = str_Line

                        Pos = InStr(str_LineRemaining, "`")

                        If (Pos > 0) Then

                            FileName_Found = str_LineRemaining.Substring(0, Pos - 1).Trim()
                            str_LineRemaining = str_LineRemaining.Substring(Pos)

                            PathedFileName_01 = NormalizePath(m_Path_Displayed) + FileName_Found

                            oFileInfo_01 = New FileInfo(PathedFileName_01)
                            Dim sizeInBytes As Long = oFileInfo_01.Length

                            lvi = New ListViewItem(FileName_Found)

                            Select Case (LCase(FileExtension(FileName_Found)))

                                Case "bmp", "gif", "jpg", "jpeg", "png"
                                    lvi.SubItems.Add("Picture")
                                    lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                                    lvi.ForeColor = Color.DarkRed

                                Case "wav", "mid", "midi", "mp3"
                                    lvi.SubItems.Add("Audio")
                                    lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                                    lvi.SubItems.Add(oFolder.GetDetailsOf(oFolder.ParseName(FileName_Found), 27)) '// (duration)
                                    lvi.ForeColor = Color.DarkBlue

                                Case "mov", "avi", "mpg", "mpeg", "mp4", "wmv"
                                    lvi.SubItems.Add("Video")
                                    lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                                    lvi.SubItems.Add(oFolder.GetDetailsOf(oFolder.ParseName(FileName_Found), 27)) '// (duration)
                                    lvi.ForeColor = Color.DarkGreen

                                Case Else
                                    lvi.SubItems.Add("other")
                                    lvi.SubItems.Add(sizeInBytes.ToString("###,###,###,###,###"))
                                    lvi.ForeColor = Color.DimGray

                            End Select

                            Pos = InStr(str_LineRemaining, "`")

                            If (Pos > 0) Then '// If we found a country abbreviation ...

                                Country = str_LineRemaining.Substring(0, Pos - 1).Trim()
                                str_LineRemaining = str_LineRemaining.Substring(Pos)

                                lvi.SubItems.Add(Country)

                                Pos = InStr(str_LineRemaining, "`")

                                If (Pos > 0) Then '// If we found a state abbreviation ...

                                    StateAbbr = str_LineRemaining.Substring(0, Pos - 1).Trim()
                                    str_LineRemaining = str_LineRemaining.Substring(Pos)

                                    lvi.SubItems.Add(StateAbbr)

                                    Pos = InStr(str_LineRemaining, "`")

                                    If (Pos > 0) Then '// If we found a county abbreviation ...

                                        CountyAbbr = str_LineRemaining.Substring(0, Pos - 1).Trim()
                                        str_LineRemaining = str_LineRemaining.Substring(Pos)

                                        lvi.SubItems.Add(CountyAbbr)

                                        Pos = InStr(str_LineRemaining, "`")

                                        If (Pos > 0) Then '// If we found a city name ...

                                            City = str_LineRemaining.Substring(0, Pos - 1).Trim()
                                            str_LineRemaining = str_LineRemaining.Substring(Pos)

                                            lvi.SubItems.Add(City)

                                            Descr = str_LineRemaining.Trim()

                                            lvi.SubItems.Add(Descr)

                                        End If

                                    End If

                                End If

                            End If

                            oListView_Info.Items.Add(lvi)

                        End If

                    End If

                Next i_LineNum

                btn_ConvertInfoFile.Enabled = False

        End Select

    End Sub

    ''' <summary>
    ''' Creat a new info.txt file and save it.
    ''' </summary>
    Private Sub CreateNewInfoFile()

        Dim str_PathedFileName_Info As String
        Dim oFileInfo_Folder As FileInfo
        Dim str_InfoFileText As String
        Dim PhotoNum As Integer


        oFileInfo_Folder = New FileInfo(m_Path_Displayed)
        str_PathedFileName_Info = NormalizePath(m_Path_Displayed) + "info.txt"

        '// Add the first lines to the file text:
        str_InfoFileText = oFileInfo_Folder.Directory.Parent.Name + "-" + oFileInfo_Folder.Directory.Name.Substring(0, 2) + "-" + oFileInfo_Folder.Name + vbCrLf
        str_InfoFileText = str_InfoFileText + vbCrLf

        '// Add the rest of the lines to the file text:
        For PhotoNum = 1 To 999
            Dim FileTitle As String = PhotoNum.ToString("000")
            If ImageExists(FileTitle) Then
                str_InfoFileText = (str_InfoFileText + FileTitle) + " " + vbLf
            ElseIf VideoExists(FileTitle) Then
                str_InfoFileText = (str_InfoFileText + FileTitle) + " [movie] " + vbLf
            End If
        Next PhotoNum

        '// Save the new info file:
        SetFileContents(str_PathedFileName_Info, str_InfoFileText)

        '// Display the new info file:
        DisplayInfo()

    End Sub

    ''' <summary>
    ''' Creat a new info.txt file and save it.
    ''' </summary>
    Private Sub CreateNewInfoFile_V02()

        Dim PathedFileName_Info As String
        Dim FileName As String
        Dim oFileInfo_Folder As FileInfo
        Dim InfoFileText As String
        Dim PhotoNum As Integer


        oFileInfo_Folder = New FileInfo(m_Path_Displayed)
        PathedFileName_Info = NormalizePath(m_Path_Displayed) + "info.txt"

        '// Add the first lines to the file text:
        InfoFileText = oFileInfo_Folder.Directory.Parent.Name + "-" + oFileInfo_Folder.Directory.Name.Substring(0, 2) + "-" + oFileInfo_Folder.Name + vbLf
        InfoFileText = InfoFileText + "[02]" + vbLf

        '// Add the rest of the lines to the file text:
        For PhotoNum = 1 To 999
            Dim FileTitle As String = PhotoNum.ToString("000")
            FileName = FindImageOrVideo(FileTitle)
            If (FileName.Length > 0) Then
                InfoFileText = (InfoFileText + FileName) + "`USA`" + vbLf
            End If
        Next PhotoNum

        '// Save the new info file:
        SetFileContents(PathedFileName_Info, InfoFileText)

        '// Display the new info file:
        DisplayInfo()

    End Sub

    Private Sub ConvertInfoFile()

        Dim str_Info_Old As String
        Dim str_Info_New As String
        Dim Line_New As String
        Dim Lines_Old As String()

        Dim lvi As ListViewItem

        Dim frmTextBlock_01 As frm_TextBlock


        str_Info_Old = textbox_Info.Text

        Lines_Old = str_Info_Old.Split({vbLf}, StringSplitOptions.None)

        str_Info_New = ""
        str_Info_New += Lines_Old(0) + vbLf
        str_Info_New += "[02]" + vbLf

        For Each lvi In oListView_Info.Items
            Line_New = lvi.Text + "`" + lvi.SubItems(1).Text + "`" + lvi.SubItems(2).Text + "`" + lvi.SubItems(3).Text + "`" + lvi.SubItems(4).Text + "`" + lvi.SubItems(5).Text
            str_Info_New += Line_New + vbLf
        Next

        frmTextBlock_01 = New frm_TextBlock
        frmTextBlock_01.Text = "Info"
        frmTextBlock_01.textbox_01.Text = str_Info_New
        frmTextBlock_01.btn_01.Visible = True : frmTextBlock_01.btn_01.Text = "OK"
        frmTextBlock_01.btn_02.Visible = True : frmTextBlock_01.btn_02.Text = "Cancel"

        frmTextBlock_01.ShowDialog(Me)

        If (frmTextBlock_01.m_ButtonNumPressed = 1) Then '// If the user pressed OK ...
            textbox_Info.Text = frmTextBlock_01.textbox_01.Text
            FillInfoListView()
        End If

    End Sub


    ''' <summary>
    ''' Save the info.txt file to disk.
    ''' </summary>
    Private Sub SaveInfoFile()

        If (textbox_Info.Visible And Len(textbox_PathedFileName_Info.Text) > 0) Then
            SetFileContents(textbox_PathedFileName_Info.Text, textbox_Info.Text)
        End If

    End Sub

    ''' <summary>
    ''' Rename the files to "001.jpeg", "002.jpeg", "003.jpeg", etc.
    ''' </summary>
    Private Sub EnumerateFiles()

        Dim FileExtension_Old As String
        Dim FileName_Old As String
        Dim PathedFileName_Old As String

        Dim FileTitle_New As String
        Dim FileExtension_New As String
        Dim FileName_New As String

        Dim i_Consecution As Integer
        Dim i_FileNum As Integer


        i_FileNum = 0

        '// Unload the picture:
        pic_01.Load(NormalizePath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) + "Default.jpeg")
        pic_01.Refresh()

        For i_Consecution = 0 To oListView_Files.Items.Count - 1

            FileName_Old = oListView_Files.Items(i_Consecution).Text

            '// If this file has NOT been marked for deletion ...
            If Not FileName_Old.StartsWith("ZZZ", StringComparison.CurrentCultureIgnoreCase) Then

                '// If this file fits the criteria for renaming ...
                If (IsGraphicFile(FileName_Old) Or IsVideoFile(FileName_Old)) Then

                    '// Determine the file name pieces:
                    i_FileNum = i_FileNum + 1
                    FileExtension_Old = FileExtension(FileName_Old)
                    PathedFileName_Old = NormalizePath(m_Path_Displayed) + FileName_Old
                    FileTitle_New = Format$(i_FileNum, "000")
                    If (FileExtension_Old.ToLower = "jpg") Then
                        FileExtension_New = "jpeg"
                    Else
                        FileExtension_New = FileExtension_Old
                    End If
                    FileName_New = FileTitle_New + "." + FileExtension_New

                    '// Rename the file if necessary:
                    If (FileName_New <> FileName_Old) Then
                        My.Computer.FileSystem.RenameFile(PathedFileName_Old, FileName_New)
                    End If

                End If
                '// ... if this file fits the criteria for renaming.

            End If
            '// ... if this file has not been marked for deletion.

        Next i_Consecution

        FillFileListView(m_Path_Displayed)

    End Sub

    ''' <summary>
    ''' Blank out the ListView control on the File Properties tab.
    ''' </summary>
    Private Sub ClearFileProperties()

        oListView_FileProperties.Items.Clear()

    End Sub

    ''' <summary>
    ''' Blank out the ListView control on the Exif Data tab.
    ''' </summary>
    Private Sub ClearExifData()

        oListView_ExifData.Items.Clear()

    End Sub

    ''' <summary>
    ''' Read the Exif data for the selected picture and display it on the Exif ListView control.
    ''' </summary>
    ''' <param name="PathedFileName_Selected"></param>
    Private Sub DisplayExifData(PathedFileName_Selected As String)

        Dim EW As New ExifWorks(PathedFileName_Selected)
        Dim lvi As ListViewItem


        oListView_ExifData.Items.Clear()


        lvi = New ListViewItem("Title")
        lvi.SubItems.Add(EW.Title)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Description")
        lvi.SubItems.Add(EW.Description)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Copyright")
        lvi.SubItems.Add(EW.Copyright)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("User Comment")
        lvi.SubItems.Add(EW.UserComment)
        lvi.BackColor = SystemColors.Window '(editable)
        oListView_ExifData.Items.Add(lvi)

        '// Add a blank row:
        lvi = New ListViewItem("")
        oListView_ExifData.Items.Add(lvi)


        lvi = New ListViewItem("Dimensions")
        lvi.SubItems.Add(EW.Width.ToString() + " x " + EW.Height.ToString() + " px")
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Resolution")
        lvi.SubItems.Add(EW.ResolutionX.ToString() + " x " + EW.ResolutionY.ToString() + " dpi")
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Orientation")
        lvi.SubItems.Add([Enum].GetName(GetType(ExifWorks.Orientations), EW.Orientation))
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Equipment Maker")
        lvi.SubItems.Add(EW.EquipmentMaker)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Equipment Model")
        lvi.SubItems.Add(EW.EquipmentModel)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Software Used")
        lvi.SubItems.Add(EW.Software)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Original Date/Time")
        lvi.SubItems.Add(EW.DateTimeOriginal.ToString())
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Date/Time Digitized")
        lvi.SubItems.Add(EW.DateTimeDigitized.ToString())
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Date/Time LastModified")
        lvi.SubItems.Add(EW.DateTimeLastModified.ToString())
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Aperture")
        lvi.SubItems.Add(EW.Aperture)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Artist")
        lvi.SubItems.Add(EW.Artist)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Encoding")
        lvi.SubItems.Add(EW.Encoding.ToString)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Exposure metering mode")
        lvi.SubItems.Add(EW.ExposureMeteringMode.ToString)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Exposure program")
        lvi.SubItems.Add(EW.ExposureProgram.ToString)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Exposure time")
        lvi.SubItems.Add(EW.ExposureTime)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Focal length")
        lvi.SubItems.Add(EW.FocalLength)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Flash")
        lvi.SubItems.Add(EW.FlashMode.ToString())
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("ISO Sensitivity")
        lvi.SubItems.Add(EW.ISO.ToString())
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Light Source")
        lvi.SubItems.Add(EW.LightSource.ToString())
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Subject Distance")
        lvi.SubItems.Add(EW.SubjectDistance.ToString("N2") + " m")
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        '// Add a blank row:
        lvi = New ListViewItem("")
        oListView_ExifData.Items.Add(lvi)


        '// Add the GPS header:
        lvi = New ListViewItem("GPS:")
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Latitude in DMS")
        lvi.SubItems.Add(EW.str_Latitude)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Longitude in DMS")
        lvi.SubItems.Add(EW.str_Longitude)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Latitude in decimal degrees")
        lvi.SubItems.Add(EW.n_Latitude)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Longitude in decimal degrees")
        lvi.SubItems.Add(EW.n_Longitude)
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        lvi = New ListViewItem("Altitude")
        lvi.SubItems.Add(EW.Altitude.ToString())
        lvi.BackColor = Color.LightGray '(read-only)
        oListView_ExifData.Items.Add(lvi)

        '// !! Important !! //
        EW.Dispose()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="PathedFileName_Selected"></param>
    Private Sub DisplayFileProperties(PathedFileName_Selected As String)

        Dim Path_01 As String = IO.Path.GetDirectoryName(Path(PathedFileName_Selected))
        Dim FileName_01 As String = IO.Path.GetFileName(FileName(PathedFileName_Selected))

        Dim oShell As Shell32.Shell = CType(CreateObject("Shell.Application"), Shell32.Shell)
        Dim oFolder As Shell32.Folder = CType(oShell.NameSpace(Path_01), Shell32.Folder)

        Dim lvi As ListViewItem
        Dim ItemNum As Integer

        oListView_FileProperties.Items.Clear()

        For ItemNum = 0 To 34
            lvi = New ListViewItem(oFolder.GetDetailsOf(vbNull, ItemNum)) '// (property name)
            lvi.SubItems.Add(ItemNum) '// (property number)
            lvi.SubItems.Add(oFolder.GetDetailsOf(oFolder.ParseName(FileName_01), ItemNum)) '// (property value)
            oListView_FileProperties.Items.Add(lvi)
        Next ItemNum

    End Sub

    ''' <summary>
    ''' Fill the list view control on the Keys tab.
    ''' </summary>
    Private Sub FillKeysListView()

        Dim lvi As ListViewItem

        lvi = New ListViewItem("Del")
        lvi.SubItems.Add("Delete the selected file")
        lvi.Font = New Font(lvi.Font, FontStyle.Regular)
        oListView_Keys.Items.Add(lvi)

        lvi = New ListViewItem("Shift+Del")
        lvi.SubItems.Add("Permanently delete the selected file")
        lvi.Font = New Font(lvi.Font, FontStyle.Regular)
        oListView_Keys.Items.Add(lvi)

        lvi = New ListViewItem("F2")
        lvi.SubItems.Add("Rename the selected file")
        lvi.Font = New Font(lvi.Font, FontStyle.Regular)
        oListView_Keys.Items.Add(lvi)

        lvi = New ListViewItem("F11")
        lvi.SubItems.Add("Rotate Left")
        lvi.Font = New Font(lvi.Font, FontStyle.Regular)
        oListView_Keys.Items.Add(lvi)

        lvi = New ListViewItem("F12")
        lvi.SubItems.Add("Rotate Right")
        lvi.Font = New Font(lvi.Font, FontStyle.Regular)
        oListView_Keys.Items.Add(lvi)

        lvi = New ListViewItem("Ctrl+E")
        lvi.SubItems.Add("Echo current info line")
        lvi.Font = New Font(lvi.Font, FontStyle.Regular)
        oListView_Keys.Items.Add(lvi)

    End Sub

    ''' <summary>
    ''' Move the caret in the Info text box to a specific line.
    ''' </summary>
    ''' <param name="LineNum"></param>
    Private Sub GoToLine(ByVal LineNum As Integer)

        Dim txt As String
        Dim i As Integer
        Dim pos As Integer

        '// Find the line's position:
        txt = textbox_Info.Text
        pos = 1
        For i = 2 To LineNum
            pos = InStr(pos, txt, vbLf) '// Go to the next LF.
            If pos = 0 Then
                pos = 1
                Exit For
            End If
            pos = pos + 1
        Next i

        '// Go to this position:
        textbox_Info.SelectionStart = Len(txt)
        textbox_Info.SelectionStart = pos - 1
        textbox_Info.SelectionLength = 0
        textbox_Info.ScrollToCaret()

    End Sub

    ''' <summary>
    ''' Look for the specified image file in the folder browser
    ''' </summary>
    ''' <param name="FileTitle">the file title (without the extension), such as "002"</param>
    ''' <returns>true if the file exists in the folder browser with the "jpeg" or "jpeg" extension</returns>
    Private Function ImageExists(FileTitle As String) As Boolean

        Dim FileName As String
        Dim i_Consecution As Integer

        For i_Consecution = 0 To oListView_Files.Items.Count - 1
            FileName = oListView_Files.Items(i_Consecution).Text
            If FileName = FileTitle + Convert.ToString(".jpeg") OrElse FileName = FileTitle + Convert.ToString(".jpg") Then
                Return True
            End If
        Next

        Return False

    End Function

    ''' <summary>
    ''' Look for the specified video file in the folder browser
    ''' </summary>
    ''' <param name="FileTitle">the file title (without the extension), such as "002"</param>
    ''' <returns>true if the file exists in the folder browser with the "avi", "mov", "mp4", or "wmv" extension</returns>
    Private Function VideoExists(FileTitle As String) As Boolean

        Dim FileName As String
        Dim i_Consecution As Integer

        For i_Consecution = 0 To oListView_Files.Items.Count - 1
            FileName = oListView_Files.Items(i_Consecution).Text
            If FileName = FileTitle + Convert.ToString(".avi") OrElse FileName = FileTitle + Convert.ToString(".mov") OrElse FileName = FileTitle + Convert.ToString(".mp4") OrElse FileName = FileTitle + Convert.ToString(".wmv") Then
                Return True
            End If
        Next

        Return False

    End Function

    ''' <summary>
    ''' Look for the specified image or video file in the folder browser
    ''' </summary>
    ''' <param name="FileTitle">the file title (without the extension), such as "002"</param>
    ''' <returns>the file name</returns>
    Private Function FindImageOrVideo(FileTitle As String) As String

        Dim FileName As String
        Dim i_Consecution As Integer

        For i_Consecution = 0 To oListView_Files.Items.Count - 1
            FileName = oListView_Files.Items(i_Consecution).Text
            If FileName = FileTitle + Convert.ToString(".jpeg") OrElse FileName = FileTitle + Convert.ToString(".jpg") OrElse FileName = FileTitle + Convert.ToString(".avi") OrElse FileName = FileTitle + Convert.ToString(".mov") OrElse FileName = FileTitle + Convert.ToString(".mp3") OrElse FileName = FileTitle + Convert.ToString(".mp4") OrElse FileName = FileTitle + Convert.ToString(".wmv") Then
                Return FileName
            End If
        Next

        Return ""

    End Function

#End Region

End Class
