<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTool
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateTool))
        Window_Panel = New Panel()
        Close_Button = New Label()
        Minimize_Button = New Label()
        Form_Label = New Label()
        ItemName_Label = New Label()
        Create_Button = New Button()
        Name_Box = New TextBox()
        Target_Box = New ComboBox()
        Label1 = New Label()
        Window_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Window_Panel
        ' 
        Window_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Window_Panel.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Window_Panel.Controls.Add(Close_Button)
        Window_Panel.Controls.Add(Minimize_Button)
        Window_Panel.Controls.Add(Form_Label)
        Window_Panel.Location = New Point(0, 0)
        Window_Panel.Name = "Window_Panel"
        Window_Panel.Size = New Size(450, 40)
        Window_Panel.TabIndex = 11
        ' 
        ' Close_Button
        ' 
        Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Close_Button.AutoSize = True
        Close_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Close_Button.ForeColor = Color.Red
        Close_Button.Location = New Point(416, 10)
        Close_Button.Name = "Close_Button"
        Close_Button.Size = New Size(19, 19)
        Close_Button.TabIndex = 18
        Close_Button.Text = "X"
        ' 
        ' Minimize_Button
        ' 
        Minimize_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Minimize_Button.AutoSize = True
        Minimize_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Minimize_Button.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        Minimize_Button.Location = New Point(393, 10)
        Minimize_Button.Name = "Minimize_Button"
        Minimize_Button.Size = New Size(16, 19)
        Minimize_Button.TabIndex = 19
        Minimize_Button.Text = "-"
        ' 
        ' Form_Label
        ' 
        Form_Label.AutoSize = True
        Form_Label.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Form_Label.ForeColor = Color.White
        Form_Label.Location = New Point(12, 10)
        Form_Label.Name = "Form_Label"
        Form_Label.Size = New Size(161, 19)
        Form_Label.TabIndex = 6
        Form_Label.Text = "CDMT - Create Object"
        ' 
        ' ItemName_Label
        ' 
        ItemName_Label.Anchor = AnchorStyles.None
        ItemName_Label.AutoSize = True
        ItemName_Label.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ItemName_Label.ForeColor = Color.White
        ItemName_Label.Location = New Point(12, 64)
        ItemName_Label.Name = "ItemName_Label"
        ItemName_Label.Size = New Size(97, 19)
        ItemName_Label.TabIndex = 15
        ItemName_Label.Text = "Item Name  -"
        ' 
        ' Create_Button
        ' 
        Create_Button.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Create_Button.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        Create_Button.FlatStyle = FlatStyle.Flat
        Create_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Create_Button.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        Create_Button.Location = New Point(15, 145)
        Create_Button.Name = "Create_Button"
        Create_Button.Size = New Size(420, 50)
        Create_Button.TabIndex = 14
        Create_Button.Text = "Create Object"
        Create_Button.UseVisualStyleBackColor = False
        ' 
        ' Name_Box
        ' 
        Name_Box.Anchor = AnchorStyles.None
        Name_Box.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Name_Box.Location = New Point(115, 60)
        Name_Box.Name = "Name_Box"
        Name_Box.Size = New Size(320, 27)
        Name_Box.TabIndex = 13
        ' 
        ' Target_Box
        ' 
        Target_Box.Anchor = AnchorStyles.None
        Target_Box.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Target_Box.FormattingEnabled = True
        Target_Box.Location = New Point(115, 100)
        Target_Box.Name = "Target_Box"
        Target_Box.Size = New Size(320, 27)
        Target_Box.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(52, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 19)
        Label1.TabIndex = 17
        Label1.Text = "Type  -"
        ' 
        ' CreateTool
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(450, 210)
        Controls.Add(Label1)
        Controls.Add(Target_Box)
        Controls.Add(Window_Panel)
        Controls.Add(ItemName_Label)
        Controls.Add(Create_Button)
        Controls.Add(Name_Box)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "CreateTool"
        Text = "CreateTool"
        Window_Panel.ResumeLayout(False)
        Window_Panel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Window_Panel As Panel
    Friend WithEvents Form_Label As Label
    Friend WithEvents ItemName_Label As Label
    Friend WithEvents Create_Button As Button
    Friend WithEvents Name_Box As TextBox
    Friend WithEvents Target_Box As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Close_Button As Label
    Friend WithEvents Minimize_Button As Label
End Class
