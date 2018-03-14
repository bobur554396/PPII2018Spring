namespace FirstExample
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
            this.firstButton = new System.Windows.Forms.Button();
            this.myLabel = new System.Windows.Forms.Label();
            this.secondButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.firstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.Location = new System.Drawing.Point(436, 220);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(224, 103);
            this.firstButton.TabIndex = 0;
            this.firstButton.Text = "button1";
            this.firstButton.UseVisualStyleBackColor = false;
            this.firstButton.Click += new System.EventHandler(this.common_button_click);
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel.Location = new System.Drawing.Point(443, 106);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(67, 37);
            this.myLabel.TabIndex = 1;
            this.myLabel.Text = "text";
            // 
            // secondButton
            // 
            this.secondButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.secondButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondButton.Location = new System.Drawing.Point(793, 220);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(224, 103);
            this.secondButton.TabIndex = 2;
            this.secondButton.Text = "button2";
            this.secondButton.UseVisualStyleBackColor = false;
            this.secondButton.Click += new System.EventHandler(this.common_button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 1001);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.firstButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Label myLabel;
        private System.Windows.Forms.Button secondButton;
    }
}

