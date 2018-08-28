<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PhotoOrbit
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PhotoOrbit))
        Me.btn_Enumerate = New System.Windows.Forms.Button()
        Me.cmdbtn_RotateRight = New System.Windows.Forms.Button()
        Me.cmdbtn_RotateLeft = New System.Windows.Forms.Button()
        Me.oDirListBox_01 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.pic_01 = New System.Windows.Forms.PictureBox()
        Me.oSplitContainer_01 = New System.Windows.Forms.SplitContainer()
        Me.oSplitContainer_Left = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Folder_Videos = New System.Windows.Forms.Button()
        Me.btn_Now = New System.Windows.Forms.Button()
        Me.btn_Folder_Pictures = New System.Windows.Forms.Button()
        Me.btn_Up = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.oListView_Files = New System.Windows.Forms.ListView()
        Me.column_FileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_Size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_Duration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkbtn_ShowDetails = New System.Windows.Forms.CheckBox()
        Me.oSplitContainer_Right = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.oSplitContainer_Info = New System.Windows.Forms.SplitContainer()
        Me.btn_ConvertInfoFile = New System.Windows.Forms.Button()
        Me.textbox_Version = New System.Windows.Forms.TextBox()
        Me.textbox_PathedFileName_Info = New System.Windows.Forms.TextBox()
        Me.btn_CreateInfoFile = New System.Windows.Forms.Button()
        Me.oPanel_Info = New System.Windows.Forms.Panel()
        Me.textbox_Info = New System.Windows.Forms.RichTextBox()
        Me.oListView_Info = New System.Windows.Forms.ListView()
        Me.Num = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Duration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Country = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.State = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.County = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.City = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.textbox_PathedFileName_Display = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mplayer_01 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.m_cmdbtn_GatherSubFolderFiles = New System.Windows.Forms.Button()
        Me.lbl_textbox_TextToCopy_01 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_01 = New System.Windows.Forms.TextBox()
        Me.textbox_CopyLineCount_01 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_01 = New System.Windows.Forms.Label()
        Me.btn_CopyDown_01 = New System.Windows.Forms.Button()
        Me.btn_CopyDown_02 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_02 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_02 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_02 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_02 = New System.Windows.Forms.Label()
        Me.btn_CopyDown_03 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_03 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_03 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_03 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_03 = New System.Windows.Forms.Label()
        Me.btn_CopyDown_04 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_04 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_04 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_04 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_04 = New System.Windows.Forms.Label()
        Me.btn_CopyDown_05 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_05 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_05 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_05 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_05 = New System.Windows.Forms.Label()
        Me.btn_CopyDown_06 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_06 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_06 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_06 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_06 = New System.Windows.Forms.Label()
        Me.cmdbtn_BackupFile = New System.Windows.Forms.Button()
        Me.btn_Replace = New System.Windows.Forms.Button()
        Me.oSplitContainer_Main = New System.Windows.Forms.SplitContainer()
        Me.oTabControl_01 = New System.Windows.Forms.TabControl()
        Me.oTabPage_FileProperties = New System.Windows.Forms.TabPage()
        Me.oListView_FileProperties = New System.Windows.Forms.ListView()
        Me.column_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.oTabPage_ExifData = New System.Windows.Forms.TabPage()
        Me.oListView_ExifData = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.oTabPage_Snippets = New System.Windows.Forms.TabPage()
        Me.btn_Copy_06 = New System.Windows.Forms.Button()
        Me.btn_Copy_03 = New System.Windows.Forms.Button()
        Me.btn_Copy_01 = New System.Windows.Forms.Button()
        Me.btn_Copy_04 = New System.Windows.Forms.Button()
        Me.btn_Copy_05 = New System.Windows.Forms.Button()
        Me.btn_Copy_02 = New System.Windows.Forms.Button()
        Me.oTabPage_SearchResults = New System.Windows.Forms.TabPage()
        Me.oListView_SearchResults = New System.Windows.Forms.ListView()
        Me.column_Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_Line = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.oTabPage_Keys = New System.Windows.Forms.TabPage()
        Me.oListView_Keys = New System.Windows.Forms.ListView()
        Me.column_Key = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_Action = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbo_Path = New System.Windows.Forms.ComboBox()
        Me.btn_FindInfo = New System.Windows.Forms.Button()
        Me.btn_Go = New System.Windows.Forms.Button()
        Me.oToolTip_01 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_Map = New System.Windows.Forms.Button()
        Me.btn_NewVideoProject = New System.Windows.Forms.Button()
        CType(Me.pic_01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oSplitContainer_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_01.Panel1.SuspendLayout()
        Me.oSplitContainer_01.Panel2.SuspendLayout()
        Me.oSplitContainer_01.SuspendLayout()
        CType(Me.oSplitContainer_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Left.Panel1.SuspendLayout()
        Me.oSplitContainer_Left.Panel2.SuspendLayout()
        Me.oSplitContainer_Left.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.oSplitContainer_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Right.Panel1.SuspendLayout()
        Me.oSplitContainer_Right.Panel2.SuspendLayout()
        Me.oSplitContainer_Right.SuspendLayout()
        CType(Me.oSplitContainer_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Info.Panel1.SuspendLayout()
        Me.oSplitContainer_Info.Panel2.SuspendLayout()
        Me.oSplitContainer_Info.SuspendLayout()
        Me.oPanel_Info.SuspendLayout()
        CType(Me.mplayer_01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oSplitContainer_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Main.Panel1.SuspendLayout()
        Me.oSplitContainer_Main.Panel2.SuspendLayout()
        Me.oSplitContainer_Main.SuspendLayout()
        Me.oTabControl_01.SuspendLayout()
        Me.oTabPage_FileProperties.SuspendLayout()
        Me.oTabPage_ExifData.SuspendLayout()
        Me.oTabPage_Snippets.SuspendLayout()
        Me.oTabPage_SearchResults.SuspendLayout()
        Me.oTabPage_Keys.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Enumerate
        '
        Me.btn_Enumerate.Location = New System.Drawing.Point(276, 7)
        Me.btn_Enumerate.Name = "btn_Enumerate"
        Me.btn_Enumerate.Size = New System.Drawing.Size(70, 25)
        Me.btn_Enumerate.TabIndex = 10
        Me.btn_Enumerate.Text = "Enumerate"
        Me.btn_Enumerate.UseVisualStyleBackColor = True
        '
        'cmdbtn_RotateRight
        '
        Me.cmdbtn_RotateRight.Location = New System.Drawing.Point(140, 7)
        Me.cmdbtn_RotateRight.Name = "cmdbtn_RotateRight"
        Me.cmdbtn_RotateRight.Size = New System.Drawing.Size(130, 25)
        Me.cmdbtn_RotateRight.TabIndex = 9
        Me.cmdbtn_RotateRight.Text = "Rotate Right (F12)"
        Me.cmdbtn_RotateRight.UseVisualStyleBackColor = True
        '
        'cmdbtn_RotateLeft
        '
        Me.cmdbtn_RotateLeft.Location = New System.Drawing.Point(4, 7)
        Me.cmdbtn_RotateLeft.Name = "cmdbtn_RotateLeft"
        Me.cmdbtn_RotateLeft.Size = New System.Drawing.Size(130, 25)
        Me.cmdbtn_RotateLeft.TabIndex = 8
        Me.cmdbtn_RotateLeft.Text = "Rotate Left (F11)"
        Me.cmdbtn_RotateLeft.UseVisualStyleBackColor = True
        '
        'oDirListBox_01
        '
        Me.oDirListBox_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oDirListBox_01.FormattingEnabled = True
        Me.oDirListBox_01.IntegralHeight = False
        Me.oDirListBox_01.Location = New System.Drawing.Point(0, 31)
        Me.oDirListBox_01.Name = "oDirListBox_01"
        Me.oDirListBox_01.Size = New System.Drawing.Size(185, 247)
        Me.oDirListBox_01.TabIndex = 6
        '
        'pic_01
        '
        Me.pic_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_01.Location = New System.Drawing.Point(1, 57)
        Me.pic_01.Name = "pic_01"
        Me.pic_01.Size = New System.Drawing.Size(360, 286)
        Me.pic_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_01.TabIndex = 9
        Me.pic_01.TabStop = False
        '
        'oSplitContainer_01
        '
        Me.oSplitContainer_01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oSplitContainer_01.Location = New System.Drawing.Point(0, 0)
        Me.oSplitContainer_01.Name = "oSplitContainer_01"
        '
        'oSplitContainer_01.Panel1
        '
        Me.oSplitContainer_01.Panel1.Controls.Add(Me.oSplitContainer_Left)
        '
        'oSplitContainer_01.Panel2
        '
        Me.oSplitContainer_01.Panel2.Controls.Add(Me.oSplitContainer_Right)
        Me.oSplitContainer_01.Size = New System.Drawing.Size(1134, 341)
        Me.oSplitContainer_01.SplitterDistance = 489
        Me.oSplitContainer_01.TabIndex = 12
        '
        'oSplitContainer_Left
        '
        Me.oSplitContainer_Left.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oSplitContainer_Left.Location = New System.Drawing.Point(0, 0)
        Me.oSplitContainer_Left.Name = "oSplitContainer_Left"
        '
        'oSplitContainer_Left.Panel1
        '
        Me.oSplitContainer_Left.Panel1.Controls.Add(Me.Panel1)
        Me.oSplitContainer_Left.Panel1.Controls.Add(Me.Label4)
        Me.oSplitContainer_Left.Panel1.Controls.Add(Me.oDirListBox_01)
        '
        'oSplitContainer_Left.Panel2
        '
        Me.oSplitContainer_Left.Panel2.Controls.Add(Me.Label3)
        Me.oSplitContainer_Left.Panel2.Controls.Add(Me.oListView_Files)
        Me.oSplitContainer_Left.Panel2.Controls.Add(Me.chkbtn_ShowDetails)
        Me.oSplitContainer_Left.Size = New System.Drawing.Size(489, 341)
        Me.oSplitContainer_Left.SplitterDistance = 186
        Me.oSplitContainer_Left.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Folder_Videos)
        Me.Panel1.Controls.Add(Me.btn_Now)
        Me.Panel1.Controls.Add(Me.btn_Folder_Pictures)
        Me.Panel1.Controls.Add(Me.btn_Up)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 281)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 60)
        Me.Panel1.TabIndex = 19
        '
        'btn_Folder_Videos
        '
        Me.btn_Folder_Videos.Location = New System.Drawing.Point(83, 3)
        Me.btn_Folder_Videos.Name = "btn_Folder_Videos"
        Me.btn_Folder_Videos.Size = New System.Drawing.Size(103, 25)
        Me.btn_Folder_Videos.TabIndex = 18
        Me.btn_Folder_Videos.Text = "Videos"
        Me.oToolTip_01.SetToolTip(Me.btn_Folder_Videos, "Go to the MyVideos folder")
        Me.btn_Folder_Videos.UseVisualStyleBackColor = True
        '
        'btn_Now
        '
        Me.btn_Now.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Now.Location = New System.Drawing.Point(60, 32)
        Me.btn_Now.Name = "btn_Now"
        Me.btn_Now.Size = New System.Drawing.Size(126, 25)
        Me.btn_Now.TabIndex = 7
        Me.btn_Now.Text = "This Month"
        Me.oToolTip_01.SetToolTip(Me.btn_Now, "Go to this month's folder")
        Me.btn_Now.UseVisualStyleBackColor = True
        '
        'btn_Folder_Pictures
        '
        Me.btn_Folder_Pictures.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btn_Folder_Pictures.Location = New System.Drawing.Point(0, 3)
        Me.btn_Folder_Pictures.Name = "btn_Folder_Pictures"
        Me.btn_Folder_Pictures.Size = New System.Drawing.Size(77, 25)
        Me.btn_Folder_Pictures.TabIndex = 17
        Me.btn_Folder_Pictures.Text = "Pictures"
        Me.oToolTip_01.SetToolTip(Me.btn_Folder_Pictures, "Go to the MyPictures folder")
        Me.btn_Folder_Pictures.UseVisualStyleBackColor = True
        '
        'btn_Up
        '
        Me.btn_Up.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Up.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_Up.Location = New System.Drawing.Point(0, 32)
        Me.btn_Up.Name = "btn_Up"
        Me.btn_Up.Size = New System.Drawing.Size(53, 25)
        Me.btn_Up.TabIndex = 8
        Me.btn_Up.Text = "ã"
        Me.oToolTip_01.SetToolTip(Me.btn_Up, "Go up one folder")
        Me.btn_Up.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Folder Section:"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "File Section:"
        '
        'oListView_Files
        '
        Me.oListView_Files.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oListView_Files.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_FileName, Me.column_Category, Me.column_Size, Me.column_Duration})
        Me.oListView_Files.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oListView_Files.FullRowSelect = True
        Me.oListView_Files.GridLines = True
        Me.oListView_Files.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.oListView_Files.Location = New System.Drawing.Point(0, 30)
        Me.oListView_Files.MultiSelect = False
        Me.oListView_Files.Name = "oListView_Files"
        Me.oListView_Files.Size = New System.Drawing.Size(298, 280)
        Me.oListView_Files.TabIndex = 10
        Me.oListView_Files.UseCompatibleStateImageBehavior = False
        Me.oListView_Files.View = System.Windows.Forms.View.Details
        '
        'column_FileName
        '
        Me.column_FileName.Text = "File name"
        Me.column_FileName.Width = 140
        '
        'column_Category
        '
        Me.column_Category.Text = "Category"
        '
        'column_Size
        '
        Me.column_Size.Text = "Size in Bytes"
        Me.column_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.column_Size.Width = 100
        '
        'column_Duration
        '
        Me.column_Duration.Text = "Duration"
        '
        'chkbtn_ShowDetails
        '
        Me.chkbtn_ShowDetails.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbtn_ShowDetails.Checked = True
        Me.chkbtn_ShowDetails.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbtn_ShowDetails.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkbtn_ShowDetails.Location = New System.Drawing.Point(0, 316)
        Me.chkbtn_ShowDetails.Name = "chkbtn_ShowDetails"
        Me.chkbtn_ShowDetails.Size = New System.Drawing.Size(299, 25)
        Me.chkbtn_ShowDetails.TabIndex = 8
        Me.chkbtn_ShowDetails.Text = "Show Details"
        Me.chkbtn_ShowDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkbtn_ShowDetails.UseVisualStyleBackColor = True
        '
        'oSplitContainer_Right
        '
        Me.oSplitContainer_Right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oSplitContainer_Right.Location = New System.Drawing.Point(0, 0)
        Me.oSplitContainer_Right.Name = "oSplitContainer_Right"
        '
        'oSplitContainer_Right.Panel1
        '
        Me.oSplitContainer_Right.Panel1.Controls.Add(Me.Label2)
        Me.oSplitContainer_Right.Panel1.Controls.Add(Me.oSplitContainer_Info)
        '
        'oSplitContainer_Right.Panel2
        '
        Me.oSplitContainer_Right.Panel2.Controls.Add(Me.textbox_PathedFileName_Display)
        Me.oSplitContainer_Right.Panel2.Controls.Add(Me.Label1)
        Me.oSplitContainer_Right.Panel2.Controls.Add(Me.mplayer_01)
        Me.oSplitContainer_Right.Panel2.Controls.Add(Me.pic_01)
        Me.oSplitContainer_Right.Size = New System.Drawing.Size(641, 341)
        Me.oSplitContainer_Right.SplitterDistance = 277
        Me.oSplitContainer_Right.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Info Section:"
        '
        'oSplitContainer_Info
        '
        Me.oSplitContainer_Info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oSplitContainer_Info.Location = New System.Drawing.Point(0, 29)
        Me.oSplitContainer_Info.Name = "oSplitContainer_Info"
        Me.oSplitContainer_Info.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'oSplitContainer_Info.Panel1
        '
        Me.oSplitContainer_Info.Panel1.Controls.Add(Me.btn_ConvertInfoFile)
        Me.oSplitContainer_Info.Panel1.Controls.Add(Me.textbox_Version)
        Me.oSplitContainer_Info.Panel1.Controls.Add(Me.textbox_PathedFileName_Info)
        Me.oSplitContainer_Info.Panel1.Controls.Add(Me.btn_CreateInfoFile)
        Me.oSplitContainer_Info.Panel1.Controls.Add(Me.oPanel_Info)
        '
        'oSplitContainer_Info.Panel2
        '
        Me.oSplitContainer_Info.Panel2.Controls.Add(Me.oListView_Info)
        Me.oSplitContainer_Info.Size = New System.Drawing.Size(278, 314)
        Me.oSplitContainer_Info.SplitterDistance = 144
        Me.oSplitContainer_Info.TabIndex = 14
        '
        'btn_ConvertInfoFile
        '
        Me.btn_ConvertInfoFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ConvertInfoFile.Enabled = False
        Me.btn_ConvertInfoFile.Location = New System.Drawing.Point(202, 0)
        Me.btn_ConvertInfoFile.Name = "btn_ConvertInfoFile"
        Me.btn_ConvertInfoFile.Size = New System.Drawing.Size(75, 23)
        Me.btn_ConvertInfoFile.TabIndex = 48
        Me.btn_ConvertInfoFile.Text = "Convert"
        Me.btn_ConvertInfoFile.UseVisualStyleBackColor = True
        '
        'textbox_Version
        '
        Me.textbox_Version.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_Version.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox_Version.Location = New System.Drawing.Point(229, 28)
        Me.textbox_Version.Multiline = True
        Me.textbox_Version.Name = "textbox_Version"
        Me.textbox_Version.ReadOnly = True
        Me.textbox_Version.Size = New System.Drawing.Size(46, 28)
        Me.textbox_Version.TabIndex = 47
        '
        'textbox_PathedFileName_Info
        '
        Me.textbox_PathedFileName_Info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_PathedFileName_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox_PathedFileName_Info.Location = New System.Drawing.Point(0, 28)
        Me.textbox_PathedFileName_Info.Multiline = True
        Me.textbox_PathedFileName_Info.Name = "textbox_PathedFileName_Info"
        Me.textbox_PathedFileName_Info.ReadOnly = True
        Me.textbox_PathedFileName_Info.Size = New System.Drawing.Size(223, 28)
        Me.textbox_PathedFileName_Info.TabIndex = 46
        '
        'btn_CreateInfoFile
        '
        Me.btn_CreateInfoFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CreateInfoFile.Enabled = False
        Me.btn_CreateInfoFile.Location = New System.Drawing.Point(0, 0)
        Me.btn_CreateInfoFile.Name = "btn_CreateInfoFile"
        Me.btn_CreateInfoFile.Size = New System.Drawing.Size(196, 23)
        Me.btn_CreateInfoFile.TabIndex = 13
        Me.btn_CreateInfoFile.Text = "Create Info File"
        Me.btn_CreateInfoFile.UseVisualStyleBackColor = True
        '
        'oPanel_Info
        '
        Me.oPanel_Info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oPanel_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.oPanel_Info.Controls.Add(Me.textbox_Info)
        Me.oPanel_Info.Location = New System.Drawing.Point(1, 62)
        Me.oPanel_Info.Name = "oPanel_Info"
        Me.oPanel_Info.Size = New System.Drawing.Size(273, 79)
        Me.oPanel_Info.TabIndex = 9
        '
        'textbox_Info
        '
        Me.textbox_Info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textbox_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textbox_Info.Location = New System.Drawing.Point(0, 0)
        Me.textbox_Info.Name = "textbox_Info"
        Me.textbox_Info.Size = New System.Drawing.Size(271, 77)
        Me.textbox_Info.TabIndex = 0
        Me.textbox_Info.Text = ""
        Me.textbox_Info.WordWrap = False
        '
        'oListView_Info
        '
        Me.oListView_Info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oListView_Info.BackColor = System.Drawing.SystemColors.Window
        Me.oListView_Info.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Num, Me.Category, Me.Size, Me.Duration, Me.Country, Me.State, Me.County, Me.City, Me.Descr})
        Me.oListView_Info.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oListView_Info.FullRowSelect = True
        Me.oListView_Info.GridLines = True
        Me.oListView_Info.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.oListView_Info.Location = New System.Drawing.Point(0, 3)
        Me.oListView_Info.MultiSelect = False
        Me.oListView_Info.Name = "oListView_Info"
        Me.oListView_Info.Size = New System.Drawing.Size(274, 158)
        Me.oListView_Info.TabIndex = 13
        Me.oListView_Info.UseCompatibleStateImageBehavior = False
        Me.oListView_Info.View = System.Windows.Forms.View.Details
        '
        'Num
        '
        Me.Num.Text = "#"
        '
        'Category
        '
        Me.Category.Text = "Category"
        '
        'Size
        '
        Me.Size.Text = "Size"
        '
        'Duration
        '
        Me.Duration.Text = "Duration"
        '
        'Country
        '
        Me.Country.Text = "Country"
        '
        'State
        '
        Me.State.Text = "State"
        Me.State.Width = 40
        '
        'County
        '
        Me.County.Text = "County"
        '
        'City
        '
        Me.City.Text = "City"
        Me.City.Width = 150
        '
        'Descr
        '
        Me.Descr.Text = "Description"
        Me.Descr.Width = 500
        '
        'textbox_PathedFileName_Display
        '
        Me.textbox_PathedFileName_Display.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_PathedFileName_Display.BackColor = System.Drawing.SystemColors.Control
        Me.textbox_PathedFileName_Display.Location = New System.Drawing.Point(2, 29)
        Me.textbox_PathedFileName_Display.Name = "textbox_PathedFileName_Display"
        Me.textbox_PathedFileName_Display.Size = New System.Drawing.Size(359, 22)
        Me.textbox_PathedFileName_Display.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Display Section:"
        '
        'mplayer_01
        '
        Me.mplayer_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mplayer_01.Enabled = True
        Me.mplayer_01.Location = New System.Drawing.Point(1, 57)
        Me.mplayer_01.Name = "mplayer_01"
        Me.mplayer_01.OcxState = CType(resources.GetObject("mplayer_01.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mplayer_01.Size = New System.Drawing.Size(360, 286)
        Me.mplayer_01.TabIndex = 10
        '
        'm_cmdbtn_GatherSubFolderFiles
        '
        Me.m_cmdbtn_GatherSubFolderFiles.Location = New System.Drawing.Point(352, 7)
        Me.m_cmdbtn_GatherSubFolderFiles.Name = "m_cmdbtn_GatherSubFolderFiles"
        Me.m_cmdbtn_GatherSubFolderFiles.Size = New System.Drawing.Size(70, 25)
        Me.m_cmdbtn_GatherSubFolderFiles.TabIndex = 14
        Me.m_cmdbtn_GatherSubFolderFiles.Text = "Gather"
        Me.m_cmdbtn_GatherSubFolderFiles.UseVisualStyleBackColor = True
        '
        'lbl_textbox_TextToCopy_01
        '
        Me.lbl_textbox_TextToCopy_01.AutoSize = True
        Me.lbl_textbox_TextToCopy_01.Enabled = False
        Me.lbl_textbox_TextToCopy_01.Location = New System.Drawing.Point(10, 9)
        Me.lbl_textbox_TextToCopy_01.Name = "lbl_textbox_TextToCopy_01"
        Me.lbl_textbox_TextToCopy_01.Size = New System.Drawing.Size(26, 13)
        Me.lbl_textbox_TextToCopy_01.TabIndex = 15
        Me.lbl_textbox_TextToCopy_01.Text = "Text"
        '
        'textbox_TextToCopy_01
        '
        Me.textbox_TextToCopy_01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_01.Enabled = False
        Me.textbox_TextToCopy_01.Location = New System.Drawing.Point(58, 6)
        Me.textbox_TextToCopy_01.Name = "textbox_TextToCopy_01"
        Me.textbox_TextToCopy_01.Size = New System.Drawing.Size(797, 22)
        Me.textbox_TextToCopy_01.TabIndex = 16
        '
        'textbox_CopyLineCount_01
        '
        Me.textbox_CopyLineCount_01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_01.Enabled = False
        Me.textbox_CopyLineCount_01.Location = New System.Drawing.Point(993, 6)
        Me.textbox_CopyLineCount_01.Name = "textbox_CopyLineCount_01"
        Me.textbox_CopyLineCount_01.Size = New System.Drawing.Size(62, 22)
        Me.textbox_CopyLineCount_01.TabIndex = 18
        '
        'lbl_textbox_CopyLineCount_01
        '
        Me.lbl_textbox_CopyLineCount_01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_01.AutoSize = True
        Me.lbl_textbox_CopyLineCount_01.Enabled = False
        Me.lbl_textbox_CopyLineCount_01.Location = New System.Drawing.Point(926, 9)
        Me.lbl_textbox_CopyLineCount_01.Name = "lbl_textbox_CopyLineCount_01"
        Me.lbl_textbox_CopyLineCount_01.Size = New System.Drawing.Size(61, 13)
        Me.lbl_textbox_CopyLineCount_01.TabIndex = 17
        Me.lbl_textbox_CopyLineCount_01.Text = "Line count"
        '
        'btn_CopyDown_01
        '
        Me.btn_CopyDown_01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CopyDown_01.Enabled = False
        Me.btn_CopyDown_01.Location = New System.Drawing.Point(1061, 4)
        Me.btn_CopyDown_01.Name = "btn_CopyDown_01"
        Me.btn_CopyDown_01.Size = New System.Drawing.Size(59, 26)
        Me.btn_CopyDown_01.TabIndex = 19
        Me.btn_CopyDown_01.Text = "Copy ↓"
        Me.btn_CopyDown_01.UseVisualStyleBackColor = True
        '
        'btn_CopyDown_02
        '
        Me.btn_CopyDown_02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CopyDown_02.Enabled = False
        Me.btn_CopyDown_02.Location = New System.Drawing.Point(1061, 32)
        Me.btn_CopyDown_02.Name = "btn_CopyDown_02"
        Me.btn_CopyDown_02.Size = New System.Drawing.Size(59, 26)
        Me.btn_CopyDown_02.TabIndex = 24
        Me.btn_CopyDown_02.Text = "Copy ↓"
        Me.btn_CopyDown_02.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_02
        '
        Me.textbox_CopyLineCount_02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_02.Enabled = False
        Me.textbox_CopyLineCount_02.Location = New System.Drawing.Point(993, 34)
        Me.textbox_CopyLineCount_02.Name = "textbox_CopyLineCount_02"
        Me.textbox_CopyLineCount_02.Size = New System.Drawing.Size(62, 22)
        Me.textbox_CopyLineCount_02.TabIndex = 23
        '
        'lbl_textbox_CopyLineCount_02
        '
        Me.lbl_textbox_CopyLineCount_02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_02.AutoSize = True
        Me.lbl_textbox_CopyLineCount_02.Enabled = False
        Me.lbl_textbox_CopyLineCount_02.Location = New System.Drawing.Point(926, 37)
        Me.lbl_textbox_CopyLineCount_02.Name = "lbl_textbox_CopyLineCount_02"
        Me.lbl_textbox_CopyLineCount_02.Size = New System.Drawing.Size(61, 13)
        Me.lbl_textbox_CopyLineCount_02.TabIndex = 22
        Me.lbl_textbox_CopyLineCount_02.Text = "Line count"
        '
        'textbox_TextToCopy_02
        '
        Me.textbox_TextToCopy_02.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_02.Enabled = False
        Me.textbox_TextToCopy_02.Location = New System.Drawing.Point(58, 34)
        Me.textbox_TextToCopy_02.Name = "textbox_TextToCopy_02"
        Me.textbox_TextToCopy_02.Size = New System.Drawing.Size(797, 22)
        Me.textbox_TextToCopy_02.TabIndex = 21
        '
        'lbl_textbox_TextToCopy_02
        '
        Me.lbl_textbox_TextToCopy_02.AutoSize = True
        Me.lbl_textbox_TextToCopy_02.Enabled = False
        Me.lbl_textbox_TextToCopy_02.Location = New System.Drawing.Point(10, 37)
        Me.lbl_textbox_TextToCopy_02.Name = "lbl_textbox_TextToCopy_02"
        Me.lbl_textbox_TextToCopy_02.Size = New System.Drawing.Size(26, 13)
        Me.lbl_textbox_TextToCopy_02.TabIndex = 20
        Me.lbl_textbox_TextToCopy_02.Text = "Text"
        '
        'btn_CopyDown_03
        '
        Me.btn_CopyDown_03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CopyDown_03.Enabled = False
        Me.btn_CopyDown_03.Location = New System.Drawing.Point(1061, 60)
        Me.btn_CopyDown_03.Name = "btn_CopyDown_03"
        Me.btn_CopyDown_03.Size = New System.Drawing.Size(59, 26)
        Me.btn_CopyDown_03.TabIndex = 29
        Me.btn_CopyDown_03.Text = "Copy ↓"
        Me.btn_CopyDown_03.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_03
        '
        Me.textbox_CopyLineCount_03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_03.Enabled = False
        Me.textbox_CopyLineCount_03.Location = New System.Drawing.Point(993, 62)
        Me.textbox_CopyLineCount_03.Name = "textbox_CopyLineCount_03"
        Me.textbox_CopyLineCount_03.Size = New System.Drawing.Size(62, 22)
        Me.textbox_CopyLineCount_03.TabIndex = 28
        '
        'lbl_textbox_CopyLineCount_03
        '
        Me.lbl_textbox_CopyLineCount_03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_03.AutoSize = True
        Me.lbl_textbox_CopyLineCount_03.Enabled = False
        Me.lbl_textbox_CopyLineCount_03.Location = New System.Drawing.Point(926, 65)
        Me.lbl_textbox_CopyLineCount_03.Name = "lbl_textbox_CopyLineCount_03"
        Me.lbl_textbox_CopyLineCount_03.Size = New System.Drawing.Size(61, 13)
        Me.lbl_textbox_CopyLineCount_03.TabIndex = 27
        Me.lbl_textbox_CopyLineCount_03.Text = "Line count"
        '
        'textbox_TextToCopy_03
        '
        Me.textbox_TextToCopy_03.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_03.Enabled = False
        Me.textbox_TextToCopy_03.Location = New System.Drawing.Point(58, 62)
        Me.textbox_TextToCopy_03.Name = "textbox_TextToCopy_03"
        Me.textbox_TextToCopy_03.Size = New System.Drawing.Size(797, 22)
        Me.textbox_TextToCopy_03.TabIndex = 26
        '
        'lbl_textbox_TextToCopy_03
        '
        Me.lbl_textbox_TextToCopy_03.AutoSize = True
        Me.lbl_textbox_TextToCopy_03.Enabled = False
        Me.lbl_textbox_TextToCopy_03.Location = New System.Drawing.Point(10, 65)
        Me.lbl_textbox_TextToCopy_03.Name = "lbl_textbox_TextToCopy_03"
        Me.lbl_textbox_TextToCopy_03.Size = New System.Drawing.Size(26, 13)
        Me.lbl_textbox_TextToCopy_03.TabIndex = 25
        Me.lbl_textbox_TextToCopy_03.Text = "Text"
        '
        'btn_CopyDown_04
        '
        Me.btn_CopyDown_04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CopyDown_04.Enabled = False
        Me.btn_CopyDown_04.Location = New System.Drawing.Point(1061, 88)
        Me.btn_CopyDown_04.Name = "btn_CopyDown_04"
        Me.btn_CopyDown_04.Size = New System.Drawing.Size(59, 26)
        Me.btn_CopyDown_04.TabIndex = 34
        Me.btn_CopyDown_04.Text = "Copy ↓"
        Me.btn_CopyDown_04.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_04
        '
        Me.textbox_CopyLineCount_04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_04.Enabled = False
        Me.textbox_CopyLineCount_04.Location = New System.Drawing.Point(993, 90)
        Me.textbox_CopyLineCount_04.Name = "textbox_CopyLineCount_04"
        Me.textbox_CopyLineCount_04.Size = New System.Drawing.Size(62, 22)
        Me.textbox_CopyLineCount_04.TabIndex = 33
        '
        'lbl_textbox_CopyLineCount_04
        '
        Me.lbl_textbox_CopyLineCount_04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_04.AutoSize = True
        Me.lbl_textbox_CopyLineCount_04.Enabled = False
        Me.lbl_textbox_CopyLineCount_04.Location = New System.Drawing.Point(926, 93)
        Me.lbl_textbox_CopyLineCount_04.Name = "lbl_textbox_CopyLineCount_04"
        Me.lbl_textbox_CopyLineCount_04.Size = New System.Drawing.Size(61, 13)
        Me.lbl_textbox_CopyLineCount_04.TabIndex = 32
        Me.lbl_textbox_CopyLineCount_04.Text = "Line count"
        '
        'textbox_TextToCopy_04
        '
        Me.textbox_TextToCopy_04.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_04.Enabled = False
        Me.textbox_TextToCopy_04.Location = New System.Drawing.Point(58, 90)
        Me.textbox_TextToCopy_04.Name = "textbox_TextToCopy_04"
        Me.textbox_TextToCopy_04.Size = New System.Drawing.Size(797, 22)
        Me.textbox_TextToCopy_04.TabIndex = 31
        '
        'lbl_textbox_TextToCopy_04
        '
        Me.lbl_textbox_TextToCopy_04.AutoSize = True
        Me.lbl_textbox_TextToCopy_04.Enabled = False
        Me.lbl_textbox_TextToCopy_04.Location = New System.Drawing.Point(10, 93)
        Me.lbl_textbox_TextToCopy_04.Name = "lbl_textbox_TextToCopy_04"
        Me.lbl_textbox_TextToCopy_04.Size = New System.Drawing.Size(26, 13)
        Me.lbl_textbox_TextToCopy_04.TabIndex = 30
        Me.lbl_textbox_TextToCopy_04.Text = "Text"
        '
        'btn_CopyDown_05
        '
        Me.btn_CopyDown_05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CopyDown_05.Enabled = False
        Me.btn_CopyDown_05.Location = New System.Drawing.Point(1061, 116)
        Me.btn_CopyDown_05.Name = "btn_CopyDown_05"
        Me.btn_CopyDown_05.Size = New System.Drawing.Size(59, 26)
        Me.btn_CopyDown_05.TabIndex = 39
        Me.btn_CopyDown_05.Text = "Copy ↓"
        Me.btn_CopyDown_05.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_05
        '
        Me.textbox_CopyLineCount_05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_05.Enabled = False
        Me.textbox_CopyLineCount_05.Location = New System.Drawing.Point(993, 118)
        Me.textbox_CopyLineCount_05.Name = "textbox_CopyLineCount_05"
        Me.textbox_CopyLineCount_05.Size = New System.Drawing.Size(62, 22)
        Me.textbox_CopyLineCount_05.TabIndex = 38
        '
        'lbl_textbox_CopyLineCount_05
        '
        Me.lbl_textbox_CopyLineCount_05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_05.AutoSize = True
        Me.lbl_textbox_CopyLineCount_05.Enabled = False
        Me.lbl_textbox_CopyLineCount_05.Location = New System.Drawing.Point(926, 121)
        Me.lbl_textbox_CopyLineCount_05.Name = "lbl_textbox_CopyLineCount_05"
        Me.lbl_textbox_CopyLineCount_05.Size = New System.Drawing.Size(61, 13)
        Me.lbl_textbox_CopyLineCount_05.TabIndex = 37
        Me.lbl_textbox_CopyLineCount_05.Text = "Line count"
        '
        'textbox_TextToCopy_05
        '
        Me.textbox_TextToCopy_05.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_05.Enabled = False
        Me.textbox_TextToCopy_05.Location = New System.Drawing.Point(58, 118)
        Me.textbox_TextToCopy_05.Name = "textbox_TextToCopy_05"
        Me.textbox_TextToCopy_05.Size = New System.Drawing.Size(797, 22)
        Me.textbox_TextToCopy_05.TabIndex = 36
        '
        'lbl_textbox_TextToCopy_05
        '
        Me.lbl_textbox_TextToCopy_05.AutoSize = True
        Me.lbl_textbox_TextToCopy_05.Enabled = False
        Me.lbl_textbox_TextToCopy_05.Location = New System.Drawing.Point(10, 121)
        Me.lbl_textbox_TextToCopy_05.Name = "lbl_textbox_TextToCopy_05"
        Me.lbl_textbox_TextToCopy_05.Size = New System.Drawing.Size(26, 13)
        Me.lbl_textbox_TextToCopy_05.TabIndex = 35
        Me.lbl_textbox_TextToCopy_05.Text = "Text"
        '
        'btn_CopyDown_06
        '
        Me.btn_CopyDown_06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CopyDown_06.Enabled = False
        Me.btn_CopyDown_06.Location = New System.Drawing.Point(1061, 144)
        Me.btn_CopyDown_06.Name = "btn_CopyDown_06"
        Me.btn_CopyDown_06.Size = New System.Drawing.Size(59, 26)
        Me.btn_CopyDown_06.TabIndex = 44
        Me.btn_CopyDown_06.Text = "Copy ↓"
        Me.btn_CopyDown_06.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_06
        '
        Me.textbox_CopyLineCount_06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_06.Enabled = False
        Me.textbox_CopyLineCount_06.Location = New System.Drawing.Point(993, 146)
        Me.textbox_CopyLineCount_06.Name = "textbox_CopyLineCount_06"
        Me.textbox_CopyLineCount_06.Size = New System.Drawing.Size(62, 22)
        Me.textbox_CopyLineCount_06.TabIndex = 43
        '
        'lbl_textbox_CopyLineCount_06
        '
        Me.lbl_textbox_CopyLineCount_06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_06.AutoSize = True
        Me.lbl_textbox_CopyLineCount_06.Enabled = False
        Me.lbl_textbox_CopyLineCount_06.Location = New System.Drawing.Point(926, 149)
        Me.lbl_textbox_CopyLineCount_06.Name = "lbl_textbox_CopyLineCount_06"
        Me.lbl_textbox_CopyLineCount_06.Size = New System.Drawing.Size(61, 13)
        Me.lbl_textbox_CopyLineCount_06.TabIndex = 42
        Me.lbl_textbox_CopyLineCount_06.Text = "Line count"
        '
        'textbox_TextToCopy_06
        '
        Me.textbox_TextToCopy_06.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_06.Enabled = False
        Me.textbox_TextToCopy_06.Location = New System.Drawing.Point(58, 146)
        Me.textbox_TextToCopy_06.Name = "textbox_TextToCopy_06"
        Me.textbox_TextToCopy_06.Size = New System.Drawing.Size(797, 22)
        Me.textbox_TextToCopy_06.TabIndex = 41
        '
        'lbl_textbox_TextToCopy_06
        '
        Me.lbl_textbox_TextToCopy_06.AutoSize = True
        Me.lbl_textbox_TextToCopy_06.Enabled = False
        Me.lbl_textbox_TextToCopy_06.Location = New System.Drawing.Point(10, 149)
        Me.lbl_textbox_TextToCopy_06.Name = "lbl_textbox_TextToCopy_06"
        Me.lbl_textbox_TextToCopy_06.Size = New System.Drawing.Size(26, 13)
        Me.lbl_textbox_TextToCopy_06.TabIndex = 40
        Me.lbl_textbox_TextToCopy_06.Text = "Text"
        '
        'cmdbtn_BackupFile
        '
        Me.cmdbtn_BackupFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdbtn_BackupFile.Location = New System.Drawing.Point(1063, 4)
        Me.cmdbtn_BackupFile.Name = "cmdbtn_BackupFile"
        Me.cmdbtn_BackupFile.Size = New System.Drawing.Size(75, 29)
        Me.cmdbtn_BackupFile.TabIndex = 45
        Me.cmdbtn_BackupFile.Text = "Backup"
        Me.cmdbtn_BackupFile.UseVisualStyleBackColor = True
        '
        'btn_Replace
        '
        Me.btn_Replace.Location = New System.Drawing.Point(428, 7)
        Me.btn_Replace.Name = "btn_Replace"
        Me.btn_Replace.Size = New System.Drawing.Size(70, 25)
        Me.btn_Replace.TabIndex = 48
        Me.btn_Replace.Text = "Replace"
        Me.btn_Replace.UseVisualStyleBackColor = True
        '
        'oSplitContainer_Main
        '
        Me.oSplitContainer_Main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oSplitContainer_Main.Location = New System.Drawing.Point(4, 70)
        Me.oSplitContainer_Main.Name = "oSplitContainer_Main"
        Me.oSplitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'oSplitContainer_Main.Panel1
        '
        Me.oSplitContainer_Main.Panel1.Controls.Add(Me.oTabControl_01)
        '
        'oSplitContainer_Main.Panel2
        '
        Me.oSplitContainer_Main.Panel2.Controls.Add(Me.oSplitContainer_01)
        Me.oSplitContainer_Main.Size = New System.Drawing.Size(1134, 490)
        Me.oSplitContainer_Main.SplitterDistance = 145
        Me.oSplitContainer_Main.TabIndex = 49
        '
        'oTabControl_01
        '
        Me.oTabControl_01.Controls.Add(Me.oTabPage_FileProperties)
        Me.oTabControl_01.Controls.Add(Me.oTabPage_ExifData)
        Me.oTabControl_01.Controls.Add(Me.oTabPage_Snippets)
        Me.oTabControl_01.Controls.Add(Me.oTabPage_SearchResults)
        Me.oTabControl_01.Controls.Add(Me.oTabPage_Keys)
        Me.oTabControl_01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oTabControl_01.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oTabControl_01.Location = New System.Drawing.Point(0, 0)
        Me.oTabControl_01.Name = "oTabControl_01"
        Me.oTabControl_01.SelectedIndex = 0
        Me.oTabControl_01.Size = New System.Drawing.Size(1134, 145)
        Me.oTabControl_01.TabIndex = 45
        '
        'oTabPage_FileProperties
        '
        Me.oTabPage_FileProperties.Controls.Add(Me.oListView_FileProperties)
        Me.oTabPage_FileProperties.Location = New System.Drawing.Point(4, 22)
        Me.oTabPage_FileProperties.Name = "oTabPage_FileProperties"
        Me.oTabPage_FileProperties.Padding = New System.Windows.Forms.Padding(3)
        Me.oTabPage_FileProperties.Size = New System.Drawing.Size(1126, 119)
        Me.oTabPage_FileProperties.TabIndex = 2
        Me.oTabPage_FileProperties.Text = "File Properties"
        Me.oTabPage_FileProperties.UseVisualStyleBackColor = True
        '
        'oListView_FileProperties
        '
        Me.oListView_FileProperties.BackColor = System.Drawing.SystemColors.Window
        Me.oListView_FileProperties.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_Name, Me.column_Number, Me.column_Value})
        Me.oListView_FileProperties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oListView_FileProperties.FullRowSelect = True
        Me.oListView_FileProperties.GridLines = True
        Me.oListView_FileProperties.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.oListView_FileProperties.Location = New System.Drawing.Point(3, 3)
        Me.oListView_FileProperties.MultiSelect = False
        Me.oListView_FileProperties.Name = "oListView_FileProperties"
        Me.oListView_FileProperties.Size = New System.Drawing.Size(1120, 113)
        Me.oListView_FileProperties.TabIndex = 0
        Me.oListView_FileProperties.UseCompatibleStateImageBehavior = False
        Me.oListView_FileProperties.View = System.Windows.Forms.View.Details
        '
        'column_Name
        '
        Me.column_Name.Text = "Name"
        Me.column_Name.Width = 200
        '
        'column_Number
        '
        Me.column_Number.Text = "#"
        Me.column_Number.Width = 40
        '
        'column_Value
        '
        Me.column_Value.Text = "Value"
        Me.column_Value.Width = 400
        '
        'oTabPage_ExifData
        '
        Me.oTabPage_ExifData.Controls.Add(Me.oListView_ExifData)
        Me.oTabPage_ExifData.Location = New System.Drawing.Point(4, 22)
        Me.oTabPage_ExifData.Name = "oTabPage_ExifData"
        Me.oTabPage_ExifData.Size = New System.Drawing.Size(1126, 119)
        Me.oTabPage_ExifData.TabIndex = 4
        Me.oTabPage_ExifData.Text = "Exif Data"
        Me.oTabPage_ExifData.UseVisualStyleBackColor = True
        '
        'oListView_ExifData
        '
        Me.oListView_ExifData.BackColor = System.Drawing.SystemColors.Window
        Me.oListView_ExifData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.oListView_ExifData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oListView_ExifData.FullRowSelect = True
        Me.oListView_ExifData.GridLines = True
        Me.oListView_ExifData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.oListView_ExifData.Location = New System.Drawing.Point(0, 0)
        Me.oListView_ExifData.MultiSelect = False
        Me.oListView_ExifData.Name = "oListView_ExifData"
        Me.oListView_ExifData.Size = New System.Drawing.Size(1126, 119)
        Me.oListView_ExifData.TabIndex = 1
        Me.oListView_ExifData.UseCompatibleStateImageBehavior = False
        Me.oListView_ExifData.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 400
        '
        'oTabPage_Snippets
        '
        Me.oTabPage_Snippets.Controls.Add(Me.btn_Copy_06)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_Copy_03)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_Copy_01)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_Copy_04)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_Copy_05)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_Copy_02)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_TextToCopy_01)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_TextToCopy_04)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_TextToCopy_01)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_CopyLineCount_04)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_CopyLineCount_01)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_TextToCopy_04)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_CopyLineCount_01)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_CopyLineCount_04)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_CopyDown_06)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_CopyDown_03)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_CopyDown_01)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_CopyDown_04)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_CopyLineCount_06)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_CopyLineCount_03)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_TextToCopy_02)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_TextToCopy_05)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_CopyLineCount_06)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_CopyLineCount_03)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_TextToCopy_02)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_TextToCopy_05)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_TextToCopy_06)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_TextToCopy_03)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_CopyLineCount_02)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_CopyLineCount_05)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_TextToCopy_06)
        Me.oTabPage_Snippets.Controls.Add(Me.lbl_textbox_TextToCopy_03)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_CopyLineCount_02)
        Me.oTabPage_Snippets.Controls.Add(Me.textbox_CopyLineCount_05)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_CopyDown_05)
        Me.oTabPage_Snippets.Controls.Add(Me.btn_CopyDown_02)
        Me.oTabPage_Snippets.Location = New System.Drawing.Point(4, 22)
        Me.oTabPage_Snippets.Name = "oTabPage_Snippets"
        Me.oTabPage_Snippets.Padding = New System.Windows.Forms.Padding(3)
        Me.oTabPage_Snippets.Size = New System.Drawing.Size(1126, 119)
        Me.oTabPage_Snippets.TabIndex = 0
        Me.oTabPage_Snippets.Text = "Snippets"
        Me.oTabPage_Snippets.UseVisualStyleBackColor = True
        '
        'btn_Copy_06
        '
        Me.btn_Copy_06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Copy_06.Enabled = False
        Me.btn_Copy_06.Location = New System.Drawing.Point(861, 144)
        Me.btn_Copy_06.Name = "btn_Copy_06"
        Me.btn_Copy_06.Size = New System.Drawing.Size(59, 26)
        Me.btn_Copy_06.TabIndex = 50
        Me.btn_Copy_06.Text = "Copy"
        Me.btn_Copy_06.UseVisualStyleBackColor = True
        '
        'btn_Copy_03
        '
        Me.btn_Copy_03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Copy_03.Enabled = False
        Me.btn_Copy_03.Location = New System.Drawing.Point(861, 60)
        Me.btn_Copy_03.Name = "btn_Copy_03"
        Me.btn_Copy_03.Size = New System.Drawing.Size(59, 26)
        Me.btn_Copy_03.TabIndex = 47
        Me.btn_Copy_03.Text = "Copy"
        Me.btn_Copy_03.UseVisualStyleBackColor = True
        '
        'btn_Copy_01
        '
        Me.btn_Copy_01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Copy_01.Enabled = False
        Me.btn_Copy_01.Location = New System.Drawing.Point(861, 4)
        Me.btn_Copy_01.Name = "btn_Copy_01"
        Me.btn_Copy_01.Size = New System.Drawing.Size(59, 26)
        Me.btn_Copy_01.TabIndex = 45
        Me.btn_Copy_01.Text = "Copy"
        Me.btn_Copy_01.UseVisualStyleBackColor = True
        '
        'btn_Copy_04
        '
        Me.btn_Copy_04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Copy_04.Enabled = False
        Me.btn_Copy_04.Location = New System.Drawing.Point(861, 88)
        Me.btn_Copy_04.Name = "btn_Copy_04"
        Me.btn_Copy_04.Size = New System.Drawing.Size(59, 26)
        Me.btn_Copy_04.TabIndex = 48
        Me.btn_Copy_04.Text = "Copy"
        Me.btn_Copy_04.UseVisualStyleBackColor = True
        '
        'btn_Copy_05
        '
        Me.btn_Copy_05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Copy_05.Enabled = False
        Me.btn_Copy_05.Location = New System.Drawing.Point(861, 116)
        Me.btn_Copy_05.Name = "btn_Copy_05"
        Me.btn_Copy_05.Size = New System.Drawing.Size(59, 26)
        Me.btn_Copy_05.TabIndex = 49
        Me.btn_Copy_05.Text = "Copy"
        Me.btn_Copy_05.UseVisualStyleBackColor = True
        '
        'btn_Copy_02
        '
        Me.btn_Copy_02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Copy_02.Enabled = False
        Me.btn_Copy_02.Location = New System.Drawing.Point(861, 32)
        Me.btn_Copy_02.Name = "btn_Copy_02"
        Me.btn_Copy_02.Size = New System.Drawing.Size(59, 26)
        Me.btn_Copy_02.TabIndex = 46
        Me.btn_Copy_02.Text = "Copy"
        Me.btn_Copy_02.UseVisualStyleBackColor = True
        '
        'oTabPage_SearchResults
        '
        Me.oTabPage_SearchResults.Controls.Add(Me.oListView_SearchResults)
        Me.oTabPage_SearchResults.Location = New System.Drawing.Point(4, 22)
        Me.oTabPage_SearchResults.Name = "oTabPage_SearchResults"
        Me.oTabPage_SearchResults.Padding = New System.Windows.Forms.Padding(3)
        Me.oTabPage_SearchResults.Size = New System.Drawing.Size(1126, 119)
        Me.oTabPage_SearchResults.TabIndex = 1
        Me.oTabPage_SearchResults.Text = "Search Results"
        Me.oTabPage_SearchResults.UseVisualStyleBackColor = True
        '
        'oListView_SearchResults
        '
        Me.oListView_SearchResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_Path, Me.column_Line})
        Me.oListView_SearchResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oListView_SearchResults.FullRowSelect = True
        Me.oListView_SearchResults.GridLines = True
        Me.oListView_SearchResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.oListView_SearchResults.Location = New System.Drawing.Point(3, 3)
        Me.oListView_SearchResults.MultiSelect = False
        Me.oListView_SearchResults.Name = "oListView_SearchResults"
        Me.oListView_SearchResults.Size = New System.Drawing.Size(1120, 113)
        Me.oListView_SearchResults.TabIndex = 0
        Me.oListView_SearchResults.UseCompatibleStateImageBehavior = False
        Me.oListView_SearchResults.View = System.Windows.Forms.View.Details
        '
        'column_Path
        '
        Me.column_Path.Text = "Path"
        Me.column_Path.Width = 400
        '
        'column_Line
        '
        Me.column_Line.Text = "Line"
        Me.column_Line.Width = 600
        '
        'oTabPage_Keys
        '
        Me.oTabPage_Keys.Controls.Add(Me.oListView_Keys)
        Me.oTabPage_Keys.Location = New System.Drawing.Point(4, 22)
        Me.oTabPage_Keys.Name = "oTabPage_Keys"
        Me.oTabPage_Keys.Size = New System.Drawing.Size(1126, 119)
        Me.oTabPage_Keys.TabIndex = 3
        Me.oTabPage_Keys.Text = "Keys"
        Me.oTabPage_Keys.UseVisualStyleBackColor = True
        '
        'oListView_Keys
        '
        Me.oListView_Keys.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_Key, Me.column_Action})
        Me.oListView_Keys.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oListView_Keys.FullRowSelect = True
        Me.oListView_Keys.GridLines = True
        Me.oListView_Keys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.oListView_Keys.Location = New System.Drawing.Point(0, 0)
        Me.oListView_Keys.Name = "oListView_Keys"
        Me.oListView_Keys.Size = New System.Drawing.Size(1126, 119)
        Me.oListView_Keys.TabIndex = 0
        Me.oListView_Keys.UseCompatibleStateImageBehavior = False
        Me.oListView_Keys.View = System.Windows.Forms.View.Details
        '
        'column_Key
        '
        Me.column_Key.Text = "Key"
        Me.column_Key.Width = 100
        '
        'column_Action
        '
        Me.column_Action.Text = "Action"
        Me.column_Action.Width = 500
        '
        'cbo_Path
        '
        Me.cbo_Path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_Path.FormattingEnabled = True
        Me.cbo_Path.Location = New System.Drawing.Point(4, 39)
        Me.cbo_Path.Name = "cbo_Path"
        Me.cbo_Path.Size = New System.Drawing.Size(685, 21)
        Me.cbo_Path.TabIndex = 50
        '
        'btn_FindInfo
        '
        Me.btn_FindInfo.Location = New System.Drawing.Point(504, 7)
        Me.btn_FindInfo.Name = "btn_FindInfo"
        Me.btn_FindInfo.Size = New System.Drawing.Size(120, 25)
        Me.btn_FindInfo.TabIndex = 51
        Me.btn_FindInfo.Text = "Search Info"
        Me.btn_FindInfo.UseVisualStyleBackColor = True
        '
        'btn_Go
        '
        Me.btn_Go.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Go.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_Go.Location = New System.Drawing.Point(695, 38)
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(28, 23)
        Me.btn_Go.TabIndex = 52
        Me.btn_Go.Text = "è"
        Me.oToolTip_01.SetToolTip(Me.btn_Go, "Go to selected folder")
        Me.btn_Go.UseVisualStyleBackColor = True
        '
        'oToolTip_01
        '
        Me.oToolTip_01.ToolTipTitle = "Tip"
        '
        'btn_Map
        '
        Me.btn_Map.Location = New System.Drawing.Point(630, 7)
        Me.btn_Map.Name = "btn_Map"
        Me.btn_Map.Size = New System.Drawing.Size(70, 25)
        Me.btn_Map.TabIndex = 53
        Me.btn_Map.Text = "Map"
        Me.btn_Map.UseVisualStyleBackColor = True
        '
        'btn_NewVideoProject
        '
        Me.btn_NewVideoProject.Location = New System.Drawing.Point(706, 7)
        Me.btn_NewVideoProject.Name = "btn_NewVideoProject"
        Me.btn_NewVideoProject.Size = New System.Drawing.Size(120, 25)
        Me.btn_NewVideoProject.TabIndex = 54
        Me.btn_NewVideoProject.Text = "New Video Project"
        Me.btn_NewVideoProject.UseVisualStyleBackColor = True
        '
        'frm_PhotoOrbit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 563)
        Me.Controls.Add(Me.btn_NewVideoProject)
        Me.Controls.Add(Me.btn_Map)
        Me.Controls.Add(Me.btn_Go)
        Me.Controls.Add(Me.btn_FindInfo)
        Me.Controls.Add(Me.cbo_Path)
        Me.Controls.Add(Me.oSplitContainer_Main)
        Me.Controls.Add(Me.btn_Replace)
        Me.Controls.Add(Me.cmdbtn_BackupFile)
        Me.Controls.Add(Me.m_cmdbtn_GatherSubFolderFiles)
        Me.Controls.Add(Me.btn_Enumerate)
        Me.Controls.Add(Me.cmdbtn_RotateRight)
        Me.Controls.Add(Me.cmdbtn_RotateLeft)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_PhotoOrbit"
        Me.Text = "Photo-Orbit"
        CType(Me.pic_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_01.Panel1.ResumeLayout(False)
        Me.oSplitContainer_01.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_01.ResumeLayout(False)
        Me.oSplitContainer_Left.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Left.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_Left, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Left.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Right.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Right.Panel2.ResumeLayout(False)
        Me.oSplitContainer_Right.Panel2.PerformLayout()
        CType(Me.oSplitContainer_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Right.ResumeLayout(False)
        Me.oSplitContainer_Info.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Info.Panel1.PerformLayout()
        Me.oSplitContainer_Info.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_Info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Info.ResumeLayout(False)
        Me.oPanel_Info.ResumeLayout(False)
        CType(Me.mplayer_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Main.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Main.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Main.ResumeLayout(False)
        Me.oTabControl_01.ResumeLayout(False)
        Me.oTabPage_FileProperties.ResumeLayout(False)
        Me.oTabPage_ExifData.ResumeLayout(False)
        Me.oTabPage_Snippets.ResumeLayout(False)
        Me.oTabPage_Snippets.PerformLayout()
        Me.oTabPage_SearchResults.ResumeLayout(False)
        Me.oTabPage_Keys.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Enumerate As System.Windows.Forms.Button
  Friend WithEvents cmdbtn_RotateRight As System.Windows.Forms.Button
  Friend WithEvents cmdbtn_RotateLeft As System.Windows.Forms.Button
  Friend WithEvents oDirListBox_01 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents pic_01 As System.Windows.Forms.PictureBox
    Friend WithEvents oSplitContainer_01 As System.Windows.Forms.SplitContainer
    Friend WithEvents oSplitContainer_Left As System.Windows.Forms.SplitContainer
    Friend WithEvents oSplitContainer_Right As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_CreateInfoFile As System.Windows.Forms.Button
    Friend WithEvents m_cmdbtn_GatherSubFolderFiles As System.Windows.Forms.Button
    Friend WithEvents lbl_textbox_TextToCopy_01 As System.Windows.Forms.Label
    Friend WithEvents textbox_TextToCopy_01 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_CopyLineCount_01 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_CopyLineCount_01 As System.Windows.Forms.Label
    Friend WithEvents btn_CopyDown_01 As System.Windows.Forms.Button
    Friend WithEvents btn_CopyDown_02 As System.Windows.Forms.Button
    Friend WithEvents textbox_CopyLineCount_02 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_CopyLineCount_02 As System.Windows.Forms.Label
    Friend WithEvents textbox_TextToCopy_02 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_TextToCopy_02 As System.Windows.Forms.Label
    Friend WithEvents btn_CopyDown_03 As System.Windows.Forms.Button
    Friend WithEvents textbox_CopyLineCount_03 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_CopyLineCount_03 As System.Windows.Forms.Label
    Friend WithEvents textbox_TextToCopy_03 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_TextToCopy_03 As System.Windows.Forms.Label
    Friend WithEvents btn_CopyDown_04 As System.Windows.Forms.Button
    Friend WithEvents textbox_CopyLineCount_04 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_CopyLineCount_04 As System.Windows.Forms.Label
    Friend WithEvents textbox_TextToCopy_04 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_TextToCopy_04 As System.Windows.Forms.Label
    Friend WithEvents btn_CopyDown_05 As System.Windows.Forms.Button
    Friend WithEvents textbox_CopyLineCount_05 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_CopyLineCount_05 As System.Windows.Forms.Label
    Friend WithEvents textbox_TextToCopy_05 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_TextToCopy_05 As System.Windows.Forms.Label
    Friend WithEvents btn_CopyDown_06 As System.Windows.Forms.Button
    Friend WithEvents textbox_CopyLineCount_06 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_CopyLineCount_06 As System.Windows.Forms.Label
    Friend WithEvents textbox_TextToCopy_06 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_textbox_TextToCopy_06 As System.Windows.Forms.Label
    Friend WithEvents cmdbtn_BackupFile As System.Windows.Forms.Button
    Friend WithEvents textbox_PathedFileName_Info As System.Windows.Forms.TextBox
    Friend WithEvents mplayer_01 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btn_Replace As Button
    Friend WithEvents oSplitContainer_Info As SplitContainer
    Friend WithEvents oListView_Info As ListView
    Friend WithEvents Num As ColumnHeader
    Friend WithEvents Country As ColumnHeader
    Friend WithEvents State As ColumnHeader
    Friend WithEvents County As ColumnHeader
    Friend WithEvents City As ColumnHeader
    Friend WithEvents Descr As ColumnHeader
    Friend WithEvents oSplitContainer_Main As SplitContainer
    Friend WithEvents btn_Up As Button
    Friend WithEvents cbo_Path As ComboBox
    Friend WithEvents btn_FindInfo As Button
    Friend WithEvents oTabControl_01 As TabControl
    Friend WithEvents oTabPage_Snippets As TabPage
    Friend WithEvents oTabPage_SearchResults As TabPage
    Friend WithEvents oListView_SearchResults As ListView
    Friend WithEvents column_Path As ColumnHeader
    Friend WithEvents column_Line As ColumnHeader
    Friend WithEvents btn_Go As Button
    Friend WithEvents textbox_Info As RichTextBox
    Friend WithEvents oTabPage_FileProperties As TabPage
    Friend WithEvents oListView_FileProperties As ListView
    Friend WithEvents column_Name As ColumnHeader
    Friend WithEvents column_Value As ColumnHeader
    Friend WithEvents oToolTip_01 As ToolTip
    Friend WithEvents chkbtn_ShowDetails As CheckBox
    Friend WithEvents oListView_Files As ListView
    Friend WithEvents column_FileName As ColumnHeader
    Friend WithEvents column_Category As ColumnHeader
    Friend WithEvents oPanel_Info As Panel
    Friend WithEvents textbox_PathedFileName_Display As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents oTabPage_Keys As TabPage
    Friend WithEvents oListView_Keys As ListView
    Friend WithEvents column_Key As ColumnHeader
    Friend WithEvents column_Action As ColumnHeader
    Friend WithEvents btn_Copy_06 As Button
    Friend WithEvents btn_Copy_03 As Button
    Friend WithEvents btn_Copy_01 As Button
    Friend WithEvents btn_Copy_04 As Button
    Friend WithEvents btn_Copy_05 As Button
    Friend WithEvents btn_Copy_02 As Button
    Friend WithEvents textbox_Version As TextBox
    Friend WithEvents btn_ConvertInfoFile As Button
    Friend WithEvents btn_Map As Button
    Friend WithEvents column_Size As ColumnHeader
    Friend WithEvents btn_NewVideoProject As Button
    Friend WithEvents btn_Folder_Videos As Button
    Friend WithEvents btn_Folder_Pictures As Button
    Friend WithEvents btn_Now As Button
    Friend WithEvents oTabPage_ExifData As TabPage
    Friend WithEvents oListView_ExifData As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents column_Number As ColumnHeader
    Friend WithEvents column_Duration As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents Duration As ColumnHeader
End Class
