namespace ChatAWhileGUI
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AreaCodeLabel = new System.Windows.Forms.Label();
            this.CallLengthLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.AreaCodeBox = new System.Windows.Forms.TextBox();
            this.CallLengthBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(196, 90);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(446, 44);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Chat A While Calculator";
            // 
            // AreaCodeLabel
            // 
            this.AreaCodeLabel.AutoSize = true;
            this.AreaCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaCodeLabel.Location = new System.Drawing.Point(138, 214);
            this.AreaCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AreaCodeLabel.Name = "AreaCodeLabel";
            this.AreaCodeLabel.Size = new System.Drawing.Size(170, 37);
            this.AreaCodeLabel.TabIndex = 1;
            this.AreaCodeLabel.Text = "Area Code";
            // 
            // CallLengthLabel
            // 
            this.CallLengthLabel.AutoSize = true;
            this.CallLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallLengthLabel.Location = new System.Drawing.Point(465, 214);
            this.CallLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CallLengthLabel.Name = "CallLengthLabel";
            this.CallLengthLabel.Size = new System.Drawing.Size(215, 37);
            this.CallLengthLabel.TabIndex = 2;
            this.CallLengthLabel.Text = "Length of Call";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(228, 502);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(282, 37);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Total Cost of Call: ";
            // 
            // AreaCodeBox
            // 
            this.AreaCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaCodeBox.Location = new System.Drawing.Point(155, 284);
            this.AreaCodeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AreaCodeBox.Name = "AreaCodeBox";
            this.AreaCodeBox.Size = new System.Drawing.Size(130, 44);
            this.AreaCodeBox.TabIndex = 4;
            // 
            // CallLengthBox
            // 
            this.CallLengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallLengthBox.Location = new System.Drawing.Point(496, 284);
            this.CallLengthBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CallLengthBox.Name = "CallLengthBox";
            this.CallLengthBox.Size = new System.Drawing.Size(146, 44);
            this.CallLengthBox.TabIndex = 5;
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButton.Location = new System.Drawing.Point(293, 386);
            this.CalcButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(193, 60);
            this.CalcButton.TabIndex = 6;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(795, 607);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.CallLengthBox);
            this.Controls.Add(this.AreaCodeBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.CallLengthLabel);
            this.Controls.Add(this.AreaCodeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Chat A While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AreaCodeLabel;
        private System.Windows.Forms.Label CallLengthLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox AreaCodeBox;
        private System.Windows.Forms.TextBox CallLengthBox;
        private System.Windows.Forms.Button CalcButton;
    }
}

