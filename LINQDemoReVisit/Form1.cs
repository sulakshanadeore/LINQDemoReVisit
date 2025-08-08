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
        new Employee{ Empid=3,EmpName="Sumit",Deptno=23,Salary=10000},
        new Employee{ Empid=4,EmpName="Rajesh",Deptno=10,Salary=18888},
        new Employee{ Empid=5,EmpName="Ramesh",Deptno=10,Salary=277777},
        new Employee{ Empid=6,EmpName="Suresh",Deptno=30,Salary=34444
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
    }
}
