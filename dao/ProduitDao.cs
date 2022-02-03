using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public DbSet<Produit> findAll()
        {
            return model.Produits;
        }

        public Produit findById(int id)
        {
            return model.Produits.Find(id);
        }

        public int insert(Produit produit)
        {
             
            model.Produits.Add(produit);

            return model.SaveChanges();
        }

        public int update(Produit obj)
        {
            Produit produit = model.Produits.Find(obj.Id);
            produit.Libelle = obj.Libelle;
            produit.Prix = obj.Prix;
            produit.SeuilStock = obj.SeuilStock;
            produit.Stock = obj.Stock;
            produit.Description = obj.Description;

            return model.SaveChanges();

        }

        public int update(int id, int stock)
        {
            Produit produit = model.Produits.Find(id);
            
          
            produit.Stock = stock;
            

            return model.SaveChanges();
        }
    }
}
