namespace IRF_project
{
    partial class fociUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.export_btn = new System.Windows.Forms.Button();
            this.load_data_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.eredmeny_lbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 431);
            this.dataGridView1.TabIndex = 1;
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(53, 87);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(169, 24);
            this.export_btn.TabIndex = 5;
            this.export_btn.Text = "Exportálás csv-be";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // load_data_btn
            // 
            this.load_data_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.load_data_btn.FlatAppearance.BorderSize = 0;
            this.load_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_data_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_data_btn.Location = new System.Drawing.Point(53, 25);
            this.load_data_btn.Name = "load_data_btn";
            this.load_data_btn.Size = new System.Drawing.Size(169, 34);
            this.load_data_btn.TabIndex = 4;
            this.load_data_btn.Text = "Adatok betöltése";
            this.load_data_btn.UseVisualStyleBackColor = false;
            this.load_data_btn.Click += new System.EventHandler(this.load_data_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(53, 183);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(169, 24);
            this.load_btn.TabIndex = 6;
            this.load_btn.Text = "Betöltés";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // eredmeny_lbl
            // 
            this.eredmeny_lbl.AutoSize = true;
            this.eredmeny_lbl.Location = new System.Drawing.Point(50, 145);
            this.eredmeny_lbl.Name = "eredmeny_lbl";
            this.eredmeny_lbl.Size = new System.Drawing.Size(54, 13);
            this.eredmeny_lbl.TabIndex = 7;
            this.eredmeny_lbl.Text = "Eredmény";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // fociUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.eredmeny_lbl);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.load_data_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fociUC";
            this.Size = new System.Drawing.Size(799, 456);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Button load_data_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Label eredmeny_lbl;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
