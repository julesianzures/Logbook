
namespace LogBook
{
    partial class RegisterForm
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
            this.logbookLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginInInsteadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logbookLabel
            // 
            this.logbookLabel.AutoSize = true;
            this.logbookLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbookLabel.Location = new System.Drawing.Point(216, 83);
            this.logbookLabel.Name = "logbookLabel";
            this.logbookLabel.Size = new System.Drawing.Size(191, 43);
            this.logbookLabel.TabIndex = 1;
            this.logbookLabel.Text = "REGISTER";
            this.logbookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(168, 198);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 21);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.DimGray;
            this.namePanel.Location = new System.Drawing.Point(172, 222);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(280, 1);
            this.namePanel.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(224, 194);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 28);
            this.nameTextBox.TabIndex = 6;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Black;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Franklin Gothic Book", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(172, 256);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(280, 40);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(594, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 35);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginInInsteadButton
            // 
            this.loginInInsteadButton.BackColor = System.Drawing.Color.Transparent;
            this.loginInInsteadButton.FlatAppearance.BorderSize = 0;
            this.loginInInsteadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginInInsteadButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginInInsteadButton.ForeColor = System.Drawing.Color.DimGray;
            this.loginInInsteadButton.Location = new System.Drawing.Point(254, 302);
            this.loginInInsteadButton.Name = "loginInInsteadButton";
            this.loginInInsteadButton.Size = new System.Drawing.Size(114, 29);
            this.loginInInsteadButton.TabIndex = 10;
            this.loginInInsteadButton.Text = "Log in instead";
            this.loginInInsteadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginInInsteadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.loginInInsteadButton.UseVisualStyleBackColor = false;
            this.loginInInsteadButton.Click += new System.EventHandler(this.loginInInsteadButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.loginInInsteadButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logbookLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTER FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logbookLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button registerButton;
        public System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginInInsteadButton;
    }
}