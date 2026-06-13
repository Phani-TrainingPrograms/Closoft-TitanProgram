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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //string message = $"The name entered is {txtName.Text}\nThe Address entered is {txtAddress.Text}\nThe Salary is {txtMobile.Text:C}";
            //MessageBox.Show(message);

            //take inputs from the textboxes. 
            var id = Convert.ToInt32(txtId.Text);
            var name = txtName.Text;
            var address = txtAddress.Text;
            var mobile = Convert.ToInt64(txtMobile.Text);
            var deptId = (int)cmdDept.SelectedValue;
            //create an Employee object and fill data into it.
            var emp = new Employee
            {
                EmpId = id,
                EmpAddress = address,
                EmpContactNo = mobile,
                EmpName = name,
                DeptId = deptId,
            };
            //create the interface object
            var repo = new EmployeeDB();
            //call the function to add record
            repo.AddEmployee(emp);
            //message box to the user. 
            MessageBox.Show("Employee added successfully");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var component = new DepartmentDB();
            var depts = component.GetAllDepartments();
            cmdDept.DataSource = depts;
            cmdDept.DisplayMember = "DeptName";
            cmdDept.ValueMember = "DeptId";
        }
    }
}
