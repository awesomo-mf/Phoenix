using Phoenix.Models.Metadata.FlowContext.Fields.Interfaces;
using Phoenix.Models.Metadata.Shared;

namespace Phoenix.Models.Metadata.FlowContext.Fields
{
    public abstract class FieldMdBase<T> : IdWithAliasEntity, IFieldMd
    {
        public T Value { get; set; }
        public object ValueAsObject => Value;
    }
}
