using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Blood_Bank_Manager {
    public partial class DonorTable : Form {
        public DonorTable() {
            InitializeComponent();
            dataGridViewLoad();
        }

        private void dataGridViewLoad() {
            // open a connection
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\BloodBankDB.sdf");
            conn.Open();

            // prepare query
            string qryStr = "select * from donors";

            // prepare command
            SqlCeCommand command = new SqlCeCommand(qryStr, conn);

            // bind data with ui
            DataSet dataSet = new DataSet();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter(command);
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            // closing connection
            conn.Close();
            conn = null;
        }
    }
}
