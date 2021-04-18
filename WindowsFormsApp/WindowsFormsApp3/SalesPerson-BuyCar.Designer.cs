namespace WindowsFormsApp3
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
            System.Windows.Forms.Label dsa;
            System.Windows.Forms.Label label11;
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.dealerTxtBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modelTxtBox = new System.Windows.Forms.ComboBox();
            this.makeTxtBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.customerTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salespersonTxtBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GetCars = new System.Windows.Forms.Button();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.MileageTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PictureTB = new System.Windows.Forms.TextBox();
            this.VinTB = new System.Windows.Forms.TextBox();
            this.LotIDBtn = new System.Windows.Forms.Button();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.LotFilterTB = new System.Windows.Forms.ComboBox();
            dsa = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(699, 66);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(373, 123);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // dealerTxtBox
            // 
            this.dealerTxtBox.FormattingEnabled = true;
            this.dealerTxtBox.Location = new System.Drawing.Point(138, 24);
            this.dealerTxtBox.Name = "dealerTxtBox";
            this.dealerTxtBox.Size = new System.Drawing.Size(121, 21);
            this.dealerTxtBox.TabIndex = 2;
            this.dealerTxtBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lot";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // modelTxtBox
            // 
            this.modelTxtBox.FormattingEnabled = true;
            this.modelTxtBox.Location = new System.Drawing.Point(307, 73);
            this.modelTxtBox.Name = "modelTxtBox";
            this.modelTxtBox.Size = new System.Drawing.Size(146, 21);
            this.modelTxtBox.TabIndex = 6;
            // 
            // makeTxtBox
            // 
            this.makeTxtBox.FormattingEnabled = true;
            this.makeTxtBox.Location = new System.Drawing.Point(138, 72);
            this.makeTxtBox.Name = "makeTxtBox";
            this.makeTxtBox.Size = new System.Drawing.Size(121, 21);
            this.makeTxtBox.TabIndex = 7;
            this.makeTxtBox.SelectedIndexChanged += new System.EventHandler(this.makeTxtBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Make";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Year";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(494, 72);
            this.yearBox.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(46, 20);
            this.yearBox.TabIndex = 12;
            this.yearBox.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.yearBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Color";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(699, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(373, 152);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(698, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Buy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // customerTxtBox
            // 
            this.customerTxtBox.Location = new System.Drawing.Point(613, 263);
            this.customerTxtBox.Name = "customerTxtBox";
            this.customerTxtBox.Size = new System.Drawing.Size(160, 20);
            this.customerTxtBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer Name";
            // 
            // salespersonTxtBox
            // 
            this.salespersonTxtBox.FormattingEnabled = true;
            this.salespersonTxtBox.Location = new System.Drawing.Point(613, 233);
            this.salespersonTxtBox.Name = "salespersonTxtBox";
            this.salespersonTxtBox.Size = new System.Drawing.Size(160, 21);
            this.salespersonTxtBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Salesperson";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(373, 181);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 23;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(613, 292);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(160, 20);
            this.priceTxtBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Price Sold";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 263);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GetCars
            // 
            this.GetCars.Location = new System.Drawing.Point(373, 281);
            this.GetCars.Name = "GetCars";
            this.GetCars.Size = new System.Drawing.Size(75, 23);
            this.GetCars.TabIndex = 27;
            this.GetCars.Text = "Get Cars";
            this.GetCars.UseVisualStyleBackColor = true;
            this.GetCars.Click += new System.EventHandler(this.GetCars_Click);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(592, 68);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(101, 21);
            this.ColorComboBox.TabIndex = 28;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(266, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Mileage";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // MileageTB
            // 
            this.MileageTB.Location = new System.Drawing.Point(307, 24);
            this.MileageTB.Name = "MileageTB";
            this.MileageTB.Size = new System.Drawing.Size(146, 20);
            this.MileageTB.TabIndex = 30;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(509, 24);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(146, 20);
            this.PriceTB.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(472, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Price";
            // 
            // PictureTB
            // 
            this.PictureTB.Location = new System.Drawing.Point(547, 123);
            this.PictureTB.Name = "PictureTB";
            this.PictureTB.Size = new System.Drawing.Size(146, 20);
            this.PictureTB.TabIndex = 33;
            // 
            // dsa
            // 
            dsa.AutoEllipsis = true;
            dsa.AutoSize = true;
            dsa.Location = new System.Drawing.Point(472, 126);
            dsa.Name = "dsa";
            dsa.Size = new System.Drawing.Size(63, 13);
            dsa.TabIndex = 34;
            dsa.Text = "Picture Link";
            // 
            // VinTB
            // 
            this.VinTB.Location = new System.Drawing.Point(547, 155);
            this.VinTB.Name = "VinTB";
            this.VinTB.Size = new System.Drawing.Size(146, 20);
            this.VinTB.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoEllipsis = true;
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(491, 162);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(28, 13);
            label11.TabIndex = 36;
            label11.Text = "VIN ";
            // 
            // LotIDBtn
            // 
            this.LotIDBtn.Location = new System.Drawing.Point(373, 310);
            this.LotIDBtn.Name = "LotIDBtn";
            this.LotIDBtn.Size = new System.Drawing.Size(75, 23);
            this.LotIDBtn.TabIndex = 37;
            this.LotIDBtn.Text = "Get LotID";
            this.LotIDBtn.UseVisualStyleBackColor = true;
            this.LotIDBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(373, 361);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(62, 13);
            this.FilterLabel.TabIndex = 39;
            this.FilterLabel.Text = "Lot Number";
            // 
            // LotFilterTB
            // 
            this.LotFilterTB.FormattingEnabled = true;
            this.LotFilterTB.Location = new System.Drawing.Point(441, 358);
            this.LotFilterTB.Name = "LotFilterTB";
            this.LotFilterTB.Size = new System.Drawing.Size(72, 21);
            this.LotFilterTB.TabIndex = 40;
            this.LotFilterTB.SelectedIndexChanged += new System.EventHandler(this.LotFilterTB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.LotFilterTB);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.LotIDBtn);
            this.Controls.Add(label11);
            this.Controls.Add(this.VinTB);
            this.Controls.Add(dsa);
            this.Controls.Add(this.PictureTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.MileageTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.GetCars);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salespersonTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerTxtBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.makeTxtBox);
            this.Controls.Add(this.modelTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealerTxtBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ComboBox dealerTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modelTxtBox;
        private System.Windows.Forms.ComboBox makeTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown yearBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox customerTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox salespersonTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetCars;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MileageTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PictureTB;
        private System.Windows.Forms.TextBox VinTB;
        private System.Windows.Forms.Button LotIDBtn;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.ComboBox LotFilterTB;
    }
}

