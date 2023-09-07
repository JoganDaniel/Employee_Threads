using MultiThreading;
using Payroll_Service_ADO_database;

internal class Program
{
    private static void Main(string[] args)
    {
        

        //EmployeeOperation operations = new EmployeeOperation();
        //List<Employee> list = new List<Employee>();
        //Operation operation = new Operation();
        //operation.UsingWithoutThread(list);
        //operation.UsingWithThread(list);

        TaskParllelLibrary task = new TaskParllelLibrary();
        task.TaskParllelOperation();

    }
}