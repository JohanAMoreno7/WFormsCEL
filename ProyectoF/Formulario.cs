using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoF
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            StreamWriter celular = new StreamWriter(@"C:\Users\User\Desktop", true);
            try
            {

                celular.WriteLine("Referencia: "+ textBox1.Text);
                celular.WriteLine("Modelo: " + textBox2.Text);
                celular.WriteLine("IMEI: " + textBox3.Text);
                celular.WriteLine("Precio: " + textBox4.Text);
                if (checkBox1.Checked == true)
                {
                    celular.WriteLine("Estado: Nuevo");
                }
                if (checkBox2.Checked == true)
                {
                    celular.WriteLine("Estado: Usado");
                }
                celular.WriteLine("\n");
               
                
                MessageBox.Show("Información guardada");
                

            }
            catch (Exception)
            {
                MessageBox.Show("Error");

                throw;
            }
            
            celular.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader ver = new StreamReader(@"d:\Desktop\Archivo.txt");
            string mostrar;
            try
            {
                mostrar = ver.ReadLine();
                while(mostrar != null)
                {
                    richTextBox1.AppendText(mostrar+ "\n");
                    mostrar = ver.ReadLine();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToShortTimeString();
            label6.Text = DateTime.Now.ToShortDateString();
        }

      
    }
}
