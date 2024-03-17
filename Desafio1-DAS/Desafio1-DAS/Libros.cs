using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desafio1_DAS
{
    public partial class Libros : Form
    {
        Dictionary<string, string> Harry = new Dictionary<string, string>();
        Dictionary<string, string> Goos = new Dictionary<string, string>();
        Dictionary<string, string> Perry = new Dictionary<string, string>();



        public Libros()
        {
            InitializeComponent();
        }

        private void Libros_Load(object sender, EventArgs e)
        {

            //Datos de Harry Potter
            Harry.Add("Autor","J. K. Rowling");
            Harry.Add("Genero", "Novela");
            Harry.Add("# de paginas", "3407 (ENG),\r\n 3665(ESP)");
            Harry.Add("Protagonistas", "Harry Potter,\r\n Ron Weasley,\r\n Hermione Granger,\r\n Ginny Weasley,\r\n Neville Longbottom,\r\n Albus Dumbledore ");
            Harry.Add("Antagonistas", "Lord Voldemort,\r\n Mortífagos");
            Harry.Add("Argumento", "La historia comienza con la celebración del mundo mágico. \r\nDurante muchos años, había sido aterrorizado por el malvado mago Lord Voldemort. \r\nLa noche del 31 de octubre, mató a Lily y James Potter. Sin embargo, cuando intenta matar a \r\nsu hijo de 1 año, Harry, la \r\nmaldición asesina Avada \r\nKedavra se vuelve sobre sí mismo. El cuerpo de Voldemort resulta destruido, pero él \r\nsobrevive: no está muerto ni \r\nvivo. Por su parte, a Harry solo \r\nle queda una cicatriz con forma de rayo en la frente que es el \r\núnico remanente físico de la \r\nmaldición de Voldemort. Harry \r\nes el único sobreviviente de la maldición asesina, y a raíz de la \r\nmisteriosa derrota de Voldemort, \r\nel mundo mágico empieza a llamarlo como «el niño que sobrevivió».");
            foreach (var item in Harry.Keys)
            {
                lstHarry.Items.Add(item);

            }

            //Datos de Goosebumps
            Goos.Add("Autor", "Robert Lawrence Stine");
            Goos.Add("Genero", "Ciencia Ficción,\r\n Literatura,\r\n Infantil,\r\n Suspenso");
            Goos.Add("Subgenero", "Suspenso,\r\n Terror,\r\n Juvenil");
            Goos.Add("# de paginas", "---");
            Goos.Add("Protagonistas", "El protagonista principal de una \r\nhistoria de Pesadillas / \r\nEscalofríos, es a menudo situado \r\nen una ubicación remota o de \r\nalguna manera aislada en \r\nalgunas situaciones. ");
            Goos.Add("Antagonistas", "---");
            Goos.Add("Argumento", "La serie consta de un total de 60 \r\nlibros para España, el último de \r\nlos cuales (Sangre de monstruo \r\nIV) se publicó en 1999, mientras \r\nque en Hispanoamérica consta \r\nde 45 historias. \r\nEl nombre se tradujo en España \r\ncomo Pesadillas y en \r\nHispanoamérica \r\ncomo Escalofríos.  ");
            foreach (var item in Goos.Keys)
            {
                lstGoos.Items.Add(item);

            }

            //Datos de Perry Mason

            Perry.Add("Autor", "Erle Stanley Gardner");
            Perry.Add("Genero", "Novela Policiaca");
            Perry.Add("Subgenero", "xx");
            Perry.Add("# de Paginas", "xx");
            Perry.Add("Protagonistas", "Perry Jackson");
            Perry.Add("Antagonistas", "xx");
            Perry.Add("Argumento", "El personaje era un abogado que \r\nllegó a aparecer en 80 novelas e \r\nhistorias cortas, la mayoría de \r\nlas cuales versaban sobre la \r\ndefensa de un cliente que había \r\nsido acusado de asesinato. En \r\ngeneral, Perry Mason era capaz \r\nde demostrar la inocencia de su \r\ncliente mediante la averiguación \r\nde la culpabilidad del verdadero \r\nasesino, otro personaje de la \r\nhistoria. ");
            foreach (var item in Perry.Keys)
            {
                lstPerry.Items.Add(item);

            }


        }


        private void lstHarry_SelectedIndexChanged(object sender, EventArgs e)
        {

            string buscar;
            buscar = lstHarry.Text;
            for (int i = 0; i < Harry.Count; i++)
            {
                var item = Harry.ElementAt(i);
                if (buscar == item.Key)
                {
                    txtHarry.Text = item.Value;
                    //pctBox.Show();
                    break;
                }
            }
        }

        private void lstGoos_SelectedIndexChanged(object sender, EventArgs e)
        {
             string buscar;
            buscar = lstGoos.Text;
            for (int i = 0; i < Goos.Count; i++)
            {
                var item = Goos.ElementAt(i);
                if (buscar == item.Key)
                {
                    txtGoos.Text = item.Value;
                    //pctBox.Show();
                    break;
                }
            }
        }

        private void lstPerry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstPerry.Text;
            for (int i = 0; i < Perry.Count; i++)
            {
                var item = Perry.ElementAt(i);
                if (buscar == item.Key)
                {
                    txtPerry.Text = item.Value;
                    //pctBox.Show();
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
