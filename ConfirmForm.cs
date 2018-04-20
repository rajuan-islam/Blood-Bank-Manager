using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class ConfirmForm : Form {
        
        DonorInfoForm donor_form;
        StockInfoForm stock_form;
        
        public ConfirmForm(DonorInfoForm donorForm,string dialogString) {
            InitializeComponent();

            donor_form = donorForm;
            stock_form = null;
            dialog_out.Text = dialogString;
        }
        public ConfirmForm(StockInfoForm stockForm, string dialogString) {
            InitializeComponent();

            donor_form = null;
            stock_form = stockForm;
            dialog_out.Text = dialogString;
        }

        private void yes_button_Click(object sender, EventArgs e) {
            if (donor_form != null) {
                this.Visible = false;
                donor_form.process_removal(true);
                this.Close();
            } else {
                this.Visible = false;
                stock_form.process_removal(true);
                this.Close();
            }
        }

        private void no_button_Click(object sender, EventArgs e) {
            if (donor_form != null) {
                this.Visible = false;
                donor_form.process_removal(false);
                this.Close();
            } else {
                this.Visible = false;
                stock_form.process_removal(false);
                this.Close();
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
