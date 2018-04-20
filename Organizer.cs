using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Data;

namespace Blood_Bank_Manager {
    class Organizer {
        // Current instance of MainForm
        public static MainForm current_main_form;
        
        // Passed/Saved result dataset of query
        public static DataSet resultDataset;
        // Search tags' string
        public static String tagString;

        // Date time string methods
        public static String getDateOnly(String dateString) {
            //DateTime date = DateTime.ParseExact(dateString, "M/d/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime date = new DateTime(dateString);
            DateTime date = Convert.ToDateTime(dateString);
            return date.ToLongDateString();
        }
    }
}
