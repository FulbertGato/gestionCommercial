
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------


namespace gestion_com_2022
{

using System;
    using System.Collections.Generic;
    
public partial class Livraison
{

    public int Id { get; set; }

    public System.DateTime Date { get; set; }

    public string Statut { get; set; }

    public int LivreurId { get; set; }

    public int CommandeId { get; set; }



    public virtual Livreur Livreur { get; set; }

    public virtual Commande Commande { get; set; }

}

}
