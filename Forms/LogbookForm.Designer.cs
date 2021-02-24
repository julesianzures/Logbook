
namespace LogBook
{
    partial class LogbookForm
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
            this.logbookGroupBox = new System.Windows.Forms.GroupBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.displayTimeLabel = new System.Windows.Forms.Label();
            this.displayDateLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.lastPlaceTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.tempLabel = new System.Windows.Forms.Label();
            this.lastPlaceVisitedLabel = new System.Windows.Forms.Label();
            this.logbookGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logbookGroupBox
            // 
            this.logbookGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logbookGroupBox.Controls.Add(this.informationLabel);
            this.logbookGroupBox.Controls.Add(this.displayTimeLabel);
            this.logbookGroupBox.Controls.Add(this.displayDateLabel);
            this.logbookGroupBox.Controls.Add(this.dateLabel);
            this.logbookGroupBox.Controls.Add(this.tempTextBox);
            this.logbookGroupBox.Controls.Add(this.lastPlaceTextBox);
            this.logbookGroupBox.Controls.Add(this.closeButton);
            this.logbookGroupBox.Controls.Add(this.timeLabel);
            this.logbookGroupBox.Controls.Add(this.addButton);
            this.logbookGroupBox.Controls.Add(this.tempLabel);
            this.logbookGroupBox.Controls.Add(this.lastPlaceVisitedLabel);
            this.logbookGroupBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbookGroupBox.Location = new System.Drawing.Point(29, 40);
            this.logbookGroupBox.Name = "logbookGroupBox";
            this.logbookGroupBox.Size = new System.Drawing.Size(529, 351);
            this.logbookGroupBox.TabIndex = 40;
            this.logbookGroupBox.TabStop = false;
            // 
            // informationLabel
            // 
            this.informationLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel.Location = new System.Drawing.Point(94, 25);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(343, 43);
            this.informationLabel.TabIndex = 41;
            this.informationLabel.Text = "LOG INFORMATION";
            this.informationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // displayTimeLabel
            // 
            this.displayTimeLabel.AutoSize = true;
            this.displayTimeLabel.BackColor = System.Drawing.Color.LightGray;
            this.displayTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayTimeLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTimeLabel.Location = new System.Drawing.Point(50, 221);
            this.displayTimeLabel.Name = "displayTimeLabel";
            this.displayTimeLabel.Size = new System.Drawing.Size(56, 24);
            this.displayTimeLabel.TabIndex = 41;
            this.displayTimeLabel.Text = "dfgfd";
            // 
            // displayDateLabel
            // 
            this.displayDateLabel.AutoSize = true;
            this.displayDateLabel.BackColor = System.Drawing.Color.LightGray;
            this.displayDateLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDateLabel.Location = new System.Drawing.Point(50, 152);
            this.displayDateLabel.Name = "displayDateLabel";
            this.displayDateLabel.Size = new System.Drawing.Size(66, 24);
            this.displayDateLabel.TabIndex = 40;
            this.displayDateLabel.Text = "fdgfdg";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(46, 126);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 21);
            this.dateLabel.TabIndex = 36;
            this.dateLabel.Text = "DATE:";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tempTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTextBox.Location = new System.Drawing.Point(303, 148);
            this.tempTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.tempTextBox.Multiline = true;
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(125, 28);
            this.tempTextBox.TabIndex = 3;
            // 
            // lastPlaceTextBox
            // 
            this.lastPlaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastPlaceTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPlaceTextBox.Location = new System.Drawing.Point(303, 217);
            this.lastPlaceTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.lastPlaceTextBox.Multiline = true;
            this.lastPlaceTextBox.Name = "lastPlaceTextBox";
            this.lastPlaceTextBox.Size = new System.Drawing.Size(200, 28);
            this.lastPlaceTextBox.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(303, 275);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 40);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(46, 194);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(48, 21);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "TIME:";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(416, 275);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 40);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Info";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tempLabel
            // 
            this.tempLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(299, 126);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(118, 21);
            this.tempLabel.TabIndex = 12;
            this.tempLabel.Text = "TEMPERATURE:";
            // 
            // lastPlaceVisitedLabel
            // 
            this.lastPlaceVisitedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastPlaceVisitedLabel.AutoSize = true;
            this.lastPlaceVisitedLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPlaceVisitedLabel.Location = new System.Drawing.Point(299, 194);
            this.lastPlaceVisitedLabel.Name = "lastPlaceVisitedLabel";
            this.lastPlaceVisitedLabel.Size = new System.Drawing.Size(153, 21);
            this.lastPlaceVisitedLabel.TabIndex = 13;
            this.lastPlaceVisitedLabel.Text = "LAST PLACE VISITED:";
            // 
            // LogbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 437);
            this.Controls.Add(this.logbookGroupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogbookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG BOOK FORM";
            this.logbookGroupBox.ResumeLayout(false);
            this.logbookGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logbookGroupBox;
        private System.Windows.Forms.Label displayTimeLabel;
        private System.Windows.Forms.Label displayDateLabel;
        public System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.TextBox lastPlaceTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label lastPlaceVisitedLabel;
        private System.Windows.Forms.Label informationLabel;
    }
}