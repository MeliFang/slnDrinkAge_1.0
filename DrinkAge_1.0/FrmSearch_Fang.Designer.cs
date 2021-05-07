namespace DrinkAge_1._0
{
    partial class FrmSearch_Fang
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
            this.dataGrid_List = new System.Windows.Forms.DataGridView();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_store = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnGPRank = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.cboCategoryDetail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productsTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.ProductsTableAdapter();
            this.categoryDetailTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.CategoryDetailTableAdapter();
            this.categoryTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.CategoryTableAdapter();
            this.storeTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.StoreTableAdapter();
            this.commentTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.CommentTableAdapter();
            this.da_DataSet1 = new DrinkAge_1._0.da_DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.da_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_List
            // 
            this.dataGrid_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_List.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_List.ColumnHeadersHeight = 29;
            this.dataGrid_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGrid_List.Location = new System.Drawing.Point(11, 200);
            this.dataGrid_List.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGrid_List.Name = "dataGrid_List";
            this.dataGrid_List.RowHeadersWidth = 51;
            this.dataGrid_List.RowTemplate.Height = 27;
            this.dataGrid_List.Size = new System.Drawing.Size(711, 218);
            this.dataGrid_List.TabIndex = 0;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(102, 119);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(151, 30);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboStore
            // 
            this.cboStore.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(289, 119);
            this.cboStore.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(163, 30);
            this.cboStore.TabIndex = 2;
            this.cboStore.SelectedIndexChanged += new System.EventHandler(this.cboStore_SelectedIndexChanged);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_category.Location = new System.Drawing.Point(13, 86);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(95, 22);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "依分類搜尋";
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_store.Location = new System.Drawing.Point(284, 86);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(95, 22);
            this.lbl_store.TabIndex = 4;
            this.lbl_store.Text = "依店家搜尋";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "DrinkAge  Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(468, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "熱門排行";
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnComment.Location = new System.Drawing.Point(466, 67);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(104, 44);
            this.btnComment.TabIndex = 7;
            this.btnComment.Text = "熱門討論";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnGPRank
            // 
            this.btnGPRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGPRank.Location = new System.Drawing.Point(466, 123);
            this.btnGPRank.Name = "btnGPRank";
            this.btnGPRank.Size = new System.Drawing.Size(104, 44);
            this.btnGPRank.TabIndex = 8;
            this.btnGPRank.Text = "GP RANK";
            this.btnGPRank.UseVisualStyleBackColor = false;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoadData.Location = new System.Drawing.Point(214, 10);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(104, 44);
            this.btnLoadData.TabIndex = 9;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // cboCategoryDetail
            // 
            this.cboCategoryDetail.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboCategoryDetail.FormattingEnabled = true;
            this.cboCategoryDetail.Location = new System.Drawing.Point(102, 160);
            this.cboCategoryDetail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboCategoryDetail.Name = "cboCategoryDetail";
            this.cboCategoryDetail.Size = new System.Drawing.Size(151, 30);
            this.cboCategoryDetail.TabIndex = 10;
            this.cboCategoryDetail.SelectedIndexChanged += new System.EventHandler(this.cboCategoryDetail_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "類別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(7, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "類別細項";
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // categoryDetailTableAdapter1
            // 
            this.categoryDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // storeTableAdapter1
            // 
            this.storeTableAdapter1.ClearBeforeFill = true;
            // 
            // commentTableAdapter1
            // 
            this.commentTableAdapter1.ClearBeforeFill = true;
            // 
            // da_DataSet1
            // 
            this.da_DataSet1.DataSetName = "da_DataSet";
            this.da_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmSearch_Fang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategoryDetail);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnGPRank);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_store);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cboStore);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.dataGrid_List);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmSearch_Fang";
            this.Text = "FrmSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.da_DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_List;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboStore;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_store;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Button btnGPRank;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ComboBox cboCategoryDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private da_DataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private da_DataSetTableAdapters.CategoryDetailTableAdapter categoryDetailTableAdapter1;
        private da_DataSetTableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private da_DataSetTableAdapters.StoreTableAdapter storeTableAdapter1;
        private da_DataSetTableAdapters.CommentTableAdapter commentTableAdapter1;
        private da_DataSet da_DataSet1;
    }
}