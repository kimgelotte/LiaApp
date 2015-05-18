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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PersonaltoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTabells = new System.Windows.Forms.DataGridView();
            this.TabellcomboBox = new System.Windows.Forms.ComboBox();
            this.TabellLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabells)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonaltoolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PersonaltoolStripMenu
            // 
            this.PersonaltoolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.editToolStripMenuItem,
            this.absenceToolStripMenuItem,
            this.bookingToolStripMenuItem});
            this.PersonaltoolStripMenu.Name = "PersonaltoolStripMenu";
            this.PersonaltoolStripMenu.Size = new System.Drawing.Size(46, 20);
            this.PersonaltoolStripMenu.Text = "Arkiv";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // absenceToolStripMenuItem
            // 
            this.absenceToolStripMenuItem.Name = "absenceToolStripMenuItem";
            this.absenceToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.absenceToolStripMenuItem.Text = "Absence";
            this.absenceToolStripMenuItem.Click += new System.EventHandler(this.absenceToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // dataGridViewTabells
            // 
            this.dataGridViewTabells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabells.Location = new System.Drawing.Point(9, 61);
            this.dataGridViewTabells.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTabells.Name = "dataGridViewTabells";
            this.dataGridViewTabells.RowTemplate.Height = 24;
            this.dataGridViewTabells.Size = new System.Drawing.Size(490, 224);
            this.dataGridViewTabells.TabIndex = 1;
            // 
            // TabellcomboBox
            // 
            this.TabellcomboBox.FormattingEnabled = true;
            this.TabellcomboBox.Items.AddRange(new object[] {
            "Absence"});
            this.TabellcomboBox.Location = new System.Drawing.Point(52, 37);
            this.TabellcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabellcomboBox.Name = "TabellcomboBox";
            this.TabellcomboBox.Size = new System.Drawing.Size(92, 21);
            this.TabellcomboBox.TabIndex = 2;
            // 
            // TabellLabel
            // 
            this.TabellLabel.AutoSize = true;
            this.TabellLabel.Location = new System.Drawing.Point(9, 39);
            this.TabellLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TabellLabel.Name = "TabellLabel";
            this.TabellLabel.Size = new System.Drawing.Size(39, 13);
            this.TabellLabel.TabIndex = 3;
            this.TabellLabel.Text = "Tabell:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(442, 290);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(56, 19);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 317);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TabellLabel);
            this.Controls.Add(this.TabellcomboBox);
            this.Controls.Add(this.dataGridViewTabells);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabells)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PersonaltoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTabells;
        private System.Windows.Forms.ComboBox TabellcomboBox;
        private System.Windows.Forms.Label TabellLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}