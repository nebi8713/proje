using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace REHBER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection bağ = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=KULLANICILAR.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbCommand kmt = new OleDbCommand("select * from KULLANICILAR where kullanıcı='" + textBox1.Text + "'and şifre='" + textBox2.Text + "'", bağ);
            bağ.Open();
            OleDbDataReader okuuyucu = kmt.ExecuteReader();
            if (okuuyucu.Read())
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            else
            {
                bağ.Close();
                MessageBox.Show(" KULLANICI ADI YADA ŞİFRE YANLIŞ\n\n KAYIT OLMADIYSANIZ LUTFEN KAYIT OLUN");
            }
        }
		
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bağ.Open();
                OleDbCommand kmt = new OleDbCommand("insert into kullanıcılar(kullanıcı,şifre)values('" + textBox1.Text + "','" + textBox2.Text + "')", bağ);
                kmt.ExecuteNonQuery();
                MessageBox.Show("KAYDINIZ OLUŞTU");


            }
            catch (Exception x)
            {
               
                MessageBox.Show("LUTFEN KULLANICI ADI VE ŞİFRENİZİ GİRİNİZ");
            }
            
             bağ.Close();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
