using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrcEvo.DTO;
using GrcEvo.DAL;

namespace GrcEvo.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            /*
            AfficheAllClient();
            AddCustomer();
            AfficheAllClient();
            */

            AfficheAllTiers();

            InitializeComponent();
        }

        static void AfficheAllTiers()
        {
            ThirdPartyProvider tiersProvider = new ThirdPartyProvider();

            foreach (EntityThirdParty tiers in tiersProvider.getAll())
            {
                Console.WriteLine(tiers);
            }
        }

        
        private void btnAction_Click(object sender, EventArgs e)
        {
            /* TEMPORAIRE fonctions de test de l'application */
            Console.WriteLine("TEST GRCEVO");
            Console.WriteLine("Enregistrement d'un nouvel enregistrement");

            EntityCountry newCountry = new EntityCountry();
            CountryProvider cp = new CountryProvider();
            newCountry.Name = "PAYS MERVEILLEUX";
            newCountry.Abbreviation = "PM";
            cp.Create(newCountry);

            Console.ReadLine();

        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerEditForm frm = new CustomerEditForm();
            frm.ShowDialog();
        }
    }
}
