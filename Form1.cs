﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                const double π = 3.1415;
                double R, S;

                // Parse - метод

                // Для перетворення з текстового типу string в тип double використовується
                // метод Parse. Таким чином заповнюється значення змінної R.

                R = Double.Parse(textBox1.Text);

                S = 4 * π * R * R;


                // Перетворення у
                // тип string виконується з допомогою методу ToString().
                label2.Text = "Площа поверхні кулі = " + S.ToString();
            }
            catch (FormatException ex)
            {
                label2.Text = "Помилка - " + ex.Message;
            }
        }
    }
}