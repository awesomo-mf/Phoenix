using System;

namespace Phoenix.Models.Metadata.Shared.Interfaces
{
    public interface IHaveIdentifier
    {
        Guid Id { get; set; }
    }
}
