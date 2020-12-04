﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoulderMichigan
{
    public partial class frm_Book : Form
    {
        public frm_Book()
        {
            InitializeComponent();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Services ServicesForm = new frm_Services();
            ServicesForm.Show();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_FAQ FAQForm = new frm_FAQ();
            FAQForm.Show();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_About AboutForm = new frm_About();
            AboutForm.Show();
        }

        private void waiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Waiver WaiverForm = new frm_Waiver();
            WaiverForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Individual_Click(object sender, EventArgs e)
        {
            tmr_Individual.Start();
            if (panel1.Height != 0)
            {
                panel1.Height = 0;
                tmr_Individual.Enabled = false;
            }
        }

        private void tmr_Individual_Tick(object sender, EventArgs e)
        {
            panel1.Height = 500;
            tmr_Individual.Stop();
        }

        private void btn_Couples_Click(object sender, EventArgs e)
        {
            tmr_Couples.Start();
            if (pnl_Couples.Height != 0)
            {
                pnl_Couples.Height = 0;
                tmr_Couples.Enabled = false;
            }
        }

        private void tmr_Couples_Tick(object sender, EventArgs e)
        {
            pnl_Couples.Height = 500;
            tmr_Couples.Stop();
        }

        private void btn_Family_Click(object sender, EventArgs e)
        {
            tmr_Family.Start();
            if (pnl_Family.Height != 0)
            {
                pnl_Family.Height = 0;
                tmr_Family.Enabled = false;
            }
        }

        private void tmr_Family_Tick(object sender, EventArgs e)
        {
            pnl_Family.Height = 500;
            tmr_Family.Stop();
        }

        private void btn_Group_Click(object sender, EventArgs e)
        {
            tmr_Groups.Start();
            if (pnl_Group.Height != 0)
            {
                pnl_Group.Height = 0;
                tmr_Groups.Enabled = false;
            }
        }

        private void tmr_Groups_Tick(object sender, EventArgs e)
        {
            pnl_Group.Height = 500;
            tmr_Groups.Stop();
        }

        private void btn_Classes_Click(object sender, EventArgs e)
        {
            tmr_Classes.Start();
            if (pnl_Classes.Height != 0)
            {
                pnl_Classes.Height = 0;
                tmr_Classes.Enabled = false;
            }
        }

        private void tmr_Classes_Tick(object sender, EventArgs e)
        {
            pnl_Classes.Height = 500;
            tmr_Classes.Stop();
        }

        private void btn_FitnessLab_Click(object sender, EventArgs e)
        {
            tmr_FitnessLab.Start();
            if (pnl_FitnessLab.Height != 0)
            {
                pnl_FitnessLab.Height = 0;
                tmr_FitnessLab.Enabled = false;
            }
        }

        private void tmr_FitnessLab_Tick(object sender, EventArgs e)
        {
            pnl_FitnessLab.Height = 500;
            tmr_FitnessLab.Stop();
        }


        private void btn_LabDaily_Click_1(object sender, EventArgs e)
        {
            frm_FitnessLabDayPass FitnessLabDayPassForm = new frm_FitnessLabDayPass();
            FitnessLabDayPassForm.Show();
        }
    }
}
