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
    public partial class Registraciya : Form
    {
        public Registraciya()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {

            string connect = "data source=stud-mssql.sttec.yar.ru,38325;user id=user41_db;password=user41;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection myConnection = new SqlConnection(@connect);
            myConnection.Open();
            string sInsSql = "Insert into [!28RegPol](Login,Password) Values ('{0}','{1}')";

            string Login = this.Login.Text;
            string Password = this.Password.Text;
           
            string sInsSotr = string.Format(sInsSql, Login, Password);
            SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);
            cmdIns.ExecuteNonQuery();
            MessageBox.Show(string.Format("[Новый пользователь] {0} успешно добавлен", Login), "Сообщение");
            myConnection.Close();


        }

        private void labelUjezaReg_Click(object sender, EventArgs e)
        {

            Avtorizaciya form = new Avtorizaciya();
            form.Show();
            Hide();
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            Glavnaya form = new Glavnaya();
            form.Show();
            Hide();
        }

        private void Login_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Registraciya_Load(object sender, EventArgs e)
        {

        }
    }
}
