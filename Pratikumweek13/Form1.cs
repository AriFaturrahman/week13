using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratikumweek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Form Pengaturan Warna";
        }
        private void button_Click(object sender, EventArgs e)
        {
            labelubah.Text = textBoxobjek.Text;
            if(textBoxobjek.Text == "delete")
            {
                labelubah.Text = "[EMPTY]";
            }
            if(textBoxobjek.Text == "shown")
            {
                labelubah.Visible = true;
            }
            if(textBoxobjek.Text == "hide")
            {
                labelubah.Visible = false;
            }
            if(textBoxobjek.Text == "blue")
            {
                labelubah.ForeColor = Color.Blue; 
            }
            if(textBoxobjek.Text == "red")
            {
                labelubah.ForeColor = Color.Red;
            }
            if (textBoxobjek.Text == "green")
            {
                labelubah.ForeColor = Color.Green;
            }

        }

      
    }
}
