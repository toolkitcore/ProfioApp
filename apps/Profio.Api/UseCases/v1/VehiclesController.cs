using EntityFrameworkCore.Repository.Collections;
using Microsoft.AspNetCore.Mvc;
using Profio.Application.Deliveries;
using Profio.Application.Hubs;
using Profio.Application.Hubs.Queries;
using Profio.Application.Vehicles;
using Profio.Application.Vehicles.Commands;
using Profio.Application.Vehicles.Queries;
using Profio.Domain.Entities;
using Profio.Domain.Models;
using Profio.Domain.Specifications;
using Profio.Domain.ValueObjects;
using Swashbuckle.AspNetCore.Annotations;
namespace Profio.Api.UseCases.v1;

[ApiVersion("1.0")]
[SwaggerTag("Manage vehicles")]
public class VehiclesController : BaseEntityController<Vehicle, VehicleDto, GetVehicleByIdQuery>
{
  [HttpGet]
  [SwaggerOperation(summary: "Get Vehicle List with Paging")]
  public Task<ActionResult<ResultModel<IPagedList<VehicleDto>>>> Get([FromQuery] Criteria criteria, [FromQuery] VehicleEnumFilter vehicleEnumFilter)
    => HandlePaginationQuery(new GetVehicleWithPagingQuery(criteria, vehicleEnumFilter));

  [HttpGet("{id:length(26)}")]
  [SwaggerOperation(summary: "Get Vehicle by Id")]
  public Task<ActionResult<ResultModel<VehicleDto>>> GetById(string id)
    => HandleGetByIdQuery(new(id));

  [HttpPost]
  [SwaggerOperation(summary: "Create Vehicle")]
  public Task<ActionResult<ResultModel<VehicleDto>>> Post(CreateVehicleCommand command)
    => HandleCreateCommand(command);

  [HttpPut("{id:length(26)}")]
  [SwaggerOperation(summary: "Update Vehicle")]
  public Task<IActionResult> Put([FromRoute] string id, [FromBody] UpdateVehicleCommand command)
    => HandleUpdateCommand(id, command);

  [HttpDelete("{id:length(26)}")]
  [SwaggerOperation(summary: "Delete Vehicle")]
  public Task<ActionResult<ResultModel<VehicleDto>>> Delete(string id)
    => HandleDeleteCommand(new DeleteVehicleCommand(id));
  [HttpGet("{id:length(26)}/deliveries")]
  [SwaggerOperation(summary: "Get Delivery List by Vehicle Id")]
  public async Task<ActionResult<ResultModel<IPagedList<DeliveryDto>>>> GetDeliveries(string id, [FromQuery] Criteria criteria)
    => Ok(await Mediator.Send(new GetDeliveryByVehicleIdWithPagingQuery(id, criteria)));

  [HttpGet("{id:length(26)}/hubs/next")]
  [SwaggerOperation(summary: "Get next Hub by Vehicle Id")]
  public async Task<ActionResult<ResultModel<HubDto>>> GetNextHub(string id)
    => ResultModel<HubDto>.Create(await Mediator.Send(new GetNextHubByVehicleIdQuery(id)));
  [HttpGet("{id:length(26)}/destination-address")]
  [SwaggerOperation(summary: "Get Destination Address by Vehicle Id")]
  public async Task<ActionResult<ResultModel<Address>>> GetDestinationAddress(string id)
    => ResultModel<Address>.Create(await Mediator.Send(new GetDestinationAddressByVehicleIdQuery(id)));

  [HttpGet("count-by-type")]
  [SwaggerOperation(summary: "Get Vehicle count by Type")]
  public async Task<ActionResult<ResultModel<IEnumerable<int>>>> GetCountByType()
    => Ok(ResultModel<IEnumerable<int>>.Create(await Mediator.Send(new GetVehicleCountByTypeQuery())));
  [HttpPost("{id:length(26)}/hubs/{hubId:length(26)}/visit")]
  [SwaggerOperation(summary: "Vist the hub")]
  public async Task<IActionResult> VisitHub([FromRoute] string id, [FromRoute] string hubId)
  {
    await Mediator.Send(new VisitHubCommand(id, hubId));
    return NoContent();
  }
}
