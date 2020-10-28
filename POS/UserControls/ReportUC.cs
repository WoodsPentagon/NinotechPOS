﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Interfaces;
using POS.Forms;
using POS.Misc;



namespace POS.UserControls
{
    public enum SaleStatusFilter { All, Pending, Paid, Count }
    public partial class ReportUC : UserControl, ITab
    {
        Button defButton = new Button();
        //int[] ids;

        public ReportUC()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {

        }

        public Control FirstControl()
        {
            return null;
        }

        public Button EnterButton()
        {
            return defButton;
        }

        public void Initialize()
        {
            for (int i = 0; i < (int)SaleStatusFilter.Count; i++)
                saleStatus.Items.Add(((SaleStatusFilter)i).ToString());

            saleStatus.SelectedIndex = 0;

            defButton.Click += DefButton_Click;
            month.Items.Clear();
            for (int i = 0; i < (int)Months.Count; i++)
            {
                month.Items.Add(((Months)i).ToString());
                month.AutoCompleteCustomSource.Add(((Months)i).ToString());
            }

            month.Text = DateTime.Today.ToString("MMMM");
            day.Value = DateTime.Today.Day;
            year.Value = DateTime.Today.Year;
            day.Maximum = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);

            setRegularTableByDate();

            tabControl1.Selected += TabControl1_Selected;

        }

        private void DefButton_Click(object sender, EventArgs e)
        {
            searchBtn.PerformClick();
            chargedSearchBtn.PerformClick();
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
                setRegularTableByDate();

            else if (e.TabPageIndex == 1)
                setCharegedTable();
        }


        private void saleTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var table = (DataGridView)sender;
            int index = (int)(table.SelectedCells[0].Value);

            using (var saleDetails = new SaleDetails())
            {
                saleDetails.SetId(index);
                saleDetails.OnSave += (a, b) => { setCharegedTable(); };
                saleDetails.ShowDialog();
            }
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (month.Items.Count == 0 || year.Value < 1)
                return;

