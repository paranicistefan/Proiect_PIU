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
            int c = 0;
            if (txtFabricant.Text == "Selectati un fabricant")
            {
                errLabel.Visible = true;
                lblFabricant.ForeColor = Color.DarkRed;
                c++;
            }
            if (txtModel.Text == "")
            {
                errLabel.Visible = true;
                lblModel.ForeColor = Color.DarkRed;
                c++;
            }
            if (txtAnFarbicatie.Text == "Selectati anul de fabricatie")
            {
                errLabel.Visible = true;
                lblAnFarbicatie.ForeColor = Color.DarkRed;
                c++;
            }
            if (txtKilometraj.Text == "")
            {
                errLabel.Visible = true;
                lblKilometraj.ForeColor = Color.DarkRed;
                c++;
            }
            if (txtEchipare.Text == "")
            {
                errLabel.Visible = true;
                lblEchpare.ForeColor = Color.DarkRed;
                c++;
            }
            if (txtPret.Text == "")
            {
                errLabel.Visible = true;
                lblPret.ForeColor = Color.DarkRed;
                c++;
            }
            if (c != 0)
            {
                return;
            }
            masina nou = new masina { Fabricant = txtFabricant.Text,
                                      Model = txtModel.Text, 
                                      anFabricatie =Convert.ToInt32(txtAnFarbicatie.Text), 
                                      Kilometraj = Convert.ToInt32(txtKilometraj.Text), 
                                      Echipare = txtEchipare.Text, 
                                      Pret = Convert.ToInt32(txtPret.Text) };
            Masini.add(nou);
            this.Close();
        }

        private void txtFabricant_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFabricant.ForeColor = Color.Black;
        }

        private void txtModel_TextChanged_1(object sender, EventArgs e)
        {
            lblModel.ForeColor = Color.Black;
        }

        private void txtAnFarbicatie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnFarbicatie.ForeColor = Color.Black;
        }

        private void txtKilometraj_TextChanged(object sender, EventArgs e)
        {
            lblKilometraj.ForeColor = Color.Black;
        }

        private void txtEchipare_TextChanged(object sender, EventArgs e)
        {
            lblEchpare.ForeColor = Color.Black;
        }

        private void txtPret_TextChanged(object sender, EventArgs e)
        {
            txtPret.ForeColor = Color.Black;
        }
    }
}
