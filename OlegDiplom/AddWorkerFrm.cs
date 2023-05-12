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
    public partial class AddWorkerFrm : Form
    {
        Workers model = new Workers();
        WorkerGun gunmodel = new WorkerGun();
        GroupWorkers workergroup = new GroupWorkers();
        private string login;
        private int ae;
        int b = 0;
        public AddWorkerFrm(string login, int ae)
        {
            try
            {
                InitializeComponent();
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    List<Posts> posts = db.Posts.ToList();
                    postBox.DataSource = posts;
                    postBox.DisplayMember = "Name";
                    postBox.ValueMember = "Id";
                    List<GunModel> gunModels = db.GunModel.ToList();
                    gunBox.DataSource = gunModels;
                    gunBox.DisplayMember = "Name";
                    gunBox.ValueMember = "Id";
                    List<Groups> groups = db.Groups.ToList();
                    GrouppBox.DataSource = groups;
                    GrouppBox.DisplayMember = "Name";
                    GrouppBox.ValueMember = "Id";
                }

                this.login = login;
                this.ae = ae;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }

        private void AddWorkerFrm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("workstation id=OlegTrushDiplom.mssql.somee.com;packet size=4096;user id=TrueO_SQLLogin_1;pwd=t2djqjx6on;data source=OlegTrushDiplom.mssql.somee.com;persist security info=False;initial catalog=OlegTrushDiplom");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Workers order by Id DESC", con);
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

        private void button5_Click(object sender, EventArgs e)
        {
            workersGroupsFrm workersGroupsFrm = new workersGroupsFrm(login);
            this.Hide();
            workersGroupsFrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                model.Id = b;
                model.Surname = surnameBox.Text;
                model.Name = nameBox.Text;
                model.Patronymic = patrBox.Text;
                model.Birthdate = dateTimePicker1.Value;
                model.Address = addressBox.Text;
                model.Phone = phoneBox.Text;
                model.Nickname = nickBox.Text;
                model.PostId = (int)postBox.SelectedValue;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    db.Workers.Add(model);
                    db.SaveChanges();
                }
                gunmodel.WorkerId = b;
                gunmodel.GunId = (int)gunBox.SelectedValue;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    db.WorkerGun.Add(gunmodel);
                    db.SaveChanges();
                }
                workergroup.WorkerId = b;
                workergroup.GroupId = (int)GrouppBox.SelectedValue;
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    db.GroupWorkers.Add(workergroup);
                    db.SaveChanges();
                }
                MessageBox.Show("Успешно!");
                workersGroupsFrm workersGroupsFrm = new workersGroupsFrm(login);
                this.Hide();
                workersGroupsFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }
    }
}
