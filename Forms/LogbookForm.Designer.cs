﻿
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
            this.informationLabel = new System.Windows.Forms.Label();
            this.lastPlaceVisitedLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.clearValuesButton = new System.Windows.Forms.Button();
            this.lastPlaceTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.logHistorygroupBox = new System.Windows.Forms.GroupBox();
            this.displayTimeLabel = new System.Windows.Forms.Label();
            this.displayDateLabel = new System.Windows.Forms.Label();
            this.logHistorygroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationLabel
            // 
            this.informationLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel.Location = new System.Drawing.Point(118, 41);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(343, 43);
            this.informationLabel.TabIndex = 2;
            this.informationLabel.Text = "LOG INFORMATION";
            this.informationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastPlaceVisitedLabel
            // 
            this.lastPlaceVisitedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lastPlaceVisitedLabel.AutoSize = true;
            this.lastPlaceVisitedLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPlaceVisitedLabel.Location = new System.Drawing.Point(292, 131);
            this.lastPlaceVisitedLabel.Name = "lastPlaceVisitedLabel";
            this.lastPlaceVisitedLabel.Size = new System.Drawing.Size(153, 21);
            this.lastPlaceVisitedLabel.TabIndex = 13;
            this.lastPlaceVisitedLabel.Text = "LAST PLACE VISITED:";
            // 
            // tempLabel
            // 
            this.tempLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(292, 63);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(118, 21);
            this.tempLabel.TabIndex = 12;
            this.tempLabel.Text = "TEMPERATURE:";
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(39, 131);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(48, 21);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "TIME:";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(409, 204);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 40);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Info";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearValuesButton
            // 
            this.clearValuesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearValuesButton.BackColor = System.Drawing.Color.White;
            this.clearValuesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearValuesButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearValuesButton.ForeColor = System.Drawing.Color.Black;
            this.clearValuesButton.Location = new System.Drawing.Point(296, 204);
            this.clearValuesButton.Name = "clearValuesButton";
            this.clearValuesButton.Size = new System.Drawing.Size(108, 40);
            this.clearValuesButton.TabIndex = 5;
            this.clearValuesButton.Text = "Clear Values";
            this.clearValuesButton.UseVisualStyleBackColor = false;
            this.clearValuesButton.Click += new System.EventHandler(this.clearValuesButton_Click);
            // 
            // lastPlaceTextBox
            // 
            this.lastPlaceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lastPlaceTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPlaceTextBox.Location = new System.Drawing.Point(296, 154);
            this.lastPlaceTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.lastPlaceTextBox.Multiline = true;
            this.lastPlaceTextBox.Name = "lastPlaceTextBox";
            this.lastPlaceTextBox.Size = new System.Drawing.Size(200, 28);
            this.lastPlaceTextBox.TabIndex = 4;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(39, 63);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 21);
            this.dateLabel.TabIndex = 36;
            this.dateLabel.Text = "DATE:";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tempTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTextBox.Location = new System.Drawing.Point(296, 85);
            this.tempTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.tempTextBox.Multiline = true;
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(125, 28);
            this.tempTextBox.TabIndex = 3;
            // 
            // logHistorygroupBox
            // 
            this.logHistorygroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logHistorygroupBox.Controls.Add(this.displayTimeLabel);
            this.logHistorygroupBox.Controls.Add(this.displayDateLabel);
            this.logHistorygroupBox.Controls.Add(this.dateLabel);
            this.logHistorygroupBox.Controls.Add(this.tempTextBox);
            this.logHistorygroupBox.Controls.Add(this.lastPlaceTextBox);
            this.logHistorygroupBox.Controls.Add(this.clearValuesButton);
            this.logHistorygroupBox.Controls.Add(this.timeLabel);
            this.logHistorygroupBox.Controls.Add(this.addButton);
            this.logHistorygroupBox.Controls.Add(this.tempLabel);
            this.logHistorygroupBox.Controls.Add(this.lastPlaceVisitedLabel);
            this.logHistorygroupBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHistorygroupBox.Location = new System.Drawing.Point(40, 99);
            this.logHistorygroupBox.Name = "logHistorygroupBox";
            this.logHistorygroupBox.Size = new System.Drawing.Size(509, 250);
            this.logHistorygroupBox.TabIndex = 38;
            this.logHistorygroupBox.TabStop = false;
            // 
            // displayTimeLabel
            // 
            this.displayTimeLabel.AutoSize = true;
            this.displayTimeLabel.BackColor = System.Drawing.Color.LightGray;
            this.displayTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayTimeLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTimeLabel.Location = new System.Drawing.Point(39, 157);
            this.displayTimeLabel.Name = "displayTimeLabel";
            this.displayTimeLabel.Size = new System.Drawing.Size(0, 24);
            this.displayTimeLabel.TabIndex = 41;
            // 
            // displayDateLabel
            // 
            this.displayDateLabel.AutoSize = true;
            this.displayDateLabel.BackColor = System.Drawing.Color.LightGray;
            this.displayDateLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDateLabel.Location = new System.Drawing.Point(39, 88);
            this.displayDateLabel.Name = "displayDateLabel";
            this.displayDateLabel.Size = new System.Drawing.Size(0, 24);
            this.displayDateLabel.TabIndex = 40;
            // 
            // LogbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 416);
            this.Controls.Add(this.logHistorygroupBox);
            this.Controls.Add(this.informationLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogbookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG BOOK FORM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.logHistorygroupBox.ResumeLayout(false);
            this.logHistorygroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label lastPlaceVisitedLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearValuesButton;
        private System.Windows.Forms.TextBox lastPlaceTextBox;
        public System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.GroupBox logHistorygroupBox;
        private System.Windows.Forms.Label displayTimeLabel;
        private System.Windows.Forms.Label displayDateLabel;
    }
}