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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.Controls.Add(LinkLabel1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Poppins", 24.0F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Beige
        GroupBox1.Location = New Point(29, 29)
        GroupBox1.Margin = New Padding(20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(10)
        GroupBox1.Size = New Size(568, 544)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "MERCADO GIRASSOL"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Poppins", 14.25F, FontStyle.Italic, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.Beige
        LinkLabel1.Location = New Point(344, 452)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(173, 34)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Esqueci a senha"
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.Beige
        Button1.ForeColor = Color.DarkOliveGreen
        Button1.Location = New Point(30, 412)
        Button1.Margin = New Padding(20, 40, 20, 0)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(4)
        Button1.Size = New Size(168, 74)
        Button1.TabIndex = 5
        Button1.Text = "Entrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 235)
        Label2.Margin = New Padding(20)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 56)
        Label2.TabIndex = 4
        Label2.Text = "Senha"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Beige
        TextBox2.Location = New Point(30, 314)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(485, 55)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Beige
        TextBox1.Location = New Point(30, 157)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(485, 55)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 78)
        Label1.Margin = New Padding(20)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 56)
        Label1.TabIndex = 0
        Label1.Text = "Usuário"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(567, 107)
        PictureBox1.Margin = New Padding(30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 560)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(1184, 661)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
