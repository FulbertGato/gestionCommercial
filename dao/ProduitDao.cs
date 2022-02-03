using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao
{
    public class ProduitDao : interfaces.IProduitDao
    {
        Model1Container model = new Model1Container();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public Produit findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Produit obj)
        {
             
            model.Produits.Add(obj);

            return model.SaveChanges();
        }

        public int update(Produit obj)
        {
            throw new NotImplementedException();
        }
    }
}
