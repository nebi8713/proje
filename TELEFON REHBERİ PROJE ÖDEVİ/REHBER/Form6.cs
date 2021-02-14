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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        OleDbConnection bağ = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=REHBER.accdb");
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cvp = MessageBox.Show("Kişiyi güncellemek istediğinize eminmisiniz", "UYARI", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    bağ.Open();
                    OleDbCommand kmt = new OleDbCommand("update rehber set telefon_no='" + textBox13.Text + "',ad='" + textBox11.Text + "',soyad='" + textBox10.Text + "',semt='" + comboBox3.Text + "',yaş='" + textBox9.Text + "',türü='" + comboBox4.Text + "' where kayıtno = " + textBox12.Text, bağ);
                    kmt.ExecuteNonQuery();
                    bağ.Close();
                    button2.PerformClick();
                }
                else
                {
                    bağ.Close();
                    MessageBox.Show("Kişi Güncellenmedi", "UYARI", MessageBoxButtons.OK);
                }
            }
            catch (Exception x)
            {

                bağ.Close();
                MessageBox.Show("Hata:" + x.Message);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber",bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox12.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox9.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox8.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            MessageBox.Show("Tüm kutular temizlenmiştir", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("update rehber set telefon_no='" + textBox13.Text + "',ad='" + textBox11.Text + "',soyad='" + textBox10.Text + "',semt='" + comboBox3.Text + "',yaş='" + textBox9.Text + "',türü='" + comboBox4.Text + "' where kayıtno = " + textBox12.Text, bağ);
            kmt.ExecuteNonQuery();
            bağ.Close();
            button2.PerformClick();
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
