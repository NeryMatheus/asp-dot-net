using finance_web_domain.Entities;

namespace finance_web_service.interfaces
{
    public interface ITransacaoService
    {
        void Cadastrar(Transacao Entidade);

        void Excluir(int Id);

        List<Transacao> ListarRegistros();

        Transacao RetornarRegistro(int Id);

    }
}