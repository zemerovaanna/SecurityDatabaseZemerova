namespace WorkDbZemerova
{
    partial class FormRoot
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
            this.ButtonExite = new System.Windows.Forms.Button();
            this.TextLogin = new System.Windows.Forms.Label();
            this.TextCount = new System.Windows.Forms.Label();
            this.TextRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonExite
            // 
            this.ButtonExite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonExite.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExite.Location = new System.Drawing.Point(91, 107);
            this.ButtonExite.Name = "ButtonExite";
            this.ButtonExite.Size = new System.Drawing.Size(144, 34);
            this.ButtonExite.TabIndex = 0;
            this.ButtonExite.Text = "Выход";
            this.ButtonExite.UseVisualStyleBackColor = false;
            this.ButtonExite.Click += new System.EventHandler(this.ButtonExite_Click);
            // 
            // TextLogin
            // 
            this.TextLogin.AutoSize = true;
            this.TextLogin.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLogin.Location = new System.Drawing.Point(12, 9);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(64, 25);
            this.TextLogin.TabIndex = 1;
            this.TextLogin.Text = "label1";
            // 
            // TextCount
            // 
            this.TextCount.AutoSize = true;
            this.TextCount.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCount.Location = new System.Drawing.Point(12, 34);
            this.TextCount.Name = "TextCount";
            this.TextCount.Size = new System.Drawing.Size(64, 25);
            this.TextCount.TabIndex = 1;
            this.TextCount.Text = "label1";
            // 
            // TextRole
            // 
            this.TextRole.AutoSize = true;
            this.TextRole.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRole.Location = new System.Drawing.Point(12, 59);
            this.TextRole.Name = "TextRole";
            this.TextRole.Size = new System.Drawing.Size(64, 25);
            this.TextRole.TabIndex = 1;
            this.TextRole.Text = "label1";
            // 
            // FormRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(322, 153);
            this.Controls.Add(this.TextRole);
            this.Controls.Add(this.TextCount);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.ButtonExite);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormRoot";
            this.Text = "Профиль пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExite;
        private System.Windows.Forms.Label TextLogin;
        private System.Windows.Forms.Label TextCount;
        private System.Windows.Forms.Label TextRole;
    }
}