using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjWFDotNet23_05_2022
{
    public partial class FrmConsultaImovel : Form
    {
        public FrmConsultaImovel()
        {
            InitializeComponent();
        }
        private void dgvImovel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultaImovel_Load(object sender, EventArgs e)
        {
            dgvImovel.DataSource = null;
            dgvImovel.DataSource = new ImovelService().findAll();
        }
    }
}
