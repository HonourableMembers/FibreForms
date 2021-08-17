
namespace FibreForms
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddHome = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateHome = new System.Windows.Forms.Button();
            this.btnAddHome = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCovered = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtFibreProv = new System.Windows.Forms.TextBox();
            this.edtISP = new System.Windows.Forms.TextBox();
            this.edtOwnerName = new System.Windows.Forms.TextBox();
            this.edtSpeed = new System.Windows.Forms.TextBox();
            this.edtAddress = new System.Windows.Forms.TextBox();
            this.edtOwnerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstHomes = new System.Windows.Forms.ListBox();
            this.pnlAddHome.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddHome
            // 
            this.pnlAddHome.Controls.Add(this.button2);
            this.pnlAddHome.Controls.Add(this.button1);
            this.pnlAddHome.Controls.Add(this.btnUpdateHome);
            this.pnlAddHome.Controls.Add(this.btnAddHome);
            this.pnlAddHome.Controls.Add(this.label6);
            this.pnlAddHome.Controls.Add(this.label5);
            this.pnlAddHome.Controls.Add(this.cbxCovered);
            this.pnlAddHome.Controls.Add(this.label4);
            this.pnlAddHome.Controls.Add(this.label3);
            this.pnlAddHome.Controls.Add(this.label2);
            this.pnlAddHome.Controls.Add(this.edtFibreProv);
            this.pnlAddHome.Controls.Add(this.edtISP);
            this.pnlAddHome.Controls.Add(this.edtOwnerName);
            this.pnlAddHome.Controls.Add(this.edtSpeed);
            this.pnlAddHome.Controls.Add(this.edtAddress);
            this.pnlAddHome.Controls.Add(this.edtOwnerID);
            this.pnlAddHome.Controls.Add(this.label1);
            this.pnlAddHome.Controls.Add(this.lblAddTitle);
            this.pnlAddHome.Location = new System.Drawing.Point(257, 12);
            this.pnlAddHome.Name = "pnlAddHome";
            this.pnlAddHome.Size = new System.Drawing.Size(263, 330);
            this.pnlAddHome.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(144, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear Fields";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateHome
            // 
            this.btnUpdateHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateHome.Location = new System.Drawing.Point(3, 297);
            this.btnUpdateHome.Name = "btnUpdateHome";
            this.btnUpdateHome.Size = new System.Drawing.Size(116, 23);
            this.btnUpdateHome.TabIndex = 8;
            this.btnUpdateHome.Text = "Update Home";
            this.btnUpdateHome.UseVisualStyleBackColor = false;
            this.btnUpdateHome.Click += new System.EventHandler(this.btnUpdateHome_Click);
            // 
            // btnAddHome
            // 
            this.btnAddHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddHome.ForeColor = System.Drawing.Color.Black;
            this.btnAddHome.Location = new System.Drawing.Point(3, 268);
            this.btnAddHome.Name = "btnAddHome";
            this.btnAddHome.Size = new System.Drawing.Size(116, 23);
            this.btnAddHome.TabIndex = 7;
            this.btnAddHome.Text = "Add Home";
            this.btnAddHome.UseVisualStyleBackColor = false;
            this.btnAddHome.Click += new System.EventHandler(this.btnAddHome_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "ISP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Line Speed";
            // 
            // cbxCovered
            // 
            this.cbxCovered.AutoSize = true;
            this.cbxCovered.Location = new System.Drawing.Point(3, 207);
            this.cbxCovered.Name = "cbxCovered";
            this.cbxCovered.Size = new System.Drawing.Size(86, 19);
            this.cbxCovered.TabIndex = 5;
            this.cbxCovered.Text = "Is Covered?";
            this.cbxCovered.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fibre Provider";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Home Owner Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // edtFibreProv
            // 
            this.edtFibreProv.Location = new System.Drawing.Point(3, 178);
            this.edtFibreProv.Name = "edtFibreProv";
            this.edtFibreProv.Size = new System.Drawing.Size(113, 23);
            this.edtFibreProv.TabIndex = 2;
            // 
            // edtISP
            // 
            this.edtISP.Location = new System.Drawing.Point(142, 90);
            this.edtISP.Name = "edtISP";
            this.edtISP.Size = new System.Drawing.Size(113, 23);
            this.edtISP.TabIndex = 2;
            // 
            // edtOwnerName
            // 
            this.edtOwnerName.Location = new System.Drawing.Point(3, 134);
            this.edtOwnerName.Name = "edtOwnerName";
            this.edtOwnerName.Size = new System.Drawing.Size(113, 23);
            this.edtOwnerName.TabIndex = 2;
            // 
            // edtSpeed
            // 
            this.edtSpeed.Location = new System.Drawing.Point(142, 46);
            this.edtSpeed.Name = "edtSpeed";
            this.edtSpeed.Size = new System.Drawing.Size(113, 23);
            this.edtSpeed.TabIndex = 2;
            // 
            // edtAddress
            // 
            this.edtAddress.Location = new System.Drawing.Point(3, 90);
            this.edtAddress.Name = "edtAddress";
            this.edtAddress.Size = new System.Drawing.Size(113, 23);
            this.edtAddress.TabIndex = 2;
            // 
            // edtOwnerID
            // 
            this.edtOwnerID.Location = new System.Drawing.Point(3, 46);
            this.edtOwnerID.Name = "edtOwnerID";
            this.edtOwnerID.Size = new System.Drawing.Size(113, 23);
            this.edtOwnerID.TabIndex = 2;
            this.edtOwnerID.TextChanged += new System.EventHandler(this.edtOwnerID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home Owner ID";
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddTitle.Location = new System.Drawing.Point(3, 0);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(129, 28);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Home Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Homes List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstHomes);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 330);
            this.panel2.TabIndex = 4;
            // 
            // lstHomes
            // 
            this.lstHomes.FormattingEnabled = true;
            this.lstHomes.ItemHeight = 15;
            this.lstHomes.Location = new System.Drawing.Point(3, 31);
            this.lstHomes.Name = "lstHomes";
            this.lstHomes.Size = new System.Drawing.Size(229, 289);
            this.lstHomes.TabIndex = 1;
            this.lstHomes.SelectedIndexChanged += new System.EventHandler(this.lstHomes_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAddHome);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.pnlAddHome.ResumeLayout(false);
            this.pnlAddHome.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtOwnerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Button btnAddHome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxCovered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtFibreProv;
        private System.Windows.Forms.TextBox edtISP;
        private System.Windows.Forms.TextBox edtOwnerName;
        private System.Windows.Forms.TextBox edtSpeed;
        private System.Windows.Forms.TextBox edtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstHomes;
        private System.Windows.Forms.Button btnUpdateHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

