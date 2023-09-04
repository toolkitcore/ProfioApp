namespace Profio.Application.Hateoas.Hypermedia;

public interface ILinkService
{
  Link CreateLink(string endPointName, object? routeValues, string? rel, string? method);
}
