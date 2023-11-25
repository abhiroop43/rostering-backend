using Roster.Backend.Web.ContributorEndpoints;

namespace Roster.Backend.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
