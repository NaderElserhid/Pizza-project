using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_project
{
    public partial class placeOreder : Form
    {
        public placeOreder()
        {
            InitializeComponent();
        }
        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm order", "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Confirmed", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnOrderPizza.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;

        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSmall.Checked)
            {
                lpSize.Text = "Small";
            } 
        }

        private void rdMeduim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMeduim.Checked)
            {
                lpSize.Text = "Meduim";
            }
        }

        private void rdLarg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLarg.Checked)
            {
                lpSize.Text = "Large";
            }
        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThin.Checked)
            {
                lpCoust.Text = "Thin";
            }
        }

        private void rdthik_CheckedChanged(object sender, EventArgs e)
        {
            if(rdthik.Checked)
            {
                lpCoust.Text = "Thik";
            }   
        }

        private void rdeatIn_CheckedChanged(object sender, EventArgs e)
        {
            if(rdeatIn.Checked)
            {
                lporderStatus.Text = "Eat in";
            }
        }

        private void rdTakeout_CheckedChanged(object sender, EventArgs e)
        {
            if(rdTakeout.Checked)
            {
                lporderStatus.Text = "Take out";
            }   
        }

        private void ckExtriaChaees_CheckedChanged(object sender, EventArgs e)
        {
            if(ckExtriaChaees.Checked)
            {
               listView1.Items.Add(ckExtriaChaees.Text);
            }
        }

        private void ckMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMushrooms.Checked)
            {
                listView1.Items.Add(ckMushrooms.Text);
            }
        }

        private void ckTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTomatoes.Checked)
            {
                listView1.Items.Add(ckTomatoes.Text);
            }
        }

        private void ckOnion_CheckedChanged(object sender, EventArgs e)
        {
            if(ckOnion.Checked)
            {
                listView1.Items.Add(ckOnion.Text);
            }
        }

        private void ckOlives_CheckedChanged(object sender, EventArgs e)
        {
            if(ckOnion.Checked)
            {
                listView1.Items.Add(ckOlives.Text);
            }
        }

        private void ckGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGreenPeppers.Checked)
            {
                listView1.Items.Add(ckGreenPeppers.Text);
            }
        }
    }
}
