using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonZaregist_Click(object sender, EventArgs e)
        {
            Registraciya form = new Registraciya();
            form.Show();
            Hide();
        }

        private void Glavnaya_Load(object sender, EventArgs e)
        {

        }

        private void buttonVhod_Click(object sender, EventArgs e)
        {
            Avtorizaciya form = new Avtorizaciya();
            form.Show();
            Hide();
        }

        private void buttonVihod_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
