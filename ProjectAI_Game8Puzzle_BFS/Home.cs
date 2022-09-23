using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAI_Game8Puzzle_BFS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();            
            form1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button_WOC1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Do you want to exit the program?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button == button2 && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }
    }
}
