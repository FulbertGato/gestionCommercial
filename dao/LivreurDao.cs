using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao
{
    public class LivreurDao : ILivreurDao
    {
        Model1Container model = new Model1Container();
        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> findAll()
        {
            
            return model.Users.Where(cmde => cmde.Role.CompareTo("ROLE_LIVREUR") == 0).ToList();
        }

        public List<User> findAll(String role)
        {
            
            return model.Users.Where(cmde => cmde.Role.CompareTo(role) == 0).ToList();
        }

        public Livreur findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Livreur obj)
        {
            model.Users.Add(obj);
            return model.SaveChanges();
        }

        public int update(Livreur obj)
        {
            throw new NotImplementedException();
        }
    }
}
