using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class DonorSearchResultUC : UserControl {
        public DonorSearchResultUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static DonorSearchResultUC _instance;
        public static DonorSearchResultUC Instance {
            get {
                if (_instance == null) {
                    _instance = new DonorSearchResultUC();
                }
                return _instance;
            }
        }

        private DataSet result_data_set;
        public DataSet ResultDataSet {
            set {
                result_data_set = value;
                bindOutputUI();
            }
        }

        private string search_qry_string;
        public string SearchQueryString {
            set {
                search_qry_string = value;
            }
        }

        // refresh output results with stored dataset
        private void bindOutputUI() {
            tag_out.Text = Organizer.tagString;
            resultGridView.DataSource = result_data_set.Tables[0];
        }
        public void refreshOutputUI() {
            result_data_set = DatabaseManager.resultQuery(search_qry_string);
            bindOutputUI();
        }

        private void resultGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0) return;

            try {
                DataGridViewRow row = this.resultGridView.Rows[e.RowIndex];
                int donor_id = (int)row.Cells["Donor_Id"].Value;

                //MessageBox.Show(donor_id.ToString());
                new DonorInfoForm(donor_id, true).Show();
            } catch (Exception exep) {

            }
        }
    }
}
