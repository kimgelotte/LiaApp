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
            this.BookingNewButton = new System.Windows.Forms.Button();
            this.BookinglistBox = new System.Windows.Forms.ListBox();
            this.BookingdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BookingcheckBox = new System.Windows.Forms.CheckBox();
            this.BookingPersonallabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.databaseDataSetBooking = new LiaApp.DatabaseDataSetBooking();
            this.personalVisitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalVisitsTableAdapter = new LiaApp.DatabaseDataSetBookingTableAdapters.PersonalVisitsTableAdapter();
            this.BookingStudentlabel = new System.Windows.Forms.Label();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new LiaApp.DatabaseDataSetBookingTableAdapters.PersonalTableAdapter();
            this.lIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIATableAdapter = new LiaApp.DatabaseDataSetBookingTableAdapters.LIATableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new LiaApp.DatabaseDataSetBookingTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalVisitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingCancelButton
            // 
            this.BookingCancelButton.Location = new System.Drawing.Point(262, 278);
            this.BookingCancelButton.Name = "BookingCancelButton";
            this.BookingCancelButton.Size = new System.Drawing.Size(57, 27);
            this.BookingCancelButton.TabIndex = 1;
            this.BookingCancelButton.Text = "Cancel";
            this.BookingCancelButton.UseVisualStyleBackColor = true;
            this.BookingCancelButton.Click += new System.EventHandler(this.BookingCancelButton_Click);
            // 
            // BookingOkButton
            // 
            this.BookingOkButton.Location = new System.Drawing.Point(176, 278);
            this.BookingOkButton.Name = "BookingOkButton";
            this.BookingOkButton.Size = new System.Drawing.Size(60, 27);
            this.BookingOkButton.TabIndex = 2;
            this.BookingOkButton.Text = "Ok";
            this.BookingOkButton.UseVisualStyleBackColor = true;
            this.BookingOkButton.Click += new System.EventHandler(this.BookingOkButton_Click);
            // 
            // BookingSaveButton
            // 
            this.BookingSaveButton.Location = new System.Drawing.Point(93, 278);
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
            this.Bookingdatagridlabel.Location = new System.Drawing.Point(114, 9);
            this.Bookingdatagridlabel.Name = "Bookingdatagridlabel";
            this.Bookingdatagridlabel.Size = new System.Drawing.Size(83, 20);
            this.Bookingdatagridlabel.TabIndex = 6;
            this.Bookingdatagridlabel.Text = "Bookings";
            // 
            // BookingNewButton
            // 
            this.BookingNewButton.Location = new System.Drawing.Point(12, 278);
            this.BookingNewButton.Name = "BookingNewButton";
            this.BookingNewButton.Size = new System.Drawing.Size(56, 27);
            this.BookingNewButton.TabIndex = 8;
            this.BookingNewButton.Text = "New";
            this.BookingNewButton.UseVisualStyleBackColor = true;
            this.BookingNewButton.Click += new System.EventHandler(this.BookingNewButton_Click);
            // 
            // BookinglistBox
            // 
            this.BookinglistBox.DataSource = this.personalVisitsBindingSource;
            this.BookinglistBox.DisplayMember = "Visit_Id";
            this.BookinglistBox.FormattingEnabled = true;
            this.BookinglistBox.ItemHeight = 16;
            this.BookinglistBox.Location = new System.Drawing.Point(12, 48);
            this.BookinglistBox.Name = "BookinglistBox";
            this.BookinglistBox.Size = new System.Drawing.Size(45, 212);
            this.BookinglistBox.TabIndex = 9;
            this.BookinglistBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BookingdateTimePicker
            // 
            this.BookingdateTimePicker.Location = new System.Drawing.Point(107, 130);
            this.BookingdateTimePicker.Name = "BookingdateTimePicker";
            this.BookingdateTimePicker.Size = new System.Drawing.Size(190, 22);
            this.BookingdateTimePicker.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.personalBindingSource;
            this.comboBox1.DisplayMember = "PNamn";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "P_Id";
            // 
            // BookingcheckBox
            // 
            this.BookingcheckBox.AutoSize = true;
            this.BookingcheckBox.Location = new System.Drawing.Point(195, 173);
            this.BookingcheckBox.Name = "BookingcheckBox";
            this.BookingcheckBox.Size = new System.Drawing.Size(102, 21);
            this.BookingcheckBox.TabIndex = 12;
            this.BookingcheckBox.Text = "Visit Done?";
            this.BookingcheckBox.UseVisualStyleBackColor = true;
            // 
            // BookingPersonallabel
            // 
            this.BookingPersonallabel.AutoSize = true;
            this.BookingPersonallabel.Location = new System.Drawing.Point(104, 57);
            this.BookingPersonallabel.Name = "BookingPersonallabel";
            this.BookingPersonallabel.Size = new System.Drawing.Size(72, 17);
            this.BookingPersonallabel.TabIndex = 13;
            this.BookingPersonallabel.Text = "Personal: ";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.studentBindingSource;
            this.comboBox2.DisplayMember = "Namn";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(176, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "Id";
            // 
            // databaseDataSetBooking
            // 
            this.databaseDataSetBooking.DataSetName = "DatabaseDataSetBooking";
            this.databaseDataSetBooking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalVisitsBindingSource
            // 
            this.personalVisitsBindingSource.DataMember = "PersonalVisits";
            this.personalVisitsBindingSource.DataSource = this.databaseDataSetBooking;
            // 
            // personalVisitsTableAdapter
            // 
            this.personalVisitsTableAdapter.ClearBeforeFill = true;
            // 
            // BookingStudentlabel
            // 
            this.BookingStudentlabel.AutoSize = true;
            this.BookingStudentlabel.Location = new System.Drawing.Point(109, 88);
            this.BookingStudentlabel.Name = "BookingStudentlabel";
            this.BookingStudentlabel.Size = new System.Drawing.Size(61, 17);
            this.BookingStudentlabel.TabIndex = 15;
            this.BookingStudentlabel.Text = "Student:";
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.databaseDataSetBooking;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // lIABindingSource
            // 
            this.lIABindingSource.DataMember = "LIA";
            this.lIABindingSource.DataSource = this.databaseDataSetBooking;
            // 
            // lIATableAdapter
            // 
            this.lIATableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.databaseDataSetBooking;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // personalVisitsBindingSource
            // 
            this.personalVisitsBindingSource.DataMember = "PersonalVisits";

            // 
            // databaseDataSet1
            // 

            // 
            // personalVisitsTableAdapter
            // 
            this.personalVisitsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 

            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 327);
            this.Controls.Add(this.BookingStudentlabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.BookingPersonallabel);
            this.Controls.Add(this.BookingcheckBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BookingdateTimePicker);
            this.Controls.Add(this.BookinglistBox);
            this.Controls.Add(this.BookingNewButton);
            this.Controls.Add(this.Bookingdatagridlabel);
            this.Controls.Add(this.BookingSaveButton);
            this.Controls.Add(this.BookingOkButton);
            this.Controls.Add(this.BookingCancelButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookingForm";
            this.Text = "LiaAPP - Booking";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalVisitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BookingCancelButton;
        private System.Windows.Forms.Button BookingOkButton;
        private System.Windows.Forms.Button BookingSaveButton;
        private System.Windows.Forms.Label Bookingdatagridlabel;
        private System.Windows.Forms.Button BookingNewButton;
        private System.Windows.Forms.ListBox BookinglistBox;
        private System.Windows.Forms.DateTimePicker BookingdateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox BookingcheckBox;
        private System.Windows.Forms.Label BookingPersonallabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private DatabaseDataSetBooking databaseDataSetBooking;
        private System.Windows.Forms.BindingSource personalVisitsBindingSource;
        private DatabaseDataSetBookingTableAdapters.PersonalVisitsTableAdapter personalVisitsTableAdapter;
        private System.Windows.Forms.Label BookingStudentlabel;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private DatabaseDataSetBookingTableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.BindingSource lIABindingSource;
        private DatabaseDataSetBookingTableAdapters.LIATableAdapter lIATableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DatabaseDataSetBookingTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}