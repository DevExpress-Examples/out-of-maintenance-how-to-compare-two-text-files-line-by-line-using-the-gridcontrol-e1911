Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = ParseFiles("test1.txt", "test2.txt")
		End Sub

		Private Function ParseFiles(ByVal path1 As String, ByVal path2 As String) As BindingList(Of LineClass)
			Dim list As New BindingList(Of LineClass)()
			Try
				Dim max As Integer = 0
				Using sr As New StreamReader(path1)
					Dim line As String
					line = sr.ReadLine()
					Do While line IsNot Nothing
						list.Add(New LineClass(line, ""))
						max += 1
						line = sr.ReadLine()
					Loop
				End Using

				Dim i As Integer = 0
				Using sr As New StreamReader(path2)
					Dim line As String
					line = sr.ReadLine()
					Do While line IsNot Nothing AndAlso i <= max
						list(i).SecondFileLine = line
						i += 1
						line = sr.ReadLine()
					Loop
				End Using
			Catch e As Exception
				Console.WriteLine("The file could not be read:")
				Console.WriteLine(e.Message)
			End Try
			Return list
		End Function

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			If e.Column Is gridColumnLineNumber Then
				e.Value = e.RowHandle
				Return
			End If
		End Sub

		Private Function ValuesAreEqual(ByVal rowHandle As Integer) As Boolean
			 Dim value1 As Object = gridView1.GetRowCellValue(rowHandle, gridColumnFirstFile)
			Dim value2 As Object = gridView1.GetRowCellValue(rowHandle, gridColumnSecondFile)
			Return (Convert.ToString(value1).Equals(Convert.ToString(value2)))
		End Function

		Private Sub gridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView1.RowStyle
			If (Not ValuesAreEqual(e.RowHandle)) Then
				e.Appearance.BackColor = Color.Red
			End If
		End Sub

		Private Sub Check()
			For i As Integer = 0 To gridView1.DataRowCount - 1
				If (Not ValuesAreEqual(i)) Then
					MessageBox.Show(String.Format("Error in  {0} line:" & Constants.vbLf & "[{1}]" & Constants.vbLf & "[{2}]", i, gridView1.GetRowCellValue(i, gridColumnFirstFile), gridView1.GetRowCellValue(i, gridColumnSecondFile)))
					gridView1.FocusedRowHandle = i
					gridView1.FocusedColumn = gridColumnFirstFile
					gridView1.ShowEditor()
					If gridView1.ActiveEditor IsNot Nothing Then
						If XtraMessageBox.Show("Correct this value?", "Question", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
							gridView1.ActiveEditor.Text = gridView1.GetRowCellValue(i, gridColumnSecondFile).ToString()
						End If
						gridView1.ActiveEditor.SelectAll()
					End If
					Return
				End If
			Next i
		End Sub


		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Check()
		End Sub

	End Class
End Namespace