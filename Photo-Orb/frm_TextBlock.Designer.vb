<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TextBlock
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
        Me.textbox_01 = New System.Windows.Forms.RichTextBox()
        Me.btn_01 = New System.Windows.Forms.Button()
        Me.btn_02 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textbox_01
        '
        Me.textbox_01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textbox_01.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_01.Location = New System.Drawing.Point(0, 0)
        Me.textbox_01.Name = "textbox_01"
        Me.textbox_01.Size = New System.Drawing.Size(539, 445)
        Me.textbox_01.TabIndex = 0
        Me.textbox_01.Text = ""
        '
        'btn_01
        '
        Me.btn_01.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_01.Location = New System.Drawing.Point(12, 451)
        Me.btn_01.Name = "btn_01"
        Me.btn_01.Size = New System.Drawing.Size(75, 23)
        Me.btn_01.TabIndex = 1
        Me.btn_01.Text = "01"
        Me.btn_01.UseVisualStyleBackColor = True
        Me.btn_01.Visible = False
        '
        'btn_02
        '
        Me.btn_02.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_02.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_02.Location = New System.Drawing.Point(93, 451)
        Me.btn_02.Name = "btn_02"
        Me.btn_02.Size = New System.Drawing.Size(75, 23)
        Me.btn_02.TabIndex = 2
        Me.btn_02.Text = "02"
        Me.btn_02.UseVisualStyleBackColor = True
        Me.btn_02.Visible = False
        '
        'frm_TextBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 484)
        Me.Controls.Add(Me.btn_02)
        Me.Controls.Add(Me.btn_01)
        Me.Controls.Add(Me.textbox_01)
        Me.Name = "frm_TextBlock"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents textbox_01 As RichTextBox
    Friend WithEvents btn_01 As Button
    Friend WithEvents btn_02 As Button
End Class
