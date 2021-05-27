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
            if (chOglinzi.Checked)
                nou.OglinziElectrice = true;
            if (chScaune.Checked)
                nou.ScauneElectrice = true;
            if (chPachet.Checked)
                nou.PachetSport = true;
            if (chSenzori.Checked)
                nou.SenzoriParcare = true;
            if (chFaruri.Checked)
                nou.FariuriAutomate = true;
            if (chCruise.Checked)
                nou.CriuseControl = true;

            if (rdbAlb.Checked)
                nou.culoare = Culoare.Alb;
            if (rdbAlbastru.Checked)
                nou.culoare = Culoare.Albastru;
            if (rdbGalben.Checked)
                nou.culoare = Culoare.galben;
            if (rdbGri.Checked)
                nou.culoare = Culoare.Gri;
            if (rdbRosu.Checked)
                nou.culoare = Culoare.Rosu;
            if (rdbVerde.Checked)
                nou.culoare = Culoare.Verde;
            if (rdbNegru.Checked)
                nou.culoare = Culoare.Negru;
            if (rdbMaro.Checked)
                nou.culoare = Culoare.maro;

            if (rdbManual.Checked)
                nou.cv = CutiiViteze.Manuala;
            if (rdbAuto.Checked)
                nou.cv = CutiiViteze.Automata;

            if (rdbHatch.Checked)
                nou.caroserie = Caroserii.Hatchback;
            if (rdbSedan.Checked)
                nou.caroserie = Caroserii.Sedan;
            if (rdbSUV.Checked)
                nou.caroserie = Caroserii.SUV;
            if (rdbMPV.Checked)
                nou.caroserie = Caroserii.Monovolum;
            if (rdbCoupe.Checked)
                nou.caroserie = Caroserii.Coupe;
            if (rdbCabrio.Checked)
                nou.caroserie = Caroserii.Cabrio;
            if (rdbBreak.Checked)
                nou.caroserie = Caroserii.Break;

            if (rdbRob.Checked)
                nou.aer = AerConditionat.Manual;
            if (rdbClima.Checked)
                nou.aer = AerConditionat.Climiatronic;
            if (rdbClima2.Checked)
                nou.aer = AerConditionat.Climatronic_2_Zone;
            if (rdbClima3.Checked)
                nou.aer = AerConditionat.Climatronic_3_Zone;
            if (rdbClima4.Checked)
                nou.aer = AerConditionat.Climatronic_4_Zone;

            if (rdbBenzina.Checked)
                nou.fuel = Combustibili.Benzina;
            if (rdbDiesel.Checked)
                nou.fuel = Combustibili.Diesel;
            if (rdbHybrid.Checked)
                nou.fuel = Combustibili.Hybrid;
            if (rdbElectric.Checked)
                nou.fuel = Combustibili.Electric;

            if (rdbManivela.Checked)
                nou.geamuri = GeamuriElectrice.Nope;
            if (rdbCheala.Checked)
                nou.geamuri = GeamuriElectrice.Fata;
            if (rdbFS.Checked)
                nou.geamuri = GeamuriElectrice.Fata_Spate;
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

        private void rdbNegru_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
