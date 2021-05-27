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
    public partial class DetaliiMasina : Form
    {
        public DetaliiMasina(masina x)
        {
            
            InitializeComponent();
            lblCaroserie.Text = x.caroserie.ToString();
            lblClima.Text = x.aer.ToString();
            lblCombustibil.Text = x.fuel.ToString();
            lblCuloare.Text = x.culoare.ToString();
            lblCutie.Text = x.cv.ToString();
            lblGeamuri.Text = x.geamuri.ToString();
            if (x.OglinziElectrice)
                lblOp1.Visible=true;lblOp1.Text = "Oglinzi Electrice";
            if (x.PachetSport)
                lblOp2.Visible = true; lblOp2.Text = "Pachet Sport";
            if (x.ScauneElectrice)
                lblOp3.Visible = true; lblOp3.Text = "Scaune Electrice";
            if (x.SenzoriParcare)
                lblOp4.Visible = true; lblOp4.Text = "Senzori Parcare";
            if (x.FariuriAutomate)
                lblOp5.Visible = true;lblOp5.Text = "Faruri Automate";
            if (x.CriuseControl)
                lblOp6.Visible = true;lblOp6.Text = "Pilot Automat";

        }
    }
}
