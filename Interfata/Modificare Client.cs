using System;
using Clienti;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfata
{
    public partial class Modificare_Client : Form
    {
        ListaClienti Clienti;
        client modificat;
        public Modificare_Client(ListaClienti C, int id)
        {
            Clienti = C;
            modificat=Clienti.find(id);
            InitializeComponent();
            txtNume.Text = modificat.Nume;
            txtPrenume.Text = modificat.Prenume;
            txtCNP.Text = modificat.CNP;
            txtSerie.Text = modificat.Serie;
            txtAdresa.Text = modificat.Adresa;
            txtTelefon.Text = modificat.Telefon;
        }

        private void btnModificaClient_Click(object sender, EventArgs e)
        {
             modificat.Nume= txtNume.Text;
             modificat.Prenume= txtPrenume.Text;
             modificat.CNP= txtCNP.Text;
             modificat.Serie = txtSerie.Text;
            modificat.Adresa =txtAdresa.Text ;
             modificat.Telefon= txtTelefon.Text;
            Clienti.modify(modificat, modificat.id);
            this.Close();
        }
    }
}
