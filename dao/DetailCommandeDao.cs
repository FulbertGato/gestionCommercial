using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao
{
    public class DetailCommandeDao : IDetailCommandesDao
    {
        Model1Container model = new Model1Container();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<DetailCommande> findAllDetailCommandeByCommmandeId(int id)
        {
            return model.DetailCommandes.SqlQuery("SELECT * FROM DetailCommandes WHERE CommandeId = " + id).ToList();
        }

        public DetailCommande findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(DetailCommande obj)
        {
            throw new NotImplementedException();
        }

        public int insertDetailByList(List<DetailCommande> detailsLis)
        {
            model.DetailCommandes.AddRange(detailsLis);
            return model.SaveChanges();
        }

        public int update(DetailCommande obj)
        {
            throw new NotImplementedException();
        }
    }
}