            day.Maximum = DateTime.DaysInMonth((int)year.Value, month.SelectedIndex + 1);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            setRegularTableByDate();
        }

        void setRegularTableByDate()
        {
            string type = SaleType.Regular.ToString();
            saleTable.Rows.Clear();

            IQueryable<Sale> filteredSales;
            using (var p = new POSEntities())
            {
                filteredSales = p.Sales.Where(x => x.Date.Value.Year == (int)year.Value && x.SaleType == SaleType.Regular.ToString());

                if (!string.IsNullOrEmpty(month.Text))
                    filteredSales = filteredSales.Where(x => x.Date.Value.Month == month.SelectedIndex + 1);

                if (!string.IsNullOrEmpty(day.Text))
                    filteredSales = filteredSales.Where(x => x.Date.Value.Day == (int)day.Value);

                totalSale.Text = string.Format("₱ {0:n}", filteredSales.ToArray().Sum(x => x.GetSaleTotalPrice()));

                //ids = filteredSales.Select(x => x.Id).ToArray();

                foreach (var x in filteredSales)
                    saleTable.Rows.Add(x.Id, x.Date.Value.ToString("MMMM dd, yyyy hh:mm: tt"), x.Login?.Username, x.Customer.Name, string.Format("₱ {0:n}", x.GetSaleTotalPrice()));
            }
        }

        void setCharegedTable()
        {
            chargedTable.Rows.Clear();
            using (var p = new POSEntities())
            {
                var sales = p.Sales.Where(x => x.SaleType == SaleType.Charged.ToString()).OrderBy(x => x.Date);
                decimal total = sales.ToArray().Sum(x => x.GetSaleTotalPrice() - x.AmountRecieved ?? 0);

                toBeSettledTxt.Text = string.Format("P {0:n}", total);
                //ids = sales.Select(x => x.Id).ToArray();
                foreach (var x in sales)
                    chargedTable.Rows.Add(x.Id,
                                          x.Date.Value.ToString("MMMM dd, yyyy hh:mm tt"),
                                          x.Login?.Username,
                                          x.Customer.Name,
                                          string.Format("₱ {0:n}", x.GetSaleTotalPrice()),
                                          string.Format("₱ {0:n}", x.AmountRecieved),
                                          string.Format("₱ {0:n}", x.GetSaleTotalPrice() - x.AmountRecieved),
                                          x.AmountRecieved < x.GetSaleTotalPrice() ? false : true);
            }
        }

        private void month_TextChanged(object sender, EventArgs e)
        {
            day.Enabled = month.Text == string.Empty ? false : true;
            if (month.Text == string.Empty)
                day.Text = string.Empty;
        }

        void searchChargeByName()
        {
            //for(int i =0;i< chargedTable.RowCount; i++)
            //{
            //    //// need to lower the case because string.contains is case sensitive :(
            //    string name = chargedTable.Rows[i].Cells[2].Value.ToString().ToLower();
            //    if (name.Contains(chargedSaleSearch.Text.ToLower()))
            //    {
            //        chargedTable.Rows[i].Selected = true;
            //        chargedTable.FirstDisplayedScrollingRowIndex = i;
            //        break;
            //    }
            //}       
            chargedTable.Rows.Clear();
            using (var p = new POSEntities())
            {
                var sales = p.Sales.Where(x => x.SaleType == SaleType.Charged.ToString() && x.Customer.Name.Contains(chargedSaleSearch.Text)).OrderBy(x => x.Date);
                //ids = sales.Select(x => x.Id).ToArray();
                foreach (var x in sales)
                    chargedTable.Rows.Add(x.Id, x.Date.Value.ToString("MMMM dd, yyyy hh:mm tt"), x.Login?.Username, x.Customer.Name, string.Format("₱ {0:n}", x.GetSaleTotalPrice()), string.Format("₱ {0:n}", x.AmountRecieved), x.AmountRecieved < x.GetSaleTotalPrice() ? false : true);
            }

        }

        private void chargedSearchBtn_Click(object sender, EventArgs e)
        {
            searchChargeByName();
        }

        private void chargedSaleSearch_TextChanged(object sender, EventArgs e)
        {
            if (chargedSaleSearch.Text == string.Empty)
                setCharegedTable();
        }

        private void chargedSaleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchChargeByName();
        }

        private void month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                setRegularTableByDate();
        }

        public void Refresh_Callback(object sender, EventArgs e)
        {
            setRegularTableByDate();
            setCharegedTable();
        }

        private void regularSalesTab_Click(object sender, EventArgs e)
        {

        }

        private void chargedPage_Click(object sender, EventArgs e)
        {

        }

        private void saleStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargedTable.Rows.Clear();

            using (var p = new POSEntities())
            {
                var sales = p.Sales.ToArray().Where(x => x.SaleType == SaleType.Charged.ToString());

                if (chargedSaleSearch.Text != string.Empty)
                {
                    sales = sales.Where(x => x.Customer.Name.Contains(chargedSaleSearch.Text));
                }

                if (saleStatus.Text == "Pending")
                {
                    Console.WriteLine("hey");
                    sales = sales.ToArray().Where(x => x.GetSaleTotalPrice() > x.AmountRecieved);
                }
                else if (saleStatus.Text == "Paid")
                {
                    sales = sales.ToArray().Where(x => x.GetSaleTotalPrice() <= x.AmountRecieved);
                }


                //ids = sales.Select(x => x.Id).ToArray();
                foreach (var x in sales.OrderBy(x => x.Date))
                    chargedTable.Rows.Add(x.Id, x.Date.Value.ToString("MMMM dd, yyyy hh:mm tt"), x.Login?.Username, x.Customer.Name, string.Format("₱ {0:n}", x.GetSaleTotalPrice()), string.Format("₱ {0:n}", x.AmountRecieved), x.AmountRecieved < x.GetSaleTotalPrice() ? false : true);
            }
        }
    }
}
