
namespace WeatherApp
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.celsiusRadioButton = new System.Windows.Forms.RadioButton();
            this.fahrenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefered Unit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fahrenheitRadioButton);
            this.groupBox1.Controls.Add(this.celsiusRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(136, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Units";
            // 
            // celsiusRadioButton
            // 
            this.celsiusRadioButton.AutoSize = true;
            this.celsiusRadioButton.Checked = true;
            this.celsiusRadioButton.Location = new System.Drawing.Point(7, 20);
            this.celsiusRadioButton.Name = "celsiusRadioButton";
            this.celsiusRadioButton.Size = new System.Drawing.Size(93, 24);
            this.celsiusRadioButton.TabIndex = 0;
            this.celsiusRadioButton.TabStop = true;
            this.celsiusRadioButton.Text = "Celsius C";
            this.celsiusRadioButton.UseVisualStyleBackColor = true;
            // 
            // fahrenheitRadioButton
            // 
            this.fahrenheitRadioButton.AutoSize = true;
            this.fahrenheitRadioButton.Location = new System.Drawing.Point(6, 52);
            this.fahrenheitRadioButton.Name = "fahrenheitRadioButton";
            this.fahrenheitRadioButton.Size = new System.Drawing.Size(118, 24);
            this.fahrenheitRadioButton.TabIndex = 1;
            this.fahrenheitRadioButton.TabStop = true;
            this.fahrenheitRadioButton.Text = "Fahrenheit F";
            this.fahrenheitRadioButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 135);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fahrenheitRadioButton;
        private System.Windows.Forms.RadioButton celsiusRadioButton;
    }
}