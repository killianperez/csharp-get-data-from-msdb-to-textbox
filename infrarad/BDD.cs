using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrarad
{
    public class BDD
    {
        public static OleDbConnection maConnexion;

        public static void connexion()
        {
            String chaineConnexion;
            // chaineConnexion = "provider = Microsoft.ACE.Oldedb.12.0 ; data source =bdd.accdb;";
            chaineConnexion = "provider = Microsoft.Ace.OLEDB.12.0 ; data source = bdd.accdb;";
            maConnexion = new OleDbConnection(chaineConnexion);
            maConnexion.Open();
        }
    }
}
