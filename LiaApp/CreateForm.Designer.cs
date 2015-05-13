namespace LiaApp
{
    partial class CreateForm
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
            this.comboBoxCreate = new System.Windows.Forms.ComboBox();
            this.dataGridViewCreate = new System.Windows.Forms.DataGridView();
            this.labelCreate = new System.Windows.Forms.Label();
            this.buttonCancelCreate = new System.Windows.Forms.Button();
            this.buttonCreateSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCreate
            // 
            this.comboBoxCreate.FormattingEnabled = true;
            this.comboBoxCreate.Items.AddRange(new object[] {
            "Student",
            "Personal",
            "Class",
            "Company"});
            this.comboBoxCreate.Location = new System.Drawing.Point(30, 41);
            this.comboBoxCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCreate.Name = "comboBoxCreate";
            this.comboBoxCreate.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCreate.TabIndex = 0;
            this.comboBoxCreate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewCreate
            // 
            this.dataGridViewCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreate.Location = new System.Drawing.Point(30, 78);
            this.dataGridViewCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCreate.Name = "dataGridViewCreate";
            this.dataGridViewCreate.RowTemplate.Height = 24;
            this.dataGridViewCreate.Size = new System.Drawing.Size(574, 233);
            this.dataGridViewCreate.TabIndex = 1;
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Location = new System.Drawing.Point(30, 11);
            this.labelCreate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(117, 13);
            this.labelCreate.TabIndex = 2;
            this.labelCreate.Text = "Select object to create:";
            // 
            // buttonCancelCreate
            // 
            this.buttonCancelCreate.Location = new System.Drawing.Point(548, 324);
            this.buttonCancelCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelCreate.Name = "buttonCancelCreate";
            this.buttonCancelCreate.Size = new System.Drawing.Size(56, 19);
            this.buttonCancelCreate.TabIndex = 3;
            this.buttonCancelCreate.Text = "Cancel";
            this.buttonCancelCreate.UseVisualStyleBackColor = true;
            // 
            // buttonCreateSave
            // 
            this.buttonCreateSave.Location = new System.Drawing.Point(466, 324);
            this.buttonCreateSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateSave.Name = "buttonCreateSave";
            this.buttonCreateSave.Size = new System.Drawing.Size(56, 19);
            this.buttonCreateSave.TabIndex = 4;
            this.buttonCreateSave.Text = "Save";
            this.buttonCreateSave.UseVisualStyleBackColor = true;
            this.buttonCreateSave.Click += new System.EventHandler(this.buttonCreateSave_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 360);
            this.Controls.Add(this.buttonCreateSave);
            this.Controls.Add(this.buttonCancelCreate);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.dataGridViewCreate);
            this.Controls.Add(this.comboBoxCreate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateForm";
            this.Text = "Create new";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCreate;
        private System.Windows.Forms.DataGridView dataGridViewCreate;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Button buttonCancelCreate;
        private System.Windows.Forms.Button buttonCreateSave;
    }
}