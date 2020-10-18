namespace OOP_new
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.delete = new System.Windows.Forms.Button();
            this.CustomerTable = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fstnamebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agebox = new System.Windows.Forms.TextBox();
            this.citybox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstnamebox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.delete.ForeColor = System.Drawing.SystemColors.MenuText;
            this.delete.Location = new System.Drawing.Point(373, 167);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(91, 36);
            this.delete.TabIndex = 0;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerTable
            // 
            this.CustomerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerTable.Location = new System.Drawing.Point(54, 208);
            this.CustomerTable.Name = "CustomerTable";
            this.CustomerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerTable.Size = new System.Drawing.Size(591, 211);
            this.CustomerTable.TabIndex = 1;
            this.CustomerTable.Text = "dataGridView1";
            this.CustomerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerTable_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(555, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button3.Location = new System.Drawing.Point(199, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.insert.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.insert.ForeColor = System.Drawing.SystemColors.MenuText;
            this.insert.Location = new System.Drawing.Point(54, 167);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(91, 36);
            this.insert.TabIndex = 0;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.button4_Click);
            // 
            // idbox
            // 
            this.idbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.idbox.Enabled = false;
            this.idbox.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.idbox.Location = new System.Drawing.Point(146, 29);
            this.idbox.Name = "idbox";
            this.idbox.ReadOnly = true;
            this.idbox.Size = new System.Drawing.Size(52, 31);
            this.idbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fstnamebox
            // 
            this.fstnamebox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fstnamebox.Location = new System.Drawing.Point(367, 27);
            this.fstnamebox.Name = "fstnamebox";
            this.fstnamebox.Size = new System.Drawing.Size(112, 27);
            this.fstnamebox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(220, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(134, 86);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(52, 20);
            this.agebox.TabIndex = 2;
            // 
            // citybox
            // 
            this.citybox.Location = new System.Drawing.Point(353, 86);
            this.citybox.Name = "citybox";
            this.citybox.Size = new System.Drawing.Size(127, 20);
            this.citybox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(300, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "City";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(87, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstnamebox
            // 
            this.lstnamebox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstnamebox.Location = new System.Drawing.Point(479, 27);
            this.lstnamebox.Name = "lstnamebox";
            this.lstnamebox.Size = new System.Drawing.Size(112, 27);
            this.lstnamebox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 448);
            this.Controls.Add(this.lstnamebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.citybox);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fstnamebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CustomerTable);
            this.Controls.Add(this.delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView CustomerTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fstnamebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox agebox;
        private System.Windows.Forms.TextBox citybox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lstnamebox;
    }
}

