namespace Login_Register_Products
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RegSurName = new System.Windows.Forms.TextBox();
            this.RegUserName = new System.Windows.Forms.TextBox();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.RegPass = new System.Windows.Forms.TextBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // RegName
            // 
            this.RegName.Location = new System.Drawing.Point(177, 129);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(160, 20);
            this.RegName.TabIndex = 0;
            this.RegName.Validating += new System.ComponentModel.CancelEventHandler(this.RegName_Validating);
            // 
            // RegSurName
            // 
            this.RegSurName.Location = new System.Drawing.Point(177, 174);
            this.RegSurName.Name = "RegSurName";
            this.RegSurName.Size = new System.Drawing.Size(160, 20);
            this.RegSurName.TabIndex = 1;
            this.RegSurName.Validating += new System.ComponentModel.CancelEventHandler(this.RegSurName_Validating);
            // 
            // RegUserName
            // 
            this.RegUserName.Location = new System.Drawing.Point(177, 217);
            this.RegUserName.Name = "RegUserName";
            this.RegUserName.Size = new System.Drawing.Size(160, 20);
            this.RegUserName.TabIndex = 2;
            this.RegUserName.Validating += new System.ComponentModel.CancelEventHandler(this.RegUserName_Validating);
            // 
            // RegEmail
            // 
            this.RegEmail.Location = new System.Drawing.Point(177, 266);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(160, 20);
            this.RegEmail.TabIndex = 3;
            this.RegEmail.Validating += new System.ComponentModel.CancelEventHandler(this.RegEmail_Validating);
            // 
            // RegPass
            // 
            this.RegPass.Location = new System.Drawing.Point(177, 308);
            this.RegPass.Name = "RegPass";
            this.RegPass.PasswordChar = '*';
            this.RegPass.Size = new System.Drawing.Size(160, 20);
            this.RegPass.TabIndex = 4;
            this.RegPass.Validating += new System.ComponentModel.CancelEventHandler(this.RegPass_Validating);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SignUpBtn.CausesValidation = false;
            this.SignUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.Location = new System.Drawing.Point(110, 367);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(176, 36);
            this.SignUpBtn.TabIndex = 5;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(379, 469);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.RegPass);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.RegUserName);
            this.Controls.Add(this.RegSurName);
            this.Controls.Add(this.RegName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.TextBox RegSurName;
        private System.Windows.Forms.TextBox RegUserName;
        private System.Windows.Forms.TextBox RegEmail;
        private System.Windows.Forms.TextBox RegPass;
        private System.Windows.Forms.Button SignUpBtn;
    }
}