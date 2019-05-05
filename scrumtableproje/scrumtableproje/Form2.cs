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

namespace scrumtableproje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglantı = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\barut\Documents\Database1.accdb");
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * form Tablo1 where KullaniciAdi='" + textBox1.Text + "' and Parola='" + textBox2 + "'" + baglantı);
            OleDbDataReader datar = komut.ExecuteReader();
            if (datar.Read())
            {
                this.Hide();
                Form form1 = new Form();
                form1.Show();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
