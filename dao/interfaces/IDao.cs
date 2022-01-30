using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dao.interfaces
{
    public interface IDao<T>
    {
        int insert(T obj);
        int update(T obj);
        int delete(int id);
        T findById(int id);
    }
}
