using MediatR;
using Profio.Domain.Models;

namespace Profio.Application.Abstractions.CQRS.Events.Queries;

public record GetByIdQueryBase<T>(object Id) : IRequest<T>
  where T : BaseModel;
