<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCalcular
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCalcular))
        Label7 = New Label()
        UltPago = New Label()
        Button10 = New Button()
        Label1 = New Label()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TotalTotal = New Label()
        TotalMant = New Label()
        TotalFan = New Label()
        TotalFuen = New Label()
        TotalTarj = New Label()
        CantMant = New Label()
        CantFan = New Label()
        CantFuen = New Label()
        CantTar = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(209, 242)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 20)
        Label7.TabIndex = 60
        Label7.Text = "Label7"
        ' 
        ' UltPago
        ' 
        UltPago.AutoSize = True
        UltPago.Location = New Point(321, 222)
        UltPago.Name = "UltPago"
        UltPago.Size = New Size(17, 20)
        UltPago.TabIndex = 59
        UltPago.Text = "0"
        ' 
        ' Button10
        ' 
        Button10.Enabled = False
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Location = New Point(116, 220)
        Button10.Name = "Button10"
        Button10.Size = New Size(86, 45)
        Button10.TabIndex = 58
        Button10.Text = "Pagar"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(219, 222)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 20)
        Label1.TabIndex = 57
        Label1.Text = "Último pago: $"
        ' 
        ' Button9
        ' 
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Location = New Point(24, 220)
        Button9.Name = "Button9"
        Button9.Size = New Size(86, 45)
        Button9.TabIndex = 53
        Button9.Text = "Limpiar"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(218, 170)
        Button8.Name = "Button8"
        Button8.Size = New Size(31, 29)
        Button8.TabIndex = 52
        Button8.Text = "+"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(158, 170)
        Button7.Name = "Button7"
        Button7.Size = New Size(31, 29)
        Button7.TabIndex = 51
        Button7.Text = "-"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(158, 121)
        Button6.Name = "Button6"
        Button6.Size = New Size(31, 29)
        Button6.TabIndex = 50
        Button6.Text = "-"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(218, 121)
        Button5.Name = "Button5"
        Button5.Size = New Size(31, 29)
        Button5.TabIndex = 49
        Button5.Text = "+"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(218, 74)
        Button4.Name = "Button4"
        Button4.Size = New Size(31, 29)
        Button4.TabIndex = 48
        Button4.Text = "+"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(158, 74)
        Button3.Name = "Button3"
        Button3.Size = New Size(31, 29)
        Button3.TabIndex = 47
        Button3.Text = "-"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Control
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(218, 26)
        Button2.Name = "Button2"
        Button2.Size = New Size(31, 29)
        Button2.TabIndex = 46
        Button2.Text = "+"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(158, 26)
        Button1.Name = "Button1"
        Button1.Size = New Size(31, 29)
        Button1.TabIndex = 45
        Button1.Text = "-"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TotalTotal
        ' 
        TotalTotal.AutoSize = True
        TotalTotal.BackColor = Color.AntiqueWhite
        TotalTotal.Location = New Point(462, 231)
        TotalTotal.Name = "TotalTotal"
        TotalTotal.Size = New Size(17, 20)
        TotalTotal.TabIndex = 44
        TotalTotal.Text = "0"
        ' 
        ' TotalMant
        ' 
        TotalMant.AutoSize = True
        TotalMant.Location = New Point(462, 174)
        TotalMant.Name = "TotalMant"
        TotalMant.Size = New Size(17, 20)
        TotalMant.TabIndex = 43
        TotalMant.Text = "0"
        ' 
        ' TotalFan
        ' 
        TotalFan.AutoSize = True
        TotalFan.BackColor = SystemColors.AppWorkspace
        TotalFan.Location = New Point(462, 125)
        TotalFan.Name = "TotalFan"
        TotalFan.Size = New Size(17, 20)
        TotalFan.TabIndex = 42
        TotalFan.Text = "0"
        ' 
        ' TotalFuen
        ' 
        TotalFuen.AutoSize = True
        TotalFuen.Location = New Point(462, 78)
        TotalFuen.Name = "TotalFuen"
        TotalFuen.Size = New Size(17, 20)
        TotalFuen.TabIndex = 41
        TotalFuen.Text = "0"
        ' 
        ' TotalTarj
        ' 
        TotalTarj.AutoSize = True
        TotalTarj.BackColor = SystemColors.AppWorkspace
        TotalTarj.Location = New Point(462, 30)
        TotalTarj.Name = "TotalTarj"
        TotalTarj.Size = New Size(17, 20)
        TotalTarj.TabIndex = 40
        TotalTarj.Text = "0"
        ' 
        ' CantMant
        ' 
        CantMant.AutoSize = True
        CantMant.Location = New Point(195, 174)
        CantMant.Name = "CantMant"
        CantMant.Size = New Size(17, 20)
        CantMant.TabIndex = 39
        CantMant.Text = "0"
        ' 
        ' CantFan
        ' 
        CantFan.AutoSize = True
        CantFan.BackColor = SystemColors.AppWorkspace
        CantFan.Location = New Point(195, 125)
        CantFan.Name = "CantFan"
        CantFan.Size = New Size(17, 20)
        CantFan.TabIndex = 38
        CantFan.Text = "0"
        ' 
        ' CantFuen
        ' 
        CantFuen.AutoSize = True
        CantFuen.Location = New Point(195, 78)
        CantFuen.Name = "CantFuen"
        CantFuen.Size = New Size(17, 20)
        CantFuen.TabIndex = 37
        CantFuen.Text = "0"
        ' 
        ' CantTar
        ' 
        CantTar.AutoSize = True
        CantTar.BackColor = SystemColors.AppWorkspace
        CantTar.Location = New Point(195, 30)
        CantTar.Name = "CantTar"
        CantTar.Size = New Size(17, 20)
        CantTar.TabIndex = 36
        CantTar.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.AntiqueWhite
        Label6.Location = New Point(411, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 35
        Label6.Text = "Total: $"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 20)
        Label5.TabIndex = 34
        Label5.Text = "Mantenimientos:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.AppWorkspace
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(24, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 33
        Label4.Text = "Fan coolers:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 32
        Label3.Text = "Fuentes:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.AppWorkspace
        Label2.Location = New Point(24, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 20)
        Label2.TabIndex = 31
        Label2.Text = "Tarjetas:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.AppWorkspace
        PictureBox1.Location = New Point(-29, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(550, 41)
        PictureBox1.TabIndex = 54
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.AppWorkspace
        PictureBox2.Location = New Point(-19, 115)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(550, 41)
        PictureBox2.TabIndex = 55
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.AntiqueWhite
        PictureBox3.Location = New Point(380, 220)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(151, 41)
        PictureBox3.TabIndex = 56
        PictureBox3.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Timer2
        ' 
        ' 
        ' FCalcular
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(519, 275)
        Controls.Add(Label7)
        Controls.Add(UltPago)
        Controls.Add(Button10)
        Controls.Add(Label1)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TotalTotal)
        Controls.Add(TotalMant)
        Controls.Add(TotalFan)
        Controls.Add(TotalFuen)
        Controls.Add(TotalTarj)
        Controls.Add(CantMant)
        Controls.Add(CantFan)
        Controls.Add(CantFuen)
        Controls.Add(CantTar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FCalcular"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calcular"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents UltPago As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TotalTotal As Label
    Friend WithEvents TotalMant As Label
    Friend WithEvents TotalFan As Label
    Friend WithEvents TotalFuen As Label
    Friend WithEvents TotalTarj As Label
    Friend WithEvents CantMant As Label
    Friend WithEvents CantFan As Label
    Friend WithEvents CantFuen As Label
    Friend WithEvents CantTar As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
