namespace Discover_O_laptop.Forms
{
    partial class ManageLaptopForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laptopRAM = new System.Windows.Forms.NumericUpDown();
            this.laptopBrandBox = new System.Windows.Forms.ComboBox();
            this.laptopPriceText = new System.Windows.Forms.TextBox();
            this.laptopVGAText = new System.Windows.Forms.TextBox();
            this.laptopSizeText = new System.Windows.Forms.TextBox();
            this.laptopNameText = new System.Windows.Forms.TextBox();
            this.laptopIdText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laptopRAM)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(519, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.laptopRAM);
            this.groupBox1.Controls.Add(this.laptopBrandBox);
            this.groupBox1.Controls.Add(this.laptopPriceText);
            this.groupBox1.Controls.Add(this.laptopVGAText);
            this.groupBox1.Controls.Add(this.laptopSizeText);
            this.groupBox1.Controls.Add(this.laptopNameText);
            this.groupBox1.Controls.Add(this.laptopIdText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(297, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laptop Details";
            // 
            // laptopRAM
            // 
            this.laptopRAM.Location = new System.Drawing.Point(144, 228);
            this.laptopRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laptopRAM.Name = "laptopRAM";
            this.laptopRAM.Size = new System.Drawing.Size(135, 22);
            this.laptopRAM.TabIndex = 15;
            // 
            // laptopBrandBox
            // 
            this.laptopBrandBox.FormattingEnabled = true;
            this.laptopBrandBox.Location = new System.Drawing.Point(144, 106);
            this.laptopBrandBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laptopBrandBox.Name = "laptopBrandBox";
            this.laptopBrandBox.Size = new System.Drawing.Size(135, 24);
            this.laptopBrandBox.TabIndex = 14;
            // 
            // laptopPriceText
            // 
            this.laptopPriceText.Location = new System.Drawing.Point(144, 270);
            this.laptopPriceText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laptopPriceText.Name = "laptopPriceText";
            this.laptopPriceText.Size = new System.Drawing.Size(135, 22);
            this.laptopPriceText.TabIndex = 13;
            // 
            // laptopVGAText
            // 
            this.laptopVGAText.Location = new System.Drawing.Point(144, 186);
            this.laptopVGAText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laptopVGAText.Name = "laptopVGAText";
            this.laptopVGAText.Size = new System.Drawing.Size(135, 22);
            this.laptopVGAText.TabIndex = 11;
            // 
            // laptopSizeText
            // 
            this.laptopSizeText.Location = new System.Drawing.Point(144, 146);
            this.laptopSizeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laptopSizeText.Name = "laptopSizeText";
            this.laptopSizeText.Size = new System.Drawing.Size(135, 22);
            this.laptopSizeText.TabIndex = 10;
            // 
            // laptopNameText
            // 
            this.laptopNameText.Location = new System.Drawing.Point(144, 68);
            this.laptopNameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laptopNameText.Name = "laptopNameText";
            this.laptopNameText.Size = new System.Drawing.Size(135, 22);
            this.laptopNameText.TabIndex = 8;
            // 
            // laptopIdText
            // 
            this.laptopIdText.Location = new System.Drawing.Point(144, 31);
            this.laptopIdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laptopIdText.Name = "laptopIdText";
            this.laptopIdText.Size = new System.Drawing.Size(135, 22);
            this.laptopIdText.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "LaptopRAM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "LaptopPrice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "LaptopVGA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "LaptopSize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "LaptopBrand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "LaptopName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LaptopID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(352, 222);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(203, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 103);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(352, 393);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(203, 144);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirmation";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(45, 82);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 37);
            this.button5.TabIndex = 11;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 30);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ManageLaptopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageLaptopForm";
            this.Text = "Manage Laptop Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laptopRAM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown laptopRAM;
        private System.Windows.Forms.ComboBox laptopBrandBox;
        private System.Windows.Forms.TextBox laptopPriceText;
        private System.Windows.Forms.TextBox laptopVGAText;
        private System.Windows.Forms.TextBox laptopSizeText;
        private System.Windows.Forms.TextBox laptopNameText;
        private System.Windows.Forms.TextBox laptopIdText;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}