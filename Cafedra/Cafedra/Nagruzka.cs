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
    public partial class Nagruzka : Form
    {
        public Nagruzka()
        {
            InitializeComponent();
        }

        private void Nagruzka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nagruzka_1.Nagruzka' table. You can move, or remove it, as needed.
            this.nagruzkaTableAdapter.Fill(this.nagruzka_1.Nagruzka);

        }

        private void dobavit_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO Nagruzka (id_prepodovatelya, id_predmeta, vid_nagruzki) VALUES (@id_prepod, @id_predmeta, @vid_nagruzki)", db.getConnection());

            command.Parameters.Add("@id_prepod", SqlDbType.VarChar).Value = id_prepod.Text;
            command.Parameters.Add("@id_predmeta", SqlDbType.VarChar).Value = id_predmeta.Text;
            command.Parameters.Add("@vid_nagruzki", SqlDbType.VarChar).Value = vid_nagruzki.Text;

            db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            string sql = "select * from Nagruzka";
            command.CommandText = sql;
            DataSet m_set = new DataSet();
            adapter.Fill(m_set);
            dataGridView1.DataSource = m_set.Tables[0];

            db.closeConnection();
        }

        private void izmenenie_Click(object sender, EventArgs e)
        {
            DB db = new DB();


            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("update Nagruzka set id_prepodovatelya='" + id_prepod.Text + "', vid_nagruzki='" + vid_nagruzki.Text + "' where id_nagruzki='" + id_nagruzki.Text +"'", db.getConnection());


            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            string sql = "select * from Nagruzka";
            command.CommandText = sql;
            DataSet m_set = new DataSet();
            adapter.Fill(m_set);
            dataGridView1.DataSource = m_set.Tables[0];
            db.closeConnection();
        }

        private void udalenie_Click(object sender, EventArgs e)
        {
            DB db = new DB();


            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("delete from Nagruzka where id_nagruzki='" + id_nagruzki.Text + "'", db.getConnection());
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            string sql = "select * from Nagruzka";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
