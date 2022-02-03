using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.dto
{
    class DetailCommandeDto : IDto<DetailCommandeDto, DetailCommande>
    {

        private String produitLibelle;
        private int id;
        private Double produitMontant;
        private Double produitPrix;
        private int Qte;

        public double ProduitMontant { get => produitMontant; set => produitMontant = value; }
        public string ProduitLibelle { get => produitLibelle; set => produitLibelle = value; }
        
        public double ProduitPrix { get => produitPrix; set => produitPrix = value; }
        public int Id { get => id; set => id = value; }
        public int Qte1 { get => Qte; set => Qte = value; }

        // private Produit produit;
        public DetailCommande dtoToModel()
        {
            throw new NotImplementedException();
        }

        public DetailCommandeDto modelToDto(DetailCommande model)
        {
            throw new NotImplementedException();
        }
    }
}
