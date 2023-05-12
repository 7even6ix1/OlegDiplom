using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlegDiplom
{
    public partial class addLoginDataFrm : Form
    {
        private string login;
        public addLoginDataFrm(string login)
        {
            try
            {
                InitializeComponent();
                this.login = login;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    List<Workers> objectTypes = db.Workers.ToList();
                    objectBox.DataSource = objectTypes;
                    objectBox.DisplayMember = "Nickname";
                    objectBox.ValueMember = "Id";
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
                MenuFrm menuFrm = new MenuFrm(login);
                this.Hide();
                menuFrm.Show();
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
                LoginData model = new LoginData();
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    model.WorkerId = (int)objectBox.SelectedValue;
                    model.Password = nameBox.Text;
                    db.LoginData.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Успешно!");
                    MenuFrm objectsFrm = new MenuFrm(login);
                    this.Hide();
                    objectsFrm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }
    }
}
