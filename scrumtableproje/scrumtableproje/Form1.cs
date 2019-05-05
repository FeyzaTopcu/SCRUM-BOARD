using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrumtableproje
{
    public partial class Form1 :Form
    {
        private Point p;
        int current_panel;

        Panel[] panels;

        public Form1()
        {
            InitializeComponent();
            panels = new Panel[] { panel2, panel3, panel4 };
            current_panel = 0;


        
     
        }
        TextBox txtbox ;
        public object [] kutu ;
        public int d;

        /*TextBox txtbox1;
        TextBox txtbox2;
        TextBox txtbox3;*/
        Random random = new Random();
        int sayac = 0;
        int sayac1 = 0;
        int sayac2 = 0;
        int sayac3 = 0;

       

       
        void panel_DragEnter(object sender, DragEventArgs e)
        {
         
              e.Effect  = DragDropEffects.All;

        }
        void panel_DragDrop(object sender, DragEventArgs e)
        {
            Panel pn1 = sender as Panel;
            TextBox txt = e.Data.GetData(typeof(TextBox)) as TextBox;
            txt.Location = pn1.PointToClient(new Point(e.X, e.Y));
            pn1.Controls.Add(txt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtbox = new TextBox();
            txtbox.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            txtbox.Location = new System.Drawing.Point(5,55+55*sayac++);
            txtbox.Size = new System.Drawing.Size(100, 20);
            txtbox.Width = 150;
            txtbox.Height = 50;
            txtbox.Multiline = true;
            txtbox.TabIndex = 1;
           
           panel1.Controls.Add(txtbox);
        
            
        }
        void txtbox_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
            if(e.Button == MouseButtons.Left)
                DoDragDrop(sender, DragDropEffects.All);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox txtbox1 = new TextBox();
            txtbox1.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            txtbox1.Location = new System.Drawing.Point(5, 55 + 55 * sayac1++);
            txtbox1.Size = new System.Drawing.Size(100, 20);
            txtbox1.Width = 150;
            txtbox1.Height = 50;
            txtbox1.Multiline = true;
            txtbox1.TabIndex = 1;
            panel4.Controls.Add(txtbox1);
            txtbox1.MouseDown += new System.Windows.Forms.MouseEventHandler(txtbox_MouseDown);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox txtbox2= new TextBox();
            txtbox2.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            txtbox2.Location = new System.Drawing.Point(5, 55 + 55 * sayac2++);
            txtbox2.Size = new System.Drawing.Size(100, 20);
            txtbox2.Width = 150;
            txtbox2.Height = 50;
            txtbox2.Multiline = true;
            txtbox2.TabIndex = 1;
            panel3.Controls.Add(txtbox2);
            txtbox2.MouseDown += new System.Windows.Forms.MouseEventHandler(txtbox_MouseDown);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            TextBox txtbox3 = new TextBox();
            txtbox3.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            txtbox3.Location = new System.Drawing.Point(5, 55 + 55 * sayac3++);
            txtbox3.Size = new System.Drawing.Size(100, 20);
            txtbox3.Width = 150;
            txtbox3.Height = 50;
            txtbox3.Multiline = true;
            txtbox3.TabIndex = 1;
            panel2.Controls.Add(txtbox3);
            txtbox3.MouseDown += new System.Windows.Forms.MouseEventHandler(txtbox_MouseDown);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
