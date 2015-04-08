using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortalama_Hesap
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        
        public double toplam;
        public int derssay, kredi;
        public void TabDegistir(int Index)
        {
            tabControl1.SelectedIndex = Index;
            if(Index==1)
            tabControl1.SelectedTab = tabPage1;
            else if (Index == 2)
                tabControl1.SelectedTab = tabPage2;
            else if (Index == 3)
                tabControl1.SelectedTab = tabPage3;
            else if (Index == 4)
                tabControl1.SelectedTab = tabPage4;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (progressBar1.Value == 50 && harfler.SelectedIndex != 0)
            //{
            //    progressBar1.Value = 100;
            //}
            //else
            //{
            //    if (harfler.SelectedItem == "Seçiniz")
            //    {
            //        progressBar1.Value = 50;
            //    }
            //        if(ders.SelectedItem == "Seçiniz")
            //    {
            //        progressBar1.Value = 0;
            //    }
            //}
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string nes = ders.SelectedItem.ToString() + " " + harfler.SelectedItem.ToString();
            secim.Items.Add(nes);
            string meral = secim.Items[0].ToString();
            if (meral.EndsWith("Seçiniz") || meral.StartsWith("Seçiniz"))
            {
                secim.Items.Remove(secim.Items[0].ToString());
                if (ders.SelectedItem.ToString() == "Seçiniz")
                {
                    MessageBox.Show("Lütfen bir ders seçiniz.", "Ders Seçilmedi");
                }
                if (harfler.SelectedItem.ToString() == "Seçiniz")
                {
                    MessageBox.Show("Lütfen harf notunuzu seçiniz.", "Harf Notu Girilmedi");
                    if (ders.SelectedItem == "Analiz I" || ders.SelectedItem == "Analiz II")
                    {
                        derssay -= 1;
                        kredi -= 4;
                        if (derssay <= 0)
                            derssay = 0;
                        if (kredi <= 0)
                            kredi = 0;
                    }
                    else if (ders.SelectedItem == "A.İ.İ.T. I" || ders.SelectedItem == "A.İ.İ.T II")
                    {
                        derssay -= 1;
                        kredi -= 2;
                        if (derssay <= 0)
                            derssay = 0;
                        if (kredi <= 0)
                            kredi = 0;
                    }
                    else
                    {
                        derssay -= 1;
                        kredi -= 3;
                        if (derssay <= 0)
                            derssay = 0;
                        if (kredi <= 0)
                            kredi = 0;
                    }
                }
            }
            else
            {
                if (ders.SelectedItem == "Analiz I" || ders.SelectedItem == "Analiz II")
                {
                    derssay += 1;
                    kredi += 4;
                    label2.Text = derssay.ToString();
                    label6.Text = kredi.ToString();
                    if (harfler.SelectedItem == "AA")
                    {
                        toplam += 16;

                    }
                    else if (harfler.SelectedItem == "BA")
                    {
                        toplam += 14;

                    }
                    else if (harfler.SelectedItem == "BB")
                    {
                        toplam += 12;

                    }
                    else if (harfler.SelectedItem == "CB")
                    {
                        toplam += 10;

                    }
                    else if (harfler.SelectedItem == "CC")
                    {
                        toplam += 8;

                    }
                    else if (harfler.SelectedItem == "DC")
                    {
                        toplam += 6;

                    }
                    else if (harfler.SelectedItem == "DD")
                    {
                        toplam += 4;

                    }
                    else
                    {
                        toplam += 0;

                    }
                }
                else if (ders.SelectedItem == "A.İ.İ.T. I" || ders.SelectedItem == "A.İ.İ.T. II")
                {
                    derssay += 1;
                    kredi += 2;
                    label2.Text = derssay.ToString();
                    label6.Text = kredi.ToString();
                    if (harfler.SelectedItem == "AA")
                    {
                        toplam += 8;

                    }
                    else if (harfler.SelectedItem == "BA")
                    {
                        toplam += 7;

                    }
                    else if (harfler.SelectedItem == "BB")
                    {
                        toplam += 6;

                    }
                    else if (harfler.SelectedItem == "CB")
                    {
                        toplam += 5;

                    }
                    else if (harfler.SelectedItem == "CC")
                    {
                        toplam += 4;

                    }
                    else if (harfler.SelectedItem == "DC")
                    {
                        toplam += 3;

                    }
                    else if (harfler.SelectedItem == "DD")
                    {
                        toplam += 2;

                    }
                    else
                    {
                        toplam += 0;

                    }
                }
                else
                {
                    derssay += 1;
                    kredi += 3;
                    label2.Text = derssay.ToString();
                    label6.Text = kredi.ToString();
                    if (harfler.SelectedItem == "AA")
                    {
                        if (ders.SelectedItem.ToString() == "Seçiniz")
                            toplam += 0;
                        else
                            toplam += 12;

                    }
                    else if (harfler.SelectedItem == "BA")
                    {
                        if (ders.SelectedItem.ToString() == "Seçiniz")
                            toplam += 0;
                        else
                            toplam += 10.5;

                    }
                    else if (harfler.SelectedItem == "BB")
                    {
                        if (ders.SelectedItem.ToString() == "Seçiniz")
                            toplam += 0;
                        else
                            toplam += 9;

                    }
                    else if (harfler.SelectedItem == "CB")
                    {
                        if (ders.SelectedItem.ToString() == "Seçiniz")
                            toplam += 0;
                        else
                            toplam += 7.5;

                    }
                    else if (harfler.SelectedItem == "CC")
                    {
                        if (ders.SelectedItem.ToString() == "Seçiniz")
                            toplam += 0;
                        else
                            toplam += 6;

                    }
                    else if (harfler.SelectedItem == "DC")
                    {
                        if (ders.SelectedItem.ToString() == "Seçiniz")
                            toplam += 0;
                        else
                            toplam += 4.5;

                    }
                    else if (harfler.SelectedItem == "DD")
                    {
                        if (ders.SelectedItem.ToString() == "Seçiniz")
                            toplam += 0;
                        else
                            toplam += 3;

                    }
                    else
                    {
                        toplam += 0;

                    }
                }
                double ort = toplam / kredi;
                label4.Text = ort.ToString();
                if (ort <= 1.8)
                {
                    label9.Text = "Akademik Uyarı!";
                    label4.ForeColor = System.Drawing.Color.Red;
                }
                else
                    label4.ForeColor = System.Drawing.Color.Green;
            }
        }
        private void cikar_Click(object sender, EventArgs e)
        {
            int g = secim.Items.Count;
            if (g == 0 || secim.SelectedItem == null)
            {
                MessageBox.Show("Seçili Öge Yok", "Hata");
            }
            else
            {
                if (secim.SelectedItem.ToString() == "Analiz I AA" || secim.SelectedItem.ToString() == "Analiz II AA")
                {
                    toplam -= 16;
                    kredi -= 4;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "Analiz I BA" || secim.SelectedItem.ToString() == "Analiz II BA")
                {
                    toplam -= 14;
                    kredi -= 4;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "Analiz I BB" || secim.SelectedItem.ToString() == "Analiz II BB")
                {
                    toplam -= 12;
                    kredi -= 4;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "Analiz I CB" || secim.SelectedItem.ToString() == "Analiz II CB")
                {
                    toplam -= 10;
                    kredi -= 4;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "Analiz I CC" || secim.SelectedItem.ToString() == "Analiz II CC")
                {
                    toplam -= 8;
                    kredi -= 4;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "Analiz I DC" || secim.SelectedItem.ToString() == "Analiz II DC")
                {
                    toplam -= 6;
                    kredi -= 4;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "Analiz I DD" || secim.SelectedItem.ToString() == "Analiz II DD")
                {
                    toplam -= 4;                    
                    kredi -= 4;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "Analiz I FF" || secim.SelectedItem.ToString() == "Analiz II FF")
                {
                    toplam -= 0;
                    kredi -= 4;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "A.İ.İ.T. I AA" || secim.SelectedItem.ToString() == "A.İ.İ.T. II AA")
                {
                    toplam -= 8;
                    kredi -= 2;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "A.İ.İ.T. I BA" || secim.SelectedItem.ToString() == "A.İ.İ.T. II BA")
                {
                    toplam -= 7;
                    kredi -= 2;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "A.İ.İ.T. I BB" || secim.SelectedItem.ToString() == "A.İ.İ.T. II BB")
                {
                    toplam -= 6;
                    kredi -= 2;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "A.İ.İ.T. I CB" || secim.SelectedItem.ToString() == "A.İ.İ.T. II CB")
                {
                    toplam -= 5;
                    kredi -= 2;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "A.İ.İ.T. I CC" || secim.SelectedItem.ToString() == "A.İ.İ.T. II CC")
                {
                    toplam -= 4;
                    kredi -= 2;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "A.İ.İ.T. I DC" || secim.SelectedItem.ToString() == "A.İ.İ.T. II DC")
                {
                    toplam -= 3;
                    kredi -= 2;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "A.İ.İ.T. I DD" || secim.SelectedItem.ToString() == "A.İ.İ.T. II DD")
                {
                    toplam -= 2;
                    kredi -= 2;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else if (secim.SelectedItem.ToString() == "A.İ.İ.T. I FF" || secim.SelectedItem.ToString() == "A.İ.İ.T. II FF")
                {
                    toplam -= 0;
                    kredi -= 2;
                    label6.Text = kredi.ToString();
                    derssay -= 1;
                    label2.Text = derssay.ToString();
                    ort = toplam / kredi;
                    label4.Text = ort.ToString();
                    secim.Items.Remove(secim.SelectedItem);
                }
                else
                {
                    string ata = secim.SelectedItem.ToString();
                    if (ata.EndsWith("AA"))
                    {
                        toplam -= 12;
                        kredi -= 3;
                        label6.Text = kredi.ToString();
                        derssay -= 1;
                        label2.Text = derssay.ToString();
                        ort = toplam / kredi;
                        label4.Text = ort.ToString();
                        secim.Items.Remove(secim.SelectedItem);
                    }
                    else if (ata.EndsWith("BA"))
                    {
                        toplam -= 10.5;                        
                        kredi -= 3;
                        label6.Text = kredi.ToString();
                        derssay -= 1;
                        label2.Text = derssay.ToString();
                        ort = toplam / kredi;
                        label4.Text = ort.ToString();
                        secim.Items.Remove(secim.SelectedItem);
                    }
                    else if (ata.EndsWith("BB"))
                    {
                        toplam -= 9;
                        kredi -= 3;
                        label6.Text = kredi.ToString();
                        derssay -= 1;
                        label2.Text = derssay.ToString();
                        ort = toplam / kredi;
                        label4.Text = ort.ToString();
                        secim.Items.Remove(secim.SelectedItem);
                    }
                    else if (ata.EndsWith("CB"))
                    {
                        toplam -= 7.5;
                        kredi -= 3;
                        label6.Text = kredi.ToString();
                        derssay -= 1;
                        label2.Text = derssay.ToString();
                        ort = toplam / kredi;
                        label4.Text = ort.ToString();
                        secim.Items.Remove(secim.SelectedItem);
                    }
                    else if (ata.EndsWith("CC"))
                    {
                        toplam -= 6;
                        kredi -= 3;
                        label6.Text = kredi.ToString();
                        derssay -= 1;
                        label2.Text = derssay.ToString();
                        ort = toplam / kredi;
                        label4.Text = ort.ToString();
                        secim.Items.Remove(secim.SelectedItem);
                    }
                    else if (ata.EndsWith("DC"))
                    {
                        toplam -= 4.5;
                        kredi -= 3;
                        label6.Text = kredi.ToString();
                        derssay -= 1;
                        label2.Text = derssay.ToString();
                        ort = toplam / kredi;
                        label4.Text = ort.ToString();
                        secim.Items.Remove(secim.SelectedItem);
                    }
                    else if (ata.EndsWith("DD"))
                    {
                        toplam -= 3;
                        kredi -= 3;
                        label6.Text = kredi.ToString();
                        derssay -= 1;
                        label2.Text = derssay.ToString();
                        ort = toplam / kredi;
                        label4.Text = ort.ToString();
                        secim.Items.Remove(secim.SelectedItem);
                    }
                    else
                    {
                        toplam -= 0;
                        kredi -= 3;
                        label6.Text = kredi.ToString();
                        derssay -= 1;
                        label2.Text = derssay.ToString();
                        ort = toplam / kredi;
                        label4.Text = ort.ToString();
                        secim.Items.Remove(secim.SelectedItem);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            label4.Text = Convert.ToString(0);
            label6.Text = Convert.ToString(0);
            label9.Text = Convert.ToString(" ");
            ders.SelectedIndex = 0;
            harfler.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void ders_KeyUp(object sender, KeyEventArgs e)
        {
            ders.SelectedItem = "Seçiniz";
            MessageBox.Show("Lütfen tıklayarak seçiniz.", "Hata!");
        }

        private void harfler_KeyUp(object sender, KeyEventArgs e)
        {
            harfler.SelectedItem = "Seçiniz";
            MessageBox.Show("Lütfen tıklayarak seçiniz.", "Hata!");
        }

        private void ders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.ogu.edu.tr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void cikar_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.bulentsaka.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://193.140.141.9:7777/pls/osmangaziuniversitesibilgisistemi/asp.home");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://fef.ogu.edu.tr/matbil/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.ogu.edu.tr");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://batuhanaktas.blogspot.com");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/bohemsoft");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        public double htop = 0, ort=0;
        public int ktop = 0;

        public double hkod(int a, double b)
        {
            return a * b;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem=="Seçiniz")
            {
                    MessageBox.Show("Lütfen harf notunuzu seçiniz.", "Harf Notu Girilmedi");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen bir ders giriniz.", "Ders Girilmedi");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen kredi katsayısını giriniz.", "Kredi Girilmedi");
            }
            else
            {
                string ders, harfn;
                byte kredi2;
                ders = textBox1.Text;
                listBox2.Items.Add(comboBox1.SelectedItem.ToString());
                harfn = Convert.ToString(comboBox1.SelectedItem);
                kredi2 = Convert.ToByte(textBox2.Text);
                listBox1.Items.Add(ders + " " + kredi2.ToString());
                label15.Text = listBox1.Items.Count.ToString();
                if (harfn == "AA")
                {
                    htop += hkod(kredi2, 4);
                    ktop += kredi2;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (harfn == "BA")
                {
                    htop += hkod(kredi2, 3.5);
                    ktop += kredi2;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (harfn == "BB")
                {
                    htop += hkod(kredi2, 3);
                    ktop += kredi2;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (harfn == "CB")
                {
                    htop += hkod(kredi2, 2.5);
                    ktop += kredi2;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (harfn == "CC")
                {
                    htop += hkod(kredi2, 2);
                    ktop += kredi2;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (harfn == "DC")
                {
                    htop += hkod(kredi2, 1.5);
                    ktop += kredi2;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (harfn == "DD")
                {
                    htop += kredi2;
                    ktop += kredi2;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (harfn == "FF")
                {
                    ktop += kredi2;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seçili Öge Yok", "Hata");
            }
            else
            {
                string cikar = listBox2.SelectedItem.ToString();
                int kre = Convert.ToInt32(listBox1.SelectedItem.ToString().Substring(listBox1.SelectedItem.ToString().Length -1));
                if (cikar=="AA")
                {
                    htop -= hkod(kre, 4);
                    ktop -= kre;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (cikar.EndsWith("BA"))
                {
                    htop -= hkod(kre, 3.5);
                    ktop -= kre;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (cikar.EndsWith("BB"))
                {
                    htop -= hkod(kre, 3);
                    ktop -= kre;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (cikar.EndsWith("CB"))
                {
                    htop -= hkod(kre, 2.5);
                    ktop -= kre;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (cikar.EndsWith("CC"))
                {
                    htop -= hkod(kre, 2);
                    ktop -= kre;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (cikar.EndsWith("DC"))
                {
                    htop -= hkod(kre, 1.5);
                    ktop -= kre;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                else if (cikar.EndsWith("DD"))
                {
                    htop -= kre;
                    ktop -= kre;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();                    
                }
                else if (cikar.EndsWith("FF"))
                {
                    ktop -= kre;
                    ort = htop / ktop;
                    label8.Text = ktop.ToString();
                    label13.Text = ort.ToString();
                }
                int a = listBox1.SelectedIndex;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.Items[a]);
                label15.Text = listBox1.Items.Count.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab =tabPage3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

            
        }
        }
    }
