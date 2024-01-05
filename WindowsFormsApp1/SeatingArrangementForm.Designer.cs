namespace WindowsFormsApp1
{
    partial class SeatingArrangementForm
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
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnSortBySeatNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(12, 408);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(84, 30);
            this.btnSortByName.TabIndex = 0;
            this.btnSortByName.Text = "By Name";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnSortBySeatNumber
            // 
            this.btnSortBySeatNumber.Location = new System.Drawing.Point(112, 408);
            this.btnSortBySeatNumber.Name = "btnSortBySeatNumber";
            this.btnSortBySeatNumber.Size = new System.Drawing.Size(84, 30);
            this.btnSortBySeatNumber.TabIndex = 1;
            this.btnSortBySeatNumber.Text = "By Seat No";
            this.btnSortBySeatNumber.UseVisualStyleBackColor = true;
            this.btnSortBySeatNumber.Click += new System.EventHandler(this.btnSortBySeatNumber_Click);
            // 
            // SeatingArrangementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortBySeatNumber);
            this.Controls.Add(this.btnSortByName);
            this.Name = "SeatingArrangementForm";
            this.Text = "SeatingArrangementForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnSortBySeatNumber;
    }
}