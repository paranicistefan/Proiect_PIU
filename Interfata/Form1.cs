using System;
using Masini;
using Clienti;
using Tranzactii;
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
        int optiune=0;
        ListaMasini Masini;
        ListaClienti Clienti;
        ListaTranzactii Tranzactii;
        masina deVanzare;
        client Cumparator;
        client Vanzator;
        DateTime dataActualizare = new DateTime();
        public Form1(ListaMasini M,ListaClienti C,ListaTranzactii T)
        {
            Masini = M;
            Clienti = C;
            Tranzactii = T;
            InitializeComponent();
            dataActualizare = DateTime.Now;
            lblTime.Text = dataActualizare.ToString();

            car.Click += new EventHandler(car_Click);
            client.Click += new EventHandler(client_Click);
            clientE.Click += new EventHandler(clientE_Click);
            carE.Click += new EventHandler(carE_Click);
            grid.Click += new EventHandler(btnGrid_Click);
            offer.Click += new EventHandler(offer_Click);
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
            listBox.Items.Add("-----Selectati o masina pentru a vedea mai multe detalii-------");
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

            if(optiune==4)
            {
                deVanzare=Masini.find(listBox.SelectedIndex);
                btnClient_Click(sender, e);
                listBox.Items.Add("-----Selectati Clientul Masinii ce va fi vanduta -------");
                optiune = 5;
                return;
            }
            if(optiune == 5)
            {
                Cumparator = Clienti.find(listBox.SelectedIndex);
                btnClient_Click(sender, e);
                listBox.Items.Add("-----Selectati Vanzatorul Masinii ce va fi vanduta -------");
                optiune = 6;
                return;
            }
            if (optiune == 6)
            {
                Vanzator = Clienti.find(listBox.SelectedIndex);
                if(Vanzator==Cumparator)
                {
                    MessageBox.Show("Ai selectat Gresit ! Va trebui sa o iei de la capat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listBox.Items.Clear();
                    listBox.Visible = false;
                    optiune = 0;
                    return;
                }
                Masini.delete(deVanzare);
                optiune = 0;
                Data_Tranzactie x = new Data_Tranzactie(deVanzare,Cumparator,Vanzator,Tranzactii);
                x.ShowDialog();
                return;
            }
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            dataActualizare = DateTime.Now;
            lblTime.Text = dataActualizare.ToString();
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            DataGrid x = new DataGrid(Masini,Clienti,optiune);
            x.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            List<tranzactie> listaTranzactii = Tranzactii.show();
            listBox.Visible = true;
            if (listaTranzactii.Count == 0)
            {
                listBox.Items.Add("Nu a-ti efectuat nici-o tranzactie");
                return;
            }
            listBox.Items.Add($"ID   Nume Vanzator\tNume Client\tNume Masina\tData Tranzactiei\t\tpret");
            foreach (tranzactie curent in listaTranzactii)
            {
                listBox.Items.Add(curent.afisare());
            }
            listBox.Items.Add("-----Selectati o tranzactie pentru a vedea mai multe detalii-------");
            optiune = 0;
        }
        private void offer_Click(object sender, EventArgs e)
        {
            if (Clienti.show().Count==0 || Masini.show().Count < 1)
            {
                MessageBox.Show("Nu ai toate datele neceseare pentru efectuarea unei tranzactii","Eroare",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button1_Click(sender, e);
            listBox.Items.RemoveAt(listBox.Items.Count-1);
            listBox.Items.Add("-----Selectati masina ce va fi vanduta -------");

            optiune = 4;
        }
    }
}
