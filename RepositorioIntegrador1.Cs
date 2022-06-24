using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaAppLoginIniciodesesión_Rutas_Nicas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnIniciarsesión_Click(object sender, EventArgs e)
        {
             if (txtEmail.Text == "ggabriel22@gmail.com" && txtContraseña.Text == "1234")
             {
                new Form2().Show();
                this.Hide();

             }
             else

             {
                MessageBox.Show("El nombre de usuario o contraseña que ingresaste es incorrecto,intenta otravez");
                txtEmail.Clear();
                txtContraseña.Clear();
                txtEmail.Focus();
             }

        }

        private void lblCreaunaahora_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

    }

}