namespace Blood_Bank_Manager {
    partial class StockInfoForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInfoForm));
            this.title_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.use_button = new System.Windows.Forms.Button();
            this.date_collection_out = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.donor_name_out = new System.Windows.Forms.Label();
            this.used_out = new System.Windows.Forms.Label();
            this.donor_id_out = new System.Windows.Forms.Label();
            this.stock_id_out = new System.Windows.Forms.Label();
            this.bg_out = new System.Windows.Forms.Label();
            this.donor_info_button = new System.Windows.Forms.Button();
            this.title_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.title_panel.Controls.Add(this.pictureBox1);
            this.title_panel.Controls.Add(this.label1);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(581, 74);
            this.title_panel.TabIndex = 2;
            this.title_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseDown);
            this.title_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseMove);
            this.title_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 51);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Bag Information";
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(102)))), ((int)(((byte)(169)))));
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close_button.Location = new System.Drawing.Point(12, 366);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(100, 51);
            this.close_button.TabIndex = 31;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.remove_button.FlatAppearance.BorderSize = 0;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.remove_button.Location = new System.Drawing.Point(300, 366);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(100, 51);
            this.remove_button.TabIndex = 30;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // use_button
            // 
            this.use_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.use_button.FlatAppearance.BorderSize = 0;
            this.use_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.use_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.use_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.use_button.Location = new System.Drawing.Point(406, 366);
            this.use_button.Name = "use_button";
            this.use_button.Size = new System.Drawing.Size(163, 51);
            this.use_button.TabIndex = 29;
            this.use_button.Text = "Use Blood Bag";
            this.use_button.UseVisualStyleBackColor = false;
            this.use_button.Click += new System.EventHandler(this.use_button_Click);
            // 
            // date_collection_out
            // 
            this.date_collection_out.AutoSize = true;
            this.date_collection_out.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_collection_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.date_collection_out.Location = new System.Drawing.Point(183, 293);
            this.date_collection_out.Name = "date_collection_out";
            this.date_collection_out.Size = new System.Drawing.Size(52, 18);
            this.date_collection_out.TabIndex = 33;
            this.date_collection_out.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Blood Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Stock Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Donor ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Donor Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Date of collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Bag used?";
            // 
            // donor_name_out
            // 
            this.donor_name_out.AutoSize = true;
            this.donor_name_out.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donor_name_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.donor_name_out.Location = new System.Drawing.Point(183, 213);
            this.donor_name_out.Name = "donor_name_out";
            this.donor_name_out.Size = new System.Drawing.Size(52, 18);
            this.donor_name_out.TabIndex = 42;
            this.donor_name_out.Text = "Value";
            // 
            // used_out
            // 
            this.used_out.AutoSize = true;
            this.used_out.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.used_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.used_out.Location = new System.Drawing.Point(183, 326);
            this.used_out.Name = "used_out";
            this.used_out.Size = new System.Drawing.Size(52, 18);
            this.used_out.TabIndex = 43;
            this.used_out.Text = "Value";
            // 
            // donor_id_out
            // 
            this.donor_id_out.AutoSize = true;
            this.donor_id_out.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donor_id_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.donor_id_out.Location = new System.Drawing.Point(183, 176);
            this.donor_id_out.Name = "donor_id_out";
            this.donor_id_out.Size = new System.Drawing.Size(52, 18);
            this.donor_id_out.TabIndex = 44;
            this.donor_id_out.Text = "Value";
            // 
            // stock_id_out
            // 
            this.stock_id_out.AutoSize = true;
            this.stock_id_out.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_id_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.stock_id_out.Location = new System.Drawing.Point(183, 140);
            this.stock_id_out.Name = "stock_id_out";
            this.stock_id_out.Size = new System.Drawing.Size(52, 18);
            this.stock_id_out.TabIndex = 45;
            this.stock_id_out.Text = "Value";
            // 
            // bg_out
            // 
            this.bg_out.AutoSize = true;
            this.bg_out.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bg_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.bg_out.Location = new System.Drawing.Point(182, 99);
            this.bg_out.Name = "bg_out";
            this.bg_out.Size = new System.Drawing.Size(64, 23);
            this.bg_out.TabIndex = 46;
            this.bg_out.Text = "Value";
            // 
            // donor_info_button
            // 
            this.donor_info_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.donor_info_button.FlatAppearance.BorderSize = 0;
            this.donor_info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donor_info_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donor_info_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.donor_info_button.Location = new System.Drawing.Point(186, 245);
            this.donor_info_button.Name = "donor_info_button";
            this.donor_info_button.Size = new System.Drawing.Size(214, 30);
            this.donor_info_button.TabIndex = 47;
            this.donor_info_button.Text = "Show donor info in details";
            this.donor_info_button.UseVisualStyleBackColor = false;
            this.donor_info_button.Click += new System.EventHandler(this.donor_info_button_Click);
            // 
            // StockInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 429);
            this.Controls.Add(this.donor_info_button);
            this.Controls.Add(this.bg_out);
            this.Controls.Add(this.stock_id_out);
            this.Controls.Add(this.donor_id_out);
            this.Controls.Add(this.used_out);
            this.Controls.Add(this.donor_name_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_collection_out);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.use_button);
            this.Controls.Add(this.title_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockInfoForm";
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button use_button;
        private System.Windows.Forms.Label date_collection_out;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label donor_name_out;
        private System.Windows.Forms.Label used_out;
        private System.Windows.Forms.Label donor_id_out;
        private System.Windows.Forms.Label stock_id_out;
        private System.Windows.Forms.Label bg_out;
        private System.Windows.Forms.Button donor_info_button;
    }
}