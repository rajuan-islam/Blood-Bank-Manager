using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Blood_Bank_Manager {
    public partial class AddDonorUC : UserControl {
        public AddDonorUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static AddDonorUC _instance;
        public static AddDonorUC Instance {
            get {
                if (_instance == null) {
                    _instance = new AddDonorUC();
                }
                return _instance;
            }
        }

        private void add_donor_button_Click(object sender, EventArgs e) {
            //new DonorInfoForm().Show();

            if (name_in.Text=="" || bg_in.Text=="" || gender_in.Text=="" || area_in.Text=="" || contactNo_in.Text=="") {
                MessageBox.Show("Please fill up all the fields to register.");
                return;
            }

            // SQL query String
            string qryString = "insert into donors(name,date_birth,gender,date_donation,area,address,contact_no,blood_group,date_reg) "
                +"values( '"+name_in.Text+"' , '"+doBirth_in.Text+"' , '"+
                gender_in.Text + "' , '" + doLastDonation_in.Text + "' , '" + area_in.Text + "' , '" + address_in.Text + "' , '" + contactNo_in.Text + "' , '" + bg_in.Text + "' , '"+DateTime.Now.ToString("M/d/yyyy")+"'  )";

            DatabaseManager.processQuery(qryString);

            //MessageBox.Show(qryString);

            // clear input fields after registering
            clear_input_fields();
        }

        private void clear_button_Click(object sender, EventArgs e) {
            clear_input_fields();
        }

        private void clear_input_fields() {
            name_in.Text = "";
            bg_in.Text = "";
            gender_in.Text = "";
            area_in.Text = "";
            address_in.Text = "";
            contactNo_in.Text = "";
        }

        private void contactNo_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch!=8) {
                e.Handled = true;
                //MessageBox.Show("Wrong Input");
                //AutoClosingMessageBox.Show("Digits Only!","Wrong Input",1000);
                new ToolTip().Show("Digits only!", contactNo_in, 0, contactNo_in.Height, 1000);
            }
        }

        private void name_in_KeyPress(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 32 && ch!=8) {
                e.Handled = true;
                new ToolTip().Show("Characters and space only!", name_in, 0, name_in.Height, 1000);
            }
        }
    }
}
