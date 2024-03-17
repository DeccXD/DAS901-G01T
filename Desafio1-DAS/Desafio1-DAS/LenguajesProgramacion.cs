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
    public partial class LenguajesProgramacion : Form
    {
        Dictionary<string, string> pyt = new Dictionary<string, string>();
        Dictionary<string, string> java = new Dictionary<string, string>();
        Dictionary<string, string> javascri = new Dictionary<string, string>();



        public LenguajesProgramacion()
        {
            InitializeComponent();
        }

        private void LenguajesProgramacion_Load(object sender, EventArgs e)
        {
            //Datos de Python
            pyt.Add("Desarrollador(es):", "Python Software Foundation");
            pyt.Add("Extensiones:", ".py,\r\n .pyc,\r\n .pyd,\r\n .pyo,\r\n .pyw\r\n, .pyz");
            pyt.Add("Apareció en:", "1991");
            pyt.Add("Sistema Operativo:", "Multiplataforma");
            pyt.Add("Paradigma:", "Multiparadigma: orientado a objetos, imperativo, funcional, \r\nreflexivo");
            pyt.Add("Ultima Versión:", "3.8.3");
            pyt.Add("Licencia:", "Python Software Foundation License");
            foreach (var item in pyt.Keys)
            {
                lstPython.Items.Add(item);

            }

            //Datos de JAVA
            java.Add("Desarrollador(es):", "James Gosling y Sun Microsystem");
            java.Add("Extensiones:", "java,\r\n class,\r\n jar,\r\n jad,\r\n jmod ");
            java.Add("Apareció en:", "1996");
            java.Add("Sistema Operativo:", "Multiplataforma");
            java.Add("Paradigma:", "Orientado a objetos,\r\n imperativo");
            java.Add("Ultima Versión:", "14.01");
            java.Add("Licencia:", "GNU GPL,\r\n Java Community Process");
            foreach (var item in java.Keys)
            {
                lstJava.Items.Add(item);

            }

            //Datos de JavaScript
            javascri.Add("Desarrollador(es):", "xx ");
            javascri.Add("Extensiones:", "js ");
            javascri.Add("Apareció en:", "1995");
            javascri.Add("Sistema Operativo:", "xx");
            javascri.Add("Paradigma:", "Multiparadigma, programación \r\nfuncional,1 programación basada \r\nen \r\nprototipos, imperativo, interpreta\r\n do (scripting) ");
            javascri.Add("Ultima Versión Estable:", "ECMAScript2016 ");
            javascri.Add("Licencia:", "xx");
            foreach (var item in javascri.Keys)
            {
                lstJavascript.Items.Add(item);

            }


        }


        private void lstPython_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstPython.Text;
            for (int i = 0; i < pyt.Count; i++)
            {
                var item = pyt.ElementAt(i);
                if (buscar == item.Key)
                {
                    txtPython.Text = item.Value;
                    //pctBox.Show();
                    break;
                }
            }
        }

        private void lstJava_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstJava.Text;
            for (int i = 0; i < java.Count; i++)
            {
                var item = java.ElementAt(i);
                if (buscar == item.Key)
                {
                    txtJava.Text = item.Value;
                    //pctBox.Show();
                    break;
                }
            }
        }

        private void lstJavascript_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstJavascript.Text;
            for (int i = 0; i < javascri.Count; i++)
            {
                var item = javascri.ElementAt(i);
                if (buscar == item.Key)
                {
                   txtJavascript.Text = item.Value;
                    //pctBox.Show();
                    break;
                }
            }
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
