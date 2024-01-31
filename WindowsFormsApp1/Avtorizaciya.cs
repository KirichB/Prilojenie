using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Avtorizaciya : Form
    {
        public Avtorizaciya()
        {
            InitializeComponent();
            this.AcceptButton = ButtinVhod;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Avtorizaciya_Load(object sender, EventArgs e)
        {
           
           
        }

        private void ButtinVhod_Click(object sender, EventArgs e)
        {
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;user id=user41_db;password=user41;MultipleActiveResultSets=True;App=EntityFramework";
            string command = "Select * from [!28RegPol] where Login='" + comboBox1.Text + "' and Password='" + textBox1.Text + "'";
            SqlConnection myConnection = new SqlConnection(connect);
            SqlCommand myCommand = new SqlCommand(command, myConnection);
            myConnection.Open();
            SqlDataReader rd = myCommand.ExecuteReader();
            string Login = "null";
            string Password = "null";
            while (rd.Read())
            {
                Login = rd.GetString(1);
                Password = rd.GetString(2);
            }
            myConnection.Close();
            if (Password == "null")
            {
                MessageBox.Show("Неправильный пароль");
            }
            else if (Login == "Администратор")
            {
                Admin form = new Admin();
                form.Show();
                Hide();
                MessageBox.Show("Вы вошли как администратор");
            }
            else if (Login == "Пользователь")
            {
                Polzovatel form = new Polzovatel();
                form.Show();
                Hide();
                MessageBox.Show("Вы вошли как пользователь");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            Glavnaya form = new Glavnaya();
            form.Show();
            Hide();
        }
    }
}
