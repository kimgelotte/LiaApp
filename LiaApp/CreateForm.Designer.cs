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
            this.labelCreate = new System.Windows.Forms.Label();
            this.buttonCancelCreate = new System.Windows.Forms.Button();
            this.buttonCreateSave = new System.Windows.Forms.Button();
            this.panelCreateStud = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panelCreateStud.SuspendLayout();
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
            this.comboBoxCreate.Location = new System.Drawing.Point(40, 50);
            this.comboBoxCreate.Name = "comboBoxCreate";
            this.comboBoxCreate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCreate.TabIndex = 0;
            this.comboBoxCreate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.buttonCreateSave.Click += new System.EventHandler(this.buttonCreateSave_Click);
            // 
            // panelCreateStud
            // 
            this.panelCreateStud.Controls.Add(this.textBox5);
            this.panelCreateStud.Controls.Add(this.textBox4);
            this.panelCreateStud.Controls.Add(this.textBox3);
            this.panelCreateStud.Controls.Add(this.textBox2);
            this.panelCreateStud.Controls.Add(this.textBoxName);
            this.panelCreateStud.Location = new System.Drawing.Point(40, 109);
            this.panelCreateStud.Name = "panelCreateStud";
            this.panelCreateStud.Size = new System.Drawing.Size(766, 274);
            this.panelCreateStud.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(200, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(200, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 4;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 443);
            this.Controls.Add(this.panelCreateStud);
            this.Controls.Add(this.buttonCreateSave);
            this.Controls.Add(this.buttonCancelCreate);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.comboBoxCreate);
            this.Name = "CreateForm";
            this.Text = "Create new";
            this.panelCreateStud.ResumeLayout(false);
            this.panelCreateStud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCreate;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Button buttonCancelCreate;
        private System.Windows.Forms.Button buttonCreateSave;
        private System.Windows.Forms.Panel panelCreateStud;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxName;
    }
}