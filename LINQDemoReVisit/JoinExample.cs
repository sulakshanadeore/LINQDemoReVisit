using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LINQDemoReVisit
{
    public partial class JoinExample : Form
    {
        public JoinExample()
        {
            InitializeComponent();
        }

        List<Department> deptlist = new List<Department> {
        new Department{Deptno=10,Dname="HR" },
        new Department{Deptno=20,Dname="Accounts" },
        new Department{ Deptno=30,Dname="Training"},

        };

        List<Employee> emplist = new List<Employee>() {
        new Employee{Empid=1,EmpName="Arpit",Deptno=10 },
        new Employee{Empid=2,EmpName="Arpita",Deptno=20 },
        new Employee{Empid=3,EmpName="Sumit",Deptno=30 },
        new Employee{Empid=4,EmpName="Amit",Deptno=30 },
        new Employee{Empid=5,EmpName="Mita",Deptno=10 },
       new Employee{Empid=6,EmpName="Arnima",Deptno=10 },
         };

        private void JoinExample_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = from emp in emplist
                         join dept in deptlist
                       on emp.Deptno equals dept.Deptno
                         select emp;

            foreach (var item in result)
            {

                listBox1.Items.Add(item.Deptno);
                listBox1.Items.Add(item.Empid);
                listBox1.Items.Add(item.EmpName);
                listBox1.Items.Add(item.Salary);

            }

            var upperEnameResult = from emp1 in emplist
                                   let upperName = emp1.EmpName.ToUpper()
                                   where upperName.StartsWith('A')
                                   select upperName;

            foreach (var item in upperEnameResult)
            {
                MessageBox.Show(item);

            }
            //  return true if at least one element matches a condition
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Any-- return  true if at least one element matches a condition
            
            int[] nos = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };

            bool data1 = nos.Any(n => n > 50);
            MessageBox.Show(data1.ToString());
            MessageBox.Show("Data 1 : ANY = " + data1.ToString());



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //All--return  true if every element matches a condition
            int[] nos = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };

            bool data2 = nos.All(n => n > 50);
            MessageBox.Show("Data 2 : ALL = " + data2.ToString());
        }
    }
}
