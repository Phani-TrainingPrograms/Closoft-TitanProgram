using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassLib
{
    public class Employee
    {
        public int? DeptId { get; set; }
        public long EmpContactNo { get; set; }
        public string EmpAddress { get; set; }
        public string EmpName { get; set; }
        public int EmpId { get; set; }
    }

    public class Dept
    {
        public string DeptName { get; set; }
        public int DeptId { get; set; }
    }
}
