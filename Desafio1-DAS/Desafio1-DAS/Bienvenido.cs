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
    public partial class Bienvenido : Form
    {
        int indice = 0;
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            cmbTema.Items.Add("Programas de Entretenimiento");
            cmbTema.Items.Add("Libros");
            cmbTema.Items.Add("Lenguajes de Programación");
        }


        private void btnGO_Click(object sender, EventArgs e)
        {
            indice = cmbTema.SelectedIndex;
            switch (indice)
            {
                case 0:
                    ProgramasEntretenimiento program = new ProgramasEntretenimiento();
                    program.Show();
                    break;
                case 1:
                    Libros libros = new Libros();
                    libros.Show();
                    break;
                case 2:
                    LenguajesProgramacion lenguaje = new LenguajesProgramacion();
                    lenguaje.Show();
                    break;
            }
            this.Close();
        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
