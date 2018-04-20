namespace Blood_Bank_Manager {
    partial class SearchStockUC {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStockUC));
            this.bg_in = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bg_box = new System.Windows.Forms.CheckBox();
            this.used_show_box = new System.Windows.Forms.CheckBox();
            this.donor_id_in = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.donor_id_box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bg_in
            // 
            this.bg_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.bg_in.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bg_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg_in.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bg_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.bg_in.FormattingEnabled = true;
            this.bg_in.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bg_in.Location = new System.Drawing.Point(149, 201);
            this.bg_in.Name = "bg_in";
            this.bg_in.Size = new System.Drawing.Size(121, 28);
            this.bg_in.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Blood Group";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search_button.Location = new System.Drawing.Point(269, 294);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 51);
            this.search_button.TabIndex = 22;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.label9.Location = new System.Drawing.Point(25, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Search For blood in stock:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 127);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // bg_box
            // 
            this.bg_box.Appearance = System.Windows.Forms.Appearance.Button;
            this.bg_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.bg_box.FlatAppearance.BorderSize = 0;
            this.bg_box.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.bg_box.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.bg_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg_box.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bg_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bg_box.Location = new System.Drawing.Point(396, 199);
            this.bg_box.Name = "bg_box";
            this.bg_box.Size = new System.Drawing.Size(217, 30);
            this.bg_box.TabIndex = 61;
            this.bg_box.Text = "Search by blood group";
            this.bg_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bg_box.UseVisualStyleBackColor = false;
            // 
            // used_show_box
            // 
            this.used_show_box.Appearance = System.Windows.Forms.Appearance.Button;
            this.used_show_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.used_show_box.FlatAppearance.BorderSize = 0;
            this.used_show_box.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.used_show_box.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.used_show_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.used_show_box.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.used_show_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.used_show_box.Location = new System.Drawing.Point(396, 294);
            this.used_show_box.Name = "used_show_box";
            this.used_show_box.Size = new System.Drawing.Size(217, 30);
            this.used_show_box.TabIndex = 62;
            this.used_show_box.Text = "Show used blood bags also";
            this.used_show_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.used_show_box.UseVisualStyleBackColor = false;
            // 
            // donor_id_in
            // 
            this.donor_id_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.donor_id_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.donor_id_in.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donor_id_in.Location = new System.Drawing.Point(149, 251);
            this.donor_id_in.Name = "donor_id_in";
            this.donor_id_in.Size = new System.Drawing.Size(213, 19);
            this.donor_id_in.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Donor ID";
            // 
            // donor_id_box
            // 
            this.donor_id_box.Appearance = System.Windows.Forms.Appearance.Button;
            this.donor_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.donor_id_box.FlatAppearance.BorderSize = 0;
            this.donor_id_box.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.donor_id_box.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.donor_id_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donor_id_box.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donor_id_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.donor_id_box.Location = new System.Drawing.Point(396, 246);
            this.donor_id_box.Name = "donor_id_box";
            this.donor_id_box.Size = new System.Drawing.Size(217, 30);
            this.donor_id_box.TabIndex = 65;
            this.donor_id_box.Text = "Search by Donor ID";
            this.donor_id_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.donor_id_box.UseVisualStyleBackColor = false;
            // 
            // SearchStockUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.donor_id_box);
            this.Controls.Add(this.donor_id_in);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.used_show_box);
            this.Controls.Add(this.bg_box);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.bg_in);
            this.Controls.Add(this.label4);
            this.Name = "SearchStockUC";
            this.Size = new System.Drawing.Size(808, 529);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bg_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox bg_box;
        private System.Windows.Forms.CheckBox used_show_box;
        private System.Windows.Forms.TextBox donor_id_in;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox donor_id_box;
    }
}
