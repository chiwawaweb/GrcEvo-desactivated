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

        /*
        static void AfficheAllClient()
        {
            CustomerProvider customerProvider = new CustomerProvider();

            foreach (EntityCustomer customer in customerProvider.getAll())
            {
                Console.WriteLine(customer);
            }
        }

        static void AddCustomer()
        {
            Console.WriteLine("===== Création de clients dans la base =====");
            CustomerProvider provider = new CustomerProvider();

            provider.Create(new EntityCustomer
            {
                PrefixCode = "CL",
                NumberCode = 10,
                Civility = "M."
            });
            provider.Create(new EntityCustomer
            {
                PrefixCode = "CL",
                NumberCode = 11,
                Civility = "Mme"
            });
            provider.Create(new EntityCustomer
            {
                PrefixCode = "CL",
                NumberCode = 12,
                Civility = "Dr"
            });
            Console.WriteLine("======================");
        }
        */
        private void btnAction_Click(object sender, EventArgs e)
        {
            /* TEMPORAIRE fonctions de test de l'application */
            Console.WriteLine("TEST GRCEVO");
            Console.ReadLine();
        }
    }
}
