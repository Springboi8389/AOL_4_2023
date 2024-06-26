﻿using aol.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class weather : Win95Theme
    {

        private void MiniBtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }

        private void Weather_Shown(object sender, EventArgs e)
        {
            List<string> tmpCityState = new List<string>();
            tmpCityState = location.getCityState();
            cityStateLabel.Text = tmpCityState[0] + ", " + tmpCityState[1];
            //location.getForecastWeather(); // test
        }

        private void Panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }


        public weather()
        {
            InitializeComponent();
        }

        private void Weather_Load(object sender, EventArgs e)
        {

        }
    }
}
