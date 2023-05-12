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
    public partial class CarsViewFrm : Form
    {
        private string login;
        public CarsViewFrm(string login)
        {
            InitializeComponent();
            this.login = login;
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection("workstation id=OlegTrushDiplom.mssql.somee.com;packet size=4096;user id=TrueO_SQLLogin_1;pwd=t2djqjx6on;data source=OlegTrushDiplom.mssql.somee.com;persist security info=False;initial catalog=OlegTrushDiplom");
                con.Open();
                string query = "Select * from CarsView ";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            carsFrm carsFrm = new carsFrm(login);
            this.Hide();
            carsFrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < workersInfoPredDataGridView.Rows.Count; i++)
                {
                    workersInfoPredDataGridView.Rows[i].Visible = workersInfoPredDataGridView[2, i].Value.ToString() == workerBox.Text;
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

        private void button6_Click(object sender, EventArgs e)
        {
            MenuFrm menuFrm = new MenuFrm(login);
            this.Hide();
            menuFrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("workstation id=OlegTrushDiplom.mssql.somee.com;packet size=4096;user id=TrueO_SQLLogin_1;pwd=t2djqjx6on;data source=OlegTrushDiplom.mssql.somee.com;persist security info=False;initial catalog=OlegTrushDiplom");
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Cars WHERE Id =@pId", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            carsFrm carsFrm = new carsFrm(login);
            this.Hide();
            carsFrm.Show();
        }
    }
}
