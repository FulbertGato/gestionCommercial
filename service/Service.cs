using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.service
{
    public class Service : IService
    {

        private IUserDao userDao;
        private IClientDao clientDao;
        private ILivreurDao livreurDao;

        public Service()
        {
        }


        //Injection de Dépendance
        public Service(IUserDao userDao, IClientDao clientDao, ILivreurDao livreurDao)
        {
            this.userDao = userDao;
            this.clientDao = clientDao;
            this.livreurDao = livreurDao;
            
        }

        public IUserDao UserDao { get => userDao; set => userDao = value; }
        public IClientDao ClientDao { get => clientDao; set => clientDao = value; }
        public ILivreurDao LivreurDao { get => livreurDao; set => livreurDao = value; }

        public int addClient(Client client)
        {
            return this.clientDao.insert(client);
        }

        public int AddLivreur(Livreur liveur)
        {
            throw new NotImplementedException();
        }

        public int addUser(User user)
        {
            throw new NotImplementedException();
        }

        public int deleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User searchUserLoginAndPassword(string login, string password)
        {
            return this.userDao.findUserByLoginAndPassword(login,password);
        }

        public DataTable showAllUsers()
        {
            throw new NotImplementedException();
        }

        public int updateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
