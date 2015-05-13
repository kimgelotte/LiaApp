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
            this.trrtu = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.OrderVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderVisit)).BeginInit();
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
            this.OrderVisit.Location = new System.Drawing.Point(4, 25);
            this.OrderVisit.Name = "OrderVisit";
            this.OrderVisit.Size = new System.Drawing.Size(754, 418);
            this.OrderVisit.TabIndex = 3;
            this.OrderVisit.Text = "OrderVisit";
            this.OrderVisit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Location = new System.Drawing.Point(50, 56);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(64, 17);
            this.Personal.TabIndex = 9;
            this.Personal.Text = "Personal";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(558, 376);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(396, 376);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(477, 376);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(50, 341);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(81, 29);
            this.AddOrderButton.TabIndex = 4;
            this.AddOrderButton.Text = "Add";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(639, 376);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BookSaveButton
            // 
            this.BookSaveButton.Location = new System.Drawing.Point(315, 376);
            this.BookSaveButton.Name = "BookSaveButton";
            this.BookSaveButton.Size = new System.Drawing.Size(75, 23);
            this.BookSaveButton.TabIndex = 2;
            this.BookSaveButton.Text = "Save";
            this.BookSaveButton.UseVisualStyleBackColor = true;
            // 
            // VisitOrders
            // 
            this.VisitOrders.AutoSize = true;
            this.VisitOrders.Location = new System.Drawing.Point(299, 0);
            this.VisitOrders.Name = "VisitOrders";
            this.VisitOrders.Size = new System.Drawing.Size(82, 17);
            this.VisitOrders.TabIndex = 1;
            this.VisitOrders.Text = "Order Visits";
            // 
            // dataGridViewOrderVisit
            // 
            this.dataGridViewOrderVisit.AllowUserToAddRows = false;
            this.dataGridViewOrderVisit.AllowUserToDeleteRows = false;
            this.dataGridViewOrderVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderVisit.Location = new System.Drawing.Point(302, 20);
            this.dataGridViewOrderVisit.Name = "dataGridViewOrderVisit";
            this.dataGridViewOrderVisit.ReadOnly = true;
            this.dataGridViewOrderVisit.RowHeadersVisible = false;
            this.dataGridViewOrderVisit.RowTemplate.Height = 24;
            this.dataGridViewOrderVisit.Size = new System.Drawing.Size(434, 350);
            this.dataGridViewOrderVisit.TabIndex = 0;
            // 
            // trrtu
            // 
            this.trrtu.Location = new System.Drawing.Point(217, 154);
            this.trrtu.Name = "trrtu";
            this.trrtu.Size = new System.Drawing.Size(75, 23);
            this.trrtu.TabIndex = 13;
            this.trrtu.Text = "dfhdh";
            this.trrtu.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderVisit)).EndInit();
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
    }
}