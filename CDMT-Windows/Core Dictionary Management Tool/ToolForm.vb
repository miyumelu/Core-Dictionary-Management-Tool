Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Core_Dictionary_Module
Imports neXt_Window_Managment_System

Public Class ToolForm

    Private _currentSelectedPath As String = ""
    Private _currentTreeRoot As String = ""
    Private _originalContent As String = ""
    Private _isLoading As Boolean = False
    Dim xela As New Main()
    Private drag As neXt_Window_Managment_System.Window ' Create variable to hold instance of neXt Window class

    Private Sub ToolForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drag = New neXt_Window_Managment_System.Window(Me) ' Create new instance of the neXt Window class
        drag.AddControl(Window_Panel) ' Add the panel that will act as the title bar
        drag.AddControl(Form_Label) ' Add the label that will also act as the title bar

        _currentTreeRoot = xela.AutoTree(File_Tree, Main.ObjectLevel.Root)
        LoadTree(_currentTreeRoot)
    End Sub

    Private Sub Maximize_Button_Click(sender As Object, e As EventArgs) Handles Maximize_Button.Click
        If drag._isMaxed Then
            drag.OriginalSize()
        Else
            drag.MaximizeFull()
        End If
    End Sub

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Button_Click(sender As Object, e As EventArgs) Handles Minimize_Button.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub File_Tree_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles File_Tree.NodeMouseDoubleClick
        If e.Node.Tag IsNot Nothing Then
            LoadTree(e.Node.Tag.ToString())
        End If
    End Sub

    Private Sub GetDataContent_Button_Click(sender As Object, e As EventArgs) Handles GetDataContent_Button.Click
        If File_Tree.SelectedNode IsNot Nothing AndAlso File_Tree.SelectedNode.Tag IsNot Nothing Then
            LoadTree(File_Tree.SelectedNode.Tag.ToString())
        Else
            MessageBox.Show("Please select an object first.")
        End If
    End Sub

    Private Sub LoadTree(filePath As String)
        _isLoading = True
        _currentSelectedPath = filePath

        Try
            If File.Exists(filePath) Then
                Dim info As New FileInfo(filePath)
                Object_Label.Text = info.Name
                SizeInfo_Label.Text = "Size - " & info.Length.ToString("N0") & " Bytes"
                Date_Label.Text = info.LastWriteTime.ToString("dd.MM.yyyy - HH:mm:ss")

                Dim content As Object = Nothing

                If filePath.EndsWith(".word") Then
                    content = xela.MRead_String(filePath)
                    Type_Label.Text = "Content Type - String"
                ElseIf filePath.EndsWith(".val") Then
                    content = xela.MRead_Integer(filePath)
                    Type_Label.Text = "Content Type - Value"
                ElseIf filePath.EndsWith(".sta") Then
                    content = xela.MRead_Boolean(filePath)
                    Type_Label.Text = "Content Type - Boolean"
                End If

                If content IsNot Nothing Then
                    Content_Box.Text = content.ToString()
                    _originalContent = content.ToString()
                Else
                    Content_Box.Text = String.Empty
                    _originalContent = String.Empty
                End If

            ElseIf Directory.Exists(filePath) Then
                Dim info As New DirectoryInfo(filePath)
                Dim sizeInKB As Double = DirectorySize(filePath)
                Object_Label.Text = Path.GetFileName(filePath.TrimEnd("\"c))
                SizeInfo_Label.Text = "Size - " & sizeInKB.ToString("N2") & " KB"
                Date_Label.Text = info.LastWriteTime.ToString("dd.MM.yyyy - HH:mm:ss")
                Type_Label.Text = "Content Type - Directory"
                Content_Box.Text = String.Empty
                _originalContent = String.Empty
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading item: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            _isLoading = False
        End Try
    End Sub
    Private Function DirectorySize(path As String) As Double
        Try
            Dim dirInfo As New DirectoryInfo(path)
            Dim files = dirInfo.GetFiles("*.*", SearchOption.AllDirectories)
            Dim totalBytes As Long = files.Sum(Function(f) f.Length)
            Return totalBytes / 1024
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub Rename_Button_Click(sender As Object, e As EventArgs) Handles Rename_Button.Click
        If String.IsNullOrEmpty(_currentSelectedPath) Then Exit Sub

        RenameTool.TargetPath = _currentSelectedPath

        If RenameTool.ShowDialog() = DialogResult.OK Then
            If Not String.IsNullOrEmpty(_currentTreeRoot) Then
                xela.Tree(File_Tree, _currentTreeRoot)

                _currentSelectedPath = ""
                Object_Label.Text = "Select Item"
                Content_Box.Clear()
                SizeInfo_Label.Text = "Size - N/A"
                Date_Label.Text = "N/A"
                Type_Label.Text = "Content Type - N/A"
            Else
                _currentTreeRoot = xela.AutoTree(File_Tree, Main.ObjectLevel.Root)
            End If
        End If
    End Sub

    Private Sub MTree_Button_Click(sender As Object, e As EventArgs) Handles MTree_Button.Click
        Using fbd As New FolderBrowserDialog()
            fbd.Description = "Select a folder to set as the new Root Tree"
            fbd.ShowNewFolderButton = True

            If fbd.ShowDialog() = DialogResult.OK Then
                _currentTreeRoot = xela.ManualTree(File_Tree, fbd.SelectedPath)

                Object_Label.Text = "Root changed"
                _currentSelectedPath = ""
                Content_Box.Clear()
                SizeInfo_Label.Text = "Size - N/A"
                Date_Label.Text = "N/A"
                Type_Label.Text = "Content Type - N/A"
            End If
        End Using
    End Sub

    Private Sub QuickSave_Button_Click(sender As Object, e As EventArgs) Handles QuickSave_Button.Click
        If String.IsNullOrEmpty(_currentSelectedPath) OrElse Not File.Exists(_currentSelectedPath) Then
            MessageBox.Show("Please select a file to save first.")
            Exit Sub
        End If

        Dim success As Boolean = False
        Dim rawContent As String = Content_Box.Text

        Try
            If _currentSelectedPath.EndsWith(".word") Then
                success = xela.MWrite_String(_currentSelectedPath, rawContent)
            ElseIf _currentSelectedPath.EndsWith(".val") Then
                Dim intValue As Integer
                If Integer.TryParse(rawContent, intValue) Then success = xela.MWrite_Integer(_currentSelectedPath, intValue)
            ElseIf _currentSelectedPath.EndsWith(".sta") Then
                Dim boolValue As Boolean
                If Boolean.TryParse(rawContent, boolValue) Then success = xela.MWrite_Boolean(_currentSelectedPath, boolValue)
            End If

            If success Then
                _originalContent = rawContent
                If Object_Label.Text.EndsWith("*") Then
                    Object_Label.Text = Object_Label.Text.TrimEnd("*"c)
                End If

                Dim info As New FileInfo(_currentSelectedPath)
                SizeInfo_Label.Text = "Size - " & info.Length.ToString("N0") & " Bytes"
                Date_Label.Text = info.LastWriteTime.ToString("dd.MM.yyyy - HH:mm:ss")

                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Convert_Button_Click(sender As Object, e As EventArgs) Handles Convert_Button.Click
        If String.IsNullOrEmpty(_currentSelectedPath) OrElse Not File.Exists(_currentSelectedPath) Then
            MessageBox.Show("Please select a file first.")
            Exit Sub
        End If

        ConvertTool.TargetPath = _currentSelectedPath
        If ConvertTool.ShowDialog() = DialogResult.OK Then
            If Not String.IsNullOrEmpty(_currentTreeRoot) Then
                xela.Tree(File_Tree, _currentTreeRoot)
            End If
            LoadTree(_currentSelectedPath)
        End If
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        If String.IsNullOrEmpty(_currentSelectedPath) Then
            MessageBox.Show("Please select an item to delete first.", "Selection Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim itemName As String = Path.GetFileName(_currentSelectedPath.TrimEnd("\"c))
        Dim result = MessageBox.Show("Are you sure you want to delete '" & itemName & "'?" & vbCrLf &
                                     "This action cannot be undone!", "Confirm Delete",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                If File.Exists(_currentSelectedPath) Then
                    File.Delete(_currentSelectedPath)
                ElseIf Directory.Exists(_currentSelectedPath) Then
                    Directory.Delete(_currentSelectedPath, True)
                End If

                MessageBox.Show("Item deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If Not String.IsNullOrEmpty(_currentTreeRoot) Then
                    xela.Tree(File_Tree, _currentTreeRoot)
                    If File_Tree.Nodes.Count > 0 Then File_Tree.Nodes(0).Expand()
                End If

                _currentSelectedPath = ""
                Object_Label.Text = "Select Item"
                Content_Box.Clear()
                SizeInfo_Label.Text = "Size - N/A"
                Date_Label.Text = "N/A"
                Type_Label.Text = "Content Type - N/A"

            Catch ex As Exception
                MessageBox.Show("Error during deletion: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Create_Button_Click(sender As Object, e As EventArgs) Handles Create_Button.Click
        Dim targetDir As String = _currentTreeRoot

        If Not String.IsNullOrEmpty(_currentSelectedPath) Then
            If Directory.Exists(_currentSelectedPath) Then
                targetDir = _currentSelectedPath
            Else
                targetDir = Path.GetDirectoryName(_currentSelectedPath)
            End If
        End If

        Using f4 As New CreateTool()
            f4.BaseDestination = targetDir

            If f4.ShowDialog() = DialogResult.OK Then
                xela.Tree(File_Tree, _currentTreeRoot)

                If Not String.IsNullOrEmpty(f4.CreatedPath) Then
                    LoadTree(f4.CreatedPath)
                    Content_Box.Focus()
                End If
            End If
        End Using
    End Sub

    Private Sub SA_Button_Click(sender As Object, e As EventArgs) Handles SA_Button.Click
        _currentTreeRoot = xela.AutoTree(File_Tree, Main.ObjectLevel.SysApps)
        LoadTree(_currentTreeRoot)
    End Sub

    Private Sub SE_Button_Click(sender As Object, e As EventArgs) Handles SE_Button.Click
        _currentTreeRoot = xela.AutoTree(File_Tree, Main.ObjectLevel.SysExt)
        LoadTree(_currentTreeRoot)
    End Sub

    Private Sub R_Button_Click(sender As Object, e As EventArgs) Handles R_Button.Click
        _currentTreeRoot = xela.AutoTree(File_Tree, Main.ObjectLevel.Root)
        LoadTree(_currentTreeRoot)
    End Sub

    Private Sub Content_Box_TextChanged(sender As Object, e As EventArgs) Handles Content_Box.TextChanged
        If _isLoading Then Exit Sub

        If File.Exists(_currentSelectedPath) Then
            Dim isChanged As Boolean = (Content_Box.Text <> _originalContent)

            If isChanged Then
                If Not Object_Label.Text.EndsWith("*") Then
                    Object_Label.Text &= "*"
                End If
            Else
                If Object_Label.Text.EndsWith("*") Then
                    Object_Label.Text = Object_Label.Text.TrimEnd("*"c)
                End If
            End If
        End If
    End Sub

    Private Sub Refresh_Button_Click(sender As Object, e As EventArgs) Handles Refresh_Button.Click
        If Not String.IsNullOrEmpty(_currentTreeRoot) Then
            Try
                xela.Tree(File_Tree, _currentTreeRoot)
                If File_Tree.Nodes.Count > 0 Then
                    File_Tree.Nodes(0).Expand()
                End If

                If Not String.IsNullOrEmpty(_currentSelectedPath) Then
                    LoadTree(_currentSelectedPath)
                End If

            Catch ex As Exception
                MessageBox.Show("Error during refresh: " & ex.Message, "Refresh Error")
            End Try
        Else
            _currentTreeRoot = xela.AutoTree(File_Tree, Main.ObjectLevel.Root)
        End If
    End Sub
End Class