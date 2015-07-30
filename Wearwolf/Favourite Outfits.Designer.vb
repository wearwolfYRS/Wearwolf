<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Favourite_Outfits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Favourite_Outfits))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pictureboxFave = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnPreviousFave = New System.Windows.Forms.Button()
        CType(Me.pictureboxFave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 68)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Favourite Outfits"
        '
        'pictureboxFave
        '
        Me.pictureboxFave.BackColor = System.Drawing.Color.Transparent
        Me.pictureboxFave.Location = New System.Drawing.Point(59, 69)
        Me.pictureboxFave.Name = "pictureboxFave"
        Me.pictureboxFave.Size = New System.Drawing.Size(318, 492)
        Me.pictureboxFave.TabIndex = 8
        Me.pictureboxFave.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(418, 464)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 48)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back to Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(418, 9)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(85, 48)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next Outfit"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(408, 123)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 67)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Remove From Favourites"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.Location = New System.Drawing.Point(408, 211)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(114, 48)
        Me.btnUndo.TabIndex = 12
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnPreviousFave
        '
        Me.btnPreviousFave.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousFave.Location = New System.Drawing.Point(303, 9)
        Me.btnPreviousFave.Name = "btnPreviousFave"
        Me.btnPreviousFave.Size = New System.Drawing.Size(89, 48)
        Me.btnPreviousFave.TabIndex = 13
        Me.btnPreviousFave.Text = "Previous Outfit"
        Me.btnPreviousFave.UseVisualStyleBackColor = True
        '
        'Favourite_Outfits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(534, 612)
        Me.Controls.Add(Me.btnPreviousFave)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.pictureboxFave)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Favourite_Outfits"
        Me.Text = "Favourite_Outfits"
        CType(Me.pictureboxFave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pictureboxFave As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents btnPreviousFave As System.Windows.Forms.Button
End Class
