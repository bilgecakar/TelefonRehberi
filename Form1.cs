/************************************************************************

                    SAKARYA ÜNİVERSİTESİ
            BİLGİSAYAR VE BİLİŞİM SİSTEMLERİ FAKÜLTESİ
                NESNEYE DAYALI PROGRAMLAMA DERSİ
                          3.ÖDEV
                  
               AD: BİLGE 
               SOYAD: ÇAKAR
               NUMARA: G161210033
               GRUP: D

**************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        // Form2 ile form4' ü tanımladım.
        public Form2 frm2;
        public Form4 frm4;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            IsMdiContainer = true;
           
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
           
            frm2 = new Form2();//Form2 ile bağlantı oluşturma.
            frm2.frm1_2 = this;
            frm2.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm4 = new Form4();//Form4 ile bağlantı oluşturma.
            frm4.frm1_4 = this;
            frm4.Show();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Button  rengi değiştirme.
            button1.BackColor = Color.BurlyWood;

            button2.BackColor = Color.BurlyWood;

        }
    }
}
