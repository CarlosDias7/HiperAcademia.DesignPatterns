using CadastroDeProdutos.Builder.Domain.Produtos.Origens;
using System;

namespace CadastroDeProdutos.Builder.Domain.Produtos
{
    public class Produto
    {
        public Produto(int codigo, string nome, decimal saldoEmEstoque, Origem origem, DateTime? dataDeImportacao, int? numeroDaNotaDeImportacao)
        {
            SetCodigo(codigo);
            SetIdExterno(Guid.NewGuid());
            SetNome(nome);
            SetSaldoDeEstoque(saldoEmEstoque);
            SetOrigem(origem);
            SetDataDeImportacao(dataDeImportacao);
            SetNumeroDaNotaFiscalDeImportacao(numeroDaNotaDeImportacao);
        }

        public int Codigo { get; private set; }
        public Guid IdExterno { get; private set; }
        public string Nome { get; private set; }
        public decimal SaldoEmEstoque { get; private set; }
        public Origem Origem { get; private set; }
        public DateTime? DataDeImportacao { get; private set; }
        public int? NumeroDaNotaFiscalDeImportacao { get; private set; }

        public void SetCodigo(int codigo)
        {
            Codigo = codigo;
        }

        public void SetIdExterno(Guid idExterno)
        {
            IdExterno = idExterno;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetSaldoDeEstoque(decimal saldoDeEstoque)
        {
            SaldoEmEstoque = saldoDeEstoque;
        }

        public void SetOrigem(Origem origem)
        {
            Origem = origem;
        }

        public void SetDataDeImportacao(DateTime? dataDeImportacao)
        {
            DataDeImportacao = dataDeImportacao;
        }

        public void SetNumeroDaNotaFiscalDeImportacao(int? idDaNotaFiscalDeImportacao)
        {
            NumeroDaNotaFiscalDeImportacao = idDaNotaFiscalDeImportacao;
        }
    }
}