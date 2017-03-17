<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ejercicio 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(134, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ejercicio 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(235, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Ejercicio 3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(235, 119)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Ejercicio 6"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(134, 119)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Ejercicio 5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(32, 119)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Ejercicio 4"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(32, 31)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(278, 20)
        Me.txtParametro.TabIndex = 6
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(32, 244)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(278, 20)
        Me.txtRespuesta.TabIndex = 7
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(32, 157)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(278, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Ejercicio 7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(23, 198)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(278, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Ejercicio 7"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 295)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
