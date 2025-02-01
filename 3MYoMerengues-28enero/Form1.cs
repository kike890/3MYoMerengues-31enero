using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MYoMerengues_28enero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle X = this.ClientRectangle;

            Color color1 = Color.DarkViolet;
            Color color2 = Color.BlueViolet;

            using (LinearGradientBrush brush = new LinearGradientBrush(X, color1, color2, 260))
            {
                g.FillRectangle(brush, X);
            }
        }

            private void but_celcius_Click(object sender, EventArgs e)
        {
            float celcius = float.Parse(LB_celcius.Text);
            float farenheit = (celcius * 9f / 5f) + 32;
            Lb_resul.Text = farenheit.ToString();
        }

        private void but_faren_Click(object sender, EventArgs e)
        {
            float farenheit = float.Parse(Lb_fare.Text);
            float celcius = (farenheit - 32) * 5.0f / 9.0f;
            Lb_resul.Text = celcius.ToString();
        }

        private void but_limpiar_Click(object sender, EventArgs e)
        {
            LB_celcius.Text = ("0.0"); 
            Lb_fare.Text = ("0.0");
            MessageBox.Show("Ya no hay nada");

        }
    }
}
