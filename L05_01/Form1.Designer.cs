namespace L05_01
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.chkPowerWindows = new System.Windows.Forms.CheckBox();
            this.chkAirConditioning = new System.Windows.Forms.CheckBox();
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(75, 48);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(616, 170);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Choose from the\r\nfollowing options:";
            // 
            // chkPowerWindows
            // 
            this.chkPowerWindows.AutoSize = true;
            this.chkPowerWindows.Checked = true;
            this.chkPowerWindows.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkPowerWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPowerWindows.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkPowerWindows.Location = new System.Drawing.Point(106, 269);
            this.chkPowerWindows.Name = "chkPowerWindows";
            this.chkPowerWindows.Size = new System.Drawing.Size(318, 46);
            this.chkPowerWindows.TabIndex = 1;
            this.chkPowerWindows.Text = "Power Windows";
            this.chkPowerWindows.UseVisualStyleBackColor = true;
            // 
            // chkAirConditioning
            // 
            this.chkAirConditioning.AutoSize = true;
            this.chkAirConditioning.Checked = true;
            this.chkAirConditioning.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkAirConditioning.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAirConditioning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkAirConditioning.Location = new System.Drawing.Point(106, 342);
            this.chkAirConditioning.Name = "chkAirConditioning";
            this.chkAirConditioning.Size = new System.Drawing.Size(313, 46);
            this.chkAirConditioning.TabIndex = 2;
            this.chkAirConditioning.Text = "Air Conditioning";
            this.chkAirConditioning.UseVisualStyleBackColor = true;
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Checked = true;
            this.chkChrome.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChrome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkChrome.Location = new System.Drawing.Point(106, 418);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(182, 46);
            this.chkChrome.TabIndex = 3;
            this.chkChrome.Text = "Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(90, 509);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(388, 81);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOutput.Location = new System.Drawing.Point(564, 548);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(127, 42);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "(Price)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(773, 754);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkChrome);
            this.Controls.Add(this.chkAirConditioning);
            this.Controls.Add(this.chkPowerWindows);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "New Car Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.CheckBox chkPowerWindows;
        private System.Windows.Forms.CheckBox chkAirConditioning;
        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOutput;
    }
}

