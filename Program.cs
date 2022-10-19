namespace Labb8.Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee s1 = new Employee() {Id = 1, Name = "Gandalf", gender = "M", Salary = 50000 };
            Employee s2 = new Employee() {Id = 2, Name = "Aragon", gender = "M", Salary = 40000 };
            Employee s3 = new Employee() {Id = 3, Name = "Gimli", gender = "M", Salary = 30000 };
            Employee s4 = new Employee() {Id = 4, Name = "Legolas", gender = "M", Salary = 20000 };

            List<Employee> ListStack = new List<Employee>();
            ListStack.Add(s1);
            ListStack.Add(s2);
            ListStack.Add(s3);
            ListStack.Add(s4);

            /*Stack<Employee> EmpStack = new Stack<Employee>();
            EmpStack.Push(s1);
            EmpStack.Push(s2);
            EmpStack.Push(s3);
            EmpStack.Push(s4);


            foreach (Employee T in EmpStack)
            {

                Console.WriteLine($" {T.Name} {T.Id} {T.gender} {T.Salary}\n");

            }

            Console.WriteLine($"Id: {s1.Id}\nName:{s1.Name}\nGender:{s1.gender}\nSalary{s1.Salary}");
            Console.WriteLine($"Items remaining in stack:  {EmpStack.Count()}");
            EmpStack.Pop();
            Console.WriteLine("Removed one item from stack: Pop\n");
            Console.WriteLine($"Id: {s2.Id}\nName: {s2.Name}\nGender: {s2.gender}\nSalary {s2.Salary}\n");
            Console.WriteLine($"Items remaining in stack:  {EmpStack.Count()}");
            EmpStack.Pop();
            Console.WriteLine("Removed one item from stack: Pop\n");
            Console.WriteLine($"Id: {s3.Id}\nName: {s3.Name}\nGender: {s3.gender}\nSalary {s3.Salary}\n");
            Console.WriteLine($"Items remaining in stack:  {EmpStack.Count()}");
            EmpStack.Pop();
            Console.WriteLine("Removed one item from stack: Pop\n");
            Console.WriteLine($"Id: {s4.Id}\nName: {s4.Name}\nGender: {s4.gender}\nSalary {s4.Salary}\n");
            Console.WriteLine($"Items remaining in stack:  {EmpStack.Count()}");
            EmpStack.Pop();
            Console.WriteLine($"Items remaining in stack:  {EmpStack.Count()}");

            EmpStack.Push(s1);
            EmpStack.Push(s2);
            EmpStack.Push(s3);
            EmpStack.Push(s4);

            Employee Ep1 = EmpStack.Peek();
            Console.WriteLine($"ID:{Ep1.Id}\nName: {Ep1.Name}\nGender: {Ep1.gender}\nSalary: {Ep1.Salary}");
            EmpStack.Pop();
            Console.WriteLine(EmpStack.Count());
            Employee Ep2 = EmpStack.Peek();
            Console.WriteLine($"ID: {Ep2.Id}\nName: {Ep2.Name}\nGender:{Ep2.gender}\nSalary: {Ep2.Salary}");
            EmpStack.Pop();
            Console.WriteLine(EmpStack.Count());

            if (EmpStack.Contains(s3))
            {
                Console.WriteLine("Exist in stack");
            }
            else
            {
                Console.WriteLine("Has ben popped");
            }*/

        }
    }
}