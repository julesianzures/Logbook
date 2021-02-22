namespace LogBook
{
    partial class HomeForm
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
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logHistoryButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.buttonsPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonsPanel.Controls.Add(this.namePanel);
            this.buttonsPanel.Controls.Add(this.logButton);
            this.buttonsPanel.Controls.Add(this.exitButton);
            this.buttonsPanel.Controls.Add(this.logHistoryButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(165, 438);
            this.buttonsPanel.TabIndex = 0;
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.Silver;
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.namePanel.Location = new System.Drawing.Point(0, 0);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(161, 50);
            this.namePanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(26, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 24);
            this.nameLabel.TabIndex = 58;
            this.nameLabel.Text = "Hello, Marshall";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.Color.Black;
            this.logButton.Location = new System.Drawing.Point(0, 49);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(165, 40);
            this.logButton.TabIndex = 1;
            this.logButton.TabStop = false;
            this.logButton.Text = "Log Today";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(-2, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(165, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logHistoryButton
            // 
            this.logHistoryButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logHistoryButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHistoryButton.ForeColor = System.Drawing.Color.Black;
            this.logHistoryButton.Location = new System.Drawing.Point(0, 87);
            this.logHistoryButton.Name = "logHistoryButton";
            this.logHistoryButton.Size = new System.Drawing.Size(165, 40);
            this.logHistoryButton.TabIndex = 2;
            this.logHistoryButton.TabStop = false;
            this.logHistoryButton.Text = "View Log History";
            this.logHistoryButton.UseVisualStyleBackColor = false;
            this.logHistoryButton.Click += new System.EventHandler(this.logHistoryButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.homeLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(165, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(519, 438);
            this.mainPanel.TabIndex = 1;
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(105, 180);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(303, 43);
            this.homeLabel.TabIndex = 59;
            this.homeLabel.Text = "LOGBOOK HOME";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 438);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME FORM";
            this.buttonsPanel.ResumeLayout(false);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logHistoryButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label homeLabel;
        public System.Windows.Forms.Button logButton;
    }
}