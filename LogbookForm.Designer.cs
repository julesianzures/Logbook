
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
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.lastPlaceTextBox = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.exitButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // informationLabel
            // 
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
            this.lastPlaceVisitedLabel.AutoSize = true;
            this.lastPlaceVisitedLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPlaceVisitedLabel.Location = new System.Drawing.Point(65, 283);
            this.lastPlaceVisitedLabel.Name = "lastPlaceVisitedLabel";
            this.lastPlaceVisitedLabel.Size = new System.Drawing.Size(153, 21);
            this.lastPlaceVisitedLabel.TabIndex = 13;
            this.lastPlaceVisitedLabel.Text = "LAST PLACE VISITED:";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(65, 214);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(118, 21);
            this.tempLabel.TabIndex = 12;
            this.tempLabel.Text = "TEMPERATURE:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(65, 146);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(48, 21);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "TIME:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Black;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(458, 368);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "ADD INFO";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearValuesButton
            // 
            this.clearValuesButton.BackColor = System.Drawing.Color.Black;
            this.clearValuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearValuesButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearValuesButton.ForeColor = System.Drawing.Color.White;
            this.clearValuesButton.Location = new System.Drawing.Point(69, 368);
            this.clearValuesButton.Name = "clearValuesButton";
            this.clearValuesButton.Size = new System.Drawing.Size(125, 40);
            this.clearValuesButton.TabIndex = 27;
            this.clearValuesButton.Text = "CLEAR VALUES";
            this.clearValuesButton.UseVisualStyleBackColor = false;
            this.clearValuesButton.Click += new System.EventHandler(this.clearValuesButton_Click);
            // 
            // viewLogHistory
            // 
            this.viewLogHistory.BackColor = System.Drawing.Color.Black;
            this.viewLogHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLogHistory.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogHistory.ForeColor = System.Drawing.Color.White;
            this.viewLogHistory.Location = new System.Drawing.Point(279, 368);
            this.viewLogHistory.Name = "viewLogHistory";
            this.viewLogHistory.Size = new System.Drawing.Size(156, 40);
            this.viewLogHistory.TabIndex = 28;
            this.viewLogHistory.Text = "VIEW LOG HISTORY";
            this.viewLogHistory.UseVisualStyleBackColor = false;
            this.viewLogHistory.Click += new System.EventHandler(this.viewLogHistory_Click);
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "yyyy/MM/dd";
            this.datePicker.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(69, 107);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowCheckBox = true;
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 29;
            this.datePicker.Tag = "";
            this.datePicker.Value = new System.DateTime(2021, 2, 1, 15, 32, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // tempTextBox
            // 
            this.tempTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTextBox.Location = new System.Drawing.Point(69, 237);
            this.tempTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.tempTextBox.Multiline = true;
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(125, 28);
            this.tempTextBox.TabIndex = 31;
            // 
            // lastPlaceTextBox
            // 
            this.lastPlaceTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPlaceTextBox.Location = new System.Drawing.Point(69, 306);
            this.lastPlaceTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.lastPlaceTextBox.Multiline = true;
            this.lastPlaceTextBox.Name = "lastPlaceTextBox";
            this.lastPlaceTextBox.Size = new System.Drawing.Size(200, 28);
            this.lastPlaceTextBox.TabIndex = 32;
            // 
            // timePicker
            // 
            this.timePicker.Checked = false;
            this.timePicker.CustomFormat = "HH:mm:ss ";
            this.timePicker.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(69, 170);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowCheckBox = true;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(125, 22);
            this.timePicker.TabIndex = 33;
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
            this.exitButton.TabIndex = 35;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(65, 83);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 21);
            this.dateLabel.TabIndex = 36;
            this.dateLabel.Text = "DATE:";
            // 
            // LogbookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.lastPlaceTextBox);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.viewLogHistory);
            this.Controls.Add(this.clearValuesButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lastPlaceVisitedLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.informationLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogbookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG BOOK FORM";
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
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.TextBox lastPlaceTextBox;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label dateLabel;
    }
}