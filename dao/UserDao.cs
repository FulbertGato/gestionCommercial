using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao
{
    public class UserDao : IUserDao
    {
        Model1Container model = new Model1Container();
        public int delete(int id)
        {
            model.Users.Remove(model.Users.Find(id));
            return model.SaveChanges();
        }

        public User findById(int id)
        {
            return model.Users.Find(id);
        }

        public User findUserByLoginAndPassword(string login, string password)
        {
            User user = model.Users.Where(s => s.Login == login  && s.Password == password).FirstOrDefault();
            return user;
        }

        public int insert(User user)
        {
            model.Users.Add(user);
            return model.SaveChanges();
        }

        public int update(User user)
        {
            return model.SaveChanges();
        }



    }
}
