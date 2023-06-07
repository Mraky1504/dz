using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafedra
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void prepod_Click(object sender, EventArgs e)
        {
            Prepodi x = new Prepodi();
            x.Show();
            this.Hide();
        }

        private void predmeti_Click(object sender, EventArgs e)
        {
            Predmeti x = new Predmeti();
            x.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nagruzka_Click(object sender, EventArgs e)
        {
            Nagruzka x = new Nagruzka();
            x.Show();
            this.Hide();
        }
    }
}
