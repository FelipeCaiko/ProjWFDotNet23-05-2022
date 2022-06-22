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
    public partial class FrmConsultaLocacao : Form
    {
        public FrmConsultaLocacao()
        {
            InitializeComponent();
        }

        private void FrmConsultaLocacao_Load(object sender, EventArgs e)
        {
            dgvLocacao.DataSource = null;
            dgvLocacao.DataSource = new LocacaoService().findAll();
        }
    }
}
