using CadastrandoProdutos.Builder.Domain.Produtos;
using System;

namespace CadastrandoProdutos.Builder.Services
{
    internal interface IProdutoServices
    {
        Produto CriarProdutoOriginadoDaTelaDeCadastro(int codigo, string nome, decimal saldoEmEstoque);

        Produto CriarProdutoOriginadoDaImportacaoDeProdutos(int codigo, string nome, decimal saldoEmEstoque, DateTime dataDaImportacao);

        Produto CriarProdutoOriginadoDeNotaFiscalDeEntrada(int codigo, string nome, decimal saldoEmEstoque, DateTime dataDaImportacao, int numeroDaNotaDeEntrada);
    }
}