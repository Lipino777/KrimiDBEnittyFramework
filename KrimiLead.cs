using System;
using System.Collections.Generic;

namespace KrimiDBEnittyFramework;

public partial class KrimiLead
{
    public int LeadId { get; set; }

    public string LeadAddress { get; set; } = null!;

    public string? LeadDescription { get; set; }

    public virtual ICollection<KrimiInvestigation> KrimiInvestigations { get; set; } = new List<KrimiInvestigation>();
}
