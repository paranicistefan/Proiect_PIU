using System;
using Masini;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfata
{
    public partial class Adaugare_Masina : Form
    {
        ListaMasini Masini;
        public Adaugare_Masina(ListaMasini M)
        {
            Masini = M;
            InitializeComponent();
        }

        private void lblFabricant_Click(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugaMasina_Click(object sender, EventArgs e)
        {
            masina nou = new masina { Fabricant = txtFabricant.Text,
                                      Model = txtModel.Text, 
                                      anFabricatie =Convert.ToInt32(txtAnFarbicatie.Text), 
                                      Kilometraj = Convert.ToInt32(txtKilometraj.Text), 
                                      Echipare = txtEchipare.Text, 
                                      Pret = Convert.ToInt32(txtPret.Text) };
            Masini.add(nou);
            this.Close();
        }
    }
}
