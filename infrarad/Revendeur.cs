using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrarad
{
    class Revendeur
    {
        private int noRevendeur;
        private String raisonSociale;
        private String adresse;
        private int codePostal;
        private String ville;
        private String noTel;
        private String noFax;
        private String mail;

        public Revendeur()
        {
        }

        public void retrieve(int valeurSelectionne)
        {
            BDD.connexion();
            String req;
            req = "SELECT * FROM Revendeur WHERE NoRevendeur=" + valeurSelectionne;
            OleDbCommand cmd = new OleDbCommand(req, BDD.maConnexion);
            OleDbDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            this.noRevendeur = (int)rdr["NoRevendeur"];
            this.raisonSociale = (String)rdr["Raisonsociale"];
            this.adresse = (String)rdr["Adresse"];
            this.codePostal = (int)rdr["CodePostal"];
            this.ville = (String)rdr["Ville"];
            this.noTel = (String)rdr["NoTel"];
            this.noFax = (String)rdr["NoFax"];
            this.mail = (String)rdr["Mail"];
        }
        public int getRevendeur()
        {
            return this.noRevendeur;
        }
        public String getRaisonSociale()
        {
            return this.raisonSociale;
        }
        public String getAdresse()
        {
            return this.adresse;
        }
        public int getCodePostal()
        {
            return this.codePostal;
        }
        public String getNoTel()
        {
            return this.noTel;
        }

        public String getNoFax()
        {
            return this.noFax;
        }
        public String getVille()
        {
            return this.ville;
        }
        public String getMail()
        {
            return this.mail;
        }
    }
}
