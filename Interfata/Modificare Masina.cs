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

            if (modificat.OglinziElectrice == true)
                chOglinzi.Checked=true;
            if (modificat.ScauneElectrice == true)
                chScaune.Checked=true;
            if (modificat.PachetSport == true)
                chPachet.Checked = true;
            if (modificat.SenzoriParcare == true)
                chSenzori.Checked = true;
            if (modificat.FariuriAutomate == true)
                chFaruri.Checked = true;
            if (modificat.CriuseControl == true)
                chCruise.Checked = true;

            if (modificat.culoare == Culoare.Alb)
                rdbAlb.Checked = true;
            if (modificat.culoare == Culoare.Albastru)
                rdbAlbastru.Checked = true;
            if (modificat.culoare == Culoare.galben)
                rdbGalben.Checked = true;
            if (modificat.culoare == Culoare.Gri)
                rdbGri.Checked = true;
            if (modificat.culoare == Culoare.Rosu)
                rdbRosu.Checked = true;
            if (modificat.culoare == Culoare.Verde)
                rdbVerde.Checked = true;
            if (modificat.culoare == Culoare.Negru)
                rdbNegru.Checked = true;
            if (modificat.culoare == Culoare.maro)
                rdbMaro.Checked = true;

            if (modificat.cv == CutiiViteze.Manuala)
                rdbManual.Checked = true;
            if (modificat.cv == CutiiViteze.Automata)
                rdbAuto.Checked = true;

            if (modificat.caroserie == Caroserii.Hatchback)
                rdbHatch.Checked = true;
            if (modificat.caroserie == Caroserii.Sedan)
                rdbSedan.Checked = true;
            if (modificat.caroserie == Caroserii.SUV)
                rdbSUV.Checked = true;
            if (modificat.caroserie == Caroserii.Monovolum)
                rdbMPV.Checked = true;
            if (modificat.caroserie == Caroserii.Coupe)
                rdbCoupe.Checked = true;
            if (modificat.caroserie == Caroserii.Cabrio)
                rdbCabrio.Checked = true;
            if (modificat.caroserie == Caroserii.Break)
                rdbBreak.Checked = true;

            if (modificat.aer == AerConditionat.Manual)
                rdbRob.Checked = true;
            if (modificat.aer == AerConditionat.Climiatronic)
                rdbClima.Checked = true;
            if (modificat.aer == AerConditionat.Climatronic_2_Zone)
                rdbClima2.Checked = true;
            if (modificat.aer == AerConditionat.Climatronic_3_Zone)
                rdbClima3.Checked = true;
            if (modificat.aer == AerConditionat.Climatronic_4_Zone)
                rdbClima4.Checked = true;

            if (modificat.fuel == Combustibili.Benzina)
                rdbBenzina.Checked = true;
            if (modificat.fuel == Combustibili.Diesel)
                rdbDiesel.Checked = true;
            if (modificat.fuel == Combustibili.Hybrid)
                rdbHybrid.Checked = true;
            if (modificat.fuel == Combustibili.Electric)
                rdbElectric.Checked = true;

            if (modificat.geamuri == GeamuriElectrice.Nope)
                rdbManivela.Checked = true;
            if (modificat.geamuri == GeamuriElectrice.Fata)
                rdbCheala.Checked = true;
            if (modificat.geamuri == GeamuriElectrice.Fata_Spate)
                rdbFS.Checked = true;

        }

        private void btnModificaMasina_Click(object sender, EventArgs e)
        {
             modificat.Fabricant= txtFabricant.Text;
             modificat.Model= txtModel.Text;
             modificat.anFabricatie=Convert.ToInt32(txtAnFarbicatie.Text);
             modificat.Echipare= txtEchipare.Text;
             modificat.Kilometraj= Convert.ToInt32(txtKilometraj.Text);
             modificat.Pret= Convert.ToInt32(txtPret.Text);

            if (chOglinzi.Checked)
                modificat.OglinziElectrice = true;
            if (chScaune.Checked)
                modificat.ScauneElectrice = true;
            if (chPachet.Checked)
                modificat.PachetSport = true;
            if (chSenzori.Checked)
                modificat.SenzoriParcare = true;
            if (chFaruri.Checked)
                modificat.FariuriAutomate = true;
            if (chCruise.Checked)
                modificat.CriuseControl = true;

            if (rdbAlb.Checked)
                modificat.culoare = Culoare.Alb;
            if (rdbAlbastru.Checked)
                modificat.culoare = Culoare.Albastru;
            if (rdbGalben.Checked)
                modificat.culoare = Culoare.galben;
            if (rdbGri.Checked)
                modificat.culoare = Culoare.Gri;
            if (rdbRosu.Checked)
                modificat.culoare = Culoare.Rosu;
            if (rdbVerde.Checked)
                modificat.culoare = Culoare.Verde;
            if (rdbNegru.Checked)
                modificat.culoare = Culoare.Negru;
            if (rdbMaro.Checked)
                modificat.culoare = Culoare.maro;

            if (rdbManual.Checked)
                modificat.cv = CutiiViteze.Manuala;
            if (rdbAuto.Checked)
                modificat.cv = CutiiViteze.Automata;

            if (rdbHatch.Checked)
                modificat.caroserie = Caroserii.Hatchback;
            if (rdbSedan.Checked)
                modificat.caroserie = Caroserii.Sedan;
            if (rdbSUV.Checked)
                modificat.caroserie = Caroserii.SUV;
            if (rdbMPV.Checked)
                modificat.caroserie = Caroserii.Monovolum;
            if (rdbCoupe.Checked)
                modificat.caroserie = Caroserii.Coupe;
            if (rdbCabrio.Checked)
                modificat.caroserie = Caroserii.Cabrio;
            if (rdbBreak.Checked)
                modificat.caroserie = Caroserii.Break;

            if (rdbRob.Checked)
                modificat.aer = AerConditionat.Manual;
            if (rdbClima.Checked)
                modificat.aer = AerConditionat.Climiatronic;
            if (rdbClima2.Checked)
                modificat.aer = AerConditionat.Climatronic_2_Zone;
            if (rdbClima3.Checked)
                modificat.aer = AerConditionat.Climatronic_3_Zone;
            if (rdbClima4.Checked)
                modificat.aer = AerConditionat.Climatronic_4_Zone;

            if (rdbBenzina.Checked)
                modificat.fuel = Combustibili.Benzina;
            if (rdbDiesel.Checked)
                modificat.fuel = Combustibili.Diesel;
            if (rdbHybrid.Checked)
                modificat.fuel = Combustibili.Hybrid;
            if (rdbElectric.Checked)
                modificat.fuel = Combustibili.Electric;

            if (rdbManivela.Checked)
                modificat.geamuri = GeamuriElectrice.Nope;
            if (rdbCheala.Checked)
                modificat.geamuri = GeamuriElectrice.Fata;
            if (rdbFS.Checked)
                modificat.geamuri = GeamuriElectrice.Fata_Spate;
            Masini.modify(modificat, modificat.id);
            this.Close();

        }
    }
}
