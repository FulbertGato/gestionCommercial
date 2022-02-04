using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao
{
    public class PaiementDao : IPaiementDao
    {

        Model1Container model = new Model1Container();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public Paiement findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Paiement obj)
        {

            model.Paiements.Add(obj);
            return model.SaveChanges();
        }

        public int update(Paiement obj)
        {
            throw new NotImplementedException();
        }
    }
}
