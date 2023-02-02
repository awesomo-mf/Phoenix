using Phoenix.Models.Metadata.Shared.Interfaces;
using System;

namespace Phoenix.Models.Metadata.Shared
{
    public class IdWithAliasEntity : IHaveAlias, IHaveIdentifier
    {
        public Guid Id { get; set; }
        public string Alias { get; set; }
    }
}
