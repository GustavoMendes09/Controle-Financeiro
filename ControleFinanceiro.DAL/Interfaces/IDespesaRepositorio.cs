using ControleFinanceiro.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.DAL.Interfaces
{
    public interface IDespesaRepositorio : IRepositorioGenerico<Despesa>
    {
        IQueryable<Despesa> PegarDespesasPeloUsuarioId(string usuarioId);
        IQueryable<Despesa> FiltrarDespesas(string nomeCategoria);

        void ExcluirDespesas(IEnumerable<Despesa> despesas);

        Task<IEnumerable<Despesa>> PegarDespesasPeloCartaoId(int cartaoId);
        Task<double> PegarDespesaTotalPeloUsuarioId(string usuarioId);
    }
}
