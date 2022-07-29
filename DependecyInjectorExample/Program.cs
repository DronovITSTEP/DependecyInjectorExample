using DependecyInjectorExample;

/*EmployeeBL employeeBl = new EmployeeBL(new EmployeeDAL());
List<Employee> listEmployees = employeeBl.GetAllEmployees();
*/
/*
EmployeeBL employeeBL = new EmployeeBL();
employeeBL.employeeDataObject = new EmployeeDAL();
*/
EmplyeeBL emplyeeBL = new EmplyeeBL();

List<Employee> listEmployees = emplyeeBL.GetAllEmployees(new EmployeeDAL());
foreach (Employee emp in listEmployees)
{
    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}",
        emp.ID, emp.Name, emp.Department);
}

/*
Unity
Castle Windsor
StructureMap
Spring.NET
 */
