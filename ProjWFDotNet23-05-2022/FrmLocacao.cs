using Models;
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
    public partial class FrmLocacao : Form
    {
        public FrmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {

            LoadCBOCliente();
            LoadCBOImovel();

        }

        private void LoadCBOImovel()
        {
            cboImovel.DataSource = new ImovelService().findAll();
            cboImovel.ValueMember = "Id";
            cboImovel.DisplayMember = "Descricao";
        }
        private void LoadCBOCliente()
        {
            cbocliente.DataSource = new ClienteService().findAll();
            cbocliente.ValueMember = "Id";
            cbocliente.DisplayMember = "Nome";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Locacao locacao = new Locacao()
            {
                Descricao = txtDesc.Text,
                Cliente = new Cliente() { Id = int.Parse(cbocliente.SelectedValue.ToString()) },
                Imovel = new Imovel() { Id = int.Parse(cboImovel.SelectedValue.ToString()) }
            };

            LocacaoService locacaoService = new LocacaoService();

            locacaoService.Add(locacao);

            MessageBox.Show("Aluguel Registrado com sucesso!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
