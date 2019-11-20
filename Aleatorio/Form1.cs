using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aleatorio
{
    public partial class Form1 : Form
    {
        int x_def;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            //escogeremos 4 numeros del centro
            DataTable dt = new DataTable();
            dt.Columns.Add("i", typeof(int));
            dt.Columns.Add("xi", typeof(int));
            dt.Columns.Add("xi2", typeof(int));
            dt.Columns.Add("ri", typeof(int));
            int tam1,tam2,primerc,numero1,numero2;
            string semilla, snumero2,snumero3;
            semilla = txt_numero.Text;
            tam1 = semilla.Length;
            numero1 = Int32.Parse(semilla);
            for (int i=0;i<20;i++)
            {
                numero2 = numero1 * numero1;
                snumero2 = numero2.ToString();
                tam2 = snumero2.Length;
                primerc = (tam2 - tam1) / 2;
                snumero3 = snumero2.Substring(primerc, primerc + tam1);
                dt.Rows.Add(i++,numero1,numero2,Int32.Parse(snumero3));
                dataGridView1.DataSource = dt;
                numero1 = Int32.Parse(snumero3);
                

            }


        }
    }
}
