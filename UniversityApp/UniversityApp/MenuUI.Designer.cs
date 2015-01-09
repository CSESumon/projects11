namespace UniversityApp
{
    partial class MenuUI
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
            this.entryButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(41, 42);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(75, 55);
            this.entryButton.TabIndex = 0;
            this.entryButton.Text = "Entry";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(167, 44);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 53);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // MenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.entryButton);
            this.Name = "MenuUI";
            this.Text = "MenuUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Button viewButton;
    }
}