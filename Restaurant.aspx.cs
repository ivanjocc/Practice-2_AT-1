using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice2
{
    public partial class Restaurant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                evaluation.Visible = false;

                CreateEntries();
                CreatePlats();
                CreateDesserts();
                CreateBoisson();
                CreateGender();

            }
        }

        private void CreateGender()
        {
            ListItem item = new ListItem();
            item.Text = "Femme";
            item.Selected = true;
            lstRbtnGender.Items.Add(item);

            lstRbtnGender.Items.Add(new ListItem("Homme"));
        }

        private void CreateBoisson()
        {
            ListItem item = new ListItem();
            item.Text = "Cafe";
            item.Value = "2";
            lstChkBoisson.Items.Add(item);

            lstChkBoisson.Items.Add(new ListItem("Coca Cola", "5"));

            lstChkBoisson.Items.Add(new ListItem("Te", "3"));

            lstChkBoisson.Items.Add(new ListItem("Agua", "0"));

        }

        private void CreateDesserts()
        {
            ListItem item = new ListItem();
            item.Text = "Cheesecake";
            item.Value = "30";
            item.Selected = true;
            lstRbtnDessert.Items.Add(item);

            lstRbtnDessert.Items.Add(new ListItem("Chocolate", "20"));

            lstRbtnDessert.Items.Add(new ListItem("Fresa", "15"));

            lstRbtnDessert.Items.Add(new ListItem("Zanahoria", "25"));
        }

        private void CreatePlats()
        {
            ListItem item = new ListItem();
            item.Text = "Carne";
            item.Value = "20";
            item.Selected = true;
            lstBPlat.Items.Add(item);

            lstBPlat.Items.Add(new ListItem("Pollo", "15"));

            lstBPlat.Items.Add(new ListItem("Costillitas", "30"));

            lstBPlat.Items.Add(new ListItem("Cerdo", "25"));
        }

        private void CreateEntries()
        {
            ListItem item = new ListItem();
            item.Text = "Choose your entry";
            item.Value = "0";
            lstDDEntry.Items.Add(item);

            lstDDEntry.Items.Add(new ListItem("Patacones", "10"));

            lstDDEntry.Items.Add(new ListItem("Yuca", "5"));

            lstDDEntry.Items.Add(new ListItem("Empanadas", "5"));

            lstDDEntry.Items.Add(new ListItem("Chicharrones", "10"));
        }

        protected void lstRbtnGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDDEntry.SelectedIndex != 0)
            {
                ShowInfo();
            } else
            {
                evaluation.Visible = false;
            }
        }

        private void ShowInfo()
        {
            evaluation.Visible = true;

            string name = txtNom.Text;
            string gender = lstRbtnGender.SelectedItem.Text;
            string entry = lstDDEntry.SelectedItem.Text;
            string entryVal = lstDDEntry.SelectedItem.Value;
            string plat = lstBPlat.SelectedItem.Text;
            string platVal = lstBPlat.SelectedItem.Value;
            string dessert = lstRbtnDessert.SelectedItem.Text;
            string dessertVal = lstRbtnDessert.SelectedItem.Value;

            string drinks = "";

            decimal drinksPrice = 0;
            decimal totalSansTaxes = 0;
            decimal taxesTip = 0.3m;
            decimal total = 0;


            string info = "";

            if (gender == "Femme")
            {
                info +=  "<strong>" + "Ms " + "</strong>" + "<strong>" + name + "</strong>" + ", votre facture" + "<br />";
            }
            else
            {
                info +=  "<strong>" + "Mr " + "</strong>" + "<strong>" + name + "</strong>" + ", votre facture" + "<br />";
            }

            info += "<strong>" + "Entree" + "</strong>" + "<br />";

            info += " -   " + entry + " $" + entryVal + "<br />";

            info += "<strong>" + "Plat principal" + "</strong>" + "<br />";

            info += " -   " + plat + " $" + platVal+ "<br />";
            
            info += "<strong>" + "Dessert" + "</strong>" + "<br />";

            info += " -   " + dessert + " $" + dessertVal+ "<br />";

            foreach (ListItem drink in lstChkBoisson.Items)
            {
                if (drink.Selected)
                {
                    drinks += " -   " + drink + " $" + drink.Value +  "<br />";
                }
            }

            info += "<strong>" + "Boisson" + "</strong>" + "<br />";

            info += drinks + "<br />";

            foreach (ListItem drink in lstChkBoisson.Items)
            {
                if (drink.Selected)
                {
                    drinksPrice += Convert.ToDecimal(drink.Value);
                }
            }

            totalSansTaxes = 
                Convert.ToDecimal(entryVal) + 
                Convert.ToDecimal(platVal) +
                Convert.ToDecimal(dessertVal) +
                drinksPrice;

            info += "<hr>";

            info += "<strong>" + "Total sans tanxes " + "</strong>" + " $" + totalSansTaxes + "<br />";

            info += "<strong>" + "Taxes + Tip " + "</strong>" + " $" + taxesTip * totalSansTaxes+ "<br />";
            
            info += "<hr>";

            total = (taxesTip * totalSansTaxes) + totalSansTaxes;

            info += "<strong>" + "Total " + "</strong>" + " $" + total + "<br />";

            lblEvaluation.Text = info;
        }

        protected void lstBPlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDDEntry.SelectedIndex != 0)
            {
                ShowInfo();
            }
            else
            {
                evaluation.Visible = false;
            }
        }

        protected void lstRbtnDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDDEntry.SelectedIndex != 0)
            {
                ShowInfo();
            }
            else
            {
                evaluation.Visible = false;
            }
        }

        protected void lstChkBoisson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDDEntry.SelectedIndex != 0)
            {
                ShowInfo();
            }
            else
            {
                evaluation.Visible = false;
            }
        }

        protected void lstDDEntry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDDEntry.SelectedIndex != 0)
            {
                ShowInfo();
            }
        }

        protected void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (lstDDEntry.SelectedIndex != 0)
            {
                ShowInfo();
            }
        }
    }
}