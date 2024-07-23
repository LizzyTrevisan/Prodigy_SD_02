namespace Prodigy_SD_02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label helperLabel;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.TextBox numbersTextBox;
        private System.Windows.Forms.Button confirmButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.helperLabel = new System.Windows.Forms.Label();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.numbersTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titleLabel.Location = new System.Drawing.Point(53, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(267, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Guess the number (1 to 100):";
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.counterLabel.Location = new System.Drawing.Point(145, 62);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(18, 20);
            this.counterLabel.TabIndex = 1;
            this.counterLabel.Text = "0";
            // 
            // helperLabel
            // 
            this.helperLabel.AutoSize = true;
            this.helperLabel.Location = new System.Drawing.Point(12, 100);
            this.helperLabel.Name = "helperLabel";
            this.helperLabel.Size = new System.Drawing.Size(0, 20);
            this.helperLabel.TabIndex = 2;
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attemptsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.attemptsLabel.Location = new System.Drawing.Point(12, 62);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(76, 20);
            this.attemptsLabel.TabIndex = 3;
            this.attemptsLabel.Text = "Attempts";
            // 
            // numbersTextBox
            // 
            this.numbersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numbersTextBox.Location = new System.Drawing.Point(16, 139);
            this.numbersTextBox.Name = "numbersTextBox";
            this.numbersTextBox.Size = new System.Drawing.Size(100, 27);
            this.numbersTextBox.TabIndex = 4;
            this.numbersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.confirmButton.Location = new System.Drawing.Point(149, 138);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(90, 28);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(263, 134);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 31);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.numbersTextBox);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.helperLabel);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button resetButton;
    }
}
