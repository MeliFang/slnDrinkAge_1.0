namespace DrankAge
{
    partial class orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.OrdersStore = new System.Windows.Forms.ComboBox();
            this.店家s = new System.Windows.Forms.Label();
            this.menu1 = new System.Windows.Forms.ListBox();
            this.品名 = new System.Windows.Forms.Label();
            this.店家 = new System.Windows.Forms.Label();
            this.單價s = new System.Windows.Forms.Label();
            this.單價 = new System.Windows.Forms.Label();
            this.品名s = new System.Windows.Forms.Label();
            this.carprice = new System.Windows.Forms.Label();
            this.lorderprice = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insertorders1 = new System.Windows.Forms.Button();
            this.orderdetailsprice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insertshopping = new System.Windows.Forms.Button();
            this.ordersTemperature = new System.Windows.Forms.ComboBox();
            this.OrdersSugar = new System.Windows.Forms.ComboBox();
            this.ordersQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productphoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.OrdersStore);
            this.splitContainer1.Panel1.Controls.Add(this.店家s);
            this.splitContainer1.Panel1.Controls.Add(this.menu1);
            this.splitContainer1.Panel1.Controls.Add(this.品名);
            this.splitContainer1.Panel1.Controls.Add(this.店家);
            this.splitContainer1.Panel1.Controls.Add(this.單價s);
            this.splitContainer1.Panel1.Controls.Add(this.單價);
            this.splitContainer1.Panel1.Controls.Add(this.品名s);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.carprice);
            this.splitContainer1.Panel2.Controls.Add(this.lorderprice);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.ordersSize);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.insertorders1);
            this.splitContainer1.Panel2.Controls.Add(this.orderdetailsprice);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.insertshopping);
            this.splitContainer1.Panel2.Controls.Add(this.ordersTemperature);
            this.splitContainer1.Panel2.Controls.Add(this.OrdersSugar);
            this.splitContainer1.Panel2.Controls.Add(this.ordersQty);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.productphoto);
            this.splitContainer1.Size = new System.Drawing.Size(977, 536);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "店家:";
            // 
            // OrdersStore
            // 
            this.OrdersStore.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrdersStore.FormattingEnabled = true;
            this.OrdersStore.Items.AddRange(new object[] {
            "選擇店家"});
            this.OrdersStore.Location = new System.Drawing.Point(83, 15);
            this.OrdersStore.Name = "OrdersStore";
            this.OrdersStore.Size = new System.Drawing.Size(178, 24);
            this.OrdersStore.TabIndex = 11;
            this.OrdersStore.SelectedIndexChanged += new System.EventHandler(this.OrdersStore_SelectedIndexChanged);
            // 
            // 店家s
            // 
            this.店家s.AutoSize = true;
            this.店家s.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.店家s.Location = new System.Drawing.Point(99, 425);
            this.店家s.Name = "店家s";
            this.店家s.Size = new System.Drawing.Size(21, 21);
            this.店家s.TabIndex = 6;
            this.店家s.Text = ".";
            // 
            // menu1
            // 
            this.menu1.FormattingEnabled = true;
            this.menu1.ItemHeight = 12;
            this.menu1.Location = new System.Drawing.Point(12, 46);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(249, 316);
            this.menu1.TabIndex = 0;
            this.menu1.SelectedIndexChanged += new System.EventHandler(this.menuselect);
            // 
            // 品名
            // 
            this.品名.AutoSize = true;
            this.品名.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.品名.Location = new System.Drawing.Point(28, 371);
            this.品名.Name = "品名";
            this.品名.Size = new System.Drawing.Size(65, 21);
            this.品名.TabIndex = 1;
            this.品名.Text = "品名:";
            // 
            // 店家
            // 
            this.店家.AutoSize = true;
            this.店家.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.店家.Location = new System.Drawing.Point(28, 425);
            this.店家.Name = "店家";
            this.店家.Size = new System.Drawing.Size(65, 21);
            this.店家.TabIndex = 3;
            this.店家.Text = "店家:";
            // 
            // 單價s
            // 
            this.單價s.AutoSize = true;
            this.單價s.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.單價s.Location = new System.Drawing.Point(99, 398);
            this.單價s.Name = "單價s";
            this.單價s.Size = new System.Drawing.Size(21, 21);
            this.單價s.TabIndex = 5;
            this.單價s.Text = ".";
            // 
            // 單價
            // 
            this.單價.AutoSize = true;
            this.單價.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.單價.Location = new System.Drawing.Point(28, 398);
            this.單價.Name = "單價";
            this.單價.Size = new System.Drawing.Size(65, 21);
            this.單價.TabIndex = 2;
            this.單價.Text = "單價:";
            // 
            // 品名s
            // 
            this.品名s.AutoSize = true;
            this.品名s.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.品名s.Location = new System.Drawing.Point(99, 371);
            this.品名s.Name = "品名s";
            this.品名s.Size = new System.Drawing.Size(21, 21);
            this.品名s.TabIndex = 4;
            this.品名s.Text = ".";
            // 
            // carprice
            // 
            this.carprice.AutoSize = true;
            this.carprice.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.carprice.Location = new System.Drawing.Point(606, 341);
            this.carprice.Name = "carprice";
            this.carprice.Size = new System.Drawing.Size(21, 21);
            this.carprice.TabIndex = 16;
            this.carprice.Text = "0";
            // 
            // lorderprice
            // 
            this.lorderprice.AutoSize = true;
            this.lorderprice.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lorderprice.Location = new System.Drawing.Point(491, 341);
            this.lorderprice.Name = "lorderprice";
            this.lorderprice.Size = new System.Drawing.Size(109, 21);
            this.lorderprice.TabIndex = 15;
            this.lorderprice.Text = "訂單總價:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(377, 331);
            this.dataGridView1.TabIndex = 14;
            // 
            // ordersSize
            // 
            this.ordersSize.FormattingEnabled = true;
            this.ordersSize.Location = new System.Drawing.Point(88, 453);
            this.ordersSize.Name = "ordersSize";
            this.ordersSize.Size = new System.Drawing.Size(100, 20);
            this.ordersSize.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(17, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "尺寸:";
            // 
            // insertorders1
            // 
            this.insertorders1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertorders1.Location = new System.Drawing.Point(564, 479);
            this.insertorders1.Name = "insertorders1";
            this.insertorders1.Size = new System.Drawing.Size(108, 36);
            this.insertorders1.TabIndex = 11;
            this.insertorders1.Text = "確定下單";
            this.insertorders1.UseVisualStyleBackColor = true;
            this.insertorders1.Click += new System.EventHandler(this.insertorders1_Click);
            // 
            // orderdetailsprice
            // 
            this.orderdetailsprice.AutoSize = true;
            this.orderdetailsprice.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.orderdetailsprice.Location = new System.Drawing.Point(88, 485);
            this.orderdetailsprice.Name = "orderdetailsprice";
            this.orderdetailsprice.Size = new System.Drawing.Size(21, 21);
            this.orderdetailsprice.TabIndex = 9;
            this.orderdetailsprice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(17, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "總價:";
            // 
            // insertshopping
            // 
            this.insertshopping.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertshopping.Location = new System.Drawing.Point(295, 479);
            this.insertshopping.Name = "insertshopping";
            this.insertshopping.Size = new System.Drawing.Size(108, 36);
            this.insertshopping.TabIndex = 10;
            this.insertshopping.Text = "加入購物車";
            this.insertshopping.UseVisualStyleBackColor = true;
            this.insertshopping.Click += new System.EventHandler(this.insertshopping_Click);
            // 
            // ordersTemperature
            // 
            this.ordersTemperature.FormattingEnabled = true;
            this.ordersTemperature.Location = new System.Drawing.Point(88, 415);
            this.ordersTemperature.Name = "ordersTemperature";
            this.ordersTemperature.Size = new System.Drawing.Size(100, 20);
            this.ordersTemperature.TabIndex = 7;
            // 
            // OrdersSugar
            // 
            this.OrdersSugar.FormattingEnabled = true;
            this.OrdersSugar.Location = new System.Drawing.Point(88, 378);
            this.OrdersSugar.Name = "OrdersSugar";
            this.OrdersSugar.Size = new System.Drawing.Size(100, 20);
            this.OrdersSugar.TabIndex = 6;
            // 
            // ordersQty
            // 
            this.ordersQty.Location = new System.Drawing.Point(88, 340);
            this.ordersQty.Name = "ordersQty";
            this.ordersQty.Size = new System.Drawing.Size(100, 22);
            this.ordersQty.TabIndex = 5;
            this.ordersQty.TextChanged += new System.EventHandler(this.ordersQty_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(17, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "冰塊:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(17, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "甜度:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "數量:";
            // 
            // productphoto
            // 
            this.productphoto.Location = new System.Drawing.Point(12, 3);
            this.productphoto.Name = "productphoto";
            this.productphoto.Size = new System.Drawing.Size(268, 331);
            this.productphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productphoto.TabIndex = 0;
            this.productphoto.TabStop = false;
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 536);
            this.Controls.Add(this.splitContainer1);
            this.Name = "orders";
            this.Text = "orders";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productphoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox menu1;
        private System.Windows.Forms.PictureBox productphoto;
        private System.Windows.Forms.Label 店家s;
        private System.Windows.Forms.Label 單價s;
        private System.Windows.Forms.Label 品名s;
        private System.Windows.Forms.Label 店家;
        private System.Windows.Forms.Label 單價;
        private System.Windows.Forms.Label 品名;
        private System.Windows.Forms.ComboBox ordersTemperature;
        private System.Windows.Forms.ComboBox OrdersSugar;
        private System.Windows.Forms.TextBox ordersQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orderdetailsprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertorders1;
        private System.Windows.Forms.Button insertshopping;
        private System.Windows.Forms.ComboBox ordersSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label carprice;
        private System.Windows.Forms.Label lorderprice;
        private System.Windows.Forms.ComboBox OrdersStore;
        private System.Windows.Forms.Label label6;
    }
}