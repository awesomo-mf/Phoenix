using Phoenix.Models.Metadata.Shared.Interfaces;
using System;

namespace Phoenix.Models.Metadata.Shared
{
    public abstract class AliasMd : IHaveAlias
    {
        public string Alias { get; set; }
    }
}
