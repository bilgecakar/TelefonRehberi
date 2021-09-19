using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form1 frm1_2;
        public Form2()
        {
            InitializeComponent();
            tanımlamalar();
        }
        public void  tanımlamalar() // Combobox içindeki değerleri atamak için fonksiyon oluşturdum.
        {

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            //Combobox1 içine kırmızı, mavi, yeşil diye yazı atadım.
            comboBox1.Items.Add(item: new ComboBoxItem { Text = "Kırmızı", Value = "k" });
            comboBox1.Items.Add(new ComboBoxItem { Text = "Mavi", Value = "m" });
            comboBox1.Items.Add(new ComboBoxItem { Text = "Yeşil", Value = "y" });
            comboBox1.SelectedIndex = 0;

            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
            //Combobox2 içine kırmızı, mavi, yeşil diye yazı atadım.
            comboBox2.Items.Add(new ComboBoxItem { Text = "Kırmızı", Value = "k" });
            comboBox2.Items.Add(new ComboBoxItem { Text = "Mavi", Value = "m" });
            comboBox2.Items.Add(new ComboBoxItem { Text = "Yeşil", Value = "y" });
            comboBox2.SelectedIndex = 0;

            comboBox3.DisplayMember = "Text";
            comboBox3.ValueMember = "Value";
            //Combobox3 içine kırmızı, mavi, yeşil diye yazı atadım.
            comboBox3.Items.Add(new ComboBoxItem { Text = "Kırmızı", Value = "k" });
            comboBox3.Items.Add(new ComboBoxItem { Text = "Mavi", Value = "m" });
            comboBox3.Items.Add(new ComboBoxItem { Text = "Yeşil", Value = "y" });
            comboBox3.SelectedIndex = 0;

        }
 
     
        public void Dosya_Kaydi()//Dosya kaydı fonksiyonu.
        {
            kisi yeni = new kisi();//Classı atadım.

            //Textboxlara ad, soyad ve numara atadım.
            yeni.ad = textBox1.Text;
            yeni.Soyad = textBox2.Text;
            yeni.No = textBox3.Text;
            

            List<ComboBoxItem> list = new List<ComboBoxItem>();
            list.Add((ComboBoxItem)comboBox1.SelectedItem);
            list.Add((ComboBoxItem)comboBox2.SelectedItem);
            list.Add((ComboBoxItem)comboBox3.SelectedItem);//List ile renkleri tuttum.

            yeni.renk = list[0].Value + list[1].Value + list[2].Value;



            using (var writer = File.AppendText("Veriler.txt"))//Dosya kayıt  işlemi
            {
            
                writer.WriteLine(String.Format("{0} {1} {2} {3} ", yeni.ad, yeni.Soyad, yeni.No, yeni.renk));//Dosyaya ad, soyad ve numara yazdırdım.
                
            }
        }


        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")//Textboxlar boş ise uyarı verecek.
            {
                MessageBox.Show("BOS ALAN BIRAKMAYINIZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Dosya_Kaydi();//Dosya kaydı fonksiyonunu çağırdım.
                MessageBox.Show("KAYIT BASARILI!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);//Kayıt başarılı olursa bilgi verecek.

            }
            //Kaydettikten sonra formu temizleyecek.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;


        }

        public void Form2_Load(object sender, EventArgs e)
        {  //Button rengi verir.
            button1.BackColor = Color.DarkCyan;
            button2.BackColor = Color.DarkCyan;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();//Formdan çıkacak.
        }
    }
}
