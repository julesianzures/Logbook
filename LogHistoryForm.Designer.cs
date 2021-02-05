
namespace LogBook
{
    partial class logHistoryForm
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
            this.logHistoryLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridViewLogHistory = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // logHistoryLabel
            // 
            this.logHistoryLabel.AutoSize = true;
            this.logHistoryLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHistoryLabel.Location = new System.Drawing.Point(187, 20);
            this.logHistoryLabel.Name = "logHistoryLabel";
            this.logHistoryLabel.Size = new System.Drawing.Size(249, 43);
            this.logHistoryLabel.TabIndex = 3;
            this.logHistoryLabel.Text = "LOG HISTORY";
            this.logHistoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(506, 365);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 40);
            this.backButton.TabIndex = 35;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridViewLogHistory
            // 
            this.dataGridViewLogHistory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewLogHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLogHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogHistory.Location = new System.Drawing.Point(37, 132);
            this.dataGridViewLogHistory.Name = "dataGridViewLogHistory";
            this.dataGridViewLogHistory.Size = new System.Drawing.Size(550, 227);
            this.dataGridViewLogHistory.TabIndex = 36;
            this.dataGridViewLogHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLogHistory_CellContentClick_1);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(37, 101);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(449, 26);
            this.searchTextBox.TabIndex = 38;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(489, 100);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 28);
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "Open CSV file";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            this.openFileDialog1.Title = "Open CSV file";
            // 
            // logHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridViewLogHistory);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logHistoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG HISTORY FORM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logHistoryLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridViewLogHistory;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}