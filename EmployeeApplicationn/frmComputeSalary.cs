using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplicationn
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(fname1.Text, LnameBox1.Text, DprtmntBox2.Text, JtitleBox3.Text);


            double hour = Convert.ToDouble(RPHBox4.Text);
            int thl = Convert.ToInt32(TLHBox5.Text);

            partTimeEmployee.computeSalary(thl , hour);
            fnhlabel.Text = fname1.Text;
            LNHlabel.Text = LnameBox1.Text;
            inputLABEL.Text = Convert.ToString(partTimeEmployee.getSalary());
        }
    }
}
