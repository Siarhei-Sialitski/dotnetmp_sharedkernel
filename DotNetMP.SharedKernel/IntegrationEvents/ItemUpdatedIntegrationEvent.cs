namespace DotNetMP.SharedKernel.IntegrationEvents;

public record ItemUpdatedIntegrationEvent(Guid Id, string Name, decimal Price, string? Description, string? Image);
