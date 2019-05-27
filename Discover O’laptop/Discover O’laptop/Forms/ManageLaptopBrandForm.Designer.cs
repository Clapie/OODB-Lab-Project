namespace Discover_O_laptop.Forms
{
    partial class ManageLaptopBrandForm
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
            this.LaptopBrandGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brandNameText = new System.Windows.Forms.TextBox();
            this.brandIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopBrandGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LaptopBrandGrid
            // 
            this.LaptopBrandGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaptopBrandGrid.Location = new System.Drawing.Point(37, 26);
            this.LaptopBrandGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LaptopBrandGrid.Name = "LaptopBrandGrid";
            this.LaptopBrandGrid.RowTemplate.Height = 24;
            this.LaptopBrandGrid.Size = new System.Drawing.Size(468, 207);
            this.LaptopBrandGrid.TabIndex = 0;
            this.LaptopBrandGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LaptopBrandGrid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brandNameText);
            this.groupBox1.Controls.Add(this.brandIdText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(467, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brand Details";
            // 
            // brandNameText
            // 
            this.brandNameText.Location = new System.Drawing.Point(189, 82);
            this.brandNameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandNameText.Name = "brandNameText";
            this.brandNameText.Size = new System.Drawing.Size(173, 22);
            this.brandNameText.TabIndex = 3;
            // 
            // brandIdText
            // 
            this.brandIdText.Location = new System.Drawing.Point(189, 34);
            this.brandIdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandIdText.Name = "brandIdText";
            this.brandIdText.Size = new System.Drawing.Size(173, 22);
            this.brandIdText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.insertButton);
            this.groupBox2.Location = new System.Drawing.Point(41, 393);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(464, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(316, 21);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 37);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(172, 21);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 37);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(29, 21);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(120, 37);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cancelButton);
            this.groupBox3.Controls.Add(this.saveButton);
            this.groupBox3.Location = new System.Drawing.Point(41, 475);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(465, 71);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirmation";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(251, 21);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 37);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(95, 21);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 37);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ManageLaptopBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 570);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LaptopBrandGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageLaptopBrandForm";
            this.Text = "Manage Laptop Brand Form";
            ((System.ComponentModel.ISupportInitialize)(this.LaptopBrandGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LaptopBrandGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox brandNameText;
        private System.Windows.Forms.TextBox brandIdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}