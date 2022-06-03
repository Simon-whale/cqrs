using EmploymeeManagementLibrary.Models;
using MediatR;

namespace EmploymeeManagementLibrary.Queries;

public record GetEmployeeListQuery() : IRequest<List<EmployeeModel>>;
