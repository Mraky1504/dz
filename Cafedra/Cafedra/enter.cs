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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }
        public String ConnectString;//Строка подключения к БД 
        public Exception error = null;//Класс ошибок
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
