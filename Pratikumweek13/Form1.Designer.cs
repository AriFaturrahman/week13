﻿namespace Pratikumweek13
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxobjek = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.labelubah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Data :";
            // 
            // textBoxobjek
            // 
            this.textBoxobjek.Location = new System.Drawing.Point(30, 41);
            this.textBoxobjek.Name = "textBoxobjek";
            this.textBoxobjek.Size = new System.Drawing.Size(185, 20);
            this.textBoxobjek.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(30, 93);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "Proses";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelubah
            // 
            this.labelubah.AutoSize = true;
            this.labelubah.Location = new System.Drawing.Point(27, 163);
            this.labelubah.Name = "labelubah";
            this.labelubah.Size = new System.Drawing.Size(50, 13);
            this.labelubah.TabIndex = 3;
            this.labelubah.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelubah);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxobjek);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxobjek;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelubah;
    }
}

