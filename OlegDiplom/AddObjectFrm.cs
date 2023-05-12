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
    public partial class AddObjectFrm : Form
    {
        Objects model = new Objects();
        private string login;
        private int ae;
        public AddObjectFrm(string login, int ae)
        {
            try
            {

                InitializeComponent();
                using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                {
                    List<ObjectTypes> objectTypes = db.ObjectTypes.ToList();
                    typeBox.DataSource = objectTypes;
                    typeBox.DisplayMember = "Name";
                    typeBox.ValueMember = "Id";
                }

                this.login = login;
                this.ae = ae;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }

        private void AddObjectFrm_Load(object sender, EventArgs e)
        {
            try
            {
                typeBox.DropDownHeight = 300;
                if(ae != 0)
                {
                    SqlConnection con = new SqlConnection("workstation id=OlegTrushDiplom.mssql.somee.com;packet size=4096;user id=TrueO_SQLLogin_1;pwd=t2djqjx6on;data source=OlegTrushDiplom.mssql.somee.com;persist security info=False;initial catalog=OlegTrushDiplom");
                    SqlDataAdapter sda = new SqlDataAdapter("Select Address, Name, TypeId from Objects where Id='" + ae + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    addressBox.Text = dt.Rows[0][0].ToString();
                    nameBox.Text = dt.Rows[0][1].ToString();
                    string type = dt.Rows[0][2].ToString();
                    typeBox.SelectedIndex=Convert.ToInt32(type)-1;
                    button4.Text = "Изменить";
                    label1.Text = "Изменение объекта";
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (ae == null)
                {
                    model.Name = nameBox.Text;
                    model.Address = addressBox.Text;
                    model.TypeId = (int)typeBox.SelectedValue;
                    using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                    {
                        db.Objects.Add(model);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Успешно!");
                    ObjectsFrm objectsFrm = new ObjectsFrm(login);
                    this.Hide();
                    objectsFrm.Show();
                }
                else
                {
                    using (OlegTrushDiplomEntities db = new OlegTrushDiplomEntities())
                    {
                        var result = db.Objects.SingleOrDefault(b => b.Id ==ae);
                        if (result != null)
                        {
                            result.Address = addressBox.Text;
                            result.TypeId = (int)typeBox.SelectedValue;
                            result.Name = nameBox.Text;
                        }
                        db.SaveChanges();
                    }
                    MessageBox.Show("Успешно!");
                    ObjectsFrm objectsFrm = new ObjectsFrm(login);
                    this.Hide();
                    objectsFrm.Show();
                }
        }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
}

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectsFrm objectsFrm = new ObjectsFrm(login);
                this.Hide();
                objectsFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
