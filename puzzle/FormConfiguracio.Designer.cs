﻿namespace puzzle
{
    partial class FormConfiguracio
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
            this.numericUpDownMov = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introdueix el nombre de moviments màxims";
            // 
            // numericUpDownMov
            // 
            this.numericUpDownMov.Location = new System.Drawing.Point(225, 21);
            this.numericUpDownMov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMov.Name = "numericUpDownMov";
            this.numericUpDownMov.Size = new System.Drawing.Size(126, 20);
            this.numericUpDownMov.TabIndex = 1;
            this.numericUpDownMov.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormConfiguracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 61);
            this.Controls.Add(this.numericUpDownMov);
            this.Controls.Add(this.label1);
            this.Name = "FormConfiguracio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuració";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.avisarFormPropietario);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMov;
    }
}