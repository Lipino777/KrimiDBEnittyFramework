using System;
using System.Collections.Generic;

namespace KrimiDBEnittyFramework;

public partial class KrimiPerson
{
    public int PersonId { get; set; }

    public string PersonFirstName { get; set; } = null!;

    public string PersonLastName { get; set; } = null!;

    public byte[]? PersonFingerprint { get; set; }

    public int PersonCrimeCount { get; set; }

    public virtual ICollection<KrimiCrime> KrimiCrimes { get; set; } = new List<KrimiCrime>();

    public virtual ICollection<KrimiInvestigation> KrimiInvestigations { get; set; } = new List<KrimiInvestigation>();
}
