﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TogetherCultureCRM
{
    public partial class Place_Hire : Form
    {
        public Place_Hire()
        {
            InitializeComponent();
        }


        private void homepage_btn_Click(object sender, EventArgs e)
        {
            Homepage newForm = new Homepage();
            newForm.ShowDialog();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {

        }

        private void membership_btn_Click(object sender, EventArgs e)
        {

        }

        private void benefits_btn_Click(object sender, EventArgs e)
        {

        }
    }
