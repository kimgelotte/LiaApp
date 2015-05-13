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
            this.comboBoxCreate.Location = new System.Drawing.Point(40, 50);
            this.comboBoxCreate.Name = "comboBoxCreate";
            this.comboBoxCreate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCreate.TabIndex = 0;
            this.comboBoxCreate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewCreate
            // 
            this.dataGridViewCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreate.Location = new System.Drawing.Point(40, 96);
            this.dataGridViewCreate.Name = "dataGridViewCreate";
            this.dataGridViewCreate.RowTemplate.Height = 24;
            this.dataGridViewCreate.Size = new System.Drawing.Size(766, 287);
            this.dataGridViewCreate.TabIndex = 1;
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Location = new System.Drawing.Point(40, 13);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(153, 17);
            this.labelCreate.TabIndex = 2;
            this.labelCreate.Text = "Select object to create:";
            // 
            // buttonCancelCreate
            // 
            this.buttonCancelCreate.Location = new System.Drawing.Point(731, 399);
            this.buttonCancelCreate.Name = "buttonCancelCreate";
            this.buttonCancelCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelCreate.TabIndex = 3;
            this.buttonCancelCreate.Text = "Cancel";
            this.buttonCancelCreate.UseVisualStyleBackColor = true;
            // 
            // buttonCreateSave
            // 
            this.buttonCreateSave.Location = new System.Drawing.Point(621, 399);
            this.buttonCreateSave.Name = "buttonCreateSave";
            this.buttonCreateSave.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateSave.TabIndex = 4;
            this.buttonCreateSave.Text = "Save";
            this.buttonCreateSave.UseVisualStyleBackColor = true;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 443);
            this.Controls.Add(this.buttonCreateSave);
            this.Controls.Add(this.buttonCancelCreate);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.dataGridViewCreate);
            this.Controls.Add(this.comboBoxCreate);
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