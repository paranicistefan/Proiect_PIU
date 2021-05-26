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
    public partial class Modificare_Masina : Form
    {
        ListaMasini Masini;
        masina modificat;
        public Modificare_Masina(ListaMasini M, int id)
        {
            Masini = M;
            modificat = Masini.find(id);
            InitializeComponent();
            txtFabricant.Text = modificat.Fabricant;
            txtModel.Text = modificat.Model;
            txtAnFarbicatie.Text = modificat.anFabricatie.ToString();
            txtEchipare.Text = modificat.Echipare;
            txtKilometraj.Text = modificat.Kilometraj.ToString();
            txtPret.Text = modificat.Pret.ToString();

        }

        private void btnModificaMasina_Click(object sender, EventArgs e)
        {
             modificat.Fabricant= txtFabricant.Text;
             modificat.Model= txtModel.Text;
             modificat.anFabricatie=Convert.ToInt32(txtAnFarbicatie.Text);
             modificat.Echipare= txtEchipare.Text;
             modificat.Kilometraj= Convert.ToInt32(txtKilometraj.Text);
             modificat.Pret= Convert.ToInt32(txtPret.Text);
            Masini.modify(modificat, modificat.id);
            this.Close();

        }
    }
}
