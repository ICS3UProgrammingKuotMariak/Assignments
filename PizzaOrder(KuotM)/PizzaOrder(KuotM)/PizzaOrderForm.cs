using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder_KuotM_
{
    public partial class frmPizzaOrder : Form
    {
        const double SMALL = 4.99;
        const double MEDIUM = 6.99;
        const double LARGE = 9.99;
        const double XLARGE = 12.99;
        const double TOPPING = 0.75;
        const double ONE_TOPPING = 0.75;
        const double TWO_TOPPING = 1.50;
        const double THREE_TOPPING = 2.25;
        const double DELIVERY = 5;
        const double HST = 0.13;
        double PIZZA_SIZE;
        double NUM_TOPPINGS;
        double SIDE_DISH;
        double YES = 3.99;
        double TAX, TOTAL;
        double SUBTOTAL;
  
       System.Media.SoundPlayer KrustyKrab = new System.Media.SoundPlayer(Properties.Resources.KrustyKrab1);
       System.Media.SoundPlayer Campfire = new System.Media.SoundPlayer(Properties.Resources.FUN);

        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            picPizza.Hide();
            lblStateSubTotal.Hide();
            lblStateTax.Hide();
            lblDelivery.Hide();
            lblStateTotal.Hide();
            lblSubTotal.Hide();
            lblTax.Hide();
            lblDeliveryOption.Hide();
            lblTotal.Hide();   
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            PIZZA_SIZE = SMALL;
            if (radDelivery.Checked == true)
            {
                SUBTOTAL = PIZZA_SIZE + NUM_TOPPINGS + SIDE_DISH;
                TAX = SUBTOTAL * HST;
                TOTAL = SUBTOTAL + TAX + DELIVERY;


                lblSubTotal.Text = Convert.ToString(Math.Round(SUBTOTAL, 2) + "$");
                lblTax.Text = Convert.ToString(Math.Round(TAX, 2) + "$");
                lblDelivery.Text = "Delivery";
                lblDeliveryOption.Text = Convert.ToString(DELIVERY + "$");
                lblTotal.Text = Convert.ToString(Math.Round(TOTAL, 2) + "$");
            }
            else
            {
                SUBTOTAL = PIZZA_SIZE + NUM_TOPPINGS + SIDE_DISH;
                TAX = SUBTOTAL * HST;
                TOTAL = SUBTOTAL + TAX;

                lblSubTotal.Text = Convert.ToString(Math.Round(SUBTOTAL, 2) + "$");
                lblTax.Text = Convert.ToString(Math.Round(TAX, 2) + "$");
                lblDelivery.Text = "Pick up";
                lblDeliveryOption.Text = "$0.00";
                lblTotal.Text = Convert.ToString(Math.Round(TOTAL, 2) + "$");
            }

        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            PIZZA_SIZE = MEDIUM;
            if (radDelivery.Checked == true)
            {
                SUBTOTAL = PIZZA_SIZE + NUM_TOPPINGS + SIDE_DISH;
                TAX = SUBTOTAL * HST;
                TOTAL = SUBTOTAL + TAX + DELIVERY;


                lblSubTotal.Text = Convert.ToString(Math.Round(SUBTOTAL, 2) + "$");
                lblTax.Text = Convert.ToString(Math.Round(TAX, 2) + "$");
                lblDelivery.Text = "Delivery";
                lblDeliveryOption.Text = Convert.ToString(DELIVERY + "$");
                lblTotal.Text = Convert.ToString(Math.Round(TOTAL, 2) + "$");
            }
            else
            {
                SUBTOTAL = PIZZA_SIZE + NUM_TOPPINGS + SIDE_DISH;
                TAX = SUBTOTAL * HST;
                TOTAL = SUBTOTAL + TAX;

                lblSubTotal.Text = Convert.ToString(Math.Round(SUBTOTAL, 2) + "$");
                lblTax.Text = Convert.ToString(Math.Round(TAX, 2) + "$");
                lblDelivery.Text = "Pick up";
                lblDeliveryOption.Text = "$0.00";
                lblTotal.Text = Convert.ToString(Math.Round(TOTAL, 2) + "$");
            }
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            PIZZA_SIZE = LARGE;
            if (radDelivery.Checked == true)
            {
                SUBTOTAL = PIZZA_SIZE + NUM_TOPPINGS + SIDE_DISH;
                TAX = SUBTOTAL * HST;
                TOTAL = SUBTOTAL + TAX + DELIVERY;


                lblSubTotal.Text = Convert.ToString(Math.Round(SUBTOTAL, 2) + "$");
                lblTax.Text = Convert.ToString(Math.Round(TAX, 2) + "$");
                lblDelivery.Text = "Delivery";
                lblDeliveryOption.Text = Convert.ToString(DELIVERY + "$");
                lblTotal.Text = Convert.ToString(Math.Round(TOTAL, 2) + "$");
            }
            else
            {
                SUBTOTAL = PIZZA_SIZE + NUM_TOPPINGS + SIDE_DISH;
                TAX = SUBTOTAL * HST;
                TOTAL = SUBTOTAL + TAX;

                lblSubTotal.Text = Convert.ToString(Math.Round(SUBTOTAL, 2) + "$");
                lblTax.Text = Convert.ToString(Math.Round(TAX, 2) + "$");
                lblDelivery.Text = "Pick up";
                lblDeliveryOption.Text = "$0.00";
                lblTotal.Text = Convert.ToString(Math.Round(TOTAL, 2) + "$");
            }
        }

        private void radXLarge_CheckedChanged(object sender, EventArgs e)
        {
            PIZZA_SIZE = XLARGE;
        }

        private void picMusic_Click(object sender, EventArgs e)
        {
            KrustyKrab.Stop();
            Campfire.Stop();
  
        }

        private void mniMainTheme_Click(object sender, EventArgs e)
        {
            KrustyKrab.Play();
        }

        private void mniFUN_Click(object sender, EventArgs e)
        {            
            Campfire.Play();
        }

        private void mniEnglish_Click(object sender, EventArgs e)
        {

        }

        private void mniFrançais_Click(object sender, EventArgs e)
        {
            
        }

        private void mniEspañol_Click(object sender, EventArgs e)
        {

        }

        private void radPickup_CheckedChanged(object sender, EventArgs e)
        {
            if (radPickup.Checked == true)
            {
                lblStateSubTotal.Show();
                lblSubTotal.Show();
                lblStateTax.Show();
                lblTax.Show();
                lblDelivery.Show();
                lblDeliveryOption.Show();
                lblStateTotal.Show();
                lblTotal.Show();

                SUBTOTAL = PIZZA_SIZE + NUM_TOPPINGS + SIDE_DISH;
                TAX = SUBTOTAL * HST;
                TOTAL = SUBTOTAL + TAX;

                lblSubTotal.Text = Convert.ToString(Math.Round(SUBTOTAL,2) + "$");
                lblTax.Text = Convert.ToString(Math.Round(TAX,2) + "$");
                lblDelivery.Text = "Pick up";
                lblDeliveryOption.Text = "$0.00";
                lblTotal.Text = Convert.ToString(Math.Round(TOTAL,2) + "$");
            }
            else
            {
                lblStateSubTotal.Hide();
                lblStateTax.Hide();
                lblDelivery.Hide();
                lblStateTotal.Hide();
                lblSubTotal.Hide();
                lblTax.Hide();
                lblDeliveryOption.Hide();
                lblTotal.Hide();
            }
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
                NUM_TOPPINGS = ONE_TOPPING;
                picPizza.Image = Properties.Resources.pepperoni_pizza;
                picPizza.Show();
            if (chkBacon.Checked == true)
            {
                NUM_TOPPINGS = TWO_TOPPING;
                picPizza.Image = Properties.Resources.pepperoni_bacon_pizza;
            }

            else if (chkOlives.Checked == true)
            {
                NUM_TOPPINGS = TWO_TOPPING;
                picPizza.Image = Properties.Resources.pepperoni_olives_pizza;
            }
            else if (chkPepperoni.Checked == false)
            {
                NUM_TOPPINGS = 0;
                picPizza.Image = Properties.Resources.cheese_pizza;
            }

        }

        private void chkBacon_CheckedChanged(object sender, EventArgs e)
        {            
                NUM_TOPPINGS = ONE_TOPPING;
                picPizza.Image = Properties.Resources.bacon_pizza;
                picPizza.Show();
            if (chkPepperoni.Checked == true)
            {
                NUM_TOPPINGS = TWO_TOPPING;
                picPizza.Image = Properties.Resources.pepperoni_bacon_pizza;
            }
            else if (chkOlives.Checked == true)
            {
                NUM_TOPPINGS = TWO_TOPPING;
                picPizza.Image = Properties.Resources.bacon_olives_pizza;
            }
            else if (chkBacon.Checked == false)
            {
                NUM_TOPPINGS = 0;
                picPizza.Image = Properties.Resources.cheese_pizza;
            }

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {    
                NUM_TOPPINGS = ONE_TOPPING;
                picPizza.Image = Properties.Resources.olives_pizza;
                picPizza.Show();
            if (chkPepperoni.Checked == true)
            {
                NUM_TOPPINGS = TWO_TOPPING;
                picPizza.Image = Properties.Resources.pepperoni_olives_pizza;
            }
            else if (chkBacon.Checked == true)
            {
                NUM_TOPPINGS = TWO_TOPPING;
                picPizza.Image = Properties.Resources.bacon_olives_pizza;
            }
            else if (chkOlives.Checked == false)
            {
                NUM_TOPPINGS = 0;
                picPizza.Image = Properties.Resources.cheese_pizza;
            }

        }

        private void radFries_CheckedChanged(object sender, EventArgs e)
        {
            SIDE_DISH = YES;           
        }
        private void radWings_CheckedChanged(object sender, EventArgs e)
        {
            SIDE_DISH = YES;
        }

        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            SIDE_DISH = YES;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (radDelivery.Checked == true)
            {
                lblStateSubTotal.Show();
                lblSubTotal.Show();
                lblStateTax.Show();
                lblTax.Show();
                lblDelivery.Show();
                lblDeliveryOption.Show();
                lblStateTotal.Show();
                lblTotal.Show();

                SUBTOTAL = PIZZA_SIZE + NUM_TOPPINGS + SIDE_DISH;
                TAX = SUBTOTAL * HST;
                TOTAL = SUBTOTAL + TAX + DELIVERY;

                lblSubTotal.Text = Convert.ToString(Math.Round(SUBTOTAL,2) + "$");
                lblTax.Text = Convert.ToString(Math.Round(TAX,2) + "$");
                lblDelivery.Text = "Delivery";
                lblDeliveryOption.Text = Convert.ToString(DELIVERY + "$");
                lblTotal.Text = Convert.ToString(Math.Round(TOTAL,2) + "$");
            }
            else
            {
                lblStateSubTotal.Hide();
                lblStateTax.Hide();
                lblDelivery.Hide();
                lblStateTotal.Hide();
                lblSubTotal.Hide();
                lblTax.Hide();
                lblDeliveryOption.Hide();
                lblTotal.Hide();
            }
        }
    }
}
