using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo.Repositories
{
    public class BaseRepository
    {
        
        private readonly ApplicationContext contexto;
        private readonly DbSet<Produto> dbSet;

        public ProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<Produto>();
        }
    }
}