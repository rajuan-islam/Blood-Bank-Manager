using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class StockInfoForm : Form {
        public StockInfoForm() {
            InitializeComponent();
        }

        int Stock_Id, Donor_Id;
        
        public StockInfoForm(int stock_id) {
            InitializeComponent();
            Stock_Id = stock_id;
            load_stock_info_UI(stock_id);
        }

        private void load_stock_info_UI(int stock_id) { 
            // database query
            string qryString = "select donor_id, name, blood_group, date_collection, used from stock, donors where donor_id=donors.id and stock.id="+stock_id.ToString();
            DataSet stock = DatabaseManager.resultQuery(qryString);

            stock_id_out.Text = stock_id.ToString();

            donor_id_out.Text = stock.Tables[0].Rows[0]["donor_id"].ToString();
            Donor_Id = Convert.ToInt32(donor_id_out.Text);

            donor_name_out.Text = stock.Tables[0].Rows[0]["name"].ToString();
            bg_out.Text = stock.Tables[0].Rows[0]["blood_group"].ToString();
            date_collection_out.Text = Organizer.getDateOnly(stock.Tables[0].Rows[0]["date_collection"].ToString());
            used_out.Text = stock.Tables[0].Rows[0]["used"].ToString();

            if (used_out.Text == "no") {
                used_out.ForeColor = Color.Green;
            } else {
                use_button.Visible = false;
            }
        }

        // close button
        private void close_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Implement window drag on title_panel
        int toMove = 0, valX, valY;
        private void title_panel_MouseDown(object sender, MouseEventArgs e) {
            toMove = 1;
            valX = e.X;
            valY = e.Y;
        }
        private void title_panel_MouseUp(object sender, MouseEventArgs e) {
            toMove = 0;
        }
        private void title_panel_MouseMove(object sender, MouseEventArgs e) {
            if (toMove == 1) {
                this.SetDesktopLocation(MousePosition.X - valX, MousePosition.Y - valY);
            }
        }
        // Windows XP style drop shadow
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void donor_info_button_Click(object sender, EventArgs e) {
            new DonorInfoForm(Donor_Id,false).Show();
        }
        
        private void remove_button_Click(object sender, EventArgs e) {
            new ConfirmForm(this, "Do you want to delete this stock's infomation?").Show();
        }
        public void process_removal(bool yes) {
            if (!yes) return;

            // stock table query
            string qryString = "delete from stock where id="+Stock_Id.ToString();
            DatabaseManager.processQuery(qryString);

            // refresh result page in behind
            StockSearchResultUC.Instance.refreshOutputUI();

            this.Close();
        }

        // use the blood bag
        private void use_button_Click(object sender, EventArgs e) {
            /* All Database Changes */
            // Update Stock Table
            string qryString = "update stock set used='yes' where id="+Stock_Id.ToString();
            DatabaseManager.processQuery(qryString);
            // Update Donors Table
            qryString = "update donors set date_donation='"+DateTime.Now.ToShortDateString()+"' where id="+Donor_Id.ToString();
            DatabaseManager.processQuery(qryString);

            used_out.Text = "yes";
            used_out.ForeColor = donor_name_out.ForeColor;
            use_button.Visible = false;

            // refresh search result page showing behind
            StockSearchResultUC.Instance.refreshOutputUI();
        }
    }
}
