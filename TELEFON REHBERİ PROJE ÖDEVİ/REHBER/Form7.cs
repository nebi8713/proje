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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        OleDbConnection bağ = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=REHBER.accdb");
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Silmek istediğinize eminmisiniz ?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            button3.PerformClick();
            if (cvp == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
            {
                bağ.Open();
                OleDbCommand kmt = new OleDbCommand("delete * from REHBER where kayıtno=" + textBox1.Text, bağ);
                kmt.ExecuteNonQuery();
                bağ.Close();
                button3.PerformClick();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Silmek istediğinize eminmisiniz ?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            button3.PerformClick();
            if (cvp == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
            {
                bağ.Open();
                OleDbCommand kmt = new OleDbCommand("delete * from REHBER where Telefon_no='" + textBox3.Text + "'", bağ);
                kmt.ExecuteNonQuery();
                bağ.Close();
                button3.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Silmek istediğinize eminmisiniz ?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            button3.PerformClick();
            if (cvp == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
            {
                bağ.Open();
                OleDbCommand kmt = new OleDbCommand("delete * from REHBER where ad='" + textBox6.Text + "'", bağ);
                kmt.ExecuteNonQuery();
                bağ.Close();
                button3.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Silmek istediğinize eminmisiniz ?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            button3.PerformClick();
            if (cvp == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
            {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("delete * from REHBER where soyad='" + textBox2.Text + "'", bağ);
            kmt.ExecuteNonQuery();
            bağ.Close();
            button3.PerformClick();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox8.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            MessageBox.Show("Tüm kutular temizlenmiştir", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where soyad like'%" + textBox5.Text + "%'", bağ);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where yaş like'%" + textBox4.Text + "%'", bağ);
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
