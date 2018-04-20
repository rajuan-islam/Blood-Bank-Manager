using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Blood_Bank_Manager {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            // Sending instance to manager class
            Organizer.current_main_form = this;
            // initialize menu button list to change menu button colors
            menu_button_list_initialize();
            // load HomeUC user control
            load_HomeUC();
        }

        // Home
        private void home_button_Click(object sender, EventArgs e) {
            // Menu buttons' color change
            change_menu_button_color(sender);
            // load HomeUC user control
            load_HomeUC();
        }
        private void load_HomeUC() {
            // Title change
            page_title.Text = "Dashboard";
            // load UC
            if (!base_panel.Controls.Contains(HomeUC.Instance)) {
                base_panel.Controls.Add(HomeUC.Instance);
                HomeUC.Instance.Dock = DockStyle.Fill;
            }
            HomeUC.Instance.bindUI();
            HomeUC.Instance.BringToFront();
        }

        // Add Donor
        private void add_donor_button_Click(object sender, EventArgs e) {
            // Menu buttons' color change
            change_menu_button_color(sender);
            // Load AddDonorUC user control
            load_AddDonorUC();
        }
        private void load_AddDonorUC() {
            // Title change
            page_title.Text = "Add Donor";
            // load UC
            if (!base_panel.Controls.Contains(AddDonorUC.Instance)) {
                base_panel.Controls.Add(AddDonorUC.Instance);
                AddDonorUC.Instance.Dock = DockStyle.Fill;
            }
            AddDonorUC.Instance.BringToFront();
        }

        // Search Donor
        private void search_donor_button_Click(object sender, EventArgs e) {
            // Menu buttons' color change
            change_menu_button_color(sender);
            // Load SearchDonorUC user control
            load_SearchDonorUC();
        }
        private void load_SearchDonorUC() {
            // Title change
            page_title.Text = "Search Donor";
            // load UC
            if (!base_panel.Controls.Contains(SearchDonorUC.Instance)) {
                base_panel.Controls.Add(SearchDonorUC.Instance);
                SearchDonorUC.Instance.Dock = DockStyle.Fill;
            }
            SearchDonorUC.Instance.BringToFront();
        }
        public void goToDonorSearchPage() {
            load_SearchDonorUC();
        }

        // Search Stock
        private void search_stock_button_Click(object sender, EventArgs e) {
            // Menu buttons' color change
            change_menu_button_color(sender);
            // Load SearchDonorUC user control
            load_SearchStockUC();
        }
        private void load_SearchStockUC() {
            // Title change
            page_title.Text = "Search Stock";
            // load UC
            if (!base_panel.Controls.Contains(SearchStockUC.Instance)) {
                base_panel.Controls.Add(SearchStockUC.Instance);
                SearchStockUC.Instance.Dock = DockStyle.Fill;
            }
            SearchStockUC.Instance.BringToFront();
        }

        // Date range search
        private void date_range_search_button_Click(object sender, EventArgs e) {
            // Menu buttons' color change
            change_menu_button_color(sender);
            // Load Date range search UC
            load_DateRangeSearch();
        }
        private void load_DateRangeSearch() {
            // Title change
            page_title.Text = "Search In Range";
            // load UC
            if (!base_panel.Controls.Contains(DateRangeSearch.Instance)) {
                base_panel.Controls.Add(DateRangeSearch.Instance);
                DateRangeSearch.Instance.Dock = DockStyle.Fill;
            }
            DateRangeSearch.Instance.BringToFront();
        }

        /* Donor Search Result UC load indirect */
        private void load_DonorSearchResultUC(DataSet dataset,string qryString) {
            // Title change
            page_title.Text = "Donor Search Result";
            // load UC
            if (!base_panel.Controls.Contains(DonorSearchResultUC.Instance)) {
                base_panel.Controls.Add(DonorSearchResultUC.Instance);
                DonorSearchResultUC.Instance.Dock = DockStyle.Fill;
            }
            DonorSearchResultUC.Instance.ResultDataSet = dataset;
            DonorSearchResultUC.Instance.SearchQueryString = qryString;
            DonorSearchResultUC.Instance.BringToFront();
        }
        public void goToDonorSearchResultPage(DataSet dataset,string qryString) {
            load_DonorSearchResultUC(dataset,qryString);
        }

        /* Stock Search Result UC load indirect */
        private void load_StockSearchResultUC(DataSet dataset,string qryString) {
            // Title change
            page_title.Text = "Blood Bag Stock Search Result";
            // load UC
            if (!base_panel.Controls.Contains(StockSearchResultUC.Instance)) {
                base_panel.Controls.Add(StockSearchResultUC.Instance);
                StockSearchResultUC.Instance.Dock = DockStyle.Fill;
            }
            StockSearchResultUC.Instance.ResultDataSet = dataset;
            StockSearchResultUC.Instance.SearchQueryString = qryString;
            StockSearchResultUC.Instance.BringToFront();
        }
        public void goToStockSearchResultPage(DataSet dataset,string qryString) {
            load_StockSearchResultUC(dataset,qryString);
        }

        /*
         * Form design related codes
         */

        // Exit button
        private void exit_button_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // Minimize button
        private void minimize_button_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
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
                this.SetDesktopLocation(MousePosition.X - valX-200, MousePosition.Y - valY);
            }
        }
      
        // Button click color change code
        List<Button> menu_buttons;
        void menu_button_list_initialize() {
            menu_buttons = new List<Button>();
            menu_buttons.Add( home_button );
            menu_buttons.Add(add_donor_button);
            menu_buttons.Add(search_donor_button);
            menu_buttons.Add(search_stock_button);
            menu_buttons.Add(date_range_search_button);
        }
        void change_menu_button_color(object sender) {
            foreach (Button button in menu_buttons) {
                button.BackColor = Color.FromArgb(53,57,66);
            }
            (sender as Button).BackColor = Color.FromArgb(150,37,67);
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

        private void button1_Click(object sender, EventArgs e) {
            new DonorTable().Show();
        }

        private void about_us_button_Click(object sender, EventArgs e) {
            new AboutUs().Show();
        }
    }
}
