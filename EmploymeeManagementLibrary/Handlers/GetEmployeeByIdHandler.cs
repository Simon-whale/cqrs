using EmploymeeManagementLibrary.Models;
using EmploymeeManagementLibrary.Queries;
using MediatR;

namespace EmploymeeManagementLibrary.Handlers;

public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeModel>
{
    private readonly IMediator _mediator;

    public GetEmployeeByIdHandler(IMediator mediator) => _mediator = mediator;
    
    public async Task<EmployeeModel> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
    {
        var employees = await _mediator.Send(new GetEmployeeListQuery());
        var searchEmployee = employees.FirstOrDefault(p => p.Id == request.Id);
        return searchEmployee;
    }
}
