using finance_web_domain.Entities;
using finance_web_infra;
using finance_web_service.interfaces;
using Microsoft.EntityFrameworkCore;

namespace finance_web_service
{
    public class TransacaoService : ITransacaoService
    {

        private readonly FinanceDbContext _dbContext;

        public TransacaoService(FinanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Cadastrar(Transacao Entidade)
        {
            var dbSet = _dbContext.Transacao;

            if (Entidade.Id == null)
            {
                dbSet.Add(Entidade);
            }
            else
            {
                dbSet.Attach(Entidade);
                _dbContext.Entry(Entidade).State = EntityState.Modified;
            }
            _dbContext.SaveChanges();
        }

        public void Excluir(int Id)
        {
            var transacao = new Transacao() { Id = Id };
            _dbContext.Attach(transacao);
            _dbContext.Remove(transacao);
            _dbContext.SaveChanges();
        }

        public List<Transacao> ListarRegistros()
        {
            var dbSet = _dbContext.Transacao;

            return dbSet.ToList();
        }

        public Transacao RetornarRegistro(int Id)
        {
            return _dbContext.Transacao.Where(x => x.Id == Id).First();
        }
    }
}