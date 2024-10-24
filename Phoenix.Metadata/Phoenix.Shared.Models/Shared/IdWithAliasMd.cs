﻿using Phoenix.Models.Metadata.Shared.Interfaces;
using System;

namespace Phoenix.Models.Metadata.Shared
{
    public abstract class IdWithAliasMd : AliasMd, IHaveIdentifier
    {
        public Guid Id { get; set; }
    }
}
