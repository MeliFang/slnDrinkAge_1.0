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
    public partial class FrmSearch_Fang : Form
    {
        public FrmSearch_Fang()
        {
            InitializeComponent();
            LoadingCboCategory();
            LoadingCboStore();

            this.dataGrid_Comment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGrid_Comment.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void LoadingCboStore()
        {
            this.cboStore.Items.Clear();
            /* SQL DATASET combobox1自動生成可選item*/
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DrinkAge;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("select StoreName from Store", conn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    cboStore.Items.Add(dataReader["StoreName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SystemError!!");
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //LoadingCboCategory();
        }

        private void LoadingCboCategory()
        {
            /* SQL DATASET combobox1自動生成可選item*/
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DrinkAge;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("select CategoryName from Category", conn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    cboCategory.Items.Add(dataReader["CategoryName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SystemError!!");
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
        }


        private void btnComment_Click(object sender, EventArgs e)
        {
            DrinkAgeEntities dbContext = new DrinkAgeEntities();

            var Q = from c in dbContext.Comments
                    select new { c.CommentID, c.Comment1 };

            var Q2 = from p in Q
                     group p by new { p.CommentID, p.Comment1 } into G
                     orderby G.Sum(c => c.CommentID) descending
                     select new { 評論內容 = G.Key.Comment1, 評論總數 = G.Sum(c => c.CommentID) };

            this.dataGrid_Comment.DataSource = Q2.ToList();

        }

        private void btnGPRank_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboCategoryDetail.Items.Clear();
            if (cboCategory != null)
            {
                string s = cboCategory.SelectedItem.ToString();
                if (s == "手搖飲")
                {
                    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DrinkAge;Integrated Security=True");
                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("select CategoryDetailName from CategoryDetail", conn);
                        SqlDataReader dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            cboCategoryDetail.Items.Add(dataReader["CategoryDetailName"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SystemError!!");
                    }
                    finally
                    {
                        conn.Dispose();
                        conn.Close();
                    }
                }
            }
        }

        private void cboCategoryDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory != null && cboCategoryDetail != null)
            {
                //string s = cboCategoryDetail.SelectedItem.ToString();
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DrinkAge;Integrated Security=True");
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"select ProductName as 品名, P.Price as 價格, P.Comment as 簡評, P.Star_AVG as 評價星等,  S.StoreName as 店家名稱, P.CategoryDetailID as 類別ID, C.CategoryDetailName as 類別名稱 from Products as P inner join CategoryDetail as C on P.CategoryDetailID = C.CategoryDetailID inner join Store as S on P.StoreID = S.StoreID group by P.Price, P.StoreID, P.Comment, P.Star_AVG, ProductName, P.CategoryDetailID, C.CategoryDetailName, S.StoreName having P.CategoryDetailID={cboCategoryDetail.SelectedIndex + 1}", conn);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    this.dataGrid_Comment.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SystemError!!");
                }
                finally
                {
                    conn.Dispose();
                    conn.Close();
                }
            }
        }

        private void cboStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DrinkAge;Integrated Security=True");
            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"select S.StoreName, ProductName, P.Price, P.Comment, P.Star_AVG from Products as P inner join Store as S on P.StoreID = S.StoreID group by S.StoreName, ProductName, P.Price, P.Comment, P.Star_AVG, S.StoreName, S.StoreID, P.Comment having S.StoreID ={cboStore.SelectedIndex + 1}", conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                this.dataGrid_Comment.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SystemError!!");
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
        }

        private void btnGPRank_Click_1(object sender, EventArgs e)
        {

        }
    }
}