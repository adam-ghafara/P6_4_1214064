namespace P6_4_1214064
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btUppercase = new System.Windows.Forms.Button();
            this.btLowercase = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTwitter = new System.Windows.Forms.TextBox();
            this.warnProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btSubmit = new System.Windows.Forms.Button();
            this.labelTwitter = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbInstagram = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbOther4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbOther3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbOther2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFacebook = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCountrycode = new System.Windows.Forms.ComboBox();
            this.checkProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.warnProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER NEW ACCOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nickname";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(446, 105);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(227, 233);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // btUppercase
            // 
            this.btUppercase.Location = new System.Drawing.Point(15, 129);
            this.btUppercase.Name = "btUppercase";
            this.btUppercase.Size = new System.Drawing.Size(75, 23);
            this.btUppercase.TabIndex = 3;
            this.btUppercase.Text = "&Upper";
            this.btUppercase.UseVisualStyleBackColor = true;
            this.btUppercase.Click += new System.EventHandler(this.btUppercase_Click);
            // 
            // btLowercase
            // 
            this.btLowercase.Location = new System.Drawing.Point(96, 129);
            this.btLowercase.Name = "btLowercase";
            this.btLowercase.Size = new System.Drawing.Size(75, 23);
            this.btLowercase.TabIndex = 4;
            this.btLowercase.Text = "&Lower";
            this.btLowercase.UseVisualStyleBackColor = true;
            this.btLowercase.Click += new System.EventHandler(this.btLowercase_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(15, 415);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(15, 105);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 6;
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(15, 176);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(156, 20);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description (Optional)";
            // 
            // tbTwitter
            // 
            this.tbTwitter.Location = new System.Drawing.Point(49, 35);
            this.tbTwitter.Name = "tbTwitter";
            this.tbTwitter.Size = new System.Drawing.Size(137, 20);
            this.tbTwitter.TabIndex = 11;
            this.tbTwitter.Leave += new System.EventHandler(this.tbTwitter_Leave);
            // 
            // warnProvider
            // 
            this.warnProvider.ContainerControl = this;
            this.warnProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("warnProvider.Icon")));
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(598, 390);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 12;
            this.btSubmit.Text = "&Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // labelTwitter
            // 
            this.labelTwitter.AutoSize = true;
            this.labelTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwitter.Location = new System.Drawing.Point(22, 16);
            this.labelTwitter.Name = "labelTwitter";
            this.labelTwitter.Size = new System.Drawing.Size(46, 16);
            this.labelTwitter.TabIndex = 13;
            this.labelTwitter.Text = "Twitter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "@";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "@";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Instagram";
            // 
            // tbInstagram
            // 
            this.tbInstagram.Location = new System.Drawing.Point(49, 77);
            this.tbInstagram.Name = "tbInstagram";
            this.tbInstagram.Size = new System.Drawing.Size(137, 20);
            this.tbInstagram.TabIndex = 15;
            this.tbInstagram.TextChanged += new System.EventHandler(this.tbInstagram_TextChanged);
            this.tbInstagram.Leave += new System.EventHandler(this.tbInstagram_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbOther4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbOther3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbOther2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbOther);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbFacebook);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTwitter);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelTwitter);
            this.groupBox1.Controls.Add(this.tbInstagram);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 183);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Social Media (Optional)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(213, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Other 4";
            // 
            // tbOther4
            // 
            this.tbOther4.Location = new System.Drawing.Point(213, 158);
            this.tbOther4.Name = "tbOther4";
            this.tbOther4.Size = new System.Drawing.Size(161, 20);
            this.tbOther4.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(213, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Other 3";
            // 
            // tbOther3
            // 
            this.tbOther3.Location = new System.Drawing.Point(213, 116);
            this.tbOther3.Name = "tbOther3";
            this.tbOther3.Size = new System.Drawing.Size(161, 20);
            this.tbOther3.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(213, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Other 2";
            // 
            // tbOther2
            // 
            this.tbOther2.Location = new System.Drawing.Point(213, 77);
            this.tbOther2.Name = "tbOther2";
            this.tbOther2.Size = new System.Drawing.Size(161, 20);
            this.tbOther2.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(213, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Other 1";
            // 
            // tbOther
            // 
            this.tbOther.Location = new System.Drawing.Point(213, 35);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(161, 20);
            this.tbOther.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Site";
            // 
            // tbSite
            // 
            this.tbSite.Location = new System.Drawing.Point(25, 158);
            this.tbSite.Name = "tbSite";
            this.tbSite.Size = new System.Drawing.Size(164, 20);
            this.tbSite.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Facebook";
            // 
            // tbFacebook
            // 
            this.tbFacebook.Location = new System.Drawing.Point(25, 116);
            this.tbFacebook.Name = "tbFacebook";
            this.tbFacebook.Size = new System.Drawing.Size(161, 20);
            this.tbFacebook.TabIndex = 18;
            this.tbFacebook.Leave += new System.EventHandler(this.tbFacebook_Leave);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(271, 176);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(124, 20);
            this.tbPhone.TabIndex = 20;
            this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Phone Number";
            // 
            // cbCountrycode
            // 
            this.cbCountrycode.FormattingEnabled = true;
            this.cbCountrycode.Items.AddRange(new object[] {
            "+1 (US)",
            "+62 (ID)",
            "+49 (GR)",
            "+39 (ITA)",
            "+34 (SPN)",
            "+60 (MLY)",
            "+91 (IND)",
            "+852 (HK)",
            "+81 (JP)",
            "+971 (UAE)",
            "+82 (KR)",
            "+48 (PL)",
            "+7 (RUS)"});
            this.cbCountrycode.Location = new System.Drawing.Point(204, 176);
            this.cbCountrycode.Name = "cbCountrycode";
            this.cbCountrycode.Size = new System.Drawing.Size(61, 21);
            this.cbCountrycode.TabIndex = 21;
            this.cbCountrycode.Text = "Country";
            // 
            // checkProvider
            // 
            this.checkProvider.ContainerControl = this;
            this.checkProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("checkProvider.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.cbCountrycode);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btLowercase);
            this.Controls.Add(this.btUppercase);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Clubsport";
            ((System.ComponentModel.ISupportInitialize)(this.warnProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btUppercase;
        private System.Windows.Forms.Button btLowercase;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTwitter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btSubmit;
        internal System.Windows.Forms.ErrorProvider warnProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTwitter;
        private System.Windows.Forms.TextBox tbInstagram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFacebook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSite;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCountrycode;
        private System.Windows.Forms.ErrorProvider checkProvider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbOther4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbOther3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbOther2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbOther;
    }
}

