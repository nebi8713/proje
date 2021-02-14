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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbConnection bağ = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=REHBER.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("insert into rehber(ad,soyad,telefon_no,semt,yaş,türü)values('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + comboBox2.Text + "')", bağ);
            kmt.ExecuteNonQuery();
            bağ.Close();
            button2.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox8.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            MessageBox.Show("Tüm kutular temizlenmiştir", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult cvp = MessageBox.Show("Kişiyi eklemek istediğinize eminmisiniz", "UYARI", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                     bağ.Open();
            OleDbCommand kmt = new OleDbCommand("insert into rehber(ad,soyad,telefon_no,semt,yaş,türü)values('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + comboBox2.Text + "')", bağ);
            kmt.ExecuteNonQuery();
            bağ.Close();
            button2.PerformClick();
                }
                else
                {
                    bağ.Close();
                    MessageBox.Show("Kişi Eklenemedi", "UYARI", MessageBoxButtons.OK);
                }
            }
            catch (Exception x)
            {
                bağ.Close();
                MessageBox.Show("Hata:" + x.Message);
            }

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where kayıtno like'%" + textBox15.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where telefon_no like'%" + textBox14.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where ad like'%" + textBox8.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where soyad like'%" + textBox1.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where semt like'%" + comboBox3.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where yaş like'%" + textBox3.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where türü like'%" + comboBox4.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
