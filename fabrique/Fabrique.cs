using gestion_com_2022.dao;
using gestion_com_2022.dao.interfaces;
using gestion_com_2022.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.fabrique
{
    public static class Fabrique
    {
        public static IService getInstanceService()
        {
            return new Service()
            {
                ClientDao = new ClientDao(),
                UserDao = new UserDao(),
                LivreurDao = new LivreurDao(),
                CategorieDao = new CategorieDao(),
                ProduitDao = new ProduitDao(),
                CommandeDao = new CommandeDao(),
                DetailCommandesDao = new DetailCommandeDao(),
                LivraisonDao = new LivraisonDao()
            };
        }
    }

}
