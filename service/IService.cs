using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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

        int soldeCompteUpdate(int id, double solde);
        int updateClient(Client client);

        int AddLivreur(Livreur liveur);
        int addUser(User user);
        int updateUser(User user);
        List<Commande> showAllCommandes();
        int deleteUser(int id);
        List<User> showAllUsers();


        //Gestion produit

        DbSet<Categorie> showAllCategories();
        int addCategorie(Categorie cat);
        int editCategorie(Categorie cat);
        int addProduit(Produit produit);
        DbSet<Produit> showAllProduits();
        int EditProduit(Produit produit);
        Produit findProduitById(int v);
        List<DetailCommande> showAllDetailCommandeByCommmandeId(int id);
        int addCommande(Commande cmd);
        Commande findCommandeByRef(string refgene);
        int addDetailByList(List<DetailCommande> listeDetails);
        List<Commande> showAllCommandesByClient(int id);
        int UpdateCommandeDetails(Commande co);
        Commande findCommandeById(int id);
        List<Commande> showAllCommandes(string statut);
        List<Commande> showAllCommandesClientTel(string tel);
        List<User> showAllLivreurs(string v);


        int addLivraison(Livraison livraison);
        int AddLivraisonCommmande(Commande cmde);
        int stockProduitupdtade(int id, int stock);
    }
}
