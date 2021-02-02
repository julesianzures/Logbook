
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridViewLogHistory = new System.Windows.Forms.DataGridView();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPlaceVisited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLabel = new System.Windows.Forms.Label();
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
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(136, 101);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(160, 28);
            this.searchTextBox.TabIndex = 32;
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
            this.dataGridViewLogHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userID,
            this.name,
            this.date,
            this.time,
            this.temp,
            this.lastPlaceVisited});
            this.dataGridViewLogHistory.Location = new System.Drawing.Point(37, 132);
            this.dataGridViewLogHistory.Name = "dataGridViewLogHistory";
            this.dataGridViewLogHistory.Size = new System.Drawing.Size(550, 227);
            this.dataGridViewLogHistory.TabIndex = 36;
            // 
            // userID
            // 
            this.userID.Frozen = true;
            this.userID.HeaderText = "ID";
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            this.userID.Width = 50;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date
            // 
            this.date.Frozen = true;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.Frozen = true;
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 70;
            // 
            // temp
            // 
            this.temp.Frozen = true;
            this.temp.HeaderText = "Temperature";
            this.temp.Name = "temp";
            this.temp.ReadOnly = true;
            this.temp.Width = 70;
            // 
            // lastPlaceVisited
            // 
            this.lastPlaceVisited.Frozen = true;
            this.lastPlaceVisited.HeaderText = "Last Place Visited";
            this.lastPlaceVisited.Name = "lastPlaceVisited";
            this.lastPlaceVisited.ReadOnly = true;
            this.lastPlaceVisited.Width = 130;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(35, 104);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(98, 21);
            this.searchLabel.TabIndex = 37;
            this.searchLabel.Text = "Search by ID:";
            // 
            // logHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.dataGridViewLogHistory);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchTextBox);
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
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridViewLogHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastPlaceVisited;
        private System.Windows.Forms.Label searchLabel;
    }
}