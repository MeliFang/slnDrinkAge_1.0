using DrinkAge.會員.mods;
using DrinkAge_1._0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAge.會員
{
    public partial class member03 : Form
    {
        public member03()
        {
            InitializeComponent();
            AllData();
            PictureDrop();
        }

        private void PictureDrop()
        {
            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragDrop += PictureBox1_DragDrop;
            this.pictureBox1.DragEnter += PictureBox1_DragEnter;
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filesname = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.pictureBox1.Image = Image.FromFile(filesname[0]);

            PictureSave();
        }

        private void PictureSave()
        {
            try
            {
                string connstring = Settings.Default.DrinkAgeConnectionString;
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandText = $"update Member Set MemberPIC=(@MemberPIC) where Account='{CViewBag.currentUser}'";
                        command.Connection = conn;


                        byte[] bytes = { };
                        MemoryStream ms = new MemoryStream();
                        this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytes = ms.GetBuffer();

                        command.Parameters.Add("@MemberPIC", SqlDbType.VarBinary).Value = bytes;

                        conn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("變更成功");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllData()
        {
            try
            {
                string constring = Settings.Default.DrinkAgeConnectionString;
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"select * from Member where Account='{CViewBag.currentUser}'",conn);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {                       
                        CViewid.currentUserid = (int)reader["MemberID"];
                        this.label5.Text = (string)reader["RealName"];
                        this.label7.Text = (string)reader["NickName"];
                        this.label13.Text = Convert.ToDateTime(reader["Birth"]).ToString("yyyy年MM月dd日");
                        this.label14.Text = (string)reader["Gender"];
                        this.label15.Text = (string)reader["Email"];
                        this.label16.Text = (string)reader["Phone"];
                        this.label17.Text = (string)reader["Address"];
                        this.label20.Text = reader["Level"].ToString();
                        this.label21.Text = reader["Point"].ToString();                      
                        loadAchvid();

                        byte[] imageData = (byte[])reader["MemberPIC"];
                        MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length);
                        this.pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadAchvid()
        {
            try
            {
                string constring = Settings.Default.DrinkAgeConnectionString;
                SqlConnection conn = new SqlConnection(constring);

                conn.Open();
                    SqlCommand command = new SqlCommand($"select m.ACHVID,m.MemberACHVID,a.ACHVName from Achievements as a join MemberACHV as m on a.ACHVID=m.ACHVID group by m.ACHVID,m.MemberID,m.MemberACHVID,a.ACHVName   Having m.MemberID='{CViewid.currentUserid}'", conn);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        this.comboBox1.Items.Add(reader["ACHVName"]);
                    }

                conn.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }
    }
}
