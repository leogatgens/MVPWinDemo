<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vista
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
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(800, 450)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.Text = "RadPanel1"
        '
        'RadPanel2
        '
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(800, 100)
        Me.RadPanel2.TabIndex = 1
        Me.RadPanel2.Text = "RadPanel2"
        '
        'RadPanel3
        '
        Me.RadPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel3.Location = New System.Drawing.Point(0, 100)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(800, 350)
        Me.RadPanel3.TabIndex = 2
        Me.RadPanel3.Text = "RadPanel3"
        '
        'RadPanel4
        '
        Me.RadPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel4.Location = New System.Drawing.Point(0, 431)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(800, 19)
        Me.RadPanel4.TabIndex = 3
        Me.RadPanel4.Text = "RadPanel4"
        '
        'RadPanel5
        '
        Me.RadPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel5.Location = New System.Drawing.Point(0, 100)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(800, 331)
        Me.RadPanel5.TabIndex = 4
        Me.RadPanel5.Text = "RadPanel5"
        '
        'Vista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadPanel5)
        Me.Controls.Add(Me.RadPanel4)
        Me.Controls.Add(Me.RadPanel3)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "Vista"
        Me.Text = "Form1"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
End Class
