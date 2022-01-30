using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao
{
    public class ClientDao: IClientDao
    {
        Model1Container model = new Model1Container();

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public Client findById(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(Client client)
        {
            model.Users.Add(client);

            return model.SaveChanges();
        }

        public int update(Client obj)
        {
            throw new NotImplementedException();
        }
    }
}
