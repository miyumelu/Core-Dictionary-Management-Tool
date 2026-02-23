<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConvertTool))
        Target_Box = New ComboBox()
        Convert_Button = New Button()
        Object_Label = New Label()
        Window_Panel = New Panel()
        Close_Button = New Label()
        Minimize_Button = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Form_Label = New Label()
        Window_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Target_Box
        ' 
        Target_Box.Anchor = AnchorStyles.None
        Target_Box.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Target_Box.FormattingEnabled = True
        Target_Box.Location = New Point(323, 56)
        Target_Box.Name = "Target_Box"
        Target_Box.Size = New Size(112, 27)
        Target_Box.TabIndex = 0
        ' 
        ' Convert_Button
        ' 
        Convert_Button.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Convert_Button.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        Convert_Button.FlatStyle = FlatStyle.Flat
        Convert_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Convert_Button.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        Convert_Button.Location = New Point(15, 105)
        Convert_Button.Name = "Convert_Button"
        Convert_Button.Size = New Size(420, 50)
        Convert_Button.TabIndex = 10
        Convert_Button.Text = "Convert Object"
        Convert_Button.UseVisualStyleBackColor = False
        ' 
        ' Object_Label
        ' 
        Object_Label.Anchor = AnchorStyles.None
        Object_Label.AutoSize = True
        Object_Label.Font = New Font("SF UI Display Light", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Object_Label.ForeColor = Color.White
        Object_Label.Location = New Point(15, 56)
        Object_Label.Name = "Object_Label"
        Object_Label.Size = New Size(208, 29)
        Object_Label.TabIndex = 11
        Object_Label.Text = "Current Name.word"
        ' 
        ' Window_Panel
        ' 
        Window_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Window_Panel.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Window_Panel.Controls.Add(Close_Button)
        Window_Panel.Controls.Add(Minimize_Button)
        Window_Panel.Controls.Add(Label2)
        Window_Panel.Controls.Add(Label3)
        Window_Panel.Controls.Add(Form_Label)
        Window_Panel.Location = New Point(0, 0)
        Window_Panel.Name = "Window_Panel"
        Window_Panel.Size = New Size(450, 40)
        Window_Panel.TabIndex = 12
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
        Close_Button.TabIndex = 13
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
        Minimize_Button.TabIndex = 13
        Minimize_Button.Text = "-"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        Label2.Location = New Point(643, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(16, 19)
        Label2.TabIndex = 11
        Label2.Text = "-"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(666, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(19, 19)
        Label3.TabIndex = 10
        Label3.Text = "X"
        ' 
        ' Form_Label
        ' 
        Form_Label.AutoSize = True
        Form_Label.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Form_Label.ForeColor = Color.White
        Form_Label.Location = New Point(12, 10)
        Form_Label.Name = "Form_Label"
        Form_Label.Size = New Size(171, 19)
        Form_Label.TabIndex = 6
        Form_Label.Text = "CDMT - Convert Object"
        ' 
        ' ConvertTool
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(450, 168)
        Controls.Add(Window_Panel)
        Controls.Add(Object_Label)
        Controls.Add(Convert_Button)
        Controls.Add(Target_Box)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ConvertTool"
        Text = "ConvertTool"
        Window_Panel.ResumeLayout(False)
        Window_Panel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Target_Box As ComboBox
    Friend WithEvents Convert_Button As Button
    Friend WithEvents Object_Label As Label
    Friend WithEvents Window_Panel As Panel
    Friend WithEvents Maximize_Button As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Minimize_Button As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Form_Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Close_Button As Label
End Class
