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
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            /* TEMPORAIRE fonctions de test de l'application */
            Console.WriteLine("TEST GRCEVO");
            Console.ReadLine();
        }
    }
}
