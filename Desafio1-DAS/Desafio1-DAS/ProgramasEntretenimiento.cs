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
    public partial class ProgramasEntretenimiento : Form
    {
        Dictionary<string,string> GOT= new Dictionary<string,string>();
        Dictionary<string,string> Cher = new Dictionary<string,string>();
        Dictionary<string,string> Marv = new Dictionary<string,string>();
 

        public ProgramasEntretenimiento()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
         
        }

        private void ProgramasEntretenimiento_Load(object sender, EventArgs e)
        {
            //Datos de Game Of Thrones
            GOT.Add("Título en Español", "Juego de Tronos ");
            GOT.Add("Creado por", "David Benioff D.B. Weiss");
            GOT.Add("Protagonistas", "Sean Bean,\r\n Nicolaj Coster-Waldau,\r\n Peter Dinklage,\r\n Emilia Clark,\r\n Lena Headey,\r\n Ian Glen,\r\n Kit Harintong,\r\n Sophie Turner,\r\n Maisie Williams,\r\n Isaac Hemstead-Wright,\r\n Natalie Dormer");
            GOT.Add("País de Origen", "Estados Unidos");
            GOT.Add("Temporadas", "8");
            GOT.Add("Episodios", "73");
            GOT.Add("Sinopsis", "La trama de Game of \r\nThrones está basada en la serie \r\nde novelas Canción de hielo y \r\nfuego, y relata las vivencias de \r\nun grupo de personajes de \r\ndistintas casas nobiliarias en el \r\ncontinente ficticio Poniente para \r\ntener el control del Trono de \r\nHierro y gobernar los siete \r\nreinos que conforman el \r\nterritorio");
            foreach (var item in GOT.Keys)
            {
                lstDatos.Items.Add(item);

            }

            //Datos de Chernobyl
            Cher.Add("Título en Español", "Chernóbyl");
            Cher.Add("Creado por", "Craig Mazin");
            Cher.Add("Protagonistas", "Jared Harris\r\n, Stellan Skarsgard\r\n Emily Watson");
            Cher.Add("País de Origen", "Estados Unidos\r, Reino Unido");
            Cher.Add("Temporadas", "1");
            Cher.Add("Episodios", "5");
            Cher.Add("Sinopsis", "La serie gira en torno al desastre nuclear de Chernóbil de abril de \r\n1986 y los esfuerzos de limpieza \r\nsin precedentes que siguieron. \r\nCuenta con un reparto \r\nencabezado por Jared Harris, \r\nStellan Skarsgård y Emily \r\nWatson.");
            foreach (var item in Cher.Keys)
            {
                lstChernobyl.Items.Add(item);

            }

            //Datos de THE MARVELOUS MRS.MAISEL
            Marv.Add("Titulo", "La maravillosa Señora Maisel");
            Marv.Add("Creado por", "Amy Sherman-Paladino");
            Marv.Add("Protagonistas", "Rachel Brosnaham,\r\n Micheal Zegen,\r\n Alex Borstein,\r\n Tony Shalhoub, Marin Hinkle");
            Marv.Add("País de Origen", "Estados Unidos");
            Marv.Add("Temporadas", "3");
            Marv.Add("Episodios", "26");
            Marv.Add("Sinopsis", "La serie cuenta la historia de un \r\nama de casa en Nueva York que \r\ndescubre que tiene una habilidad \r\nespecial para la comedia en vivo. \r\nEl primer episodio se estrenó \r\ncomo parte de la temporada de \r\npilotos de primavera de Amazon \r\nStudios el 17 de marzo de 2017, \r\nrecibiendo la aclamación de la \r\ncrítica.");
            foreach (var item in Marv.Keys)
            {
                lstMarv.Items.Add(item);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {


            string buscar;
            buscar = lstDatos.Text;
            for (int i = 0; i < GOT.Count; i++)
            {
                var item = GOT.ElementAt(i);
                if (buscar == item.Key)
                {
                    textBox1.Text = item.Value;
                    //pctBox.Show();
                    break;
                }
            }
        }


        private void lstChernobyl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstChernobyl.Text;
            for (int i = 0; i < Cher.Count; i++)
            {
                var item = Cher.ElementAt(i);
                if (buscar == item.Key)
                {
                    txtCherno.Text = item.Value;
                    //pctBox.Show();
                    break;
                }
            }
        }

        private void lstMarv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstMarv.Text;
            for (int i = 0; i < Marv.Count;i++)
            {
                var item = Marv.ElementAt(i);
                if (buscar == item.Key)
                {
                    txtMarv.Text = item.Value;
                    break;
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Close();
        }
    }
}
