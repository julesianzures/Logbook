
namespace Logbook
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
            this.logHistoryLabel = new System.Windows.Forms.Label();
            this.logListView = new System.Windows.Forms.ListView();
            this.employeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastPlaceVisited = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // logHistoryLabel
            // 
            this.logHistoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logHistoryLabel.AutoSize = true;
            this.logHistoryLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHistoryLabel.Location = new System.Drawing.Point(176, 54);
            this.logHistoryLabel.Name = "logHistoryLabel";
            this.logHistoryLabel.Size = new System.Drawing.Size(249, 43);
            this.logHistoryLabel.TabIndex = 3;
            this.logHistoryLabel.Text = "LOG HISTORY";
            this.logHistoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logListView
            // 
            this.logListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.logListView.Location = new System.Drawing.Point(91, 100);
            this.logListView.Name = "logListView";
            this.logListView.Size = new System.Drawing.Size(407, 307);
            this.logListView.TabIndex = 2;
            this.logListView.TabStop = false;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            // 
            // employeeId
            // 
            this.employeeId.Text = "Id";
            this.employeeId.Width = 0;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 88;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 64;
            // 
            // temp
            // 
            this.temp.Text = "Temp.";
            this.temp.Width = 51;
            // 
            // lastPlaceVisited
            // 
            this.lastPlaceVisited.Text = "Last Place Visited";
            this.lastPlaceVisited.Width = 156;
            // 
            // LogHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 476);
            this.Controls.Add(this.logListView);
            this.Controls.Add(this.logHistoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG HISTORY FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logHistoryLabel;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.ColumnHeader employeeId;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader temp;
        private System.Windows.Forms.ColumnHeader lastPlaceVisited;
    }
}