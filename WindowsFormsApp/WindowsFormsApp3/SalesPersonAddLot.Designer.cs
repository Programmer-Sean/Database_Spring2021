namespace WindowsFormsApp3
{
    partial class SalesPersonAddLot
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
            this.InsertLot = new System.Windows.Forms.Button();
            this.ViewLots = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.LotName = new System.Windows.Forms.Label();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.numBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertLot
            // 
            this.InsertLot.Location = new System.Drawing.Point(152, 243);
            this.InsertLot.Name = "InsertLot";
            this.InsertLot.Size = new System.Drawing.Size(113, 57);
            this.InsertLot.TabIndex = 0;
            this.InsertLot.Text = "Insert Lot";
            this.InsertLot.UseVisualStyleBackColor = true;
            this.InsertLot.Click += new System.EventHandler(this.InsertLot_Click);
            // 
            // ViewLots
            // 
            this.ViewLots.Location = new System.Drawing.Point(152, 370);
            this.ViewLots.Name = "ViewLots";
            this.ViewLots.Size = new System.Drawing.Size(113, 57);
            this.ViewLots.TabIndex = 1;
            this.ViewLots.Text = "View Lots";
            this.ViewLots.UseVisualStyleBackColor = true;
            this.ViewLots.Click += new System.EventHandler(this.ViewLots_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 2;
            // 
            // LotName
            // 
            this.LotName.AutoSize = true;
            this.LotName.Location = new System.Drawing.Point(43, 64);
            this.LotName.Name = "LotName";
            this.LotName.Size = new System.Drawing.Size(53, 13);
            this.LotName.TabIndex = 3;
            this.LotName.Text = "Lot Name";
            this.LotName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStName
            // 
            this.txtStName.Location = new System.Drawing.Point(119, 153);
            this.txtStName.Name = "txtStName";
            this.txtStName.Size = new System.Drawing.Size(167, 20);
            this.txtStName.TabIndex = 5;
            this.txtStName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(119, 200);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(167, 20);
            this.txtCityName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lot Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lot Street Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "City";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(292, 49);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(546, 378);
            this.dgv1.TabIndex = 10;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 404);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(119, 105);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(167, 20);
            this.numBox.TabIndex = 13;
            // 
            // SalesPersonAddLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.txtStName);
            this.Controls.Add(this.LotName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ViewLots);
            this.Controls.Add(this.InsertLot);
            this.Name = "SalesPersonAddLot";
            this.Text = "SalesPersonAddLot";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertLot;
        private System.Windows.Forms.Button ViewLots;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label LotName;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox numBox;
    }
}