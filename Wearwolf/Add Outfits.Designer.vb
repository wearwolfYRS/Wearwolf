<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Outfit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create_Outfit))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pictureboxAddOutfit = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.comboOccasion = New System.Windows.Forms.ComboBox()
        Me.comboSeason = New System.Windows.Forms.ComboBox()
        Me.comboWeather = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClearText = New System.Windows.Forms.Button()
        CType(Me.pictureboxAddOutfit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 65)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Add an Outfit"
        '
        'pictureboxAddOutfit
        '
        Me.pictureboxAddOutfit.BackColor = System.Drawing.Color.Transparent
        Me.pictureboxAddOutfit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureboxAddOutfit.Location = New System.Drawing.Point(195, 92)
        Me.pictureboxAddOutfit.Name = "pictureboxAddOutfit"
        Me.pictureboxAddOutfit.Size = New System.Drawing.Size(306, 468)
        Me.pictureboxAddOutfit.TabIndex = 7
        Me.pictureboxAddOutfit.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(575, 387)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(200, 38)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add Outfit"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(523, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 28)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Occasion/Theme"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(556, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Season"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(556, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 28)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Weather"
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(696, 458)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(95, 56)
        Me.btnClearAll.TabIndex = 20
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(46, 104)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(102, 67)
        Me.btnUpload.TabIndex = 8
        Me.btnUpload.Text = "Upload Photo of Outfit"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'comboOccasion
        '
        Me.comboOccasion.FormattingEnabled = True
        Me.comboOccasion.Items.AddRange(New Object() {"Party", "Formal", "Casual"})
        Me.comboOccasion.Location = New System.Drawing.Point(686, 246)
        Me.comboOccasion.Name = "comboOccasion"
        Me.comboOccasion.Size = New System.Drawing.Size(121, 21)
        Me.comboOccasion.TabIndex = 23
        '
        'comboSeason
        '
        Me.comboSeason.FormattingEnabled = True
        Me.comboSeason.Items.AddRange(New Object() {"Spring", "Summer", "Autumn", "Winter", "All"})
        Me.comboSeason.Location = New System.Drawing.Point(686, 289)
        Me.comboSeason.Name = "comboSeason"
        Me.comboSeason.Size = New System.Drawing.Size(121, 21)
        Me.comboSeason.TabIndex = 24
        '
        'comboWeather
        '
        Me.comboWeather.FormattingEnabled = True
        Me.comboWeather.Items.AddRange(New Object() {"Rain", "Cold", "Heat", "Snow / Snow and Rain", "Rain and Cold", "Rain and Heat", "All"})
        Me.comboWeather.Location = New System.Drawing.Point(686, 339)
        Me.comboWeather.Name = "comboWeather"
        Me.comboWeather.Size = New System.Drawing.Size(121, 21)
        Me.comboWeather.TabIndex = 25
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(46, 458)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 56)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClearText
        '
        Me.btnClearText.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearText.Location = New System.Drawing.Point(561, 458)
        Me.btnClearText.Name = "btnClearText"
        Me.btnClearText.Size = New System.Drawing.Size(95, 56)
        Me.btnClearText.TabIndex = 27
        Me.btnClearText.Text = "Clear Text"
        Me.btnClearText.UseVisualStyleBackColor = True
        '
        'Create_Outfit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(880, 573)
        Me.Controls.Add(Me.btnClearText)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.comboWeather)
        Me.Controls.Add(Me.comboSeason)
        Me.Controls.Add(Me.comboOccasion)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.pictureboxAddOutfit)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Create_Outfit"
        Me.Text = "Create Outfit"
        CType(Me.pictureboxAddOutfit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pictureboxAddOutfit As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents comboOccasion As System.Windows.Forms.ComboBox
    Friend WithEvents comboSeason As System.Windows.Forms.ComboBox
    Friend WithEvents comboWeather As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClearText As System.Windows.Forms.Button
End Class
