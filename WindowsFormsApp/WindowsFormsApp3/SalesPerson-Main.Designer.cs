﻿namespace WindowsFormsApp3
{
    partial class SalesPersonMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.addLot = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sales Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 105);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buy Car";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(585, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 105);
            this.button3.TabIndex = 2;
            this.button3.Text = "Potential Sales";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sales Person Main Menu";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 10);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(139, 72);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // addLot
            // 
            this.addLot.Location = new System.Drawing.Point(585, 208);
            this.addLot.Name = "addLot";
            this.addLot.Size = new System.Drawing.Size(180, 83);
            this.addLot.TabIndex = 5;
            this.addLot.Text = "Add Lot";
            this.addLot.UseVisualStyleBackColor = true;
            this.addLot.Click += new System.EventHandler(this.addLot_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 83);
            this.button4.TabIndex = 6;
            this.button4.Text = "Car Tools";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SalesPersonMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addLot);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SalesPersonMain";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button addLot;
        private System.Windows.Forms.Button button4;
    }
}