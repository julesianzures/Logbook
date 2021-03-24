
namespace Logbook
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logbookLabel = new System.Windows.Forms.Label();
            this.idIcon = new System.Windows.Forms.PictureBox();
            this.idPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerHereButton = new System.Windows.Forms.Button();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.dontHaveAnIdYetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // logbookLabel
            // 
            this.logbookLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logbookLabel.AutoSize = true;
            this.logbookLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbookLabel.Location = new System.Drawing.Point(202, 82);
            this.logbookLabel.Name = "logbookLabel";
            this.logbookLabel.Size = new System.Drawing.Size(190, 43);
            this.logbookLabel.TabIndex = 0;
            this.logbookLabel.Text = "LOGBOOK";
            this.logbookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idIcon
            // 
            this.idIcon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idIcon.Image = ((System.Drawing.Image)(resources.GetObject("idIcon.Image")));
            this.idIcon.Location = new System.Drawing.Point(158, 185);
            this.idIcon.Name = "idIcon";
            this.idIcon.Size = new System.Drawing.Size(30, 30);
            this.idIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.idIcon.TabIndex = 1;
            this.idIcon.TabStop = false;
            // 
            // idPanel
            // 
            this.idPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idPanel.BackColor = System.Drawing.Color.DimGray;
            this.idPanel.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPanel.Location = new System.Drawing.Point(158, 221);
            this.idPanel.Name = "idPanel";
            this.idPanel.Size = new System.Drawing.Size(280, 1);
            this.idPanel.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginButton.BackColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Franklin Gothic Book", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(158, 255);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(280, 40);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerHereButton
            // 
            this.registerHereButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registerHereButton.BackColor = System.Drawing.Color.Transparent;
            this.registerHereButton.FlatAppearance.BorderSize = 0;
            this.registerHereButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerHereButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHereButton.ForeColor = System.Drawing.Color.DimGray;
            this.registerHereButton.Location = new System.Drawing.Point(322, 303);
            this.registerHereButton.Name = "registerHereButton";
            this.registerHereButton.Size = new System.Drawing.Size(111, 29);
            this.registerHereButton.TabIndex = 7;
            this.registerHereButton.Text = "Register here.";
            this.registerHereButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerHereButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.registerHereButton.UseVisualStyleBackColor = false;
            this.registerHereButton.Click += new System.EventHandler(this.registerHereButton_Click);
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeeIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeIdTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdTextBox.ForeColor = System.Drawing.Color.Silver;
            this.employeeIdTextBox.Location = new System.Drawing.Point(194, 191);
            this.employeeIdTextBox.Multiline = true;
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(244, 28);
            this.employeeIdTextBox.TabIndex = 9;
            this.employeeIdTextBox.Text = "Enter ID number ";
            this.employeeIdTextBox.Enter += new System.EventHandler(this.employeeIdTextBox_Enter);
            // 
            // dontHaveAnIdYetLabel
            // 
            this.dontHaveAnIdYetLabel.AutoSize = true;
            this.dontHaveAnIdYetLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dontHaveAnIdYetLabel.Location = new System.Drawing.Point(170, 307);
            this.dontHaveAnIdYetLabel.Name = "dontHaveAnIdYetLabel";
            this.dontHaveAnIdYetLabel.Size = new System.Drawing.Size(152, 21);
            this.dontHaveAnIdYetLabel.TabIndex = 10;
            this.dontHaveAnIdYetLabel.Text = "Don\'t have an ID yet?";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 437);
            this.Controls.Add(this.dontHaveAnIdYetLabel);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.registerHereButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.idPanel);
            this.Controls.Add(this.idIcon);
            this.Controls.Add(this.logbookLabel);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
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
        private System.Windows.Forms.Button registerHereButton;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.Label dontHaveAnIdYetLabel;
    }
}

