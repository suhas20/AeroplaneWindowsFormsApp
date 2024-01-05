namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAssignSeats = new System.Windows.Forms.Button();
            this.btnShowSeating = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.radioBtnFirstClass = new System.Windows.Forms.RadioButton();
            this.radioBtnEconomyClass = new System.Windows.Forms.RadioButton();
            this.numPassengersSelector = new System.Windows.Forms.NumericUpDown();
            this.radioBtnWindow = new System.Windows.Forms.RadioButton();
            this.radioBtnCenter = new System.Windows.Forms.RadioButton();
            this.radioBtnAisle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowSeatingEco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPassengersSelector)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "PASSANGER NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "TRAVEL CLASS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "NUMBER OF SEAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "SEAT TYPE";
            // 
            // btnAssignSeats
            // 
            this.btnAssignSeats.Location = new System.Drawing.Point(147, 266);
            this.btnAssignSeats.Name = "btnAssignSeats";
            this.btnAssignSeats.Size = new System.Drawing.Size(111, 39);
            this.btnAssignSeats.TabIndex = 10;
            this.btnAssignSeats.Text = "ADD";
            this.btnAssignSeats.UseVisualStyleBackColor = true;
            this.btnAssignSeats.Click += new System.EventHandler(this.btnAssignSeats_Click);
            // 
            // btnShowSeating
            // 
            this.btnShowSeating.Location = new System.Drawing.Point(440, 261);
            this.btnShowSeating.Name = "btnShowSeating";
            this.btnShowSeating.Size = new System.Drawing.Size(111, 48);
            this.btnShowSeating.TabIndex = 11;
            this.btnShowSeating.Text = "First Class Passanger List";
            this.btnShowSeating.UseVisualStyleBackColor = true;
            this.btnShowSeating.Click += new System.EventHandler(this.btnShowSeating_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(296, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 39);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // radioBtnFirstClass
            // 
            this.radioBtnFirstClass.AutoSize = true;
            this.radioBtnFirstClass.Location = new System.Drawing.Point(118, 16);
            this.radioBtnFirstClass.Name = "radioBtnFirstClass";
            this.radioBtnFirstClass.Size = new System.Drawing.Size(113, 20);
            this.radioBtnFirstClass.TabIndex = 13;
            this.radioBtnFirstClass.TabStop = true;
            this.radioBtnFirstClass.Text = "FIRST CLASS";
            this.radioBtnFirstClass.UseVisualStyleBackColor = true;
            // 
            // radioBtnEconomyClass
            // 
            this.radioBtnEconomyClass.AutoSize = true;
            this.radioBtnEconomyClass.Location = new System.Drawing.Point(6, 16);
            this.radioBtnEconomyClass.Name = "radioBtnEconomyClass";
            this.radioBtnEconomyClass.Size = new System.Drawing.Size(96, 20);
            this.radioBtnEconomyClass.TabIndex = 14;
            this.radioBtnEconomyClass.TabStop = true;
            this.radioBtnEconomyClass.Text = "ECONOMY";
            this.radioBtnEconomyClass.UseVisualStyleBackColor = true;
            // 
            // numPassengersSelector
            // 
            this.numPassengersSelector.Location = new System.Drawing.Point(305, 152);
            this.numPassengersSelector.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numPassengersSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPassengersSelector.Name = "numPassengersSelector";
            this.numPassengersSelector.Size = new System.Drawing.Size(132, 22);
            this.numPassengersSelector.TabIndex = 15;
            this.numPassengersSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioBtnWindow
            // 
            this.radioBtnWindow.AutoSize = true;
            this.radioBtnWindow.Location = new System.Drawing.Point(305, 203);
            this.radioBtnWindow.Name = "radioBtnWindow";
            this.radioBtnWindow.Size = new System.Drawing.Size(87, 20);
            this.radioBtnWindow.TabIndex = 16;
            this.radioBtnWindow.TabStop = true;
            this.radioBtnWindow.Text = "WINDOW";
            this.radioBtnWindow.UseVisualStyleBackColor = true;
            // 
            // radioBtnCenter
            // 
            this.radioBtnCenter.AutoSize = true;
            this.radioBtnCenter.Location = new System.Drawing.Point(408, 203);
            this.radioBtnCenter.Name = "radioBtnCenter";
            this.radioBtnCenter.Size = new System.Drawing.Size(84, 20);
            this.radioBtnCenter.TabIndex = 17;
            this.radioBtnCenter.TabStop = true;
            this.radioBtnCenter.Text = "CENTER";
            this.radioBtnCenter.UseVisualStyleBackColor = true;
            // 
            // radioBtnAisle
            // 
            this.radioBtnAisle.AutoSize = true;
            this.radioBtnAisle.Location = new System.Drawing.Point(518, 203);
            this.radioBtnAisle.Name = "radioBtnAisle";
            this.radioBtnAisle.Size = new System.Drawing.Size(65, 20);
            this.radioBtnAisle.TabIndex = 18;
            this.radioBtnAisle.TabStop = true;
            this.radioBtnAisle.Text = "AISLE";
            this.radioBtnAisle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioBtnEconomyClass);
            this.groupBox1.Controls.Add(this.radioBtnFirstClass);
            this.groupBox1.Location = new System.Drawing.Point(305, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 42);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnShowSeatingEco
            // 
            this.btnShowSeatingEco.Location = new System.Drawing.Point(590, 261);
            this.btnShowSeatingEco.Name = "btnShowSeatingEco";
            this.btnShowSeatingEco.Size = new System.Drawing.Size(111, 48);
            this.btnShowSeatingEco.TabIndex = 21;
            this.btnShowSeatingEco.Text = "Economy class passanger list";
            this.btnShowSeatingEco.UseVisualStyleBackColor = true;
            this.btnShowSeatingEco.Click += new System.EventHandler(this.btnShowSeatingEco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowSeatingEco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioBtnAisle);
            this.Controls.Add(this.radioBtnCenter);
            this.Controls.Add(this.radioBtnWindow);
            this.Controls.Add(this.numPassengersSelector);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowSeating);
            this.Controls.Add(this.btnAssignSeats);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPassengersSelector)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAssignSeats;
        private System.Windows.Forms.Button btnShowSeating;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton radioBtnFirstClass;
        private System.Windows.Forms.RadioButton radioBtnEconomyClass;
        private System.Windows.Forms.NumericUpDown numPassengersSelector;
        private System.Windows.Forms.RadioButton radioBtnWindow;
        private System.Windows.Forms.RadioButton radioBtnCenter;
        private System.Windows.Forms.RadioButton radioBtnAisle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowSeatingEco;
    }
}

