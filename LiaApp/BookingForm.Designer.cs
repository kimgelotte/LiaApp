namespace LiaApp
{
    partial class BookingForm
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
            this.BookingCancelButton = new System.Windows.Forms.Button();
            this.BookingOkButton = new System.Windows.Forms.Button();
            this.BookingSaveButton = new System.Windows.Forms.Button();
            this.Bookingdatagridlabel = new System.Windows.Forms.Label();
            this.databaseDataSet = new LiaApp.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookingEditButton = new System.Windows.Forms.Button();
            this.BookingNewButton = new System.Windows.Forms.Button();
            this.BookingdataGridView = new System.Windows.Forms.DataGridView();
            this.visitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDoneDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personalVisitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new LiaApp.DatabaseDataSet1();
            this.personalVisitsTableAdapter = new LiaApp.DatabaseDataSet1TableAdapters.PersonalVisitsTableAdapter();
            this.tableAdapterManager = new LiaApp.DatabaseDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalVisitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingCancelButton
            // 
            this.BookingCancelButton.Location = new System.Drawing.Point(256, 226);
            this.BookingCancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookingCancelButton.Name = "BookingCancelButton";
            this.BookingCancelButton.Size = new System.Drawing.Size(57, 27);
            this.BookingCancelButton.TabIndex = 1;
            this.BookingCancelButton.Text = "Cancel";
            this.BookingCancelButton.UseVisualStyleBackColor = true;
            this.BookingCancelButton.Click += new System.EventHandler(this.BookingCancelButton_Click);
            // 
            // BookingOkButton
            // 
            this.BookingOkButton.Location = new System.Drawing.Point(191, 226);
            this.BookingOkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookingOkButton.Name = "BookingOkButton";
            this.BookingOkButton.Size = new System.Drawing.Size(60, 27);
            this.BookingOkButton.TabIndex = 2;
            this.BookingOkButton.Text = "Ok";
            this.BookingOkButton.UseVisualStyleBackColor = true;
            this.BookingOkButton.Click += new System.EventHandler(this.BookingOkButton_Click);
            // 
            // BookingSaveButton
            // 
            this.BookingSaveButton.Location = new System.Drawing.Point(129, 226);
            this.BookingSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookingSaveButton.Name = "BookingSaveButton";
            this.BookingSaveButton.Size = new System.Drawing.Size(58, 27);
            this.BookingSaveButton.TabIndex = 5;
            this.BookingSaveButton.Text = "Save";
            this.BookingSaveButton.UseVisualStyleBackColor = true;
            // 
            // Bookingdatagridlabel
            // 
            this.Bookingdatagridlabel.AutoSize = true;
            this.Bookingdatagridlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookingdatagridlabel.Location = new System.Drawing.Point(118, 7);
            this.Bookingdatagridlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bookingdatagridlabel.Name = "Bookingdatagridlabel";
            this.Bookingdatagridlabel.Size = new System.Drawing.Size(83, 20);
            this.Bookingdatagridlabel.TabIndex = 6;
            this.Bookingdatagridlabel.Text = "Bookings";
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
            // BookingEditButton
            // 
            this.BookingEditButton.Location = new System.Drawing.Point(68, 226);
            this.BookingEditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookingEditButton.Name = "BookingEditButton";
            this.BookingEditButton.Size = new System.Drawing.Size(56, 27);
            this.BookingEditButton.TabIndex = 7;
            this.BookingEditButton.Text = "Edit";
            this.BookingEditButton.UseVisualStyleBackColor = true;
            // 
            // BookingNewButton
            // 
            this.BookingNewButton.Location = new System.Drawing.Point(8, 226);
            this.BookingNewButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookingNewButton.Name = "BookingNewButton";
            this.BookingNewButton.Size = new System.Drawing.Size(56, 27);
            this.BookingNewButton.TabIndex = 8;
            this.BookingNewButton.Text = "New";
            this.BookingNewButton.UseVisualStyleBackColor = true;
            // 
            // BookingdataGridView
            // 
            this.BookingdataGridView.AutoGenerateColumns = false;
            this.BookingdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitIdDataGridViewTextBoxColumn,
            this.pIdDataGridViewTextBoxColumn,
            this.visitDateDataGridViewTextBoxColumn,
            this.visitDoneDataGridViewCheckBoxColumn});
            this.BookingdataGridView.DataSource = this.personalVisitsBindingSource;
            this.BookingdataGridView.Location = new System.Drawing.Point(8, 30);
            this.BookingdataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookingdataGridView.Name = "BookingdataGridView";
            this.BookingdataGridView.RowTemplate.Height = 24;
            this.BookingdataGridView.Size = new System.Drawing.Size(304, 191);
            this.BookingdataGridView.TabIndex = 9;
            // 
            // visitIdDataGridViewTextBoxColumn
            // 
            this.visitIdDataGridViewTextBoxColumn.DataPropertyName = "Visit_Id";
            this.visitIdDataGridViewTextBoxColumn.HeaderText = "Visit_Id";
            this.visitIdDataGridViewTextBoxColumn.Name = "visitIdDataGridViewTextBoxColumn";
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "P_Id";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "P_Id";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            // 
            // visitDateDataGridViewTextBoxColumn
            // 
            this.visitDateDataGridViewTextBoxColumn.DataPropertyName = "VisitDate";
            this.visitDateDataGridViewTextBoxColumn.HeaderText = "VisitDate";
            this.visitDateDataGridViewTextBoxColumn.Name = "visitDateDataGridViewTextBoxColumn";
            // 
            // visitDoneDataGridViewCheckBoxColumn
            // 
            this.visitDoneDataGridViewCheckBoxColumn.DataPropertyName = "Visit_Done";
            this.visitDoneDataGridViewCheckBoxColumn.HeaderText = "Visit_Done";
            this.visitDoneDataGridViewCheckBoxColumn.Name = "visitDoneDataGridViewCheckBoxColumn";
            // 
            // personalVisitsBindingSource
            // 
            this.personalVisitsBindingSource.DataMember = "PersonalVisits";
            this.personalVisitsBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalVisitsTableAdapter
            // 
            this.personalVisitsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonalVisitsTableAdapter = this.personalVisitsTableAdapter;
            this.tableAdapterManager.UpdateOrder = LiaApp.DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 266);
            this.Controls.Add(this.BookingdataGridView);
            this.Controls.Add(this.BookingNewButton);
            this.Controls.Add(this.BookingEditButton);
            this.Controls.Add(this.Bookingdatagridlabel);
            this.Controls.Add(this.BookingSaveButton);
            this.Controls.Add(this.BookingOkButton);
            this.Controls.Add(this.BookingCancelButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookingForm";
            this.Text = "LiaAPP - Booking";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalVisitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BookingCancelButton;
        private System.Windows.Forms.Button BookingOkButton;
        private System.Windows.Forms.Button BookingSaveButton;
        private System.Windows.Forms.Label Bookingdatagridlabel;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.Button BookingEditButton;
        private System.Windows.Forms.Button BookingNewButton;
        private System.Windows.Forms.DataGridView BookingdataGridView;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource personalVisitsBindingSource;
        private DatabaseDataSet1TableAdapters.PersonalVisitsTableAdapter personalVisitsTableAdapter;
        private DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visitDoneDataGridViewCheckBoxColumn;
    }
}