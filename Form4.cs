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
    public partial class Form4 : Form
    {
         public Form1 frm1_4;
        public Form4()
        {
            InitializeComponent();
            yazdır(okun());//Yazdırma fonksiyonu içine okun fonksiyonunu atadım.Böylece istedğimiz özelliğe göre yazdıracak.
        }

        private List<kisi> okun()//Dosya okuma fonksiyonu.
        {
            List<kisi> oku_kisi = new List<kisi>();
            StreamReader oku = File.OpenText("Veriler.txt");//Dosya okuma için txt dosyasını açacak.

            String line;
            while ((line = oku.ReadLine()) != null)//Ad, soyad, numara tek tek okuyacak.
            {
                String[] okunan = line.Split(' ');
                oku_kisi.Add(new kisi { ad = okunan[0], Soyad = okunan[1], No = okunan[2], renk = okunan[3] });
            }

            oku.Close();//Dosyayı kapat.
            return oku_kisi;

        }


        private void yazdır(List<kisi> okunanlist)//Dosyayı richtextboxa yazdırma fonksiyonu.
        {
            for (int i = 0; i < okunanlist.Count; i++)//Birinci satır kalın ikinci satır kalın olarak devam edecek.
            {
                if (i % 2 == 0)
                {
                    richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, 12, FontStyle.Regular);//Satırı ince yapacak.
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, 12, FontStyle.Bold);//Satırı kalın yapacak.
                }

                Color yazırenk = new Color();
                char[] renk = okunanlist[i].renk.ToCharArray();

                for (int j = 0; j < renk.Length; j++)
                {
                    if (renk[j] == 'k')//Combobox value değeri k ise kırmızı renkte yazdıracak.
                    {
                        yazırenk = Color.Red;
                    }

                    else if (renk[j] == 'm')//Combobox value değeri m ise mavi renkte yazdıracak.
                    {
                        yazırenk = Color.Blue;
                    }

                    if (renk[j] == 'y')//Combobox value değeri y ise yeşil renkte yazdıracak.
                    {
                        yazırenk = Color.Green;
                    }

                    richTextBox1.SelectionColor = yazırenk;
                    if (j == 0)
                    {
                        richTextBox1.AppendText(okunanlist[i].ad + " ");//Adı yazdıracak.
                    }

                    else if (j == 1)
                    {
                        richTextBox1.AppendText(okunanlist[i].Soyad + " ");//Soyadı yazdıracak.
                    }

                    else
                    {
                        richTextBox1.AppendText(okunanlist[i].No + "\r\n ");//Numara yazdıracak.
                    }

                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }
    }
}
