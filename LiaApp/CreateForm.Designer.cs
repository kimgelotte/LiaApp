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
            this.panelCreateClass = new System.Windows.Forms.Panel();
            this.groupBoxcrclLia = new System.Windows.Forms.GroupBox();
            this.labelcrcll2d2 = new System.Windows.Forms.Label();
            this.labelcrcll1d2 = new System.Windows.Forms.Label();
            this.labelcrcll2d1 = new System.Windows.Forms.Label();
            this.labelcrcll1d1 = new System.Windows.Forms.Label();
            this.labelcrcld = new System.Windows.Forms.Label();
            this.labelcrcld1 = new System.Windows.Forms.Label();
            this.labelcrcllia1 = new System.Windows.Forms.Label();
            this.comboBoxcrcllia1 = new System.Windows.Forms.ComboBox();
            this.labelcrcllia2 = new System.Windows.Forms.Label();
            this.comboBoxcrcllia2 = new System.Windows.Forms.ComboBox();
            this.labelcrclco = new System.Windows.Forms.Label();
            this.labelcrclong = new System.Windows.Forms.Label();
            this.labelcrclstn = new System.Windows.Forms.Label();
            this.labelcrantst = new System.Windows.Forms.Label();
            this.labelcrclna = new System.Windows.Forms.Label();
            this.checkBoxcrclong = new System.Windows.Forms.CheckBox();
            this.textBoxcrclst = new System.Windows.Forms.TextBox();
            this.textBoxcrcla = new System.Windows.Forms.TextBox();
            this.panelCreateStudent.SuspendLayout();
            this.panelCreatePersonal.SuspendLayout();
            this.panelCreateCompany.SuspendLayout();
            this.panelCreateClass.SuspendLayout();
            this.groupBoxcrclLia.SuspendLayout();
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
            this.buttonCancelCreate.Size = new System.Drawing.Size(84, 40);
            this.buttonCancelCreate.TabIndex = 3;
            this.buttonCancelCreate.Text = "Cancel";
            this.buttonCancelCreate.UseVisualStyleBackColor = true;
            this.buttonCancelCreate.Click += new System.EventHandler(this.buttonCancelCreate_Click);
            // 
            // buttonCreateSave
            // 
            this.buttonCreateSave.Location = new System.Drawing.Point(515, 399);
            this.buttonCreateSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateSave.Name = "buttonCreateSave";
            this.buttonCreateSave.Size = new System.Drawing.Size(93, 40);
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
            this.panelCreateStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCreateStudent.Name = "panelCreateStudent";
            this.panelCreateStudent.Size = new System.Drawing.Size(661, 254);
            this.panelCreateStudent.TabIndex = 5;
            this.panelCreateStudent.Visible = false;
            this.panelCreateStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCreateStudent_Paint);
            // 
            // comboBoxCrSt
            // 
            this.comboBoxCrSt.FormattingEnabled = true;
            this.comboBoxCrSt.Location = new System.Drawing.Point(491, 166);
            this.comboBoxCrSt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCrSt.Name = "comboBoxCrSt";
            this.comboBoxCrSt.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCrSt.TabIndex = 18;
            // 
            // checkBoxCreateExamen
            // 
            this.checkBoxCreateExamen.AutoSize = true;
            this.checkBoxCreateExamen.Location = new System.Drawing.Point(531, 60);
            this.checkBoxCreateExamen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCreateExamen.Name = "checkBoxCreateExamen";
            this.checkBoxCreateExamen.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCreateExamen.TabIndex = 17;
            this.checkBoxCreateExamen.UseVisualStyleBackColor = true;
            // 
            // textBoxCteateMail
            // 
            this.textBoxCteateMail.Location = new System.Drawing.Point(491, 111);
            this.textBoxCteateMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.labelCreateMail.Location = new System.Drawing.Point(391, 114);
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
            this.textBoxCreatePnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.textBoxCreatePadress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreatePadress.Name = "textBoxCreatePadress";
            this.textBoxCreatePadress.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreatePadress.TabIndex = 4;
            // 
            // textBoxcREATEADRESS
            // 
            this.textBoxcREATEADRESS.Location = new System.Drawing.Point(117, 162);
            this.textBoxcREATEADRESS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxcREATEADRESS.Name = "textBoxcREATEADRESS";
            this.textBoxcREATEADRESS.Size = new System.Drawing.Size(100, 22);
            this.textBoxcREATEADRESS.TabIndex = 3;
            // 
            // textBoxcREATEpERSNR
            // 
            this.textBoxcREATEpERSNR.Location = new System.Drawing.Point(117, 111);
            this.textBoxcREATEpERSNR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxcREATEpERSNR.Name = "textBoxcREATEpERSNR";
            this.textBoxcREATEpERSNR.Size = new System.Drawing.Size(100, 22);
            this.textBoxcREATEpERSNR.TabIndex = 2;
            // 
            // textBoxcREATEnAME
            // 
            this.textBoxcREATEnAME.Location = new System.Drawing.Point(117, 60);
            this.textBoxcREATEnAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxcREATEnAME.Name = "textBoxcREATEnAME";
            this.textBoxcREATEnAME.Size = new System.Drawing.Size(100, 22);
            this.textBoxcREATEnAME.TabIndex = 1;
            // 
            // textBoxcREATEid
            // 
            this.textBoxcREATEid.Location = new System.Drawing.Point(117, 17);
            this.textBoxcREATEid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panelCreatePersonal.Location = new System.Drawing.Point(45, 98);
            this.panelCreatePersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.labelCrTele.Location = new System.Drawing.Point(24, 114);
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
            this.textBoxCreateMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateMail.Name = "textBoxCreateMail";
            this.textBoxCreateMail.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreateMail.TabIndex = 3;
            // 
            // textBoxCreateTele
            // 
            this.textBoxCreateTele.Location = new System.Drawing.Point(117, 114);
            this.textBoxCreateTele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateTele.Name = "textBoxCreateTele";
            this.textBoxCreateTele.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreateTele.TabIndex = 2;
            // 
            // textBoxCreateNamn
            // 
            this.textBoxCreateNamn.Location = new System.Drawing.Point(117, 74);
            this.textBoxCreateNamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateNamn.Name = "textBoxCreateNamn";
            this.textBoxCreateNamn.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreateNamn.TabIndex = 1;
            // 
            // textBoxP_Id
            // 
            this.textBoxP_Id.Location = new System.Drawing.Point(117, 32);
            this.textBoxP_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panelCreateCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCreateCompany.Name = "panelCreateCompany";
            this.panelCreateCompany.Size = new System.Drawing.Size(595, 262);
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
            this.labelCreatetfn.Location = new System.Drawing.Point(33, 114);
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
            this.textBoxCrFoPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCrFoPN.Name = "textBoxCrFoPN";
            this.textBoxCrFoPN.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFoPN.TabIndex = 4;
            // 
            // textBoxCrFoPA
            // 
            this.textBoxCrFoPA.Location = new System.Drawing.Point(123, 161);
            this.textBoxCrFoPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCrFoPA.Name = "textBoxCrFoPA";
            this.textBoxCrFoPA.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFoPA.TabIndex = 3;
            // 
            // textBoxCrFoTfn
            // 
            this.textBoxCrFoTfn.Location = new System.Drawing.Point(123, 114);
            this.textBoxCrFoTfn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCrFoTfn.Name = "textBoxCrFoTfn";
            this.textBoxCrFoTfn.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFoTfn.TabIndex = 2;
            // 
            // textBoxCrFoAd
            // 
            this.textBoxCrFoAd.Location = new System.Drawing.Point(123, 71);
            this.textBoxCrFoAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCrFoAd.Name = "textBoxCrFoAd";
            this.textBoxCrFoAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFoAd.TabIndex = 1;
            // 
            // textBoxCrFo
            // 
            this.textBoxCrFo.Location = new System.Drawing.Point(123, 31);
            this.textBoxCrFo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCrFo.Name = "textBoxCrFo";
            this.textBoxCrFo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrFo.TabIndex = 0;
            // 
            // panelCreateClass
            // 
            this.panelCreateClass.Controls.Add(this.groupBoxcrclLia);
            this.panelCreateClass.Controls.Add(this.labelcrclco);
            this.panelCreateClass.Controls.Add(this.labelcrclong);
            this.panelCreateClass.Controls.Add(this.labelcrclstn);
            this.panelCreateClass.Controls.Add(this.labelcrantst);
            this.panelCreateClass.Controls.Add(this.labelcrclna);
            this.panelCreateClass.Controls.Add(this.checkBoxcrclong);
            this.panelCreateClass.Controls.Add(this.textBoxcrclst);
            this.panelCreateClass.Controls.Add(this.textBoxcrcla);
            this.panelCreateClass.Location = new System.Drawing.Point(49, 91);
            this.panelCreateClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCreateClass.Name = "panelCreateClass";
            this.panelCreateClass.Size = new System.Drawing.Size(664, 282);
            this.panelCreateClass.TabIndex = 19;
            this.panelCreateClass.Visible = false;
            // 
            // groupBoxcrclLia
            // 
            this.groupBoxcrclLia.Controls.Add(this.labelcrcll2d2);
            this.groupBoxcrclLia.Controls.Add(this.labelcrcll1d2);
            this.groupBoxcrclLia.Controls.Add(this.labelcrcll2d1);
            this.groupBoxcrclLia.Controls.Add(this.labelcrcll1d1);
            this.groupBoxcrclLia.Controls.Add(this.labelcrcld);
            this.groupBoxcrclLia.Controls.Add(this.labelcrcld1);
            this.groupBoxcrclLia.Controls.Add(this.labelcrcllia1);
            this.groupBoxcrclLia.Controls.Add(this.comboBoxcrcllia1);
            this.groupBoxcrclLia.Controls.Add(this.labelcrcllia2);
            this.groupBoxcrclLia.Controls.Add(this.comboBoxcrcllia2);
            this.groupBoxcrclLia.Location = new System.Drawing.Point(17, 116);
            this.groupBoxcrclLia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxcrclLia.Name = "groupBoxcrclLia";
            this.groupBoxcrclLia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxcrclLia.Size = new System.Drawing.Size(479, 106);
            this.groupBoxcrclLia.TabIndex = 15;
            this.groupBoxcrclLia.TabStop = false;
            this.groupBoxcrclLia.Text = "Lia-periods";
            // 
            // labelcrcll2d2
            // 
            this.labelcrcll2d2.AutoSize = true;
            this.labelcrcll2d2.Location = new System.Drawing.Point(399, 65);
            this.labelcrcll2d2.Name = "labelcrcll2d2";
            this.labelcrcll2d2.Size = new System.Drawing.Size(0, 17);
            this.labelcrcll2d2.TabIndex = 17;
            // 
            // labelcrcll1d2
            // 
            this.labelcrcll1d2.AutoSize = true;
            this.labelcrcll1d2.Location = new System.Drawing.Point(399, 28);
            this.labelcrcll1d2.Name = "labelcrcll1d2";
            this.labelcrcll1d2.Size = new System.Drawing.Size(0, 17);
            this.labelcrcll1d2.TabIndex = 16;
            // 
            // labelcrcll2d1
            // 
            this.labelcrcll2d1.AutoSize = true;
            this.labelcrcll2d1.Location = new System.Drawing.Point(316, 65);
            this.labelcrcll2d1.Name = "labelcrcll2d1";
            this.labelcrcll2d1.Size = new System.Drawing.Size(0, 17);
            this.labelcrcll2d1.TabIndex = 15;
            // 
            // labelcrcll1d1
            // 
            this.labelcrcll1d1.AutoSize = true;
            this.labelcrcll1d1.Location = new System.Drawing.Point(316, 28);
            this.labelcrcll1d1.Name = "labelcrcll1d1";
            this.labelcrcll1d1.Size = new System.Drawing.Size(0, 17);
            this.labelcrcll1d1.TabIndex = 14;
            // 
            // labelcrcld
            // 
            this.labelcrcld.AutoSize = true;
            this.labelcrcld.Location = new System.Drawing.Point(243, 65);
            this.labelcrcld.Name = "labelcrcld";
            this.labelcrcld.Size = new System.Drawing.Size(42, 17);
            this.labelcrcld.TabIndex = 13;
            this.labelcrcld.Text = "Date:";
            // 
            // labelcrcld1
            // 
            this.labelcrcld1.AutoSize = true;
            this.labelcrcld1.Location = new System.Drawing.Point(243, 28);
            this.labelcrcld1.Name = "labelcrcld1";
            this.labelcrcld1.Size = new System.Drawing.Size(42, 17);
            this.labelcrcld1.TabIndex = 12;
            this.labelcrcld1.Text = "Date:";
            // 
            // labelcrcllia1
            // 
            this.labelcrcllia1.AutoSize = true;
            this.labelcrcllia1.Location = new System.Drawing.Point(23, 31);
            this.labelcrcllia1.Name = "labelcrcllia1";
            this.labelcrcllia1.Size = new System.Drawing.Size(43, 17);
            this.labelcrcllia1.TabIndex = 8;
            this.labelcrcllia1.Text = "Lia 1:";
            // 
            // comboBoxcrcllia1
            // 
            this.comboBoxcrcllia1.FormattingEnabled = true;
            this.comboBoxcrcllia1.Location = new System.Drawing.Point(97, 28);
            this.comboBoxcrcllia1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxcrcllia1.Name = "comboBoxcrcllia1";
            this.comboBoxcrcllia1.Size = new System.Drawing.Size(121, 24);
            this.comboBoxcrcllia1.TabIndex = 9;
            // 
            // labelcrcllia2
            // 
            this.labelcrcllia2.AutoSize = true;
            this.labelcrcllia2.Location = new System.Drawing.Point(23, 63);
            this.labelcrcllia2.Name = "labelcrcllia2";
            this.labelcrcllia2.Size = new System.Drawing.Size(43, 17);
            this.labelcrcllia2.TabIndex = 11;
            this.labelcrcllia2.Text = "Lia 2:";
            // 
            // comboBoxcrcllia2
            // 
            this.comboBoxcrcllia2.FormattingEnabled = true;
            this.comboBoxcrcllia2.Location = new System.Drawing.Point(97, 63);
            this.comboBoxcrcllia2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxcrcllia2.Name = "comboBoxcrcllia2";
            this.comboBoxcrcllia2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxcrcllia2.TabIndex = 10;
            // 
            // labelcrclco
            // 
            this.labelcrclco.AutoSize = true;
            this.labelcrclco.Location = new System.Drawing.Point(115, 78);
            this.labelcrclco.Name = "labelcrclco";
            this.labelcrclco.Size = new System.Drawing.Size(16, 17);
            this.labelcrclco.TabIndex = 14;
            this.labelcrclco.Text = "0";
            // 
            // labelcrclong
            // 
            this.labelcrclong.AutoSize = true;
            this.labelcrclong.Location = new System.Drawing.Point(268, 18);
            this.labelcrclong.Name = "labelcrclong";
            this.labelcrclong.Size = new System.Drawing.Size(81, 17);
            this.labelcrclong.TabIndex = 13;
            this.labelcrclong.Text = "Ongoing st:";
            // 
            // labelcrclstn
            // 
            this.labelcrclstn.AutoSize = true;
            this.labelcrclstn.Location = new System.Drawing.Point(13, 238);
            this.labelcrclstn.Name = "labelcrclstn";
            this.labelcrclstn.Size = new System.Drawing.Size(75, 17);
            this.labelcrclstn.TabIndex = 12;
            this.labelcrclstn.Text = "2nd name:";
            // 
            // labelcrantst
            // 
            this.labelcrantst.AutoSize = true;
            this.labelcrantst.Location = new System.Drawing.Point(5, 78);
            this.labelcrantst.Name = "labelcrantst";
            this.labelcrantst.Size = new System.Drawing.Size(90, 17);
            this.labelcrantst.TabIndex = 7;
            this.labelcrantst.Text = "No. of Studs:";
            // 
            // labelcrclna
            // 
            this.labelcrclna.AutoSize = true;
            this.labelcrclna.Location = new System.Drawing.Point(40, 20);
            this.labelcrclna.Name = "labelcrclna";
            this.labelcrclna.Size = new System.Drawing.Size(49, 17);
            this.labelcrclna.TabIndex = 6;
            this.labelcrclna.Text = "Name:";
            // 
            // checkBoxcrclong
            // 
            this.checkBoxcrclong.AutoSize = true;
            this.checkBoxcrclong.Location = new System.Drawing.Point(365, 18);
            this.checkBoxcrclong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxcrclong.Name = "checkBoxcrclong";
            this.checkBoxcrclong.Size = new System.Drawing.Size(18, 17);
            this.checkBoxcrclong.TabIndex = 5;
            this.checkBoxcrclong.UseVisualStyleBackColor = true;
            // 
            // textBoxcrclst
            // 
            this.textBoxcrclst.Location = new System.Drawing.Point(115, 235);
            this.textBoxcrclst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxcrclst.Name = "textBoxcrclst";
            this.textBoxcrclst.Size = new System.Drawing.Size(100, 22);
            this.textBoxcrclst.TabIndex = 4;
            // 
            // textBoxcrcla
            // 
            this.textBoxcrcla.Location = new System.Drawing.Point(111, 18);
            this.textBoxcrcla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxcrcla.Name = "textBoxcrcla";
            this.textBoxcrcla.Size = new System.Drawing.Size(100, 22);
            this.textBoxcrcla.TabIndex = 0;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCreateClass);
            this.Controls.Add(this.panelCreateStudent);
            this.Controls.Add(this.panelCreateCompany);
            this.Controls.Add(this.panelCreatePersonal);
            this.Controls.Add(this.buttonCreateSave);
            this.Controls.Add(this.buttonCancelCreate);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.comboBoxCreate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateForm";
            this.Text = "LiaAPP - Create";
            this.panelCreateStudent.ResumeLayout(false);
            this.panelCreateStudent.PerformLayout();
            this.panelCreatePersonal.ResumeLayout(false);
            this.panelCreatePersonal.PerformLayout();
            this.panelCreateCompany.ResumeLayout(false);
            this.panelCreateCompany.PerformLayout();
            this.panelCreateClass.ResumeLayout(false);
            this.panelCreateClass.PerformLayout();
            this.groupBoxcrclLia.ResumeLayout(false);
            this.groupBoxcrclLia.PerformLayout();
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
        private System.Windows.Forms.Panel panelCreateClass;
        private System.Windows.Forms.Label labelcrclong;
        private System.Windows.Forms.Label labelcrclstn;
        private System.Windows.Forms.Label labelcrcllia2;
        private System.Windows.Forms.ComboBox comboBoxcrcllia2;
        private System.Windows.Forms.ComboBox comboBoxcrcllia1;
        private System.Windows.Forms.Label labelcrcllia1;
        private System.Windows.Forms.Label labelcrantst;
        private System.Windows.Forms.Label labelcrclna;
        private System.Windows.Forms.CheckBox checkBoxcrclong;
        private System.Windows.Forms.TextBox textBoxcrclst;
        private System.Windows.Forms.TextBox textBoxcrcla;
        private System.Windows.Forms.Label labelcrclco;
        private System.Windows.Forms.GroupBox groupBoxcrclLia;
        private System.Windows.Forms.Label labelcrcll2d2;
        private System.Windows.Forms.Label labelcrcll1d2;
        private System.Windows.Forms.Label labelcrcll2d1;
        private System.Windows.Forms.Label labelcrcll1d1;
        private System.Windows.Forms.Label labelcrcld;
        private System.Windows.Forms.Label labelcrcld1;
    }
}