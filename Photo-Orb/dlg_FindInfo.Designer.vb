<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_FindInfo
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.oTextBox_TextToSearchFor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkbox_StillPhotos = New System.Windows.Forms.CheckBox()
        Me.chkbox_Movies = New System.Windows.Forms.CheckBox()
        Me.chkbox_CaseSensitive = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 145)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'oTextBox_TextToSearchFor
        '
        Me.oTextBox_TextToSearchFor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oTextBox_TextToSearchFor.Location = New System.Drawing.Point(13, 35)
        Me.oTextBox_TextToSearchFor.Name = "oTextBox_TextToSearchFor"
        Me.oTextBox_TextToSearchFor.Size = New System.Drawing.Size(410, 20)
        Me.oTextBox_TextToSearchFor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Text to search for:"
        '
        'chkbox_StillPhotos
        '
        Me.chkbox_StillPhotos.AutoSize = True
        Me.chkbox_StillPhotos.Checked = True
        Me.chkbox_StillPhotos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbox_StillPhotos.Location = New System.Drawing.Point(13, 70)
        Me.chkbox_StillPhotos.Name = "chkbox_StillPhotos"
        Me.chkbox_StillPhotos.Size = New System.Drawing.Size(78, 17)
        Me.chkbox_StillPhotos.TabIndex = 3
        Me.chkbox_StillPhotos.Text = "Still Photos"
        Me.chkbox_StillPhotos.UseVisualStyleBackColor = True
        '
        'chkbox_Movies
        '
        Me.chkbox_Movies.AutoSize = True
        Me.chkbox_Movies.Checked = True
        Me.chkbox_Movies.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbox_Movies.Location = New System.Drawing.Point(13, 93)
        Me.chkbox_Movies.Name = "chkbox_Movies"
        Me.chkbox_Movies.Size = New System.Drawing.Size(60, 17)
        Me.chkbox_Movies.TabIndex = 4
        Me.chkbox_Movies.Text = "Movies"
        Me.chkbox_Movies.UseVisualStyleBackColor = True
        '
        'chkbox_CaseSensitive
        '
        Me.chkbox_CaseSensitive.AutoSize = True
        Me.chkbox_CaseSensitive.Location = New System.Drawing.Point(13, 116)
        Me.chkbox_CaseSensitive.Name = "chkbox_CaseSensitive"
        Me.chkbox_CaseSensitive.Size = New System.Drawing.Size(96, 17)
        Me.chkbox_CaseSensitive.TabIndex = 5
        Me.chkbox_CaseSensitive.Text = "Case Sensitive"
        Me.chkbox_CaseSensitive.UseVisualStyleBackColor = True
        '
        'dlg_FindInfo
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 186)
        Me.Controls.Add(Me.chkbox_CaseSensitive)
        Me.Controls.Add(Me.chkbox_Movies)
        Me.Controls.Add(Me.chkbox_StillPhotos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.oTextBox_TextToSearchFor)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_FindInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Info"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents oTextBox_TextToSearchFor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkbox_StillPhotos As CheckBox
    Friend WithEvents chkbox_Movies As CheckBox
    Friend WithEvents chkbox_CaseSensitive As CheckBox
End Class
