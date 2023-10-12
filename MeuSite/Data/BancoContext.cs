using Microsoft.EntityFrameworkCore;

namespace ControleeContatos.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        }

    }
}
