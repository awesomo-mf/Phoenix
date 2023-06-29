using Phoenix.Models.Metadata.FlowContext.Fields;
using Phoenix.Models.Metadata.FlowContext.Fields.Interfaces;
using Phoenix.Models.Metadata.Shared;
using System.Collections.Generic;

namespace Phoenix.Models.Metadata.FlowState
{
    public  class FlowStateMd : IdWithAliasEntity
    {
        public IDictionary<string, IFieldMd> Fields { get; set; }
    }
}
