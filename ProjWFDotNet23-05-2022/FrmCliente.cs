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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Nome = txtNome.Text,
                RG = txtRG.Text,
                Telefone = txtTelefone.Text,
            };

            ClienteService clienteService = new ClienteService();

            clienteService.Add(cliente);

            MessageBox.Show("Cliente Registrado com sucesso!");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtRG.Text = "";
            txtTelefone.Text = "";
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
