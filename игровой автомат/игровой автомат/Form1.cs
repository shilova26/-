﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игровой_автомат
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void start1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text;
            double money = Convert.ToDouble(textBox2.Text);
            Form form = new Form2(name, money);
            form.Show();
            this.Hide();
            

             



        }
    }
}
