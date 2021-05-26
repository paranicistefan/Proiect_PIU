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
    public partial class Adaugare_Clienti : Form
    {
        ListaClienti Clienti;
        public Adaugare_Clienti(ListaClienti C)
        {
            Clienti = C;
            InitializeComponent();
        }

        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            client nou = new client {Nume=txtNume.Text,
                                     Prenume=txtPrenume.Text,
                                     CNP=txtCNP.Text,
                                     Serie=txtSerie.Text,
                                     Adresa=txtAdresa.Text,
                                     Telefon=txtTelefon.Text
            };
            Clienti.add(nou);
            this.Close();
        }
    }
}
