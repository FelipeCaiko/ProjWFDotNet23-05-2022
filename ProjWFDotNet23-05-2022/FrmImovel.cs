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
    public partial class FrmImovel : Form
    {
        public FrmImovel()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeLoc_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Imovel imovel = new Imovel()
            {
                Descricao = txbDesc.Text,
                Endereco = new Endereco() {CEP = txbCEP.Text, Bairro = txbBairro.Text, Numero = int.Parse(txbNumero.Text), Complemento = txbComp.Text, Logradouro = txbLog.Text },
                Locador = new Locador() {Nome = txbNomeLoc.Text, RG = txbRGLoc.Text, Telefone = txbTelLoc.Text}
            };

            ImovelService imovelService = new ImovelService();

            imovelService.Add(imovel);

            MessageBox.Show("Imóvel Registrado com sucesso!");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbDesc.Text = "";
            txbCEP.Text = "";
            txbBairro.Text = "";
            txbNumero.Text = "";
            txbComp.Text = "";
            txbLog.Text = "";
            txbNomeLoc.Text = "";
            txbRGLoc.Text = "";
            txbTelLoc.Text = "";
        }

        private void FrmImovel_Load(object sender, EventArgs e)
        {

        }
    }
}