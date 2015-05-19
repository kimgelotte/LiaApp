﻿namespace LiaApp
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
            this.panelCreateStudent = new System.Windows.Forms.Panel();
            this.comboBoxCrSt = new System.Windows.Forms.ComboBox();
            this.checkBoxCreateExamen = new System.Windows.Forms.CheckBox();
            this.textBoxCteateMail = new System.Windows.Forms.TextBox();
            this.labelCreateClass = new System.Windows.Forms.Label();
            this.labelCreateMail = new System.Windows.Forms.Label();
            this.labelCreateExamen = new System.Windows.Forms.Label();
            this.labelCreatePnum = new System.Windows.Forms.Label();
            this.textBoxCreatePnummer = new System.Windows.Forms.TextBox();
            this.labelCreatePadress = new System.Windows.Forms.Label();
            this.labelCreateAdress = new System.Windows.Forms.Label();
            this.labelCreatePnummer = new System.Windows.Forms.Label();
            this.labelCreateNamn = new System.Windows.Forms.Label();
            this.labelCreateID = new System.Windows.Forms.Label();
            this.textBoxCreatePadress = new System.Windows.Forms.TextBox();
            this.textBoxcREATEADRESS = new System.Windows.Forms.TextBox();
            this.textBoxcREATEpERSNR = new System.Windows.Forms.TextBox();
            this.textBoxcREATEnAME = new System.Windows.Forms.TextBox();
            this.textBoxcREATEid = new System.Windows.Forms.TextBox();
            this.panelCreatePersonal = new System.Windows.Forms.Panel();
            this.labelCreaMail = new System.Windows.Forms.Label();
            this.labelCrTele = new System.Windows.Forms.Label();
            this.labelCreNam = new System.Windows.Forms.Label();
            this.labelCreId = new System.Windows.Forms.Label();
            this.textBoxCreateMail = new System.Windows.Forms.TextBox();
            this.textBoxCreateTele = new System.Windows.Forms.TextBox();
            this.textBoxCreateNamn = new System.Windows.Forms.TextBox();
            this.textBoxP_Id = new System.Windows.Forms.TextBox();
            this.panelCreateCompany = new System.Windows.Forms.Panel();
            this.labelCreatePostN = new System.Windows.Forms.Label();
            this.labelCreatePostA = new System.Windows.Forms.Label();
            this.labelCreatetfn = new System.Windows.Forms.Label();
            this.labelCrAdress = new System.Windows.Forms.Label();
            this.labelCreateForetag = new System.Windows.Forms.Label();
            this.textBoxCrFoPN = new System.Windows.Forms.TextBox();
            this.textBoxCrFoPA = new System.Windows.Forms.TextBox();
            this.textBoxCrFoTfn = new System.Windows.Forms.TextBox();
            this.textBoxCrFoAd = new System.Windows.Forms.TextBox();
            this.textBoxCrFo = new System.Windows.Forms.TextBox();
            this.panelCreateStudent.SuspendLayout();
            this.panelCreatePersonal.SuspendLayout();
            this.panelCreateCompany.SuspendLayout();
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
            this.comboBoxCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCreate.Name = "comboBoxCreate";
            this.comboBoxCreate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCreate.TabIndex = 0;
            this.comboBoxCreate.Text = "Browse...";
            this.comboBoxCreate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Location = new System.Drawing.Point(40, 14);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(153, 17);
            this.labelCreate.TabIndex = 2;
            this.labelCreate.Text = "Select object to create:";
            // 
            // buttonCancelCreate
            // 
            this.buttonCancelCreate.Location = new System.Drawing.Point(629, 399);
            this.buttonCancelCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelCreate.Name = "buttonCancelCreate";
            this.buttonCancelCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelCreate.TabIndex = 3;
            this.buttonCancelCreate.Text = "Cancel";
            this.buttonCancelCreate.UseVisualStyleBackColor = true;
            this.buttonCancelCreate.Click += new System.EventHandler(this.buttonCancelCreate_Click);
            // 
            // buttonCreateSave
            // 
            this.buttonCreateSave.Location = new System.Drawing.Point(498, 399);
            this.buttonCreateSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateSave.Name = "buttonCreateSave";
            this.buttonCreateSave.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateSave.TabIndex = 4;
            this.buttonCreateSave.Text = "Save";
            this.buttonCreateSave.UseVisualStyleBackColor = true;
            this.buttonCreateSave.Click += new System.EventHandler(this.buttonCreateSave_Click);
            // 
            // panelCreateStudent
            // 
            this.panelCreateStudent.Controls.Add(this.comboBoxCrSt);
            this.panelCreateStudent.Controls.Add(this.checkBoxCreateExamen);
            this.panelCreateStudent.Controls.Add(this.textBoxCteateMail);
            this.panelCreateStudent.Controls.Add(this.labelCreateClass);
            this.panelCreateStudent.Controls.Add(this.labelCreateMail);
            this.panelCreateStudent.Controls.Add(this.labelCreateExamen);
            this.panelCreateStudent.Controls.Add(this.labelCreatePnum);
            this.panelCreateStudent.Controls.Add(this.textBoxCreatePnummer);
            this.panelCreateStudent.Controls.Add(this.labelCreatePadress);
            this.panelCreateStudent.Controls.Add(this.labelCreateAdress);
            this.panelCreateStudent.Controls.Add(this.labelCreatePnummer);
            this.panelCreateStudent.Controls.Add(this.labelCreateNamn);
            this.panelCreateStudent.Controls.Add(this.labelCreateID);
            this.panelCreateStudent.Controls.Add(this.textBoxCreatePadress);
            this.panelCreateStudent.Controls.Add(this.textBoxcREATEADRESS);
            this.panelCreateStudent.Controls.Add(this.textBoxcREATEpERSNR);
            this.panelCreateStudent.Controls.Add(this.textBoxcREATEnAME);
            this.panelCreateStudent.Controls.Add(this.textBoxcREATEid);
            this.panelCreateStudent.Location = new System.Drawing.Point(43, 110);
            this.panelCreateStudent.Name = "panelCreateStudent";
            this.panelCreateStudent.Size = new System.Drawing.Size(661, 253);
            this.panelCreateStudent.TabIndex = 5;
            this.panelCreateStudent.Visible = false;
            this.panelCreateStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCreateStudent_Paint);
            // 
            // comboBoxCrSt
            // 
            this.comboBoxCrSt.FormattingEnabled = true;
            this.comboBoxCrSt.Location = new System.Drawing.Point(491, 166);
            this.comboBoxCrSt.Name = "comboBoxCrSt";
            this.comboBoxCrSt.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCrSt.TabIndex = 18;
            // 
            // checkBoxCreateExamen
            // 
            this.checkBoxCreateExamen.AutoSize = true;
            this.checkBoxCreateExamen.Location = new System.Drawing.Point(530, 60);
            this.checkBoxCreateExamen.Name = "checkBoxCreateExamen";
            this.checkBoxCreateExamen.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCreateExamen.TabIndex = 17;
            this.checkBoxCreateExamen.UseVisualStyleBackColor = true;
            // 
            // textBoxCteateMail
            // 
            this.textBoxCteateMail.Location = new System.Drawing.Point(491, 111);
            this.textBoxCteateMail.Name = "textBoxCteateMail";
            this.textBoxCteateMail.Size = new System.Drawing.Size(100, 22);
            this.textBoxCteateMail.TabIndex = 15;
            // 
            // labelCreateClass
            // 
            this.labelCreateClass.AutoSize = true;
            this.labelCreateClass.Location = new System.Drawing.Point(391, 166);
            this.labelCreateClass.Name = "labelCreateClass";
            this.labelCreateClass.Size = new System.Drawing.Size(46, 17);
            this.labelCreateClass.TabIndex = 14;
            this.labelCreateClass.Text = "Class:";
            // 
            // labelCreateMail
            // 
            this.labelCreateMail.AutoSize = true;
            this.labelCreateMail.Location = new System.Drawing.Point(391, 115);
            this.labelCreateMail.Name = "labelCreateMail";
            this.labelCreateMail.Size = new System.Drawing.Size(80, 17);
            this.labelCreateMail.TabIndex = 13;
            this.labelCreateMail.Text = "Mailadress:";
            // 
            // labelCreateExamen
            // 
            this.labelCreateExamen.AutoSize = true;
            this.labelCreateExamen.Location = new System.Drawing.Point(391, 64);
            this.labelCreateExamen.Name = "labelCreateExamen";
            this.labelCreateExamen.Size = new System.Drawing.Size(46, 17);
            this.labelCreateExamen.TabIndex = 12;
            this.labelCreateExamen.Text = "Exam:";
            // 
            // labelCreatePnum
            // 
            this.labelCreatePnum.AutoSize = true;
            this.labelCreatePnum.Location = new System.Drawing.Point(388, 17);
            this.labelCreatePnum.Name = "labelCreatePnum";
            this.labelCreatePnum.Size = new System.Drawing.Size(96, 17);
            this.labelCreatePnum.TabIndex = 11;
            this.labelCreatePnum.Text = "Area Number:";
            // 
            // textBoxCreatePnummer
            // 
            this.textBoxCreatePnummer.Location = new System.Drawing.Point(491, 17);
            this.textBoxCreatePnummer.Name = "textBoxCreatePnummer";
            this.textBoxCreatePnummer.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreatePnummer.TabIndex = 10;
            // 
            // labelCreatePadress
            // 
            this.labelCreatePadress.AutoSize = true;
            this.labelCreatePadress.Location = new System.Drawing.Point(21, 206);
            this.labelCreatePadress.Name = "labelCreatePadress";
            this.labelCreatePadress.Size = new System.Drawing.Size(79, 17);
            this.labelCreatePadress.TabIndex = 9;
            this.labelCreatePadress.Text = "Area Code:";
            // 
            // labelCreateAdress
            // 
            this.labelCreateAdress.AutoSize = true;
            this.labelCreateAdress.Location = new System.Drawing.Point(21, 162);
            this.labelCreateAdress.Name = "labelCreateAdress";
            this.labelCreateAdress.Size = new System.Drawing.Size(56, 17);
            this.labelCreateAdress.TabIndex = 8;
            this.labelCreateAdress.Text = "Adress:";
            // 
            // labelCreatePnummer
            // 
            this.labelCreatePnummer.AutoSize = true;
            this.labelCreatePnummer.Location = new System.Drawing.Point(21, 111);
            this.labelCreatePnummer.Name = "labelCreatePnummer";
            this.labelCreatePnummer.Size = new System.Drawing.Size(63, 17);
            this.labelCreatePnummer.TabIndex = 7;
            this.labelCreatePnummer.Text = "Socialnr:";
            // 
            // labelCreateNamn
            // 
            this.labelCreateNamn.AutoSize = true;
            this.labelCreateNamn.Location = new System.Drawing.Point(21, 60);
            this.labelCreateNamn.Name = "labelCreateNamn";
            this.labelCreateNamn.Size = new System.Drawing.Size(49, 17);
            this.labelCreateNamn.TabIndex = 6;
            this.labelCreateNamn.Text = "Name:";
            // 
            // labelCreateID
            // 
            this.labelCreateID.AutoSize = true;
            this.labelCreateID.Location = new System.Drawing.Point(21, 17);
            this.labelCreateID.Name = "labelCreateID";
            this.labelCreateID.Size = new System.Drawing.Size(25, 17);
            this.labelCreateID.TabIndex = 5;
            this.labelCreateID.Text = "ID:";
            // 
            // textBoxCreatePadress
            // 
            this.textBoxCreatePadress.Location = new System.Drawing.Point(117, 206);
            this.textBoxCreatePadress.Name = "textBoxCreatePadress";
            this.textBoxCreatePadress.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreatePadress.TabIndex = 4;
            // 
            // textBoxcREATEADRESS
            // 
            this.textBoxcREATEADRESS.Location = new System.Drawing.Point(117, 162);
            this.textBoxcREATEADRESS.Name = "textBoxcREATEADRESS";
            this.textBoxcREATEADRESS.Size = new System.Drawing.Size(100, 22);
            this.textBoxcREATEADRESS.TabIndex = 3;
            // 
            // textBoxcREATEpERSNR
            // 
            this.textBoxcREATEpERSNR.Location = new System.Drawing.Point(117, 111);
            this.textBoxcREATEpERSNR.Name = "textBoxcREATEpERSNR";
            this.textBoxcREATEpERSNR.Size = new System.Drawing.Size(100, 22);
            this.textBoxcREATEpERSNR.TabIndex = 2;
            // 
            // textBoxcREATEnAME
            // 
            this.textBoxcREATEnAME.Location = new System.Drawing.Point(117, 60);
            this.textBoxcREATEnAME.Name = "textBoxcREATEnAME";
            this.textBoxcREATEnAME.Size = new System.Drawing.Size(100, 22);
            this.textBoxcREATEnAME.TabIndex = 1;
            // 
            // textBoxcREATEid
            // 
            this.textBoxcREATEid.Location = new System.Drawing.Point(117, 17);
            this.textBoxcREATEid.Name = "textBoxcREATEid";
            this.textBoxcREATEid.Size = new System.Drawing.Size(100, 22);
            this.textBoxcREATEid.TabIndex = 0;
            // 
            // panelCreatePersonal
            // 
            this.panelCreatePersonal.Controls.Add(this.labelCreaMail);
            this.panelCreatePersonal.Controls.Add(this.labelCrTele);
            this.panelCreatePersonal.Controls.Add(this.labelCreNam);
            this.panelCreatePersonal.Controls.Add(this.labelCreId);
            this.panelCreatePersonal.Controls.Add(this.textBoxCreateMail);
            this.panelCreatePersonal.Controls.Add(this.textBoxCreateTele);
            this.panelCreatePersonal.Controls.Add(this.textBoxCreateNamn);
            this.panelCreatePersonal.Controls.Add(this.textBoxP_Id);
            this.panelCreatePersonal.Location = new System.Drawing.Point(46, 98);
            this.panelCreatePersonal.Name = "panelCreatePersonal";
            this.panelCreatePersonal.Size = new System.Drawing.Size(661, 250);
            this.panelCreatePersonal.TabIndex = 18;
            this.panelCreatePersonal.Visible = false;
            // 
            // labelCreaMail
            // 
            this.labelCreaMail.AutoSize = true;
            this.labelCreaMail.Location = new System.Drawing.Point(27, 162);
            this.labelCreaMail.Name = "labelCreaMail";
            this.labelCreaMail.Size = new System.Drawing.Size(37, 17);
            this.labelCreaMail.TabIndex = 7;
            this.labelCreaMail.Text = "Mail:";
            // 
            // labelCrTele
            // 
            this.labelCrTele.AutoSize = true;
            this.labelCrTele.Location = new System.Drawing.Point(24, 115);
            this.labelCrTele.Name = "labelCrTele";
            this.labelCrTele.Size = new System.Drawing.Size(53, 17);
            this.labelCrTele.TabIndex = 6;
            this.labelCrTele.Text = "Phone:";
            // 
            // labelCreNam
            // 
            this.labelCreNam.AutoSize = true;
            this.labelCreNam.Location = new System.Drawing.Point(24, 74);
            this.labelCreNam.Name = "labelCreNam";
            this.labelCreNam.Size = new System.Drawing.Size(49, 17);
            this.labelCreNam.TabIndex = 5;
            this.labelCreNam.Text = "Name:";
            // 
            // labelCreId
            // 
            this.labelCreId.AutoSize = true;
            this.labelCreId.Location = new System.Drawing.Point(24, 32);
            this.labelCreId.Name = "labelCreId";
            this.labelCreId.Size = new System.Drawing.Size(23, 17);
            this.labelCreId.TabIndex = 4;
            this.labelCreId.Text = "Id:";
            // 
            // textBoxCreateMail
            // 
            this.textBoxCreateMail.Location = new System.Drawing.Point(117, 162);
            this.textBoxCreateMail.Name = "textBoxCreateMail";
            this.textBoxCreateMail.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreateMail.TabIndex = 3;
            // 
            // textBoxCreateTele
            // 
            this.textBoxCreateTele.Location = new System.Drawing.Point(117, 115);
            this.textBoxCreateTele.Name = "textBoxCreateTele";
            this.textBoxCreateTele.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreateTele.TabIndex = 2;
            // 
            // textBoxCreateNamn
            // 
            this.textBoxCreateNamn.Location = new System.Drawing.Point(117, 74);
            this.textBoxCreateNamn.Name = "textBoxCreateNamn";
            this.textBoxCreateNamn.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreateNamn.TabIndex = 1;
            // 
            // textBoxP_Id
            // 
            this.textBoxP_Id.Location = new System.Drawing.Point(117, 32);
            this.textBoxP_Id.Name = "textBoxP_Id";
            this.textBoxP_Id.Size = new System.Drawing.Size(100, 22);
            this.textBoxP_Id.TabIndex = 0;
            // 
            // panelCreateCompany
            // 
            this.panelCreateCompany.Controls.Add(this.labelCreatePostN);
            this.panelCreateCompany.Controls.Add(this.labelCreatePostA);
            this.panelCreateCompany.Controls.Add(this.labelCreatetfn);
            this.panelCreateCompany.Controls.Add(this.labelCrAdress);
            this.panelCreateCompany.Controls.Add(this.labelCreateForetag);
            this.panelCreateCompany.Controls.Add(this.textBoxCrFoPN);
            this.panelCreateCompany.Controls.Add(this.textBoxCrFoPA);
            this.panelCreateCompany.Controls.Add(this.textBoxCrFoTfn);
            this.panelCreateCompany.Controls.Add(this.textBoxCrFoAd);
            this.panelCreateCompany.Controls.Add(this.textBoxCrFo);
            this.panelCreateCompany.Location = new System.Drawing.Point(40, 98);
            this.panelCreateCompany.Name = "panelCreateCompany";
            this.panelCreateCompany.Size = new System.Drawing.Size(594, 262);
            this.panelCreateCompany.TabIndex = 8;
            this.panelCreateCompany.Visible = false;
            // 
            // labelCreatePostN
            // 
            this.labelCreatePostN.AutoSize = true;
            this.labelCreatePostN.Location = new System.Drawing.Point(39, 202);
            this.labelCreatePostN.Name = "labelCreatePostN";
            this.labelCreatePostN.Size = new System.Drawing.Size(59, 17);
            this.labelCreatePostN.TabIndex = 9;
            this.labelCreatePostN.Text = "Post.Nr:";
            // 
            // labelCreatePostA
            // 
            this.labelCreatePostA.AutoSize = true;
            this.labelCreatePostA.Location = new System.Drawing.Point(36, 161);
            this.labelCreatePostA.Name = "labelCreatePostA";
            this.labelCreatePostA.Size = new System.Drawing.Size(69, 17);
            this.labelCreatePostA.TabIndex = 8;
            this.labelCreatePostA.Text = "P.Adress:";
            // 
            // labelCreatetfn
            // 
            this.labelCreatetfn.AutoSize = true;
            this.labelCreatetfn.Location = new System.Drawing.Point(33, 115);
            this.labelCreatetfn.Name = "labelCreatetfn";
            this.labelCreatetfn.Size = new System.Drawing.Size(53, 17);
            this.labelCreatetfn.TabIndex = 7;
            this.labelCreatetfn.Text = "Phone:";
            // 
            // labelCrAdress
            // 
            this.labelCrAdress.AutoSize = true;
            this.labelCrAdress.Location = new System.Drawing.Point(33, 74);
            this.labelCrAdress.Name = "labelCrAdress";
            this.labelCrAdress.Size = new System.Drawing.Size(56, 17);
            this.labelCrAdress.TabIndex = 6;
            this.labelCrAdress.Text = "Adress:";
            // 
            // labelCreateForetag
            // 
            this.labelCreateForetag.AutoSize = true;
            this.labelCreateForetag.Location = new System.Drawing.Point(37, 32);
            this.labelCreateForetag.Name = "labelCreateForetag";
            this.labelCreateForetag.Size = new System.Drawing.Size(49, 17);
            this.labelCreateForetag.TabIndex = 5;
            this.labelCreateForetag.Text = "Name:";
            // 
            // textBoxCrFoPN
            // 
            this.textBoxCrFoPN.Location = new System.Drawing.Point(123, 202);
            this.textBoxCrFoPN.Name = "textBoxCrFoPN";
            this.textBoxCrFoPN.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFoPN.TabIndex = 4;
            // 
            // textBoxCrFoPA
            // 
            this.textBoxCrFoPA.Location = new System.Drawing.Point(123, 161);
            this.textBoxCrFoPA.Name = "textBoxCrFoPA";
            this.textBoxCrFoPA.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFoPA.TabIndex = 3;
            // 
            // textBoxCrFoTfn
            // 
            this.textBoxCrFoTfn.Location = new System.Drawing.Point(122, 115);
            this.textBoxCrFoTfn.Name = "textBoxCrFoTfn";
            this.textBoxCrFoTfn.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFoTfn.TabIndex = 2;
            // 
            // textBoxCrFoAd
            // 
            this.textBoxCrFoAd.Location = new System.Drawing.Point(123, 72);
            this.textBoxCrFoAd.Name = "textBoxCrFoAd";
            this.textBoxCrFoAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFoAd.TabIndex = 1;
            // 
            // textBoxCrFo
            // 
            this.textBoxCrFo.Location = new System.Drawing.Point(122, 31);
            this.textBoxCrFo.Name = "textBoxCrFo";
            this.textBoxCrFo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFo.TabIndex = 0;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCreateStudent);
            this.Controls.Add(this.panelCreateCompany);
            this.Controls.Add(this.panelCreatePersonal);
            this.Controls.Add(this.buttonCreateSave);
            this.Controls.Add(this.buttonCancelCreate);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.comboBoxCreate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateForm";
            this.Text = "Create new";
            this.panelCreateStudent.ResumeLayout(false);
            this.panelCreateStudent.PerformLayout();
            this.panelCreatePersonal.ResumeLayout(false);
            this.panelCreatePersonal.PerformLayout();
            this.panelCreateCompany.ResumeLayout(false);
            this.panelCreateCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCreate;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Button buttonCancelCreate;
        private System.Windows.Forms.Button buttonCreateSave;
        private System.Windows.Forms.Panel panelCreateStudent;
        private System.Windows.Forms.CheckBox checkBoxCreateExamen;
        private System.Windows.Forms.TextBox textBoxCteateMail;
        private System.Windows.Forms.Label labelCreateClass;
        private System.Windows.Forms.Label labelCreateMail;
        private System.Windows.Forms.Label labelCreateExamen;
        private System.Windows.Forms.Label labelCreatePnum;
        private System.Windows.Forms.TextBox textBoxCreatePnummer;
        private System.Windows.Forms.Label labelCreatePadress;
        private System.Windows.Forms.Label labelCreateAdress;
        private System.Windows.Forms.Label labelCreatePnummer;
        private System.Windows.Forms.Label labelCreateNamn;
        private System.Windows.Forms.Label labelCreateID;
        private System.Windows.Forms.TextBox textBoxCreatePadress;
        private System.Windows.Forms.TextBox textBoxcREATEADRESS;
        private System.Windows.Forms.TextBox textBoxcREATEpERSNR;
        private System.Windows.Forms.TextBox textBoxcREATEnAME;
        private System.Windows.Forms.TextBox textBoxcREATEid;
        private System.Windows.Forms.Panel panelCreatePersonal;
        private System.Windows.Forms.Label labelCreaMail;
        private System.Windows.Forms.Label labelCrTele;
        private System.Windows.Forms.Label labelCreNam;
        private System.Windows.Forms.Label labelCreId;
        private System.Windows.Forms.TextBox textBoxCreateMail;
        private System.Windows.Forms.TextBox textBoxCreateTele;
        private System.Windows.Forms.TextBox textBoxCreateNamn;
        private System.Windows.Forms.TextBox textBoxP_Id;
        private System.Windows.Forms.Panel panelCreateCompany;
        private System.Windows.Forms.Label labelCreatePostN;
        private System.Windows.Forms.Label labelCreatePostA;
        private System.Windows.Forms.Label labelCreatetfn;
        private System.Windows.Forms.Label labelCrAdress;
        private System.Windows.Forms.Label labelCreateForetag;
        private System.Windows.Forms.TextBox textBoxCrFoPN;
        private System.Windows.Forms.TextBox textBoxCrFoPA;
        private System.Windows.Forms.TextBox textBoxCrFoTfn;
        private System.Windows.Forms.TextBox textBoxCrFoAd;
        private System.Windows.Forms.TextBox textBoxCrFo;
        private System.Windows.Forms.ComboBox comboBoxCrSt;
    }
}