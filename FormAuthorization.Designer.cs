namespace WorkDbZemerova
{
    partial class FormAuthorization
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
            this.ButtonSighIn = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.usertblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageSignIn = new System.Windows.Forms.TabPage();
            this.TabPageRegistration = new System.Windows.Forms.TabPage();
            this.TextVerification = new System.Windows.Forms.Label();
            this.TextBoxVeficitaion = new System.Windows.Forms.TextBox();
            this.ButtonSighUp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPageSignIn.SuspendLayout();
            this.TabPageRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSighIn
            // 
            this.ButtonSighIn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonSighIn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSighIn.Location = new System.Drawing.Point(143, 111);
            this.ButtonSighIn.Name = "ButtonSighIn";
            this.ButtonSighIn.Size = new System.Drawing.Size(434, 36);
            this.ButtonSighIn.TabIndex = 31;
            this.ButtonSighIn.Text = "Войти";
            this.ButtonSighIn.UseVisualStyleBackColor = false;
            this.ButtonSighIn.Click += new System.EventHandler(this.ButtonSighIn_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.Location = new System.Drawing.Point(228, 75);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(349, 30);
            this.TextBoxPassword.TabIndex = 30;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.Location = new System.Drawing.Point(228, 39);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(349, 30);
            this.TextBoxLogin.TabIndex = 29;
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPassword.Location = new System.Drawing.Point(139, 82);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(74, 23);
            this.TextPassword.TabIndex = 28;
            this.TextPassword.Text = "Пароль";
            // 
            // TextLogin
            // 
            this.TextLogin.AutoSize = true;
            this.TextLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLogin.Location = new System.Drawing.Point(139, 46);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(64, 23);
            this.TextLogin.TabIndex = 27;
            this.TextLogin.Text = "Логин";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(7, 204);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(743, 209);
            this.DataGridView.TabIndex = 33;
            // 
            // usertblBindingSource1
            // 
            this.usertblBindingSource1.DataMember = "User_tbl";
            // 
            // usertblBindingSource
            // 
            this.usertblBindingSource.DataMember = "User_tbl";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageSignIn);
            this.TabControl.Controls.Add(this.TabPageRegistration);
            this.TabControl.Location = new System.Drawing.Point(7, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(743, 186);
            this.TabControl.TabIndex = 34;
            // 
            // TabPageSignIn
            // 
            this.TabPageSignIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TabPageSignIn.Controls.Add(this.TextBoxLogin);
            this.TabPageSignIn.Controls.Add(this.TextLogin);
            this.TabPageSignIn.Controls.Add(this.ButtonSighIn);
            this.TabPageSignIn.Controls.Add(this.TextPassword);
            this.TabPageSignIn.Controls.Add(this.TextBoxPassword);
            this.TabPageSignIn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageSignIn.Location = new System.Drawing.Point(4, 22);
            this.TabPageSignIn.Name = "TabPageSignIn";
            this.TabPageSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSignIn.Size = new System.Drawing.Size(735, 160);
            this.TabPageSignIn.TabIndex = 0;
            this.TabPageSignIn.Text = "Вход";
            // 
            // TabPageRegistration
            // 
            this.TabPageRegistration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TabPageRegistration.Controls.Add(this.TextVerification);
            this.TabPageRegistration.Controls.Add(this.TextBoxVeficitaion);
            this.TabPageRegistration.Controls.Add(this.ButtonSighUp);
            this.TabPageRegistration.Controls.Add(this.textBox1);
            this.TabPageRegistration.Controls.Add(this.textBox2);
            this.TabPageRegistration.Controls.Add(this.label1);
            this.TabPageRegistration.Controls.Add(this.label2);
            this.TabPageRegistration.Location = new System.Drawing.Point(4, 22);
            this.TabPageRegistration.Name = "TabPageRegistration";
            this.TabPageRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageRegistration.Size = new System.Drawing.Size(735, 160);
            this.TabPageRegistration.TabIndex = 1;
            this.TabPageRegistration.Text = "Регистрация";
            // 
            // TextVerification
            // 
            this.TextVerification.AutoSize = true;
            this.TextVerification.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.TextVerification.Location = new System.Drawing.Point(148, 95);
            this.TextVerification.Name = "TextVerification";
            this.TextVerification.Size = new System.Drawing.Size(91, 13);
            this.TextVerification.TabIndex = 31;
            this.TextVerification.Text = "Подтверждение:";
            // 
            // TextBoxVeficitaion
            // 
            this.TextBoxVeficitaion.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxVeficitaion.Location = new System.Drawing.Point(248, 78);
            this.TextBoxVeficitaion.Name = "TextBoxVeficitaion";
            this.TextBoxVeficitaion.PasswordChar = '*';
            this.TextBoxVeficitaion.Size = new System.Drawing.Size(349, 30);
            this.TextBoxVeficitaion.TabIndex = 32;
            // 
            // ButtonSighUp
            // 
            this.ButtonSighUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSighUp.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSighUp.Location = new System.Drawing.Point(151, 114);
            this.ButtonSighUp.Name = "ButtonSighUp";
            this.ButtonSighUp.Size = new System.Drawing.Size(446, 36);
            this.ButtonSighUp.TabIndex = 30;
            this.ButtonSighUp.Text = "Зарегистрироваться";
            this.ButtonSighUp.UseVisualStyleBackColor = false;
            this.ButtonSighUp.Click += new System.EventHandler(this.ButtonSighUp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(248, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(349, 30);
            this.textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(248, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 30);
            this.textBox2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(147, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(147, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Логин:";
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(759, 424);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.DataGridView);
            this.Name = "FormAuthorization";
            this.Text = "FormSignIn";
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPageSignIn.ResumeLayout(false);
            this.TabPageSignIn.PerformLayout();
            this.TabPageRegistration.ResumeLayout(false);
            this.TabPageRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonSighIn;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.Label TextLogin;
        private System.Windows.Forms.BindingSource usertblBindingSource1;
        private System.Windows.Forms.BindingSource usertblBindingSource;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPageSignIn;
        private System.Windows.Forms.TabPage TabPageRegistration;
        private System.Windows.Forms.Label TextVerification;
        private System.Windows.Forms.TextBox TextBoxVeficitaion;
        private System.Windows.Forms.Button ButtonSighUp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}