namespace Blood_Bank_Manager {
    partial class ConfirmForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmForm));
            this.title_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dialog_out = new System.Windows.Forms.Label();
            this.yes_button = new System.Windows.Forms.Button();
            this.no_button = new System.Windows.Forms.Button();
            this.title_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.title_panel.Controls.Add(this.pictureBox1);
            this.title_panel.Controls.Add(this.label1);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(356, 74);
            this.title_panel.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm?";
            // 
            // dialog_out
            // 
            this.dialog_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialog_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialog_out.Location = new System.Drawing.Point(0, 74);
            this.dialog_out.Name = "dialog_out";
            this.dialog_out.Size = new System.Drawing.Size(356, 53);
            this.dialog_out.TabIndex = 49;
            this.dialog_out.Text = "Date of birth";
            this.dialog_out.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // yes_button
            // 
            this.yes_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(102)))), ((int)(((byte)(169)))));
            this.yes_button.FlatAppearance.BorderSize = 0;
            this.yes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yes_button.Location = new System.Drawing.Point(67, 158);
            this.yes_button.Margin = new System.Windows.Forms.Padding(5);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(100, 36);
            this.yes_button.TabIndex = 58;
            this.yes_button.Text = "Yes";
            this.yes_button.UseVisualStyleBackColor = false;
            this.yes_button.Click += new System.EventHandler(this.yes_button_Click);
            // 
            // no_button
            // 
            this.no_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(102)))), ((int)(((byte)(169)))));
            this.no_button.FlatAppearance.BorderSize = 0;
            this.no_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no_button.Location = new System.Drawing.Point(186, 158);
            this.no_button.Margin = new System.Windows.Forms.Padding(5);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(100, 36);
            this.no_button.TabIndex = 59;
            this.no_button.Text = "No";
            this.no_button.UseVisualStyleBackColor = false;
            this.no_button.Click += new System.EventHandler(this.no_button_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 230);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.yes_button);
            this.Controls.Add(this.dialog_out);
            this.Controls.Add(this.title_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmForm";
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dialog_out;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Button no_button;
    }
}