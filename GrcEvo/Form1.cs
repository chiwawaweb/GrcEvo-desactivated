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
            Console.WriteLine("Fin");
            Console.ReadLine();
        }

        static void AfficheAllClient()
        {
            CustomerProvider customerProvider = new CustomerProvider();
        }
    }
}
