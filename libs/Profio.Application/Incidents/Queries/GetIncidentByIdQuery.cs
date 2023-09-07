using AutoMapper;
using EntityFrameworkCore.UnitOfWork.Interfaces;
using Profio.Application.CQRS.Events.Queries;
using Profio.Application.CQRS.Handlers.Queries;
using Profio.Application.CQRS.Validators;
using Profio.Domain.Entities;

namespace Profio.Application.Incidents.Queries;

public record GetIncidentByIdQuery(object Id) : GetByIdQueryBase<IncidentDto>(Id);

public class GetIncidentByIdQueryHandler : GetByIdQueryHandlerBase<GetIncidentByIdQuery, IncidentDto, Incident>
{
  public GetIncidentByIdQueryHandler(IRepositoryFactory unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
  {
  }
}

public class GetIncidentByIdQueryValidator : GetByIdQueryValidatorBase<GetIncidentByIdQuery, IncidentDto>
{
}
