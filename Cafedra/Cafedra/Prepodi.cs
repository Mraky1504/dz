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
using System.IO;

namespace Cafedra
{
    public partial class Prepodi : Form
    {
        public Prepodi()
        {
            InitializeComponent();
        }

        private void Prepodi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prepodi_1.Prepod' table. You can move, or remove it, as needed.
            this.prepodTableAdapter.Fill(this.prepodi_1.Prepod);

        }

        private void dobavit_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO Prepod (id_cafedri, familia, imya, otchestvo) VALUES (@id_caf, @familia, @imya, @otchestvo)", db.getConnection());


            command.Parameters.Add("@id_caf", SqlDbType.VarChar).Value = id_caf.Text;
            command.Parameters.Add("@familia", SqlDbType.VarChar).Value = familia.Text;
            command.Parameters.Add("@imya", SqlDbType.VarChar).Value = imya.Text;
            command.Parameters.Add("@otchestvo", SqlDbType.VarChar).Value = otchestvo.Text;

            db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            string sql = "select * from Prepod";
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
            SqlCommand command = new SqlCommand("update Prepod set id_cafedri= '" + id_caf.Text + "', familia= '" + familia.Text + "', imya='" + imya.Text + "', otchestvo='" + otchestvo.Text + "' where id_prepodovatelya='" + id_prepod.Text + "'", db.getConnection());


            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            string sql = "select * from Prepod";
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
            SqlCommand command = new SqlCommand("delete from Prepod where id_prepodovatelya='" + id_prepod.Text + "'", db.getConnection());
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            string sql = "select * from Prepod";
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

        private void print_Click(object sender, EventArgs e)
        {
            DateTime filterDate = new DateTime(2023, 5, 1); // Пример фильтрации по 1 мая 2023 года
            string filterDateStr = filterDate.ToString("yyyy-MM-dd"); // Пример формата "yyyy-MM-dd"


            string connectionString = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user60_db;persist security info=True;user id=user60_db;password=user60;MultipleActiveResultSets=True;App=EntityFramework";
            string query = "SELECT * FROM Prepod";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(Convert.ToString("@filterDate"), "01.05.2023" + "00:00:00");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                        saveFileDialog.FilterIndex = 1;
                        saveFileDialog.RestoreDirectory = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                            {
                                // Запись заголовков столбцов
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    writer.Write("\"" + reader.GetName(i) + "\"");
                                    if (i < reader.FieldCount - 1)
                                    {
                                        writer.Write(";");
                                    }
                                }
                                writer.WriteLine();

                                // Запись данных
                                while (reader.Read())
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        writer.Write("\"" + reader.GetValue(i).ToString().Replace("\"", "\"\"") + "\"");
                                        if (i < reader.FieldCount - 1)
                                        {
                                            writer.Write(";");
                                        }
                                    }
                                    writer.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
