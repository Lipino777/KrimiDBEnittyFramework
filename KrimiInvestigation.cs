using System;
using System.Collections.Generic;

namespace KrimiDBEnittyFramework;

public partial class KrimiInvestigation
{
    public int InvestigationId { get; set; }

    public int InvestigationSuspectId { get; set; }

    public int InvestigationLeadId { get; set; }

    public virtual KrimiLead InvestigationLead { get; set; } = null!;

    public virtual KrimiPerson InvestigationSuspect { get; set; } = null!;

    public virtual ICollection<KrimiCrime> KrimiCrimes { get; set; } = new List<KrimiCrime>();
}
