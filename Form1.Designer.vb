<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picHours = New System.Windows.Forms.PictureBox()
        Me.btnHours = New System.Windows.Forms.Button()
        Me.ShowAndClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 595)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(887, 555)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(169, 52)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&XIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(552, 100)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(447, 153)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'picHours
        '
        Me.picHours.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.picHours.Image = CType(resources.GetObject("picHours.Image"), System.Drawing.Image)
        Me.picHours.Location = New System.Drawing.Point(505, 269)
        Me.picHours.Name = "picHours"
        Me.picHours.Size = New System.Drawing.Size(533, 220)
        Me.picHours.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHours.TabIndex = 3
        Me.picHours.TabStop = False
        '
        'btnHours
        '
        Me.btnHours.AccessibleName = "BtnHoursOpen"
        Me.btnHours.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHours.Location = New System.Drawing.Point(712, 555)
        Me.btnHours.Name = "btnHours"
        Me.btnHours.Size = New System.Drawing.Size(169, 52)
        Me.btnHours.TabIndex = 4
        Me.btnHours.Text = "&Hours"
        Me.btnHours.UseVisualStyleBackColor = True
        '
        'ShowAndClose
        '
        Me.ShowAndClose.AccessibleName = ""
        Me.ShowAndClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowAndClose.Location = New System.Drawing.Point(537, 555)
        Me.ShowAndClose.Name = "ShowAndClose"
        Me.ShowAndClose.Size = New System.Drawing.Size(169, 52)
        Me.ShowAndClose.TabIndex = 5
        Me.ShowAndClose.Text = "&More Choices"
        Me.ShowAndClose.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1085, 619)
        Me.Controls.Add(Me.ShowAndClose)
        Me.Controls.Add(Me.btnHours)
        Me.Controls.Add(Me.picHours)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P.Cessna - Florist Haven"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picHours As PictureBox
    Friend WithEvents btnHours As Button
    Friend WithEvents ShowAndClose As Button
End Class
