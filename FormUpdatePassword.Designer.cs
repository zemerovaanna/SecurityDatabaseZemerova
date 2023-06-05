namespace WorkDbZemerova
{
    partial class FormUpdatePassword
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
            this.TextBoxPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.TextBoxNewPassword = new System.Windows.Forms.TextBox();
            this.TextBoxOldPassword = new System.Windows.Forms.TextBox();
            this.TextPasswordConfirmation = new System.Windows.Forms.Label();
            this.TextNewPassword = new System.Windows.Forms.Label();
            this.TextOldPassword = new System.Windows.Forms.Label();
            this.TextInformationForm = new System.Windows.Forms.Label();
            this.ButtonChangePassword = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPasswordConfirmation
            // 
            this.TextBoxPasswordConfirmation.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPasswordConfirmation.Location = new System.Drawing.Point(210, 120);
            this.TextBoxPasswordConfirmation.Name = "TextBoxPasswordConfirmation";
            this.TextBoxPasswordConfirmation.PasswordChar = '*';
            this.TextBoxPasswordConfirmation.Size = new System.Drawing.Size(317, 30);
            this.TextBoxPasswordConfirmation.TabIndex = 15;
            // 
            // TextBoxNewPassword
            // 
            this.TextBoxNewPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNewPassword.Location = new System.Drawing.Point(210, 84);
            this.TextBoxNewPassword.Name = "TextBoxNewPassword";
            this.TextBoxNewPassword.PasswordChar = '*';
            this.TextBoxNewPassword.Size = new System.Drawing.Size(317, 30);
            this.TextBoxNewPassword.TabIndex = 14;
            // 
            // TextBoxOldPassword
            // 
            this.TextBoxOldPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOldPassword.Location = new System.Drawing.Point(210, 48);
            this.TextBoxOldPassword.Name = "TextBoxOldPassword";
            this.TextBoxOldPassword.PasswordChar = '*';
            this.TextBoxOldPassword.Size = new System.Drawing.Size(317, 30);
            this.TextBoxOldPassword.TabIndex = 13;
            // 
            // TextPasswordConfirmation
            // 
            this.TextPasswordConfirmation.AutoSize = true;
            this.TextPasswordConfirmation.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPasswordConfirmation.Location = new System.Drawing.Point(12, 127);
            this.TextPasswordConfirmation.Name = "TextPasswordConfirmation";
            this.TextPasswordConfirmation.Size = new System.Drawing.Size(196, 23);
            this.TextPasswordConfirmation.TabIndex = 12;
            this.TextPasswordConfirmation.Text = "Подтвердите пароль:";
            // 
            // TextNewPassword
            // 
            this.TextNewPassword.AutoSize = true;
            this.TextNewPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextNewPassword.Location = new System.Drawing.Point(12, 91);
            this.TextNewPassword.Name = "TextNewPassword";
            this.TextNewPassword.Size = new System.Drawing.Size(138, 23);
            this.TextNewPassword.TabIndex = 11;
            this.TextNewPassword.Text = "Новый пароль:";
            // 
            // TextOldPassword
            // 
            this.TextOldPassword.AutoSize = true;
            this.TextOldPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOldPassword.Location = new System.Drawing.Point(12, 55);
            this.TextOldPassword.Name = "TextOldPassword";
            this.TextOldPassword.Size = new System.Drawing.Size(147, 23);
            this.TextOldPassword.TabIndex = 10;
            this.TextOldPassword.Text = "Старый пароль:";
            // 
            // TextInformationForm
            // 
            this.TextInformationForm.AutoSize = true;
            this.TextInformationForm.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextInformationForm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TextInformationForm.Location = new System.Drawing.Point(12, 9);
            this.TextInformationForm.MinimumSize = new System.Drawing.Size(400, 0);
            this.TextInformationForm.Name = "TextInformationForm";
            this.TextInformationForm.Size = new System.Drawing.Size(733, 23);
            this.TextInformationForm.TabIndex = 9;
            this.TextInformationForm.Text = "Измените пароль Вашей учетной записи, т. к. Вы не меняли пароль более 14 дней.";
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonChangePassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChangePassword.Location = new System.Drawing.Point(210, 156);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Size = new System.Drawing.Size(317, 34);
            this.ButtonChangePassword.TabIndex = 8;
            this.ButtonChangePassword.Text = "Изменить пароль";
            this.ButtonChangePassword.UseVisualStyleBackColor = false;
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(16, 197);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(743, 209);
            this.DataGridView.TabIndex = 27;
            // 
            // FormUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(774, 418);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.TextBoxPasswordConfirmation);
            this.Controls.Add(this.TextBoxNewPassword);
            this.Controls.Add(this.TextBoxOldPassword);
            this.Controls.Add(this.TextPasswordConfirmation);
            this.Controls.Add(this.TextNewPassword);
            this.Controls.Add(this.TextOldPassword);
            this.Controls.Add(this.TextInformationForm);
            this.Controls.Add(this.ButtonChangePassword);
            this.Name = "FormUpdatePassword";
            this.Text = "Обновление пароля";
            this.Load += new System.EventHandler(this.FormUpdatePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPasswordConfirmation;
        private System.Windows.Forms.TextBox TextBoxNewPassword;
        private System.Windows.Forms.TextBox TextBoxOldPassword;
        private System.Windows.Forms.Label TextPasswordConfirmation;
        private System.Windows.Forms.Label TextNewPassword;
        private System.Windows.Forms.Label TextOldPassword;
        private System.Windows.Forms.Label TextInformationForm;
        private System.Windows.Forms.Button ButtonChangePassword;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}