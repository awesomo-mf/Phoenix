using Phoenix.Models.Metadata.Shared;

namespace Phoenix.Metadata.Models.Forms.Fields
{
    public abstract class FieldBaseMd<TFieldType> : AliasMd
    {
        public string Title { get; set; }
        public string DataField { get; set; }

        public Type FieldType => typeof(TFieldType);
    }
}
