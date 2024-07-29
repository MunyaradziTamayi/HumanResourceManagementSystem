
namespace LOGIIN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkpass = new System.Windows.Forms.CheckBox();
            this.CPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkpass);
            this.panel1.Controls.Add(this.CPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Role);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Fname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(250, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 483);
            this.panel1.TabIndex = 0;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(302, 217);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(161, 20);
            this.Email.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(118, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sign In";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkpass
            // 
            this.checkpass.AutoSize = true;
            this.checkpass.Location = new System.Drawing.Point(331, 407);
            this.checkpass.Name = "checkpass";
            this.checkpass.Size = new System.Drawing.Size(94, 17);
            this.checkpass.TabIndex = 11;
            this.checkpass.Text = "Remember me";
            this.checkpass.UseVisualStyleBackColor = true;
            this.checkpass.CheckedChanged += new System.EventHandler(this.checkpass_CheckedChanged);
            // 
            // CPassword
            // 
            this.CPassword.Location = new System.Drawing.Point(302, 363);
            this.CPassword.Name = "CPassword";
            this.CPassword.Size = new System.Drawing.Size(161, 20);
            this.CPassword.TabIndex = 10;
            this.CPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Role";
            // 
            // Role
            // 
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.Role.Location = new System.Drawing.Point(302, 263);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(161, 21);
            this.Role.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(302, 315);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(161, 20);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(302, 169);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(161, 20);
            this.Lname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "LastName";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(302, 119);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(161, 20);
            this.Fname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(302, 86);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(161, 20);
            this.ID.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 557);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkpass;
        private System.Windows.Forms.TextBox CPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label9;
    }
}

