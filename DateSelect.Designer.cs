namespace Blood_Bank_Manager {
    partial class DateSelect {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateSelect));
            this.title_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_tag_out = new System.Windows.Forms.Label();
            this.date_in = new System.Windows.Forms.DateTimePicker();
            this.select_date_button = new System.Windows.Forms.Button();
            this.current_date = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
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
            this.title_panel.Size = new System.Drawing.Size(372, 74);
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
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Date";
            // 
            // date_tag_out
            // 
            this.date_tag_out.AutoSize = true;
            this.date_tag_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_tag_out.Location = new System.Drawing.Point(134, 107);
            this.date_tag_out.Name = "date_tag_out";
            this.date_tag_out.Size = new System.Drawing.Size(88, 18);
            this.date_tag_out.TabIndex = 48;
            this.date_tag_out.Text = "Date of birth";
            this.date_tag_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_in
            // 
            this.date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.date_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_in.Location = new System.Drawing.Point(112, 137);
            this.date_in.Name = "date_in";
            this.date_in.Size = new System.Drawing.Size(137, 24);
            this.date_in.TabIndex = 47;
            // 
            // select_date_button
            // 
            this.select_date_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.select_date_button.FlatAppearance.BorderSize = 0;
            this.select_date_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_date_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_date_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.select_date_button.Location = new System.Drawing.Point(100, 179);
            this.select_date_button.Name = "select_date_button";
            this.select_date_button.Size = new System.Drawing.Size(163, 34);
            this.select_date_button.TabIndex = 49;
            this.select_date_button.Text = "Select Date";
            this.select_date_button.UseVisualStyleBackColor = false;
            this.select_date_button.Click += new System.EventHandler(this.select_date_button_Click);
            // 
            // current_date
            // 
            this.current_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.current_date.FlatAppearance.BorderSize = 0;
            this.current_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.current_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.current_date.Location = new System.Drawing.Point(100, 228);
            this.current_date.Name = "current_date";
            this.current_date.Size = new System.Drawing.Size(163, 34);
            this.current_date.TabIndex = 50;
            this.current_date.Text = "Use current date";
            this.current_date.UseVisualStyleBackColor = false;
            this.current_date.Click += new System.EventHandler(this.current_date_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(71)))));
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_button.Location = new System.Drawing.Point(100, 279);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(163, 34);
            this.cancel_button.TabIndex = 51;
            this.cancel_button.Text = "Cancel donation";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // DateSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 357);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.current_date);
            this.Controls.Add(this.select_date_button);
            this.Controls.Add(this.date_tag_out);
            this.Controls.Add(this.date_in);
            this.Controls.Add(this.title_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DateSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateSelect";
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
        private System.Windows.Forms.Label date_tag_out;
        private System.Windows.Forms.DateTimePicker date_in;
        private System.Windows.Forms.Button select_date_button;
        private System.Windows.Forms.Button current_date;
        private System.Windows.Forms.Button cancel_button;
    }
}