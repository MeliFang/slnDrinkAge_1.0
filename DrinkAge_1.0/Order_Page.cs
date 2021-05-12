using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAge_1._0
{
   
    public partial class Order_Page : Form
    {
        //DrinkAgeEntities dbConntext = new DrinkAgeEntities();
        DrinkAgeEntities1 dbconntext = new DrinkAgeEntities1();
        public Order_Page()
        {
            InitializeComponent();
            loadproductinlistbox();
            loadcombobox();
        }
        int memberTest = 2, storID;
        private void loadcombobox()//載入選單
        {
            var q = from s in dbconntext.Sugars
                    where s.SugarID > 0
                    select s;
            foreach (var item in q)
            {
                this.OrdersSugar.Items.Add(item.SugarName);
            }

            var q2 = from t in dbconntext.Temperatures
                     where t.TemperatureID > 0
                     select t;
            foreach (var item in q2)
            {
                this.ordersTemperature.Items.Add(item.TemperatureName);
            }

            var q3 = from sz in dbconntext.Sizes
                     select sz;
            foreach (var item in q3)
            {
                this.ordersSize.Items.Add(item.SizeName);

            }

            var q4 = from st in dbconntext.Stores
                     select st.StoreName;
            foreach (var item in q4)
            {
                this.OrdersStore.Items.Add(item);
            }

            OrdersSugar.SelectedIndex = OrdersSugar.FindStringExact(OrdersSugar.Items[0].ToString());

            ordersTemperature.SelectedIndex = ordersTemperature.FindStringExact(OrdersSugar.Items[0].ToString());

            ordersSize.SelectedIndex = ordersSize.FindStringExact(ordersSize.Items[0].ToString());

            OrdersStore.SelectedIndex = OrdersStore.FindStringExact(OrdersStore.Items[0].ToString());
        }

        int qty = 1, price;

     
        private void loadproductinlistbox() //載入商品
        {
            var q = from p in dbconntext.Products
                    select p.ProductName;
            foreach (var item in q)
            {
                this.menu1.Items.Add(item);
            };


        }

        private void OrdersStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.menu1.Items.Clear();
            var q = from p in dbconntext.Products
                    where p.Store.StoreName == OrdersStore.SelectedItem.ToString()
                    select p.ProductName;
            foreach (var item in q)
            {
                this.menu1.Items.Add(item);
            }
        }

        private void menuselect(object sender, EventArgs e)
        {
            string selectproduct = this.menu1.SelectedItem.ToString();
            byte[] bytes;

            var q = from p in dbconntext.Products
                    where p.ProductName == selectproduct
                    select p;
            foreach (var item in q)
            {

                this.品名s.Text = item.ProductName;
                this.單價s.Text = item.Price.ToString();
                this.店家s.Text = item.Store.StoreName;
                storID = (int)item.StoreID;
                bytes = item.ProductPhoto;
                MemoryStream ms = new MemoryStream(bytes, true);
                ms.Write(bytes, 0, bytes.Length);
                productphoto.Image = new Bitmap(ms);
                ms.Close();
            }
            price = Int32.Parse(單價s.Text);
            this.ordersQty.Text = "0";
            this.orderdetailsprice.Text = (qty * price).ToString();

        }

        private void ordersQty_TextChanged(object sender, EventArgs e)
        {
            if (ordersQty.Text == "")
            {
                ordersQty.Text = "1";
            }
            try
            {
                qty = Int32.Parse(ordersQty.Text);
                price = Int32.Parse(單價s.Text);
                this.orderdetailsprice.Text = (qty * price).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        List<shopping_car> list1 = new List<shopping_car>();

       

        private void insertshopping_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(ordersQty.Text) > 0)
            {
                try
                {

                    int prdID = 0;
                    var QprdID = from id in dbconntext.Products
                                 where id.ProductName == menu1.SelectedItem.ToString()
                                 select id.ProductID;

                    foreach (var item in QprdID)
                    {
                        prdID = item;
                    }

                    list1.Add(new shopping_car()
                    {
                        productID = prdID,
                        unitprice = Int32.Parse(單價s.Text),
                        quantity = Int32.Parse(ordersQty.Text),
                        sizeID = ordersSize.SelectedIndex + 1,
                        sizename = ordersSize.SelectedItem.ToString(),
                        sugarID = OrdersSugar.SelectedIndex + 1,
                        sugarname = OrdersSugar.SelectedItem.ToString(),
                        temperatureID = ordersTemperature.SelectedIndex + 1,
                        temperaturename = ordersTemperature.SelectedItem.ToString()

                    });

                    var q = from car in list1
                            select new
                            {
                                產品編號 = car.productID,
                                單價 = car.unitprice,
                                數量 = car.quantity,
                                大小 = car.sizename,
                                甜度 = car.sugarname,
                                冰塊 = car.temperaturename

                            };
                    this.dataGridView1.DataSource = q.ToList();

                    int pricesave = Int32.Parse(orderdetailsprice.Text);
                    this.carprice.Text = (Int32.Parse(carprice.Text) + pricesave).ToString();
                    this.orderdetailsprice.Text = "0";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Int32.Parse(ordersQty.Text) < 0)
            {
                MessageBox.Show("數量不得為負數");
            }

            else
            {
                MessageBox.Show("數量不得為0");
            }
        }


        private void insertorders1_Click(object sender, EventArgs e)
        {
            int localorderID = 0;
            var addOrder = new Order //新增order資料
            {
                MemberID = memberTest,
                StoreID = storID,
                OrderDate = DateTime.Now,
            };
            dbconntext.Orders.Add(addOrder);
            this.dbconntext.SaveChanges();

            var q = (from o in dbconntext.Orders  //抓剛剛那筆資料
                     where o.MemberID == memberTest
                     orderby o.OrderID descending
                     select o).FirstOrDefault();

            localorderID = q.OrderID;//取的這筆訂單編號

            for (int i = 0; i < list1.Count; i++) //orderDetail新增訂單明細用迴圈加多筆
            {
                var addorderDetail = new Order_Detail
                {
                    OrderID = localorderID,
                    ProductID = list1[i].productID,
                    UnitPrice = list1[i].unitprice,
                    Quantity = list1[i].quantity,
                    SizeID = list1[i].sizeID,
                    SugarID = list1[i].sugarID,
                    TemperatureID = list1[i].temperatureID,

                };
                dbconntext.Order_Details.Add(addorderDetail);
                this.dbconntext.SaveChanges();

            }
            MessageBox.Show("下單成功!!");
        }

        public class shopping_car
        {
            public int productID { get; set; }
            public int unitprice { get; set; }
            public int quantity { get; set; }
            public int sizeID { get; set; }
            public string sizename { get; set; }
            public int sugarID { get; set; }
            public string sugarname { get; set; }
            public int temperatureID { get; set; }
            public string temperaturename { get; set; }

        }
    }
}
