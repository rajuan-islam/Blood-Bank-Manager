using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class DonorInfoForm : Form {
        public DonorInfoForm() {
            InitializeComponent();
        }

        int Donor_Id;
        
        public DonorInfoForm(int id,bool operateMode) {
            InitializeComponent();
            Donor_Id = id;
            load_donor_info_to_UI(id);

            if (!operateMode) {
                remove_button.Visible = false;
                donate_button.Visible = false;
            }
        }

        private void load_donor_info_to_UI(int id) {
            id_out.Text = id.ToString();

            // Database Query
            string qryString = "select *, DATEDIFF(day,date_donation,'" + DateTime.Now.ToShortDateString() + "') as days from donors where id=" + id.ToString();
            DataSet donor = DatabaseManager.resultQuery(qryString);

            name_out.Text = donor.Tables[0].Rows[0]["name"].ToString();
            date_birth_out.Text = Organizer.getDateOnly(donor.Tables[0].Rows[0]["date_birth"].ToString());
            gender_out.Text = donor.Tables[0].Rows[0]["gender"].ToString();
            date_donation_out.Text = Organizer.getDateOnly(donor.Tables[0].Rows[0]["date_donation"].ToString());
            area_out.Text = donor.Tables[0].Rows[0]["area"].ToString();
            address_out.Text = donor.Tables[0].Rows[0]["address"].ToString();
            contact_no_out.Text = donor.Tables[0].Rows[0]["contact_no"].ToString();
            bg_out.Text = donor.Tables[0].Rows[0]["blood_group"].ToString();
            date_registration_out.Text = Organizer.getDateOnly(donor.Tables[0].Rows[0]["date_reg"].ToString());

            int days = Convert.ToInt32(donor.Tables[0].Rows[0]["days"].ToString());
            donation_days_count_out.Text = days.ToString()+" days";
            if (days > 120) {
                donation_days_count_out.ForeColor = Color.Green;
            } else {
                donate_button.Visible = false;
            }
        }

        private void donate_button_Click(object sender, EventArgs e) {
            new DateSelect(this,"Date of donation:").Show();
        }

        public void process_donation(string donation_date) {
            if (donation_date == null) return;
            //MessageBox.Show(donation_date);

            /*All database queries*/
            // stock table query
            string qryString = "insert into stock(donor_id,date_collection) "
                +"values( "+Donor_Id.ToString()+", '"+donation_date+"' )";
            DatabaseManager.processQuery(qryString);
            // donors table query
            qryString = "update donors set date_donation='"+donation_date+"' where id="+Donor_Id.ToString();
            DatabaseManager.processQuery(qryString);

            // form ui change
            donation_days_count_out.Text = "0";
            donation_days_count_out.ForeColor = name_out.ForeColor;
            donate_button.Visible = false;
            date_donation_out.Text = Convert.ToDateTime(donation_date).ToLongDateString();

            // refresh search result in background
            DonorSearchResultUC.Instance.refreshOutputUI();
        }

        private void close_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void remove_button_Click(object sender, EventArgs e) {
            new ConfirmForm(this, "Do you want to delete this donor's all informations?").Show();
        }
        public void process_removal(bool yes) {
            if (!yes) return;

            // stock table query
            string qryString = "delete from stock where donor_id=" + Donor_Id.ToString();
            DatabaseManager.processQuery(qryString);
            // donors table query
            qryString = "delete from donors where id=" + Donor_Id.ToString();
            DatabaseManager.processQuery(qryString);

            // refresh result page in behind
            DonorSearchResultUC.Instance.refreshOutputUI();

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
    }
}
