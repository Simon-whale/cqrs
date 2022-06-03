using EmploymeeManagementLibrary.Command;
using EmploymeeManagementLibrary.Data;
using EmploymeeManagementLibrary.Models;
using MediatR;

namespace EmploymeeManagementLibrary.Handlers;

public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, EmployeeModel>
{
    private readonly IDataAccess _dataAccess;

    public AddEmployeeHandler(IDataAccess dataAccess) => _dataAccess = dataAccess;

    public Task<EmployeeModel> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_dataAccess.AddEmployee(request.FirstName, request.LastName));
    }
}   