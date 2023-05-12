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
    public partial class addGunFrm : Form
    {
        private string login;
        public addGunFrm(string login)
        {
            try
            {
                InitializeComponent();
                this.login = login;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    List<GunModel> gunModels = db.GunModel.ToList();
                    typeBox.DataSource = gunModels;
                    typeBox.ValueMember = "Id";
                    typeBox.DisplayMember = "Name";
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
                Guns model = new Guns();
                model.ModelId = (int)typeBox.SelectedValue;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    db.Guns.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Оружие добавлено!");
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
