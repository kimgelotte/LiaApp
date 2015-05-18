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
            this.ResultVisitId = new System.Windows.Forms.Label();
            this.VisitIdlabel = new System.Windows.Forms.Label();
            this.ResultPersonaltele = new System.Windows.Forms.Label();
            this.ResultPersonalName = new System.Windows.Forms.Label();
            this.ResultDatelabel = new System.Windows.Forms.Label();
            this.ResultCompanyName = new System.Windows.Forms.Label();
            this.ResultStudentName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Personallabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Companylabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SocialNumberlabel = new System.Windows.Forms.Label();
            this.ClassInfo = new System.Windows.Forms.Label();
            this.dataGridViewLIA = new System.Windows.Forms.DataGridView();
            this.LiaInfo = new System.Windows.Forms.Label();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.ElevBackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Välj klass ur lista:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ElevBackButton);
            this.groupBox1.Controls.Add(this.ResultVisitId);
            this.groupBox1.Controls.Add(this.VisitIdlabel);
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(935, 433);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Studentinfo";
            // 
            // ResultVisitId
            // 
            this.ResultVisitId.AutoSize = true;
            this.ResultVisitId.Location = new System.Drawing.Point(807, 230);
            this.ResultVisitId.Name = "ResultVisitId";
            this.ResultVisitId.Size = new System.Drawing.Size(0, 17);
            this.ResultVisitId.TabIndex = 24;
            // 
            // VisitIdlabel
            // 
            this.VisitIdlabel.AutoSize = true;
            this.VisitIdlabel.Location = new System.Drawing.Point(748, 230);
            this.VisitIdlabel.Name = "VisitIdlabel";
            this.VisitIdlabel.Size = new System.Drawing.Size(53, 17);
            this.VisitIdlabel.TabIndex = 23;
            this.VisitIdlabel.Text = "Visit Id:";
            // 
            // ResultPersonaltele
            // 
            this.ResultPersonaltele.AutoSize = true;
            this.ResultPersonaltele.Location = new System.Drawing.Point(808, 327);
            this.ResultPersonaltele.Name = "ResultPersonaltele";
            this.ResultPersonaltele.Size = new System.Drawing.Size(0, 17);
            this.ResultPersonaltele.TabIndex = 22;
            // 
            // ResultPersonalName
            // 
            this.ResultPersonalName.AutoSize = true;
            this.ResultPersonalName.Location = new System.Drawing.Point(808, 295);
            this.ResultPersonalName.Name = "ResultPersonalName";
            this.ResultPersonalName.Size = new System.Drawing.Size(0, 17);
            this.ResultPersonalName.TabIndex = 21;
            // 
            // ResultDatelabel
            // 
            this.ResultDatelabel.AutoSize = true;
            this.ResultDatelabel.Location = new System.Drawing.Point(808, 263);
            this.ResultDatelabel.Name = "ResultDatelabel";
            this.ResultDatelabel.Size = new System.Drawing.Size(0, 17);
            this.ResultDatelabel.TabIndex = 20;
            // 
            // ResultCompanyName
            // 
            this.ResultCompanyName.AutoSize = true;
            this.ResultCompanyName.Location = new System.Drawing.Point(808, 192);
            this.ResultCompanyName.Name = "ResultCompanyName";
            this.ResultCompanyName.Size = new System.Drawing.Size(0, 17);
            this.ResultCompanyName.TabIndex = 19;
            // 
            // ResultStudentName
            // 
            this.ResultStudentName.AutoSize = true;
            this.ResultStudentName.Location = new System.Drawing.Point(808, 162);
            this.ResultStudentName.Name = "ResultStudentName";
            this.ResultStudentName.Size = new System.Drawing.Size(0, 17);
            this.ResultStudentName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Personal tele:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student:";
            // 
            // Personallabel
            // 
            this.Personallabel.AutoSize = true;
            this.Personallabel.Location = new System.Drawing.Point(733, 295);
            this.Personallabel.Name = "Personallabel";
            this.Personallabel.Size = new System.Drawing.Size(68, 17);
            this.Personallabel.TabIndex = 15;
            this.Personallabel.Text = "Personal:";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Location = new System.Drawing.Point(759, 263);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(42, 17);
            this.Datelabel.TabIndex = 14;
            this.Datelabel.Text = "Date:";
            // 
            // Companylabel
            // 
            this.Companylabel.AutoSize = true;
            this.Companylabel.Location = new System.Drawing.Point(731, 192);
            this.Companylabel.Name = "Companylabel";
            this.Companylabel.Size = new System.Drawing.Size(71, 17);
            this.Companylabel.TabIndex = 13;
            this.Companylabel.Text = "Company:";
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
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(839, 101);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(69, 28);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(733, 103);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 22);
            this.SearchBox.TabIndex = 10;
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
            // ClassInfo
            // 
            this.ClassInfo.AutoSize = true;
            this.ClassInfo.Location = new System.Drawing.Point(27, 71);
            this.ClassInfo.Name = "ClassInfo";
            this.ClassInfo.Size = new System.Drawing.Size(69, 17);
            this.ClassInfo.TabIndex = 8;
            this.ClassInfo.Text = "ClassInfo:";
            // 
            // dataGridViewLIA
            // 
            this.dataGridViewLIA.AllowUserToAddRows = false;
            this.dataGridViewLIA.AllowUserToDeleteRows = false;
            this.dataGridViewLIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLIA.Location = new System.Drawing.Point(29, 295);
            this.dataGridViewLIA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLIA.Name = "dataGridViewLIA";
            this.dataGridViewLIA.ReadOnly = true;
            this.dataGridViewLIA.RowHeadersVisible = false;
            this.dataGridViewLIA.RowTemplate.Height = 24;
            this.dataGridViewLIA.Size = new System.Drawing.Size(651, 123);
            this.dataGridViewLIA.TabIndex = 7;
            // 
            // LiaInfo
            // 
            this.LiaInfo.AutoSize = true;
            this.LiaInfo.Location = new System.Drawing.Point(27, 263);
            this.LiaInfo.Name = "LiaInfo";
            this.LiaInfo.Size = new System.Drawing.Size(54, 17);
            this.LiaInfo.TabIndex = 6;
            this.LiaInfo.Text = "LiaInfo:";
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AllowUserToAddRows = false;
            this.dataGridViewClass.AllowUserToDeleteRows = false;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Location = new System.Drawing.Point(27, 103);
            this.dataGridViewClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            this.dataGridViewClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewClass.RowHeadersVisible = false;
            this.dataGridViewClass.RowTemplate.Height = 24;
            this.dataGridViewClass.Size = new System.Drawing.Size(653, 134);
            this.dataGridViewClass.TabIndex = 5;
            this.dataGridViewClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellContentClick);
            // 
            // ElevBackButton
            // 
            this.ElevBackButton.Location = new System.Drawing.Point(839, 394);
            this.ElevBackButton.Name = "ElevBackButton";
            this.ElevBackButton.Size = new System.Drawing.Size(90, 34);
            this.ElevBackButton.TabIndex = 25;
            this.ElevBackButton.Text = "Back";
            this.ElevBackButton.UseVisualStyleBackColor = true;
            this.ElevBackButton.Click += new System.EventHandler(this.ElevBackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 449);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Elev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
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
        private System.Windows.Forms.Label ResultVisitId;
        private System.Windows.Forms.Label VisitIdlabel;
        private System.Windows.Forms.Button ElevBackButton;

    }
}

