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
        int optiune;
        ListaMasini Masini;
        ListaClienti Clienti;
        DateTime dataActualizare = new DateTime();
        public Form1(ListaMasini M,ListaClienti C)
        {
            Masini = M;
            Clienti = C;
            InitializeComponent();
            dataActualizare = DateTime.Now;
            lblTime.Text = dataActualizare.ToString();
            car.Click += new EventHandler(car_Click);
            client.Click += new EventHandler(client_Click);
            clientE.Click += new EventHandler(clientE_Click);
            carE.Click += new EventHandler(carE_Click);
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
            optiune = 3;
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
        private void clientE_Click(object sender, EventArgs e)
        {
            btnClient_Click(0,e);
            listBox.Items.Add("-----Selectati Elementul ce dorit sa fie modificat-------");
            optiune = 1;
        }
        private void carE_Click(object sender, EventArgs e)
        {
            button1_Click(0, e);
            listBox.Items.Add("-----Selectati Elementul ce dorit sa fie modificat-------");
            optiune = 2;
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
            optiune = 0;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(optiune==1)
            {
                Modificare_Client x = new Modificare_Client(Clienti,listBox.SelectedIndex);
                x.ShowDialog();
            }
            if (optiune == 2)
            {
                Modificare_Masina x = new Modificare_Masina(Masini, listBox.SelectedIndex);
                x.ShowDialog();
            }
            if(optiune == 3)
            {
                DetaliiMasina x = new DetaliiMasina(Masini.find(listBox.SelectedIndex));
                x.ShowDialog();
            }
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            dataActualizare = DateTime.Now;
            lblTime.Text = dataActualizare.ToString();
        }
    }
}
