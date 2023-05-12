using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlegDiplom
{
    public partial class ObjectWorkersFrm : Form
    {
        private string login;
        public ObjectWorkersFrm(string login)
        {
            InitializeComponent();
            this.login = login;
            LoadGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuFrm menuFrm = new MenuFrm(login);
            this.Hide();
            menuFrm.Show();
        }
        private void LoadGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection("workstation id=OlegTrushDiplom.mssql.somee.com;packet size=4096;user id=TrueO_SQLLogin_1;pwd=t2djqjx6on;data source=OlegTrushDiplom.mssql.somee.com;persist security info=False;initial catalog=OlegTrushDiplom");
                con.Open();
                string query = "Select * from WorkersOnObjectsView ";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[13]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
                    data[data.Count - 1][10] = reader[10].ToString();
                    data[data.Count - 1][11] = reader[11].ToString();
                    data[data.Count - 1][12] = reader[12].ToString();

                }
                reader.Close();
                con.Close();
                foreach (string[] s in data)
                    workersInfoPredDataGridView.Rows.Add(s);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < workersInfoPredDataGridView.Rows.Count; i++)
                {
                    workersInfoPredDataGridView.Rows[i].Visible = workersInfoPredDataGridView[7, i].Value.ToString() == workerBox.Text;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < workersInfoPredDataGridView.Rows.Count; i++)
                {
                    workersInfoPredDataGridView.Rows[i].Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("workstation id=OlegTrushDiplom.mssql.somee.com;packet size=4096;user id=TrueO_SQLLogin_1;pwd=t2djqjx6on;data source=OlegTrushDiplom.mssql.somee.com;persist security info=False;initial catalog=OlegTrushDiplom");
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Workers WHERE Id =@pId", con);
                command.Parameters.Add(new SqlParameter("@pId", this.workersInfoPredDataGridView.CurrentRow.Cells["Id"].Value));
                command.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                workersInfoPredDataGridView.Rows.Clear();
                LoadGrid();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addWorkerOnObjectFrm addWorkerOnObjectFrm = new addWorkerOnObjectFrm(login);
            this.Hide();
            addWorkerOnObjectFrm.Show();
        }
    }
}
