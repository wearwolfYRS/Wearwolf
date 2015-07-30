<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Page))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAllOutfits = New System.Windows.Forms.Button()
        Me.btnFave = New System.Windows.Forms.Button()
        Me.btnAddOutfit = New System.Windows.Forms.Button()
        Me.btnSuggestions = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnWish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 186)
        Me.Label1.MaximumSize = New System.Drawing.Size(700, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the program that allows you to organise your"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(318, 224)
        Me.Label2.MaximumSize = New System.Drawing.Size(700, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(373, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "wardrobe and plan different outfits"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(57, 316)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(133, 45)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAllOutfits
        '
        Me.btnAllOutfits.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllOutfits.Location = New System.Drawing.Point(281, 316)
        Me.btnAllOutfits.Name = "btnAllOutfits"
        Me.btnAllOutfits.Size = New System.Drawing.Size(133, 45)
        Me.btnAllOutfits.TabIndex = 3
        Me.btnAllOutfits.Text = "All Outfits"
        Me.btnAllOutfits.UseVisualStyleBackColor = True
        '
        'btnFave
        '
        Me.btnFave.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFave.Location = New System.Drawing.Point(506, 316)
        Me.btnFave.Name = "btnFave"
        Me.btnFave.Size = New System.Drawing.Size(133, 45)
        Me.btnFave.TabIndex = 4
        Me.btnFave.Text = "Favourite Outfits"
        Me.btnFave.UseVisualStyleBackColor = True
        '
        'btnAddOutfit
        '
        Me.btnAddOutfit.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOutfit.Location = New System.Drawing.Point(168, 421)
        Me.btnAddOutfit.Name = "btnAddOutfit"
        Me.btnAddOutfit.Size = New System.Drawing.Size(133, 45)
        Me.btnAddOutfit.TabIndex = 5
        Me.btnAddOutfit.Text = "Add an Outfit"
        Me.btnAddOutfit.UseVisualStyleBackColor = True
        '
        'btnSuggestions
        '
        Me.btnSuggestions.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuggestions.Location = New System.Drawing.Point(394, 421)
        Me.btnSuggestions.Name = "btnSuggestions"
        Me.btnSuggestions.Size = New System.Drawing.Size(133, 45)
        Me.btnSuggestions.TabIndex = 6
        Me.btnSuggestions.Text = "Suggestions?"
        Me.btnSuggestions.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 69.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 171)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MENU"
        '
        'btnWish
        '
        Me.btnWish.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWish.Location = New System.Drawing.Point(281, 516)
        Me.btnWish.Name = "btnWish"
        Me.btnWish.Size = New System.Drawing.Size(133, 45)
        Me.btnWish.TabIndex = 8
        Me.btnWish.Text = "Wish List"
        Me.btnWish.UseVisualStyleBackColor = True
        '
        'Menu_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(712, 598)
        Me.Controls.Add(Me.btnWish)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSuggestions)
        Me.Controls.Add(Me.btnAddOutfit)
        Me.Controls.Add(Me.btnFave)
        Me.Controls.Add(Me.btnAllOutfits)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu_Page"
        Me.Text = "Menu_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnAllOutfits As System.Windows.Forms.Button
    Friend WithEvents btnFave As System.Windows.Forms.Button
    Friend WithEvents btnAddOutfit As System.Windows.Forms.Button
    Friend WithEvents btnSuggestions As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnWish As System.Windows.Forms.Button
End Class
