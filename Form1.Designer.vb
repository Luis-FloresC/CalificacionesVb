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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNota1 = New System.Windows.Forms.TextBox()
        Me.txtNota2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nota 2"
        '
        'txtNota1
        '
        Me.txtNota1.Location = New System.Drawing.Point(135, 42)
        Me.txtNota1.Name = "txtNota1"
        Me.txtNota1.Size = New System.Drawing.Size(223, 23)
        Me.txtNota1.TabIndex = 2
        '
        'txtNota2
        '
        Me.txtNota2.Location = New System.Drawing.Point(135, 77)
        Me.txtNota2.Name = "txtNota2"
        Me.txtNota2.Size = New System.Drawing.Size(223, 23)
        Me.txtNota2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Promedio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Aprovechmiento"
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(135, 120)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(223, 23)
        Me.txtPromedio.TabIndex = 6
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(135, 157)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(223, 23)
        Me.txtResultado.TabIndex = 7
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(68, 202)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 28)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Location = New System.Drawing.Point(253, 202)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(75, 28)
        Me.btn_Nuevo.TabIndex = 9
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 242)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNota2)
        Me.Controls.Add(Me.txtNota1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aprovechmiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNota1 As TextBox
    Friend WithEvents txtNota2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btn_Nuevo As Button
End Class
