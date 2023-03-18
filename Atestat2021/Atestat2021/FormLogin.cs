using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat2021
{
    public partial class FormLogin : Form
    {
        public static bool OK = false;
        public FormLogin()
        {
            InitializeComponent();
            label3.Text = "";
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.EchipeFavorite' table. You can move, or remove it, as needed.
            this.echipeFavoriteTableAdapter.Fill(this.bazedateUseriDataSet.EchipeFavorite);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.EchipeFavorite' table. You can move, or remove it, as needed.
            this.echipeFavoriteTableAdapter.Fill(this.bazedateUseriDataSet.EchipeFavorite);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.Statistici' table. You can move, or remove it, as needed.
            this.statisticiTableAdapter.Fill(this.bazedateUseriDataSet.Statistici);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.Useri' table. You can move, or remove it, as needed.
            this.useriTableAdapter.Fill(this.bazedateUseriDataSet.Useri);
            bazedateUseriDataSet.EnforceConstraints = false;

        }
        public bool VerificareDateCorecte()
        {
            string username = textBox1.Text;
            string parola = textBox2.Text;
            useriTableAdapter.Afisare_Username(bazedateUseriDataSet.Useri, username);
            DataTable t = bazedateUseriDataSet.Useri;
            if (t.Rows.Count==1 && username== t.Rows[0]["username"].ToString())
            {
                string parola2 = t.Rows[0]["parola"].ToString();
                if (parola != parola2)
                {
                    label3.Text = "Parola introdusa nu este corecta";
                    return false;
                }
            }
            else
            {
                label3.Text = "Username-ul introdus nu exista";
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
             if (OK == false)
             {
                 if (VerificareDateCorecte() == true)
                 {
                     label3.Text = "";
                     OK = true;
                     Form1.userActiv = textBox1.Text;
                     this.Close();
                 }
             } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text == "Afisati Parola")
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Ascundeti Parola";
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Afisati Parola";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
