using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.service
{
   public interface IService
    {

        //Creer un compte

        int addClient(Client client);

        //Se Connecter
        User searchUserLoginAndPassword(string login, string password);

        //Gestion de compte

        Client searchClientByUserId(int id);
        int updateClient(Client client);

        int AddLivreur(Livreur liveur);
        int addUser(User user);
        int updateUser(User user);

        int deleteUser(int id);
        DataTable showAllUsers();
       
    }
}
