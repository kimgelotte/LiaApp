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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PersonaltoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTabells = new System.Windows.Forms.DataGridView();
            this.TabellcomboBox = new System.Windows.Forms.ComboBox();
            this.TabellLabel = new System.Windows.Forms.Label();
            this.databaseDataSet = new LiaApp.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new LiaApp.DatabaseDataSet1();
            this.lIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIATableAdapter = new LiaApp.DatabaseDataSet1TableAdapters.LIATableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIABindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PersonaltoolStripMenu
            // 
            this.PersonaltoolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.editToolStripMenuItem,
            this.absenceToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.toolStripSeparator1,
            this.LogoutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.PersonaltoolStripMenu.Name = "PersonaltoolStripMenu";
            this.PersonaltoolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.PersonaltoolStripMenu.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // absenceToolStripMenuItem
            // 
            this.absenceToolStripMenuItem.Name = "absenceToolStripMenuItem";
            this.absenceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.absenceToolStripMenuItem.Text = "Absence";
            this.absenceToolStripMenuItem.Click += new System.EventHandler(this.absenceToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LogoutToolStripMenuItem.Text = "Log out";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // dataGridViewTabells
            // 
            this.dataGridViewTabells.AllowUserToAddRows = false;
            this.dataGridViewTabells.AllowUserToDeleteRows = false;
            this.dataGridViewTabells.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewTabells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabells.Location = new System.Drawing.Point(9, 61);
            this.dataGridViewTabells.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTabells.Name = "dataGridViewTabells";
            this.dataGridViewTabells.ReadOnly = true;
            this.dataGridViewTabells.RowHeadersVisible = false;
            this.dataGridViewTabells.RowTemplate.Height = 24;
            this.dataGridViewTabells.Size = new System.Drawing.Size(775, 410);
            this.dataGridViewTabells.TabIndex = 1;
            // 
            // TabellcomboBox
            // 
            this.TabellcomboBox.FormattingEnabled = true;
            this.TabellcomboBox.Location = new System.Drawing.Point(78, 36);
            this.TabellcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TabellcomboBox.Name = "TabellcomboBox";
            this.TabellcomboBox.Size = new System.Drawing.Size(92, 21);
            this.TabellcomboBox.TabIndex = 2;
            this.TabellcomboBox.Text = "Browse...";
            this.TabellcomboBox.SelectedIndexChanged += new System.EventHandler(this.TabellcomboBox_SelectedIndexChanged_1);
            // 
            // TabellLabel
            // 
            this.TabellLabel.AutoSize = true;
            this.TabellLabel.Location = new System.Drawing.Point(9, 39);
            this.TabellLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TabellLabel.Name = "TabellLabel";
            this.TabellLabel.Size = new System.Drawing.Size(65, 13);
            this.TabellLabel.TabIndex = 3;
            this.TabellLabel.Text = "Select Class";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIABindingSource
            // 
            this.lIABindingSource.DataMember = "LIA";
            this.lIABindingSource.DataSource = this.databaseDataSet1;
            // 
            // lIATableAdapter
            // 
            this.lIATableAdapter.ClearBeforeFill = true;
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 482);
            this.Controls.Add(this.TabellLabel);
            this.Controls.Add(this.TabellcomboBox);
            this.Controls.Add(this.dataGridViewTabells);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.Load += new System.EventHandler(this.PersonalForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIABindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource lIABindingSource;
        private DatabaseDataSet1TableAdapters.LIATableAdapter lIATableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}