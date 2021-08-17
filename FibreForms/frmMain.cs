using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FibreLib;

namespace FibreForms
{
    public partial class frmMain : Form
    {
        Homes h = new Homes();

        public frmMain()
        {
            InitializeComponent();
            h.ReadText();
            printHomes();
            addOrEdit();
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
            h.toTextFile();
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
                    MessageBox.Show("This house does not exist! Please add it before updating it's details.");
                }
            }
            else
            {
                MessageBox.Show("Some fields are invalid! Please check your fields and retry.");
            }

            h.toTextFile();
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

            h.toTextFile();
            printHomes();
        }

        public bool validFields()
        {
            if (!h.validID(edtOwnerID.Text))
            {
                MessageBox.Show("Invalid ID!");
                return false;
            }
            else if (!h.validAddress(edtAddress.Text))
            {
                MessageBox.Show("Invalid Address!");
                return false;
            }
            else if (!h.validName(edtOwnerName.Text))
            {
                MessageBox.Show("Invalid Owner Name!");
                return false;
            }
            else if (!h.validProvider(edtFibreProv.Text))
            {
                MessageBox.Show("Invalid Fibre Provider!");
                return false;
            }
            else if (!h.validBool(cbxCovered.Checked))
            {
                MessageBox.Show("Invalid Checkbox!");
                return false;
            }
            else if (!h.validSpeed(edtSpeed.Text))
            {
                MessageBox.Show("Invalid Speed!");
                return false;
            }
            else if (!h.validIsp(edtISP.Text))
            {
                MessageBox.Show("Invalid ISP!");
                return false;
            }

            return true;
        }
    }
}
