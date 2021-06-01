using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Masini;
using Clienti;
using Tranzactii;
using System.Windows.Forms;

namespace Interfata
{
    public partial class Data_Tranzactie : Form
    {
        tranzactie x = new tranzactie();
        ListaTranzactii list;
        public Data_Tranzactie(masina M,client Cumparator,client Vanzator,ListaTranzactii lista)
        {
            InitializeComponent();
            x.Masina = M;
            x.Vanzator = Vanzator;
            x.Clientul = Cumparator;
            list = lista;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            x.dataTranzactiei = dtTranzactie.Value;
            list.add(x);
            this.Close();
        }
    }
}
