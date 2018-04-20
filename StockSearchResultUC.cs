using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class StockSearchResultUC : UserControl {
        public StockSearchResultUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static StockSearchResultUC _instance;
        public static StockSearchResultUC Instance {
            get {
                if (_instance == null) {
                    _instance = new StockSearchResultUC();
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

        private string search_query_string;
        public string SearchQueryString {
            set {
                search_query_string = value;
            }
        }

        // refresh output results with stored dataset
        private void bindOutputUI() {
            tag_out.Text = Organizer.tagString;
            resultGridView.DataSource = result_data_set.Tables[0];
        }
        public void refreshOutputUI() {
            result_data_set = DatabaseManager.resultQuery(search_query_string);
            bindOutputUI();
        }

        // double click on result row
        private void resultGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0) return;

            try {
                DataGridViewRow row = this.resultGridView.Rows[e.RowIndex];
                int stock_id = (int)row.Cells["Blood_Stock_Id"].Value;

                new StockInfoForm(stock_id).Show();
            } catch (Exception exep) { 

            }
        }
    }
}
