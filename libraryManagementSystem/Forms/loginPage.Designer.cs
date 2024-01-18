namespace libraryManagementSystem
{
    partial class loginPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.lblMain = new System.Windows.Forms.Label();
            this.txtStuUser = new System.Windows.Forms.TextBox();
            this.txtStuPass = new System.Windows.Forms.TextBox();
            this.grpStu = new System.Windows.Forms.GroupBox();
            this.btnStuLog = new System.Windows.Forms.Button();
            this.lblStuPass = new System.Windows.Forms.Label();
            this.lblStuUser = new System.Windows.Forms.Label();
            this.grpAdm = new System.Windows.Forms.GroupBox();
            this.btnAdmLog = new System.Windows.Forms.Button();
            this.lblAdmPass = new System.Windows.Forms.Label();
            this.lblAdmUser = new System.Windows.Forms.Label();
            this.txtAdmUser = new System.Windows.Forms.TextBox();
            this.txtAdmPass = new System.Windows.Forms.TextBox();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpStu.SuspendLayout();
            this.grpAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMain.Location = new System.Drawing.Point(28, 51);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(352, 36);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Library Management System";
            // 
            // txtStuUser
            // 
            this.txtStuUser.Location = new System.Drawing.Point(96, 28);
            this.txtStuUser.Name = "txtStuUser";
            this.txtStuUser.Size = new System.Drawing.Size(144, 29);
            this.txtStuUser.TabIndex = 2;
            // 
            // txtStuPass
            // 
            this.txtStuPass.Location = new System.Drawing.Point(96, 63);
            this.txtStuPass.Name = "txtStuPass";
            this.txtStuPass.Size = new System.Drawing.Size(144, 29);
            this.txtStuPass.TabIndex = 3;
            this.txtStuPass.UseSystemPasswordChar = true;
            // 
            // grpStu
            // 
            this.grpStu.Controls.Add(this.btnStuLog);
            this.grpStu.Controls.Add(this.lblStuPass);
            this.grpStu.Controls.Add(this.lblStuUser);
            this.grpStu.Controls.Add(this.txtStuUser);
            this.grpStu.Controls.Add(this.txtStuPass);
            this.grpStu.Location = new System.Drawing.Point(12, 142);
            this.grpStu.Name = "grpStu";
            this.grpStu.Size = new System.Drawing.Size(246, 151);
            this.grpStu.TabIndex = 4;
            this.grpStu.TabStop = false;
            this.grpStu.Text = "Student";
            // 
            // btnStuLog
            // 
            this.btnStuLog.Location = new System.Drawing.Point(69, 98);
            this.btnStuLog.Name = "btnStuLog";
            this.btnStuLog.Size = new System.Drawing.Size(117, 35);
            this.btnStuLog.TabIndex = 8;
            this.btnStuLog.Text = "Log In";
            this.btnStuLog.UseVisualStyleBackColor = true;
            this.btnStuLog.Click += new System.EventHandler(this.btnStuLog_Click);
            // 
            // lblStuPass
            // 
            this.lblStuPass.AutoSize = true;
            this.lblStuPass.Location = new System.Drawing.Point(12, 66);
            this.lblStuPass.Name = "lblStuPass";
            this.lblStuPass.Size = new System.Drawing.Size(78, 22);
            this.lblStuPass.TabIndex = 5;
            this.lblStuPass.Text = "Password:";
            // 
            // lblStuUser
            // 
            this.lblStuUser.AutoSize = true;
            this.lblStuUser.Location = new System.Drawing.Point(6, 31);
            this.lblStuUser.Name = "lblStuUser";
            this.lblStuUser.Size = new System.Drawing.Size(84, 22);
            this.lblStuUser.TabIndex = 4;
            this.lblStuUser.Text = "Username:";
            // 
            // grpAdm
            // 
            this.grpAdm.Controls.Add(this.btnAdmLog);
            this.grpAdm.Controls.Add(this.lblAdmPass);
            this.grpAdm.Controls.Add(this.lblAdmUser);
            this.grpAdm.Controls.Add(this.txtAdmUser);
            this.grpAdm.Controls.Add(this.txtAdmPass);
            this.grpAdm.Location = new System.Drawing.Point(268, 142);
            this.grpAdm.Name = "grpAdm";
            this.grpAdm.Size = new System.Drawing.Size(246, 151);
            this.grpAdm.TabIndex = 5;
            this.grpAdm.TabStop = false;
            this.grpAdm.Text = "Admin";
            // 
            // btnAdmLog
            // 
            this.btnAdmLog.Location = new System.Drawing.Point(68, 98);
            this.btnAdmLog.Name = "btnAdmLog";
            this.btnAdmLog.Size = new System.Drawing.Size(117, 35);
            this.btnAdmLog.TabIndex = 9;
            this.btnAdmLog.Text = "Log In";
            this.btnAdmLog.UseVisualStyleBackColor = true;
            this.btnAdmLog.Click += new System.EventHandler(this.btnAdmLog_Click);
            // 
            // lblAdmPass
            // 
            this.lblAdmPass.AutoSize = true;
            this.lblAdmPass.Location = new System.Drawing.Point(12, 66);
            this.lblAdmPass.Name = "lblAdmPass";
            this.lblAdmPass.Size = new System.Drawing.Size(78, 22);
            this.lblAdmPass.TabIndex = 7;
            this.lblAdmPass.Text = "Password:";
            // 
            // lblAdmUser
            // 
            this.lblAdmUser.AutoSize = true;
            this.lblAdmUser.Location = new System.Drawing.Point(6, 31);
            this.lblAdmUser.Name = "lblAdmUser";
            this.lblAdmUser.Size = new System.Drawing.Size(84, 22);
            this.lblAdmUser.TabIndex = 6;
            this.lblAdmUser.Text = "Username:";
            // 
            // txtAdmUser
            // 
            this.txtAdmUser.Location = new System.Drawing.Point(96, 28);
            this.txtAdmUser.Name = "txtAdmUser";
            this.txtAdmUser.Size = new System.Drawing.Size(144, 29);
            this.txtAdmUser.TabIndex = 2;
            // 
            // txtAdmPass
            // 
            this.txtAdmPass.Location = new System.Drawing.Point(96, 63);
            this.txtAdmPass.Name = "txtAdmPass";
            this.txtAdmPass.Size = new System.Drawing.Size(144, 29);
            this.txtAdmPass.TabIndex = 3;
            this.txtAdmPass.UseSystemPasswordChar = true;
            // 
            // picBook
            // 
            this.picBook.Image = global::libraryManagementSystem.Properties.Resources.giphy;
            this.picBook.Location = new System.Drawing.Point(386, 12);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(128, 115);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBook.TabIndex = 1;
            this.picBook.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(205, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // firstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(172)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(526, 341);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpAdm);
            this.Controls.Add(this.grpStu);
            this.Controls.Add(this.picBook);
            this.Controls.Add(this.lblMain);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "firstPage";
            this.Text = "Library Management System";
            this.grpStu.ResumeLayout(false);
            this.grpStu.PerformLayout();
            this.grpAdm.ResumeLayout(false);
            this.grpAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.TextBox txtStuUser;
        private System.Windows.Forms.TextBox txtStuPass;
        private System.Windows.Forms.GroupBox grpStu;
        private System.Windows.Forms.Label lblStuPass;
        private System.Windows.Forms.Label lblStuUser;
        private System.Windows.Forms.GroupBox grpAdm;
        private System.Windows.Forms.Label lblAdmPass;
        private System.Windows.Forms.Label lblAdmUser;
        private System.Windows.Forms.TextBox txtAdmUser;
        private System.Windows.Forms.TextBox txtAdmPass;
        private System.Windows.Forms.Button btnStuLog;
        private System.Windows.Forms.Button btnAdmLog;
        private System.Windows.Forms.Button btnExit;
    }
}

