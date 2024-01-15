using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if(SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if(SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if(SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if(ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if(ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {
            if(CheeseCb.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if(CheeseCb.Checked == false)
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if(TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if(TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void CococolaCb_CheckedChanged(object sender, EventArgs e)
        {
            if(CococolaCb.Checked == true)
            {
                CococolaTb.Enabled = true;
            }
            if (CococolaCb.Checked == false)
            {
                CococolaTb.Enabled = false;
                CococolaTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if(WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if(WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void ChocolatesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(ChocolatesCb.Checked == true)
            {
                ChocolatesTb.Enabled = true;
            }
            if(ChocolatesCb.Checked == false)
            {
                ChocolatesTb.Enabled = false;
                ChocolatesTb.Text = "0";
            }
        }

        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if(PancakesCb.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0"; 
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if(OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if(OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Declare Unit Price to Different meal and Drinks
        double friesup = 120, burgerup = 150, saladup = 110, sandwichup = 180, chickenup = 300, cheeseup = 280;

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            CheeseCb.Checked = false;
            TeaCb.Checked = false;
            CococolaCb.Checked = false;
            WaterCb.Checked = false;
            ChocolatesCb.Checked = false;
            PancakesCb.Checked = false;
            OrangeCb.Checked = false;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text + " Subtotal " + Subtotallbl.Text + "Tax: " + Taxlbl.Text + "total " + Totallbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void Subtotallbl_Click(object sender, EventArgs e)
        {

        }

        double teaup = 50, cococolaup = 70, waterup = 20, chocolatesup = 80, pancakesup = 120, orangeup = 110;
        
        //Declares variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwichtp, chickentp, cheesetp, teatp, cococolatp, watertp, chocolatestp, pancakestp, orangetp;
        double Subtotal = 0, tax, total;
        

        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);

            // Let do the same thing for drinks and deserts

            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            cococolatp = cococolaup * Convert.ToDouble(CococolaTb.Text);
            watertp = waterup * Convert.ToDouble(WaterTb.Text);
            chocolatestp = chocolatesup * Convert.ToDouble(ChocolatesTb.Text);
            pancakestp = pancakesup * Convert.ToDouble(PancakesTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);

            //Now Let's Add Products on the receipt
            ReceiptTb.Clear();
            total = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\tCODESPACE RESTAURANT\t\t"+Datelbl.Text+Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t**********************" +Environment.NewLine);

            if(FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFries:\t" + friestp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if(BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:\t" + saladtp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:\t" + sandwichtp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + sandwichtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:\t" + chickentp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + chickentp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (CheeseCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCheese:\t" + cheesetp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + cheesetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (CococolaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCococola:\t" + cococolatp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + cococolatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\tWater:\t" + watertp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + watertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChocolatesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChocolates:\t" + chocolatestp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + chocolatestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (PancakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPancakes:\t" + pancakestp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + pancakestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tOrange:\t" + orangetp + "RS" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            tax = Subtotal * 0.20; // According to nepal government tax rules 20% tax had been added this tax rate can be changed according to Palace//
            total = Subtotal + tax;
            Taxlbl.Text = "RS" + total;
            Totallbl.Text = "RS" + total;
          











        }
    }
}
