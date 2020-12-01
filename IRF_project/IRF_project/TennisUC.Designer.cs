namespace IRF_project
{
    partial class TennisUC
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
            this.load_data_btn = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // load_data_btn
            // 
            this.load_data_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.load_data_btn.FlatAppearance.BorderSize = 0;
            this.load_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_data_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_data_btn.Location = new System.Drawing.Point(248, 22);
            this.load_data_btn.Name = "load_data_btn";
            this.load_data_btn.Size = new System.Drawing.Size(169, 34);
            this.load_data_btn.TabIndex = 2;
            this.load_data_btn.Text = "Adatok betöltése";
            this.load_data_btn.UseVisualStyleBackColor = false;
            this.load_data_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(248, 84);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(169, 24);
            this.export_btn.TabIndex = 3;
            this.export_btn.Text = "Exportálás csv-be";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // TennisUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.load_data_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TennisUC";
            this.Size = new System.Drawing.Size(799, 456);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button load_data_btn;
        private System.Windows.Forms.Button export_btn;
    }
}
