using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao
{
    public class CategorieDao : ICategorieDao
    {
        Model1Container model = new Model1Container();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public Categorie findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Categorie obj)
        {
            model.Categories.Add(obj);
            return model.SaveChanges();
        }

        public int update(Categorie obj)
        {
            Categorie cat = model.Categories.Find(obj.Id);
            cat.Libelle = obj.Libelle;
            return model.SaveChanges();
        }
        public DbSet<Categorie> findAll()
        {
            System.Data.Entity.DbSet<Categorie> categories = model.Categories;
            return  categories;
        }
    }
}
