using DrinkAge_1._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjLiang
{
    public partial class FormLiang1 : Form
    {
        DrinkAgeEntities dbContext = new DrinkAgeEntities();
        public FormLiang1(string NickName, string StoreName, string Product)
        {
            InitializeComponent();
            ShowAllCommentSource();
            ShowTopCommentSource();
            ShowLblScoreAvg();
            ShowLblCommentNum();
        }

        private void ShowTopCommentSource()
        {
            this.dataGridView2.DataSource = null;
            var q = (from c in dbContext.Comments
                     where c.Product.ProductName == lblProduct.Text && c.Product.Store.StoreName == lblStore.Text
                     orderby c.GP_Quantity descending
                     select new { c.CommentID, c.ProductID, c.Comment1, c.Star, c.GP_Quantity, c.BP_Quantity, c.Display }).Take(3);

            this.bindingSource2.DataSource = q.ToList();
            this.dataGridView2.DataSource = this.bindingSource2;
        }

        private void ShowLblCommentNum()
        {
            int SumComment = 0;
            var q = from c in dbContext.Comments
                    where c.Product.ProductName == lblProduct.Text && c.Product.Store.StoreName == lblStore.Text
                    group c by c.ProductID into g
                    select g.Count();
            foreach (var s in q)
            {
                SumComment = s;
            }
            lblCommonNum.Text = $"評論數({SumComment}則)";
        }

        private void ShowLblScoreAvg()
        {
            double AvgScore = 0;
            var q = from c in dbContext.Comments
                    where c.Product.ProductName == lblProduct.Text && c.Product.Store.StoreName == lblStore.Text
                    group c by c.ProductID into g
                    select g.Average(c => c.Star);
            foreach (var s in q)
            {
                AvgScore = (double)s;
            }
            lblScoreAvg.Text = AvgScore.ToString("#0.0") + " 分";
        }

        private void ShowAllCommentSource()
        {
            this.dataGridView1.DataSource = null;
            var q = from c in dbContext.Comments
                    where c.Product.ProductName == lblProduct.Text && c.Product.Store.StoreName == lblStore.Text
                    select new { c.CommentID, c.ProductID, c.Comment1, c.Star, c.GP_Quantity, c.BP_Quantity, c.Display };

            this.bindingSource1.DataSource = q.ToList();
            this.dataGridView1.DataSource = this.bindingSource1;
            this.lblChooseComment.DataBindings.Clear();
            this.lblChooseComment.DataBindings.Add("Text", this.bindingSource1, "Comment1", true);
        }


        private void btnCommon_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Products
                    where p.ProductName == lblProduct.Text && p.Store.StoreName == lblStore.Text
                    select p.ProductID;

            int drinkID = 0;
            foreach (var s in q)
            {
                drinkID = s;
            }

            byte[] _picbytes;  //抓照片的二進制
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picBoxComment.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            _picbytes = ms.GetBuffer();

            Comment comment = new Comment { ProductID = drinkID, Comment1 = PeopleCommon.Text, Star = score, GP_Quantity = 0, BP_Quantity = 0, CommentPicture = _picbytes, Display = true };
            this.dbContext.Comments.Add(comment);
            this.dbContext.SaveChanges();

            ShowAllCommentSource();
            ShowTopCommentSource();
            ShowLblScoreAvg();
            ShowLblCommentNum();
        }

        //int likeNum = 0;
        //int dislikeNum = 0;
        //bool likebool = false;
        //bool dislikebool = false;
        //private int _likeNum = 0;
        //private int _dislikeNum = 0;
        //btnlike.BackColor = Color.FromArgb(224, 224, 224);
        //btndislike.BackColor = Color.FromArgb(224, 224, 224);
        //btnlike.BackColor = Color.LightSkyBlue;
        //btndislike.BackColor = Color.Red;
        //private bool _likebool = false;
        //private bool _dislikebool = false;

        private void btnlike_Click(object sender, EventArgs e)
        {
            //_likebool = true;

            var q = from m in dbContext.Members  //取出登入會員的memberID
                    where m.NickName == lblNickName.Text
                    select m.MemberID;

            int _MemberID = 0;
            foreach (var s in q)
            {
                _MemberID = s;
            }

            var b = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;  //找出該登入會員對應的評論明細
            CommentDetail ComDetail = (dbContext.CommentDetails.Where(c => c.CommentID == b && c.MemberID == _MemberID)).FirstOrDefault();
            ComDetail.GP++;

            if (/*_likebool == true &&*/ ComDetail.GP <= 2)
            {

                var a = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

                Comment Com = (dbContext.Comments.Where(c =>
                    c.CommentID == a)).FirstOrDefault();

                if (ComDetail.GP == 1 && ComDetail.BP == 1/*_dislikebool == true*/)
                {
                    Com.GP_Quantity++;
                    Com.BP_Quantity--;
                    //_dislikebool = false;
                    ComDetail.BP = 0;
                    btnlike.BackColor = Color.LightSkyBlue;
                    btndislike.BackColor = Color.FromArgb(224, 224, 224);
                }
                else if (ComDetail.GP == 1 && ComDetail.BP == 0 /*_dislikebool == false*/)
                {
                    Com.GP_Quantity++;
                    btnlike.BackColor = Color.LightSkyBlue;
                }
                else if (ComDetail.GP == 2)
                {
                    Com.GP_Quantity--;
                    ComDetail.GP = 0;
                    btnlike.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            this.dbContext.SaveChanges();
            ShowAllCommentSource();
            ShowTopCommentSource();
        }

        //btnlike.BackColor = Color.FromArgb(224, 224, 224);
        //btndislike.BackColor = Color.FromArgb(224, 224, 224);
        //btnlike.BackColor = Color.LightSkyBlue;
        //btndislike.BackColor = Color.Red;
        private void btndislike_Click(object sender, EventArgs e)
        {
            //_dislikebool = true;

            var q = from m in dbContext.Members  //取出登入會員的memberID
                    where m.NickName == lblNickName.Text
                    select m.MemberID;

            int _MemberID = 0;
            foreach (var s in q)
            {
                _MemberID = s;
            }

            var b = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;  //找出該登入會員對應的評論明細
            CommentDetail ComDetail = (dbContext.CommentDetails.Where(c => c.CommentID == b && c.MemberID == _MemberID)).FirstOrDefault();
            ComDetail.BP++;

            if (/*_dislikebool == true &&*/ ComDetail.BP <= 2)
            {
                var a = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

                Comment Com = (dbContext.Comments.Where(c =>
                    c.CommentID == a)).FirstOrDefault();

                if (ComDetail.BP == 1 && ComDetail.GP == 1 /*_likebool == true*/)
                {
                    Com.GP_Quantity--;
                    Com.BP_Quantity++;
                    ComDetail.GP = 0;
                    btnlike.BackColor = Color.FromArgb(224, 224, 224);
                    btndislike.BackColor = Color.Red;
                    //_likebool = false;

                }
                else if (ComDetail.BP == 1 && ComDetail.GP == 0 /*_likebool == false*/)
                {
                    btndislike.BackColor = Color.Red;
                    Com.BP_Quantity++;
                }
                else if (ComDetail.BP == 2)
                {
                    Com.BP_Quantity--;
                    ComDetail.BP = 0;
                    btndislike.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            this.dbContext.SaveChanges();
            ShowAllCommentSource();
            ShowTopCommentSource();
        }

        private int score;  //星星分數
        private string op;  //選擇按鈕
        private void btnStar_Click(object sender, EventArgs e)
        {
            op = (sender as Button).Name;
            if (op == "star1")
                score = 1;
            else if (op == "star2")
                score = 2;
            else if (op == "star3")
                score = 3;
            else if (op == "star4")
                score = 4;
            else if (op == "star5")
                score = 5;
        }

        private void BindingSourceComment_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AllCommentSelection_change(object sender, EventArgs e)
        {
            var q = from m in dbContext.Members  //取出登入會員的memberID
                    where m.NickName == lblNickName.Text
                    select m.MemberID;

            int _MemberID = 0;
            foreach (var s in q)
            {
                _MemberID = s;
            }

            var a = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;  //找出該登入會員對應的評論明細
            CommentDetail ComDetail = (dbContext.CommentDetails.Where(c => c.CommentID == a && c.MemberID == _MemberID)).FirstOrDefault();

            if (ComDetail.GP == 0 && ComDetail.BP == 0)
            {
                btnlike.BackColor = Color.FromArgb(224, 224, 224);
                btndislike.BackColor = Color.FromArgb(224, 224, 224);
            }
            else if (ComDetail.GP == 1 && ComDetail.BP == 0)
            {
                btnlike.BackColor = Color.LightSkyBlue;
                btndislike.BackColor = Color.FromArgb(224, 224, 224);
            }
            else if (ComDetail.GP == 1 && ComDetail.BP == 1)
            {
                btnlike.BackColor = Color.LightSkyBlue;
                btndislike.BackColor = Color.Red;
            }
            else if (ComDetail.GP == 0 && ComDetail.BP == 1)
            {
                btnlike.BackColor = Color.FromArgb(224, 224, 224);
                btndislike.BackColor = Color.Red;
            }
            else
            {
                btnlike.BackColor = Color.Black;
                btndislike.BackColor = Color.Black;
            }
        }

        private void btnCommentPic_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.picBoxComment.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }
    }
}
