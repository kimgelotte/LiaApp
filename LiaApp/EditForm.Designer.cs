namespace LiaApp
{
    partial class EditForm
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
            this.EditSelectTable = new System.Windows.Forms.ComboBox();
            this.EditSelectLabel = new System.Windows.Forms.Label();
            this.EditdataGridView = new System.Windows.Forms.DataGridView();
            this.EditCancelButton = new System.Windows.Forms.Button();
            this.EditOKButton = new System.Windows.Forms.Button();
            this.EditSaveChangesButton = new System.Windows.Forms.Button();
            this.EditRevertChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditSelectTable
            // 
            this.EditSelectTable.FormattingEnabled = true;
            this.EditSelectTable.Items.AddRange(new object[] {
            "Student",
            "Staff",
            "Company",
            "Contact person",
            "LIA"});
            this.EditSelectTable.Location = new System.Drawing.Point(12, 27);
            this.EditSelectTable.Name = "EditSelectTable";
            this.EditSelectTable.Size = new System.Drawing.Size(121, 21);
            this.EditSelectTable.TabIndex = 0;
            this.EditSelectTable.Text = "Browse...";
            this.EditSelectTable.SelectedIndexChanged += new System.EventHandler(this.EditSelectTable_SelectedIndexChanged);
            // 
            // EditSelectLabel
            // 
            this.EditSelectLabel.AutoSize = true;
            this.EditSelectLabel.Location = new System.Drawing.Point(12, 12);
            this.EditSelectLabel.Name = "EditSelectLabel";
            this.EditSelectLabel.Size = new System.Drawing.Size(63, 13);
            this.EditSelectLabel.TabIndex = 1;
            this.EditSelectLabel.Text = "Select table";
            // 
            // EditdataGridView
            // 
            this.EditdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditdataGridView.Location = new System.Drawing.Point(12, 54);
            this.EditdataGridView.Name = "EditdataGridView";
            this.EditdataGridView.Size = new System.Drawing.Size(576, 280);
            this.EditdataGridView.TabIndex = 2;
            // 
            // EditCancelButton
            // 
            this.EditCancelButton.Location = new System.Drawing.Point(513, 340);
            this.EditCancelButton.Name = "EditCancelButton";
            this.EditCancelButton.Size = new System.Drawing.Size(75, 23);
            this.EditCancelButton.TabIndex = 3;
            this.EditCancelButton.Text = "Cancel";
            this.EditCancelButton.UseVisualStyleBackColor = true;
            // 
            // EditOKButton
            // 
            this.EditOKButton.Location = new System.Drawing.Point(432, 340);
            this.EditOKButton.Name = "EditOKButton";
            this.EditOKButton.Size = new System.Drawing.Size(75, 23);
            this.EditOKButton.TabIndex = 4;
            this.EditOKButton.Text = "OK";
            this.EditOKButton.UseVisualStyleBackColor = true;
            // 
            // EditSaveChangesButton
            // 
            this.EditSaveChangesButton.Location = new System.Drawing.Point(12, 340);
            this.EditSaveChangesButton.Name = "EditSaveChangesButton";
            this.EditSaveChangesButton.Size = new System.Drawing.Size(95, 23);
            this.EditSaveChangesButton.TabIndex = 5;
            this.EditSaveChangesButton.Text = "Save changes";
            this.EditSaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // EditRevertChangesButton
            // 
            this.EditRevertChangesButton.Location = new System.Drawing.Point(113, 340);
            this.EditRevertChangesButton.Name = "EditRevertChangesButton";
            this.EditRevertChangesButton.Size = new System.Drawing.Size(88, 23);
            this.EditRevertChangesButton.TabIndex = 6;
            this.EditRevertChangesButton.Text = "Revert changes";
            this.EditRevertChangesButton.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.EditRevertChangesButton);
            this.Controls.Add(this.EditSaveChangesButton);
            this.Controls.Add(this.EditOKButton);
            this.Controls.Add(this.EditCancelButton);
            this.Controls.Add(this.EditdataGridView);
            this.Controls.Add(this.EditSelectLabel);
            this.Controls.Add(this.EditSelectTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditForm";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.EditdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EditSelectTable;
        private System.Windows.Forms.Label EditSelectLabel;
        private System.Windows.Forms.DataGridView EditdataGridView;
        private System.Windows.Forms.Button EditCancelButton;
        private System.Windows.Forms.Button EditOKButton;
        private System.Windows.Forms.Button EditSaveChangesButton;
        private System.Windows.Forms.Button EditRevertChangesButton;
    }
}