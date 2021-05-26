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
            int c = 0;
            if(txtNume.Text=="")
            {
                errLabel.Visible = true;
                lblNume.ForeColor=Color.DarkRed;
                c++;
            }
            if (txtPrenume.Text == "")
            {
                errLabel.Visible = true;
                lblPrenume.ForeColor = Color.DarkRed;
                c++;
            }
            if (txtCNP.Text == "")
            {
                errLabel.Visible = true;
                lblCNP.ForeColor = Color.DarkRed;
                c++;
            }
            if (txtSerie.Text == "")
            {
                errLabel.Visible = true;
                lblSerie.ForeColor = Color.DarkRed;
                c++;
            }
            if (txtAdresa.Text == "")
            {
                errLabel.Visible = true;
                lblAdresa.ForeColor = Color.DarkRed;
                c++;
            }
            if (txtTelefon.Text == "")
            {
                errLabel.Visible = true;
                lblTelefon.ForeColor = Color.DarkRed;
                c++;
            }
            if (c!=0)
            {
                return;
            }
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

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            lblNume.ForeColor = Color.Black;
        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {
            lblPrenume.ForeColor = Color.Black;
        }

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {
            lblCNP.ForeColor = Color.Black;
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
            lblAdresa.ForeColor = Color.Black;
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {
            lblSerie.ForeColor = Color.Black;
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            lblTelefon.ForeColor = Color.Black;
        }
    }
}
