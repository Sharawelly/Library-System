namespace LiberarySystem
{
    partial class AdminView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.dataGridViewbooks = new System.Windows.Forms.DataGridView();
            this.ezzDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ezzDataSet11 = new LiberarySystem.ezzDataSet1();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtboxNumOfPages = new System.Windows.Forms.TextBox();
            this.lblNumOfPages = new System.Windows.Forms.Label();
            this.txtboxISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtboxYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtboxCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxpublisher = new System.Windows.Forms.TextBox();
            this.lblpublisher = new System.Windows.Forms.Label();
            this.txtBoxauthorid = new System.Windows.Forms.TextBox();
            this.lblauthor = new System.Windows.Forms.Label();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ezzDataSet = new LiberarySystem.ezzDataSet();
            this.bookTableAdapter = new LiberarySystem.ezzDataSetTableAdapters.bookTableAdapter();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ezzDataSet1 = new LiberarySystem.ezzDataSet();
            this.ezzDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.waiting = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet11)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewbooks
            // 
            this.dataGridViewbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbooks.Location = new System.Drawing.Point(612, 96);
            this.dataGridViewbooks.Name = "dataGridViewbooks";
            this.dataGridViewbooks.RowHeadersWidth = 51;
            this.dataGridViewbooks.RowTemplate.Height = 24;
            this.dataGridViewbooks.Size = new System.Drawing.Size(827, 494);
            this.dataGridViewbooks.TabIndex = 0;
            this.dataGridViewbooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewbooks_CellContentClick);
            // 
            // ezzDataSet11BindingSource
            // 
            this.ezzDataSet11BindingSource.DataSource = this.ezzDataSet11;
            this.ezzDataSet11BindingSource.Position = 0;
            // 
            // ezzDataSet11
            // 
            this.ezzDataSet11.DataSetName = "ezzDataSet1";
            this.ezzDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.Location = new System.Drawing.Point(710, 34);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(601, 30);
            this.txtboxSearch.TabIndex = 35;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(629, 37);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 25);
            this.lblSearch.TabIndex = 36;
            this.lblSearch.Text = "Search";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(40, 516);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 61);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(238, 516);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 61);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(439, 516);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 61);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtboxNumOfPages
            // 
            this.txtboxNumOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNumOfPages.Location = new System.Drawing.Point(217, 308);
            this.txtboxNumOfPages.Name = "txtboxNumOfPages";
            this.txtboxNumOfPages.Size = new System.Drawing.Size(279, 30);
            this.txtboxNumOfPages.TabIndex = 49;
            // 
            // lblNumOfPages
            // 
            this.lblNumOfPages.AutoSize = true;
            this.lblNumOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfPages.Location = new System.Drawing.Point(35, 308);
            this.lblNumOfPages.Name = "lblNumOfPages";
            this.lblNumOfPages.Size = new System.Drawing.Size(140, 25);
            this.lblNumOfPages.TabIndex = 48;
            this.lblNumOfPages.Text = "Num Of Pages";
            // 
            // txtboxISBN
            // 
            this.txtboxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxISBN.Location = new System.Drawing.Point(217, 150);
            this.txtboxISBN.Name = "txtboxISBN";
            this.txtboxISBN.Size = new System.Drawing.Size(279, 30);
            this.txtboxISBN.TabIndex = 47;
            this.txtboxISBN.TextChanged += new System.EventHandler(this.txtboxISBN_TextChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(35, 150);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(58, 25);
            this.lblISBN.TabIndex = 46;
            this.lblISBN.Text = "ISBN";
            this.lblISBN.Click += new System.EventHandler(this.lblISBN_Click);
            // 
            // txtboxYear
            // 
            this.txtboxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxYear.Location = new System.Drawing.Point(217, 354);
            this.txtboxYear.Name = "txtboxYear";
            this.txtboxYear.Size = new System.Drawing.Size(279, 30);
            this.txtboxYear.TabIndex = 45;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(40, 357);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 25);
            this.lblYear.TabIndex = 44;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // txtboxCategory
            // 
            this.txtboxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCategory.Location = new System.Drawing.Point(217, 256);
            this.txtboxCategory.Name = "txtboxCategory";
            this.txtboxCategory.Size = new System.Drawing.Size(279, 30);
            this.txtboxCategory.TabIndex = 43;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(35, 256);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 42;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTitle.Location = new System.Drawing.Point(217, 202);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.Size = new System.Drawing.Size(279, 30);
            this.txtboxTitle.TabIndex = 41;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(35, 202);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 25);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(27, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 136);
            this.panel2.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 13.8F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-5, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 49);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1457, 16);
            this.panel1.TabIndex = 50;
            // 
            // textboxpublisher
            // 
            this.textboxpublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxpublisher.Location = new System.Drawing.Point(217, 404);
            this.textboxpublisher.Name = "textboxpublisher";
            this.textboxpublisher.ShortcutsEnabled = false;
            this.textboxpublisher.Size = new System.Drawing.Size(279, 30);
            this.textboxpublisher.TabIndex = 53;
            this.textboxpublisher.TextChanged += new System.EventHandler(this.textboxpublisher_TextChanged);
            // 
            // lblpublisher
            // 
            this.lblpublisher.AutoSize = true;
            this.lblpublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpublisher.Location = new System.Drawing.Point(40, 404);
            this.lblpublisher.Name = "lblpublisher";
            this.lblpublisher.Size = new System.Drawing.Size(91, 25);
            this.lblpublisher.TabIndex = 52;
            this.lblpublisher.Text = "publisher";
            this.lblpublisher.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxauthorid
            // 
            this.txtBoxauthorid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxauthorid.Location = new System.Drawing.Point(217, 449);
            this.txtBoxauthorid.Name = "txtBoxauthorid";
            this.txtBoxauthorid.Size = new System.Drawing.Size(279, 30);
            this.txtBoxauthorid.TabIndex = 57;
            this.txtBoxauthorid.TextChanged += new System.EventHandler(this.txtBoxauthorid_TextChanged);
            // 
            // lblauthor
            // 
            this.lblauthor.AutoSize = true;
            this.lblauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblauthor.Location = new System.Drawing.Point(49, 449);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(67, 25);
            this.lblauthor.TabIndex = 56;
            this.lblauthor.Text = "author";
            this.lblauthor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.ezzDataSet;
            // 
            // ezzDataSet
            // 
            this.ezzDataSet.DataSetName = "ezzDataSet";
            this.ezzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "book";
            this.bookBindingSource1.DataSource = this.ezzDataSet;
            // 
            // ezzDataSet1
            // 
            this.ezzDataSet1.DataSetName = "ezzDataSet";
            this.ezzDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ezzDataSet1BindingSource
            // 
            this.ezzDataSet1BindingSource.DataSource = this.ezzDataSet1;
            this.ezzDataSet1BindingSource.Position = 0;
            // 
            // bookBindingSource2
            // 
            this.bookBindingSource2.DataMember = "book";
            this.bookBindingSource2.DataSource = this.ezzDataSet1BindingSource;
            // 
            // waiting
            // 
            this.waiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.waiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waiting.Font = new System.Drawing.Font("MV Boli", 13.8F);
            this.waiting.Image = ((System.Drawing.Image)(resources.GetObject("waiting.Image")));
            this.waiting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.waiting.Location = new System.Drawing.Point(115, 34);
            this.waiting.Name = "waiting";
            this.waiting.Size = new System.Drawing.Size(199, 63);
            this.waiting.TabIndex = 58;
            this.waiting.Text = "waiting list";
            this.waiting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.waiting.UseVisualStyleBackColor = false;
            this.waiting.Click += new System.EventHandler(this.waiting_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1376, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(63, 53);
            this.btnHome.TabIndex = 59;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1457, 592);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.waiting);
            this.Controls.Add(this.txtBoxauthorid);
            this.Controls.Add(this.lblauthor);
            this.Controls.Add(this.textboxpublisher);
            this.Controls.Add(this.lblpublisher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxNumOfPages);
            this.Controls.Add(this.lblNumOfPages);
            this.Controls.Add(this.txtboxISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtboxYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtboxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtboxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.dataGridViewbooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminView";
            this.Text = "x";
            this.Load += new System.EventHandler(this.AdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet11)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezzDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewbooks;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtboxNumOfPages;
        private System.Windows.Forms.Label lblNumOfPages;
        private System.Windows.Forms.TextBox txtboxISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtboxYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtboxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtboxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxpublisher;
        private System.Windows.Forms.Label lblpublisher;
        private System.Windows.Forms.TextBox txtBoxauthorid;
        private System.Windows.Forms.Label lblauthor;
        private ezzDataSet ezzDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private ezzDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.BindingSource ezzDataSet1BindingSource;
        private ezzDataSet ezzDataSet1;
        private ezzDataSet1 ezzDataSet11;
        private System.Windows.Forms.BindingSource ezzDataSet11BindingSource;
        private System.Windows.Forms.BindingSource bookBindingSource2;
        private System.Windows.Forms.Button waiting;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button btnHome;
    }
}