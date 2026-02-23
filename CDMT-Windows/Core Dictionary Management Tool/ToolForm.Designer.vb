<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolForm))
        File_Tree = New TreeView()
        Window_Panel = New Panel()
        Maximize_Button = New Label()
        Minimize_Button = New Label()
        Close_Button = New Label()
        Form_Label = New Label()
        Object_Label = New Label()
        Type_Label = New Label()
        Content_Box = New RichTextBox()
        Option_Bar = New MenuStrip()
        Tree_Menu = New ToolStripMenuItem()
        SystemTreeToolStripMenuItem = New ToolStripMenuItem()
        SA_Button = New ToolStripMenuItem()
        SE_Button = New ToolStripMenuItem()
        R_Button = New ToolStripMenuItem()
        MTree_Button = New ToolStripMenuItem()
        Refresh_Button = New ToolStripMenuItem()
        File_Menu = New ToolStripMenuItem()
        Create_Button = New ToolStripMenuItem()
        Convert_Button = New ToolStripMenuItem()
        Delete_Button = New ToolStripMenuItem()
        LTE_Button = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        BoxBorder = New PictureBox()
        GetDataContent_Button = New Button()
        QuickSave_Button = New Button()
        SizeInfo_Label = New Label()
        Date_Label = New Label()
        Rename_Button = New Button()
        Window_Panel.SuspendLayout()
        Option_Bar.SuspendLayout()
        CType(BoxBorder, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' File_Tree
        ' 
        File_Tree.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        File_Tree.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        File_Tree.BorderStyle = BorderStyle.None
        File_Tree.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        File_Tree.ForeColor = Color.White
        File_Tree.Location = New Point(0, 80)
        File_Tree.Name = "File_Tree"
        File_Tree.Size = New Size(200, 430)
        File_Tree.TabIndex = 0
        ' 
        ' Window_Panel
        ' 
        Window_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Window_Panel.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Window_Panel.Controls.Add(Maximize_Button)
        Window_Panel.Controls.Add(Minimize_Button)
        Window_Panel.Controls.Add(Close_Button)
        Window_Panel.Controls.Add(Form_Label)
        Window_Panel.Location = New Point(0, 0)
        Window_Panel.Name = "Window_Panel"
        Window_Panel.Size = New Size(940, 40)
        Window_Panel.TabIndex = 1
        ' 
        ' Maximize_Button
        ' 
        Maximize_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Maximize_Button.AutoSize = True
        Maximize_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Maximize_Button.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        Maximize_Button.Location = New Point(877, 9)
        Maximize_Button.Name = "Maximize_Button"
        Maximize_Button.Size = New Size(23, 19)
        Maximize_Button.TabIndex = 9
        Maximize_Button.Text = "[ ]"
        ' 
        ' Minimize_Button
        ' 
        Minimize_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Minimize_Button.AutoSize = True
        Minimize_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Minimize_Button.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        Minimize_Button.Location = New Point(854, 10)
        Minimize_Button.Name = "Minimize_Button"
        Minimize_Button.Size = New Size(16, 19)
        Minimize_Button.TabIndex = 8
        Minimize_Button.Text = "-"
        ' 
        ' Close_Button
        ' 
        Close_Button.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Close_Button.AutoSize = True
        Close_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Close_Button.ForeColor = Color.Red
        Close_Button.Location = New Point(906, 10)
        Close_Button.Name = "Close_Button"
        Close_Button.Size = New Size(19, 19)
        Close_Button.TabIndex = 7
        Close_Button.Text = "X"
        ' 
        ' Form_Label
        ' 
        Form_Label.AutoSize = True
        Form_Label.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Form_Label.ForeColor = Color.White
        Form_Label.Location = New Point(12, 10)
        Form_Label.Name = "Form_Label"
        Form_Label.Size = New Size(241, 19)
        Form_Label.TabIndex = 6
        Form_Label.Text = "Core Dictionary Management Tool"
        ' 
        ' Object_Label
        ' 
        Object_Label.AutoSize = True
        Object_Label.Font = New Font("SF UI Display Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Object_Label.ForeColor = Color.White
        Object_Label.Location = New Point(214, 83)
        Object_Label.Name = "Object_Label"
        Object_Label.Size = New Size(331, 44)
        Object_Label.TabIndex = 2
        Object_Label.Text = "Current Object.word"
        ' 
        ' Type_Label
        ' 
        Type_Label.AutoSize = True
        Type_Label.Font = New Font("SF UI Display Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Type_Label.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        Type_Label.Location = New Point(220, 126)
        Type_Label.Name = "Type_Label"
        Type_Label.Size = New Size(161, 23)
        Type_Label.TabIndex = 3
        Type_Label.Text = "Object Type String"
        ' 
        ' Content_Box
        ' 
        Content_Box.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Content_Box.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        Content_Box.BorderStyle = BorderStyle.None
        Content_Box.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Content_Box.ForeColor = Color.White
        Content_Box.Location = New Point(230, 170)
        Content_Box.Name = "Content_Box"
        Content_Box.Size = New Size(680, 300)
        Content_Box.TabIndex = 4
        Content_Box.Text = "Content"
        ' 
        ' Option_Bar
        ' 
        Option_Bar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Option_Bar.AutoSize = False
        Option_Bar.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Option_Bar.Dock = DockStyle.None
        Option_Bar.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Option_Bar.Items.AddRange(New ToolStripItem() {Tree_Menu, File_Menu, LTE_Button, ToolStripMenuItem1})
        Option_Bar.Location = New Point(0, 40)
        Option_Bar.Name = "Option_Bar"
        Option_Bar.Size = New Size(940, 40)
        Option_Bar.TabIndex = 5
        Option_Bar.Text = "MenuStrip1"
        ' 
        ' Tree_Menu
        ' 
        Tree_Menu.DropDownItems.AddRange(New ToolStripItem() {SystemTreeToolStripMenuItem, MTree_Button, Refresh_Button})
        Tree_Menu.ForeColor = Color.White
        Tree_Menu.Name = "Tree_Menu"
        Tree_Menu.Size = New Size(50, 36)
        Tree_Menu.Text = "Tree"
        ' 
        ' SystemTreeToolStripMenuItem
        ' 
        SystemTreeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SA_Button, SE_Button, R_Button})
        SystemTreeToolStripMenuItem.Name = "SystemTreeToolStripMenuItem"
        SystemTreeToolStripMenuItem.Size = New Size(180, 24)
        SystemTreeToolStripMenuItem.Text = "System Tree"
        ' 
        ' SA_Button
        ' 
        SA_Button.Name = "SA_Button"
        SA_Button.Size = New Size(208, 24)
        SA_Button.Text = "System Application"
        ' 
        ' SE_Button
        ' 
        SE_Button.Name = "SE_Button"
        SE_Button.Size = New Size(208, 24)
        SE_Button.Text = "System Extention"
        ' 
        ' R_Button
        ' 
        R_Button.Name = "R_Button"
        R_Button.Size = New Size(208, 24)
        R_Button.Text = "Root"
        ' 
        ' MTree_Button
        ' 
        MTree_Button.Name = "MTree_Button"
        MTree_Button.Size = New Size(180, 24)
        MTree_Button.Text = "Manual Tree"
        ' 
        ' Refresh_Button
        ' 
        Refresh_Button.Name = "Refresh_Button"
        Refresh_Button.Size = New Size(180, 24)
        Refresh_Button.Text = "Refresh Tree"
        ' 
        ' File_Menu
        ' 
        File_Menu.DropDownItems.AddRange(New ToolStripItem() {Create_Button, Convert_Button, Delete_Button})
        File_Menu.ForeColor = Color.White
        File_Menu.Name = "File_Menu"
        File_Menu.Size = New Size(43, 36)
        File_Menu.Text = "File"
        ' 
        ' Create_Button
        ' 
        Create_Button.Name = "Create_Button"
        Create_Button.Size = New Size(206, 24)
        Create_Button.Text = "Create New Object"
        ' 
        ' Convert_Button
        ' 
        Convert_Button.Name = "Convert_Button"
        Convert_Button.Size = New Size(206, 24)
        Convert_Button.Text = "Convert Object"
        ' 
        ' Delete_Button
        ' 
        Delete_Button.Name = "Delete_Button"
        Delete_Button.Size = New Size(206, 24)
        Delete_Button.Text = "Delete Object"
        ' 
        ' LTE_Button
        ' 
        LTE_Button.ForeColor = Color.White
        LTE_Button.Name = "LTE_Button"
        LTE_Button.Size = New Size(172, 36)
        LTE_Button.Text = "Light-Term Encryption"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(12, 36)
        ' 
        ' BoxBorder
        ' 
        BoxBorder.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BoxBorder.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        BoxBorder.Location = New Point(220, 160)
        BoxBorder.Name = "BoxBorder"
        BoxBorder.Size = New Size(700, 320)
        BoxBorder.TabIndex = 6
        BoxBorder.TabStop = False
        ' 
        ' GetDataContent_Button
        ' 
        GetDataContent_Button.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        GetDataContent_Button.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        GetDataContent_Button.FlatAppearance.BorderSize = 0
        GetDataContent_Button.FlatStyle = FlatStyle.Flat
        GetDataContent_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GetDataContent_Button.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        GetDataContent_Button.Location = New Point(0, 510)
        GetDataContent_Button.Name = "GetDataContent_Button"
        GetDataContent_Button.Size = New Size(200, 50)
        GetDataContent_Button.TabIndex = 7
        GetDataContent_Button.Text = "Get Data Content"
        GetDataContent_Button.UseVisualStyleBackColor = False
        ' 
        ' QuickSave_Button
        ' 
        QuickSave_Button.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        QuickSave_Button.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        QuickSave_Button.FlatStyle = FlatStyle.Flat
        QuickSave_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        QuickSave_Button.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        QuickSave_Button.Location = New Point(720, 495)
        QuickSave_Button.Name = "QuickSave_Button"
        QuickSave_Button.Size = New Size(200, 50)
        QuickSave_Button.TabIndex = 8
        QuickSave_Button.Text = "Quick Save"
        QuickSave_Button.UseVisualStyleBackColor = False
        ' 
        ' SizeInfo_Label
        ' 
        SizeInfo_Label.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SizeInfo_Label.Font = New Font("SF UI Display Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        SizeInfo_Label.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SizeInfo_Label.Location = New Point(647, 95)
        SizeInfo_Label.Name = "SizeInfo_Label"
        SizeInfo_Label.Size = New Size(273, 23)
        SizeInfo_Label.TabIndex = 9
        SizeInfo_Label.Text = "Size KB"
        SizeInfo_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Date_Label
        ' 
        Date_Label.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Date_Label.Font = New Font("SF UI Display Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Date_Label.ForeColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Date_Label.Location = New Point(647, 119)
        Date_Label.Name = "Date_Label"
        Date_Label.Size = New Size(273, 23)
        Date_Label.TabIndex = 10
        Date_Label.Text = "Last Change Date"
        Date_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Rename_Button
        ' 
        Rename_Button.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Rename_Button.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        Rename_Button.FlatStyle = FlatStyle.Flat
        Rename_Button.Font = New Font("SF UI Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Rename_Button.ForeColor = Color.FromArgb(CByte(0), CByte(190), CByte(100))
        Rename_Button.Location = New Point(510, 495)
        Rename_Button.Name = "Rename_Button"
        Rename_Button.Size = New Size(200, 50)
        Rename_Button.TabIndex = 11
        Rename_Button.Text = "Rename"
        Rename_Button.UseVisualStyleBackColor = False
        ' 
        ' ToolForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(940, 560)
        Controls.Add(Rename_Button)
        Controls.Add(Date_Label)
        Controls.Add(SizeInfo_Label)
        Controls.Add(QuickSave_Button)
        Controls.Add(GetDataContent_Button)
        Controls.Add(Content_Box)
        Controls.Add(Type_Label)
        Controls.Add(Object_Label)
        Controls.Add(Window_Panel)
        Controls.Add(File_Tree)
        Controls.Add(Option_Bar)
        Controls.Add(BoxBorder)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = Option_Bar
        Name = "ToolForm"
        Text = "ToolForm"
        Window_Panel.ResumeLayout(False)
        Window_Panel.PerformLayout()
        Option_Bar.ResumeLayout(False)
        Option_Bar.PerformLayout()
        CType(BoxBorder, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents File_Tree As TreeView
    Friend WithEvents Window_Panel As Panel
    Friend WithEvents Object_Label As Label
    Friend WithEvents Type_Label As Label
    Friend WithEvents Content_Box As RichTextBox
    Friend WithEvents Option_Bar As MenuStrip
    Friend WithEvents Close_Button As Label
    Friend WithEvents Form_Label As Label
    Friend WithEvents File_Menu As ToolStripMenuItem
    Friend WithEvents Tree_Menu As ToolStripMenuItem
    Friend WithEvents LTE_Button As ToolStripMenuItem
    Friend WithEvents BoxBorder As PictureBox
    Friend WithEvents GetDataContent_Button As Button
    Friend WithEvents QuickSave_Button As Button
    Friend WithEvents SizeInfo_Label As Label
    Friend WithEvents Date_Label As Label
    Friend WithEvents Rename_Button As Button
    Friend WithEvents Minimize_Button As Label
    Friend WithEvents Maximize_Button As Label
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SystemTreeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MTree_Button As ToolStripMenuItem
    Friend WithEvents Create_Button As ToolStripMenuItem
    Friend WithEvents Convert_Button As ToolStripMenuItem
    Friend WithEvents Delete_Button As ToolStripMenuItem
    Friend WithEvents SA_Button As ToolStripMenuItem
    Friend WithEvents SE_Button As ToolStripMenuItem
    Friend WithEvents R_Button As ToolStripMenuItem
    Friend WithEvents Refresh_Button As ToolStripMenuItem
End Class
