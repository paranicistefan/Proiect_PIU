using System;
using Masini;
using Clienti;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfata
{
    public partial class DataGrid : Form
    {
        public List<masina> Masini { get; set; }
        public List<client> Clienti { get; set; }
        public DataGrid(ListaMasini M,ListaClienti C, int op)
        {
            InitializeComponent();
            switch (op)
            {
                case 3:
                    dataGridView1.DataSource = M.show();
                    break;
                case 4:
                    dataGridView1.DataSource = C.show();
                    break;
                default:
                    break;
            }
        }
    }
}
