using AutoMapper;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using FluentValidation;
using Profio.Application.Abstractions.CQRS.Events.Commands;
using Profio.Application.Abstractions.CQRS.Handlers.Command;
using Profio.Domain.Constants;
using Profio.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace Profio.Application.Staffs.Commands;

[SwaggerSchema(
  Title = "Staff Request",
  Description = "A Representation of Staff")]
public sealed record CreateStaffCommand : CreateCommandBase
{
  public required string Name { get; set; }
  public required string Phone { get; set; }
  public Position Position { get; set; } = Position.Driver;
}

public sealed class CreateStaffCommandHandler : CreateCommandHandlerBase<CreateStaffCommand, Staff>
{
  public CreateStaffCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
  {
  }
}

public sealed class CreateStaffCommandValidator : AbstractValidator<CreateStaffCommand>
{
  public CreateStaffCommandValidator()
  {
    RuleFor(s => s.Name)
      .MaximumLength(50);

    RuleFor(s => s.Phone)
      .Length(10)
      .Matches("^[0-9]*$");

    RuleFor(s => s.Position)
      .IsInEnum();
  }
}
