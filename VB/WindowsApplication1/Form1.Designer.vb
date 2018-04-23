Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumnFirstFile = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.gridColumnLineNumber = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnSecondFile = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(945, 663)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumnFirstFile, Me.gridColumnLineNumber, Me.gridColumnSecondFile})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridView1.OptionsSelection.EnableAppearanceFocusedRow = False
			Me.gridView1.OptionsSelection.EnableAppearanceHideSelection = False
			Me.gridView1.OptionsSelection.UseIndicatorForSelection = False
			Me.gridView1.OptionsView.RowAutoHeight = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsView.ShowIndicator = False
'			Me.gridView1.RowStyle += New DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(Me.gridView1_RowStyle);
'			Me.gridView1.CustomColumnDisplayText += New DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(Me.gridView1_CustomColumnDisplayText);
			' 
			' gridColumnFirstFile
			' 
			Me.gridColumnFirstFile.Caption = "File 1"
			Me.gridColumnFirstFile.ColumnEdit = Me.repositoryItemMemoEdit1
			Me.gridColumnFirstFile.FieldName = "FirstFileLine"
			Me.gridColumnFirstFile.Name = "gridColumnFirstFile"
			Me.gridColumnFirstFile.Visible = True
			Me.gridColumnFirstFile.VisibleIndex = 0
			Me.gridColumnFirstFile.Width = 259
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
			' 
			' gridColumnLineNumber
			' 
			Me.gridColumnLineNumber.AppearanceCell.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			Me.gridColumnLineNumber.AppearanceCell.BackColor2 = System.Drawing.Color.Silver
			Me.gridColumnLineNumber.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.gridColumnLineNumber.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			Me.gridColumnLineNumber.AppearanceCell.Options.UseBackColor = True
			Me.gridColumnLineNumber.AppearanceCell.Options.UseFont = True
			Me.gridColumnLineNumber.AppearanceCell.Options.UseTextOptions = True
			Me.gridColumnLineNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.gridColumnLineNumber.Caption = "Line number"
			Me.gridColumnLineNumber.FieldName = "gridColumnLineNumber"
			Me.gridColumnLineNumber.Name = "gridColumnLineNumber"
			Me.gridColumnLineNumber.OptionsColumn.AllowEdit = False
			Me.gridColumnLineNumber.OptionsColumn.AllowFocus = False
			Me.gridColumnLineNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnLineNumber.OptionsColumn.AllowMove = False
			Me.gridColumnLineNumber.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnLineNumber.OptionsColumn.FixedWidth = True
			Me.gridColumnLineNumber.OptionsColumn.ReadOnly = True
			Me.gridColumnLineNumber.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			Me.gridColumnLineNumber.Visible = True
			Me.gridColumnLineNumber.VisibleIndex = 1
			Me.gridColumnLineNumber.Width = 95
			' 
			' gridColumnSecondFile
			' 
			Me.gridColumnSecondFile.Caption = "File 2"
			Me.gridColumnSecondFile.ColumnEdit = Me.repositoryItemMemoEdit1
			Me.gridColumnSecondFile.FieldName = "SecondFileLine"
			Me.gridColumnSecondFile.Name = "gridColumnSecondFile"
			Me.gridColumnSecondFile.Visible = True
			Me.gridColumnSecondFile.VisibleIndex = 2
			Me.gridColumnSecondFile.Width = 266
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' button1
			' 
			Me.button1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.button1.Location = New System.Drawing.Point(0, 640)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(945, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Check"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(945, 663)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumnFirstFile As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnLineNumber As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnSecondFile As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents button1 As System.Windows.Forms.Button
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
	End Class
End Namespace

