<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.English = New System.Windows.Forms.Button()
        Me.ITALIAN = New System.Windows.Forms.Button()
        Me.CustomCipherInput = New System.Windows.Forms.TextBox()
        Me.CustomPlainInput = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.EncryptedOutput = New System.Windows.Forms.TextBox()
        Me.NormalInput = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.English)
        Me.GroupBox1.Controls.Add(Me.ITALIAN)
        Me.GroupBox1.Controls.Add(Me.CustomCipherInput)
        Me.GroupBox1.Controls.Add(Me.CustomPlainInput)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.EncryptedOutput)
        Me.GroupBox1.Controls.Add(Me.NormalInput)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1015, 479)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Normal text to be encrypted"
        '
        'English
        '
        Me.English.Location = New System.Drawing.Point(808, 414)
        Me.English.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.English.Name = "English"
        Me.English.Size = New System.Drawing.Size(52, 57)
        Me.English.TabIndex = 13
        Me.English.Text = "EN"
        Me.English.UseVisualStyleBackColor = True
        '
        'ITALIAN
        '
        Me.ITALIAN.Location = New System.Drawing.Point(736, 414)
        Me.ITALIAN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ITALIAN.Name = "ITALIAN"
        Me.ITALIAN.Size = New System.Drawing.Size(52, 57)
        Me.ITALIAN.TabIndex = 12
        Me.ITALIAN.Text = "IT"
        Me.ITALIAN.UseVisualStyleBackColor = True
        '
        'CustomCipherInput
        '
        Me.CustomCipherInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.CustomCipherInput.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustomCipherInput.Location = New System.Drawing.Point(9, 346)
        Me.CustomCipherInput.Name = "CustomCipherInput"
        Me.CustomCipherInput.PlaceholderText = "Custom key correspondance"
        Me.CustomCipherInput.Size = New System.Drawing.Size(1000, 54)
        Me.CustomCipherInput.TabIndex = 11
        '
        'CustomPlainInput
        '
        Me.CustomPlainInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.CustomPlainInput.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustomPlainInput.Location = New System.Drawing.Point(9, 286)
        Me.CustomPlainInput.Name = "CustomPlainInput"
        Me.CustomPlainInput.PlaceholderText = "Custom plain letters"
        Me.CustomPlainInput.Size = New System.Drawing.Size(1000, 54)
        Me.CustomPlainInput.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(187, 414)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(243, 57)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Convert with Custom Subsistution Cipher"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1002, 84)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(438, 414)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 57)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Convert to Farfallino"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(866, 414)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 57)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'EncryptedOutput
        '
        Me.EncryptedOutput.Location = New System.Drawing.Point(540, 32)
        Me.EncryptedOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EncryptedOutput.Multiline = True
        Me.EncryptedOutput.Name = "EncryptedOutput"
        Me.EncryptedOutput.PlaceholderText = "Output"
        Me.EncryptedOutput.ReadOnly = True
        Me.EncryptedOutput.Size = New System.Drawing.Size(469, 163)
        Me.EncryptedOutput.TabIndex = 3
        '
        'NormalInput
        '
        Me.NormalInput.Location = New System.Drawing.Point(7, 32)
        Me.NormalInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NormalInput.Multiline = True
        Me.NormalInput.Name = "NormalInput"
        Me.NormalInput.PlaceholderText = "Input"
        Me.NormalInput.Size = New System.Drawing.Size(527, 163)
        Me.NormalInput.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(587, 414)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 57)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 414)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 57)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convert with Default Subsistution Cipher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1041, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 508)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CodeSpeak by EdSoft"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents EncryptedOutput As TextBox
    Friend WithEvents NormalInput As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents CustomCipherInput As TextBox
    Friend WithEvents CustomPlainInput As TextBox
    Friend WithEvents English As Button
    Friend WithEvents ITALIAN As Button
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
