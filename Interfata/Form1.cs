using System;
using Masini;
using Clienti;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata
{
    public partial class Form1 : Form
    {
        ListaMasini Masini;
        ListaClienti Clienti;
        public Form1(ListaMasini M,ListaClienti C)
        {
            Masini = M;
            Clienti = C;
            InitializeComponent();
            car.Click += new EventHandler(car_Click);
            client.Click += new EventHandler(client_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            List < masina > listaMasini = Masini.show();
            listBox.Visible = true;
            if (listaMasini.Count == 0)
            {
                listBox.Items.Add("Nu ai nici-o masina introdusa");
                return;
            }
            listBox.Items.Add($"ID   Fabricant\tModel\tanFabricatie\tEchipare\t\tkilometri   \tpret");
            foreach (masina curent in listaMasini)
            {
                listBox.Items.Add(curent.afisare());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, EventArgs e)
        {
            
        }
        private void car_Click(object sender, EventArgs e)
        {
            Adaugare_Masina x = new Adaugare_Masina(Masini);
            x.ShowDialog();
        }
        private void client_Click(object sender, EventArgs e)
        {
            Adaugare_Clienti x = new Adaugare_Clienti(Clienti);
            x.ShowDialog();
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            List<client> listaClienti = Clienti.show();
            listBox.Visible = true;
            if (listaClienti.Count == 0)
            {
                listBox.Items.Add("Nu ai nici-un client introdus");
                return;
            }
            listBox.Items.Add($"ID   Nume\tPrenume\tCNP\t\tSerie\t\tAdresa\tTelefon");
            foreach (client curent in listaClienti)
            {
                listBox.Items.Add(curent.afisare());
            }
        }
    }
}
