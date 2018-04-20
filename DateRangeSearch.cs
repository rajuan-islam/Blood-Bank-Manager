using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class DateRangeSearch : UserControl {
        public DateRangeSearch() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static DateRangeSearch _instance;
        public static DateRangeSearch Instance {
            get {
                if (_instance == null) {
                    _instance = new DateRangeSearch();
                }
                //_instance.bindUI();
                return _instance;
            }
        }

        private bool target_donor;
        private void donor_button_Click(object sender, EventArgs e) {
            target_donor = true;
            big_label.Text = "Donor Information";
            small_label.Text = "Donors registered in the date range.";
            enable_hidden_UI();
            load_date_data();
            load_stock_chart(true);
            load_small_UI(true);
        }
        private void stock_button_Click(object sender, EventArgs e) {
            target_donor = false;
            big_label.Text = "Stock Information";
            small_label.Text = "Stock collected in the date range.";
            enable_hidden_UI();
            load_date_data();
            load_stock_chart(false);
            load_small_UI(false);
        }

        int total, fraction;
        private void load_small_UI(bool donors) {
            if (donors) {
                qryString = "select count(id) from donors";
            } else {
                qryString = "select count(id) from stock";
            }
            data = DatabaseManager.resultQuery(qryString);
            total = Convert.ToInt32(data.Tables[0].Rows[0][0]);

            if (donors) {
                qryString = "select count(id) from donors where '" + start_date + "'<=date_reg and date_reg<='" + end_date + "' ";
            } else {
                qryString = "select count(id) from stock where '" + start_date + "'<=date_collection and date_collection<='" + end_date + "' ";
            }
            data = DatabaseManager.resultQuery(qryString);
            fraction = Convert.ToInt32(data.Tables[0].Rows[0][0]);

            range_entries_out.Text = fraction.ToString();
            if (total > 0)
                fraction_entries_bar.ProgressValue = (fraction * 100) / total;
            else
                fraction_entries_bar.ProgressValue = 0;
        }

        string qryString,start_date,end_date;
        private void load_date_data() {
            start_date = start_date_in.Text;
            end_date = end_date_in.Text;
        }

        DataSet data;
        int cnt;
        void load_stock_chart(bool donors) {
            stock_chart.Series["Stock"].Points.Clear();
            stock_chart.Series["Stock2"].Points.Clear();
            stock_chart.Series["Stock3"].Points.Clear();

            if (donors) {
                qryString = "select count(id) from donors where '"+start_date+"'<=date_reg and date_reg<='"+end_date+"' and blood_group='";
            } else {
                qryString = "select count(stock.id) from stock, donors where donor_id=donors.id and '" + start_date + "'<=date_collection and date_collection<='" + end_date + "' and blood_group='";
            }

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

        private void enable_hidden_UI() {
            range_entries_out.Visible = true;
            fraction_entries_bar.Visible = true;
            label6.Visible = true;
            label11.Visible = true;
            show_search_button.Visible = true;
        }

        private void show_search_button_Click(object sender, EventArgs e) {
            if (target_donor) {
                string query = "select id as Donor_Id, name as Donor_Name, blood_group as Blood_Group, area as Area, DATEDIFF(day,date_donation,'" + DateTime.Now.ToShortDateString() + "') as Days_since_last_donation from donors where '" + start_date + "'<=date_reg and date_reg<='" + end_date + "' ";
                DataSet resultDataSet = DatabaseManager.resultQuery(query);

                Organizer.tagString = "";
                Organizer.current_main_form.goToDonorSearchResultPage(resultDataSet, query);
            } else {
                string query = "select stock.id as Blood_Stock_Id,blood_group as Blood_Group,name as Donor_Name,donor_id as Donor_Id,date_collection as Date_of_Collection,used as Used from stock,donors where stock.donor_id=donors.id and '" + start_date + "'<=date_collection and date_collection<='" + end_date + "' ";
                Organizer.tagString = "";

                DataSet result_data_set = DatabaseManager.resultQuery(query);

                Organizer.current_main_form.goToStockSearchResultPage(result_data_set, query);
            }
        }
    }
}
