
namespace LogBook
{
    partial class LogHistoryForm
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
            this.logbookFormButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logListView = new System.Windows.Forms.ListView();
            this.employeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastPlaceVisited = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logHistoryLabel
            // 
            this.logHistoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logHistoryLabel.AutoSize = true;
            this.logHistoryLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHistoryLabel.Location = new System.Drawing.Point(200, 34);
            this.logHistoryLabel.Name = "logHistoryLabel";
            this.logHistoryLabel.Size = new System.Drawing.Size(249, 43);
            this.logHistoryLabel.TabIndex = 3;
            this.logHistoryLabel.Text = "LOG HISTORY";
            this.logHistoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logbookFormButton
            // 
            this.logbookFormButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logbookFormButton.BackColor = System.Drawing.Color.Black;
            this.logbookFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logbookFormButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbookFormButton.ForeColor = System.Drawing.Color.White;
            this.logbookFormButton.Location = new System.Drawing.Point(125, 97);
            this.logbookFormButton.Name = "logbookFormButton";
            this.logbookFormButton.Size = new System.Drawing.Size(120, 40);
            this.logbookFormButton.TabIndex = 35;
            this.logbookFormButton.Text = "Logbook Form";
            this.logbookFormButton.UseVisualStyleBackColor = false;
            this.logbookFormButton.Click += new System.EventHandler(this.logbookFormButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchTextBox.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(359, 109);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(151, 28);
            this.searchTextBox.TabIndex = 38;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // employeeListView
            // 
            this.employeeListView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeeListView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name});
            this.employeeListView.GridLines = true;
            this.employeeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(38, 143);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(169, 218);
            this.employeeListView.TabIndex = 1;
            this.employeeListView.TabStop = false;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 115;
            // 
            // logListView
            // 
            this.logListView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logListView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeId,
            this.date,
            this.time,
            this.temp,
            this.lastPlaceVisited});
            this.logListView.GridLines = true;
            this.logListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.logListView.HideSelection = false;
            this.logListView.Location = new System.Drawing.Point(208, 143);
            this.logListView.Name = "logListView";
            this.logListView.Size = new System.Drawing.Size(380, 218);
            this.logListView.TabIndex = 2;
            this.logListView.TabStop = false;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            // 
            // employeeId
            // 
            this.employeeId.Text = "ID";
            this.employeeId.Width = 0;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 82;
            // 
            // time
            // 
            this.time.Text = "Time";
            // 
            // temp
            // 
            this.temp.Text = "Temp.";
            this.temp.Width = 44;
            // 
            // lastPlaceVisited
            // 
            this.lastPlaceVisited.Text = "Last Place Visited";
            this.lastPlaceVisited.Width = 132;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(513, 107);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 30);
            this.searchButton.TabIndex = 41;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.homeButton.BackColor = System.Drawing.Color.Black;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(38, 97);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(81, 40);
            this.homeButton.TabIndex = 42;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // LogHistoryForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.logListView);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.logbookFormButton);
            this.Controls.Add(this.logHistoryLabel);
            this.Name = "LogHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG HISTORY FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logHistoryLabel;
        private System.Windows.Forms.Button logbookFormButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.ColumnHeader employeeId;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader temp;
        private System.Windows.Forms.ColumnHeader lastPlaceVisited;
    }
}