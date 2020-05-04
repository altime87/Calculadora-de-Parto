using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime fecha = converttodateTime();
            DateTime Parto = dateTimePicker1.Value.AddMonths(9);
            //Parto.AddMonths(9);
            textBox1.Text = Parto.AddDays(7).Date.ToString("dd/MM/yyyy");
            //textBox1.Text = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            //textBox1.Text = dateTimePicker1.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime Parto = dateTimePicker2.Value.AddMonths(-9);
            textBox2.Text = Parto.AddDays(-7).Date.ToString("dd/MM/yyyy");
        }
    }
}
