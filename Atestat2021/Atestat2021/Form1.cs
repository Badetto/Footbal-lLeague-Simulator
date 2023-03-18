using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
namespace Atestat2021
{
    
    public partial class Form1 : Form
    {
        public static string userActiv = "";
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public Form1()
        {
            InitializeComponent();
            label2.Text = label4.Text = label6.Text = label7.Text
                = label10.Text = label11.Text = label12.Text = label13.Text = label18.Text =
                label19.Text = label20.Text = label21.Text="";
            label5.Text = "Tebuie sa fi logat sa iti vezi statisticile";
            Facere_Null_SelectareEchipe();
            //*completare comboBox-uri
            campionateTableAdapter.Campionate_Diferite(bazedateEchipeDataSet.Campionate);
            DataTable t = bazedateEchipeDataSet.Campionate;
            for (int i=0;i<t.Rows.Count;i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = t.Rows[i]["nume"].ToString();
                item.Value = t.Rows[i]["id_campionat"];
                comboBox1.Items.Add(item);
                comboBox2.Items.Add(item);
                comboBox3.Items.Add(item);
                comboBox6.Items.Add(item);
                comboBox8.Items.Add(item);
                comboBox10.Items.Add(item);
            }
            button6.Visible = false;
            //centrare elemente
            dataGridView1.Left=(this.ClientSize.Width - dataGridView1.Width) / 2;
            button3.Left = (this.ClientSize.Width - button3.Width) / 2;
            comboBox1.Left = (this.ClientSize.Width - comboBox1.Width) / 2;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazedateEchipeDataSet.Echipe' table. You can move, or remove it, as needed.
            this.echipeTableAdapter.Fill(this.bazedateEchipeDataSet.Echipe);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet1.EchipeFavorite' table. You can move, or remove it, as needed.
            this.echipeFavoriteTableAdapter.Fill(this.bazedateUseriDataSet1.EchipeFavorite);
            // TODO: This line of code loads data into the 'bazedateEchipeDataSet.Echipe' table. You can move, or remove it, as needed.
            this.echipeTableAdapter.Fill(this.bazedateEchipeDataSet.Echipe);
            // TODO: This line of code loads data into the 'bazedateEchipeDataSet.Campionate' table. You can move, or remove it, as needed.
            this.campionateTableAdapter.Fill(this.bazedateEchipeDataSet.Campionate);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.EchipeFavorite' table. You can move, or remove it, as needed.
            this.echipeFavoriteTableAdapter.Fill(this.bazedateUseriDataSet.EchipeFavorite);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.Statistici' table. You can move, or remove it, as needed.
            this.statisticiTableAdapter.Fill(this.bazedateUseriDataSet.Statistici);
            // TODO: This line of code loads data into the 'bazedateUseriDataSet.Useri' table. You can move, or remove it, as needed.
            this.useriTableAdapter.Fill(this.bazedateUseriDataSet.Useri);
            bazedateEchipeDataSet.EnforceConstraints=false;
            bazedateUseriDataSet.EnforceConstraints = false;
        }
        public void Facere_Null_Combo()
        {          
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox4.Items.Clear();
            comboBox5.SelectedIndex = -1;
            comboBox5.Items.Clear();
            label4.Text = "";
        }
        public void Facere_Null_SelectareEchipe()
        {
            label14.Text = label15.Text = label16.Text = "";
            comboBox7.Items.Clear();
            comboBox9.Items.Clear();
            comboBox11.Items.Clear();
            comboBox6.SelectedIndex = comboBox8.SelectedIndex = comboBox10.SelectedIndex = -1;
            comboBox6.Visible = comboBox7.Visible = comboBox8.Visible = comboBox9.Visible = comboBox10.Visible =
                comboBox11.Visible = false;
        }
        public void Modificare_Echipe_Favorite()
        {
            echipeFavoriteTableAdapter.EchipeFavorite_User(bazedateUseriDataSet.EchipeFavorite, userActiv);
            DataTable t = bazedateUseriDataSet.EchipeFavorite;
            label19.Text = t.Rows[0]["cod_echipa1"].ToString();
            label20.Text = t.Rows[0]["cod_echipa2"].ToString();
            label21.Text = t.Rows[0]["cod_echipa3"].ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Autentificare / Logare
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FormLogin.OK == true) 
            {
                Facere_Null_Combo();
                statisticiTableAdapter.UpdateStatistici(bazedateUseriDataSet.Statistici, userActiv);
                DataTable t1 = bazedateUseriDataSet.Statistici;
                label13.Text = t1.Rows[0]["meciuri_simulate"].ToString();
                label12.Text = t1.Rows[0]["campionate_simulate"].ToString();
                label10.Text = "Campionate Simulate";
                label11.Text = "Meciuri Simulate";
                label5.Text = "Statistici";        
                button2.Visible = false;
                comboBox1.SelectedIndex = -1;
                button1.Text = "Logout";
                label17.Text = "Selecteaza pana la 3 echipe favorite";
                dataGridView1.Rows.Clear();
                label6.Text = label7.Text = label2.Text = "";
                label14.Text = "Prima echipa";
                label15.Text = "A doua echipa";
                label16.Text = "A treia echipa";
                comboBox6.Visible = comboBox7.Visible = comboBox8.Visible = comboBox9.Visible = comboBox10.Visible =
                comboBox11.Visible = true;
                label17.BackColor = Color.LightGreen;
                label5.BackColor = Color.LightGreen;
                label18.Text = "Echipe Favorite";
                button6.Visible =  true;
                Modificare_Echipe_Favorite();
            }
            timer1.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Login")
            {
                FormLogin f = new FormLogin();
                f.ShowDialog();
                timer1.Start();
            }
            else
            {
                label10.Text = label11.Text = label12.Text = label13.Text = "";
                Facere_Null_Combo();
                Facere_Null_SelectareEchipe();
                label5.Text = "Tebuie sa fi logat sa iti vezi statisticile";
                label17.Text = "Trebuie sa fi logat sa poti sa iti selectezi echipele favorite";
                label17.BackColor = Color.Violet;
                label5.BackColor = Color.Violet;
                comboBox1.SelectedIndex = -1;
                button2.Visible = true;
                userActiv = "";
                button1.Text = "Login";
                FormLogin.OK = false;
                dataGridView1.Rows.Clear();
                label6.Text = "";
                label7.Text = "";
                label2.Text = "";
                label18.Text = label19.Text = label20.Text = label21.Text = "";
                button6.Visible =  false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormAutentificare f = new FormAutentificare();
            f.ShowDialog();
        }
        //Simulare campionat
        public class statistica
        {
            public int victorii { get; set; }
            public int egaluri { get; set; }
            public int infrangeri { get; set; }
            public int golaveraj { get; set; }
            public int puncte { get; set; }
            public statistica() { }
            public statistica (int victorii,int egaluri,int infrangeri,int golaveraj,int puncte)
            {
                this.victorii = victorii;
                this.egaluri = egaluri;
                this.infrangeri = infrangeri;
                this.golaveraj = golaveraj;
                this.puncte = puncte;
            }

        }
        statistica[] clasament = new statistica[25];
        public void simulare_meci_campionat(int x,float a,float b,int c,int y,float a1,float b1,int c1)
        {
            float mediex = a / c;
            float mediey = a1 / c1;
            int probx, proby, probvarstax, probvarstay, xGoluri = 0, yGoluri = 0;
            if (mediex > mediey)
            {
                probx = 300;
                proby = (int)((probx * mediey) / mediex);
                for (int i1 = 5; i1 >= 1; i1--)
                {
                    if (proby + 1 / 5 * proby < probx)
                    {
                        proby = proby + 1 / 5 * proby;
                    }
                }

            }
            else
            {
                proby = 300;
                probx = (int)((proby * mediex) / mediey);
                for (int i1 = 5; i1 >= 1; i1--)
                {
                    if (probx + 1 / 5 * probx < proby)
                    {
                        probx = probx + 1 / 5 * probx;
                    }
                }
            }
            probvarstax = (int)((b - 26) * 10);
            probvarstay = (int)((b1 - 26) * 10);
            if (probvarstax < 0)
                probvarstax *= (-1);
            if (probvarstay < 0)
                probvarstay *= (-1);
            Random rn = new Random();
            int minx = (probx - probvarstax), maxx = (probx + probvarstax);
            int miny = (proby - probvarstay), maxy = (proby + probvarstay);
            if (minx < 0)
                minx = 1;
            if (miny < 0)
                miny = 1;
            minx = 110 * minx / 100;
            maxx = 110 * maxx / 100;
            int vreme = rn.Next(1, 5);
            if (vreme == 1)
            {
                if (mediex > mediey)
                {
                    minx = 90 * minx / 100;
                    maxx = 90 * maxx / 100;
                }
                else
                {
                    miny = miny - miny / 10;
                    maxy = maxy - maxy / 10;
                }
            }
            if (minx < 0)
                minx = 1;
            if (miny < 0)
                miny = 1;
            int minute = rn.Next(90, 93);
            for (int i1 = 1; i1 <= minute; i1++)
            {
                int auxX = rn.Next(minx, maxx);
                int auxY = rn.Next(miny, maxy);
                int probgolx = rn.Next(1, 10000);
                int probgoly = rn.Next(1, 10000);
                if (auxX >= probgolx)
                    xGoluri++;
                if (auxY >= probgoly)
                    yGoluri++;
                if (xGoluri - yGoluri >= 3)
                {
                    maxx = 80 * maxx / 100;
                    minx = 80 * minx / 100;
                    if (minx < 0)
                        minx = 1;
                }
                if (yGoluri - xGoluri >= 3)
                {
                    maxy = 80 * maxy / 100;
                    miny = 80 * miny / 100;
                    if (miny < 0)
                        miny = 1;
                }
            }
            if (xGoluri > yGoluri)
            {
                clasament[x].victorii++;
                clasament[x].golaveraj += xGoluri - yGoluri;
                clasament[y].infrangeri++;
                clasament[y].golaveraj += yGoluri - xGoluri;
                clasament[x].puncte += 3;
            }
            else if (xGoluri < yGoluri)
            {
                clasament[y].victorii++;
                clasament[y].golaveraj += yGoluri - xGoluri;
                clasament[x].infrangeri++;
                clasament[x].golaveraj += xGoluri - yGoluri;
                clasament[y].puncte += 3;
            }
            else
            {
                clasament[x].egaluri++;
                clasament[y].egaluri++;
                clasament[x].puncte += 1;
                clasament[y].puncte += 1;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (comboBox1.SelectedIndex!=-1)
            {
                if (FormLogin.OK == true)
                {
                    statisticiTableAdapter.UpdateCampionate(userActiv);
                    statisticiTableAdapter.UpdateStatistici(bazedateUseriDataSet.Statistici, userActiv);
                    DataTable t1 = bazedateUseriDataSet.Statistici;
                    label12.Text = t1.Rows[0]["campionate_simulate"].ToString();
                }
                campionateTableAdapter.Echipe_In_Campionat(bazedateEchipeDataSet.Campionate, (int)(comboBox1.SelectedItem as ComboboxItem).Value);
                DataTable t = bazedateEchipeDataSet.Campionate;
                int n = (int)t.Rows.Count - 1;
                for (int i=0;i<=n;i++)
                {
                    dataGridView1.Rows.Add();
                    clasament[i] = new statistica(0, 0, 0, 0, 0);
                }
                for (int i=0;i<n;i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        //Echipe.valoare_lot, Echipe.medie_varsta, Echipe.
                        float a = float.Parse((t.Rows[i]["valoare_lot"]).ToString());
                        float b = float.Parse((t.Rows[i]["medie_varsta"]).ToString());
                        int c = int.Parse(t.Rows[i]["numar_jucatori"].ToString());
                        float a1 = float.Parse((t.Rows[j]["valoare_lot"]).ToString());
                        float b1 = float.Parse((t.Rows[j]["medie_varsta"]).ToString());
                        int c1 = int.Parse(t.Rows[j]["numar_jucatori"].ToString());
                        simulare_meci_campionat(i,a,b,c,j,a1,b1,c1);
                        simulare_meci_campionat(j, a1,b1,c1, i, a,b,c);
                        if (comboBox1.SelectedIndex==4)
                            simulare_meci_campionat(i, a, b, c, j, a1, b1, c1);
                    }
                }
                for (int i=0;i<=n;i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[1].Value = t.Rows[i]["nume"];
                    dataGridView1.Rows[i].Cells[2].Value = clasament[i].victorii;
                    dataGridView1.Rows[i].Cells[3].Value = clasament[i].egaluri;
                    dataGridView1.Rows[i].Cells[4].Value = clasament[i].infrangeri;
                    dataGridView1.Rows[i].Cells[5].Value = clasament[i].golaveraj;
                    dataGridView1.Rows[i].Cells[6].Value = clasament[i].puncte;
                }
                dataGridView1.Sort(dataGridView1.Columns["Golaveraj"], ListSortDirection.Descending);
                dataGridView1.Sort(dataGridView1.Columns["Puncte"], ListSortDirection.Descending);              
                for (int i = 0; i <= n; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
                }
        }
        //simulare meci
        public string Salutari_Tara(int x)
        {
            if (x == 0)
                return "Good Luck!";
            if (x == 1)
                return "Viel Glück!";
            if (x == 2)
                return "Noroc!";
            if (x == 3)
                return "Щасти!";
            if (x == 4)
                return "행운을 빕니다!";
            return "-";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = -1;
            comboBox4.Items.Clear();
            label4.Text = "";
            label6.Text = "";
            pictureBox1.Image = null;
            if (comboBox2.SelectedIndex!=-1)
            {
                campionateTableAdapter.Echipe_In_Campionat(bazedateEchipeDataSet.Campionate, (int)(comboBox2.SelectedItem as ComboboxItem).Value);
                DataTable t = bazedateEchipeDataSet.Campionate;
                for (int i=0;i<t.Rows.Count;i++)
                {
                    comboBox4.Items.Add(t.Rows[i]["nume"]);
                }
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.SelectedIndex = -1;
            comboBox5.Items.Clear();
            label4.Text = "";
            label7.Text = "";
            pictureBox2.Image = null;
            if (comboBox3.SelectedIndex != -1)
            {
                campionateTableAdapter.Echipe_In_Campionat(bazedateEchipeDataSet.Campionate, (int)(comboBox3.SelectedItem as ComboboxItem).Value);
                DataTable t = bazedateEchipeDataSet.Campionate;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    comboBox5.Items.Add(t.Rows[i]["nume"]);
                }
            }
        }
        public string simulare_meci(int x, float a, float b, int c, int y, float a1, float b1, int c1)
        {
            float mediex = a / c;
            float mediey = a1 / c1;
            int probx, proby, probvarstax, probvarstay, xGoluri = 0, yGoluri = 0;
            if (mediex > mediey)
            {
                probx = 300;
                proby = (int)((probx * mediey) / mediex);
                for (int i1=5;i1>=1;i1--)
                {
                    if (proby + 1 / 5 * proby < probx)
                    {
                        proby = proby + 1 / 5 * proby;
                    }
                }
                
            }
            else
            {
                proby = 300;
                probx = (int)((proby * mediex) / mediey);
                for (int i1 = 5; i1 >= 1; i1--)
                {
                    if (probx + 1 / 5 * probx < proby)
                    {
                        probx = probx + 1 / 5 * probx;
                    }
                }               
            }
            probvarstax = (int)((b - 26) * 10);
            probvarstay = (int)((b1 - 26) * 10);
            if (probvarstax < 0)
                probvarstax *= (-1);
            if (probvarstay < 0)
                probvarstay *= (-1);
            Random rn = new Random();
            int minx = (probx - probvarstax), maxx = (probx + probvarstax);
            int miny = (proby - probvarstay), maxy = (proby + probvarstay);
            if (minx < 0)
                minx = 1;
            if (miny < 0)
                miny = 1;
            minx = 105 * minx / 100;
            maxx = 105 * maxx / 100;
            int vreme = rn.Next(1, 5);
            if (vreme==1)
            {
                if (mediex>mediey)
                {
                    minx = 80 * minx / 100;
                    maxx = 80 * maxx / 100;
                }
                else
                {
                    miny = 80 * miny / 100;
                    maxy = 80 * maxy / 100;
                }
            }
            if (minx < 0)
                minx = 1;
            if (miny < 0)
                miny = 1;
            int minute = rn.Next(90, 93);
            for (int i1 = 1; i1 <= minute; i1++)
            {
                int auxX = rn.Next(minx, maxx);
                int auxY = rn.Next(miny, maxy);
                int probgolx = rn.Next(1, 10000);
                int probgoly = rn.Next(1, 10000);
                if (auxX >= probgolx)
                    xGoluri++;
                if (auxY >= probgoly)
                    yGoluri++;
                if (xGoluri - yGoluri >= 3)
                {
                    maxx = 80 * maxx / 100;
                    minx = 80 * minx / 100;
                    if (minx < 0)
                        minx = 1;
                }
                if (yGoluri - xGoluri >= 3)
                {
                    maxy = 80 * maxy / 100;
                    miny = 80 * miny / 100;
                    if (miny < 0)
                        miny = 1;
                }
            }
            string sus = xGoluri.ToString() + "-" + yGoluri.ToString();
            return sus;    
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1 && comboBox5.SelectedIndex == -1)
                label2.Text = "Trebuie sa selectati echipele";
            if (comboBox4.SelectedIndex != -1 && comboBox5.SelectedIndex == -1)
                label2.Text = "Sa nu uitati sa selectati a doua echipa!";
            if (comboBox4.SelectedIndex == -1 && comboBox5.SelectedIndex != -1)
                label2.Text = "Sa nu uitati sa selectati prima echipa!";
            if (comboBox4.SelectedIndex != -1 && comboBox5.SelectedIndex != -1)
            {
                if (FormLogin.OK == true)
                {
                    statisticiTableAdapter.UpdateMeciuri(userActiv);
                    statisticiTableAdapter.UpdateStatistici(bazedateUseriDataSet.Statistici, userActiv);
                    DataTable t1= bazedateUseriDataSet.Statistici;
                    label13.Text = t1.Rows[0]["meciuri_simulate"].ToString();
                }
                label2.Text = "";
                echipeTableAdapter.Echipa_Selectata(bazedateEchipeDataSet.Echipe, comboBox4.SelectedItem.ToString());
                DataTable t = bazedateEchipeDataSet.Echipe;
                float a = float.Parse((t.Rows[0]["valoare_lot"]).ToString());
                float b = float.Parse((t.Rows[0]["medie_varsta"]).ToString());
                int c = int.Parse(t.Rows[0]["numar_jucatori"].ToString());
                echipeTableAdapter.Echipa_Selectata(bazedateEchipeDataSet.Echipe, comboBox5.SelectedItem.ToString());
                t = bazedateEchipeDataSet.Echipe;
                float a1 = float.Parse((t.Rows[0]["valoare_lot"]).ToString());
                float b1 = float.Parse((t.Rows[0]["medie_varsta"]).ToString());
                int c1 = int.Parse(t.Rows[0]["numar_jucatori"].ToString());
                label4.Text = simulare_meci(0, a, b, c, 0, a1, b1, c1);
                label6.Text = Salutari_Tara(comboBox2.SelectedIndex);
                label7.Text = Salutari_Tara(comboBox3.SelectedIndex);
            }
        }
        //Selectare echipe favorite
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex!=-1)
            {
                comboBox7.SelectedIndex = -1;
                comboBox7.Items.Clear();
                campionateTableAdapter.Echipe_In_Campionat(bazedateEchipeDataSet.Campionate, (int)(comboBox6.SelectedItem as ComboboxItem).Value);
                DataTable t = bazedateEchipeDataSet.Campionate;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    comboBox7.Items.Add(t.Rows[i]["nume"]);
                }
            }
           
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex != -1)
            {
                comboBox9.SelectedIndex = -1;
                comboBox9.Items.Clear();
                campionateTableAdapter.Echipe_In_Campionat(bazedateEchipeDataSet.Campionate, (int)(comboBox8.SelectedItem as ComboboxItem).Value);
                DataTable t = bazedateEchipeDataSet.Campionate;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    comboBox9.Items.Add(t.Rows[i]["nume"]);
                }
            }
        }
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex != -1)
            {
                comboBox11.SelectedIndex = -1;
                comboBox11.Items.Clear();
                campionateTableAdapter.Echipe_In_Campionat(bazedateEchipeDataSet.Campionate, (int)(comboBox10.SelectedItem as ComboboxItem).Value);
                DataTable t = bazedateEchipeDataSet.Campionate;
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    comboBox11.Items.Add(t.Rows[i]["nume"]);
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string echipa1, echipa2, echipa3;
            echipeFavoriteTableAdapter.EchipeFavorite_User(bazedateUseriDataSet.EchipeFavorite, userActiv);
            DataTable t = bazedateUseriDataSet.EchipeFavorite;
            echipa1 = t.Rows[0]["cod_echipa1"].ToString();
            echipa2 = t.Rows[0]["cod_echipa2"].ToString();
            echipa3 = t.Rows[0]["cod_echipa3"].ToString();
            bool OK1 = true, OK2 = true, OK3 = true, OK4 = true ;
            if (comboBox7.SelectedIndex != -1 && comboBox9.SelectedIndex != -1)
            {
                if (comboBox7.SelectedItem.ToString() == comboBox9.SelectedItem.ToString())
                    OK4 = false;
            }
            if (comboBox11.SelectedIndex != -1 && comboBox9.SelectedIndex != -1)
            {
                if (comboBox11.SelectedItem.ToString() == comboBox9.SelectedItem.ToString())
                    OK4 = false;
            }
            if (comboBox7.SelectedIndex != -1 && comboBox11.SelectedIndex != -1)
            {
                if (comboBox7.SelectedItem.ToString() == comboBox11.SelectedItem.ToString())
                    OK4 = false;
            }
            if (comboBox7.SelectedIndex!=-1 && OK4 == true)
            {
                if (comboBox7.SelectedItem.ToString() == echipa1 || comboBox7.SelectedItem.ToString() == echipa2
                    || comboBox7.SelectedItem.ToString() == echipa3)
                    OK1 = false;
                if (OK1 == true)
                {
                    string numeEchipa = comboBox7.SelectedItem.ToString();
                    echipeFavoriteTableAdapter.ModificareCodEchipa1(numeEchipa, userActiv);
                    Modificare_Echipe_Favorite();
                }
            }
            if (comboBox9.SelectedIndex != -1 && OK4 == true)
            {
                if (comboBox9.SelectedItem.ToString() == echipa1 || comboBox9.SelectedItem.ToString() == echipa2
                    || comboBox9.SelectedItem.ToString() == echipa3)
                    OK2 = false;
                if (OK2 == true)
                {
                    string numeEchipa = comboBox9.SelectedItem.ToString();
                    echipeFavoriteTableAdapter.ModificareCodEchipa2(numeEchipa, userActiv);
                    Modificare_Echipe_Favorite();
                }
            }
            if (comboBox11.SelectedIndex != -1 && OK4 == true)
            {
                if (comboBox11.SelectedItem.ToString() == echipa1 || comboBox11.SelectedItem.ToString() == echipa2
                    || comboBox11.SelectedItem.ToString() == echipa3)
                    OK3 = false;
                if (OK3 == true)
                {
                    string numeEchipa = comboBox11.SelectedItem.ToString();
                    echipeFavoriteTableAdapter.ModificareCodEchipa3(numeEchipa, userActiv);
                    Modificare_Echipe_Favorite();
                }
            }
            if (OK1 == false || OK2==false || OK3==false)
            {
                string echipe = "";
                int nr = 0;
                if (OK1 == false) {
                    echipe = echipe + comboBox7.SelectedItem.ToString() + " ";
                    nr++;
                }
                if (OK2 == false) {
                    echipe = echipe + comboBox9.SelectedItem.ToString() + " ";
                    nr++;
                }
                if (OK3 == false) {
                    echipe = echipe + comboBox11.SelectedItem.ToString() + " ";
                    nr++;
                }
                if (nr == 1) {
                    MessageBox.Show("Echipele favorite nu au fost actualizate doarece echipa " + echipe +
                         "iti este deja selectata ca fiind o echipa favorita!");
                }
                else
                {
                    MessageBox.Show("Echipele favorite nu au fost actualizate doarece echipele " + echipe +
                         " iti sunt deja selectate ca fiind echipe favorite!");
                }
            }
            if (OK4 == false)
            {
                MessageBox.Show("Nu puteti selecta aceeasi echipa de mai multe ori!");
            }
            comboBox7.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.Items.Clear();
            comboBox9.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.Items.Clear();
            comboBox11.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.Items.Clear();
        }
        //Embleme la Simulare Meci
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            if (comboBox4.SelectedIndex!=-1)
            {
                echipeTableAdapter.Echipa_Selectata(bazedateEchipeDataSet.Echipe, comboBox4.SelectedItem.ToString());
                DataTable t = bazedateEchipeDataSet.Echipe;
                string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                Bitmap imagine = new Bitmap(path + "\\Imagini\\" + t.Rows[0]["emblema2"].ToString());
                pictureBox1.Image = imagine;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            if (comboBox5.SelectedIndex != -1)
            {
                echipeTableAdapter.Echipa_Selectata(bazedateEchipeDataSet.Echipe, comboBox5.SelectedItem.ToString());
                DataTable t = bazedateEchipeDataSet.Echipe;
                string path = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
                Bitmap imagine = new Bitmap(path + "\\Imagini\\" + t.Rows[0]["emblema2"].ToString());
                pictureBox2.Image = imagine;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
