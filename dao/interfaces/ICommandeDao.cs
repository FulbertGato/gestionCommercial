using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao.interfaces
{
    public interface ICommandeDao: IDao<Commande>
    {

        Commande findComandeByRef(String reference);
        List<Commande> findcommandeByIdClient(int id);
        List<Commande> findAllCommande();
        List<Commande> findAllCommande(string statut);
        List<Commande> findAllCommandeTelClient(string tel);
    }
}
