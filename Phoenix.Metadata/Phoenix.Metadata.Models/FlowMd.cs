using Phoenix.Metadata.Models.Forms;
using Phoenix.Metadata.Models.Steps;
using Phoenix.Models.Metadata.Shared;

namespace Phoenix.Metadata.Models
{
    public class FlowMd : IdWithAliasMd
    {
        public IDictionary<string, FormMd> Forms { get; set; }
        public IDictionary<string, StepMd> Steps{ get; set; }

        public FlowEntityMd FlowEntity { get; set; }
    }
}
