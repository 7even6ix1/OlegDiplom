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
    public partial class carsFrm : Form
    {
        private string login;
        private int b;
        Cars model = new Cars();
        GroupCars groupCars = new GroupCars();
        public carsFrm(string login)
        {
            try
            {
                InitializeComponent();
                this.login = login;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    List<Marks> marks = db.Marks.ToList();
                    markBox.DataSource = marks;
                    markBox.ValueMember = "Id";
                    markBox.DisplayMember = "Name";
                    List<ModelCars> modelCars = db.ModelCars.ToList();
                    modelBox.DataSource = modelCars;
                    modelBox.ValueMember = "Id";
                    modelBox.DisplayMember = "Name";
                    List<Sostoyanie> sostoyanies = db.Sostoyanie.ToList();
                    sostBox.DataSource = sostoyanies;
                    sostBox.ValueMember = "Id";
                    sostBox.DisplayMember = "Name";
                    List<Groups> groups = db.Groups.ToList();
                    gruppBox.DataSource = groups;
                    gruppBox.ValueMember = "Id";
                    gruppBox.DisplayMember = "Name";
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CarsViewFrm menuFrm = new CarsViewFrm(login);
            this.Hide();
            menuFrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                model.Id = b;
                model.MarkId = (int)markBox.SelectedValue;
                model.ModelId = (int)modelBox.SelectedValue;
                model.Gosnom = gosnomBox.Text;
                model.SostId = (int)sostBox.SelectedValue;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    db.Cars.Add(model);
                    db.SaveChanges();
                }
                groupCars.CarId = b;
                groupCars.GroupId = (int)gruppBox.SelectedValue;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    db.GroupCars.Add(groupCars);
                    db.SaveChanges();
                }
                MessageBox.Show("Успешно!");
                CarsViewFrm workersGroupsFrm = new CarsViewFrm(login);
                this.Hide();
                workersGroupsFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }

        private void carsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("workstation id=OlegTrushDiplom.mssql.somee.com;packet size=4096;user id=TrueO_SQLLogin_1;pwd=t2djqjx6on;data source=OlegTrushDiplom.mssql.somee.com;persist security info=False;initial catalog=OlegTrushDiplom");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Cars order by Id DESC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string a = dt.Rows[0][0].ToString();
                b = Convert.ToInt32(a) + 1;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }
    }
}
