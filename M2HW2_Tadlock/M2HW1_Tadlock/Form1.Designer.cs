
namespace M2HW1_Tadlock
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.salaryInput = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.bonusInput = new System.Windows.Forms.TextBox();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(266, 131);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(270, 155);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 26);
            this.nameInput.TabIndex = 1;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(402, 155);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 26);
            this.numberInput.TabIndex = 3;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(398, 131);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(65, 20);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Number";
            // 
            // salaryInput
            // 
            this.salaryInput.Location = new System.Drawing.Point(270, 219);
            this.salaryInput.Name = "salaryInput";
            this.salaryInput.Size = new System.Drawing.Size(100, 26);
            this.salaryInput.TabIndex = 5;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(266, 195);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(53, 20);
            this.salaryLabel.TabIndex = 4;
            this.salaryLabel.Text = "Salary";
            // 
            // bonusInput
            // 
            this.bonusInput.Location = new System.Drawing.Point(402, 219);
            this.bonusInput.Name = "bonusInput";
            this.bonusInput.Size = new System.Drawing.Size(100, 26);
            this.bonusInput.TabIndex = 7;
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Location = new System.Drawing.Point(398, 195);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(55, 20);
            this.bonusLabel.TabIndex = 6;
            this.bonusLabel.Text = "Bonus";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(270, 261);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(232, 34);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create Employee";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.bonusInput);
            this.Controls.Add(this.bonusLabel);
            this.Controls.Add(this.salaryInput);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox salaryInput;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox bonusInput;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Button createButton;
    }
}

