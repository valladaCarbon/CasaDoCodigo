using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{

    public interface IPedidoRepository
    {

    }
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}