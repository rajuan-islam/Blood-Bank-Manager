using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class SearchDonorUC : UserControl {
        public SearchDonorUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static SearchDonorUC _instance;
        public static SearchDonorUC Instance {
            get {
                if (_instance == null) {
                    _instance = new SearchDonorUC();
                }
                return _instance;
            }
        }

        private void search_button_Click(object sender, EventArgs e) {
            // prepare query string
            string qryString = "select id as Donor_Id, name as Donor_Name, blood_group as Blood_Group, area as Area, DATEDIFF(day,date_donation,'" + DateTime.Now.ToShortDateString() + "') as Days_since_last_donation from donors";

            // modifying query string based on selected options
            string tagList = "";
            bool options = false;
            if (id_box.Checked && id_in.Text!="") { // search by only id and directly show donor info
                qryString += " where id=" + id_in.Text;
                options = true;
            } else {
                if (name_box.Checked && name_in.Text!="") {
                    qryString += " where name='"+name_in.Text+"'";
                    options = true;
                    tagList += name_in.Text+".. ";
                } 
                if (bg_box.Checked && bg_in.Text!="") {
                    if (!options) qryString += " where blood_group='" + bg_in.Text + "'";
                    else qryString += " and blood_group='" + bg_in.Text + "'";
                    options=true;
                    tagList += bg_in.Text+".. ";
                }
                if (area_box.Checked && area_in.Text!="") {
                    if (!options) qryString += " where area='" + area_in.Text + "'";
                    else qryString += " and area='" + area_in.Text + "'";
                    options = true;
                    tagList += area_in.Text+".. ";
                }
            }
            if (!show_unavailable_box.Checked) {
                if (!options) qryString += " where DATEDIFF(day,date_donation,'" + DateTime.Now.ToShortDateString() + "')>120";
                else qryString += " and DATEDIFF(day,date_donation,'" + DateTime.Now.ToShortDateString() + "')>120";
            }

            //MessageBox.Show(qryString);
            //return;

            DataSet resultDataSet = DatabaseManager.resultQuery(qryString);

            // go to search results page
            Organizer.tagString = tagList;
            Organizer.current_main_form.goToDonorSearchResultPage(resultDataSet,qryString);
        }
    }
}
