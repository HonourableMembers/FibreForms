﻿using System;
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

            addOrEdit();
            h.toTextFile();
            printHomes();
        }

        public void printHomes()
        {
            lstHomes.Items.Clear();
            for (int i = 0; i < h.ListSize; i++)
            {
                lstHomes.Items.Add(" - " + h.stringList()[i]);
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
                Home tempHome = h.getHome(index);

                edtOwnerID.Text = tempHome.ID;
                edtAddress.Text = tempHome.Address;
                edtOwnerName.Text = tempHome.Owner;
                edtFibreProv.Text = tempHome.FibreProvider;
                cbxCovered.Checked = tempHome.IsCovered;
                edtSpeed.Text = tempHome.Speed.ToString();
                edtISP.Text = tempHome.Isp;
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
            if (h.search(h.getHome(lstHomes.SelectedIndex).ID) != null)
            {
                DialogResult dr = MessageBox.Show("You are about to save current Home details!\n" +
                "Any overwritten data will be lost. Continue?", "Warning", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    var id = edtOwnerID.Text;
                    var address = edtAddress.Text;
                    var ownerName = edtOwnerName.Text;
                    var fibreProv = edtFibreProv.Text;
                    bool isCovered = cbxCovered.Checked;
                    int speed = Convert.ToInt32(edtSpeed.Text);
                    var isp = edtISP.Text;

                    Home newHome = new Home(id, address, ownerName, fibreProv, isCovered, speed, isp);

                    h.updateHome(lstHomes.SelectedIndex, newHome);
                }
            }
            else
            {
                MessageBox.Show("This house does not exist! Please add it before updating it's details.");
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
    }
}
