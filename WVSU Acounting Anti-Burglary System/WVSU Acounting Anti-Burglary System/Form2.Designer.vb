<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.taskbarPanel = New System.Windows.Forms.Panel()
        Me.TitleTB = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        Me.taskbarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel1.Controls.Add(Me.taskbarPanel)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 600)
        Me.Panel1.TabIndex = 0
        '
        'taskbarPanel
        '
        Me.taskbarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.taskbarPanel.Controls.Add(Me.TitleTB)
        Me.taskbarPanel.Location = New System.Drawing.Point(3, 3)
        Me.taskbarPanel.Name = "taskbarPanel"
        Me.taskbarPanel.Size = New System.Drawing.Size(794, 42)
        Me.taskbarPanel.TabIndex = 1
        '
        'TitleTB
        '
        Me.TitleTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TitleTB.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTB.ForeColor = System.Drawing.Color.White
        Me.TitleTB.HintForeColor = System.Drawing.Color.Empty
        Me.TitleTB.HintText = ""
        Me.TitleTB.isPassword = False
        Me.TitleTB.LineFocusedColor = System.Drawing.Color.Blue
        Me.TitleTB.LineIdleColor = System.Drawing.Color.Gray
        Me.TitleTB.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TitleTB.LineThickness = 3
        Me.TitleTB.Location = New System.Drawing.Point(-3, 8)
        Me.TitleTB.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleTB.Name = "TitleTB"
        Me.TitleTB.Size = New System.Drawing.Size(793, 35)
        Me.TitleTB.TabIndex = 2
        Me.TitleTB.Text = "WVSU Accounting Anti-Burglary System"
        Me.TitleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.taskbarPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents taskbarPanel As System.Windows.Forms.Panel
    Friend WithEvents TitleTB As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
