using Microsoft.AspNet.Identity.EntityFramework;
using OwinAutentication.Acessos.Lgroup.DomainModel;

namespace OwinAutentication.Acessos.Lgroup.Infra.Data
{
    public class AcessosContext
        :IdentityDbContext<Usuario>
    {
        //Estamos setando a string de conexão do webConfig
        //com o name AAIdentity1
        public AcessosContext() 
            : base("AAIdentity1")
        {        }
    }
}
