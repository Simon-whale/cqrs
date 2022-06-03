using EmploymeeManagementLibrary.Models;
using MediatR;

namespace EmploymeeManagementLibrary.Queries;

public record GetEmployeeByIdQuery(int Id): IRequest<EmployeeModel>;