using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dto
{
    public interface IDto<TDto, TModel>
    {
        TModel dtoToModel();
        TDto modelToDto(TModel model);
    }
}
