<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenameTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RenameTool))
        Window_Panel = New Panel()
        Minimize_Button = New Label()
        Close_Button = New Label()
        Form_Label = New Label()
        Object_Label = New Label()
        Name_Box = New TextBox()
        Rename_Button = New Button()
        ItemName_Label = New Label()
        Window_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Window_Panel
        ' 
        Window_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Window_Panel.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Window_Panel.Controls.Add(Minimize_Button)
        Window_Panel.Controls.Add(Close_Button)
        Window_Panel.Controls.Add(Form_Label)
        Window_Panel.Location = New Point(0, 0)
        Window_Panel.Name = "Window_Panel"
        Window_Panel.Size = New Size(450, 40)
        Window_Panel.TabIndex = 2
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
        Minimize_Button.TabIndex = 11
        Minimize_Button.Text = "-"
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
        Close_Button.TabIndex = 10
        Close_Button.Text = "X"
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
        Form_Label.Text = "CDMT - Rename Object"
        ' 
        ' Object_Label
        ' 
        Object_Label.Anchor = AnchorStyles.None
        Object_Label.AutoSize = True
        Object_Label.Font = New Font("SF UI Display Light", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Object_Label.ForeColor = Color.White
        Object_Label.Location = New Point(12, 55)
        Object_Label.Name = "Object_Label"
        Object_Label.Size = New Size(208, 29)
        Object_Label.TabIndex = 3
        Object_Label.Text = "Current Name.word"
        ' 
        ' Name_Box
        ' 
        Name_Box.Anchor = AnchorStyles.None
        Name_Box.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Name_Box.Location = New Point(115, 100)
        Name_Box.Name = "Name_Box"
        Name_Box.Size = New Size(320, 27)
        Name_Box.TabIndex = 4
        ' 
        ' Rename_Button
        ' 
        Rename_Button.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Rename_Button.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        Rename_Button.FlatStyle = FlatStyle.Flat
        Rename_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Rename_Button.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        Rename_Button.Location = New Point(15, 145)
        Rename_Button.Name = "Rename_Button"
        Rename_Button.Size = New Size(420, 50)
        Rename_Button.TabIndex = 9
        Rename_Button.Text = "Rename Object"
        Rename_Button.UseVisualStyleBackColor = False
        ' 
        ' ItemName_Label
        ' 
        ItemName_Label.Anchor = AnchorStyles.None
        ItemName_Label.AutoSize = True
        ItemName_Label.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ItemName_Label.ForeColor = Color.White
        ItemName_Label.Location = New Point(12, 104)
        ItemName_Label.Name = "ItemName_Label"
        ItemName_Label.Size = New Size(97, 19)
        ItemName_Label.TabIndex = 10
        ItemName_Label.Text = "Item Name  -"
        ' 
        ' RenameTool
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(450, 210)
        Controls.Add(ItemName_Label)
        Controls.Add(Rename_Button)
        Controls.Add(Name_Box)
        Controls.Add(Object_Label)
        Controls.Add(Window_Panel)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "RenameTool"
        Text = "RenameTool"
        Window_Panel.ResumeLayout(False)
        Window_Panel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Window_Panel As Panel
    Friend WithEvents Maximize_Button As Label
    Friend WithEvents Minimize_Button As Label
    Friend WithEvents Close_Button As Label
    Friend WithEvents Form_Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Close_Label As Label
    Friend WithEvents Object_Label As Label
    Friend WithEvents Name_Box As TextBox
    Friend WithEvents Rename_Button As Button
    Friend WithEvents ItemName_Label As Label
End Class
