using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Roster.Backend.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
