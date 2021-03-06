using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao.interfaces
{
    public interface IUserDao : IDao<User>
    {
        User findUserByLoginAndPassword(String login, String password);
        List<User> findAllUser();
    }
}
