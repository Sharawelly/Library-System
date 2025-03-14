namespace LiberarySystem.Properties
{
    partial class updateuserdetailscs
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
            this.label1 = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.bookTableAdapter1 = new LiberarySystem.ezzDataSetTableAdapters.bookTableAdapter();
            this.passwordbox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "email";
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(354, 159);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(183, 22);
            this.emailbox.TabIndex = 1;
            this.emailbox.TextChanged += new System.EventHandler(this.emailbox_TextChanged);
            // 
            // bookTableAdapter1
            // 
            this.bookTableAdapter1.ClearBeforeFill = true;
            // 
            // passwordbox
            // 
            this.passwordbox.AutoSize = true;
            this.passwordbox.Location = new System.Drawing.Point(252, 230);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(66, 16);
            this.passwordbox.TabIndex = 2;
            this.passwordbox.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 3;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(369, 293);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(130, 36);
            this.updatebtn.TabIndex = 4;
            this.updatebtn.Text = "update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // updateuserdetailscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 574);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.label1);
            this.Name = "updateuserdetailscs";
            this.Text = "updateuserdetailscs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailbox;
        private ezzDataSetTableAdapters.bookTableAdapter bookTableAdapter1;
        private System.Windows.Forms.Label passwordbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button updatebtn;
    }
}