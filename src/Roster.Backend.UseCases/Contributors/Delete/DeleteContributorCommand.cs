using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Roster.Backend.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
