
namespace M1HW1_Tadlock_Resubmit
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
            this.cs101 = new System.Windows.Forms.RadioButton();
            this.selectClassBox = new System.Windows.Forms.GroupBox();
            this.cm241 = new System.Windows.Forms.RadioButton();
            this.nti110 = new System.Windows.Forms.RadioButton();
            this.cs103 = new System.Windows.Forms.RadioButton();
            this.cs102 = new System.Windows.Forms.RadioButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.selectClassBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cs101
            // 
            this.cs101.AutoSize = true;
            this.cs101.Location = new System.Drawing.Point(0, 25);
            this.cs101.Name = "cs101";
            this.cs101.Size = new System.Drawing.Size(83, 24);
            this.cs101.TabIndex = 0;
            this.cs101.TabStop = true;
            this.cs101.Text = "CS101";
            this.cs101.UseVisualStyleBackColor = true;
            this.cs101.CheckedChanged += new System.EventHandler(this.cs101_CheckedChanged);
            // 
            // selectClassBox
            // 
            this.selectClassBox.Controls.Add(this.cm241);
            this.selectClassBox.Controls.Add(this.nti110);
            this.selectClassBox.Controls.Add(this.cs103);
            this.selectClassBox.Controls.Add(this.cs102);
            this.selectClassBox.Controls.Add(this.cs101);
            this.selectClassBox.Location = new System.Drawing.Point(307, 158);
            this.selectClassBox.Name = "selectClassBox";
            this.selectClassBox.Size = new System.Drawing.Size(200, 170);
            this.selectClassBox.TabIndex = 1;
            this.selectClassBox.TabStop = false;
            this.selectClassBox.Text = "Select Class";
            // 
            // cm241
            // 
            this.cm241.AutoSize = true;
            this.cm241.Location = new System.Drawing.Point(0, 145);
            this.cm241.Name = "cm241";
            this.cm241.Size = new System.Drawing.Size(85, 24);
            this.cm241.TabIndex = 4;
            this.cm241.TabStop = true;
            this.cm241.Text = "CM241";
            this.cm241.UseVisualStyleBackColor = true;
            this.cm241.CheckedChanged += new System.EventHandler(this.cm241_CheckedChanged);
            // 
            // nti110
            // 
            this.nti110.AutoSize = true;
            this.nti110.Location = new System.Drawing.Point(0, 115);
            this.nti110.Name = "nti110";
            this.nti110.Size = new System.Drawing.Size(81, 24);
            this.nti110.TabIndex = 3;
            this.nti110.TabStop = true;
            this.nti110.Text = "NT110";
            this.nti110.UseVisualStyleBackColor = true;
            this.nti110.CheckedChanged += new System.EventHandler(this.nti110_CheckedChanged);
            // 
            // cs103
            // 
            this.cs103.AutoSize = true;
            this.cs103.Location = new System.Drawing.Point(0, 85);
            this.cs103.Name = "cs103";
            this.cs103.Size = new System.Drawing.Size(83, 24);
            this.cs103.TabIndex = 2;
            this.cs103.TabStop = true;
            this.cs103.Text = "CS103";
            this.cs103.UseVisualStyleBackColor = true;
            this.cs103.CheckedChanged += new System.EventHandler(this.cs103_CheckedChanged);
            // 
            // cs102
            // 
            this.cs102.AutoSize = true;
            this.cs102.Location = new System.Drawing.Point(0, 55);
            this.cs102.Name = "cs102";
            this.cs102.Size = new System.Drawing.Size(83, 24);
            this.cs102.TabIndex = 1;
            this.cs102.TabStop = true;
            this.cs102.Text = "CS102";
            this.cs102.UseVisualStyleBackColor = true;
            this.cs102.CheckedChanged += new System.EventHandler(this.cs102_CheckedChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(99, 60);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.selectClassBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.selectClassBox.ResumeLayout(false);
            this.selectClassBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton cs101;
        private System.Windows.Forms.GroupBox selectClassBox;
        private System.Windows.Forms.RadioButton cm241;
        private System.Windows.Forms.RadioButton nti110;
        private System.Windows.Forms.RadioButton cs103;
        private System.Windows.Forms.RadioButton cs102;
        private System.Windows.Forms.Label resultLabel;
    }
}

