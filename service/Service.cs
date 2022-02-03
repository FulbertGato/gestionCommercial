using gestion_com_2022.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
        private ICategorieDao categorieDao;
        private IProduitDao produitDao;
        private ICommandeDao commandeDao;
        private IDetailCommandesDao detailCommandesDao;

        public Service()
        {
        }


        //Injection de Dépendance
        public Service(IUserDao userDao, IClientDao clientDao, ILivreurDao livreurDao, ICategorieDao categorieDao, IProduitDao produitDao, ICommandeDao commandeDao, IDetailCommandesDao detailCommandesDao)
        {
            this.userDao = userDao;
            this.clientDao = clientDao;
            this.livreurDao = livreurDao;
            this.CategorieDao = categorieDao;
            this.produitDao = produitDao;
            this.commandeDao = commandeDao;
            this.DetailCommandesDao = detailCommandesDao;


        }

        public IUserDao UserDao { get => userDao; set => userDao = value; }
        public IClientDao ClientDao { get => clientDao; set => clientDao = value; }
        public ILivreurDao LivreurDao { get => livreurDao; set => livreurDao = value; }
        public ICategorieDao CategorieDao { get => categorieDao; set => categorieDao = value; }
        public IProduitDao ProduitDao { get => produitDao; set => produitDao = value; }
        public ICommandeDao CommandeDao { get => commandeDao; set => commandeDao = value; }
        public IDetailCommandesDao DetailCommandesDao { get => detailCommandesDao; set => detailCommandesDao = value; }

        public int addCategorie(Categorie cat)
        {
            return this.categorieDao.insert(cat);
        }

        public int editCategorie(Categorie cat)
        {
            return this.categorieDao.update(cat);
        }

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

       

        public Client searchClientByUserId(int id)
        {
            return this.clientDao.findById(id);
        }

        public User searchUserLoginAndPassword(string login, string password)
        {
            return this.userDao.findUserByLoginAndPassword(login,password);
        }

        public DbSet<Categorie> showAllCategories()
        {
            return this.categorieDao.findAll();
        }

        public DataTable showAllUsers()
        {
            throw new NotImplementedException();
        }

        public int updateClient(Client client)
        {
            return this.clientDao.update(client);
        }

        public int updateUser(User user)
        {
            throw new NotImplementedException();
        }

        public int addProduit(Produit produit)
        {
            return this.produitDao.insert(produit);
        }

        public DbSet<Produit> showAllProduits()
        {
            return this.produitDao.findAll();
        }

        public int EditProduit(Produit produit)
        {
            return this.produitDao.update(produit);
        }

        public Produit findProduitById(int v)
        {
            return this.produitDao.findById(v);
        }

        public int addCommande(Commande cmd)
        {
            return this.commandeDao.insert(cmd);
        }

        public Commande findCommandeByRef(string refgene)
        {
            return this.commandeDao.findComandeByRef(refgene);
        }

        public int addDetailByList(List<DetailCommande> listeDetails)
        {
            return this.addDetailByList(listeDetails);
        }

        public int UpdateCommandeDetails(Commande co)
        {
            return this.commandeDao.update(co);
        }

        public int soldeCompteUpdate(int id, double solde)
        {
            return this.clientDao.soldeCompteUpdate(id, solde);
        }

        public List<Commande> showAllCommandesByClient(int id)
        {
            return this.commandeDao.findcommandeByIdClient(id);
        }

        public Commande findCommandeById(int id)
        {
            return this.commandeDao.findById(id);
        }
    }
}
