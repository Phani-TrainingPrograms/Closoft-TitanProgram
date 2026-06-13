using BaseClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleUIApp
{
    public partial class DisplayAll : Form
    {
        public DisplayAll()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstEmpNames.SelectedItem  is Employee)
            {
                var selectedRec = lstEmpNames.SelectedItem as Employee;//Safe csting
                txtId.Text = selectedRec.EmpId.ToString();
                txtName.Text = selectedRec.EmpName;
                txtAddress.Text = selectedRec.EmpAddress;
                txtMobile.Text = selectedRec.EmpContactNo.ToString();
                txtDeptId.Text = selectedRec.DeptId.ToString();
            }
        }

        private void DisplayAll_Load(object sender, EventArgs e)
        {
            var component = new EmployeeDB();
            var data = component.GetAllEmployees();
            lstEmpNames.DataSource = data;//Bind the data with UR control. 
            lstEmpNames.DisplayMember = "EmpName";
            lstEmpNames.ValueMember = "EmpId";
        }
    }
}
