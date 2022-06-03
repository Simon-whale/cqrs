using EmploymeeManagementLibrary.Command;
using EmploymeeManagementLibrary.Models;
using EmploymeeManagementLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_MediatR.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class EmployeesController : Controller
{
    private readonly IMediator _mediator;

    public EmployeesController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<List<EmployeeModel>> Get() => await _mediator.Send(new GetEmployeeListQuery());

    [HttpPost]
    public async Task<EmployeeModel> Post([FromBody] EmployeeModel employeeModel) => await _mediator.Send((new AddEmployeeCommand(employeeModel.FirstName, employeeModel.LastName)));
    
    [HttpGet("{Id}")]
    public async Task<EmployeeModel> Get(int Id) => await _mediator.Send(new GetEmployeeByIdQuery(Id));
}