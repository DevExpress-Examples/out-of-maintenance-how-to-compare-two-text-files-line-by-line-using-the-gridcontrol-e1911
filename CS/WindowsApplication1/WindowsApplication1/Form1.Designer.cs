namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnFirstFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumnLineNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSecondFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(945, 663);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnFirstFile,
            this.gridColumnLineNumber,
            this.gridColumnSecondFile});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorzLines = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // gridColumnFirstFile
            // 
            this.gridColumnFirstFile.Caption = "File 1";
            this.gridColumnFirstFile.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumnFirstFile.FieldName = "FirstFileLine";
            this.gridColumnFirstFile.Name = "gridColumnFirstFile";
            this.gridColumnFirstFile.Visible = true;
            this.gridColumnFirstFile.VisibleIndex = 0;
            this.gridColumnFirstFile.Width = 259;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridColumnLineNumber
            // 
            this.gridColumnLineNumber.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumnLineNumber.AppearanceCell.BackColor2 = System.Drawing.Color.Silver;
            this.gridColumnLineNumber.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumnLineNumber.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumnLineNumber.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnLineNumber.AppearanceCell.Options.UseFont = true;
            this.gridColumnLineNumber.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnLineNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnLineNumber.Caption = "Line number";
            this.gridColumnLineNumber.FieldName = "gridColumnLineNumber";
            this.gridColumnLineNumber.Name = "gridColumnLineNumber";
            this.gridColumnLineNumber.OptionsColumn.AllowEdit = false;
            this.gridColumnLineNumber.OptionsColumn.AllowFocus = false;
            this.gridColumnLineNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnLineNumber.OptionsColumn.AllowMove = false;
            this.gridColumnLineNumber.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnLineNumber.OptionsColumn.FixedWidth = true;
            this.gridColumnLineNumber.OptionsColumn.ReadOnly = true;
            this.gridColumnLineNumber.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumnLineNumber.Visible = true;
            this.gridColumnLineNumber.VisibleIndex = 1;
            this.gridColumnLineNumber.Width = 95;
            // 
            // gridColumnSecondFile
            // 
            this.gridColumnSecondFile.Caption = "File 2";
            this.gridColumnSecondFile.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumnSecondFile.FieldName = "SecondFileLine";
            this.gridColumnSecondFile.Name = "gridColumnSecondFile";
            this.gridColumnSecondFile.Visible = true;
            this.gridColumnSecondFile.VisibleIndex = 2;
            this.gridColumnSecondFile.Width = 266;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(945, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstFile;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLineNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSecondFile;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}

