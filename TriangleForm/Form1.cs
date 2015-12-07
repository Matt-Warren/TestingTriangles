using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangle;

namespace TriangleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoStuff_Click(object sender, EventArgs e)
        {
            if (cbRightAngle.Checked)
            {
                //right angle triangle
                if(txtSideA.Text!="" && txtSideB.Text != "")
                {
                    Triangle.Triangle tri = new Triangle.Triangle(Convert.ToDouble(txtSideA.Text), Convert.ToDouble(txtSideB.Text));
                    txtResults.Text = "Side C = " + Convert.ToString(tri.GetSideC()) +
                                      "\r\nArea = " + Convert.ToString(tri.CalculateArea());
                }
                else
                {
                    MessageBox.Show("Need sides to get area and other side.");
                }
            }
            else
            {
                //not right angle triangle, can only do angle things
                //therefore find angles
                if (txtAngleA.Text != "" && txtAngleB.Text != "")
                {
                    Triangle.Triangle tri = new Triangle.Triangle(Convert.ToDouble(txtAngleA.Text), Convert.ToDouble(txtAngleB.Text), 0);
                    txtResults.Text = "Missing angle = " + Convert.ToString(tri.GetMissingAngle('c'));
                }
                else
                {
                    MessageBox.Show("Need angles to get the missing angle.");
                }
            }
        }

        private void cbRightAngle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRightAngle.Checked)
            {
                btnDoStuff.Text = "Side C and Area";
                txtAngleA.Enabled = false;
                txtAngleB.Enabled = false;
                txtSideA.Enabled = true;
                txtSideB.Enabled = true;
            }
            else
            {
                btnDoStuff.Text = "Find Missing Angle";
                txtAngleA.Enabled = true;
                txtAngleB.Enabled = true;
                txtSideA.Enabled = false;
                txtSideB.Enabled = false;
            }
        }
    }
}
