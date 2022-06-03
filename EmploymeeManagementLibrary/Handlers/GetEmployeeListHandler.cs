using EmploymeeManagementLibrary.Data;
using EmploymeeManagementLibrary.Models;
using EmploymeeManagementLibrary.Queries;
using MediatR;

namespace EmploymeeManagementLibrary.Handlers;

public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<EmployeeModel>>
{
    private readonly IDataAccess _dataAccess;

    public GetEmployeeListHandler(IDataAccess dataAccess) => _dataAccess = dataAccess;
    
    public Task<List<EmployeeModel>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_dataAccess.GetEmployees());
    }
}