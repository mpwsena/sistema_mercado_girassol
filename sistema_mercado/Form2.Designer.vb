<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(TelaPrincipal))
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        LbFunc = New Label()
        LbHor = New Label()
        MenuStrip1 = New MenuStrip()
        ConfiguraçõesToolStripMenuItem = New ToolStripMenuItem()
        BlocoDeNotasToolStripMenuItem = New ToolStripMenuItem()
        SuporteToolStripMenuItem = New ToolStripMenuItem()
        MercadogirassolsuportecomToolStripMenuItem = New ToolStripMenuItem()
        Timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.Beige
        Button1.ForeColor = Color.DarkOliveGreen
        Button1.Location = New Point(30, 63)
        Button1.Margin = New Padding(20, 5, 20, 40)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(4)
        Button1.Size = New Size(374, 74)
        Button1.TabIndex = 5
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.Beige
        Button2.Font = New Font("JetBrains Mono ExtraBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.DarkOliveGreen
        Button2.Location = New Point(30, 187)
        Button2.Margin = New Padding(10)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(4)
        Button2.Size = New Size(177, 51)
        Button2.TabIndex = 8
        Button2.Text = "PRODUTO"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.AutoSize = True
        GroupBox1.BackgroundImageLayout = ImageLayout.None
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Font = New Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(29, 106)
        GroupBox1.Margin = New Padding(20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(10)
        GroupBox1.Size = New Size(434, 377)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.AutoSize = True
        Button4.BackColor = Color.Beige
        Button4.Font = New Font("JetBrains Mono ExtraBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.DarkOliveGreen
        Button4.Location = New Point(227, 187)
        Button4.Margin = New Padding(10)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(4)
        Button4.Size = New Size(177, 51)
        Button4.TabIndex = 16
        Button4.Text = "CONSULTAR"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.BackColor = Color.Beige
        Button3.Font = New Font("JetBrains Mono ExtraBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.DarkOliveGreen
        Button3.Location = New Point(30, 258)
        Button3.Margin = New Padding(10)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(4)
        Button3.Size = New Size(177, 51)
        Button3.TabIndex = 15
        Button3.Text = "CLIENTE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.AutoSize = True
        Button6.BackColor = Color.Beige
        Button6.Font = New Font("JetBrains Mono ExtraBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.DarkOliveGreen
        Button6.Location = New Point(227, 258)
        Button6.Margin = New Padding(10)
        Button6.Name = "Button6"
        Button6.Padding = New Padding(4)
        Button6.Size = New Size(177, 51)
        Button6.TabIndex = 14
        Button6.Text = "RELATÓRIO"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.AutoSize = True
        Button5.BackColor = Color.IndianRed
        Button5.Font = New Font("JetBrains Mono ExtraBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(1058, 586)
        Button5.Margin = New Padding(15)
        Button5.Name = "Button5"
        Button5.Padding = New Padding(4)
        Button5.Size = New Size(97, 51)
        Button5.TabIndex = 11
        Button5.Text = "SAIR"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' LbFunc
        ' 
        LbFunc.AutoSize = True
        LbFunc.Font = New Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LbFunc.ForeColor = Color.Beige
        LbFunc.Location = New Point(29, 44)
        LbFunc.Margin = New Padding(20)
        LbFunc.Name = "LbFunc"
        LbFunc.Size = New Size(243, 37)
        LbFunc.TabIndex = 2
        LbFunc.Text = "{ID DO FUNCIONÁRIO}"
        ' 
        ' LbHor
        ' 
        LbHor.AutoSize = True
        LbHor.Font = New Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LbHor.ForeColor = Color.Beige
        LbHor.Location = New Point(1052, 44)
        LbHor.Margin = New Padding(20)
        LbHor.Name = "LbHor"
        LbHor.Size = New Size(103, 37)
        LbHor.TabIndex = 3
        LbHor.Text = "XX:XX:XX"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ConfiguraçõesToolStripMenuItem, BlocoDeNotasToolStripMenuItem, SuporteToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1184, 24)
        MenuStrip1.TabIndex = 12
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ConfiguraçõesToolStripMenuItem
        ' 
        ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        ConfiguraçõesToolStripMenuItem.Size = New Size(96, 20)
        ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        ' 
        ' BlocoDeNotasToolStripMenuItem
        ' 
        BlocoDeNotasToolStripMenuItem.Name = "BlocoDeNotasToolStripMenuItem"
        BlocoDeNotasToolStripMenuItem.Size = New Size(99, 20)
        BlocoDeNotasToolStripMenuItem.Text = "Bloco de Notas"
        ' 
        ' SuporteToolStripMenuItem
        ' 
        SuporteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MercadogirassolsuportecomToolStripMenuItem})
        SuporteToolStripMenuItem.Name = "SuporteToolStripMenuItem"
        SuporteToolStripMenuItem.Size = New Size(60, 20)
        SuporteToolStripMenuItem.Text = "Suporte"
        ' 
        ' MercadogirassolsuportecomToolStripMenuItem
        ' 
        MercadogirassolsuportecomToolStripMenuItem.Name = "MercadogirassolsuportecomToolStripMenuItem"
        MercadogirassolsuportecomToolStripMenuItem.Size = New Size(239, 22)
        MercadogirassolsuportecomToolStripMenuItem.Text = "mercadogirassol@suporte.com"
        ' 
        ' Timer1
        ' 
        ' 
        ' TelaPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1184, 661)
        Controls.Add(LbHor)
        Controls.Add(LbFunc)
        Controls.Add(GroupBox1)
        Controls.Add(Button5)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "TelaPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LbFunc As Label
    Friend WithEvents LbHor As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConfiguraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocoDeNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MercadogirassolsuportecomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
