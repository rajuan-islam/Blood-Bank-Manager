using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class SearchStockUC : UserControl {
        public SearchStockUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static SearchStockUC _instance;
        public static SearchStockUC Instance {
            get {
                if (_instance == null) {
                    _instance = new SearchStockUC();
                }
                return _instance;
            }
        }

        private void search_button_Click(object sender, EventArgs e) {
            // database query
            string qryString = "select stock.id as Blood_Stock_Id,blood_group as Blood_Group,name as Donor_Name,donor_id as Donor_Id,date_collection as Date_of_Collection,used as Used from stock,donors where stock.donor_id=donors.id";
            Organizer.tagString = "";
            
            if(donor_id_box.Checked && donor_id_in.Text!="") {
                qryString += " and donor_id="+donor_id_in.Text;
                Organizer.tagString = "Donor Id " + donor_id_in.Text;
            } else if (bg_box.Checked && bg_in.Text!="") {
                qryString += " and blood_group='"+bg_in.Text+"'";
                Organizer.tagString = bg_in.Text;
            }
            if (!used_show_box.Checked) {
                qryString += " and used='no'";
            }
            
            DataSet result_data_set = DatabaseManager.resultQuery(qryString);
            
            Organizer.current_main_form.goToStockSearchResultPage(result_data_set,qryString);
        }
    }
}
