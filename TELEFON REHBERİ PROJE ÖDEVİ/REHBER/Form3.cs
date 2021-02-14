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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection bağ = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=KULLANICILAR.accdb");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("select * from kullanıcılar where kullanıcı='" + textBox1.Text + "'and şifre='" + textBox2.Text + "'", bağ);
            OleDbDataReader okunan = kmt.ExecuteReader();


            if (okunan.Read())
            {
                MessageBox.Show("KAYITLI KULLANICI ADI VE ŞİFRESİ YAZLIMIŞ");
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VE ŞİFRE KAYITLI DEGİL");
            }

            okunan.Close();
            bağ.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("delete * from kullanıcılar where kullanıcı='" + textBox1.Text+"'and şifre='"+textBox2.Text+"'", bağ);

            kmt.ExecuteNonQuery();

            bağ.Close();
            MessageBox.Show("BAŞARIYLA SİLİNMİŞTİR");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("insert into kullanıcılar(kullanıcı,şifre)values('" + textBox1.Text + "','" + textBox2.Text + "')", bağ);
            kmt.ExecuteNonQuery();
            bağ.Close();
            MessageBox.Show("YENİ KULLANICI EKLENDİ");
        }
    }
}
