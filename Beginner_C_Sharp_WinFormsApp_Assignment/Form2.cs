﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beginner_C_Sharp_WinFormsApp_Assignment
{

    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String when = textBox1.Text;
            String where = textBox2.Text;
            String who = textBox3.Text;
            String what = textBox4.Text;
            String why = textBox5.Text;
            String how = textBox6.Text;

            label7.Text = "「" + when + "、" + where + "、" + who + "、" + what + "、" + why + "、" + how + "。」";

        }

    }

}
