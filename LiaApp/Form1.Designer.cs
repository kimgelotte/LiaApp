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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKlasser = new System.Windows.Forms.ComboBox();
            this.DataGridKlassView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridKlassView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(284, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(284, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Välj elev ur lista:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 252);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elever";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Klass:";
            // 
            // comboBoxKlasser
            // 
            this.comboBoxKlasser.FormattingEnabled = true;
            this.comboBoxKlasser.Location = new System.Drawing.Point(56, 287);
            this.comboBoxKlasser.Name = "comboBoxKlasser";
            this.comboBoxKlasser.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKlasser.TabIndex = 9;
            this.comboBoxKlasser.SelectedIndexChanged += new System.EventHandler(this.comboBoxKlasser_SelectedIndexChanged);
            // 
            // DataGridKlassView
            // 
            this.DataGridKlassView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridKlassView.Location = new System.Drawing.Point(29, 317);
            this.DataGridKlassView.Name = "DataGridKlassView";
            this.DataGridKlassView.RowTemplate.Height = 24;
            this.DataGridKlassView.Size = new System.Drawing.Size(651, 213);
            this.DataGridKlassView.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 576);
            this.Controls.Add(this.DataGridKlassView);
            this.Controls.Add(this.comboBoxKlasser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Elev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridKlassView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxKlasser;
        private System.Windows.Forms.DataGridView DataGridKlassView;

    }
}

