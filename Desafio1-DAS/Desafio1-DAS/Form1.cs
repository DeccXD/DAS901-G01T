using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_DAS
{
    public partial class Form1 : Form
    {
        // Este es el arreglo con nombres de usuario
       public string[] usuarios =
        {
                "Denis", "Wins", "Deyna", "Marco", "Emma"
            };

        //Esta es la colección con Contraseñas
        public Dictionary<string, string>
         password = new Dictionary<string, string>
        
         {
                {"Denis", "Denis123" },
                {"Wins", "Wins123" },
                {"Deyna", "Deyna123" },
                {"Marco", "Marco123" },
                {"Emma", "Emma123" },
             

        };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string usuariolog = txtUser.Text;
                string passwordlog = txtContra.Text;

                if (Array.IndexOf(usuarios, usuariolog) > -1 &&
                    password.ContainsKey(usuariolog) &&
                    password[usuariolog] == passwordlog)
                {
                    //MessageBox.Show("Bienvenido");
                    Bienvenido bienvenido = new Bienvenido();
                    bienvenido.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña es incorrecto");
                    txtUser.Clear();
                    txtContra.Clear();
                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
           


        }
    }
}
