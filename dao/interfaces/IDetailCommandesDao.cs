using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao.interfaces
{
    public interface IDetailCommandesDao:IDao<DetailCommande>
    {
        int insertDetailByList(List<DetailCommande> detailsLis);
        List<DetailCommande> findAllDetailCommandeByCommmandeId(int id);
    }
}
