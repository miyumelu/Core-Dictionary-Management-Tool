Imports System.IO
Imports System.Numerics
Imports Core_Dictionary_Module
Imports neXt_Motion_Engine

Public Class RenameTool
    Public Property TargetPath As String
    Private xela As New Main()
    Private drag As neXt_Window_Managment_System.Window
    Dim u As New Motions()

    Private Sub RenameTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drag = New neXt_Window_Managment_System.Window(Me)
        drag.AddControl(Window_Panel)
        drag.AddControl(Form_Label)

        If File.Exists(TargetPath) Then
            Name_Box.Text = Path.GetFileNameWithoutExtension(TargetPath)
            Object_Label.Text = "Object - " & Path.GetFileName(TargetPath)
        Else
            Name_Box.Text = Path.GetFileName(TargetPath)
        End If
    End Sub

    Private Async Sub Rename_Button_Click(sender As Object, e As EventArgs) Handles Rename_Button.Click
        Dim newPath As String = xela.EnhancedRename(TargetPath, Name_Box.Text)

        If Not String.IsNullOrEmpty(newPath) Then
            Me.DialogResult = DialogResult.OK
            Me.Close()

            Await u.Peak()
        Else
            MessageBox.Show("Error: Could not rename object.")
        End If
    End Sub

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Button_Click(sender As Object, e As EventArgs) Handles Minimize_Button.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class