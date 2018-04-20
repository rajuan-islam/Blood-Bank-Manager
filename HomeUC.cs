using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class HomeUC : UserControl {
        public HomeUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static HomeUC _instance;
        public static HomeUC Instance {
            get {
                if (_instance == null) {
                    _instance = new HomeUC();
                }
                //_instance.bindUI();
                return _instance;
            }
        }

        // all data variables
        int ttl_donor,ttl_unused_stock,available_donor,new_donor,ttl_stock_collection,new_stock_collection;
        int cnt;
        string qryString;
        DataSet data;

        public void bindUI() {
            //MessageBox.Show("Bind");
            
            timer1.Start();

            // total donors
            qryString = "select count(id) from donors";
            data = DatabaseManager.resultQuery(qryString);
            ttl_donor = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            total_donor_out.Text = ttl_donor.ToString();

            // total unused blood bags in stock
            qryString = "select count(id) from stock where used='no'";
            data = DatabaseManager.resultQuery(qryString);
            ttl_unused_stock = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            unused_stock_out.Text = ttl_unused_stock.ToString();

            // donors available currently
            qryString = "select count(id) from donors where DATEDIFF(day,date_donation,'" + DateTime.Now.ToShortDateString() + "')>120";
            data = DatabaseManager.resultQuery(qryString);
            available_donor = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            if (ttl_donor > 0) {
                donors_available_bar.ProgressValue = (available_donor * 100) / ttl_donor;
            } else {
                donors_available_bar.ProgressValue = 0;
            }

            // new donors this month
            string this_month = DateTime.Now.Month.ToString();
            string this_year = DateTime.Now.Year.ToString();
            qryString = "select count(id) from donors where datepart(month,date_reg)='"+this_month+"' and datepart(year,date_reg)='"+this_year+"'";
            data = DatabaseManager.resultQuery(qryString);
            new_donor = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            if (ttl_donor > 0) {
                monthly_new_donor_bar.ProgressValue = (new_donor * 100) / ttl_donor;
            } else {
                monthly_new_donor_bar.ProgressValue = 0;
            }

            // new stock collection this month
            qryString = "select count(id) from stock";
            data = DatabaseManager.resultQuery(qryString);
            ttl_stock_collection = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            qryString = "select count(id) from stock where datepart(month,date_collection)='" + this_month + "' and datepart(year,date_collection)='" + this_year + "'";
            data = DatabaseManager.resultQuery(qryString);
            new_stock_collection = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            if (ttl_stock_collection > 0) {
                monthly_new_stock_bar.ProgressValue = (new_stock_collection * 100) / ttl_stock_collection;
            } else {
                monthly_new_stock_bar.ProgressValue = 0;
            }

            load_donor_chart();
            load_stock_chart();
        }

        void load_donor_chart() {
            donor_chart.Series["Donors"].Points.Clear();

            qryString = "select count(id) from donors where blood_group='";

            data = DatabaseManager.resultQuery(qryString+"A+'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            donor_chart.Series["Donors"].Points.AddXY("A+",cnt);
            donor_chart.Series["Donors"].Points[0].Color = Color.FromArgb(70, 36, 70);

            data = DatabaseManager.resultQuery(qryString + "A-'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            donor_chart.Series["Donors"].Points.AddXY("A-",cnt);
            donor_chart.Series["Donors"].Points[1].Color = Color.FromArgb(176, 95, 109);

            data = DatabaseManager.resultQuery(qryString + "B+'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            donor_chart.Series["Donors"].Points.AddXY("B+",cnt);
            donor_chart.Series["Donors"].Points[2].Color = Color.FromArgb(235, 107, 86);

            data = DatabaseManager.resultQuery(qryString + "B-'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            donor_chart.Series["Donors"].Points.AddXY("B-",cnt);
            donor_chart.Series["Donors"].Points[3].Color = Color.FromArgb(255, 193, 83);

            data = DatabaseManager.resultQuery(qryString + "AB+'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            donor_chart.Series["Donors"].Points.AddXY("AB+",cnt);
            donor_chart.Series["Donors"].Points[4].Color = Color.FromArgb(174, 68, 200);

            data = DatabaseManager.resultQuery(qryString + "AB-'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            donor_chart.Series["Donors"].Points.AddXY("AB-",cnt);
            donor_chart.Series["Donors"].Points[5].Color = Color.FromArgb(85, 195, 77);

            data = DatabaseManager.resultQuery(qryString + "O+'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            donor_chart.Series["Donors"].Points.AddXY("O+",cnt);
            donor_chart.Series["Donors"].Points[6].Color = Color.FromArgb(7, 67, 84);

            data = DatabaseManager.resultQuery(qryString + "O-'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            donor_chart.Series["Donors"].Points.AddXY("O-",cnt);
        }

        void load_stock_chart() {
            stock_chart.Series["Stock"].Points.Clear();
            stock_chart.Series["Stock2"].Points.Clear();
            stock_chart.Series["Stock3"].Points.Clear();

            qryString = "select count(stock.id) from stock, donors where used='no' and donor_id=donors.id and blood_group='";

            data = DatabaseManager.resultQuery(qryString + "A+'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            stock_chart.Series["Stock"].Points.AddXY("A+", cnt);
            stock_chart.Series["Stock2"].Points.AddXY("A+", cnt);
            stock_chart.Series["Stock3"].Points.AddXY("A+", cnt);

            data = DatabaseManager.resultQuery(qryString + "A-'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            stock_chart.Series["Stock"].Points.AddXY("A-", cnt);
            stock_chart.Series["Stock2"].Points.AddXY("A-", cnt);
            stock_chart.Series["Stock3"].Points.AddXY("A-", cnt);

            data = DatabaseManager.resultQuery(qryString + "B+'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            stock_chart.Series["Stock"].Points.AddXY("B+", cnt);
            stock_chart.Series["Stock2"].Points.AddXY("B+", cnt);
            stock_chart.Series["Stock3"].Points.AddXY("B+", cnt);

            data = DatabaseManager.resultQuery(qryString + "B-'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            stock_chart.Series["Stock"].Points.AddXY("B-", cnt);
            stock_chart.Series["Stock2"].Points.AddXY("B-", cnt);
            stock_chart.Series["Stock3"].Points.AddXY("B-", cnt);

            data = DatabaseManager.resultQuery(qryString + "AB+'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            stock_chart.Series["Stock"].Points.AddXY("AB+", cnt);
            stock_chart.Series["Stock2"].Points.AddXY("AB+", cnt);
            stock_chart.Series["Stock3"].Points.AddXY("AB+", cnt);

            data = DatabaseManager.resultQuery(qryString + "AB-'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            stock_chart.Series["Stock"].Points.AddXY("AB-", cnt);
            stock_chart.Series["Stock2"].Points.AddXY("AB-", cnt);
            stock_chart.Series["Stock3"].Points.AddXY("AB-", cnt);

            data = DatabaseManager.resultQuery(qryString + "O+'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            stock_chart.Series["Stock"].Points.AddXY("O+", cnt);
            stock_chart.Series["Stock2"].Points.AddXY("O+", cnt);
            stock_chart.Series["Stock3"].Points.AddXY("O+", cnt);

            data = DatabaseManager.resultQuery(qryString + "O-'");
            cnt = Convert.ToInt32(data.Tables[0].Rows[0][0]);
            stock_chart.Series["Stock"].Points.AddXY("O-", cnt);
            stock_chart.Series["Stock2"].Points.AddXY("O-", cnt);
            stock_chart.Series["Stock3"].Points.AddXY("O-", cnt);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            //date_label.Text = DateTime.Now.ToString("d MMMM yyyy");
            date_label.Text = DateTime.Now.ToString("M/d/yyyy");
            time_label.Text = DateTime.Now.ToString("hh:mm tt");
        }
    }
}
