Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Public Class LineClass

		Private _FirstFileLine As String
		Public Property FirstFileLine() As String
			Get
				Return _FirstFileLine
			End Get
			Set(ByVal value As String)
				_FirstFileLine = value
			End Set
		End Property

		Private _SecondFileLine As String
		Public Property SecondFileLine() As String
			Get
				Return _SecondFileLine
			End Get
			Set(ByVal value As String)
				_SecondFileLine = value
			End Set
		End Property
		Public Sub New(ByVal f As String, ByVal s As String)
			FirstFileLine = f
			SecondFileLine = s
		End Sub
	End Class
End Namespace
