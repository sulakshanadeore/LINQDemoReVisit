using DemoLibrary;

namespace LINQDemoReVisit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Employee> emplist = new List<Employee>() {
        new Employee{ Empid=1,EmpName="Aditi",Deptno=10,Salary=17777},
        new Employee{ Empid=2,EmpName="Amit",Deptno=20,Salary=23323223},
        new Employee{ Empid=3,EmpName="Sumit",Deptno=22,Salary=10000},
        new Employee{ Empid=4,EmpName="Rajesh",Deptno=10,Salary=18888},
        new Employee{ Empid=5,EmpName="Ramesh",Deptno=10,Salary=277777},
        new Employee{ Empid=6,EmpName="Suresh",Deptno=30,Salary=34444 },
            new Employee{ Empid=7,EmpName="Sowmya",Deptno=30,Salary=34444 },
                new Employee{ Empid=8,EmpName="Suramya",Deptno=30,Salary=34444,

        }

        };
        private void button1_Click(object sender, EventArgs e)
        {
            //They are Delegates
            //----Func Lambda---has a output/return -----16(any type) input parameters---- + 1 paramter/last parameter is output parameter--- bool,int,string etc
            //    -----Action ----- 16 input(can be anytype) paramter and no output parameters---void(Multicast)
            //    -----Predicate ----- only one input(can be of any type) paramter and one output parameter(bool)

            var findEmployee = from emp in emplist
                               orderby emp.Empid
                               where emp.Empid == 6 || emp.Empid == 2
                               select emp;
            foreach (var item in findEmployee)
            {
                MessageBox.Show(item.Empid.ToString());
                MessageBox.Show(item.EmpName);
                MessageBox.Show(item.Deptno.ToString());
                MessageBox.Show(item.Salary.ToString());
                MessageBox.Show("One record completed....");
            }

            MessageBox.Show("METHOD SYNTAX....");
            var foundEmployee = emplist.Where(emp => emp.Empid == 6 || emp.Empid == 2).OrderBy(empdata => empdata.Empid);

            foreach (var item in foundEmployee)
            {
                MessageBox.Show(item.Empid.ToString());
                MessageBox.Show(item.EmpName);
                MessageBox.Show(item.Deptno.ToString());
                MessageBox.Show(item.Salary.ToString());
                MessageBox.Show("One record completed....");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = emplist.GroupBy(emp => emp.Deptno).
                Select(emp=> new { groupedDeptno = emp.Key,
                    EmpCount=emp.Count(),
                    EmployeesInDept=emp});

            foreach (var item in result)
            {
                listBox1.Items.Add("Deptno= " + item.groupedDeptno +
                    " EmpCount= " + item.EmpCount);
                foreach (var item1 in item.EmployeesInDept)
                {
                    listBox1.Items.Add(item1.Empid);
                    listBox1.Items.Add(item1.EmpName);
                    listBox1.Items.Add(item1.Deptno);
                    listBox1.Items.Add(item1.Salary);
                    listBox1.Items.Add("-------");

                }
            }


            var result2 = emplist.GroupBy(emp => emp.Deptno).
               Select(emp => new {  emp.Key,empcount=Convert.ToInt32(emp.Count()),  emp });
            foreach (var item in result2)
            {
                listBox2.Items.Add("Deptno= " + item.Key + " EmpCount= " + item.empcount);
                foreach (var item1 in item.emp)
                {
                    listBox2.Items.Add(item1.Empid);
                    listBox2.Items.Add(item1.EmpName);
                    listBox2.Items.Add(item1.Deptno);
                    listBox2.Items.Add(item1.Salary);
                    listBox2.Items.Add("-------");

                }
            }






            var result1 = from emp in emplist
                          group emp by emp.Deptno into groupedon
                          select new {groupedDeptno= groupedon.Key, EmpCount=groupedon.Count(), 
                              EmployeesInDept=groupedon   };

            foreach (var item in result1) {
                listBox3.Items.Add("Deptno= " + item.groupedDeptno + " EmpCount= " + item.EmpCount);
                foreach (var item1 in item.EmployeesInDept)
                {
                    listBox3.Items.Add(item1.Empid);
                    listBox3.Items.Add(item1.EmpName);
                    listBox3.Items.Add(item1.Deptno);
                    listBox3.Items.Add(item1.Salary);
                    listBox3.Items.Add("-------");
                }




            }



        }
    }
}
