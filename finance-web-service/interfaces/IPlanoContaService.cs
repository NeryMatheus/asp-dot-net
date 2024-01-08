using finance_web_domain.Entities;

namespace finance_web_service.interfaces
{
    public interface IPlanoContaService
    {
        void Cadastrar(PlanoConta Entidade);

        void Excluir(int Id);

        List<PlanoConta> ListarRegistros();

        PlanoConta RetornarRegistro(int Id);

    }
}