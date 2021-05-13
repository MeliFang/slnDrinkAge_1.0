namespace PrjLiang
{
    partial class FormLiang1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLiang1));
            this.lblProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PeopleCommon = new System.Windows.Forms.RichTextBox();
            this.btnlike = new System.Windows.Forms.Button();
            this.btndislike = new System.Windows.Forms.Button();
            this.star1 = new System.Windows.Forms.Button();
            this.star2 = new System.Windows.Forms.Button();
            this.star3 = new System.Windows.Forms.Button();
            this.star4 = new System.Windows.Forms.Button();
            this.star5 = new System.Windows.Forms.Button();
            this.btnCommon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblScoreAvg = new System.Windows.Forms.Label();
            this.lblCommonNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblStore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblChooseComment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.picBoxComment = new System.Windows.Forms.PictureBox();
            this.btnCommentPic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProduct.Location = new System.Drawing.Point(80, 55);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(72, 16);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "珍珠奶茶";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "評論:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "評價:";
            // 
            // PeopleCommon
            // 
            this.PeopleCommon.Location = new System.Drawing.Point(83, 291);
            this.PeopleCommon.Margin = new System.Windows.Forms.Padding(2);
            this.PeopleCommon.Name = "PeopleCommon";
            this.PeopleCommon.Size = new System.Drawing.Size(286, 126);
            this.PeopleCommon.TabIndex = 5;
            this.PeopleCommon.Text = "";
            // 
            // btnlike
            // 
            this.btnlike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlike.Location = new System.Drawing.Point(429, 617);
            this.btnlike.Margin = new System.Windows.Forms.Padding(2);
            this.btnlike.Name = "btnlike";
            this.btnlike.Size = new System.Drawing.Size(58, 49);
            this.btnlike.TabIndex = 7;
            this.btnlike.Text = "喜翻";
            this.btnlike.UseVisualStyleBackColor = false;
            this.btnlike.Click += new System.EventHandler(this.btnlike_Click);
            // 
            // btndislike
            // 
            this.btndislike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndislike.Location = new System.Drawing.Point(491, 617);
            this.btndislike.Margin = new System.Windows.Forms.Padding(2);
            this.btndislike.Name = "btndislike";
            this.btndislike.Size = new System.Drawing.Size(58, 49);
            this.btndislike.TabIndex = 8;
            this.btndislike.Text = "討M";
            this.btndislike.UseVisualStyleBackColor = false;
            this.btndislike.Click += new System.EventHandler(this.btndislike_Click);
            // 
            // star1
            // 
            this.star1.Location = new System.Drawing.Point(86, 452);
            this.star1.Margin = new System.Windows.Forms.Padding(2);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(46, 54);
            this.star1.TabIndex = 9;
            this.star1.Text = "星星1";
            this.star1.UseVisualStyleBackColor = true;
            this.star1.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // star2
            // 
            this.star2.Location = new System.Drawing.Point(151, 452);
            this.star2.Margin = new System.Windows.Forms.Padding(2);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(46, 54);
            this.star2.TabIndex = 10;
            this.star2.Text = "星星2";
            this.star2.UseVisualStyleBackColor = true;
            this.star2.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // star3
            // 
            this.star3.Location = new System.Drawing.Point(216, 452);
            this.star3.Margin = new System.Windows.Forms.Padding(2);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(46, 54);
            this.star3.TabIndex = 11;
            this.star3.Text = "星星3";
            this.star3.UseVisualStyleBackColor = true;
            this.star3.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // star4
            // 
            this.star4.Location = new System.Drawing.Point(281, 452);
            this.star4.Margin = new System.Windows.Forms.Padding(2);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(46, 54);
            this.star4.TabIndex = 12;
            this.star4.Text = "星星4";
            this.star4.UseVisualStyleBackColor = true;
            this.star4.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // star5
            // 
            this.star5.Location = new System.Drawing.Point(345, 452);
            this.star5.Margin = new System.Windows.Forms.Padding(2);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(46, 54);
            this.star5.TabIndex = 13;
            this.star5.Text = "星星5";
            this.star5.UseVisualStyleBackColor = true;
            this.star5.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnCommon
            // 
            this.btnCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCommon.Location = new System.Drawing.Point(459, 466);
            this.btnCommon.Name = "btnCommon";
            this.btnCommon.Size = new System.Drawing.Size(97, 40);
            this.btnCommon.TabIndex = 14;
            this.btnCommon.Text = "送出評論";
            this.btnCommon.UseVisualStyleBackColor = false;
            this.btnCommon.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblScoreAvg
            // 
            this.lblScoreAvg.AutoSize = true;
            this.lblScoreAvg.Location = new System.Drawing.Point(367, 55);
            this.lblScoreAvg.Name = "lblScoreAvg";
            this.lblScoreAvg.Size = new System.Drawing.Size(53, 12);
            this.lblScoreAvg.TabIndex = 15;
            this.lblScoreAvg.Text = "現有評分";
            // 
            // lblCommonNum
            // 
            this.lblCommonNum.AutoSize = true;
            this.lblCommonNum.Location = new System.Drawing.Point(446, 55);
            this.lblCommonNum.Name = "lblCommonNum";
            this.lblCommonNum.Size = new System.Drawing.Size(41, 12);
            this.lblCommonNum.TabIndex = 16;
            this.lblCommonNum.Text = "評論數";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(24, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "評論區:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(579, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "所有評論:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(582, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 347);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.AllCommentSelection_change);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStore.Location = new System.Drawing.Point(24, 55);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(40, 16);
            this.lblStore.TabIndex = 22;
            this.lblStore.Text = "50嵐";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(579, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "熱門評論:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(582, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(633, 151);
            this.dataGridView2.TabIndex = 24;
            // 
            // lblChooseComment
            // 
            this.lblChooseComment.AutoSize = true;
            this.lblChooseComment.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChooseComment.Location = new System.Drawing.Point(105, 617);
            this.lblChooseComment.Name = "lblChooseComment";
            this.lblChooseComment.Size = new System.Drawing.Size(20, 16);
            this.lblChooseComment.TabIndex = 25;
            this.lblChooseComment.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "選取的評論:";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNickName.Location = new System.Drawing.Point(24, 20);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(93, 16);
            this.lblNickName.TabIndex = 27;
            this.lblNickName.Text = "野原新之助";
            // 
            // picBoxComment
            // 
            this.picBoxComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxComment.Location = new System.Drawing.Point(390, 291);
            this.picBoxComment.Name = "picBoxComment";
            this.picBoxComment.Size = new System.Drawing.Size(166, 126);
            this.picBoxComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxComment.TabIndex = 28;
            this.picBoxComment.TabStop = false;
            // 
            // btnCommentPic
            // 
            this.btnCommentPic.Location = new System.Drawing.Point(480, 423);
            this.btnCommentPic.Name = "btnCommentPic";
            this.btnCommentPic.Size = new System.Drawing.Size(75, 23);
            this.btnCommentPic.TabIndex = 29;
            this.btnCommentPic.Text = "新增照片";
            this.btnCommentPic.UseVisualStyleBackColor = true;
            this.btnCommentPic.Click += new System.EventHandler(this.btnCommentPic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1076, 635);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 31);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "修改評論";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormLiang1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 678);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCommentPic);
            this.Controls.Add(this.picBoxComment);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblChooseComment);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCommonNum);
            this.Controls.Add(this.lblScoreAvg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCommon);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.btndislike);
            this.Controls.Add(this.btnlike);
            this.Controls.Add(this.PeopleCommon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProduct);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLiang1";
            this.Text = "珍珠奶茶評論評價";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox PeopleCommon;
        private System.Windows.Forms.Button btnlike;
        private System.Windows.Forms.Button btndislike;
        private System.Windows.Forms.Button star1;
        private System.Windows.Forms.Button star2;
        private System.Windows.Forms.Button star3;
        private System.Windows.Forms.Button star4;
        private System.Windows.Forms.Button star5;
        private System.Windows.Forms.Button btnCommon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScoreAvg;
        private System.Windows.Forms.Label lblCommonNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblChooseComment;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.PictureBox picBoxComment;
        private System.Windows.Forms.Button btnCommentPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

