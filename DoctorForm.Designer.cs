
namespace HCPApp
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.DoctorList = new System.Windows.Forms.DataGridView();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboDay = new System.Windows.Forms.ComboBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.ComboSpec = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.ComboTime = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.hCPAppDBDataSet2 = new HCPApp.HCPAppDBDataSet2();
            this.doctorTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTblTableAdapter = new HCPApp.HCPAppDBDataSet2TableAdapters.DoctorTblTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCPAppDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.DoctorList);
            this.panel4.Controls.Add(this.txtFee);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.ComboDay);
            this.panel4.Controls.Add(this.Deletebtn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Updatebtn);
            this.panel4.Controls.Add(this.ComboSpec);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtQualification);
            this.panel4.Controls.Add(this.ComboTime);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtContact);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtFirstName);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtLastName);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(197, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(863, 584);
            this.panel4.TabIndex = 46;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // DoctorList
            // 
            this.DoctorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DoctorList.Location = new System.Drawing.Point(3, 359);
            this.DoctorList.Name = "DoctorList";
            this.DoctorList.Size = new System.Drawing.Size(860, 225);
            this.DoctorList.TabIndex = 31;
            this.DoctorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorList_CellContentClick_1);
            // 
            // txtFee
            // 
            this.txtFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(635, 193);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(141, 23);
            this.txtFee.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Doctor Fee";
            // 
            // ComboDay
            // 
            this.ComboDay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDay.FormattingEnabled = true;
            this.ComboDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wedneday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.ComboDay.Location = new System.Drawing.Point(166, 233);
            this.ComboDay.Name = "ComboDay";
            this.ComboDay.Size = new System.Drawing.Size(176, 25);
            this.ComboDay.TabIndex = 28;
            this.ComboDay.Text = "Select Day";
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(738, 296);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(100, 30);
            this.Deletebtn.TabIndex = 23;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Updatebtn.FlatAppearance.BorderSize = 0;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Updatebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(604, 296);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(100, 30);
            this.Updatebtn.TabIndex = 22;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // ComboSpec
            // 
            this.ComboSpec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSpec.FormattingEnabled = true;
            this.ComboSpec.Items.AddRange(new object[] {
            "Abdomen",
            "Accupuncture Physician",
            "Acting Consultant Endocrinologist",
            "Allergy And ImmunologyAnomaly Scan",
            "Aryuvedic Physician",
            "Bacteriologist",
            "Brain Scalp",
            "Breast Care Clinic",
            "Cancer Surgeon",
            "Cardiaologist",
            "Chest Physician",
            "Dental Surgeon",
            "Dentist",
            "Dermatologist",
            "Dietician",
            "Eye Surgeon",
            "Gastroenterologist",
            "Gastrologist",
            "Hypotherapist",
            "Oncologist",
            "Pysician",
            "Radiologist",
            "Sport Physician"});
            this.ComboSpec.Location = new System.Drawing.Point(166, 173);
            this.ComboSpec.Name = "ComboSpec";
            this.ComboSpec.Size = new System.Drawing.Size(176, 25);
            this.ComboSpec.TabIndex = 27;
            this.ComboSpec.Text = "Select Time";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(474, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtQualification
            // 
            this.txtQualification.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQualification.Location = new System.Drawing.Point(635, 83);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(141, 23);
            this.txtQualification.TabIndex = 20;
            // 
            // ComboTime
            // 
            this.ComboTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTime.FormattingEnabled = true;
            this.ComboTime.Items.AddRange(new object[] {
            "8.00 - 9.00",
            "9.00-10.00",
            "10.00-11.00",
            "11.00-12.00",
            "12.00-13.00",
            "13.00-14.00",
            "14.00-15.00",
            "15.00-16.00",
            "16.00-17.00",
            "17.00-18.00",
            "18.00-19.00",
            "19.00-20.00",
            "21.00-22.00"});
            this.ComboTime.Location = new System.Drawing.Point(164, 296);
            this.ComboTime.Name = "ComboTime";
            this.ComboTime.Size = new System.Drawing.Size(178, 25);
            this.ComboTime.TabIndex = 26;
            this.ComboTime.Text = "Select Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(483, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Qualification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Specification";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(572, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Profile";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(635, 142);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(141, 23);
            this.txtContact.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Available Day";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(166, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 23);
            this.txtFirstName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(164, 123);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(178, 23);
            this.txtLastName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Available Time";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2Button7);
            this.panel1.Controls.Add(this.guna2Button6);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.imgSlide);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 609);
            this.panel1.TabIndex = 62;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.Location = new System.Drawing.Point(20, 112);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(186, 43);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Dashboard";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 22;
            this.guna2Button7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button7.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button7.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button7.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button7.Location = new System.Drawing.Point(20, 430);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(149, 43);
            this.guna2Button7.TabIndex = 6;
            this.guna2Button7.Text = "Reports";
            this.guna2Button7.UseTransparentBackground = true;
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 5;
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.Location = new System.Drawing.Point(20, 531);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(45, 38);
            this.guna2Button6.TabIndex = 5;
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 22;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button5.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button5.Location = new System.Drawing.Point(20, 368);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(149, 43);
            this.guna2Button5.TabIndex = 2;
            this.guna2Button5.Text = "Rooms";
            this.guna2Button5.UseTransparentBackground = true;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 22;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button4.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button4.Location = new System.Drawing.Point(20, 305);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(186, 43);
            this.guna2Button4.TabIndex = 2;
            this.guna2Button4.Text = "Appointments";
            this.guna2Button4.UseTransparentBackground = true;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 22;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button3.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button3.Location = new System.Drawing.Point(20, 242);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(149, 43);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Patients";
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 22;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button2.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button2.Location = new System.Drawing.Point(20, 182);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(186, 43);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Doctors";
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(61, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "HelthCare+";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.InitialImage")));
            this.pictureBox11.Location = new System.Drawing.Point(20, 15);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(33, 29);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(147, 151);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(87, 101);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 0;
            this.imgSlide.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 22;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 22;
            this.guna2Elipse2.TargetControl = this.panel4;
            // 
            // hCPAppDBDataSet2
            // 
            this.hCPAppDBDataSet2.DataSetName = "HCPAppDBDataSet2";
            this.hCPAppDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTblBindingSource
            // 
            this.doctorTblBindingSource.DataMember = "DoctorTbl";
            this.doctorTblBindingSource.DataSource = this.hCPAppDBDataSet2;
            // 
            // doctorTblTableAdapter
            // 
            this.doctorTblTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCPAppDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboDay;
        private System.Windows.Forms.ComboBox ComboSpec;
        private System.Windows.Forms.ComboBox ComboTime;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.DataGridView DoctorList;
        private HCPAppDBDataSet2 hCPAppDBDataSet2;
        private System.Windows.Forms.BindingSource doctorTblBindingSource;
        private HCPAppDBDataSet2TableAdapters.DoctorTblTableAdapter doctorTblTableAdapter;
    }
}