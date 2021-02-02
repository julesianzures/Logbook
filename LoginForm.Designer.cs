
namespace LogBook
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.logbookLabel = new System.Windows.Forms.Label();
            this.idIcon = new System.Windows.Forms.PictureBox();
            this.idPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dontHaveAnAccountText = new System.Windows.Forms.TextBox();
            this.registerHereButton = new System.Windows.Forms.Button();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.idIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // logbookLabel
            // 
            this.logbookLabel.AutoSize = true;
            this.logbookLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbookLabel.Location = new System.Drawing.Point(216, 83);
            this.logbookLabel.Name = "logbookLabel";
            this.logbookLabel.Size = new System.Drawing.Size(190, 43);
            this.logbookLabel.TabIndex = 0;
            this.logbookLabel.Text = "LOGBOOK";
            this.logbookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idIcon
            // 
            this.idIcon.Image = ((System.Drawing.Image)(resources.GetObject("idIcon.Image")));
            this.idIcon.Location = new System.Drawing.Point(172, 186);
            this.idIcon.Name = "idIcon";
            this.idIcon.Size = new System.Drawing.Size(30, 30);
            this.idIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.idIcon.TabIndex = 1;
            this.idIcon.TabStop = false;
            // 
            // idPanel
            // 
            this.idPanel.BackColor = System.Drawing.Color.DimGray;
            this.idPanel.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPanel.Location = new System.Drawing.Point(172, 222);
            this.idPanel.Name = "idPanel";
            this.idPanel.Size = new System.Drawing.Size(280, 1);
            this.idPanel.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Franklin Gothic Book", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(172, 256);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(280, 40);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
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
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dontHaveAnAccountText
            // 
            this.dontHaveAnAccountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dontHaveAnAccountText.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dontHaveAnAccountText.Location = new System.Drawing.Point(189, 308);
            this.dontHaveAnAccountText.Name = "dontHaveAnAccountText";
            this.dontHaveAnAccountText.Size = new System.Drawing.Size(150, 19);
            this.dontHaveAnAccountText.TabIndex = 6;
            this.dontHaveAnAccountText.Text = "Don\'t have an ID yet?";
            // 
            // registerHereButton
            // 
            this.registerHereButton.BackColor = System.Drawing.Color.Transparent;
            this.registerHereButton.FlatAppearance.BorderSize = 0;
            this.registerHereButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerHereButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHereButton.ForeColor = System.Drawing.Color.DimGray;
            this.registerHereButton.Location = new System.Drawing.Point(331, 304);
            this.registerHereButton.Name = "registerHereButton";
            this.registerHereButton.Size = new System.Drawing.Size(111, 29);
            this.registerHereButton.TabIndex = 7;
            this.registerHereButton.Text = "Register here.";
            this.registerHereButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerHereButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.registerHereButton.UseVisualStyleBackColor = false;
            this.registerHereButton.Click += new System.EventHandler(this.registerHereButton_Click);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIDTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTextBox.Location = new System.Drawing.Point(208, 192);
            this.userIDTextBox.Multiline = true;
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(244, 28);
            this.userIDTextBox.TabIndex = 9;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.registerHereButton);
            this.Controls.Add(this.dontHaveAnAccountText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.idPanel);
            this.Controls.Add(this.idIcon);
            this.Controls.Add(this.logbookLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN FORM";
            ((System.ComponentModel.ISupportInitialize)(this.idIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logbookLabel;
        private System.Windows.Forms.PictureBox idIcon;
        private System.Windows.Forms.Panel idPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox dontHaveAnAccountText;
        private System.Windows.Forms.Button registerHereButton;
        public System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox userIDTextBox;
    }
}

