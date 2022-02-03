using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao
{
    
    public class CommandeDao : ICommandeDao
    {
        Model1Container model = new Model1Container();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public Commande findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Commande comde)
        {
            /*List<DetailCommande> listeDetails = new List<DetailCommande>();
            foreach (DetailCommande de in comde.DetailCommandes)
            {
                de.Commande = comde;
                model.DetailCommandes.Add(de);
                listeDetails.Add(de);
            }
            comde.DetailCommandes = listeDetails;*/
            model.Commandes.Add(comde);
            return model.SaveChanges();
        }

        public int update(Commande obj)
        {
            throw new NotImplementedException();
        }
    }
}
