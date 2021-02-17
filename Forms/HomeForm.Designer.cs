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
            this.homeLabel = new System.Windows.Forms.Label();
            this.logButton = new System.Windows.Forms.Button();
            this.logHistoryButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(163, 86);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(303, 43);
            this.homeLabel.TabIndex = 4;
            this.homeLabel.Text = "LOGBOOK HOME";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logButton
            // 
            this.logButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logButton.BackColor = System.Drawing.Color.White;
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.Color.Black;
            this.logButton.Location = new System.Drawing.Point(238, 231);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(156, 40);
            this.logButton.TabIndex = 48;
            this.logButton.TabStop = false;
            this.logButton.Text = "Log Today";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click_1);
            // 
            // logHistoryButton
            // 
            this.logHistoryButton.BackColor = System.Drawing.Color.White;
            this.logHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logHistoryButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHistoryButton.ForeColor = System.Drawing.Color.Black;
            this.logHistoryButton.Location = new System.Drawing.Point(238, 279);
            this.logHistoryButton.Name = "logHistoryButton";
            this.logHistoryButton.Size = new System.Drawing.Size(156, 40);
            this.logHistoryButton.TabIndex = 47;
            this.logHistoryButton.TabStop = false;
            this.logHistoryButton.Text = "View Log History";
            this.logHistoryButton.UseVisualStyleBackColor = false;
            this.logHistoryButton.Click += new System.EventHandler(this.logHistoryButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(256, 144);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 26);
            this.nameLabel.TabIndex = 49;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.logHistoryButton);
            this.Controls.Add(this.homeLabel);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button logHistoryButton;
        private System.Windows.Forms.Label nameLabel;
    }
}