using BeeHotel2.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHotel2
{
    public partial class Form1 : Form
    {
        ConexionBD con = new ConexionBD();
        public string user;
        public string pass;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = "admin";
            pass = "1234";
            if (txtUser.Text == user && txtPass.Text==pass)
            {
                panelLateral dash=new panelLateral();
                dash.Show();
                this.Hide();
            }
            else
            {
                
                if (txtUser.Text != user)
                {
                    MessageBox.Show("Usuario incorrecto");
                    txtUser.Text = "";
                    txtUser.Focus();
                }
                 if (txtPass.Text != pass)
                {
                    MessageBox.Show("Contraseña incorrecta");
                    txtPass.Text = "";
                    txtPass.Focus();
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
