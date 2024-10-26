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
        cmbUnidadDesde = New ComboBox()
        cmbUnidadA = New ComboBox()
        txtValor = New TextBox()
        btnConvertir = New Button()
        lblResultado = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbUnidadDesde
        ' 
        cmbUnidadDesde.FormattingEnabled = True
        cmbUnidadDesde.Location = New Point(90, 168)
        cmbUnidadDesde.Name = "cmbUnidadDesde"
        cmbUnidadDesde.Size = New Size(151, 28)
        cmbUnidadDesde.TabIndex = 0
        ' 
        ' cmbUnidadA
        ' 
        cmbUnidadA.FormattingEnabled = True
        cmbUnidadA.Location = New Point(543, 168)
        cmbUnidadA.Name = "cmbUnidadA"
        cmbUnidadA.Size = New Size(151, 28)
        cmbUnidadA.TabIndex = 1
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(300, 115)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(163, 27)
        txtValor.TabIndex = 2
        ' 
        ' btnConvertir
        ' 
        btnConvertir.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConvertir.Location = New Point(300, 232)
        btnConvertir.Name = "btnConvertir"
        btnConvertir.Size = New Size(163, 40)
        btnConvertir.TabIndex = 3
        btnConvertir.Text = "Convertir"
        btnConvertir.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.BackColor = Color.MintCream
        lblResultado.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResultado.Location = New Point(26, 362)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(127, 33)
        lblResultado.TabIndex = 4
        lblResultado.Text = "Resultado"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(216, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(354, 39)
        Label1.TabIndex = 5
        Label1.Text = "Convertidor de Unidades"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(318, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 17)
        Label2.TabIndex = 6
        Label2.Text = "Ingrese cantidad:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(90, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 17)
        Label3.TabIndex = 7
        Label3.Text = "Ingrese Unidad a covertir:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(543, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 17)
        Label4.TabIndex = 8
        Label4.Text = "Ingrese unidad de cambio"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._475523955ce4ccc10029e9955420dd40
        PictureBox1.Location = New Point(565, 248)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(185, 171)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblResultado)
        Controls.Add(btnConvertir)
        Controls.Add(txtValor)
        Controls.Add(cmbUnidadA)
        Controls.Add(cmbUnidadDesde)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbUnidadDesde As ComboBox
    Friend WithEvents cmbUnidadA As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
