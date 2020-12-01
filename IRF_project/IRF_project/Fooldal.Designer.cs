namespace IRF_project
{
    partial class Fooldal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fooldal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labdarugas_btn = new System.Windows.Forms.Button();
            this.tenisz_btn = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fo_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labdarugas_btn);
            this.panel1.Controls.Add(this.tenisz_btn);
            this.panel1.Controls.Add(this.Clock);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // labdarugas_btn
            // 
            this.labdarugas_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labdarugas_btn.FlatAppearance.BorderSize = 0;
            this.labdarugas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labdarugas_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdarugas_btn.ForeColor = System.Drawing.Color.White;
            this.labdarugas_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labdarugas_btn.Location = new System.Drawing.Point(0, 281);
            this.labdarugas_btn.Name = "labdarugas_btn";
            this.labdarugas_btn.Size = new System.Drawing.Size(200, 52);
            this.labdarugas_btn.TabIndex = 6;
            this.labdarugas_btn.Text = "Labdarúgás";
            this.labdarugas_btn.UseVisualStyleBackColor = false;
            this.labdarugas_btn.Click += new System.EventHandler(this.labdarugas_btn_Click_1);
            // 
            // tenisz_btn
            // 
            this.tenisz_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tenisz_btn.FlatAppearance.BorderSize = 0;
            this.tenisz_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenisz_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenisz_btn.ForeColor = System.Drawing.Color.White;
            this.tenisz_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tenisz_btn.Location = new System.Drawing.Point(0, 172);
            this.tenisz_btn.Name = "tenisz_btn";
            this.tenisz_btn.Size = new System.Drawing.Size(200, 52);
            this.tenisz_btn.TabIndex = 5;
            this.tenisz_btn.Text = "Tenisz";
            this.tenisz_btn.UseVisualStyleBackColor = false;
            this.tenisz_btn.Click += new System.EventHandler(this.Labdarugas_btn_Click);
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.White;
            this.Clock.Location = new System.Drawing.Point(21, 9);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(164, 42);
            this.Clock.TabIndex = 4;
            this.Clock.Text = "00:00:00";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Red;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.Location = new System.Drawing.Point(0, 548);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(200, 52);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Kilépés";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 11);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 62.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 99);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sport Explorer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(274, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 136);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fo_panel
            // 
            this.fo_panel.Location = new System.Drawing.Point(200, 143);
            this.fo_panel.Name = "fo_panel";
            this.fo_panel.Size = new System.Drawing.Size(799, 456);
            this.fo_panel.TabIndex = 4;
            // 
            // Fooldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.fo_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fooldal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Button labdarugas_btn;
        private System.Windows.Forms.Button tenisz_btn;
        private System.Windows.Forms.Panel fo_panel;
    }
}

