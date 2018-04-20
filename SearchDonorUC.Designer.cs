namespace Blood_Bank_Manager {
    partial class SearchDonorUC {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDonorUC));
            this.label1 = new System.Windows.Forms.Label();
            this.name_in = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bg_in = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.area_in = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_box = new System.Windows.Forms.CheckBox();
            this.bg_box = new System.Windows.Forms.CheckBox();
            this.area_box = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.id_in = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.show_unavailable_box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // name_in
            // 
            this.name_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.name_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_in.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_in.Location = new System.Drawing.Point(149, 262);
            this.name_in.Name = "name_in";
            this.name_in.Size = new System.Drawing.Size(213, 19);
            this.name_in.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blood Group";
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
            this.bg_in.Location = new System.Drawing.Point(149, 317);
            this.bg_in.Name = "bg_in";
            this.bg_in.Size = new System.Drawing.Size(121, 28);
            this.bg_in.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Area";
            // 
            // area_in
            // 
            this.area_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.area_in.DropDownHeight = 300;
            this.area_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.area_in.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.area_in.FormattingEnabled = true;
            this.area_in.IntegralHeight = false;
            this.area_in.Items.AddRange(new object[] {
            "Adabor",
            "Agargaon",
            "Badda",
            "Biman Bandar",
            "Bangshal",
            "Cantonment",
            "Chawkbazar Model",
            "Dakshinkhan",
            "Darus Salam",
            "Dhanmondi",
            "Demra",
            "Kotwali",
            "Gendaria",
            "Gulshan",
            "Hazaribagh",
            "Jatrabari",
            "Kadamtali",
            "Kafrul",
            "Kalabagan",
            "Kamringir Char",
            "Khilkhet",
            "Khilgaon",
            "Lalbagh",
            "Mirpur",
            "Mohammadpur",
            "Motijheel",
            "New Market",
            "Pallabi",
            "Paltan",
            "Ramna",
            "Rampura",
            "Sabujbagh",
            "Shah Ali",
            "Shahbagh",
            "Sher-e-Bangla Nagor",
            "Shyampur",
            "Sutrapur",
            "Tejgaon",
            "Tejgaon Industrial Area",
            "Turag",
            "Uttar Khan",
            "Uttara"});
            this.area_in.Location = new System.Drawing.Point(149, 372);
            this.area_in.Name = "area_in";
            this.area_in.Size = new System.Drawing.Size(213, 28);
            this.area_in.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel1.Location = new System.Drawing.Point(383, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 201);
            this.panel1.TabIndex = 14;
            // 
            // name_box
            // 
            this.name_box.Appearance = System.Windows.Forms.Appearance.Button;
            this.name_box.AutoSize = true;
            this.name_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.name_box.FlatAppearance.BorderSize = 0;
            this.name_box.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.name_box.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.name_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_box.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.name_box.Location = new System.Drawing.Point(403, 257);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(90, 30);
            this.name_box.TabIndex = 15;
            this.name_box.Text = "use name";
            this.name_box.UseVisualStyleBackColor = false;
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
            this.bg_box.Location = new System.Drawing.Point(403, 315);
            this.bg_box.Name = "bg_box";
            this.bg_box.Size = new System.Drawing.Size(90, 30);
            this.bg_box.TabIndex = 16;
            this.bg_box.Text = "use BG";
            this.bg_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bg_box.UseVisualStyleBackColor = false;
            // 
            // area_box
            // 
            this.area_box.Appearance = System.Windows.Forms.Appearance.Button;
            this.area_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.area_box.FlatAppearance.BorderSize = 0;
            this.area_box.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.area_box.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.area_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.area_box.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.area_box.Location = new System.Drawing.Point(403, 370);
            this.area_box.Name = "area_box";
            this.area_box.Size = new System.Drawing.Size(90, 30);
            this.area_box.TabIndex = 17;
            this.area_box.Text = "use area";
            this.area_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.area_box.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(570, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Use the check boxes to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(570, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "narrow down your";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label7.Location = new System.Drawing.Point(570, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "search.";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search_button.Location = new System.Drawing.Point(284, 427);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 51);
            this.search_button.TabIndex = 21;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Donor ID";
            // 
            // id_in
            // 
            this.id_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.id_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_in.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_in.Location = new System.Drawing.Point(149, 204);
            this.id_in.Name = "id_in";
            this.id_in.Size = new System.Drawing.Size(213, 19);
            this.id_in.TabIndex = 23;
            // 
            // id_box
            // 
            this.id_box.Appearance = System.Windows.Forms.Appearance.Button;
            this.id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.id_box.FlatAppearance.BorderSize = 0;
            this.id_box.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.id_box.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.id_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_box.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.id_box.Location = new System.Drawing.Point(403, 199);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(90, 30);
            this.id_box.TabIndex = 24;
            this.id_box.Text = "use ID";
            this.id_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.id_box.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.label9.Location = new System.Drawing.Point(25, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Search For donors:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 127);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // show_unavailable_box
            // 
            this.show_unavailable_box.Appearance = System.Windows.Forms.Appearance.Button;
            this.show_unavailable_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.show_unavailable_box.FlatAppearance.BorderSize = 0;
            this.show_unavailable_box.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.show_unavailable_box.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.show_unavailable_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_unavailable_box.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_unavailable_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.show_unavailable_box.Location = new System.Drawing.Point(403, 427);
            this.show_unavailable_box.Name = "show_unavailable_box";
            this.show_unavailable_box.Size = new System.Drawing.Size(236, 30);
            this.show_unavailable_box.TabIndex = 60;
            this.show_unavailable_box.Text = "Show unavailable donors also";
            this.show_unavailable_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.show_unavailable_box.UseVisualStyleBackColor = false;
            // 
            // SearchDonorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.show_unavailable_box);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.id_in);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.area_box);
            this.Controls.Add(this.bg_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.area_in);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bg_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_in);
            this.Name = "SearchDonorUC";
            this.Size = new System.Drawing.Size(808, 529);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bg_in;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox area_in;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox name_box;
        private System.Windows.Forms.CheckBox bg_box;
        private System.Windows.Forms.CheckBox area_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id_in;
        private System.Windows.Forms.CheckBox id_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox show_unavailable_box;
    }
}
