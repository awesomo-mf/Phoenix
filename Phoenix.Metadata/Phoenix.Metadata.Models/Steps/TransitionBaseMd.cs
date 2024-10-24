using Phoenix.Models.Metadata.Shared;

namespace Phoenix.Metadata.Models.Steps
{
    public abstract class TransitionBaseMd : AliasMd
    {
        public string StepAlias { get; set; }        
    }
}
