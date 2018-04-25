<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Alta = New System.Windows.Forms.Button
        Me.Baja = New System.Windows.Forms.Button
        Me.modificar = New System.Windows.Forms.Button
        Me.GrabarXml = New System.Windows.Forms.Button
        Me.LeerXml = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(11, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Alta
        '
        Me.Alta.Location = New System.Drawing.Point(174, 25)
        Me.Alta.Name = "Alta"
        Me.Alta.Size = New System.Drawing.Size(75, 23)
        Me.Alta.TabIndex = 2
        Me.Alta.Text = "Alta"
        Me.Alta.UseVisualStyleBackColor = True
        '
        'Baja
        '
        Me.Baja.Location = New System.Drawing.Point(174, 54)
        Me.Baja.Name = "Baja"
        Me.Baja.Size = New System.Drawing.Size(75, 23)
        Me.Baja.TabIndex = 3
        Me.Baja.Text = "Baja"
        Me.Baja.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(174, 83)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(75, 23)
        Me.modificar.TabIndex = 4
        Me.modificar.Text = "modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'GrabarXml
        '
        Me.GrabarXml.Location = New System.Drawing.Point(174, 112)
        Me.GrabarXml.Name = "GrabarXml"
        Me.GrabarXml.Size = New System.Drawing.Size(75, 23)
        Me.GrabarXml.TabIndex = 5
        Me.GrabarXml.Text = "grabar"
        Me.GrabarXml.UseVisualStyleBackColor = True
        '
        'LeerXml
        '
        Me.LeerXml.Location = New System.Drawing.Point(174, 141)
        Me.LeerXml.Name = "LeerXml"
        Me.LeerXml.Size = New System.Drawing.Size(75, 23)
        Me.LeerXml.TabIndex = 6
        Me.LeerXml.Text = "Leer"
        Me.LeerXml.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 196)
        Me.Controls.Add(Me.LeerXml)
        Me.Controls.Add(Me.GrabarXml)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.Baja)
        Me.Controls.Add(Me.Alta)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMBComboBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Alta As System.Windows.Forms.Button
    Friend WithEvents Baja As System.Windows.Forms.Button
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents GrabarXml As System.Windows.Forms.Button
    Friend WithEvents LeerXml As System.Windows.Forms.Button

End Class
