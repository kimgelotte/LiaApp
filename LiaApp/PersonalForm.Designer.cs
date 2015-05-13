namespace LiaApp
{
    partial class PersonalForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Create = new System.Windows.Forms.TabPage();
            this.dataGridViewCreate = new System.Windows.Forms.DataGridView();
            this.comboBoxCreate = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.TabPage();
            this.EditRevertButton = new System.Windows.Forms.Button();
            this.EditSaveButton = new System.Windows.Forms.Button();
            this.EditOKButton = new System.Windows.Forms.Button();
            this.EditCancelButton = new System.Windows.Forms.Button();
            this.EditDataGridView = new System.Windows.Forms.DataGridView();
            this.EditSelectLabel = new System.Windows.Forms.Label();
            this.EditSelectCombobox = new System.Windows.Forms.ComboBox();
            this.Absence = new System.Windows.Forms.TabPage();
            this.OrderVisit = new System.Windows.Forms.TabPage();
            this.OkButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BookSaveButton = new System.Windows.Forms.Button();
            this.VisitOrders = new System.Windows.Forms.Label();
            this.dataGridViewOrderVisit = new System.Windows.Forms.DataGridView();
            this.OrderVisitOkButton = new System.Windows.Forms.Button();
            this.OrderVisitCancelButton = new System.Windows.Forms.Button();
            this.VisitOrdersLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreate)).BeginInit();
            this.Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).BeginInit();
            this.OrderVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Create);
            this.tabControl1.Controls.Add(this.Edit);
            this.tabControl1.Controls.Add(this.Absence);
            this.tabControl1.Controls.Add(this.OrderVisit);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.Controls.Add(this.dataGridViewCreate);
            this.Create.Controls.Add(this.comboBoxCreate);
            this.Create.Location = new System.Drawing.Point(4, 22);
            this.Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create.Size = new System.Drawing.Size(565, 339);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCreate
            // 
            this.dataGridViewCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreate.Location = new System.Drawing.Point(20, 88);
            this.dataGridViewCreate.Name = "dataGridViewCreate";
            this.dataGridViewCreate.RowTemplate.Height = 24;
            this.dataGridViewCreate.Size = new System.Drawing.Size(672, 253);
            this.dataGridViewCreate.TabIndex = 1;
            // 
            // comboBoxCreate
            // 
            this.comboBoxCreate.FormattingEnabled = true;
            this.comboBoxCreate.Items.AddRange(new object[] {
            "Student",
            "Personal",
            "Företag",
            "Class"});
            this.comboBoxCreate.Location = new System.Drawing.Point(20, 31);
            this.comboBoxCreate.Name = "comboBoxCreate";
            this.comboBoxCreate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCreate.TabIndex = 0;
            this.comboBoxCreate.SelectedIndexChanged += new System.EventHandler(this.comboBoxCreate_SelectedIndexChanged);
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.EditRevertButton);
            this.Edit.Controls.Add(this.EditSaveButton);
            this.Edit.Controls.Add(this.EditOKButton);
            this.Edit.Controls.Add(this.EditCancelButton);
            this.Edit.Controls.Add(this.EditDataGridView);
            this.Edit.Controls.Add(this.EditSelectLabel);
            this.Edit.Controls.Add(this.EditSelectCombobox);
            this.Edit.Location = new System.Drawing.Point(4, 22);
            this.Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit.Size = new System.Drawing.Size(565, 339);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // EditRevertButton
            // 
            this.EditRevertButton.Location = new System.Drawing.Point(340, 310);
            this.EditRevertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditRevertButton.Name = "EditRevertButton";
            this.EditRevertButton.Size = new System.Drawing.Size(72, 19);
            this.EditRevertButton.TabIndex = 6;
            this.EditRevertButton.Text = "Revert changes";
            this.EditRevertButton.UseVisualStyleBackColor = true;
            // 
            // EditSaveButton
            // 
            this.EditSaveButton.Location = new System.Drawing.Point(265, 310);
            this.EditSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditSaveButton.Name = "EditSaveButton";
            this.EditSaveButton.Size = new System.Drawing.Size(70, 19);
            this.EditSaveButton.TabIndex = 5;
            this.EditSaveButton.Text = "Save changes";
            this.EditSaveButton.UseVisualStyleBackColor = true;
            // 
            // EditOKButton
            // 
            this.EditOKButton.Location = new System.Drawing.Point(426, 310);
            this.EditOKButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditOKButton.Name = "EditOKButton";
            this.EditOKButton.Size = new System.Drawing.Size(67, 19);
            this.EditOKButton.TabIndex = 4;
            this.EditOKButton.Text = "OK";
            this.EditOKButton.UseVisualStyleBackColor = true;
            // 
            // EditCancelButton
            // 
            this.EditCancelButton.Location = new System.Drawing.Point(498, 310);
            this.EditCancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditCancelButton.Name = "EditCancelButton";
            this.EditCancelButton.Size = new System.Drawing.Size(56, 19);
            this.EditCancelButton.TabIndex = 3;
            this.EditCancelButton.Text = "Cancel";
            this.EditCancelButton.UseVisualStyleBackColor = true;
            // 
            // EditDataGridView
            // 
            this.EditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditDataGridView.Location = new System.Drawing.Point(168, 10);
            this.EditDataGridView.Name = "EditDataGridView";
            this.EditDataGridView.Size = new System.Drawing.Size(385, 295);
            this.EditDataGridView.TabIndex = 2;
            // 
            // EditSelectLabel
            // 
            this.EditSelectLabel.AutoSize = true;
            this.EditSelectLabel.Location = new System.Drawing.Point(7, 10);
            this.EditSelectLabel.Name = "EditSelectLabel";
            this.EditSelectLabel.Size = new System.Drawing.Size(95, 13);
            this.EditSelectLabel.TabIndex = 1;
            this.EditSelectLabel.Text = "Select table to edit";
            // 
            // EditSelectCombobox
            // 
            this.EditSelectCombobox.FormattingEnabled = true;
            this.EditSelectCombobox.Items.AddRange(new object[] {
            "Class",
            "Company",
            "Contact Person",
            "LIA",
            "Staff",
            "Student",
            "Class",
            "Company",
            "Contact Person",
            "LIA",
            "Staff",
            "Student"});
            this.EditSelectCombobox.Location = new System.Drawing.Point(7, 27);
            this.EditSelectCombobox.Name = "EditSelectCombobox";
            this.EditSelectCombobox.Size = new System.Drawing.Size(121, 21);
            this.EditSelectCombobox.TabIndex = 0;
            this.EditSelectCombobox.Text = "Browse...";
            // 
            // Absence
            // 
            this.Absence.Location = new System.Drawing.Point(4, 22);
            this.Absence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Absence.Name = "Absence";
            this.Absence.Size = new System.Drawing.Size(565, 339);
            this.Absence.TabIndex = 2;
            this.Absence.Text = "Absence";
            this.Absence.UseVisualStyleBackColor = true;
            // 
            // OrderVisit
            // 
            this.OrderVisit.Controls.Add(this.OkButton);
            this.OrderVisit.Controls.Add(this.button1);
            this.OrderVisit.Controls.Add(this.EditButton);
            this.OrderVisit.Controls.Add(this.RemoveButton);
            this.OrderVisit.Controls.Add(this.AddOrderButton);
            this.OrderVisit.Controls.Add(this.CancelButton);
            this.OrderVisit.Controls.Add(this.BookSaveButton);
            this.OrderVisit.Controls.Add(this.VisitOrders);
            this.OrderVisit.Controls.Add(this.dataGridViewOrderVisit);
            this.OrderVisit.Controls.Add(this.OrderVisitOkButton);
            this.OrderVisit.Controls.Add(this.OrderVisitCancelButton);
            this.OrderVisit.Controls.Add(this.VisitOrdersLabel);
            this.OrderVisit.Location = new System.Drawing.Point(4, 22);
            this.OrderVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderVisit.Name = "OrderVisit";
            this.OrderVisit.Size = new System.Drawing.Size(565, 339);
            this.OrderVisit.TabIndex = 3;
            this.OrderVisit.Text = "OrderVisit";
            this.OrderVisit.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(418, 306);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(56, 19);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(297, 306);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(56, 19);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(358, 306);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(56, 19);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(38, 277);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(61, 24);
            this.AddOrderButton.TabIndex = 4;
            this.AddOrderButton.Text = "Add";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(479, 306);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(56, 19);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BookSaveButton
            // 
            this.BookSaveButton.Location = new System.Drawing.Point(236, 306);
            this.BookSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookSaveButton.Name = "BookSaveButton";
            this.BookSaveButton.Size = new System.Drawing.Size(56, 19);
            this.BookSaveButton.TabIndex = 2;
            this.BookSaveButton.Text = "Save";
            this.BookSaveButton.UseVisualStyleBackColor = true;
            // 
            // VisitOrders
            // 
            this.VisitOrders.AutoSize = true;
            this.VisitOrders.Location = new System.Drawing.Point(224, 0);
            this.VisitOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VisitOrders.Name = "VisitOrders";
            this.VisitOrders.Size = new System.Drawing.Size(60, 13);
            this.VisitOrders.TabIndex = 1;
            this.VisitOrders.Text = "Order Visits";
            // 
            // dataGridViewOrderVisit
            // 
            this.dataGridViewOrderVisit.AllowUserToAddRows = false;
            this.dataGridViewOrderVisit.AllowUserToDeleteRows = false;
            this.dataGridViewOrderVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderVisit.Location = new System.Drawing.Point(226, 16);
            this.dataGridViewOrderVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrderVisit.Name = "dataGridViewOrderVisit";
            this.dataGridViewOrderVisit.ReadOnly = true;
            this.dataGridViewOrderVisit.RowHeadersVisible = false;
            this.dataGridViewOrderVisit.RowTemplate.Height = 24;
            this.dataGridViewOrderVisit.Size = new System.Drawing.Size(326, 284);
            this.dataGridViewOrderVisit.TabIndex = 0;
            // 
            // OrderVisitOkButton
            // 
            this.OrderVisitOkButton.Location = new System.Drawing.Point(558, 376);
            this.OrderVisitOkButton.Name = "OrderVisitOkButton";
            this.OrderVisitOkButton.Size = new System.Drawing.Size(75, 23);
            this.OrderVisitOkButton.TabIndex = 8;
            this.OrderVisitOkButton.Text = "Ok";
            this.OrderVisitOkButton.UseVisualStyleBackColor = true;
            this.OrderVisitOkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // OrderVisitCancelButton
            // 
            this.OrderVisitCancelButton.Location = new System.Drawing.Point(639, 376);
            this.OrderVisitCancelButton.Name = "OrderVisitCancelButton";
            this.OrderVisitCancelButton.Size = new System.Drawing.Size(75, 23);
            this.OrderVisitCancelButton.TabIndex = 3;
            this.OrderVisitCancelButton.Text = "Cancel";
            this.OrderVisitCancelButton.UseVisualStyleBackColor = true;
            this.OrderVisitCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // VisitOrdersLabel
            // 
            this.VisitOrdersLabel.AutoSize = true;
            this.VisitOrdersLabel.Location = new System.Drawing.Point(299, 0);
            this.VisitOrdersLabel.Name = "VisitOrdersLabel";
            this.VisitOrdersLabel.Size = new System.Drawing.Size(60, 13);
            this.VisitOrdersLabel.TabIndex = 1;
            this.VisitOrdersLabel.Text = "Order Visits";
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 360);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Create.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreate)).EndInit();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView)).EndInit();
            this.OrderVisit.ResumeLayout(false);
            this.OrderVisit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderVisit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Create;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.TabPage Absence;
        private System.Windows.Forms.TabPage OrderVisit;
        private System.Windows.Forms.Button BookSaveButton;
        private System.Windows.Forms.Label VisitOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrderVisit;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ComboBox EditSelectCombobox;
        private System.Windows.Forms.Label EditSelectLabel;
        private System.Windows.Forms.Button EditCancelButton;
        private System.Windows.Forms.DataGridView EditDataGridView;
        private System.Windows.Forms.Button EditOKButton;
        private System.Windows.Forms.Button EditRevertButton;
        private System.Windows.Forms.Button EditSaveButton;
        private System.Windows.Forms.ComboBox comboBoxCreate;
        private System.Windows.Forms.DataGridView dataGridViewCreate;
        private System.Windows.Forms.Label VisitOrdersLabel;
        private System.Windows.Forms.Button OrderVisitCancelButton;
        private System.Windows.Forms.Button OrderVisitOkButton;
    }
}