using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dto
{
    public class CommandeDto : IDto<CommandeDto, Commande>
    {

        private int Id;
        private String numero;
        private DateTime date;
        private String telephone;
        private double montant;

        public int Id1 { get => Id; set => Id = value; }
        public string Numero { get => numero; set => numero = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public double Montant { get => montant; set => montant = value; }

        public Commande dtoToModel()
        {
            throw new NotImplementedException();
        }

        public CommandeDto modelToDto(Commande model)
        {
            throw new NotImplementedException();
        }
    }
}
