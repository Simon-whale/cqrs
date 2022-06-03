using EmploymeeManagementLibrary.Models;
using MediatR;

namespace EmploymeeManagementLibrary.Command;

public record AddEmployeeCommand(string FirstName, string LastName) : IRequest<EmployeeModel>;