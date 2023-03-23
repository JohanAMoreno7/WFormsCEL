using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoF
{
    public partial class Form2 : Form
    {
        Formulario formu;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                if ((textBox1.Text == "admin") && (textBox2.Text == "1234"))
                {
                    formu = new Formulario();
                    formu.Show();
                    this.Hide();
                }
            }

        }
    }
}
