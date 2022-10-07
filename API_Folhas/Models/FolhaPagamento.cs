using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace API_Folhas.Models
{
    public class FolhaPagamento
    {
        public FolhaPagamento() => CriadoEm = DateTime.Now;
        public int FuncionarioId { get; set; }
        public int FolhaPagamentoId { get; set; }

        public int ValorHora { get; set; }
        public int QuantidadeHoras { get; set; }
        public double SalarioBruto { get; set; }
        public double ImpostoRenda { get; set; } 
        public double Inss { get; set; }
        public double Fgts { get; set; }
        public double SalarioLiquido { get; set; }
        public DateTime CriadoEm { get; set; }

        public FolhaPagamento(int ValorHora, int QuantidadeHoras, double SalarioBruto, 
                        double ImpostoRenda, double Inss, double Fgts, double SalarioLiquido)
        {
            this.ValorHora = ValorHora;
            this.QuantidadeHoras = QuantidadeHoras;
            this.SalarioBruto = SalarioBruto;
            this.ImpostoRenda = ImpostoRenda;
            this.Inss = Inss;
            this.Fgts = Fgts;
            this.SalarioLiquido = SalarioLiquido;
        }
    }
}