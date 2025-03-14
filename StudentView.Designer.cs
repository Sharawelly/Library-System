namespace LiberarySystem
{
    partial class StudentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentView));
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.borrowbookbtn = new System.Windows.Forms.Button();
            this.returnbookbtn = new System.Windows.Forms.Button();
            this.textBoxbookid = new System.Windows.Forms.TextBox();
            this.addtowaitingbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(550, 117);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(104, 32);
            this.lblSearch.TabIndex = 39;
            this.lblSearch.Text = "Search";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.Location = new System.Drawing.Point(660, 120);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(766, 30);
            this.txtboxSearch.TabIndex = 38;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(553, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(904, 417);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(27, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 136);
            this.panel2.TabIndex = 41;
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
            this.button1.TabIndex = 9;
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
            this.panel1.TabIndex = 40;
            // 
            // borrowbookbtn
            // 
            this.borrowbookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.borrowbookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowbookbtn.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowbookbtn.Image = ((System.Drawing.Image)(resources.GetObject("borrowbookbtn.Image")));
            this.borrowbookbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowbookbtn.Location = new System.Drawing.Point(27, 343);
            this.borrowbookbtn.Name = "borrowbookbtn";
            this.borrowbookbtn.Size = new System.Drawing.Size(148, 67);
            this.borrowbookbtn.TabIndex = 42;
            this.borrowbookbtn.Text = "Borrow";
            this.borrowbookbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.borrowbookbtn.UseVisualStyleBackColor = false;
            this.borrowbookbtn.Click += new System.EventHandler(this.borrowbookbtn_Click);
            // 
            // returnbookbtn
            // 
            this.returnbookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.returnbookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbookbtn.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbookbtn.Image = ((System.Drawing.Image)(resources.GetObject("returnbookbtn.Image")));
            this.returnbookbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnbookbtn.Location = new System.Drawing.Point(322, 343);
            this.returnbookbtn.Name = "returnbookbtn";
            this.returnbookbtn.Size = new System.Drawing.Size(148, 67);
            this.returnbookbtn.TabIndex = 43;
            this.returnbookbtn.Text = "Return";
            this.returnbookbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.returnbookbtn.UseVisualStyleBackColor = false;
            this.returnbookbtn.Click += new System.EventHandler(this.returnbookbtn_Click);
            // 
            // textBoxbookid
            // 
            this.textBoxbookid.Location = new System.Drawing.Point(157, 261);
            this.textBoxbookid.Name = "textBoxbookid";
            this.textBoxbookid.Size = new System.Drawing.Size(313, 22);
            this.textBoxbookid.TabIndex = 44;
            this.textBoxbookid.TextChanged += new System.EventHandler(this.textBoxbookid_TextChanged);
            // 
            // addtowaitingbtn
            // 
            this.addtowaitingbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.addtowaitingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtowaitingbtn.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtowaitingbtn.Image = ((System.Drawing.Image)(resources.GetObject("addtowaitingbtn.Image")));
            this.addtowaitingbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addtowaitingbtn.Location = new System.Drawing.Point(107, 438);
            this.addtowaitingbtn.Name = "addtowaitingbtn";
            this.addtowaitingbtn.Size = new System.Drawing.Size(294, 66);
            this.addtowaitingbtn.TabIndex = 45;
            this.addtowaitingbtn.Text = "Add to Waiting List";
            this.addtowaitingbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addtowaitingbtn.UseVisualStyleBackColor = false;
            this.addtowaitingbtn.Click += new System.EventHandler(this.addtowaitingbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 48;
            this.label2.Text = "Book Isbn";
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1376, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(63, 53);
            this.btnHome.TabIndex = 60;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1457, 592);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addtowaitingbtn);
            this.Controls.Add(this.textBoxbookid);
            this.Controls.Add(this.returnbookbtn);
            this.Controls.Add(this.borrowbookbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentView";
            this.Text = "StudentView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button borrowbookbtn;
        private System.Windows.Forms.Button returnbookbtn;
        private System.Windows.Forms.TextBox textBoxbookid;
        private System.Windows.Forms.Button addtowaitingbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
    }
}