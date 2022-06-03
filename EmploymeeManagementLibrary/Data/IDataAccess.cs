using EmploymeeManagementLibrary.Models;

namespace EmploymeeManagementLibrary.Data;

public interface IDataAccess
{
    List<EmployeeModel> GetEmployees();
    EmployeeModel AddEmployee(string firstName, string lastName);
}