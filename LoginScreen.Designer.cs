namespace Project_Pizza
{
    partial class LoginScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLog_In = new System.Windows.Forms.TabPage();
            this.lbShowMessageErorr = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tpAddNewUser = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpLog_In.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLog_In);
            this.tabControl1.Controls.Add(this.tpAddNewUser);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tpLog_In
            // 
            this.tpLog_In.Controls.Add(this.lbShowMessageErorr);
            this.tpLog_In.Controls.Add(this.btnLogIn);
            this.tpLog_In.Controls.Add(this.label2);
            this.tpLog_In.Controls.Add(this.tbPassword);
            this.tpLog_In.Controls.Add(this.label1);
            this.tpLog_In.Controls.Add(this.tbUserName);
            this.tpLog_In.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpLog_In.Location = new System.Drawing.Point(4, 28);
            this.tpLog_In.Name = "tpLog_In";
            this.tpLog_In.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog_In.Size = new System.Drawing.Size(744, 429);
            this.tpLog_In.TabIndex = 0;
            this.tpLog_In.Text = "تسجيل الدخول";
            this.tpLog_In.UseVisualStyleBackColor = true;
            // 
            // lbShowMessageErorr
            // 
            this.lbShowMessageErorr.AutoSize = true;
            this.lbShowMessageErorr.Enabled = false;
            this.lbShowMessageErorr.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowMessageErorr.ForeColor = System.Drawing.Color.Red;
            this.lbShowMessageErorr.Location = new System.Drawing.Point(240, 197);
            this.lbShowMessageErorr.Name = "lbShowMessageErorr";
            this.lbShowMessageErorr.Size = new System.Drawing.Size(159, 15);
            this.lbShowMessageErorr.TabIndex = 5;
            this.lbShowMessageErorr.Tag = "0";
            this.lbShowMessageErorr.Text = "                                      ";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(244, 247);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(131, 41);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "دخول";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ادخل كلمة المرور";
            // 
            // tbPassword
            // 
            this.tbPassword.AccessibleName = "";
            this.tbPassword.Location = new System.Drawing.Point(201, 157);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(236, 37);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Tag = "123456";
            this.tbPassword.Text = "123456";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ادخل اسم المستخدم";
            // 
            // tbUserName
            // 
            this.tbUserName.AccessibleName = "";
            this.tbUserName.Location = new System.Drawing.Point(201, 71);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(236, 37);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Tag = "Admin";
            this.tbUserName.Text = "Admin";
            // 
            // tpAddNewUser
            // 
            this.tpAddNewUser.Location = new System.Drawing.Point(4, 28);
            this.tpAddNewUser.Name = "tpAddNewUser";
            this.tpAddNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddNewUser.Size = new System.Drawing.Size(744, 429);
            this.tpAddNewUser.TabIndex = 1;
            this.tpAddNewUser.Text = "اضف مستخدم";
            this.tpAddNewUser.UseVisualStyleBackColor = true;
            // 
            // LoginScreen
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.tabControl1.ResumeLayout(false);
            this.tpLog_In.ResumeLayout(false);
            this.tpLog_In.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLog_In;
        private System.Windows.Forms.TabPage tpAddNewUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogIn;
        public System.Windows.Forms.TextBox tbUserName;
        public System.Windows.Forms.TextBox tbPassword;
        public System.Windows.Forms.Label lbShowMessageErorr;
    }
}