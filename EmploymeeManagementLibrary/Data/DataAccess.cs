using EmploymeeManagementLibrary.Models;

namespace EmploymeeManagementLibrary.Data;

public class DataAccess : IDataAccess
{
    private List<EmployeeModel> _employee = new ();

    public DataAccess()
    {
        _employee.Add(new EmployeeModel() { Id = 1, FirstName = "Simon", LastName = "Whale" });
        _employee.Add(new EmployeeModel() { Id = 2, FirstName = "Emma", LastName = "Vernon" });
    }

    public List<EmployeeModel> GetEmployees() => _employee;

    public EmployeeModel AddEmployee(string firstName, string lastName)
    {
        EmployeeModel newEmployee = new() {FirstName = firstName, LastName = lastName};
        newEmployee.Id = _employee.Max(p => p.Id) + 1;
        
        _employee.Add(newEmployee);
        return newEmployee;
    }
}