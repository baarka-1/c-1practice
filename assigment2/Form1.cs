using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace assigment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                txtname.Clear();
                txtstudent.Clear();
                txtdeperment.Clear();
                txtsemester.Clear();
                lbloutput.Text = "";


            
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            
               
         //creating variable to store input data
          string studentname, department, allinformation;
            int studentid, semester;

            studentname = txtname.Text;
              studentid = int.Parse(txtstudent.Text);
            department = txtdeperment.Text;
            semester = int.Parse(txtsemester.Text);
            //processing data
            allinformation = studentname + " " + studentid + " " + department + " " + semester;
            //Display out put
            lbloutput.Text = allinformation;
        }
        
            
     
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //this close
            this.Close();
        }

        private void txtstudent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
