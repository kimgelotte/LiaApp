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
            this.ClassInfo = new System.Windows.Forms.Label();
            this.SocialNumberlabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Companylabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Personallabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultStudentName = new System.Windows.Forms.Label();
            this.ResultCompanyName = new System.Windows.Forms.Label();
            this.ResultDatelabel = new System.Windows.Forms.Label();
            this.ResultPersonalName = new System.Windows.Forms.Label();
            this.ResultPersonaltele = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.ResultPersonaltele);
            this.groupBox1.Controls.Add(this.ResultPersonalName);
            this.groupBox1.Controls.Add(this.ResultDatelabel);
            this.groupBox1.Controls.Add(this.ResultCompanyName);
            this.groupBox1.Controls.Add(this.ResultStudentName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Personallabel);
            this.groupBox1.Controls.Add(this.Datelabel);
            this.groupBox1.Controls.Add(this.Companylabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.SearchBox);
            this.groupBox1.Controls.Add(this.SocialNumberlabel);
            this.groupBox1.Controls.Add(this.ClassInfo);
            this.groupBox1.Controls.Add(this.dataGridViewLIA);
            this.groupBox1.Controls.Add(this.LiaInfo);
            this.groupBox1.Controls.Add(this.dataGridViewClass);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 433);
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
            // ClassInfo
            // 
            this.ClassInfo.AutoSize = true;
            this.ClassInfo.Location = new System.Drawing.Point(27, 71);
            this.ClassInfo.Name = "ClassInfo";
            this.ClassInfo.Size = new System.Drawing.Size(69, 17);
            this.ClassInfo.TabIndex = 8;
            this.ClassInfo.Text = "ClassInfo:";
            // 
            // SocialNumberlabel
            // 
            this.SocialNumberlabel.AutoSize = true;
            this.SocialNumberlabel.Location = new System.Drawing.Point(733, 84);
            this.SocialNumberlabel.Name = "SocialNumberlabel";
            this.SocialNumberlabel.Size = new System.Drawing.Size(100, 17);
            this.SocialNumberlabel.TabIndex = 9;
            this.SocialNumberlabel.Text = "Social Number";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(733, 104);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 22);
            this.SearchBox.TabIndex = 10;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(839, 103);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(69, 22);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search";
            this.Search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(757, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lia meeting \r\ninformation";
            // 
            // Companylabel
            // 
            this.Companylabel.AutoSize = true;
            this.Companylabel.Location = new System.Drawing.Point(730, 192);
            this.Companylabel.Name = "Companylabel";
            this.Companylabel.Size = new System.Drawing.Size(71, 17);
            this.Companylabel.TabIndex = 13;
            this.Companylabel.Text = "Company:";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Location = new System.Drawing.Point(759, 233);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(42, 17);
            this.Datelabel.TabIndex = 14;
            this.Datelabel.Text = "Date:";
            // 
            // Personallabel
            // 
            this.Personallabel.AutoSize = true;
            this.Personallabel.Location = new System.Drawing.Point(733, 274);
            this.Personallabel.Name = "Personallabel";
            this.Personallabel.Size = new System.Drawing.Size(68, 17);
            this.Personallabel.TabIndex = 15;
            this.Personallabel.Text = "Personal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Personal-tele:";
            // 
            // ResultStudentName
            // 
            this.ResultStudentName.AutoSize = true;
            this.ResultStudentName.Location = new System.Drawing.Point(808, 151);
            this.ResultStudentName.Name = "ResultStudentName";
            this.ResultStudentName.Size = new System.Drawing.Size(0, 17);
            this.ResultStudentName.TabIndex = 18;
            // 
            // ResultCompanyName
            // 
            this.ResultCompanyName.AutoSize = true;
            this.ResultCompanyName.Location = new System.Drawing.Point(808, 192);
            this.ResultCompanyName.Name = "ResultCompanyName";
            this.ResultCompanyName.Size = new System.Drawing.Size(0, 17);
            this.ResultCompanyName.TabIndex = 19;
            // 
            // ResultDatelabel
            // 
            this.ResultDatelabel.AutoSize = true;
            this.ResultDatelabel.Location = new System.Drawing.Point(808, 233);
            this.ResultDatelabel.Name = "ResultDatelabel";
            this.ResultDatelabel.Size = new System.Drawing.Size(0, 17);
            this.ResultDatelabel.TabIndex = 20;
            // 
            // ResultPersonalName
            // 
            this.ResultPersonalName.AutoSize = true;
            this.ResultPersonalName.Location = new System.Drawing.Point(808, 274);
            this.ResultPersonalName.Name = "ResultPersonalName";
            this.ResultPersonalName.Size = new System.Drawing.Size(0, 17);
            this.ResultPersonalName.TabIndex = 21;
            // 
            // ResultPersonaltele
            // 
            this.ResultPersonaltele.AutoSize = true;
            this.ResultPersonaltele.Location = new System.Drawing.Point(808, 318);
            this.ResultPersonaltele.Name = "ResultPersonaltele";
            this.ResultPersonaltele.Size = new System.Drawing.Size(0, 17);
            this.ResultPersonaltele.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 449);
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
        private System.Windows.Forms.Label ResultPersonaltele;
        private System.Windows.Forms.Label ResultPersonalName;
        private System.Windows.Forms.Label ResultDatelabel;
        private System.Windows.Forms.Label ResultCompanyName;
        private System.Windows.Forms.Label ResultStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Personallabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Companylabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SocialNumberlabel;
        private System.Windows.Forms.Label ClassInfo;

    }
}

