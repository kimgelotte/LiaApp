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
            this.trrtu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Personal = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BookSaveButton = new System.Windows.Forms.Button();
            this.VisitOrders = new System.Windows.Forms.Label();
            this.dataGridViewOrderVisit = new System.Windows.Forms.DataGridView();
            this.EditSelectCombobox = new System.Windows.Forms.ComboBox();
            this.EditSelectLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditCancelButton = new System.Windows.Forms.Button();
            this.EditOKButton = new System.Windows.Forms.Button();
            this.EditSaveButton = new System.Windows.Forms.Button();
            this.EditRevertButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Edit.SuspendLayout();
            this.OrderVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Create);
            this.tabControl1.Controls.Add(this.Edit);
            this.tabControl1.Controls.Add(this.Sickness);
            this.tabControl1.Controls.Add(this.OrderVisit);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(4, 22);
            this.Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create.Size = new System.Drawing.Size(564, 337);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.EditRevertButton);
            this.Edit.Controls.Add(this.EditSaveButton);
            this.Edit.Controls.Add(this.EditOKButton);
            this.Edit.Controls.Add(this.EditCancelButton);
            this.Edit.Controls.Add(this.dataGridView1);
            this.Edit.Controls.Add(this.EditSelectLabel);
            this.Edit.Controls.Add(this.EditSelectCombobox);
            this.Edit.Location = new System.Drawing.Point(4, 22);
            this.Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit.Size = new System.Drawing.Size(564, 337);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Sickness
            // 
            this.Sickness.Location = new System.Drawing.Point(4, 22);
            this.Sickness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sickness.Name = "Sickness";
            this.Sickness.Size = new System.Drawing.Size(564, 337);
            this.Sickness.TabIndex = 2;
            this.Sickness.Text = "Sickness";
            this.Sickness.UseVisualStyleBackColor = true;
            // 
            // OrderVisit
            // 
            this.OrderVisit.Controls.Add(this.trrtu);
            this.OrderVisit.Controls.Add(this.label4);
            this.OrderVisit.Controls.Add(this.label3);
            this.OrderVisit.Controls.Add(this.label2);
            this.OrderVisit.Controls.Add(this.Personal);
            this.OrderVisit.Controls.Add(this.OkButton);
            this.OrderVisit.Controls.Add(this.button1);
            this.OrderVisit.Controls.Add(this.EditButton);
            this.OrderVisit.Controls.Add(this.RemoveButton);
            this.OrderVisit.Controls.Add(this.AddOrderButton);
            this.OrderVisit.Controls.Add(this.CancelButton);
            this.OrderVisit.Controls.Add(this.BookSaveButton);
            this.OrderVisit.Controls.Add(this.VisitOrders);
            this.OrderVisit.Controls.Add(this.dataGridViewOrderVisit);
            this.OrderVisit.Location = new System.Drawing.Point(4, 22);
            this.OrderVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderVisit.Name = "OrderVisit";
            this.OrderVisit.Size = new System.Drawing.Size(564, 337);
            this.OrderVisit.TabIndex = 3;
            this.OrderVisit.Text = "OrderVisit";
            this.OrderVisit.UseVisualStyleBackColor = true;
            // 
            // trrtu
            // 
            this.trrtu.Location = new System.Drawing.Point(163, 125);
            this.trrtu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trrtu.Name = "trrtu";
            this.trrtu.Size = new System.Drawing.Size(56, 19);
            this.trrtu.TabIndex = 13;
            this.trrtu.Text = "dfhdh";
            this.trrtu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Location = new System.Drawing.Point(38, 46);
            this.Personal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(48, 13);
            this.Personal.TabIndex = 9;
            this.Personal.Text = "Personal";
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
            // EditSelectCombobox
            // 
            this.EditSelectCombobox.FormattingEnabled = true;
            this.EditSelectCombobox.Items.AddRange(new object[] {
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
            // EditSelectLabel
            // 
            this.EditSelectLabel.AutoSize = true;
            this.EditSelectLabel.Location = new System.Drawing.Point(7, 10);
            this.EditSelectLabel.Name = "EditSelectLabel";
            this.EditSelectLabel.Size = new System.Drawing.Size(95, 13);
            this.EditSelectLabel.TabIndex = 1;
            this.EditSelectLabel.Text = "Select table to edit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 295);
            this.dataGridView1.TabIndex = 2;
            // 
            // EditCancelButton
            // 
            this.EditCancelButton.Location = new System.Drawing.Point(478, 309);
            this.EditCancelButton.Name = "EditCancelButton";
            this.EditCancelButton.Size = new System.Drawing.Size(75, 23);
            this.EditCancelButton.TabIndex = 3;
            this.EditCancelButton.Text = "Cancel";
            this.EditCancelButton.UseVisualStyleBackColor = true;
            this.EditCancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditOKButton
            // 
            this.EditOKButton.Location = new System.Drawing.Point(383, 309);
            this.EditOKButton.Name = "EditOKButton";
            this.EditOKButton.Size = new System.Drawing.Size(89, 23);
            this.EditOKButton.TabIndex = 4;
            this.EditOKButton.Text = "OK";
            this.EditOKButton.UseVisualStyleBackColor = true;
            // 
            // EditSaveButton
            // 
            this.EditSaveButton.Location = new System.Drawing.Point(168, 309);
            this.EditSaveButton.Name = "EditSaveButton";
            this.EditSaveButton.Size = new System.Drawing.Size(94, 23);
            this.EditSaveButton.TabIndex = 5;
            this.EditSaveButton.Text = "Save changes";
            this.EditSaveButton.UseVisualStyleBackColor = true;
            // 
            // EditRevertButton
            // 
            this.EditRevertButton.Location = new System.Drawing.Point(268, 309);
            this.EditRevertButton.Name = "EditRevertButton";
            this.EditRevertButton.Size = new System.Drawing.Size(96, 23);
            this.EditRevertButton.TabIndex = 6;
            this.EditRevertButton.Text = "Revert changes";
            this.EditRevertButton.UseVisualStyleBackColor = true;
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
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.OrderVisit.ResumeLayout(false);
            this.OrderVisit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Create;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.TabPage Sickness;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Personal;
        private System.Windows.Forms.Button trrtu;
        private System.Windows.Forms.ComboBox EditSelectCombobox;
        private System.Windows.Forms.Label EditSelectLabel;
        private System.Windows.Forms.Button EditCancelButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditOKButton;
        private System.Windows.Forms.Button EditRevertButton;
        private System.Windows.Forms.Button EditSaveButton;
    }
}