namespace Blood_Bank_Manager {
    partial class DateRangeSearch {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.start_date_in = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.end_date_in = new System.Windows.Forms.DateTimePicker();
            this.donor_button = new System.Windows.Forms.Button();
            this.stock_button = new System.Windows.Forms.Button();
            this.stock_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.range_entries_out = new System.Windows.Forms.Label();
            this.big_label = new System.Windows.Forms.Label();
            this.small_label = new System.Windows.Forms.Label();
            this.show_search_button = new System.Windows.Forms.Button();
            this.fraction_entries_bar = new Blood_Bank_Manager.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.stock_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Starting date";
            // 
            // start_date_in
            // 
            this.start_date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.start_date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start_date_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_date_in.Location = new System.Drawing.Point(16, 294);
            this.start_date_in.Name = "start_date_in";
            this.start_date_in.Size = new System.Drawing.Size(137, 24);
            this.start_date_in.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ending date";
            // 
            // end_date_in
            // 
            this.end_date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.end_date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.end_date_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_date_in.Location = new System.Drawing.Point(16, 367);
            this.end_date_in.Name = "end_date_in";
            this.end_date_in.Size = new System.Drawing.Size(137, 24);
            this.end_date_in.TabIndex = 49;
            // 
            // donor_button
            // 
            this.donor_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.donor_button.FlatAppearance.BorderSize = 0;
            this.donor_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donor_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donor_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.donor_button.Location = new System.Drawing.Point(16, 416);
            this.donor_button.Name = "donor_button";
            this.donor_button.Size = new System.Drawing.Size(137, 27);
            this.donor_button.TabIndex = 51;
            this.donor_button.Text = "Donor Info";
            this.donor_button.UseVisualStyleBackColor = false;
            this.donor_button.Click += new System.EventHandler(this.donor_button_Click);
            // 
            // stock_button
            // 
            this.stock_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.stock_button.FlatAppearance.BorderSize = 0;
            this.stock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stock_button.Location = new System.Drawing.Point(16, 449);
            this.stock_button.Name = "stock_button";
            this.stock_button.Size = new System.Drawing.Size(137, 30);
            this.stock_button.TabIndex = 52;
            this.stock_button.Text = "Stock Info";
            this.stock_button.UseVisualStyleBackColor = false;
            this.stock_button.Click += new System.EventHandler(this.stock_button_Click);
            // 
            // stock_chart
            // 
            this.stock_chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.stock_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.stock_chart.Legends.Add(legend1);
            this.stock_chart.Location = new System.Drawing.Point(170, 181);
            this.stock_chart.Name = "stock_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Stock3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Stock";
            series2.YValuesPerPoint = 2;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Stock2";
            this.stock_chart.Series.Add(series1);
            this.stock_chart.Series.Add(series2);
            this.stock_chart.Series.Add(series3);
            this.stock_chart.Size = new System.Drawing.Size(624, 334);
            this.stock_chart.TabIndex = 53;
            this.stock_chart.Text = "Donor Statistics";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(651, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "Of total entries";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(487, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Entries in range";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // range_entries_out
            // 
            this.range_entries_out.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_entries_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(26)))), ((int)(((byte)(117)))));
            this.range_entries_out.Location = new System.Drawing.Point(483, 71);
            this.range_entries_out.Name = "range_entries_out";
            this.range_entries_out.Size = new System.Drawing.Size(166, 63);
            this.range_entries_out.TabIndex = 57;
            this.range_entries_out.Text = "306";
            this.range_entries_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.range_entries_out.Visible = false;
            // 
            // big_label
            // 
            this.big_label.AutoSize = true;
            this.big_label.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.big_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.big_label.Location = new System.Drawing.Point(10, 25);
            this.big_label.Margin = new System.Windows.Forms.Padding(10);
            this.big_label.Name = "big_label";
            this.big_label.Size = new System.Drawing.Size(190, 36);
            this.big_label.TabIndex = 59;
            this.big_label.Text = "Enter Range";
            // 
            // small_label
            // 
            this.small_label.AutoSize = true;
            this.small_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.small_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.small_label.Location = new System.Drawing.Point(15, 71);
            this.small_label.Name = "small_label";
            this.small_label.Size = new System.Drawing.Size(249, 20);
            this.small_label.TabIndex = 60;
            this.small_label.Text = "Enter range of dates and search.";
            this.small_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_search_button
            // 
            this.show_search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(120)))));
            this.show_search_button.FlatAppearance.BorderSize = 0;
            this.show_search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_search_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_search_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.show_search_button.Location = new System.Drawing.Point(16, 485);
            this.show_search_button.Name = "show_search_button";
            this.show_search_button.Size = new System.Drawing.Size(137, 30);
            this.show_search_button.TabIndex = 61;
            this.show_search_button.Text = "See all entries";
            this.show_search_button.UseVisualStyleBackColor = false;
            this.show_search_button.Visible = false;
            this.show_search_button.Click += new System.EventHandler(this.show_search_button_Click);
            // 
            // fraction_entries_bar
            // 
            this.fraction_entries_bar.BarWidth = 15;
            this.fraction_entries_bar.EmptyBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.fraction_entries_bar.Location = new System.Drawing.Point(655, 25);
            this.fraction_entries_bar.Name = "fraction_entries_bar";
            this.fraction_entries_bar.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(135)))), ((int)(((byte)(181)))));
            this.fraction_entries_bar.ProgressValue = 32;
            this.fraction_entries_bar.Size = new System.Drawing.Size(130, 130);
            this.fraction_entries_bar.StatusFont = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.fraction_entries_bar.StatusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(135)))), ((int)(((byte)(181)))));
            this.fraction_entries_bar.TabIndex = 54;
            this.fraction_entries_bar.Visible = false;
            // 
            // DateRangeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.show_search_button);
            this.Controls.Add(this.small_label);
            this.Controls.Add(this.big_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.range_entries_out);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fraction_entries_bar);
            this.Controls.Add(this.stock_chart);
            this.Controls.Add(this.stock_button);
            this.Controls.Add(this.donor_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end_date_in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.start_date_in);
            this.Name = "DateRangeSearch";
            this.Size = new System.Drawing.Size(808, 529);
            ((System.ComponentModel.ISupportInitialize)(this.stock_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker start_date_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker end_date_in;
        private System.Windows.Forms.Button donor_button;
        private System.Windows.Forms.Button stock_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart stock_chart;
        private System.Windows.Forms.Label label11;
        private CircularProgressBar fraction_entries_bar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label range_entries_out;
        private System.Windows.Forms.Label big_label;
        private System.Windows.Forms.Label small_label;
        private System.Windows.Forms.Button show_search_button;
    }
}
