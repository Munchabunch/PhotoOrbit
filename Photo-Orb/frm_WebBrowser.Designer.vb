<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_WebBrowser
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
        Me.oWebBrowser_01 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'oWebBrowser_01
        '
        Me.oWebBrowser_01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oWebBrowser_01.Location = New System.Drawing.Point(0, 0)
        Me.oWebBrowser_01.MinimumSize = New System.Drawing.Size(20, 20)
        Me.oWebBrowser_01.Name = "oWebBrowser_01"
        Me.oWebBrowser_01.Size = New System.Drawing.Size(501, 446)
        Me.oWebBrowser_01.TabIndex = 0
        '
        'frm_WebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 446)
        Me.Controls.Add(Me.oWebBrowser_01)
        Me.Name = "frm_WebBrowser"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents oWebBrowser_01 As WebBrowser
End Class
