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
    public partial class MenuFrm : Form
    {
        private string login;
        public MenuFrm(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void MenuFrm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("workstation id=OlegTrushDiplom.mssql.somee.com;packet size=4096;user id=TrueO_SQLLogin_1;pwd=t2djqjx6on;data source=OlegTrushDiplom.mssql.somee.com;persist security info=False;initial catalog=OlegTrushDiplom");
                SqlDataAdapter sda = new SqlDataAdapter("Select Surname, Name, Patronymic from Workers where Id='" + login + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataAdapter sda2 = new SqlDataAdapter("Select PostId from Workers where Id='" + login + "'", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                string post = dt2.Rows[0][0].ToString();
                SqlDataAdapter sda3 = new SqlDataAdapter("Select Name from Posts where Id='" + post + "'", con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                label1.Text = dt3.Rows[0][0].ToString() + ", " + dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
        }
            catch
            {
                MessageBox.Show("Возникла ошибка загрузки формы.");
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            ObjectsFrm objectsFrm = new ObjectsFrm(login);
            this.Hide();
            objectsFrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workersGroupsFrm workersGroupsFrm = new workersGroupsFrm(login);
            this.Hide();
            workersGroupsFrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ObjectWorkersFrm objectWorkersFrm = new ObjectWorkersFrm(login);
            this.Hide();
            objectWorkersFrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarsViewFrm carsViewFrm = new CarsViewFrm(login);
            this.Hide();
            carsViewFrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CallsFrm callsFrm = new CallsFrm(login);
            this.Hide();
            callsFrm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addGroupFrm addGroupFrm = new addGroupFrm(login);
            this.Hide();
            addGroupFrm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addLoginDataFrm addLoginDataFrm = new addLoginDataFrm(login);
            this.Hide();
            addLoginDataFrm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addPostFrm addPostFrm = new addPostFrm(login);
            this.Hide();
            addPostFrm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addMarkFrm addMarkFrm = new addMarkFrm(login);
            this.Hide();
            addMarkFrm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addModelCarFrm addModelCarFrm = new addModelCarFrm(login);
            this.Hide();
            addModelCarFrm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addGunFrm addGunFrm = new addGunFrm(login);
            this.Hide();
            addGunFrm.Show();
        }
    }
}
