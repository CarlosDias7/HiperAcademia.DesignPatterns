using CadastrandoProdutos.Builder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrandoProdutos.Builder
{
    public partial class FormCadastroDeProdutos : Form
    {
        private readonly IProdutoServices _produtoServices;

        public FormCadastroDeProdutos()
        {
            _produtoServices = new ProdutoServices();
            InitializeComponent();
        }

        private void btnOriginadoDoCadastro_Click(object sender, EventArgs e)
        {
            var codigo = 1;
            var nome = "Produto1";
            var saldoEmEstoque = 10.00m;

            try
            {
                var produto = _produtoServices.CriarProdutoOriginadoDaTelaDeCadastro(codigo, nome, saldoEmEstoque);
                txtDescricaoDoProdutoCriado.Text = produto?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImportacaoDeProdutos_Click(object sender, EventArgs e)
        {
            var codigo = 2;
            var nome = "Produto2";
            var saldoEmEstoque = 50.00m;
            var dataDaImportacao = DateTime.Now;

            try
            {
                var produto = _produtoServices.CriarProdutoOriginadoDaImportacaoDeProdutos(codigo, nome, saldoEmEstoque, dataDaImportacao);
                txtDescricaoDoProdutoCriado.Text = produto?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNotaDeEntrada_Click(object sender, EventArgs e)
        {
            var codigo = 3;
            var nome = "Produto3";
            var saldoEmEstoque = 100.00m;
            var dataDaImportacao = DateTime.Now;
            var numeroDaNotaDeEntrada = 891187;

            try
            {
                var produto = _produtoServices.CriarProdutoOriginadoDeNotaFiscalDeEntrada(codigo, nome, saldoEmEstoque, dataDaImportacao, numeroDaNotaDeEntrada);
                txtDescricaoDoProdutoCriado.Text = produto?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}