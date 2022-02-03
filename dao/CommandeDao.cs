using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return model.Commandes.Find(id);
        }

        public Commande findComandeByRef(string reference)
        {
            Commande commande = model.Commandes.Where(s => s.Numero == reference).FirstOrDefault();
            return commande;
        }

        public List<Commande> findcommandeByIdClient(int id)
        {
            // return (DbSet<Commande>)model.Commandes.Where(s => s.ClientId == id);
          return  model.Commandes.SqlQuery("SELECT * FROM Commandes WHERE ClientId = "+id).ToList();
        }

        public int insert(Commande comde)
        {
            
            model.Commandes.Add(comde);
            return model.SaveChanges();
        }

        public int update(Commande cmde)
        {
            Commande commande = model.Commandes.Find(cmde.Id);
            commande.DetailCommandes = cmde.DetailCommandes;
            return model.SaveChanges();
        }
    }
}
