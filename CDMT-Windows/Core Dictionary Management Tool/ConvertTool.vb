Imports System.IO
Imports Core_Dictionary_Module

Public Class ConvertTool
    Public Property TargetPath As String
    Dim xela As New Main()
    Private drag As neXt_Window_Managment_System.Window
    Dim u As New Motions

    Private Sub ConvertTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drag = New neXt_Window_Managment_System.Window(Me)
        drag.AddControl(Window_Panel)
        drag.AddControl(Form_Label)

        Target_Box.Items.AddRange({".word", ".val", ".sta"})
        Object_Label.Text = Path.GetFileName(TargetPath)
    End Sub

    Private Async Sub Convert_Button_Click(sender As Object, e As EventArgs) Handles Convert_Button.Click
        Dim targetExt As String = Target_Box.SelectedItem?.ToString()
        If String.IsNullOrEmpty(targetExt) Then Exit Sub

        Dim currentExt As String = Path.GetExtension(TargetPath).ToLower()
        If currentExt = targetExt Then
            MessageBox.Show("File already has this extension.")
            Exit Sub
        End If

        Dim needsReset As Boolean = False
        Dim currentContent As String = File.ReadAllText(TargetPath)

        If targetExt = ".val" Then
            Dim dummyInt As Integer
            If Not Integer.TryParse(currentContent, dummyInt) Then needsReset = True
        ElseIf targetExt = ".sta" Then
            Dim dummyBool As Boolean
            If Not Boolean.TryParse(currentContent, dummyBool) Then needsReset = True
        End If

        If needsReset Then
            Dim result = MessageBox.Show("Warning: The current content cannot be converted safely. " &
                                       "Converting will reset the information to default values. Continue?",
                                       "Data Loss Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then Exit Sub
        End If

        Try
            Dim newPath As String = Path.ChangeExtension(TargetPath, targetExt)

            If File.Exists(newPath) Then
                MessageBox.Show("A file with this extension already exists.")
                Exit Sub
            End If

            File.Move(TargetPath, newPath)

            If needsReset Then
                If targetExt = ".val" Then xela.MWrite_Integer(newPath, 0)
                If targetExt = ".sta" Then xela.MWrite_Boolean(newPath, False)
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

            Await u.Peak()
        Catch ex As Exception
            MessageBox.Show("Convert failed: " & ex.Message)
        End Try
    End Sub

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Button_Click(sender As Object, e As EventArgs) Handles Minimize_Button.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class