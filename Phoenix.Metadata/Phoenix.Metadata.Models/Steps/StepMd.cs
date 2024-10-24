using Phoenix.Models.Metadata.Shared;

namespace Phoenix.Metadata.Models.Steps
{
    public class StepMd : AliasMd
    {
        public string Description { get; set; }

        public string FormAlias { get; set; }

        public IDictionary<string, TransitionBaseMd> Transitions { get; set; }
    }
}
