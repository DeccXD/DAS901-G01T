using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_DAS
{


    public partial class Registro : Form

    {
        Form1 formulario = new Form1();



        Sesiones NuevaSesion = new Sesiones();
        public Registro()
        {

            InitializeComponent();

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarR_Click(object sender, EventArgs e)
        {
            NuevaSesion.Nombre = txtNombreU.Text;
            NuevaSesion.Password = txtContraU.Text;

            
            if (txtContraU.Text==txtContraConfirm.Text)
            {
                Agregarusuario(NuevaSesion.Nombre, NuevaSesion.Password);


                MessageBox.Show("Se guardo nueva sesion");
                formulario.Show();
                this.Close();




            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                txtContraConfirm.Clear();
            }
            
           
            

        }

        public void Agregarusuario(string usuario,string password)
        {

            // Agrega un nuevo usuario
            if (formulario.usuarios.Length == 5)
            {
                // Redimensionar el array para insertar el usuario
                Array.Resize(ref formulario.usuarios, formulario.usuarios.Length * 2);
            }

            // Agrega el usuario al final del array
            Array.Resize(ref formulario.usuarios, formulario.usuarios.Length + 1);
            formulario.usuarios[formulario.usuarios.Length - 1] = usuario;


            formulario.password.Add(usuario, password);




        }

        private void btnCancelarR_Click(object sender, EventArgs e)
        {

            string message = "Usuarios:\n";
            foreach (string usuario in formulario.usuarios)
            {
                message += usuario + Environment.NewLine;
            }
            MessageBox.Show(message);


            string displayText = "";
            foreach (KeyValuePair<string, string> entry in formulario.password)
            {
                displayText += $"Key: {entry.Key}, Value: {entry.Value}\n";
            }
            MessageBox.Show(displayText);

           

        }
    }
}
