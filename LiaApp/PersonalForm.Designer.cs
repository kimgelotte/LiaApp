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
            this.labelCreate = new System.Windows.Forms.Label();
            this.comboBoxCreate = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.TabPage();
            this.Sickness = new System.Windows.Forms.TabPage();
            this.OrderVisit = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreate)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(747, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.Controls.Add(this.dataGridViewCreate);
            this.Create.Controls.Add(this.labelCreate);
            this.Create.Controls.Add(this.comboBoxCreate);
            this.Create.Location = new System.Drawing.Point(4, 25);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(3);
            this.Create.Size = new System.Drawing.Size(739, 402);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCreate
            // 
            this.dataGridViewCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreate.Location = new System.Drawing.Point(35, 105);
            this.dataGridViewCreate.Name = "dataGridViewCreate";
            this.dataGridViewCreate.RowTemplate.Height = 24;
            this.dataGridViewCreate.Size = new System.Drawing.Size(666, 272);
            this.dataGridViewCreate.TabIndex = 2;
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Location = new System.Drawing.Point(32, 17);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(232, 17);
            this.labelCreate.TabIndex = 1;
            this.labelCreate.Text = "Choose object to create in dropbox:";
            // 
            // comboBoxCreate
            // 
            this.comboBoxCreate.FormattingEnabled = true;
            this.comboBoxCreate.Items.AddRange(new object[] {
            "Student",
            "Personal",
            "Class",
            "ContactPerson",
            "Company"});
            this.comboBoxCreate.Location = new System.Drawing.Point(35, 55);
            this.comboBoxCreate.Name = "comboBoxCreate";
            this.comboBoxCreate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCreate.TabIndex = 0;
            this.comboBoxCreate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(4, 25);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(3);
            this.Edit.Size = new System.Drawing.Size(739, 402);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Sickness
            // 
            this.Sickness.Location = new System.Drawing.Point(4, 25);
            this.Sickness.Name = "Sickness";
            this.Sickness.Size = new System.Drawing.Size(739, 402);
            this.Sickness.TabIndex = 2;
            this.Sickness.Text = "Sickness";
            this.Sickness.UseVisualStyleBackColor = true;
            // 
            // OrderVisit
            // 
            this.OrderVisit.Location = new System.Drawing.Point(4, 25);
            this.OrderVisit.Name = "OrderVisit";
            this.OrderVisit.Size = new System.Drawing.Size(739, 402);
            this.OrderVisit.TabIndex = 3;
            this.OrderVisit.Text = "OrderVisit";
            this.OrderVisit.UseVisualStyleBackColor = true;
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.tabControl1.ResumeLayout(false);
            this.Create.ResumeLayout(false);
            this.Create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Create;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.TabPage Sickness;
        private System.Windows.Forms.TabPage OrderVisit;
        private System.Windows.Forms.DataGridView dataGridViewCreate;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.ComboBox comboBoxCreate;
    }
}