Imports System.Drawing.Imaging
Imports Core_Dictionary_Module
Imports System.IO

Public Class CreateTool
    Public Property BaseDestination As String
    Public Property CreatedPath As String
    Private drag As neXt_Window_Managment_System.Window
    Dim xela As New Main()

    Private Sub Create_Button_Click(sender As Object, e As EventArgs) Handles Create_Button.Click
        Dim objName As String = Name_Box.Text.Trim()
        If String.IsNullOrEmpty(objName) Then Exit Sub

        Try
            Select Case Target_Box.SelectedIndex
                Case 0
                    CreatedPath = Path.Combine(BaseDestination, objName & ".word")
                    xela.CreateObject(objName, BaseDestination, Main.ObjectType.StringObject, "")
                Case 1
                    CreatedPath = Path.Combine(BaseDestination, objName & ".val")
                    xela.CreateObject(objName, BaseDestination, Main.ObjectType.IntegerObject, 0)
                Case 2
                    CreatedPath = Path.Combine(BaseDestination, objName & ".sta")
                    xela.CreateObject(objName, BaseDestination, Main.ObjectType.BooleanObject, False)
                Case 3
                    CreatedPath = Path.Combine(BaseDestination, objName)
                    Directory.CreateDirectory(CreatedPath)
            End Select

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CreateTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drag = New neXt_Window_Managment_System.Window(Me)
        drag.AddControl(Window_Panel)
        drag.AddControl(Form_Label)

        Target_Box.Items.Clear()
        Target_Box.Items.AddRange({".word (String)", ".val (Integer)", ".sta (Boolean)", "Folder"})
        Target_Box.SelectedIndex = 0
    End Sub

    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Button_Click(sender As Object, e As EventArgs) Handles Minimize_Button.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class