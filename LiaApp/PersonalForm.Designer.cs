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
            this.Edit = new System.Windows.Forms.TabPage();
            this.Sickness = new System.Windows.Forms.TabPage();
            this.OrderVisit = new System.Windows.Forms.TabPage();
            this.OrderVisitIsMeetingDone = new System.Windows.Forms.Label();
            this.OrderVisitDateLabel = new System.Windows.Forms.Label();
            this.OrderVisitLiaStudentLabel = new System.Windows.Forms.Label();
            this.OrderVisitPersonalLabel = new System.Windows.Forms.Label();
            this.OrderVisitOkButton = new System.Windows.Forms.Button();
            this.OrderVisitUpdateButton = new System.Windows.Forms.Button();
            this.OrderVisitEditButton = new System.Windows.Forms.Button();
            this.OrderVisitRemoveButton = new System.Windows.Forms.Button();
            this.OrderVisitAddOrderButton = new System.Windows.Forms.Button();
            this.OrderVisitCancelButton = new System.Windows.Forms.Button();
            this.OrderVisitBookSaveButton = new System.Windows.Forms.Button();
            this.VisitOrdersLabel = new System.Windows.Forms.Label();
            this.OrderVisitdataGridView = new System.Windows.Forms.DataGridView();
            this.OrderVisitPersonalcomboBox = new System.Windows.Forms.ComboBox();
            this.OrderVisitLiaStudentcomboBox = new System.Windows.Forms.ComboBox();
            this.OrderVisitdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OrderVisitcheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.OrderVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderVisitdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Create);
            this.tabControl1.Controls.Add(this.Edit);
            this.tabControl1.Controls.Add(this.Sickness);
            this.tabControl1.Controls.Add(this.OrderVisit);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(4, 25);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(3);
            this.Create.Size = new System.Drawing.Size(754, 418);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(4, 25);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(3);
            this.Edit.Size = new System.Drawing.Size(754, 418);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Sickness
            // 
            this.Sickness.Location = new System.Drawing.Point(4, 25);
            this.Sickness.Name = "Sickness";
            this.Sickness.Size = new System.Drawing.Size(754, 418);
            this.Sickness.TabIndex = 2;
            this.Sickness.Text = "Sickness";
            this.Sickness.UseVisualStyleBackColor = true;
            // 
            // OrderVisit
            // 
            this.OrderVisit.Controls.Add(this.OrderVisitcheckBox);
            this.OrderVisit.Controls.Add(this.OrderVisitdateTimePicker);
            this.OrderVisit.Controls.Add(this.OrderVisitLiaStudentcomboBox);
            this.OrderVisit.Controls.Add(this.OrderVisitPersonalcomboBox);
            this.OrderVisit.Controls.Add(this.OrderVisitIsMeetingDone);
            this.OrderVisit.Controls.Add(this.OrderVisitDateLabel);
            this.OrderVisit.Controls.Add(this.OrderVisitLiaStudentLabel);
            this.OrderVisit.Controls.Add(this.OrderVisitPersonalLabel);
            this.OrderVisit.Controls.Add(this.OrderVisitOkButton);
            this.OrderVisit.Controls.Add(this.OrderVisitUpdateButton);
            this.OrderVisit.Controls.Add(this.OrderVisitEditButton);
            this.OrderVisit.Controls.Add(this.OrderVisitRemoveButton);
            this.OrderVisit.Controls.Add(this.OrderVisitAddOrderButton);
            this.OrderVisit.Controls.Add(this.OrderVisitCancelButton);
            this.OrderVisit.Controls.Add(this.OrderVisitBookSaveButton);
            this.OrderVisit.Controls.Add(this.VisitOrdersLabel);
            this.OrderVisit.Controls.Add(this.OrderVisitdataGridView);
            this.OrderVisit.Location = new System.Drawing.Point(4, 25);
            this.OrderVisit.Name = "OrderVisit";
            this.OrderVisit.Size = new System.Drawing.Size(754, 418);
            this.OrderVisit.TabIndex = 3;
            this.OrderVisit.Text = "OrderVisit";
            this.OrderVisit.UseVisualStyleBackColor = true;
            // 
            // OrderVisitIsMeetingDone
            // 
            this.OrderVisitIsMeetingDone.AutoSize = true;
            this.OrderVisitIsMeetingDone.Location = new System.Drawing.Point(50, 249);
            this.OrderVisitIsMeetingDone.Name = "OrderVisitIsMeetingDone";
            this.OrderVisitIsMeetingDone.Size = new System.Drawing.Size(116, 17);
            this.OrderVisitIsMeetingDone.TabIndex = 12;
            this.OrderVisitIsMeetingDone.Text = "Is meeting done?";
            // 
            // OrderVisitDateLabel
            // 
            this.OrderVisitDateLabel.AutoSize = true;
            this.OrderVisitDateLabel.Location = new System.Drawing.Point(50, 186);
            this.OrderVisitDateLabel.Name = "OrderVisitDateLabel";
            this.OrderVisitDateLabel.Size = new System.Drawing.Size(38, 17);
            this.OrderVisitDateLabel.TabIndex = 11;
            this.OrderVisitDateLabel.Text = "Date";
            // 
            // OrderVisitLiaStudentLabel
            // 
            this.OrderVisitLiaStudentLabel.AutoSize = true;
            this.OrderVisitLiaStudentLabel.Location = new System.Drawing.Point(50, 125);
            this.OrderVisitLiaStudentLabel.Name = "OrderVisitLiaStudentLabel";
            this.OrderVisitLiaStudentLabel.Size = new System.Drawing.Size(76, 17);
            this.OrderVisitLiaStudentLabel.TabIndex = 10;
            this.OrderVisitLiaStudentLabel.Text = "LiaStudent";
            // 
            // OrderVisitPersonalLabel
            // 
            this.OrderVisitPersonalLabel.AutoSize = true;
            this.OrderVisitPersonalLabel.Location = new System.Drawing.Point(50, 56);
            this.OrderVisitPersonalLabel.Name = "OrderVisitPersonalLabel";
            this.OrderVisitPersonalLabel.Size = new System.Drawing.Size(64, 17);
            this.OrderVisitPersonalLabel.TabIndex = 9;
            this.OrderVisitPersonalLabel.Text = "Personal";
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
            // OrderVisitUpdateButton
            // 
            this.OrderVisitUpdateButton.Location = new System.Drawing.Point(137, 341);
            this.OrderVisitUpdateButton.Name = "OrderVisitUpdateButton";
            this.OrderVisitUpdateButton.Size = new System.Drawing.Size(82, 29);
            this.OrderVisitUpdateButton.TabIndex = 7;
            this.OrderVisitUpdateButton.Text = "Update";
            this.OrderVisitUpdateButton.UseVisualStyleBackColor = true;
            // 
            // OrderVisitEditButton
            // 
            this.OrderVisitEditButton.Location = new System.Drawing.Point(396, 376);
            this.OrderVisitEditButton.Name = "OrderVisitEditButton";
            this.OrderVisitEditButton.Size = new System.Drawing.Size(75, 23);
            this.OrderVisitEditButton.TabIndex = 6;
            this.OrderVisitEditButton.Text = "Edit";
            this.OrderVisitEditButton.UseVisualStyleBackColor = true;
            // 
            // OrderVisitRemoveButton
            // 
            this.OrderVisitRemoveButton.Location = new System.Drawing.Point(477, 376);
            this.OrderVisitRemoveButton.Name = "OrderVisitRemoveButton";
            this.OrderVisitRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.OrderVisitRemoveButton.TabIndex = 5;
            this.OrderVisitRemoveButton.Text = "Remove";
            this.OrderVisitRemoveButton.UseVisualStyleBackColor = true;
            // 
            // OrderVisitAddOrderButton
            // 
            this.OrderVisitAddOrderButton.Location = new System.Drawing.Point(50, 341);
            this.OrderVisitAddOrderButton.Name = "OrderVisitAddOrderButton";
            this.OrderVisitAddOrderButton.Size = new System.Drawing.Size(81, 29);
            this.OrderVisitAddOrderButton.TabIndex = 4;
            this.OrderVisitAddOrderButton.Text = "Add";
            this.OrderVisitAddOrderButton.UseVisualStyleBackColor = true;
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
            // OrderVisitBookSaveButton
            // 
            this.OrderVisitBookSaveButton.Location = new System.Drawing.Point(315, 376);
            this.OrderVisitBookSaveButton.Name = "OrderVisitBookSaveButton";
            this.OrderVisitBookSaveButton.Size = new System.Drawing.Size(75, 23);
            this.OrderVisitBookSaveButton.TabIndex = 2;
            this.OrderVisitBookSaveButton.Text = "Save";
            this.OrderVisitBookSaveButton.UseVisualStyleBackColor = true;
            // 
            // VisitOrdersLabel
            // 
            this.VisitOrdersLabel.AutoSize = true;
            this.VisitOrdersLabel.Location = new System.Drawing.Point(299, 0);
            this.VisitOrdersLabel.Name = "VisitOrdersLabel";
            this.VisitOrdersLabel.Size = new System.Drawing.Size(82, 17);
            this.VisitOrdersLabel.TabIndex = 1;
            this.VisitOrdersLabel.Text = "Order Visits";
            // 
            // OrderVisitdataGridView
            // 
            this.OrderVisitdataGridView.AllowUserToAddRows = false;
            this.OrderVisitdataGridView.AllowUserToDeleteRows = false;
            this.OrderVisitdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderVisitdataGridView.Location = new System.Drawing.Point(302, 20);
            this.OrderVisitdataGridView.Name = "OrderVisitdataGridView";
            this.OrderVisitdataGridView.ReadOnly = true;
            this.OrderVisitdataGridView.RowHeadersVisible = false;
            this.OrderVisitdataGridView.RowTemplate.Height = 24;
            this.OrderVisitdataGridView.Size = new System.Drawing.Size(434, 350);
            this.OrderVisitdataGridView.TabIndex = 0;
            // 
            // OrderVisitPersonalcomboBox
            // 
            this.OrderVisitPersonalcomboBox.FormattingEnabled = true;
            this.OrderVisitPersonalcomboBox.Location = new System.Drawing.Point(53, 77);
            this.OrderVisitPersonalcomboBox.Name = "OrderVisitPersonalcomboBox";
            this.OrderVisitPersonalcomboBox.Size = new System.Drawing.Size(121, 24);
            this.OrderVisitPersonalcomboBox.TabIndex = 13;
            // 
            // OrderVisitLiaStudentcomboBox
            // 
            this.OrderVisitLiaStudentcomboBox.FormattingEnabled = true;
            this.OrderVisitLiaStudentcomboBox.Location = new System.Drawing.Point(53, 146);
            this.OrderVisitLiaStudentcomboBox.Name = "OrderVisitLiaStudentcomboBox";
            this.OrderVisitLiaStudentcomboBox.Size = new System.Drawing.Size(121, 24);
            this.OrderVisitLiaStudentcomboBox.TabIndex = 14;
            // 
            // OrderVisitdateTimePicker
            // 
            this.OrderVisitdateTimePicker.Location = new System.Drawing.Point(53, 207);
            this.OrderVisitdateTimePicker.Name = "OrderVisitdateTimePicker";
            this.OrderVisitdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.OrderVisitdateTimePicker.TabIndex = 15;
            // 
            // OrderVisitcheckBox
            // 
            this.OrderVisitcheckBox.AutoSize = true;
            this.OrderVisitcheckBox.Location = new System.Drawing.Point(53, 284);
            this.OrderVisitcheckBox.Name = "OrderVisitcheckBox";
            this.OrderVisitcheckBox.Size = new System.Drawing.Size(109, 21);
            this.OrderVisitcheckBox.TabIndex = 16;
            this.OrderVisitcheckBox.Text = "Check if true";
            this.OrderVisitcheckBox.UseVisualStyleBackColor = true;
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.OrderVisit.ResumeLayout(false);
            this.OrderVisit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderVisitdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Create;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.TabPage Sickness;
        private System.Windows.Forms.TabPage OrderVisit;
        private System.Windows.Forms.Button OrderVisitBookSaveButton;
        private System.Windows.Forms.Label VisitOrdersLabel;
        private System.Windows.Forms.DataGridView OrderVisitdataGridView;
        private System.Windows.Forms.Button OrderVisitAddOrderButton;
        private System.Windows.Forms.Button OrderVisitCancelButton;
        private System.Windows.Forms.Button OrderVisitUpdateButton;
        private System.Windows.Forms.Button OrderVisitEditButton;
        private System.Windows.Forms.Button OrderVisitRemoveButton;
        private System.Windows.Forms.Button OrderVisitOkButton;
        private System.Windows.Forms.Label OrderVisitIsMeetingDone;
        private System.Windows.Forms.Label OrderVisitDateLabel;
        private System.Windows.Forms.Label OrderVisitLiaStudentLabel;
        private System.Windows.Forms.Label OrderVisitPersonalLabel;
        private System.Windows.Forms.CheckBox OrderVisitcheckBox;
        private System.Windows.Forms.DateTimePicker OrderVisitdateTimePicker;
        private System.Windows.Forms.ComboBox OrderVisitLiaStudentcomboBox;
        private System.Windows.Forms.ComboBox OrderVisitPersonalcomboBox;
    }
}