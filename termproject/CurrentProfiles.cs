using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termproject
{
    public partial class CurrentProfiles : Form
    {

        Profile p = null;

        public CurrentProfiles()
        {
            InitializeComponent();
        }

        private void CurrentProfiles_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = Program.profiles;
            panel4.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            p = comboBox2.SelectedItem as Profile;
            if (p.Type == "Soccer player")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            textBox1.Text = p.Name;
            if (p.Gender == "Male")
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }
            comboBox1.SelectedItem = p.Age.ToString();
            pictureBox1.Image = p.Avatar;
            panel4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Type = radioButton1.Checked ? "Soccer player" : "Goalie";
            p.Name = textBox1.Text;
            p.Gender = radioButton3.Checked ? "Male" : "Female";
            p.Age = int.Parse(comboBox1.Text);
            p.Avatar = pictureBox1.Image;

            this.Dispose();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                pictureBox1.Image = rb.Image;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                if (rb.Text == "Soccer Player")
                {
                    radioButton5.Image = pictureBox5.Image;
                    radioButton6.Image = pictureBox6.Image;
                    radioButton7.Image = pictureBox7.Image;
                }
                else
                {
                    radioButton5.Image = pictureBox2.Image;
                    radioButton6.Image = pictureBox3.Image;
                    radioButton7.Image = pictureBox4.Image;
                }
            }
        }
    }
}
