using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class DateSelect : Form {
        DonorInfoForm donor_form;
        StockInfoForm stock_form;
        public DateSelect(DonorInfoForm donorForm,string tag) {
            InitializeComponent();

            donor_form = donorForm;
            stock_form = null;
            date_tag_out.Text = tag;
        }

        public DateSelect(StockInfoForm stockForm,string tag) {
            InitializeComponent();

            donor_form = null;
            stock_form = stockForm;
            date_tag_out.Text = tag;
        }

        private void select_date_button_Click(object sender, EventArgs e) {
            if (donor_form != null) {
                this.Visible = false;
                donor_form.process_donation(date_in.Value.ToShortDateString());
                this.Close();
            } else { 
                
            }
        }

        private void current_date_Click(object sender, EventArgs e) {
            if (donor_form != null) {
                this.Visible = false;
                donor_form.process_donation(DateTime.Now.ToShortDateString());
                this.Close();
            } else { 

            }
        }

        private void cancel_button_Click(object sender, EventArgs e) {
            if (donor_form != null) {
                this.Visible = false;
                donor_form.process_donation(null);
                this.Close();
            } else {

            }
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
