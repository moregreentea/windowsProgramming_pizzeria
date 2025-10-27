using cis2225_assignment3_cmoreland.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cis2225_assignment3_cmoreland
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void CenterControl(Control control, Control parent)
        {
            control.Location = new Point(
                (parent.ClientSize.Width - control.Width) / 2,
                control.Location.Y
            );
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            CenterControl(lblTitle, tabPage1);
            CenterControl(grpSize, tabPage2);
            CenterControl(grpSauce, tabPage2);
            CenterControl(clbToppings, tabPage2);
            CenterControl(btnAddToOrder, tabPage2);
            CenterControl(lstOrderSummary, tabPage3);
            CenterControl(lblTotalCost, tabPage3);
            CenterControl(btnClear, tabPage3);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza();

            lblTitle.Text = "Connor Moreland's Pizzaria";
            lblTitle.Font = new Font("Arial", 28, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkRed;
            lblTitle.AutoSize = true;
            CenterControl(lblTitle, tabPage1);

            grpSize.Text = "Choose Size:";
            rdoSmall.Text = "Small";
            rdoMedium.Text = "Medium";
            rdoLarge.Text = "Large";
            CenterControl(grpSize, tabPage2);

            grpSauce.Text = "Choose Sauce:";
            rdoRegular.Text = "Regular";
            rdoSpicy.Text = "Spicy";
            CenterControl(grpSauce, tabPage2);

            clbToppings.Text = "Choose Toppings:";
            clbToppings.Items.AddRange(pizza.IngredientList);
            CenterControl(clbToppings, tabPage2);

            btnAddToOrder.Text = "Add to Order";
            CenterControl(btnAddToOrder, tabPage2);

            CenterControl(lstOrderSummary, tabPage3);
            CenterControl(lblTotalCost, tabPage3);
            CenterControl(btnClear, tabPage3);
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            string selectedSize = "";
            if (rdoSmall.Checked)
            {
                selectedSize = "10";
            } else if (rdoLarge.Checked) 
            {
                selectedSize = "14";
            } else
            {
                selectedSize = "12";
            }

            string sauce = rdoSpicy.Checked ? "Spicy" : "Regular";

            string[] selectedToppings = clbToppings.CheckedItems.Cast<string>().ToArray();

            Pizza pizza = new Pizza(selectedSize, sauce, selectedToppings);
            Pizza.OrderList.Add(pizza);

            MessageBox.Show("Pizza Added!");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                lstOrderSummary.Items.Clear();

                double total = 0;

                foreach (Pizza p in Pizza.OrderList)
                {
                    lstOrderSummary.Items.Add(p.ToString());
                    total += p.Cost;
                }

                // Update the label
                lblTotalCost.Text = $"Total: {total:C}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the order?",
                "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Pizza.OrderList.Clear();
                lstOrderSummary.Items.Clear();
                lblTotalCost.Text = "Total: $0.00";
            }
        }
    }
}
