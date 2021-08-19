using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using FibreLib;

namespace FibreForms
{
    public partial class frmMain : Form
    {
        Homes h = new Homes();
        SqlConnection conn = null;

        static string SERVER_Name = @"PAUWLAPTOP\SQLEXPRESS";   //SQL Server Name (eg. <LAPTOP NAME>\SLEXPRESS)
        static string DB_Name = "Fibre-Homes";  //Database Name (Name of your Database created in SSMS)
        static string TBL_Name = "Homes";   //Name of table within Database you are using. (Created in SSMS)

        public string cs = $"Data Source={SERVER_Name};Initial Catalog={DB_Name};Integrated Security=True";
         
        public frmMain()
        {
            InitializeComponent();

            conn = h.connectDB(cs);
            h.dbToList(conn, TBL_Name);
            
            printHomes();
            addOrEdit();
        }

        public void FileMessage(string outcome)
        {
            switch (outcome)
            {
                case "exists":
                    MessageBox.Show("Save file located and homes list imported successfully!");
                    break;
                case "created":
                    MessageBox.Show("Save file created! Any changes will be automatically saved!");
                    break;
            }
        }

        private void btnAddHome_Click(object sender, EventArgs e)
        {
            if (validFields())
            {
                var id = edtOwnerID.Text;
                var address = edtAddress.Text;
                var ownerName = edtOwnerName.Text;
                var fibreProv = edtFibreProv.Text;
                bool isCovered = cbxCovered.Checked;
                int speed = Convert.ToInt32(edtSpeed.Text);
                var isp = edtISP.Text;

                Home newHome = new Home(id, address, ownerName, fibreProv, isCovered, speed, isp);

                if (h.search(edtOwnerID.Text) == null)
                {
                    h.addHome(id, address, ownerName, fibreProv, isCovered, speed, isp);
                }
                else
                {
                    MessageBox.Show("Home was not added! ID already in use.");
                }
            }
            else
            {
                MessageBox.Show("Some fields are invalid! Please check your fields and retry.");
            }

            addOrEdit();
            h.listToDB(conn, TBL_Name);
            printHomes();
        }

        public void printHomes()
        {
            lstHomes.Items.Clear();
            for (int i = 0; i < h.ListSize; i++)
            {
                lstHomes.Items.Add("> " + h.idList()[i]);
            }
        }

        private void lstHomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayHome(lstHomes.SelectedIndex);
        }

        public void displayHome(int index)
        {
            if (lstHomes.SelectedIndex > -1)
            {
                int homeIndex = lstHomes.SelectedIndex;

                Home temp = h.getHome(homeIndex);

                edtOwnerID.Text = temp.ID;
                edtAddress.Text = temp.Address;
                edtOwnerName.Text = temp.Owner;
                edtFibreProv.Text = temp.FibreProvider;
                cbxCovered.Checked = temp.IsCovered;
                edtSpeed.Text = temp.Speed.ToString();
                edtISP.Text = temp.Isp;
            }
        }

        private void edtOwnerID_TextChanged(object sender, EventArgs e)
        {
            addOrEdit();
        }

        public void addOrEdit()
        {
            if (h.search(edtOwnerID.Text) != null)
            {
                btnAddHome.Enabled = false;
                btnUpdateHome.Enabled = !btnAddHome.Enabled;
            }
            else
            {
                btnAddHome.Enabled = true;
                btnUpdateHome.Enabled = !btnAddHome.Enabled;
            }
        }

        private void btnUpdateHome_Click(object sender, EventArgs e)
        {
            if (validFields())
            {
                var id = edtOwnerID.Text;
                var address = edtAddress.Text;
                var ownerName = edtOwnerName.Text;
                var fibreProv = edtFibreProv.Text;
                bool isCovered = cbxCovered.Checked;
                int speed = Convert.ToInt32(edtSpeed.Text);
                var isp = edtISP.Text;

                Home temp = new Home(id, address, ownerName, fibreProv, isCovered, speed, isp);
                int homeIndex = h.getIndex(temp);

                if (h.search(temp.ID) != null)
                {
                    DialogResult dr = MessageBox.Show("You are about to save current Home details!\n" +
                    "Any overwritten data will be lost. Continue?", "Warning", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        h.updateHome(homeIndex, temp);
                    }
                }
                else
                {
                    MessageBox.Show("This house does not exist! Please add it before updating it's details.", "Attention!");
                }
            }

            h.listToDB(conn, TBL_Name);
            printHomes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearSelection();
        }

        public void clearSelection()
        {
            edtOwnerID.Clear();
            edtAddress.Clear();
            edtOwnerName.Clear();
            edtFibreProv.Clear();
            cbxCovered.Checked = false;
            edtSpeed.Clear();
            edtISP.Clear();

            lstHomes.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You are about to delete this home from the list! Continue?", "Warning!", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                h.delHome(h.getHome(lstHomes.SelectedIndex));
                clearSelection();
            }

            h.listToDB(conn, TBL_Name);
            printHomes();
        }

        public bool validFields()
        {
            if (!h.validID(edtOwnerID.Text))
            {
                MessageBox.Show("Invalid ID! \nNumbers only please and make sure length is 13 characters", "Error!");
                edtOwnerID.Focus();
                return false;
            }
            else if (!h.validAddress(edtAddress.Text))
            {
                MessageBox.Show("Invalid Address!", "Error!");
                edtAddress.Focus();
                return false;
            }
            else if (!h.validName(edtOwnerName.Text))
            {
                MessageBox.Show("Invalid Owner Name!", "Error!");
                edtOwnerName.Focus();
                return false;
            }
            else if (!h.validProvider(edtFibreProv.Text))
            {
                MessageBox.Show("Invalid Fibre Provider!", "Error!");
                edtFibreProv.Focus();
                return false;
            }
            else if (!h.validBool(cbxCovered.Checked))
            {
                MessageBox.Show("Invalid Checkbox!", "Error!");
                cbxCovered.Focus();
                return false;
            }
            else if (!h.validSpeed(edtSpeed.Text))
            {
                MessageBox.Show("Invalid Speed! Numbers only Please.", "Error!");
                edtSpeed.Focus();
                return false;
            }
            else if (!h.validIsp(edtISP.Text))
            {
                MessageBox.Show("Invalid ISP!", "Error!");
                edtISP.Focus();
                return false;
            }

            return true;
        }

        private void edtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = edtSearch.Text;
            if (h.validID(id))
            {
                Home findHome = h.search(id);

                if (findHome != null)
                {
                    int index = h.getIndex(findHome);
                    MessageBox.Show("Home found! Loaded into text fields.", "Success!");
                    lstHomes.SelectedIndex = index;
                }
            }
            else
            {
                MessageBox.Show("Invalid ID to search! Please check it and try again.", "Error!");
                edtSearch.Focus();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
