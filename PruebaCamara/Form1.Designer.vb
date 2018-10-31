<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebCameraControl1 = New WebEye.Controls.WinForms.WebCameraControl.WebCameraControl()
        Me.IniciarButton = New System.Windows.Forms.Button()
        Me.CapturarButton = New System.Windows.Forms.Button()
        Me.PararButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebCameraControl1
        '
        Me.WebCameraControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WebCameraControl1.Location = New System.Drawing.Point(12, 12)
        Me.WebCameraControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.WebCameraControl1.Name = "WebCameraControl1"
        Me.WebCameraControl1.Size = New System.Drawing.Size(380, 302)
        Me.WebCameraControl1.TabIndex = 0
        '
        'IniciarButton
        '
        Me.IniciarButton.Location = New System.Drawing.Point(208, 326)
        Me.IniciarButton.Margin = New System.Windows.Forms.Padding(2)
        Me.IniciarButton.Name = "IniciarButton"
        Me.IniciarButton.Size = New System.Drawing.Size(56, 19)
        Me.IniciarButton.TabIndex = 1
        Me.IniciarButton.Text = "Iniciar"
        Me.IniciarButton.UseVisualStyleBackColor = True
        '
        'CapturarButton
        '
        Me.CapturarButton.Location = New System.Drawing.Point(272, 326)
        Me.CapturarButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CapturarButton.Name = "CapturarButton"
        Me.CapturarButton.Size = New System.Drawing.Size(56, 19)
        Me.CapturarButton.TabIndex = 2
        Me.CapturarButton.Text = "Capturar"
        Me.CapturarButton.UseVisualStyleBackColor = True
        '
        'PararButton
        '
        Me.PararButton.Location = New System.Drawing.Point(335, 326)
        Me.PararButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PararButton.Name = "PararButton"
        Me.PararButton.Size = New System.Drawing.Size(56, 19)
        Me.PararButton.TabIndex = 3
        Me.PararButton.Text = "Parar"
        Me.PararButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 359)
        Me.Controls.Add(Me.PararButton)
        Me.Controls.Add(Me.CapturarButton)
        Me.Controls.Add(Me.IniciarButton)
        Me.Controls.Add(Me.WebCameraControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(416, 398)
        Me.MinimumSize = New System.Drawing.Size(416, 398)
        Me.Name = "Form1"
        Me.Text = "PruebaCamara"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebCameraControl1 As WebEye.Controls.WinForms.WebCameraControl.WebCameraControl
    Friend WithEvents IniciarButton As Button
    Friend WithEvents CapturarButton As Button
    Friend WithEvents PararButton As Button
End Class
