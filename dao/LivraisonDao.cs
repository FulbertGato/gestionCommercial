using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao
{
    public class LivraisonDao : ILivraisonDao
    {
        Model1Container model = new Model1Container();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public Livraison findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Livraison obj)
        {
            model.Livraisons.Add(obj);
            return model.SaveChanges();
        }

        public int update(Livraison obj)
        {
            throw new NotImplementedException();
        }
    }
}
