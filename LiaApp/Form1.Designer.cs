namespace LiaApp
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.LiaInfo = new System.Windows.Forms.Label();
            this.dataGridViewLIA = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLIA)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Välj klass ur lista:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewLIA);
            this.groupBox1.Controls.Add(this.LiaInfo);
            this.groupBox1.Controls.Add(this.dataGridViewClass);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 425);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AllowUserToAddRows = false;
            this.dataGridViewClass.AllowUserToDeleteRows = false;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Location = new System.Drawing.Point(27, 104);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            this.dataGridViewClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewClass.RowHeadersVisible = false;
            this.dataGridViewClass.RowTemplate.Height = 24;
            this.dataGridViewClass.Size = new System.Drawing.Size(654, 134);
            this.dataGridViewClass.TabIndex = 5;
            // 
            // LiaInfo
            // 
            this.LiaInfo.AutoSize = true;
            this.LiaInfo.Location = new System.Drawing.Point(27, 264);
            this.LiaInfo.Name = "LiaInfo";
            this.LiaInfo.Size = new System.Drawing.Size(54, 17);
            this.LiaInfo.TabIndex = 6;
            this.LiaInfo.Text = "LiaInfo:";
            // 
            // dataGridViewLIA
            // 
            this.dataGridViewLIA.AllowUserToAddRows = false;
            this.dataGridViewLIA.AllowUserToDeleteRows = false;
            this.dataGridViewLIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLIA.Location = new System.Drawing.Point(30, 296);
            this.dataGridViewLIA.Name = "dataGridViewLIA";
            this.dataGridViewLIA.ReadOnly = true;
            this.dataGridViewLIA.RowHeadersVisible = false;
            this.dataGridViewLIA.RowTemplate.Height = 24;
            this.dataGridViewLIA.Size = new System.Drawing.Size(651, 123);
            this.dataGridViewLIA.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 449);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Elev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.DataGridView dataGridViewLIA;
        private System.Windows.Forms.Label LiaInfo;

    }
}

