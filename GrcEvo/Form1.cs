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

namespace GrcEvo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AfficheAllClient();
            AddCustomer();
            Console.WriteLine("Fin");
            Console.ReadLine();
        }

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
    }
}
