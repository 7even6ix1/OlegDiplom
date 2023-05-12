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
    public partial class addGroupFrm : Form
    {

        private string login;
        public addGroupFrm(string login)
        {
            InitializeComponent();
            this.login = login;
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
                Groups model = new Groups();
                model.Name = nameBox.Text;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    db.Groups.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Группа добавлена!");
                    MenuFrm menuFrm = new MenuFrm(login);
                    this.Hide();
                    menuFrm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }
    }
}
