using System.Collections.Generic;
using System.Linq;
using API_Folhas.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Folhas.Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaPagamentoController : ControllerBase
    {
        private readonly DataContext _context;

        //Injeção de dependência - balta.io
        public FolhaPagamentoController(DataContext context) =>
            _context = context;

        private static List<FolhaPagamento> folhas = new List<FolhaPagamento>();

        // GET: /api/funcionario/listar
        [Route("listar")]
        [HttpGet]
        public IActionResult Listar() =>
            Ok(_context.Folhas.ToList());


        [Route("filtrar/{mes}/{ano}")]
        [HttpGet]
        public IActionResult Filtrar([FromRoute] int mes, [FromRoute] int ano)
        {
            return Ok(_context.Folhas.ToList().FindAll(folha => folha.CriadoEm.Month.Equals(mes) && folha.CriadoEm.Year.Equals(ano)));
        }

        // POST: /api/funcionario/cadastrar
        [Route("cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] FolhaPagamento folha)
        {
            folha.SalarioBruto = folha.ValorHora * folha.QuantidadeHoras;

            // ImpostoRenda
            if (folha.SalarioBruto <= 1903.38)
            {
                folha.ImpostoRenda = 0;
            } 
            else if (folha.SalarioBruto > 1903.99 && folha.SalarioBruto <= 2826.65)
            {
                folha.ImpostoRenda = 142.8;
            } 
            else if (folha.SalarioBruto > 2826.66 && folha.SalarioBruto <= 3751.05)
            {
                folha.ImpostoRenda = 354.8;
            } 
            else if (folha.SalarioBruto > 3751.06 && folha.SalarioBruto <= 4664.68)
            {
                folha.ImpostoRenda = 636.13;
            } 
            else {
                folha.ImpostoRenda = 869.36;
            }

            // INSS
            if (folha.SalarioBruto <= 1693.72)
            {
                folha.Inss = folha.SalarioBruto * 0.8;
            } 
            else if (folha.SalarioBruto > 1693.72 && folha.SalarioBruto <= 2822.9)
            {
                folha.Inss = folha.SalarioBruto * 0.9;
            } 
            else if (folha.SalarioBruto > 2822.9 && folha.SalarioBruto <= 5645.8)
            {
                folha.Inss = folha.SalarioBruto * 0.11;
            }
            else {
                folha.Inss = folha.SalarioBruto - 621.03;
            }

            // FGTS
            folha.Fgts = folha.SalarioBruto * 0.08;

            // Líquido
            folha.SalarioLiquido = folha.SalarioBruto - folha.Inss - folha.ImpostoRenda;

            _context.Folhas.Add(folha);
            _context.SaveChanges();
            return Created("", folha);
        }

        // GET: /api/funcionario/buscar/123
        [Route("buscar/{id}")]
        [HttpGet]
        public IActionResult Buscar([FromRoute] string id)
        {
            //Expressão lambda
            FolhaPagamento folha =
                _context.Folhas.FirstOrDefault
            (
                f => f.FolhaPagamentoId.Equals(id)
            );
            //IF ternário
            return folha != null ? Ok(folha) : NotFound();
        }

        // DELETE: /api/funcionario/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]
        public IActionResult Deletar([FromRoute] int id)
        {
            FolhaPagamento folha =
                _context.Folhas.Find(id);
            if (folha != null)
            {
                _context.Folhas.Remove(folha);
                _context.SaveChanges();
                return Ok(folha);
            }
            return NotFound();
        }

        // PATCH: /api/funcionario/alterar
        [Route("alterar")]
        [HttpPatch]
        public IActionResult Alterar([FromBody] FolhaPagamento folha)
        {
            _context.Folhas.Update(folha);
            _context.SaveChanges();
            return Ok(folha);
        }
    }
}