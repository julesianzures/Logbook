
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
            this.informationLabel = new System.Windows.Forms.Label();
            this.lastPlaceVisitedLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.clearValuesButton = new System.Windows.Forms.Button();
            this.viewLogHistory = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lastPlaceTextBox = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.logHistorygroupBox = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.logHistorygroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationLabel
            // 
            this.informationLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel.Location = new System.Drawing.Point(183, 20);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(263, 43);
            this.informationLabel.TabIndex = 2;
            this.informationLabel.Text = "INFORMATION";
            this.informationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastPlaceVisitedLabel
            // 
            this.lastPlaceVisitedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lastPlaceVisitedLabel.AutoSize = true;
            this.lastPlaceVisitedLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPlaceVisitedLabel.Location = new System.Drawing.Point(320, 131);
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
            this.tempLabel.Location = new System.Drawing.Point(320, 63);
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
            this.timeLabel.Location = new System.Drawing.Point(35, 131);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(48, 21);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "TIME:";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.BackColor = System.Drawing.Color.Black;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(159, 200);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Info";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearValuesButton
            // 
            this.clearValuesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearValuesButton.BackColor = System.Drawing.Color.Black;
            this.clearValuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearValuesButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearValuesButton.ForeColor = System.Drawing.Color.White;
            this.clearValuesButton.Location = new System.Drawing.Point(39, 199);
            this.clearValuesButton.Name = "clearValuesButton";
            this.clearValuesButton.Size = new System.Drawing.Size(108, 40);
            this.clearValuesButton.TabIndex = 5;
            this.clearValuesButton.Text = "Clear Values";
            this.clearValuesButton.UseVisualStyleBackColor = false;
            this.clearValuesButton.Click += new System.EventHandler(this.clearValuesButton_Click);
            // 
            // viewLogHistory
            // 
            this.viewLogHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.viewLogHistory.BackColor = System.Drawing.Color.Black;
            this.viewLogHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLogHistory.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogHistory.ForeColor = System.Drawing.Color.White;
            this.viewLogHistory.Location = new System.Drawing.Point(466, 94);
            this.viewLogHistory.Name = "viewLogHistory";
            this.viewLogHistory.Size = new System.Drawing.Size(130, 40);
            this.viewLogHistory.TabIndex = 5;
            this.viewLogHistory.Text = "View Log History";
            this.viewLogHistory.UseVisualStyleBackColor = false;
            this.viewLogHistory.Click += new System.EventHandler(this.viewLogHistory_Click);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "yyyy-MM-dd";
            this.datePicker.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(39, 87);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 1;
            this.datePicker.Tag = "0";
            this.datePicker.Value = new System.DateTime(2021, 2, 10, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // lastPlaceTextBox
            // 
            this.lastPlaceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lastPlaceTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPlaceTextBox.Location = new System.Drawing.Point(324, 154);
            this.lastPlaceTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.lastPlaceTextBox.Multiline = true;
            this.lastPlaceTextBox.Name = "lastPlaceTextBox";
            this.lastPlaceTextBox.Size = new System.Drawing.Size(200, 28);
            this.lastPlaceTextBox.TabIndex = 4;
            // 
            // timePicker
            // 
            this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timePicker.Checked = false;
            this.timePicker.CustomFormat = "HH:mm:ss";
            this.timePicker.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(39, 155);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(125, 22);
            this.timePicker.TabIndex = 2;
            this.timePicker.Value = new System.DateTime(2021, 2, 10, 13, 24, 56, 0);
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged_1);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(35, 63);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 21);
            this.dateLabel.TabIndex = 36;
            this.dateLabel.Text = "DATE:";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tempTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTextBox.Location = new System.Drawing.Point(324, 85);
            this.tempTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.tempTextBox.Multiline = true;
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(125, 28);
            this.tempTextBox.TabIndex = 3;
            // 
            // logHistorygroupBox
            // 
            this.logHistorygroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logHistorygroupBox.Controls.Add(this.dateLabel);
            this.logHistorygroupBox.Controls.Add(this.datePicker);
            this.logHistorygroupBox.Controls.Add(this.tempTextBox);
            this.logHistorygroupBox.Controls.Add(this.lastPlaceTextBox);
            this.logHistorygroupBox.Controls.Add(this.clearValuesButton);
            this.logHistorygroupBox.Controls.Add(this.timeLabel);
            this.logHistorygroupBox.Controls.Add(this.addButton);
            this.logHistorygroupBox.Controls.Add(this.timePicker);
            this.logHistorygroupBox.Controls.Add(this.tempLabel);
            this.logHistorygroupBox.Controls.Add(this.lastPlaceVisitedLabel);
            this.logHistorygroupBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHistorygroupBox.Location = new System.Drawing.Point(32, 130);
            this.logHistorygroupBox.Name = "logHistorygroupBox";
            this.logHistorygroupBox.Size = new System.Drawing.Size(564, 250);
            this.logHistorygroupBox.TabIndex = 38;
            this.logHistorygroupBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(521, 386);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 40);
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // LogbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logHistorygroupBox);
            this.Controls.Add(this.viewLogHistory);
            this.Controls.Add(this.informationLabel);
            this.DoubleBuffered = true;
            this.Name = "LogbookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG BOOK FORM";
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
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearValuesButton;
        private System.Windows.Forms.Button viewLogHistory;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox lastPlaceTextBox;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.GroupBox logHistorygroupBox;
        private System.Windows.Forms.Button backButton;
    }
}