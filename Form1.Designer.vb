<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.list = New System.Windows.Forms.ComboBox()
        Me.rd2 = New System.Windows.Forms.RadioButton()
        Me.Ch1 = New System.Windows.Forms.CheckBox()
        Me.Btn = New System.Windows.Forms.Button()
        Me.rd3 = New System.Windows.Forms.RadioButton()
        Me.rd1 = New System.Windows.Forms.RadioButton()
        Me.Ch4 = New System.Windows.Forms.CheckBox()
        Me.Ch3 = New System.Windows.Forms.CheckBox()
        Me.Ch2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'list
        '
        Me.list.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.list.FormattingEnabled = True
        Me.list.Items.AddRange(New Object() {"petite", "moyenne", "grande"})
        Me.list.Location = New System.Drawing.Point(159, 35)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(411, 24)
        Me.list.TabIndex = 0
        '
        'rd2
        '
        Me.rd2.AutoSize = True
        Me.rd2.Font = New System.Drawing.Font("Algerian", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd2.ForeColor = System.Drawing.Color.Pink
        Me.rd2.Location = New System.Drawing.Point(239, 82)
        Me.rd2.Name = "rd2"
        Me.rd2.Size = New System.Drawing.Size(257, 29)
        Me.rd2.TabIndex = 1
        Me.rd2.TabStop = True
        Me.rd2.Text = "croute classique"
        Me.rd2.UseVisualStyleBackColor = True
        '
        'Ch1
        '
        Me.Ch1.AutoSize = True
        Me.Ch1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch1.ForeColor = System.Drawing.Color.Yellow
        Me.Ch1.Location = New System.Drawing.Point(12, 140)
        Me.Ch1.Name = "Ch1"
        Me.Ch1.Size = New System.Drawing.Size(165, 29)
        Me.Ch1.TabIndex = 2
        Me.Ch1.Text = "champignons"
        Me.Ch1.UseVisualStyleBackColor = True
        '
        'Btn
        '
        Me.Btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn.Location = New System.Drawing.Point(239, 368)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(307, 45)
        Me.Btn.TabIndex = 3
        Me.Btn.Text = "afficher la commande"
        Me.Btn.UseVisualStyleBackColor = False
        '
        'rd3
        '
        Me.rd3.AutoSize = True
        Me.rd3.Font = New System.Drawing.Font("Algerian", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd3.ForeColor = System.Drawing.Color.Pink
        Me.rd3.Location = New System.Drawing.Point(494, 82)
        Me.rd3.Name = "rd3"
        Me.rd3.Size = New System.Drawing.Size(228, 29)
        Me.rd3.TabIndex = 4
        Me.rd3.TabStop = True
        Me.rd3.Text = "croute epaisse"
        Me.rd3.UseVisualStyleBackColor = True
        '
        'rd1
        '
        Me.rd1.AutoSize = True
        Me.rd1.Font = New System.Drawing.Font("Algerian", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd1.ForeColor = System.Drawing.Color.Pink
        Me.rd1.Location = New System.Drawing.Point(43, 82)
        Me.rd1.Name = "rd1"
        Me.rd1.Size = New System.Drawing.Size(181, 29)
        Me.rd1.TabIndex = 5
        Me.rd1.TabStop = True
        Me.rd1.Text = "croute fine"
        Me.rd1.UseVisualStyleBackColor = True
        '
        'Ch4
        '
        Me.Ch4.AutoSize = True
        Me.Ch4.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch4.ForeColor = System.Drawing.Color.Yellow
        Me.Ch4.Location = New System.Drawing.Point(12, 285)
        Me.Ch4.Name = "Ch4"
        Me.Ch4.Size = New System.Drawing.Size(273, 29)
        Me.Ch4.TabIndex = 7
        Me.Ch4.Text = "fromage supplimentaire"
        Me.Ch4.UseVisualStyleBackColor = True
        '
        'Ch3
        '
        Me.Ch3.AutoSize = True
        Me.Ch3.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch3.ForeColor = System.Drawing.Color.Yellow
        Me.Ch3.Location = New System.Drawing.Point(12, 233)
        Me.Ch3.Name = "Ch3"
        Me.Ch3.Size = New System.Drawing.Size(119, 29)
        Me.Ch3.TabIndex = 8
        Me.Ch3.Text = "poivrons"
        Me.Ch3.UseVisualStyleBackColor = True
        '
        'Ch2
        '
        Me.Ch2.AutoSize = True
        Me.Ch2.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch2.ForeColor = System.Drawing.Color.Yellow
        Me.Ch2.Location = New System.Drawing.Point(12, 191)
        Me.Ch2.Name = "Ch2"
        Me.Ch2.Size = New System.Drawing.Size(91, 29)
        Me.Ch2.TabIndex = 9
        Me.Ch2.Text = "olives"
        Me.Ch2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rd3)
        Me.Controls.Add(Me.rd2)
        Me.Controls.Add(Me.rd1)
        Me.Controls.Add(Me.Ch2)
        Me.Controls.Add(Me.Ch3)
        Me.Controls.Add(Me.Ch4)
        Me.Controls.Add(Me.Btn)
        Me.Controls.Add(Me.Ch1)
        Me.Controls.Add(Me.list)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents list As ComboBox
    Friend WithEvents rd2 As RadioButton
    Friend WithEvents Ch1 As CheckBox
    Friend WithEvents Btn As Button
    Friend WithEvents rd3 As RadioButton
    Friend WithEvents rd1 As RadioButton
    Friend WithEvents Ch4 As CheckBox
    Friend WithEvents Ch3 As CheckBox
    Friend WithEvents Ch2 As CheckBox
End Class
