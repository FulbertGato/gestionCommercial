using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao.interfaces
{
    public interface IProduitDao : IDao<Produit>
    {
        DbSet<Produit> findAll();
        int update(int id, int stock);
    }
}
