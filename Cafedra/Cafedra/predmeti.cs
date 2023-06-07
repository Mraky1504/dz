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
    public partial class Predmeti : Form
    {
        public Predmeti()
        {
            InitializeComponent();
        }

        private void Predmeti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'predmeti_1.Predmet' table. You can move, or remove it, as needed.
            this.predmetTableAdapter.Fill(this.predmeti_1.Predmet);

        }

        private void udalenie_Click(object sender, EventArgs e)
        {
            DB db = new DB();


            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("delete from Predmet where id_predmeta='" + id_predmeta.Text + "'", db.getConnection());
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            string sql = "select * from Predmet";
            command.CommandText = sql;
            DataSet m_set = new DataSet();
            adapter.Fill(m_set);
            dataGridView1.DataSource = m_set.Tables[0];
            db.closeConnection();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main x = new Main();
            x.Show();
            this.Hide();
        }

        private void izmenenie_Click(object sender, EventArgs e)
        {
            DB db = new DB();


            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("update Predmet set  predmet= '" + predmet.Text + "'where id_predmeta='" + id_predmeta.Text + "'", db.getConnection());


            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            string sql = "select * from Predmet";
            command.CommandText = sql;
            DataSet m_set = new DataSet();
            adapter.Fill(m_set);
            dataGridView1.DataSource = m_set.Tables[0];
            db.closeConnection();
        }

        private void dobavit_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO Predmet (predmet) VALUES (@predmet)", db.getConnection());

            command.Parameters.Add("@predmet", SqlDbType.VarChar).Value = predmet.Text;

            db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            string sql = "select * from Predmet";
            command.CommandText = sql;
            DataSet m_set = new DataSet();
            adapter.Fill(m_set);
            dataGridView1.DataSource = m_set.Tables[0];

            db.closeConnection();
        }
    }
}
