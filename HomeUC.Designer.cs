namespace Blood_Bank_Manager {
    partial class HomeUC {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.donor_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.total_donor_out = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unused_stock_out = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.stock_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.monthly_new_stock_bar = new Blood_Bank_Manager.CircularProgressBar();
            this.monthly_new_donor_bar = new Blood_Bank_Manager.CircularProgressBar();
            this.donors_available_bar = new Blood_Bank_Manager.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.donor_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // donor_chart
            // 
            this.donor_chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.donor_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.donor_chart.Legends.Add(legend1);
            this.donor_chart.Location = new System.Drawing.Point(17, 294);
            this.donor_chart.Name = "donor_chart";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Donors";
            this.donor_chart.Series.Add(series1);
            this.donor_chart.Size = new System.Drawing.Size(389, 198);
            this.donor_chart.TabIndex = 0;
            this.donor_chart.Text = "Donor Statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "Blood Bank Manager";
            // 
            // date_label
            // 
            this.date_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.date_label.Location = new System.Drawing.Point(539, 10);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(145, 25);
            this.date_label.TabIndex = 7;
            this.date_label.Text = "7-Jul-16";
            this.date_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_label
            // 
            this.time_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(102)))), ((int)(((byte)(169)))));
            this.time_label.Location = new System.Drawing.Point(690, 10);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(115, 25);
            this.time_label.TabIndex = 8;
            this.time_label.Text = "11:50 AM";
            this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(35, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Donor Statistics Chart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(412, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stock Statistics Chart";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_donor_out
            // 
            this.total_donor_out.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_donor_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.total_donor_out.Location = new System.Drawing.Point(16, 154);
            this.total_donor_out.Name = "total_donor_out";
            this.total_donor_out.Size = new System.Drawing.Size(161, 63);
            this.total_donor_out.TabIndex = 13;
            this.total_donor_out.Text = "536";
            this.total_donor_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(20, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Registered donors";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(187, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Blood bags in stock";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unused_stock_out
            // 
            this.unused_stock_out.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unused_stock_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(26)))), ((int)(((byte)(117)))));
            this.unused_stock_out.Location = new System.Drawing.Point(183, 154);
            this.unused_stock_out.Name = "unused_stock_out";
            this.unused_stock_out.Size = new System.Drawing.Size(166, 63);
            this.unused_stock_out.TabIndex = 15;
            this.unused_stock_out.Text = "306";
            this.unused_stock_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(351, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Donors available";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(351, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "currently";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(510, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "donors";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(510, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Monthly new";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(664, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "stock";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(664, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Monthly new";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock_chart
            // 
            this.stock_chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.stock_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.stock_chart.Legends.Add(legend2);
            this.stock_chart.Location = new System.Drawing.Point(412, 294);
            this.stock_chart.Name = "stock_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Stock3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Stock";
            series3.YValuesPerPoint = 2;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series4.BorderWidth = 0;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Stock2";
            this.stock_chart.Series.Add(series2);
            this.stock_chart.Series.Add(series3);
            this.stock_chart.Series.Add(series4);
            this.stock_chart.Size = new System.Drawing.Size(389, 198);
            this.stock_chart.TabIndex = 25;
            this.stock_chart.Text = "Donor Statistics";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.label14.Location = new System.Drawing.Point(15, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Donor and Stock management.";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthly_new_stock_bar
            // 
            this.monthly_new_stock_bar.BarWidth = 15;
            this.monthly_new_stock_bar.EmptyBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.monthly_new_stock_bar.Location = new System.Drawing.Point(668, 118);
            this.monthly_new_stock_bar.Name = "monthly_new_stock_bar";
            this.monthly_new_stock_bar.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(182)))), ((int)(((byte)(132)))));
            this.monthly_new_stock_bar.ProgressValue = 60;
            this.monthly_new_stock_bar.Size = new System.Drawing.Size(130, 130);
            this.monthly_new_stock_bar.StatusFont = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.monthly_new_stock_bar.StatusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(182)))), ((int)(((byte)(132)))));
            this.monthly_new_stock_bar.TabIndex = 22;
            // 
            // monthly_new_donor_bar
            // 
            this.monthly_new_donor_bar.BarWidth = 15;
            this.monthly_new_donor_bar.EmptyBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.monthly_new_donor_bar.Location = new System.Drawing.Point(514, 118);
            this.monthly_new_donor_bar.Name = "monthly_new_donor_bar";
            this.monthly_new_donor_bar.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(135)))), ((int)(((byte)(181)))));
            this.monthly_new_donor_bar.ProgressValue = 32;
            this.monthly_new_donor_bar.Size = new System.Drawing.Size(130, 130);
            this.monthly_new_donor_bar.StatusFont = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.monthly_new_donor_bar.StatusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(135)))), ((int)(((byte)(181)))));
            this.monthly_new_donor_bar.TabIndex = 19;
            // 
            // donors_available_bar
            // 
            this.donors_available_bar.BarWidth = 15;
            this.donors_available_bar.EmptyBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.donors_available_bar.Location = new System.Drawing.Point(355, 118);
            this.donors_available_bar.Name = "donors_available_bar";
            this.donors_available_bar.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.donors_available_bar.ProgressValue = 73;
            this.donors_available_bar.Size = new System.Drawing.Size(130, 130);
            this.donors_available_bar.StatusFont = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donors_available_bar.StatusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.donors_available_bar.TabIndex = 12;
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.stock_chart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.monthly_new_stock_bar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.monthly_new_donor_bar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.unused_stock_out);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total_donor_out);
            this.Controls.Add(this.donors_available_bar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.donor_chart);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(808, 529);
            ((System.ComponentModel.ISupportInitialize)(this.donor_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart donor_chart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar donors_available_bar;
        private System.Windows.Forms.Label total_donor_out;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label unused_stock_out;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CircularProgressBar monthly_new_donor_bar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private CircularProgressBar monthly_new_stock_bar;
        private System.Windows.Forms.DataVisualization.Charting.Chart stock_chart;
        private System.Windows.Forms.Label label14;

    }
}
