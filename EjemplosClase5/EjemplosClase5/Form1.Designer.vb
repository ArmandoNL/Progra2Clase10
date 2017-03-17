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
        Me.cbxFigura = New System.Windows.Forms.ComboBox()
        Me.txtLado1 = New System.Windows.Forms.TextBox()
        Me.txtLado2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblLado1 = New System.Windows.Forms.Label()
        Me.lblLado2 = New System.Windows.Forms.Label()
        Me.txtFibo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxFigura
        '
        Me.cbxFigura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFigura.FormattingEnabled = True
        Me.cbxFigura.Items.AddRange(New Object() {"Cuadrado", "Rectángulo", "Triángulo", "Paralelogramo"})
        Me.cbxFigura.Location = New System.Drawing.Point(41, 66)
        Me.cbxFigura.Name = "cbxFigura"
        Me.cbxFigura.Size = New System.Drawing.Size(160, 32)
        Me.cbxFigura.TabIndex = 0
        '
        'txtLado1
        '
        Me.txtLado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLado1.Location = New System.Drawing.Point(41, 136)
        Me.txtLado1.Name = "txtLado1"
        Me.txtLado1.Size = New System.Drawing.Size(100, 29)
        Me.txtLado1.TabIndex = 1
        Me.txtLado1.Visible = False
        '
        'txtLado2
        '
        Me.txtLado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLado2.Location = New System.Drawing.Point(185, 136)
        Me.txtLado2.Name = "txtLado2"
        Me.txtLado2.Size = New System.Drawing.Size(100, 29)
        Me.txtLado2.TabIndex = 2
        Me.txtLado2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccione la figura a calcular."
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuesta.Location = New System.Drawing.Point(41, 246)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(244, 29)
        Me.txtRespuesta.TabIndex = 6
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(41, 186)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 46)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblLado1
        '
        Me.lblLado1.AutoSize = True
        Me.lblLado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLado1.Location = New System.Drawing.Point(44, 109)
        Me.lblLado1.Name = "lblLado1"
        Me.lblLado1.Size = New System.Drawing.Size(66, 24)
        Me.lblLado1.TabIndex = 9
        Me.lblLado1.Text = "Label2"
        Me.lblLado1.Visible = False
        '
        'lblLado2
        '
        Me.lblLado2.AutoSize = True
        Me.lblLado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLado2.Location = New System.Drawing.Point(191, 109)
        Me.lblLado2.Name = "lblLado2"
        Me.lblLado2.Size = New System.Drawing.Size(66, 24)
        Me.lblLado2.TabIndex = 10
        Me.lblLado2.Text = "Label2"
        Me.lblLado2.Visible = False
        '
        'txtFibo
        '
        Me.txtFibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibo.Location = New System.Drawing.Point(157, 186)
        Me.txtFibo.Name = "txtFibo"
        Me.txtFibo.Size = New System.Drawing.Size(100, 46)
        Me.txtFibo.TabIndex = 11
        Me.txtFibo.Text = "Calcular"
        Me.txtFibo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 349)
        Me.Controls.Add(Me.txtFibo)
        Me.Controls.Add(Me.lblLado2)
        Me.Controls.Add(Me.lblLado1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLado2)
        Me.Controls.Add(Me.txtLado1)
        Me.Controls.Add(Me.cbxFigura)
        Me.Name = "Form1"
        Me.Text = "Calcular áreas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxFigura As ComboBox
    Friend WithEvents txtLado1 As TextBox
    Friend WithEvents txtLado2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblLado1 As Label
    Friend WithEvents lblLado2 As Label
    Friend WithEvents txtFibo As Button
End Class
