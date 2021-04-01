using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infrarad
{
    public partial class Form1 : Form
    {
        private List<int> tableauID = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BDD.connexion();
            String req;
            req = "select * from Revendeur";
            OleDbCommand cmd = new OleDbCommand(req, BDD.maConnexion);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while ( rdr.Read() )
            {
                String raisonSociale = (String)rdr["Raisonsociale"];
                String ville = (String)rdr["Ville"];
                String numRevendeur = rdr["NoRevendeur"].ToString();
                comboBox1.Items.Add(raisonSociale + " - " + ville + " - " + numRevendeur);
                tableauID.Add((int)rdr["NoRevendeur"]);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Int32 valeurSelectionne;
            valeurSelectionne = comboBox1.SelectedIndex;
            Revendeur RevSel = new Revendeur();
            RevSel.retrieve(tableauID[valeurSelectionne]);
            textBox5.Text = RevSel.getRevendeur().ToString() ;
            textBox4.Text = RevSel.getRaisonSociale().ToString();
            textBox3.Text = RevSel.getAdresse().ToString();
            textBox2.Text = RevSel.getCodePostal().ToString();
            textBox1.Text = RevSel.getVille().ToString();
            textBox6.Text = RevSel.getNoTel().ToString();
            textBox7.Text = RevSel.getNoFax().ToString();
            textBox8.Text = RevSel.getMail().ToString();
        }
    }
}
