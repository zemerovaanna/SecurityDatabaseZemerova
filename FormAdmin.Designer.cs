namespace WorkDbZemerova
{
    partial class FormAdmin
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.Label();
            this.TextRole = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextCount = new System.Windows.Forms.Label();
            this.TextId = new System.Windows.Forms.Label();
            this.TextBoxSerchId = new System.Windows.Forms.TextBox();
            this.ButtonSearchId = new System.Windows.Forms.Button();
            this.TextActive = new System.Windows.Forms.Label();
            this.ButtonExite = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxCount = new System.Windows.Forms.TextBox();
            this.securityDbDataSet = new WorkDbZemerova.SecurityDbDataSet();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new WorkDbZemerova.SecurityDbDataSetTableAdapters.UserTableTableAdapter();
            this.DomainUpDownRole = new System.Windows.Forms.DomainUpDown();
            this.DomainUpDownActive = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 295);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(776, 232);
            this.DataGridView.TabIndex = 23;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.Location = new System.Drawing.Point(109, 63);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(349, 30);
            this.TextBoxLogin.TabIndex = 33;
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPassword.Location = new System.Drawing.Point(8, 106);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(99, 23);
            this.TextPassword.TabIndex = 32;
            this.TextPassword.Text = "Password:";
            // 
            // TextLogin
            // 
            this.TextLogin.AutoSize = true;
            this.TextLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLogin.Location = new System.Drawing.Point(8, 70);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(61, 23);
            this.TextLogin.TabIndex = 31;
            this.TextLogin.Text = "Login:";
            // 
            // TextRole
            // 
            this.TextRole.AutoSize = true;
            this.TextRole.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.TextRole.Location = new System.Drawing.Point(8, 179);
            this.TextRole.Name = "TextRole";
            this.TextRole.Size = new System.Drawing.Size(52, 23);
            this.TextRole.TabIndex = 35;
            this.TextRole.Text = "Role:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSave.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.ButtonSave.Location = new System.Drawing.Point(109, 256);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(349, 32);
            this.ButtonSave.TabIndex = 37;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextCount
            // 
            this.TextCount.AutoSize = true;
            this.TextCount.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.TextCount.Location = new System.Drawing.Point(8, 142);
            this.TextCount.Name = "TextCount";
            this.TextCount.Size = new System.Drawing.Size(64, 23);
            this.TextCount.TabIndex = 35;
            this.TextCount.Text = "Count:";
            // 
            // TextId
            // 
            this.TextId.AutoSize = true;
            this.TextId.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.TextId.Location = new System.Drawing.Point(8, 30);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(34, 23);
            this.TextId.TabIndex = 38;
            this.TextId.Text = " Id:";
            // 
            // TextBoxSerchId
            // 
            this.TextBoxSerchId.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSerchId.Location = new System.Drawing.Point(109, 23);
            this.TextBoxSerchId.Name = "TextBoxSerchId";
            this.TextBoxSerchId.Size = new System.Drawing.Size(349, 30);
            this.TextBoxSerchId.TabIndex = 39;
            // 
            // ButtonSearchId
            // 
            this.ButtonSearchId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSearchId.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.ButtonSearchId.Location = new System.Drawing.Point(464, 19);
            this.ButtonSearchId.Name = "ButtonSearchId";
            this.ButtonSearchId.Size = new System.Drawing.Size(75, 37);
            this.ButtonSearchId.TabIndex = 40;
            this.ButtonSearchId.Text = "Найти";
            this.ButtonSearchId.UseVisualStyleBackColor = false;
            this.ButtonSearchId.Click += new System.EventHandler(this.ButtonSearchId_Click);
            // 
            // TextActive
            // 
            this.TextActive.AutoSize = true;
            this.TextActive.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.TextActive.Location = new System.Drawing.Point(8, 216);
            this.TextActive.Name = "TextActive";
            this.TextActive.Size = new System.Drawing.Size(66, 23);
            this.TextActive.TabIndex = 35;
            this.TextActive.Text = "Active:";
            // 
            // ButtonExite
            // 
            this.ButtonExite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonExite.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExite.Location = new System.Drawing.Point(692, 12);
            this.ButtonExite.Name = "ButtonExite";
            this.ButtonExite.Size = new System.Drawing.Size(96, 32);
            this.ButtonExite.TabIndex = 41;
            this.ButtonExite.Text = "Выход";
            this.ButtonExite.UseVisualStyleBackColor = false;
            this.ButtonExite.Click += new System.EventHandler(this.ButtonExite_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.Location = new System.Drawing.Point(109, 99);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(349, 30);
            this.TextBoxPassword.TabIndex = 39;
            // 
            // TextBoxCount
            // 
            this.TextBoxCount.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.TextBoxCount.Location = new System.Drawing.Point(109, 135);
            this.TextBoxCount.Name = "TextBoxCount";
            this.TextBoxCount.Size = new System.Drawing.Size(349, 30);
            this.TextBoxCount.TabIndex = 42;
            // 
            // securityDbDataSet
            // 
            this.securityDbDataSet.DataSetName = "SecurityDbDataSet";
            this.securityDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.securityDbDataSet;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // DomainUpDownRole
            // 
            this.DomainUpDownRole.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DomainUpDownRole.Items.Add("Admin");
            this.DomainUpDownRole.Items.Add("User");
            this.DomainUpDownRole.Location = new System.Drawing.Point(109, 171);
            this.DomainUpDownRole.Name = "DomainUpDownRole";
            this.DomainUpDownRole.ReadOnly = true;
            this.DomainUpDownRole.Size = new System.Drawing.Size(349, 30);
            this.DomainUpDownRole.TabIndex = 43;
            this.DomainUpDownRole.Text = "DomainUpDownRole";
            // 
            // DomainUpDownActive
            // 
            this.DomainUpDownActive.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.DomainUpDownActive.Items.Add("True");
            this.DomainUpDownActive.Items.Add("False");
            this.DomainUpDownActive.Location = new System.Drawing.Point(109, 214);
            this.DomainUpDownActive.Name = "DomainUpDownActive";
            this.DomainUpDownActive.ReadOnly = true;
            this.DomainUpDownActive.Size = new System.Drawing.Size(349, 30);
            this.DomainUpDownActive.TabIndex = 43;
            this.DomainUpDownActive.Text = "DomainUpDownActive";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.DomainUpDownActive);
            this.Controls.Add(this.DomainUpDownRole);
            this.Controls.Add(this.TextBoxCount);
            this.Controls.Add(this.ButtonExite);
            this.Controls.Add(this.ButtonSearchId);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxSerchId);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextCount);
            this.Controls.Add(this.TextActive);
            this.Controls.Add(this.TextRole);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.DataGridView);
            this.Name = "FormAdmin";
            this.Text = "Администрация системы";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.Label TextLogin;
        private System.Windows.Forms.Label TextRole;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label TextCount;
        private System.Windows.Forms.Label TextId;
        private System.Windows.Forms.TextBox TextBoxSerchId;
        private System.Windows.Forms.Button ButtonSearchId;
        private System.Windows.Forms.Label TextActive;
        private System.Windows.Forms.Button ButtonExite;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxCount;
        private SecurityDbDataSet securityDbDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private SecurityDbDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.DomainUpDown DomainUpDownRole;
        private System.Windows.Forms.DomainUpDown DomainUpDownActive;
    }
}