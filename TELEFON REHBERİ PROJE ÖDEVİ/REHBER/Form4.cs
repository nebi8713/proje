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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection bağ = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=REHBER.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("select distinct telefon_no from  rehber", bağ);
            OleDbDataReader okunan = kmt.ExecuteReader();
            while (okunan.Read())
            {
                listBox1.Items.Add(okunan["telefon_no"]);
            }
            okunan.Close();
            bağ.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("select distinct ad from  rehber", bağ);
            OleDbDataReader okunan = kmt.ExecuteReader();
            while (okunan.Read())
            {
                listBox2.Items.Add(okunan["ad"]);
            }
            okunan.Close();
            bağ.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("select distinct soyad from  rehber", bağ);
            OleDbDataReader okunan = kmt.ExecuteReader();
            while (okunan.Read())
            {
                listBox3.Items.Add(okunan["soyad"]);
            }
            okunan.Close();
            bağ.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("select distinct semt from  rehber", bağ);
            OleDbDataReader okunan = kmt.ExecuteReader();
            while (okunan.Read())
            {
                listBox5.Items.Add(okunan["semt"]);
            }
            okunan.Close();
            bağ.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox5.Items.Clear();
            textBox1.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox3.Text = "";
            textBox8.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            MessageBox.Show("Tüm kutular temizlenmiştir", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where semt like'%" + comboBox2.Text + "%'", bağ);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where türü like'%" + comboBox1.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
