
namespace WindowsFormsApp3
{
    partial class SalesPerons_CarTools
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.AddCarBtn = new System.Windows.Forms.Button();
            this.MakeTB = new System.Windows.Forms.TextBox();
            this.ModelTB = new System.Windows.Forms.TextBox();
            this.ColorTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowCarsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColorBtn
            // 
            this.ColorBtn.Location = new System.Drawing.Point(673, 65);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(83, 25);
            this.ColorBtn.TabIndex = 2;
            this.ColorBtn.Text = "Add Color";
            this.ColorBtn.UseVisualStyleBackColor = true;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // AddCarBtn
            // 
            this.AddCarBtn.Location = new System.Drawing.Point(48, 65);
            this.AddCarBtn.Name = "AddCarBtn";
            this.AddCarBtn.Size = new System.Drawing.Size(438, 25);
            this.AddCarBtn.TabIndex = 3;
            this.AddCarBtn.Text = "Add Car";
            this.AddCarBtn.UseVisualStyleBackColor = true;
            this.AddCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // MakeTB
            // 
            this.MakeTB.Location = new System.Drawing.Point(78, 22);
            this.MakeTB.Name = "MakeTB";
            this.MakeTB.Size = new System.Drawing.Size(139, 20);
            this.MakeTB.TabIndex = 4;
            // 
            // ModelTB
            // 
            this.ModelTB.Location = new System.Drawing.Point(347, 22);
            this.ModelTB.Name = "ModelTB";
            this.ModelTB.Size = new System.Drawing.Size(139, 20);
            this.ModelTB.TabIndex = 5;
            // 
            // ColorTB
            // 
            this.ColorTB.Location = new System.Drawing.Point(617, 22);
            this.ColorTB.Name = "ColorTB";
            this.ColorTB.Size = new System.Drawing.Size(139, 20);
            this.ColorTB.TabIndex = 6;
            this.ColorTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add Color";
            // 
            // ShowCarsBtn
            // 
            this.ShowCarsBtn.Location = new System.Drawing.Point(288, 185);
            this.ShowCarsBtn.Name = "ShowCarsBtn";
            this.ShowCarsBtn.Size = new System.Drawing.Size(246, 49);
            this.ShowCarsBtn.TabIndex = 10;
            this.ShowCarsBtn.Text = "Show Tables";
            this.ShowCarsBtn.UseVisualStyleBackColor = true;
            this.ShowCarsBtn.Click += new System.EventHandler(this.ShowCarsBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(428, 240);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(360, 199);
            this.dataGridView2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(438, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Load From XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SalesPerons_CarTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowCarsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorTB);
            this.Controls.Add(this.ModelTB);
            this.Controls.Add(this.MakeTB);
            this.Controls.Add(this.AddCarBtn);
            this.Controls.Add(this.ColorBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SalesPerons_CarTools";
            this.Text = "SalesPerons_CarTools";
            this.Load += new System.EventHandler(this.SalesPerons_CarTools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.Button AddCarBtn;
        private System.Windows.Forms.TextBox MakeTB;
        private System.Windows.Forms.TextBox ModelTB;
        private System.Windows.Forms.TextBox ColorTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowCarsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
    }
}