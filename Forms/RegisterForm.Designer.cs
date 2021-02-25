
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
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.loginInInsteadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logbookLabel
            // 
            this.logbookLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logbookLabel.AutoSize = true;
            this.logbookLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbookLabel.Location = new System.Drawing.Point(201, 82);
            this.logbookLabel.Name = "logbookLabel";
            this.logbookLabel.Size = new System.Drawing.Size(191, 43);
            this.logbookLabel.TabIndex = 1;
            this.logbookLabel.Text = "REGISTER";
            this.logbookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(153, 197);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 21);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // namePanel
            // 
            this.namePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.namePanel.BackColor = System.Drawing.Color.DimGray;
            this.namePanel.Location = new System.Drawing.Point(157, 221);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(280, 1);
            this.namePanel.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(204, 193);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 28);
            this.nameTextBox.TabIndex = 6;
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registerButton.BackColor = System.Drawing.Color.Black;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Franklin Gothic Book", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(157, 255);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(280, 40);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginInInsteadButton
            // 
            this.loginInInsteadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginInInsteadButton.BackColor = System.Drawing.Color.Transparent;
            this.loginInInsteadButton.FlatAppearance.BorderSize = 0;
            this.loginInInsteadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginInInsteadButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginInInsteadButton.ForeColor = System.Drawing.Color.DimGray;
            this.loginInInsteadButton.Location = new System.Drawing.Point(239, 301);
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
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 437);
            this.Controls.Add(this.loginInInsteadButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logbookLabel);
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
        private System.Windows.Forms.Button loginInInsteadButton;
    }
}