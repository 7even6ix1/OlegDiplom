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
    public partial class addCallFrm : Form
    {
        Calls model = new Calls();
        private string login;
        public addCallFrm(string login)
        {
            try
            {
                InitializeComponent();
                this.login = login;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    List<Objects> objects = db.Objects.ToList();
                    objectBox.DataSource = objects;
                    objectBox.DisplayMember = "Name";
                    objectBox.ValueMember = "Id";
                    List<Prichini> prichinis = db.Prichini.ToList();
                    reasonBox.DataSource = prichinis;
                    reasonBox.DisplayMember = "Name";
                    reasonBox.ValueMember = "Id";
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
                CallsFrm callsFrm = new CallsFrm(login);
                this.Hide();
                callsFrm.Show();
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
                model.ObjectId = (int)objectBox.SelectedValue;
                model.PrichId = (int)reasonBox.SelectedValue;
                model.Description = nameBox.Text;
                model.Date = dateTimePicker1.Value;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    db.Calls.Add(model);
                    db.SaveChanges();
                }
                MessageBox.Show("Успешно!");
                CallsFrm objectsFrm = new CallsFrm(login);
                this.Hide();
                objectsFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }

        private void addCallFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
