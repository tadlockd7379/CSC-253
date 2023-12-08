
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
            this.shiftInput = new System.Windows.Forms.TextBox();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.wageInput = new System.Windows.Forms.TextBox();
            this.wageLabel = new System.Windows.Forms.Label();
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
            // shiftInput
            // 
            this.shiftInput.Location = new System.Drawing.Point(270, 219);
            this.shiftInput.Name = "shiftInput";
            this.shiftInput.Size = new System.Drawing.Size(100, 26);
            this.shiftInput.TabIndex = 5;
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(266, 195);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(42, 20);
            this.shiftLabel.TabIndex = 4;
            this.shiftLabel.Text = "Shift";
            // 
            // wageInput
            // 
            this.wageInput.Location = new System.Drawing.Point(402, 219);
            this.wageInput.Name = "wageInput";
            this.wageInput.Size = new System.Drawing.Size(100, 26);
            this.wageInput.TabIndex = 7;
            // 
            // wageLabel
            // 
            this.wageLabel.AutoSize = true;
            this.wageLabel.Location = new System.Drawing.Point(398, 195);
            this.wageLabel.Name = "wageLabel";
            this.wageLabel.Size = new System.Drawing.Size(51, 20);
            this.wageLabel.TabIndex = 6;
            this.wageLabel.Text = "Wage";
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
            this.Controls.Add(this.wageInput);
            this.Controls.Add(this.wageLabel);
            this.Controls.Add(this.shiftInput);
            this.Controls.Add(this.shiftLabel);
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
        private System.Windows.Forms.TextBox shiftInput;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.TextBox wageInput;
        private System.Windows.Forms.Label wageLabel;
        private System.Windows.Forms.Button createButton;
    }
}

