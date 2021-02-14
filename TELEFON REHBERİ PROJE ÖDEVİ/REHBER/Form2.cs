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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection bağ = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=REHBER.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber",bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;







        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp =  MessageBox.Show("Silmek istediğinize eminmisiniz", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (cvp == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
            {
                bağ.Open();
            OleDbCommand kmt = new OleDbCommand("delete * from REHBER where kayıtno="+textBox1.Text,bağ);
            
            kmt.ExecuteNonQuery();
           
            bağ.Close();
            button1.PerformClick();
            }
            
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Silmek istediğinize eminmisiniz", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (cvp == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
            {
                bağ.Open();
                OleDbCommand kmt = new OleDbCommand("delete * from REHBER where ad='" + textBox3.Text + "'", bağ);
                kmt.ExecuteNonQuery();
                bağ.Close();
                button1.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("insert into rehber(ad,soyad,telefon_no,semt,yaş,türü)values('"+textBox2.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+comboBox1.Text+"','"+textBox7.Text+"','"+comboBox2.Text+"')",bağ);
            kmt.ExecuteNonQuery();
            bağ.Close();
            button1.PerformClick();
        }

        private void lİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Silmek istediğinize eminmisiniz", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (cvp == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
            {
                bağ.Open();
                OleDbCommand kmt = new OleDbCommand("delete * from REHBER where Telefon_no='" + textBox6.Text + "'", bağ);
                kmt.ExecuteNonQuery();
                bağ.Close();
                button1.PerformClick();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where ad like'%" + textBox8.Text + "%'", bağ);
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cvp = MessageBox.Show("Kişiyi güncellemek istediğinize eminmisiniz", "UYARI", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    bağ.Open();
            OleDbCommand kmt = new OleDbCommand("update rehber set telefon_no='" + textBox13.Text+"',ad='" + textBox11.Text + "',soyad='" + textBox10.Text + "',semt='" + comboBox3.Text + "',yaş='" + textBox9.Text+ "',türü='" + comboBox4.Text + "' where kayıtno = " + textBox12.Text, bağ);
            kmt.ExecuteNonQuery();
            bağ.Close();
            button1.PerformClick();
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox12.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox4.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            MessageBox.Show("Tüm kutular temizlenmiştir"," ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where telefon_no like'%" + textBox14.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adb = new OleDbDataAdapter("select * from rehber where kayıtno like'%" + textBox15.Text + "%'", bağ);
            DataTable tablo = new DataTable();
            adb.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void kAYITNOYAGORESİLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iŞLEMLERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lİSTELEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
            
        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();

 
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("update rehber set telefon_no='" + textBox13.Text + "',ad='" + textBox11.Text + "',soyad='" + textBox10.Text + "',semt='" + comboBox3.Text + "',yaş='" + textBox9.Text + "',türü='" + comboBox4.Text + "' where kayıtno = " + textBox12.Text, bağ);
            kmt.ExecuteNonQuery();
            bağ.Close();
            button1.PerformClick();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bağ.Open();
            OleDbCommand kmt = new OleDbCommand("insert into rehber(ad,soyad,telefon_no,semt,yaş,türü)values('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + comboBox2.Text + "')", bağ);
            kmt.ExecuteNonQuery();
            bağ.Close();
            button1.PerformClick();
        }

        private void iŞLEMLERToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
            
        }

        private void kULLANICIKONTROLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
            
        }

        private void aRAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();
            f8.Show();
        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
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
                    button1.PerformClick();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}