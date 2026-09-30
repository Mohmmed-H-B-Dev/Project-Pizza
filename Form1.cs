using Project_Pizza;
using System;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        LoginScreen NewLogin = new LoginScreen();
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rbSamll.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

        }

        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatos.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings=sToppings.Substring(1, sToppings.Length-1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;


        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Think Crust";
                return;
            }

            if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }


        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In.";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out.";
                return;
            }

        }

        float GetSelectedSizePrice()
        {
            if (rbSamll.Checked)

                return Convert.ToSingle(rbSamll.Tag);

            else if (rbMedium.Checked)

                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);

        }

        float CalculateToppingsPrice()
        {


            float ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }


            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomatos.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatos.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatos.Tag);
            }



            return ToppingsTotalPrice;



        }

        float GetSelectedCrutPrice()
        {
            if (rbThinCrust.Checked)

                return Convert.ToSingle(rbThinCrust.Tag);

            else
                return Convert.ToSingle(rbThickCrust.Tag);

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice();
        }

        void UpdateTotalPrice()
        {


            lblTotalPrice.Text = "$" + (((float)nudPlusPizza.Value) *  CalculateTotalPrice()).ToString();

        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        void ResetForm()
        {

            //reset Groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            //reset Toppings.
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatos.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            rbThinCrust.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrderPizza.Enabled = true;

            //Reset Numeric Up Down
            nudPlusPizza.Value = 1;


        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Payment_Methodes frm = new Payment_Methodes();
                frm.NItem=" pizza"+gbSize.Text;
                frm.price=(CalculateTotalPrice()  * (float)nudPlusPizza.Value  );
               // btnOrderPizza.Enabled = false;
              //  gbSize.Enabled = false;
              //  gbToppings.Enabled = false;
              //  gbCrustType.Enabled = false;
              //  gbWhereToEat.Enabled = false;


                frm.ShowDialog();

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbSamll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chckGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




            NewLogin.ShowDialog();

            if (NewLogin.tbUserName.Text!=NewLogin.tbUserName.Tag.ToString()||NewLogin.tbPassword.Text!=NewLogin.tbPassword.Tag.ToString())
            {
                this.Close();
            }
            else
            {
                if (NewLogin.IsTrue==true) {
                    this.Close();
                }
                
            }

            UpdateOrderSummary();

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void nudPlusPizza_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnOpenInvoices_Click(object sender, EventArgs e)
        {
            Form frm = new invioces();
            frm.Show();
        }
    }
}
