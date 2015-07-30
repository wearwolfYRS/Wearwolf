<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Page))
        Me.pictureboxOutfit = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comboCity = New System.Windows.Forms.ComboBox()
        Me.comboOccasion = New System.Windows.Forms.ComboBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.comboSeason = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNextOutfit = New System.Windows.Forms.Button()
        Me.lblWeather = New System.Windows.Forms.Label()
        Me.btnPreviousSearch = New System.Windows.Forms.Button()
        CType(Me.pictureboxOutfit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureboxOutfit
        '
        Me.pictureboxOutfit.BackColor = System.Drawing.Color.Transparent
        Me.pictureboxOutfit.Location = New System.Drawing.Point(593, 12)
        Me.pictureboxOutfit.Name = "pictureboxOutfit"
        Me.pictureboxOutfit.Size = New System.Drawing.Size(323, 533)
        Me.pictureboxOutfit.TabIndex = 0
        Me.pictureboxOutfit.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(326, 68)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Search for Today's Outfit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fill in the relevent boxes below..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "The boxes with asteriks (*) are compulsory."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Where are you going? *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Occasion/Theme *"
        '
        'comboCity
        '
        Me.comboCity.FormattingEnabled = True
        Me.comboCity.Items.AddRange(New Object() {"Aberdeen", "Birmingham", "Cambridge", "London"})
        Me.comboCity.Location = New System.Drawing.Point(244, 199)
        Me.comboCity.Name = "comboCity"
        Me.comboCity.Size = New System.Drawing.Size(168, 21)
        Me.comboCity.TabIndex = 15
        '
        'comboOccasion
        '
        Me.comboOccasion.FormattingEnabled = True
        Me.comboOccasion.Items.AddRange(New Object() {"Party", "Formal", "Casual"})
        Me.comboOccasion.Location = New System.Drawing.Point(244, 292)
        Me.comboOccasion.Name = "comboOccasion"
        Me.comboOccasion.Size = New System.Drawing.Size(168, 21)
        Me.comboOccasion.TabIndex = 18
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(275, 523)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(104, 55)
        Me.btnGo.TabIndex = 19
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(67, 523)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 55)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'comboSeason
        '
        Me.comboSeason.FormattingEnabled = True
        Me.comboSeason.Items.AddRange(New Object() {"Spring", "Summer", "Autumn", "Winter", "All"})
        Me.comboSeason.Location = New System.Drawing.Point(244, 376)
        Me.comboSeason.Name = "comboSeason"
        Me.comboSeason.Size = New System.Drawing.Size(168, 21)
        Me.comboSeason.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 28)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Season *"
        '
        'btnNextOutfit
        '
        Me.btnNextOutfit.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextOutfit.Location = New System.Drawing.Point(385, 415)
        Me.btnNextOutfit.Name = "btnNextOutfit"
        Me.btnNextOutfit.Size = New System.Drawing.Size(202, 55)
        Me.btnNextOutfit.TabIndex = 25
        Me.btnNextOutfit.Text = "Next Outfit"
        Me.btnNextOutfit.UseVisualStyleBackColor = True
        '
        'lblWeather
        '
        Me.lblWeather.AutoSize = True
        Me.lblWeather.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeather.Location = New System.Drawing.Point(54, 442)
        Me.lblWeather.Name = "lblWeather"
        Me.lblWeather.Size = New System.Drawing.Size(0, 28)
        Me.lblWeather.TabIndex = 26
        '
        'btnPreviousSearch
        '
        Me.btnPreviousSearch.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousSearch.Location = New System.Drawing.Point(385, 476)
        Me.btnPreviousSearch.Name = "btnPreviousSearch"
        Me.btnPreviousSearch.Size = New System.Drawing.Size(202, 55)
        Me.btnPreviousSearch.TabIndex = 27
        Me.btnPreviousSearch.Text = "Previous Outfit"
        Me.btnPreviousSearch.UseVisualStyleBackColor = True
        '
        'Search_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(949, 584)
        Me.Controls.Add(Me.btnPreviousSearch)
        Me.Controls.Add(Me.lblWeather)
        Me.Controls.Add(Me.btnNextOutfit)
        Me.Controls.Add(Me.comboSeason)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.comboOccasion)
        Me.Controls.Add(Me.comboCity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pictureboxOutfit)
        Me.Name = "Search_Page"
        Me.Text = "Search Page"
        CType(Me.pictureboxOutfit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pictureboxOutfit As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents comboCity As System.Windows.Forms.ComboBox
    Friend WithEvents comboOccasion As System.Windows.Forms.ComboBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents comboSeason As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnNextOutfit As System.Windows.Forms.Button
    Friend WithEvents lblWeather As System.Windows.Forms.Label
    Friend WithEvents btnPreviousSearch As System.Windows.Forms.Button
End Class
