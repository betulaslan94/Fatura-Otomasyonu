using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Samsung\\Documents\\Visual Studio 2012\\Projects\\WindowsFormsApplication13\\WindowsFormsApplication13\\bin\\Debug\\ilk_veritabani.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }
        void baglan()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        void listele()
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("select * from Faturalar", baglanti);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilk_veritabaniDataSet.Faturalar' table. You can move, or remove it, as needed.
            this.faturalarTableAdapter.Fill(this.ilk_veritabaniDataSet.Faturalar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                baglan();
                OleDbCommand komut = new OleDbCommand("INSERT Into Faturalar ([FaturaID],[FaturaNo],[FaturaTarihi],[KurDegeri],[FaturaKalemAdeti], [MalzemeID], [FirmaID]) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                listele();
                MessageBox.Show("Kaydınız Gerçekleşmiştir!");
                baglanti.Close();
            }
            else {
                MessageBox.Show("Boş Alan Bırakmayın!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                baglan();
                OleDbCommand komut = new OleDbCommand("delete from Faturalar where FaturaID = " + textBox9.Text + "", baglanti);
                komut.ExecuteNonQuery();
                listele();
                baglanti.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM Faturalar WHERE FaturaID= " + textBox8.Text + "", baglanti);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
