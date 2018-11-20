using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21_KuotM_
{
    public partial class frmSimplified21 : Form
    {
        public frmSimplified21()
        {
            InitializeComponent();
        }

        private void frmSimplified21_Load(object sender, EventArgs e)
        {
            // This hides the labels a.k.a cards
            lblDealerCard1.Hide();
            lblDealerCard2.Hide();
            lblDealerCard3.Hide();
            lblUserCard1.Hide();
            lblUserCard2.Hide();
            lblUserCard3.Hide();
            lblUserScore.Hide();
            lblDealerScore.Hide();

        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            double Bet;
            double outdouble;

            Bet = Convert.ToDouble(txtBet.Text);

            if (Double.TryParse(txtBet.Text, out outdouble))
            {
                txtBet.Enabled = false;
                btnBet.Enabled = false;
            }
            else if (txtBet == null)
            {
                MessageBox.Show("Enter a valid number");
            }
            else
            {
                MessageBox.Show("Enter a valid number");
            }
            
        }
    }
}
