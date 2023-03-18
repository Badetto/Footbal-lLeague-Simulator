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
    public partial class FormAutentificare : Form
    {
        public FormAutentificare()
        {
            InitializeComponent();
            label3.Text = "";
            label5.Text = "";
            label6.Left= (this.ClientSize.Width - label6.Width) / 2;
        }
        private void FormAutentificare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.EchipeFavorite' table. You can move, or remove it, as needed.
            this.echipeFavoriteTableAdapter.Fill(this.bazedateUseriDataSet.EchipeFavorite);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.EchipeFavorite' table. You can move, or remove it, as needed.
            this.echipeFavoriteTableAdapter.Fill(this.bazedateUseriDataSet.EchipeFavorite);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.Statistici' table. You can move, or remove it, as needed.
            this.statisticiTableAdapter.Fill(this.bazedateUseriDataSet.Statistici);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.Useri' table. You can move, or remove it, as needed.
            this.useriTableAdapter.Fill(this.bazedateUseriDataSet.Useri);

        }
        public bool verificareDateCorecte()
        {
            string username = textBox1.Text;
            string parola = textBox2.Text;
            string parola2 = textBox3.Text;
            if (username.Length <= 3)
            {
                label3.Text = "Username-ul trebuie sa contina minim 4 caractere";
                return false;
            }
            else if (username.Length>20)
            {
                label3.Text = "Username-ul trebuie sa contina maxim 20 de caractere";
                return false;
            }
            else if (parola.Length <= 3)
            {
                label3.Text = "Parola trebuie sa contina minim 4 caractere";
                return false;
            }
            else
            {
                bool OK = true;
                for (int i = 0; i < username.Length; i++)
                    if ((username[i] < 'a' || username[i] > 'z') && (username[i] < '0' || username[i] > '9') &&
                        username[i]!='_')
                        OK = false;
                if (OK == false)
                {
                    label5.Text = "Username-ul poate sa contina doar litere mici ale alfabetului";
                    label3.Text = "englezesc, cifre si caracterul '_'";
                    return false;
                }
                if (parola2 != parola)
                {
                    label3.Text = "Parolele nu sunt identice";
                    return false;
                }
                useriTableAdapter.Afisare_Username(bazedateUseriDataSet.Useri, username);
                DataTable t = bazedateUseriDataSet.Useri;
                if (t.Rows.Count != 0)
                {
                        label3.Text = "Username-ul exista deja";
                        return false;
                }
            }
            label3.Text = "";
            return true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (verificareDateCorecte() == true)
            {
                label3.Text = "";
                useriTableAdapter.Adaugare_User(textBox1.Text, textBox2.Text);
                echipeFavoriteTableAdapter.Insert(null, null, null, textBox1.Text);
                statisticiTableAdapter.Insert(0, 0, textBox1.Text);
                useriTableAdapter.Update(bazedateUseriDataSet);
                this.Close();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text == "Afisati Parolele")
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
                checkBox1.Text = "Ascundeti Parolele";
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
                checkBox1.Text = "Afisati Parolele";
            }
        }

    }
}
