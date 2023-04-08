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

namespace ExerciseWeek2
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-HMAJCBB8\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from StudentManagement";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            tb_id.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_name.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tbNS.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_add.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into StudentManagement values('" + tb_id.Text + "', '" + tb_name.Text + "','" + tbNS.Text + "','" + tb_add.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "delete from StudentManagement where id = '" + tb_id.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "update StudentManagement set name = '" + tb_name.Text + "', birth ='" + tbNS.Text + "', address =  '" + tb_add.Text + "' where id = '"+tb_id.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void khoitao_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tbNS.Text = "1/1/1900";
            tb_add.Text = "";
        }
    }
}
