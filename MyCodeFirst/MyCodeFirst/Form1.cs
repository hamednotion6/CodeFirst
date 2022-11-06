using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool search(human h)
        {
            db db1 = new db();
            foreach (var item in db1.humans)
            {
                if (h.name==item.name && h.family==item.family)
                {
                    return true;
                }
            }
            return false;
        }
        

        public void Register(human h)
        {
            db db1 = new db();
            if (h.age >= 18 && search(h) != true) 
            {
                db1.humans.Add(new human { name=h.name, family = h.family, age = h.age });
                db1.SaveChanges();
                MessageBox.Show("Succesfully!");
            }
            else
            {
                MessageBox.Show("Sorry you are under 18.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register(new human { name = textBox1.Text, family = textBox2.Text, age = Convert.ToByte(textBox3.Text) });
        }
    }
}
