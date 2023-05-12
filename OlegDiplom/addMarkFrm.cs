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
    public partial class addMarkFrm : Form
    {
        private string login;
        public addMarkFrm(string login)
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
                Marks model = new Marks();
                model.Name = nameBox.Text;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    db.Marks.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Марка добавлена!");
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
