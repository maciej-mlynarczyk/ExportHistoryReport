namespace ExportHistoryReport.Forms
{
    partial class Report
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
            this.FilterPanel = new DevExpress.XtraEditors.SidePanel();
            this.DateTillFilterEdit = new DevExpress.XtraEditors.DateEdit();
            this.DateSinceFilterEdit = new DevExpress.XtraEditors.DateEdit();
            this.FilterAcceptButton = new DevExpress.XtraEditors.SimpleButton();
            this.LocationFilterEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ExportHistoryGrid = new DevExpress.XtraGrid.GridControl();
            this.ExportHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateTillFilterEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTillFilterEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateSinceFilterEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateSinceFilterEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationFilterEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportHistoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.DateTillFilterEdit);
            this.FilterPanel.Controls.Add(this.DateSinceFilterEdit);
            this.FilterPanel.Controls.Add(this.FilterAcceptButton);
            this.FilterPanel.Controls.Add(this.LocationFilterEdit);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(227, 450);
            this.FilterPanel.TabIndex = 0;
            // 
            // DateTillFilterEdit
            // 
            this.DateTillFilterEdit.EditValue = null;
            this.DateTillFilterEdit.Location = new System.Drawing.Point(13, 65);
            this.DateTillFilterEdit.Name = "DateTillFilterEdit";
            this.DateTillFilterEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.DateTillFilterEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTillFilterEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTillFilterEdit.Properties.NullText = "Do:";
            this.DateTillFilterEdit.Properties.NullValuePrompt = "Do:";
            this.DateTillFilterEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.DateTillFilterEdit.Properties.ShowNullValuePromptWhenFocused = true;
            this.DateTillFilterEdit.Properties.DateTimeChanged += new System.EventHandler(this.DateTillFilterEdit_Properties_DateTimeChanged);
            this.DateTillFilterEdit.Size = new System.Drawing.Size(198, 20);
            this.DateTillFilterEdit.TabIndex = 2;
            // 
            // DateSinceFilterEdit
            // 
            this.DateSinceFilterEdit.EditValue = null;
            this.DateSinceFilterEdit.Location = new System.Drawing.Point(13, 39);
            this.DateSinceFilterEdit.Name = "DateSinceFilterEdit";
            this.DateSinceFilterEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.DateSinceFilterEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateSinceFilterEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateSinceFilterEdit.Properties.NullText = "Od:";
            this.DateSinceFilterEdit.Properties.NullValuePrompt = "Od:";
            this.DateSinceFilterEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.DateSinceFilterEdit.Properties.ShowNullValuePromptWhenFocused = true;
            this.DateSinceFilterEdit.Properties.DateTimeChanged += new System.EventHandler(this.DateSinceFilterEdit_Properties_DateTimeChanged);
            this.DateSinceFilterEdit.Size = new System.Drawing.Size(198, 20);
            this.DateSinceFilterEdit.TabIndex = 2;
            // 
            // FilterAcceptButton
            // 
            this.FilterAcceptButton.Location = new System.Drawing.Point(12, 415);
            this.FilterAcceptButton.Name = "FilterAcceptButton";
            this.FilterAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.FilterAcceptButton.TabIndex = 0;
            this.FilterAcceptButton.Text = "Zatwierdź";
            this.FilterAcceptButton.Click += new System.EventHandler(this.FilterAcceptButton_Click);
            // 
            // LocationFilterEdit
            // 
            this.LocationFilterEdit.EditValue = "";
            this.LocationFilterEdit.Location = new System.Drawing.Point(12, 12);
            this.LocationFilterEdit.Name = "LocationFilterEdit";
            this.LocationFilterEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.LocationFilterEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LocationFilterEdit.Properties.NullText = "Lokal:";
            this.LocationFilterEdit.Properties.NullValuePrompt = "Lokal:";
            this.LocationFilterEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.LocationFilterEdit.Properties.ShowNullValuePromptWhenFocused = true;
            this.LocationFilterEdit.Properties.Sorted = true;
            this.LocationFilterEdit.Size = new System.Drawing.Size(199, 20);
            this.LocationFilterEdit.TabIndex = 1;
            // 
            // ExportHistoryGrid
            // 
            this.ExportHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportHistoryGrid.Location = new System.Drawing.Point(227, 0);
            this.ExportHistoryGrid.MainView = this.ExportHistoryGridView;
            this.ExportHistoryGrid.Name = "ExportHistoryGrid";
            this.ExportHistoryGrid.Size = new System.Drawing.Size(770, 450);
            this.ExportHistoryGrid.TabIndex = 1;
            this.ExportHistoryGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ExportHistoryGridView});
            // 
            // ExportHistoryGridView
            // 
            this.ExportHistoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NameColumn,
            this.DateColumn,
            this.TimeColumn,
            this.UserColumn,
            this.LocationColumn});
            this.ExportHistoryGridView.GridControl = this.ExportHistoryGrid;
            this.ExportHistoryGridView.Name = "ExportHistoryGridView";
            this.ExportHistoryGridView.OptionsBehavior.Editable = false;
            this.ExportHistoryGridView.OptionsView.ShowGroupPanel = false;
            // 
            // NameColumn
            // 
            this.NameColumn.Caption = "Nazwa";
            this.NameColumn.FieldName = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Visible = true;
            this.NameColumn.VisibleIndex = 0;
            // 
            // DateColumn
            // 
            this.DateColumn.Caption = "Data";
            this.DateColumn.DisplayFormat.FormatString = "d";
            this.DateColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateColumn.FieldName = "ExecutionDateTime";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.DateColumn.Visible = true;
            this.DateColumn.VisibleIndex = 1;
            // 
            // TimeColumn
            // 
            this.TimeColumn.Caption = "Godzina";
            this.TimeColumn.DisplayFormat.FormatString = "hh:mm";
            this.TimeColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TimeColumn.FieldName = "ExecutionDateTime";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.TimeColumn.Visible = true;
            this.TimeColumn.VisibleIndex = 2;
            // 
            // UserColumn
            // 
            this.UserColumn.Caption = "Użytkownik";
            this.UserColumn.FieldName = "UserName";
            this.UserColumn.Name = "UserColumn";
            this.UserColumn.Visible = true;
            this.UserColumn.VisibleIndex = 3;
            // 
            // LocationColumn
            // 
            this.LocationColumn.Caption = "Lokal";
            this.LocationColumn.FieldName = "LocationName";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.Visible = true;
            this.LocationColumn.VisibleIndex = 4;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.ExportHistoryGrid);
            this.Controls.Add(this.FilterPanel);
            this.Name = "Report";
            this.Text = "Raport";
            this.FilterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateTillFilterEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTillFilterEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateSinceFilterEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateSinceFilterEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationFilterEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportHistoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportHistoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel FilterPanel;
        private DevExpress.XtraEditors.ComboBoxEdit LocationFilterEdit;
        private DevExpress.XtraGrid.GridControl ExportHistoryGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView ExportHistoryGridView;
        private DevExpress.XtraGrid.Columns.GridColumn NameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn UserColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LocationColumn;
        private DevExpress.XtraEditors.SimpleButton FilterAcceptButton;
        private DevExpress.XtraEditors.DateEdit DateSinceFilterEdit;
        private DevExpress.XtraEditors.DateEdit DateTillFilterEdit;
    }
}

