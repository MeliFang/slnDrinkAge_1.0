using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAge_1._0
{
    public partial class FrmLuck : Form
    {
        DrinkAgeEntities dbContext = new DrinkAgeEntities();
        public FrmLuck()
        {
            InitializeComponent();
            LoadcboCategory();
            LoadcboCategoryDetail();
            LoadcboStore();
        }

        private void LoadcboStore()
        {
            var StoreItems = from o in dbContext.Stores
                             select o;
            foreach (var item in StoreItems)
            {
                this.cboStore.Items.Add(item.StoreName);
            }

        }

        private void LoadcboCategoryDetail()
        {
            var CategoryDeItems = from o in dbContext.CategoryDetails
                                  select o;
            foreach (var item in CategoryDeItems)
            {
                this.cboCategoryDetail.Items.Add(item.CategoryDetailName);
            }
        }

        private void LoadcboCategory()
        {
            var CategoryItems = from o in dbContext.Categories
                                select o;
            foreach (var item in CategoryItems)
            {
                this.cboCategory.Items.Add(item.CategoryName);
            }
        }

        private void btnGoodLuck_Click(object sender, EventArgs e)
        {
            //Select All
            List<int> ProductList = new List<int>();
            Random random = new Random();

            var ProductItems = from items in dbContext.Products
                               where items.ProductID > 0
                               select items;
            foreach (var item in ProductItems)
            {
                ProductList.Add(item.ProductID);
            }
            int num_All = random.Next(0, ProductList.Count);

            List<string> PdNameList = new List<string>();
            var PdNameItems = from items in dbContext.Products
                              select items;
            foreach (var item in PdNameItems)
            {
                PdNameList.Add(item.ProductName);
            }

            //Select Store

            List<string> ListStoreSel = new List<string>();
            var ListStoreItems = from item in dbContext.Products
                                 where item.StoreID == cboStore.SelectedIndex + 1
                                 select new { item.ProductName };
            foreach (var item in ListStoreItems)
            {
                ListStoreSel.Add(item.ProductName);
            }
            int num_Store = random.Next(0, ListStoreSel.Count);

            //Select CategoryDetail
            List<string> ListCategoryDeSel = new List<string>();
            var ListCategoryDeItems = from item in dbContext.Products
                                      where item.CategoryDetailID == cboCategoryDetail.SelectedIndex + 1
                                      select new { item.ProductName };
            foreach (var item in ListCategoryDeItems)
            {
                ListCategoryDeSel.Add(item.ProductName);
            }
            int num_CategoryDe = random.Next(0, ListCategoryDeSel.Count);






            //show
            if (cboCategoryDetail.Text != "")
            {

                MessageBox.Show("今天適合喝" + ListCategoryDeSel[num_CategoryDe]);
            }
            else if (cboStore.Text != "")
            {

                MessageBox.Show("今天適合喝" + ListStoreSel[num_Store]);
            }
            else if (cboCategoryDetail.Text == "" && cboStore.Text == "")
            {
                MessageBox.Show("今天適合喝" + PdNameList[num_All]);
            }
            else
            {
                MessageBox.Show("找不到資料!");
            }





        }

        private void FrmLuck_Load(object sender, EventArgs e)
        {
            DrinkAgeEntities dbContext = new DrinkAgeEntities();


        }

        private void cboCategoryDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoryDetail.Text != "")
            {
                cboStore.Text = "";
            }
        }

        private void cboStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStore.Text != "")
            {
                cboCategoryDetail.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}


