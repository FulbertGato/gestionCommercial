using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao.interfaces
{
    public interface IClientDao : IDao<Client>
    {
        int soldeCompteUpdate(int id, double solde);
    }
}
