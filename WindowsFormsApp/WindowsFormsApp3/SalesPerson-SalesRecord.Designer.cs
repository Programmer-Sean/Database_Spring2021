namespace WindowsFormsApp3
{
    partial class Form3
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
            this.SalesRecord = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GetList = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesRecord
            // 
            this.SalesRecord.FormattingEnabled = true;
            this.SalesRecord.Location = new System.Drawing.Point(12, 12);
            this.SalesRecord.Name = "SalesRecord";
            this.SalesRecord.Size = new System.Drawing.Size(77, 381);
            this.SalesRecord.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetList
            // 
            this.GetList.Location = new System.Drawing.Point(233, 415);
            this.GetList.Name = "GetList";
            this.GetList.Size = new System.Drawing.Size(75, 23);
            this.GetList.TabIndex = 2;
            this.GetList.Text = "Get List";
            this.GetList.UseVisualStyleBackColor = true;
            this.GetList.Click += new System.EventHandler(this.GetList_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(164, 31);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(506, 305);
            this.dgv1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.GetList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SalesRecord);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SalesRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GetList;
        private System.Windows.Forms.DataGridView dgv1;
    }
}