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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PhotoOrbit))
        Me.cmdbtn_Rename = New System.Windows.Forms.Button()
        Me.cmdbtn_RotateRight = New System.Windows.Forms.Button()
        Me.cmdbtn_RotateLeft = New System.Windows.Forms.Button()
        Me.oTextBox_Info = New System.Windows.Forms.TextBox()
        Me.m_oFileListBox_01 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.dirtree_01 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.pic_01 = New System.Windows.Forms.PictureBox()
        Me.oSplitContainer_01 = New System.Windows.Forms.SplitContainer()
        Me.oSplitContainer_Left = New System.Windows.Forms.SplitContainer()
        Me.btn_Now = New System.Windows.Forms.Button()
        Me.oSplitContainer_Right = New System.Windows.Forms.SplitContainer()
        Me.cmdbtn_CreateInfoFile = New System.Windows.Forms.Button()
        Me.oSplitContainer_Viewer = New System.Windows.Forms.SplitContainer()
        Me.mplayer_01 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.oListBox_Properties = New System.Windows.Forms.ListBox()
        Me.m_cmdbtn_GatherSubFolderFiles = New System.Windows.Forms.Button()
        Me.lbl_textbox_TextToCopy_01 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_01 = New System.Windows.Forms.TextBox()
        Me.textbox_CopyLineCount_01 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_01 = New System.Windows.Forms.Label()
        Me.cmdbtn_Copy_01 = New System.Windows.Forms.Button()
        Me.cmdbtn_Copy_02 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_02 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_02 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_02 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_02 = New System.Windows.Forms.Label()
        Me.cmdbtn_Copy_03 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_03 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_03 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_03 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_03 = New System.Windows.Forms.Label()
        Me.cmdbtn_Copy_04 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_04 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_04 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_04 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_04 = New System.Windows.Forms.Label()
        Me.cmdbtn_Copy_05 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_05 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_05 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_05 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_05 = New System.Windows.Forms.Label()
        Me.cmdbtn_Copy_06 = New System.Windows.Forms.Button()
        Me.textbox_CopyLineCount_06 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_CopyLineCount_06 = New System.Windows.Forms.Label()
        Me.textbox_TextToCopy_06 = New System.Windows.Forms.TextBox()
        Me.lbl_textbox_TextToCopy_06 = New System.Windows.Forms.Label()
        Me.m_cmdbtn_BackupFile = New System.Windows.Forms.Button()
        Me.m_text_PathedFileName_Info = New System.Windows.Forms.TextBox()
        CType(Me.pic_01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oSplitContainer_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_01.Panel1.SuspendLayout()
        Me.oSplitContainer_01.Panel2.SuspendLayout()
        Me.oSplitContainer_01.SuspendLayout()
        CType(Me.oSplitContainer_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Left.Panel1.SuspendLayout()
        Me.oSplitContainer_Left.Panel2.SuspendLayout()
        Me.oSplitContainer_Left.SuspendLayout()
        CType(Me.oSplitContainer_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Right.Panel1.SuspendLayout()
        Me.oSplitContainer_Right.Panel2.SuspendLayout()
        Me.oSplitContainer_Right.SuspendLayout()
        CType(Me.oSplitContainer_Viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oSplitContainer_Viewer.Panel1.SuspendLayout()
        Me.oSplitContainer_Viewer.Panel2.SuspendLayout()
        Me.oSplitContainer_Viewer.SuspendLayout()
        CType(Me.mplayer_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdbtn_Rename
        '
        Me.cmdbtn_Rename.Location = New System.Drawing.Point(324, 4)
        Me.cmdbtn_Rename.Name = "cmdbtn_Rename"
        Me.cmdbtn_Rename.Size = New System.Drawing.Size(154, 29)
        Me.cmdbtn_Rename.TabIndex = 10
        Me.cmdbtn_Rename.Text = "Rename"
        Me.cmdbtn_Rename.UseVisualStyleBackColor = True
        '
        'cmdbtn_RotateRight
        '
        Me.cmdbtn_RotateRight.Location = New System.Drawing.Point(164, 4)
        Me.cmdbtn_RotateRight.Name = "cmdbtn_RotateRight"
        Me.cmdbtn_RotateRight.Size = New System.Drawing.Size(154, 29)
        Me.cmdbtn_RotateRight.TabIndex = 9
        Me.cmdbtn_RotateRight.Text = "Rotate Right (F12)"
        Me.cmdbtn_RotateRight.UseVisualStyleBackColor = True
        '
        'cmdbtn_RotateLeft
        '
        Me.cmdbtn_RotateLeft.Location = New System.Drawing.Point(4, 4)
        Me.cmdbtn_RotateLeft.Name = "cmdbtn_RotateLeft"
        Me.cmdbtn_RotateLeft.Size = New System.Drawing.Size(154, 29)
        Me.cmdbtn_RotateLeft.TabIndex = 8
        Me.cmdbtn_RotateLeft.Text = "Rotate Left (F11)"
        Me.cmdbtn_RotateLeft.UseVisualStyleBackColor = True
        '
        'oTextBox_Info
        '
        Me.oTextBox_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oTextBox_Info.Location = New System.Drawing.Point(0, 0)
        Me.oTextBox_Info.Multiline = True
        Me.oTextBox_Info.Name = "oTextBox_Info"
        Me.oTextBox_Info.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.oTextBox_Info.Size = New System.Drawing.Size(272, 290)
        Me.oTextBox_Info.TabIndex = 8
        Me.oTextBox_Info.WordWrap = False
        '
        'm_oFileListBox_01
        '
        Me.m_oFileListBox_01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_oFileListBox_01.FormattingEnabled = True
        Me.m_oFileListBox_01.Location = New System.Drawing.Point(0, 0)
        Me.m_oFileListBox_01.Name = "m_oFileListBox_01"
        Me.m_oFileListBox_01.Pattern = "*.*"
        Me.m_oFileListBox_01.Size = New System.Drawing.Size(106, 289)
        Me.m_oFileListBox_01.TabIndex = 7
        '
        'dirtree_01
        '
        Me.dirtree_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dirtree_01.FormattingEnabled = True
        Me.dirtree_01.IntegralHeight = False
        Me.dirtree_01.Location = New System.Drawing.Point(0, 0)
        Me.dirtree_01.Name = "dirtree_01"
        Me.dirtree_01.Size = New System.Drawing.Size(152, 254)
        Me.dirtree_01.TabIndex = 6
        '
        'pic_01
        '
        Me.pic_01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_01.Location = New System.Drawing.Point(0, 0)
        Me.pic_01.Name = "pic_01"
        Me.pic_01.Size = New System.Drawing.Size(348, 214)
        Me.pic_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_01.TabIndex = 9
        Me.pic_01.TabStop = False
        '
        'oSplitContainer_01
        '
        Me.oSplitContainer_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oSplitContainer_01.Location = New System.Drawing.Point(8, 234)
        Me.oSplitContainer_01.Name = "oSplitContainer_01"
        '
        'oSplitContainer_01.Panel1
        '
        Me.oSplitContainer_01.Panel1.Controls.Add(Me.oSplitContainer_Left)
        '
        'oSplitContainer_01.Panel2
        '
        Me.oSplitContainer_01.Panel2.Controls.Add(Me.oSplitContainer_Right)
        Me.oSplitContainer_01.Size = New System.Drawing.Size(890, 290)
        Me.oSplitContainer_01.SplitterDistance = 262
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
        Me.oSplitContainer_Left.Panel1.Controls.Add(Me.btn_Now)
        Me.oSplitContainer_Left.Panel1.Controls.Add(Me.dirtree_01)
        '
        'oSplitContainer_Left.Panel2
        '
        Me.oSplitContainer_Left.Panel2.Controls.Add(Me.m_oFileListBox_01)
        Me.oSplitContainer_Left.Size = New System.Drawing.Size(262, 290)
        Me.oSplitContainer_Left.SplitterDistance = 152
        Me.oSplitContainer_Left.TabIndex = 0
        '
        'btn_Now
        '
        Me.btn_Now.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Now.Location = New System.Drawing.Point(0, 260)
        Me.btn_Now.Name = "btn_Now"
        Me.btn_Now.Size = New System.Drawing.Size(152, 30)
        Me.btn_Now.TabIndex = 7
        Me.btn_Now.Text = "Now"
        Me.btn_Now.UseVisualStyleBackColor = True
        '
        'oSplitContainer_Right
        '
        Me.oSplitContainer_Right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oSplitContainer_Right.Location = New System.Drawing.Point(0, 0)
        Me.oSplitContainer_Right.Name = "oSplitContainer_Right"
        '
        'oSplitContainer_Right.Panel1
        '
        Me.oSplitContainer_Right.Panel1.Controls.Add(Me.cmdbtn_CreateInfoFile)
        Me.oSplitContainer_Right.Panel1.Controls.Add(Me.oTextBox_Info)
        '
        'oSplitContainer_Right.Panel2
        '
        Me.oSplitContainer_Right.Panel2.Controls.Add(Me.oSplitContainer_Viewer)
        Me.oSplitContainer_Right.Size = New System.Drawing.Size(624, 290)
        Me.oSplitContainer_Right.SplitterDistance = 272
        Me.oSplitContainer_Right.TabIndex = 0
        '
        'cmdbtn_CreateInfoFile
        '
        Me.cmdbtn_CreateInfoFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdbtn_CreateInfoFile.Location = New System.Drawing.Point(0, 0)
        Me.cmdbtn_CreateInfoFile.Name = "cmdbtn_CreateInfoFile"
        Me.cmdbtn_CreateInfoFile.Size = New System.Drawing.Size(271, 40)
        Me.cmdbtn_CreateInfoFile.TabIndex = 13
        Me.cmdbtn_CreateInfoFile.Text = "Create Info File"
        Me.cmdbtn_CreateInfoFile.UseVisualStyleBackColor = True
        '
        'oSplitContainer_Viewer
        '
        Me.oSplitContainer_Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oSplitContainer_Viewer.Location = New System.Drawing.Point(0, 0)
        Me.oSplitContainer_Viewer.Name = "oSplitContainer_Viewer"
        Me.oSplitContainer_Viewer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'oSplitContainer_Viewer.Panel1
        '
        Me.oSplitContainer_Viewer.Panel1.Controls.Add(Me.pic_01)
        Me.oSplitContainer_Viewer.Panel1.Controls.Add(Me.mplayer_01)
        '
        'oSplitContainer_Viewer.Panel2
        '
        Me.oSplitContainer_Viewer.Panel2.Controls.Add(Me.oListBox_Properties)
        Me.oSplitContainer_Viewer.Size = New System.Drawing.Size(348, 290)
        Me.oSplitContainer_Viewer.SplitterDistance = 214
        Me.oSplitContainer_Viewer.TabIndex = 11
        '
        'mplayer_01
        '
        Me.mplayer_01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mplayer_01.Enabled = True
        Me.mplayer_01.Location = New System.Drawing.Point(0, 0)
        Me.mplayer_01.Name = "mplayer_01"
        Me.mplayer_01.OcxState = CType(resources.GetObject("mplayer_01.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mplayer_01.Size = New System.Drawing.Size(348, 214)
        Me.mplayer_01.TabIndex = 10
        '
        'oListBox_Properties
        '
        Me.oListBox_Properties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oListBox_Properties.FormattingEnabled = True
        Me.oListBox_Properties.ItemHeight = 19
        Me.oListBox_Properties.Location = New System.Drawing.Point(0, 0)
        Me.oListBox_Properties.Name = "oListBox_Properties"
        Me.oListBox_Properties.Size = New System.Drawing.Size(348, 72)
        Me.oListBox_Properties.TabIndex = 0
        '
        'm_cmdbtn_GatherSubFolderFiles
        '
        Me.m_cmdbtn_GatherSubFolderFiles.Location = New System.Drawing.Point(484, 4)
        Me.m_cmdbtn_GatherSubFolderFiles.Name = "m_cmdbtn_GatherSubFolderFiles"
        Me.m_cmdbtn_GatherSubFolderFiles.Size = New System.Drawing.Size(154, 29)
        Me.m_cmdbtn_GatherSubFolderFiles.TabIndex = 14
        Me.m_cmdbtn_GatherSubFolderFiles.Text = "Gather sub-folder files"
        Me.m_cmdbtn_GatherSubFolderFiles.UseVisualStyleBackColor = True
        '
        'lbl_textbox_TextToCopy_01
        '
        Me.lbl_textbox_TextToCopy_01.AutoSize = True
        Me.lbl_textbox_TextToCopy_01.Enabled = False
        Me.lbl_textbox_TextToCopy_01.Location = New System.Drawing.Point(12, 45)
        Me.lbl_textbox_TextToCopy_01.Name = "lbl_textbox_TextToCopy_01"
        Me.lbl_textbox_TextToCopy_01.Size = New System.Drawing.Size(34, 19)
        Me.lbl_textbox_TextToCopy_01.TabIndex = 15
        Me.lbl_textbox_TextToCopy_01.Text = "Text"
        '
        'textbox_TextToCopy_01
        '
        Me.textbox_TextToCopy_01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_01.Enabled = False
        Me.textbox_TextToCopy_01.Location = New System.Drawing.Point(63, 42)
        Me.textbox_TextToCopy_01.Name = "textbox_TextToCopy_01"
        Me.textbox_TextToCopy_01.Size = New System.Drawing.Size(618, 26)
        Me.textbox_TextToCopy_01.TabIndex = 16
        '
        'textbox_CopyLineCount_01
        '
        Me.textbox_CopyLineCount_01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_01.Enabled = False
        Me.textbox_CopyLineCount_01.Location = New System.Drawing.Point(772, 42)
        Me.textbox_CopyLineCount_01.Name = "textbox_CopyLineCount_01"
        Me.textbox_CopyLineCount_01.Size = New System.Drawing.Size(62, 26)
        Me.textbox_CopyLineCount_01.TabIndex = 18
        '
        'lbl_textbox_CopyLineCount_01
        '
        Me.lbl_textbox_CopyLineCount_01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_01.AutoSize = True
        Me.lbl_textbox_CopyLineCount_01.Enabled = False
        Me.lbl_textbox_CopyLineCount_01.Location = New System.Drawing.Point(687, 43)
        Me.lbl_textbox_CopyLineCount_01.Name = "lbl_textbox_CopyLineCount_01"
        Me.lbl_textbox_CopyLineCount_01.Size = New System.Drawing.Size(73, 19)
        Me.lbl_textbox_CopyLineCount_01.TabIndex = 17
        Me.lbl_textbox_CopyLineCount_01.Text = "Line count"
        '
        'cmdbtn_Copy_01
        '
        Me.cmdbtn_Copy_01.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdbtn_Copy_01.Enabled = False
        Me.cmdbtn_Copy_01.Location = New System.Drawing.Point(840, 40)
        Me.cmdbtn_Copy_01.Name = "cmdbtn_Copy_01"
        Me.cmdbtn_Copy_01.Size = New System.Drawing.Size(59, 29)
        Me.cmdbtn_Copy_01.TabIndex = 19
        Me.cmdbtn_Copy_01.Text = "Copy"
        Me.cmdbtn_Copy_01.UseVisualStyleBackColor = True
        '
        'cmdbtn_Copy_02
        '
        Me.cmdbtn_Copy_02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdbtn_Copy_02.Enabled = False
        Me.cmdbtn_Copy_02.Location = New System.Drawing.Point(840, 72)
        Me.cmdbtn_Copy_02.Name = "cmdbtn_Copy_02"
        Me.cmdbtn_Copy_02.Size = New System.Drawing.Size(59, 29)
        Me.cmdbtn_Copy_02.TabIndex = 24
        Me.cmdbtn_Copy_02.Text = "Copy"
        Me.cmdbtn_Copy_02.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_02
        '
        Me.textbox_CopyLineCount_02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_02.Enabled = False
        Me.textbox_CopyLineCount_02.Location = New System.Drawing.Point(772, 74)
        Me.textbox_CopyLineCount_02.Name = "textbox_CopyLineCount_02"
        Me.textbox_CopyLineCount_02.Size = New System.Drawing.Size(62, 26)
        Me.textbox_CopyLineCount_02.TabIndex = 23
        '
        'lbl_textbox_CopyLineCount_02
        '
        Me.lbl_textbox_CopyLineCount_02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_02.AutoSize = True
        Me.lbl_textbox_CopyLineCount_02.Enabled = False
        Me.lbl_textbox_CopyLineCount_02.Location = New System.Drawing.Point(687, 75)
        Me.lbl_textbox_CopyLineCount_02.Name = "lbl_textbox_CopyLineCount_02"
        Me.lbl_textbox_CopyLineCount_02.Size = New System.Drawing.Size(73, 19)
        Me.lbl_textbox_CopyLineCount_02.TabIndex = 22
        Me.lbl_textbox_CopyLineCount_02.Text = "Line count"
        '
        'textbox_TextToCopy_02
        '
        Me.textbox_TextToCopy_02.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_02.Enabled = False
        Me.textbox_TextToCopy_02.Location = New System.Drawing.Point(63, 74)
        Me.textbox_TextToCopy_02.Name = "textbox_TextToCopy_02"
        Me.textbox_TextToCopy_02.Size = New System.Drawing.Size(618, 26)
        Me.textbox_TextToCopy_02.TabIndex = 21
        '
        'lbl_textbox_TextToCopy_02
        '
        Me.lbl_textbox_TextToCopy_02.AutoSize = True
        Me.lbl_textbox_TextToCopy_02.Enabled = False
        Me.lbl_textbox_TextToCopy_02.Location = New System.Drawing.Point(12, 77)
        Me.lbl_textbox_TextToCopy_02.Name = "lbl_textbox_TextToCopy_02"
        Me.lbl_textbox_TextToCopy_02.Size = New System.Drawing.Size(34, 19)
        Me.lbl_textbox_TextToCopy_02.TabIndex = 20
        Me.lbl_textbox_TextToCopy_02.Text = "Text"
        '
        'cmdbtn_Copy_03
        '
        Me.cmdbtn_Copy_03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdbtn_Copy_03.Enabled = False
        Me.cmdbtn_Copy_03.Location = New System.Drawing.Point(840, 104)
        Me.cmdbtn_Copy_03.Name = "cmdbtn_Copy_03"
        Me.cmdbtn_Copy_03.Size = New System.Drawing.Size(59, 29)
        Me.cmdbtn_Copy_03.TabIndex = 29
        Me.cmdbtn_Copy_03.Text = "Copy"
        Me.cmdbtn_Copy_03.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_03
        '
        Me.textbox_CopyLineCount_03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_03.Enabled = False
        Me.textbox_CopyLineCount_03.Location = New System.Drawing.Point(772, 106)
        Me.textbox_CopyLineCount_03.Name = "textbox_CopyLineCount_03"
        Me.textbox_CopyLineCount_03.Size = New System.Drawing.Size(62, 26)
        Me.textbox_CopyLineCount_03.TabIndex = 28
        '
        'lbl_textbox_CopyLineCount_03
        '
        Me.lbl_textbox_CopyLineCount_03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_03.AutoSize = True
        Me.lbl_textbox_CopyLineCount_03.Enabled = False
        Me.lbl_textbox_CopyLineCount_03.Location = New System.Drawing.Point(687, 107)
        Me.lbl_textbox_CopyLineCount_03.Name = "lbl_textbox_CopyLineCount_03"
        Me.lbl_textbox_CopyLineCount_03.Size = New System.Drawing.Size(73, 19)
        Me.lbl_textbox_CopyLineCount_03.TabIndex = 27
        Me.lbl_textbox_CopyLineCount_03.Text = "Line count"
        '
        'textbox_TextToCopy_03
        '
        Me.textbox_TextToCopy_03.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_03.Enabled = False
        Me.textbox_TextToCopy_03.Location = New System.Drawing.Point(63, 106)
        Me.textbox_TextToCopy_03.Name = "textbox_TextToCopy_03"
        Me.textbox_TextToCopy_03.Size = New System.Drawing.Size(618, 26)
        Me.textbox_TextToCopy_03.TabIndex = 26
        '
        'lbl_textbox_TextToCopy_03
        '
        Me.lbl_textbox_TextToCopy_03.AutoSize = True
        Me.lbl_textbox_TextToCopy_03.Enabled = False
        Me.lbl_textbox_TextToCopy_03.Location = New System.Drawing.Point(12, 109)
        Me.lbl_textbox_TextToCopy_03.Name = "lbl_textbox_TextToCopy_03"
        Me.lbl_textbox_TextToCopy_03.Size = New System.Drawing.Size(34, 19)
        Me.lbl_textbox_TextToCopy_03.TabIndex = 25
        Me.lbl_textbox_TextToCopy_03.Text = "Text"
        '
        'cmdbtn_Copy_04
        '
        Me.cmdbtn_Copy_04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdbtn_Copy_04.Enabled = False
        Me.cmdbtn_Copy_04.Location = New System.Drawing.Point(840, 136)
        Me.cmdbtn_Copy_04.Name = "cmdbtn_Copy_04"
        Me.cmdbtn_Copy_04.Size = New System.Drawing.Size(59, 29)
        Me.cmdbtn_Copy_04.TabIndex = 34
        Me.cmdbtn_Copy_04.Text = "Copy"
        Me.cmdbtn_Copy_04.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_04
        '
        Me.textbox_CopyLineCount_04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_04.Enabled = False
        Me.textbox_CopyLineCount_04.Location = New System.Drawing.Point(772, 138)
        Me.textbox_CopyLineCount_04.Name = "textbox_CopyLineCount_04"
        Me.textbox_CopyLineCount_04.Size = New System.Drawing.Size(62, 26)
        Me.textbox_CopyLineCount_04.TabIndex = 33
        '
        'lbl_textbox_CopyLineCount_04
        '
        Me.lbl_textbox_CopyLineCount_04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_04.AutoSize = True
        Me.lbl_textbox_CopyLineCount_04.Enabled = False
        Me.lbl_textbox_CopyLineCount_04.Location = New System.Drawing.Point(687, 139)
        Me.lbl_textbox_CopyLineCount_04.Name = "lbl_textbox_CopyLineCount_04"
        Me.lbl_textbox_CopyLineCount_04.Size = New System.Drawing.Size(73, 19)
        Me.lbl_textbox_CopyLineCount_04.TabIndex = 32
        Me.lbl_textbox_CopyLineCount_04.Text = "Line count"
        '
        'textbox_TextToCopy_04
        '
        Me.textbox_TextToCopy_04.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_04.Enabled = False
        Me.textbox_TextToCopy_04.Location = New System.Drawing.Point(63, 138)
        Me.textbox_TextToCopy_04.Name = "textbox_TextToCopy_04"
        Me.textbox_TextToCopy_04.Size = New System.Drawing.Size(618, 26)
        Me.textbox_TextToCopy_04.TabIndex = 31
        '
        'lbl_textbox_TextToCopy_04
        '
        Me.lbl_textbox_TextToCopy_04.AutoSize = True
        Me.lbl_textbox_TextToCopy_04.Enabled = False
        Me.lbl_textbox_TextToCopy_04.Location = New System.Drawing.Point(12, 141)
        Me.lbl_textbox_TextToCopy_04.Name = "lbl_textbox_TextToCopy_04"
        Me.lbl_textbox_TextToCopy_04.Size = New System.Drawing.Size(34, 19)
        Me.lbl_textbox_TextToCopy_04.TabIndex = 30
        Me.lbl_textbox_TextToCopy_04.Text = "Text"
        '
        'cmdbtn_Copy_05
        '
        Me.cmdbtn_Copy_05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdbtn_Copy_05.Enabled = False
        Me.cmdbtn_Copy_05.Location = New System.Drawing.Point(840, 168)
        Me.cmdbtn_Copy_05.Name = "cmdbtn_Copy_05"
        Me.cmdbtn_Copy_05.Size = New System.Drawing.Size(59, 29)
        Me.cmdbtn_Copy_05.TabIndex = 39
        Me.cmdbtn_Copy_05.Text = "Copy"
        Me.cmdbtn_Copy_05.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_05
        '
        Me.textbox_CopyLineCount_05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_05.Enabled = False
        Me.textbox_CopyLineCount_05.Location = New System.Drawing.Point(772, 170)
        Me.textbox_CopyLineCount_05.Name = "textbox_CopyLineCount_05"
        Me.textbox_CopyLineCount_05.Size = New System.Drawing.Size(62, 26)
        Me.textbox_CopyLineCount_05.TabIndex = 38
        '
        'lbl_textbox_CopyLineCount_05
        '
        Me.lbl_textbox_CopyLineCount_05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_05.AutoSize = True
        Me.lbl_textbox_CopyLineCount_05.Enabled = False
        Me.lbl_textbox_CopyLineCount_05.Location = New System.Drawing.Point(687, 171)
        Me.lbl_textbox_CopyLineCount_05.Name = "lbl_textbox_CopyLineCount_05"
        Me.lbl_textbox_CopyLineCount_05.Size = New System.Drawing.Size(73, 19)
        Me.lbl_textbox_CopyLineCount_05.TabIndex = 37
        Me.lbl_textbox_CopyLineCount_05.Text = "Line count"
        '
        'textbox_TextToCopy_05
        '
        Me.textbox_TextToCopy_05.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_05.Enabled = False
        Me.textbox_TextToCopy_05.Location = New System.Drawing.Point(63, 170)
        Me.textbox_TextToCopy_05.Name = "textbox_TextToCopy_05"
        Me.textbox_TextToCopy_05.Size = New System.Drawing.Size(618, 26)
        Me.textbox_TextToCopy_05.TabIndex = 36
        '
        'lbl_textbox_TextToCopy_05
        '
        Me.lbl_textbox_TextToCopy_05.AutoSize = True
        Me.lbl_textbox_TextToCopy_05.Enabled = False
        Me.lbl_textbox_TextToCopy_05.Location = New System.Drawing.Point(12, 173)
        Me.lbl_textbox_TextToCopy_05.Name = "lbl_textbox_TextToCopy_05"
        Me.lbl_textbox_TextToCopy_05.Size = New System.Drawing.Size(34, 19)
        Me.lbl_textbox_TextToCopy_05.TabIndex = 35
        Me.lbl_textbox_TextToCopy_05.Text = "Text"
        '
        'cmdbtn_Copy_06
        '
        Me.cmdbtn_Copy_06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdbtn_Copy_06.Enabled = False
        Me.cmdbtn_Copy_06.Location = New System.Drawing.Point(840, 200)
        Me.cmdbtn_Copy_06.Name = "cmdbtn_Copy_06"
        Me.cmdbtn_Copy_06.Size = New System.Drawing.Size(59, 29)
        Me.cmdbtn_Copy_06.TabIndex = 44
        Me.cmdbtn_Copy_06.Text = "Copy"
        Me.cmdbtn_Copy_06.UseVisualStyleBackColor = True
        '
        'textbox_CopyLineCount_06
        '
        Me.textbox_CopyLineCount_06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_CopyLineCount_06.Enabled = False
        Me.textbox_CopyLineCount_06.Location = New System.Drawing.Point(772, 202)
        Me.textbox_CopyLineCount_06.Name = "textbox_CopyLineCount_06"
        Me.textbox_CopyLineCount_06.Size = New System.Drawing.Size(62, 26)
        Me.textbox_CopyLineCount_06.TabIndex = 43
        '
        'lbl_textbox_CopyLineCount_06
        '
        Me.lbl_textbox_CopyLineCount_06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_textbox_CopyLineCount_06.AutoSize = True
        Me.lbl_textbox_CopyLineCount_06.Enabled = False
        Me.lbl_textbox_CopyLineCount_06.Location = New System.Drawing.Point(687, 203)
        Me.lbl_textbox_CopyLineCount_06.Name = "lbl_textbox_CopyLineCount_06"
        Me.lbl_textbox_CopyLineCount_06.Size = New System.Drawing.Size(73, 19)
        Me.lbl_textbox_CopyLineCount_06.TabIndex = 42
        Me.lbl_textbox_CopyLineCount_06.Text = "Line count"
        '
        'textbox_TextToCopy_06
        '
        Me.textbox_TextToCopy_06.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_TextToCopy_06.Enabled = False
        Me.textbox_TextToCopy_06.Location = New System.Drawing.Point(63, 202)
        Me.textbox_TextToCopy_06.Name = "textbox_TextToCopy_06"
        Me.textbox_TextToCopy_06.Size = New System.Drawing.Size(618, 26)
        Me.textbox_TextToCopy_06.TabIndex = 41
        '
        'lbl_textbox_TextToCopy_06
        '
        Me.lbl_textbox_TextToCopy_06.AutoSize = True
        Me.lbl_textbox_TextToCopy_06.Enabled = False
        Me.lbl_textbox_TextToCopy_06.Location = New System.Drawing.Point(12, 205)
        Me.lbl_textbox_TextToCopy_06.Name = "lbl_textbox_TextToCopy_06"
        Me.lbl_textbox_TextToCopy_06.Size = New System.Drawing.Size(34, 19)
        Me.lbl_textbox_TextToCopy_06.TabIndex = 40
        Me.lbl_textbox_TextToCopy_06.Text = "Text"
        '
        'm_cmdbtn_BackupFile
        '
        Me.m_cmdbtn_BackupFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m_cmdbtn_BackupFile.Location = New System.Drawing.Point(824, 4)
        Me.m_cmdbtn_BackupFile.Name = "m_cmdbtn_BackupFile"
        Me.m_cmdbtn_BackupFile.Size = New System.Drawing.Size(75, 29)
        Me.m_cmdbtn_BackupFile.TabIndex = 45
        Me.m_cmdbtn_BackupFile.Text = "Backup"
        Me.m_cmdbtn_BackupFile.UseVisualStyleBackColor = True
        '
        'm_text_PathedFileName_Info
        '
        Me.m_text_PathedFileName_Info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m_text_PathedFileName_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_text_PathedFileName_Info.Location = New System.Drawing.Point(642, 7)
        Me.m_text_PathedFileName_Info.Name = "m_text_PathedFileName_Info"
        Me.m_text_PathedFileName_Info.Size = New System.Drawing.Size(176, 26)
        Me.m_text_PathedFileName_Info.TabIndex = 46
        '
        'frm_PhotoOrbit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 531)
        Me.Controls.Add(Me.m_text_PathedFileName_Info)
        Me.Controls.Add(Me.m_cmdbtn_BackupFile)
        Me.Controls.Add(Me.cmdbtn_Copy_06)
        Me.Controls.Add(Me.textbox_CopyLineCount_06)
        Me.Controls.Add(Me.lbl_textbox_CopyLineCount_06)
        Me.Controls.Add(Me.textbox_TextToCopy_06)
        Me.Controls.Add(Me.lbl_textbox_TextToCopy_06)
        Me.Controls.Add(Me.cmdbtn_Copy_05)
        Me.Controls.Add(Me.textbox_CopyLineCount_05)
        Me.Controls.Add(Me.lbl_textbox_CopyLineCount_05)
        Me.Controls.Add(Me.textbox_TextToCopy_05)
        Me.Controls.Add(Me.lbl_textbox_TextToCopy_05)
        Me.Controls.Add(Me.cmdbtn_Copy_04)
        Me.Controls.Add(Me.textbox_CopyLineCount_04)
        Me.Controls.Add(Me.lbl_textbox_CopyLineCount_04)
        Me.Controls.Add(Me.textbox_TextToCopy_04)
        Me.Controls.Add(Me.lbl_textbox_TextToCopy_04)
        Me.Controls.Add(Me.cmdbtn_Copy_03)
        Me.Controls.Add(Me.textbox_CopyLineCount_03)
        Me.Controls.Add(Me.lbl_textbox_CopyLineCount_03)
        Me.Controls.Add(Me.textbox_TextToCopy_03)
        Me.Controls.Add(Me.lbl_textbox_TextToCopy_03)
        Me.Controls.Add(Me.cmdbtn_Copy_02)
        Me.Controls.Add(Me.textbox_CopyLineCount_02)
        Me.Controls.Add(Me.lbl_textbox_CopyLineCount_02)
        Me.Controls.Add(Me.textbox_TextToCopy_02)
        Me.Controls.Add(Me.lbl_textbox_TextToCopy_02)
        Me.Controls.Add(Me.cmdbtn_Copy_01)
        Me.Controls.Add(Me.textbox_CopyLineCount_01)
        Me.Controls.Add(Me.lbl_textbox_CopyLineCount_01)
        Me.Controls.Add(Me.textbox_TextToCopy_01)
        Me.Controls.Add(Me.lbl_textbox_TextToCopy_01)
        Me.Controls.Add(Me.m_cmdbtn_GatherSubFolderFiles)
        Me.Controls.Add(Me.oSplitContainer_01)
        Me.Controls.Add(Me.cmdbtn_Rename)
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
        Me.oSplitContainer_Right.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Right.Panel1.PerformLayout()
        Me.oSplitContainer_Right.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Right.ResumeLayout(False)
        Me.oSplitContainer_Viewer.Panel1.ResumeLayout(False)
        Me.oSplitContainer_Viewer.Panel2.ResumeLayout(False)
        CType(Me.oSplitContainer_Viewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oSplitContainer_Viewer.ResumeLayout(False)
        CType(Me.mplayer_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdbtn_Rename As System.Windows.Forms.Button
  Friend WithEvents cmdbtn_RotateRight As System.Windows.Forms.Button
  Friend WithEvents cmdbtn_RotateLeft As System.Windows.Forms.Button
  Friend WithEvents dirtree_01 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
  Friend WithEvents m_oFileListBox_01 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
  Friend WithEvents oTextBox_Info As System.Windows.Forms.TextBox
  Friend WithEvents pic_01 As System.Windows.Forms.PictureBox
  Friend WithEvents oSplitContainer_01 As System.Windows.Forms.SplitContainer
  Friend WithEvents oSplitContainer_Left As System.Windows.Forms.SplitContainer
  Friend WithEvents oSplitContainer_Right As System.Windows.Forms.SplitContainer
  Friend WithEvents cmdbtn_CreateInfoFile As System.Windows.Forms.Button
  Friend WithEvents m_cmdbtn_GatherSubFolderFiles As System.Windows.Forms.Button
  Friend WithEvents lbl_textbox_TextToCopy_01 As System.Windows.Forms.Label
  Friend WithEvents textbox_TextToCopy_01 As System.Windows.Forms.TextBox
  Friend WithEvents textbox_CopyLineCount_01 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_CopyLineCount_01 As System.Windows.Forms.Label
  Friend WithEvents cmdbtn_Copy_01 As System.Windows.Forms.Button
  Friend WithEvents cmdbtn_Copy_02 As System.Windows.Forms.Button
  Friend WithEvents textbox_CopyLineCount_02 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_CopyLineCount_02 As System.Windows.Forms.Label
  Friend WithEvents textbox_TextToCopy_02 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_TextToCopy_02 As System.Windows.Forms.Label
  Friend WithEvents cmdbtn_Copy_03 As System.Windows.Forms.Button
  Friend WithEvents textbox_CopyLineCount_03 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_CopyLineCount_03 As System.Windows.Forms.Label
  Friend WithEvents textbox_TextToCopy_03 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_TextToCopy_03 As System.Windows.Forms.Label
  Friend WithEvents cmdbtn_Copy_04 As System.Windows.Forms.Button
  Friend WithEvents textbox_CopyLineCount_04 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_CopyLineCount_04 As System.Windows.Forms.Label
  Friend WithEvents textbox_TextToCopy_04 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_TextToCopy_04 As System.Windows.Forms.Label
  Friend WithEvents cmdbtn_Copy_05 As System.Windows.Forms.Button
  Friend WithEvents textbox_CopyLineCount_05 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_CopyLineCount_05 As System.Windows.Forms.Label
  Friend WithEvents textbox_TextToCopy_05 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_TextToCopy_05 As System.Windows.Forms.Label
  Friend WithEvents cmdbtn_Copy_06 As System.Windows.Forms.Button
  Friend WithEvents textbox_CopyLineCount_06 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_CopyLineCount_06 As System.Windows.Forms.Label
  Friend WithEvents textbox_TextToCopy_06 As System.Windows.Forms.TextBox
  Friend WithEvents lbl_textbox_TextToCopy_06 As System.Windows.Forms.Label
  Friend WithEvents m_cmdbtn_BackupFile As System.Windows.Forms.Button
  Friend WithEvents m_text_PathedFileName_Info As System.Windows.Forms.TextBox
    Friend WithEvents btn_Now As Button
    Friend WithEvents mplayer_01 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents oSplitContainer_Viewer As SplitContainer
    Friend WithEvents oListBox_Properties As ListBox
End Class
