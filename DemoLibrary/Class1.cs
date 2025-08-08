namespace DemoLibrary
{
    public class Employee
    {
        public int Empid { get; set; }

        public string    EmpName { get; set; }

        public int Deptno { get; set; }
        public double Salary { get; set; }
    }


    public class Department
    {

        public int Deptno { get; set; }

        public string Dname { get; set; }

        public List<Employee> EmpDept { get; set; }

    }
}
