<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class All_Outfits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(All_Outfits))
        Me.pictureboxAll = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUndoDelete = New System.Windows.Forms.Button()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.btnNextAll = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFavourite = New System.Windows.Forms.Button()
        CType(Me.pictureboxAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureboxAll
        '
        Me.pictureboxAll.BackColor = System.Drawing.Color.Transparent
        Me.pictureboxAll.Location = New System.Drawing.Point(59, 80)
        Me.pictureboxAll.Name = "pictureboxAll"
        Me.pictureboxAll.Size = New System.Drawing.Size(318, 492)
        Me.pictureboxAll.TabIndex = 0
        Me.pictureboxAll.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 68)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "All Outfits"
        '
        'btnUndoDelete
        '
        Me.btnUndoDelete.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndoDelete.Location = New System.Drawing.Point(416, 524)
        Me.btnUndoDelete.Name = "btnUndoDelete"
        Me.btnUndoDelete.Size = New System.Drawing.Size(85, 48)
        Me.btnUndoDelete.TabIndex = 16
        Me.btnUndoDelete.Text = "Undo"
        Me.btnUndoDelete.UseVisualStyleBackColor = True
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.Location = New System.Drawing.Point(416, 451)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(85, 48)
        Me.btnDeleteAll.TabIndex = 15
        Me.btnDeleteAll.Text = "Delete"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'btnBackAll
        '
        Me.btnBackAll.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackAll.Location = New System.Drawing.Point(416, 376)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(85, 48)
        Me.btnBackAll.TabIndex = 14
        Me.btnBackAll.Text = "Back to Menu"
        Me.btnBackAll.UseVisualStyleBackColor = True
        '
        'btnNextAll
        '
        Me.btnNextAll.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextAll.Location = New System.Drawing.Point(426, 29)
        Me.btnNextAll.Name = "btnNextAll"
        Me.btnNextAll.Size = New System.Drawing.Size(96, 48)
        Me.btnNextAll.TabIndex = 13
        Me.btnNextAll.Text = "Next Outfit"
        Me.btnNextAll.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(324, 29)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(96, 48)
        Me.btnPrevious.TabIndex = 17
        Me.btnPrevious.Text = "Previous Outfit"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFavourite
        '
        Me.btnFavourite.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavourite.Location = New System.Drawing.Point(405, 106)
        Me.btnFavourite.Name = "btnFavourite"
        Me.btnFavourite.Size = New System.Drawing.Size(117, 48)
        Me.btnFavourite.TabIndex = 18
        Me.btnFavourite.Text = "Favourite this Outfit"
        Me.btnFavourite.UseVisualStyleBackColor = True
        '
        'All_Outfits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(534, 612)
        Me.Controls.Add(Me.btnFavourite)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnUndoDelete)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnNextAll)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pictureboxAll)
        Me.Name = "All_Outfits"
        Me.Text = "All_Outfits"
        CType(Me.pictureboxAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pictureboxAll As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUndoDelete As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents btnBackAll As System.Windows.Forms.Button
    Friend WithEvents btnNextAll As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFavourite As System.Windows.Forms.Button
End Class
