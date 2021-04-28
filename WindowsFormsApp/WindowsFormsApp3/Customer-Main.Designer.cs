
namespace WindowsFormsApp3
{
    partial class CustomerMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.makeTxtBox = new System.Windows.Forms.ComboBox();
            this.modelTxtBox = new System.Windows.Forms.ComboBox();
            this.priceMinBox = new System.Windows.Forms.NumericUpDown();
            this.priceMaxBox = new System.Windows.Forms.NumericUpDown();
            this.colorTxtBox = new System.Windows.Forms.ComboBox();
            this.carLotTxtBox = new System.Windows.Forms.ComboBox();
            this.carMileage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.purchasehistoryBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.favouriteBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.ChangeLastNameTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.priceMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMaxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // makeTxtBox
            // 
            this.makeTxtBox.FormattingEnabled = true;
            this.makeTxtBox.Location = new System.Drawing.Point(12, 32);
            this.makeTxtBox.Name = "makeTxtBox";
            this.makeTxtBox.Size = new System.Drawing.Size(129, 21);
            this.makeTxtBox.TabIndex = 0;
            this.makeTxtBox.SelectedIndexChanged += new System.EventHandler(this.makeTxtBox_SelectedIndexChanged_1);
            // 
            // modelTxtBox
            // 
            this.modelTxtBox.FormattingEnabled = true;
            this.modelTxtBox.Location = new System.Drawing.Point(147, 32);
            this.modelTxtBox.Name = "modelTxtBox";
            this.modelTxtBox.Size = new System.Drawing.Size(121, 21);
            this.modelTxtBox.TabIndex = 1;
            this.modelTxtBox.SelectedIndexChanged += new System.EventHandler(this.modelTxtBox_SelectedIndexChanged_1);
            // 
            // priceMinBox
            // 
            this.priceMinBox.Location = new System.Drawing.Point(284, 32);
            this.priceMinBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceMinBox.Name = "priceMinBox";
            this.priceMinBox.Size = new System.Drawing.Size(78, 20);
            this.priceMinBox.TabIndex = 2;
            // 
            // priceMaxBox
            // 
            this.priceMaxBox.Location = new System.Drawing.Point(383, 32);
            this.priceMaxBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceMaxBox.Name = "priceMaxBox";
            this.priceMaxBox.Size = new System.Drawing.Size(80, 20);
            this.priceMaxBox.TabIndex = 3;
            // 
            // colorTxtBox
            // 
            this.colorTxtBox.FormattingEnabled = true;
            this.colorTxtBox.Location = new System.Drawing.Point(469, 31);
            this.colorTxtBox.Name = "colorTxtBox";
            this.colorTxtBox.Size = new System.Drawing.Size(108, 21);
            this.colorTxtBox.TabIndex = 4;
            // 
            // carLotTxtBox
            // 
            this.carLotTxtBox.FormattingEnabled = true;
            this.carLotTxtBox.Location = new System.Drawing.Point(583, 32);
            this.carLotTxtBox.Name = "carLotTxtBox";
            this.carLotTxtBox.Size = new System.Drawing.Size(97, 21);
            this.carLotTxtBox.TabIndex = 5;
            this.carLotTxtBox.SelectedIndexChanged += new System.EventHandler(this.carLotTxtBox_SelectedIndexChanged);
            // 
            // carMileage
            // 
            this.carMileage.Location = new System.Drawing.Point(705, 31);
            this.carMileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.carMileage.Name = "carMileage";
            this.carMileage.Size = new System.Drawing.Size(83, 20);
            this.carMileage.TabIndex = 6;
            this.carMileage.ValueChanged += new System.EventHandler(this.carMileage_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price(Min)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price(Max)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Car Lot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(702, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Car Mileage (Max)";
            // 
            // purchasehistoryBtn
            // 
            this.purchasehistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasehistoryBtn.Location = new System.Drawing.Point(293, 104);
            this.purchasehistoryBtn.Name = "purchasehistoryBtn";
            this.purchasehistoryBtn.Size = new System.Drawing.Size(176, 52);
            this.purchasehistoryBtn.TabIndex = 15;
            this.purchasehistoryBtn.Text = "Purchase History";
            this.purchasehistoryBtn.UseVisualStyleBackColor = true;
            this.purchasehistoryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(443, 189);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(301, 216);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // favouriteBtn
            // 
            this.favouriteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouriteBtn.Location = new System.Drawing.Point(506, 129);
            this.favouriteBtn.Name = "favouriteBtn";
            this.favouriteBtn.Size = new System.Drawing.Size(251, 43);
            this.favouriteBtn.TabIndex = 17;
            this.favouriteBtn.Text = "Favourite";
            this.favouriteBtn.UseVisualStyleBackColor = true;
            this.favouriteBtn.Click += new System.EventHandler(this.favouriteBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(357, 258);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 117);
            this.backBtn.TabIndex = 20;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // ChangeLastNameTB
            // 
            this.ChangeLastNameTB.Location = new System.Drawing.Point(16, 89);
            this.ChangeLastNameTB.Name = "ChangeLastNameTB";
            this.ChangeLastNameTB.Size = new System.Drawing.Size(135, 20);
            this.ChangeLastNameTB.TabIndex = 22;
            this.ChangeLastNameTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Change Last Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 63);
            this.button1.TabIndex = 25;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 203);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 27);
            this.button2.TabIndex = 28;
            this.button2.Text = "Favorite List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 478);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(738, 300);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 814);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChangeLastNameTB);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.favouriteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.purchasehistoryBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carMileage);
            this.Controls.Add(this.carLotTxtBox);
            this.Controls.Add(this.colorTxtBox);
            this.Controls.Add(this.priceMaxBox);
            this.Controls.Add(this.priceMinBox);
            this.Controls.Add(this.modelTxtBox);
            this.Controls.Add(this.makeTxtBox);
            this.Name = "CustomerMain";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.CustomerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMaxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox makeTxtBox;
        private System.Windows.Forms.ComboBox modelTxtBox;
        private System.Windows.Forms.NumericUpDown priceMinBox;
        private System.Windows.Forms.NumericUpDown priceMaxBox;
        private System.Windows.Forms.ComboBox colorTxtBox;
        private System.Windows.Forms.ComboBox carLotTxtBox;
        private System.Windows.Forms.NumericUpDown carMileage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button purchasehistoryBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button favouriteBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox ChangeLastNameTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}