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
    public partial class AuthorisationFrm : Form
    {
        private string login;
        public AuthorisationFrm()
        {
            InitializeComponent();
        } 
        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("workstation id=OlegTrushDiplom.mssql.somee.com;packet size=4096;user id=TrueO_SQLLogin_1;pwd=t2djqjx6on;data source=OlegTrushDiplom.mssql.somee.com;persist security info=False;initial catalog=OlegTrushDiplom");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LoginData where WorkerId='" + loginBox.Text + "' and Password='" + passBox.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    login = loginBox.Text;
                    MenuFrm menuFrm = new MenuFrm(login);
                    this.Hide();
                    menuFrm.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден. Проверьте данные авторизации.");
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Проверьте корректность введённых данных.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                if (passBox.UseSystemPasswordChar == true)
                {
                    passBox.UseSystemPasswordChar = false;
                    label5.Text = "Скрыть пароль";
                }
                else
                {
                    
                    passBox.UseSystemPasswordChar = true;
                    label5.Text = "Показать пароль";
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }
    }
}
