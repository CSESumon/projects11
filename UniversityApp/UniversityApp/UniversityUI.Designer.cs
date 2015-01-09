namespace UniversityApp
{
    partial class UniversityUI
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
            this.searchButton = new System.Windows.Forms.Button();
            this.showListView = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idSearchTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(253, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showListView
            // 
            this.showListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.columnHeader6});
            this.showListView.FullRowSelect = true;
            this.showListView.GridLines = true;
            this.showListView.Location = new System.Drawing.Point(34, 109);
            this.showListView.Name = "showListView";
            this.showListView.Size = new System.Drawing.Size(364, 194);
            this.showListView.TabIndex = 6;
            this.showListView.UseCompatibleStateImageBehavior = false;
            this.showListView.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Id";
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Name";
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Address";
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "PhoneNumber";
            // 
            // idSearchTextBox
            // 
            this.idSearchTextBox.Location = new System.Drawing.Point(105, 26);
            this.idSearchTextBox.Name = "idSearchTextBox";
            this.idSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.idSearchTextBox.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(18, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Department";
            // 
            // UniversityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 356);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.showListView);
            this.Controls.Add(this.idSearchTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "UniversityUI";
            this.Text = "UniversityUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button searchButton;
        internal System.Windows.Forms.ListView showListView;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.TextBox idSearchTextBox;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

