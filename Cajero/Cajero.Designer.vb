<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cajero
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBilleteV = New System.Windows.Forms.TextBox()
        Me.txtBilletedD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBilleteU = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBilleteC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonedaCtv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMonedaDs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMonedaVc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad a retirar:"
        '
        'txtEntrada
        '
        Me.txtEntrada.Location = New System.Drawing.Point(219, 38)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(229, 20)
        Me.txtEntrada.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Billetes de 20:"
        '
        'txtBilleteV
        '
        Me.txtBilleteV.Location = New System.Drawing.Point(275, 84)
        Me.txtBilleteV.Name = "txtBilleteV"
        Me.txtBilleteV.Size = New System.Drawing.Size(124, 20)
        Me.txtBilleteV.TabIndex = 3
        '
        'txtBilletedD
        '
        Me.txtBilletedD.Location = New System.Drawing.Point(275, 122)
        Me.txtBilletedD.Name = "txtBilletedD"
        Me.txtBilletedD.Size = New System.Drawing.Size(124, 20)
        Me.txtBilletedD.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Billetes de 10:"
        '
        'txtBilleteU
        '
        Me.txtBilleteU.Location = New System.Drawing.Point(275, 197)
        Me.txtBilleteU.Name = "txtBilleteU"
        Me.txtBilleteU.Size = New System.Drawing.Size(124, 20)
        Me.txtBilleteU.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Billetes de 1:"
        '
        'txtBilleteC
        '
        Me.txtBilleteC.Location = New System.Drawing.Point(275, 159)
        Me.txtBilleteC.Name = "txtBilleteC"
        Me.txtBilleteC.Size = New System.Drawing.Size(124, 20)
        Me.txtBilleteC.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Billetes de 5:"
        '
        'txtMonedaCtv
        '
        Me.txtMonedaCtv.Location = New System.Drawing.Point(275, 306)
        Me.txtMonedaCtv.Name = "txtMonedaCtv"
        Me.txtMonedaCtv.Size = New System.Drawing.Size(124, 20)
        Me.txtMonedaCtv.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(125, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Monedas de 0.1:"
        '
        'txtMonedaDs
        '
        Me.txtMonedaDs.Location = New System.Drawing.Point(275, 268)
        Me.txtMonedaDs.Name = "txtMonedaDs"
        Me.txtMonedaDs.Size = New System.Drawing.Size(124, 20)
        Me.txtMonedaDs.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(117, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Monedas de 0.10:"
        '
        'txtMonedaVc
        '
        Me.txtMonedaVc.Location = New System.Drawing.Point(275, 231)
        Me.txtMonedaVc.Name = "txtMonedaVc"
        Me.txtMonedaVc.Size = New System.Drawing.Size(124, 20)
        Me.txtMonedaVc.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(117, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Monedas de 0.25:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 36)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Retirar:"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 36)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Limpiar:"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(365, 364)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 36)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Salir:"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMonedaCtv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMonedaDs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMonedaVc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBilleteU)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBilleteC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBilletedD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBilleteV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cajero"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBilleteV As TextBox
    Friend WithEvents txtBilletedD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBilleteU As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBilleteC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonedaCtv As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMonedaDs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMonedaVc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
