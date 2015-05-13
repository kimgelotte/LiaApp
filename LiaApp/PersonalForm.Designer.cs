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
            this.OrderVisitOkButton = new System.Windows.Forms.Button();
            this.OrderVisitCancelButton = new System.Windows.Forms.Button();
            this.VisitOrdersLabel = new System.Windows.Forms.Label();
            this.OrderVisitdataGridView = new System.Windows.Forms.DataGridView();
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
            this.OrderVisit.Controls.Add(this.OrderVisitOkButton);
            this.OrderVisit.Controls.Add(this.OrderVisitCancelButton);
            this.OrderVisit.Controls.Add(this.VisitOrdersLabel);
            this.OrderVisit.Controls.Add(this.OrderVisitdataGridView);
            this.OrderVisit.Location = new System.Drawing.Point(4, 25);
            this.OrderVisit.Name = "OrderVisit";
            this.OrderVisit.Size = new System.Drawing.Size(754, 418);
            this.OrderVisit.TabIndex = 3;
            this.OrderVisit.Text = "OrderVisit";
            this.OrderVisit.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label VisitOrdersLabel;
        private System.Windows.Forms.DataGridView OrderVisitdataGridView;
        private System.Windows.Forms.Button OrderVisitCancelButton;
        private System.Windows.Forms.Button OrderVisitOkButton;
    }
}