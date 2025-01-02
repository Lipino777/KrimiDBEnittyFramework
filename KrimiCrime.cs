using System;
using System.Collections.Generic;

namespace KrimiDBEnittyFramework;

public partial class KrimiCrime
{
    public int CrimeId { get; set; }

    public string CrimeAlias { get; set; } = null!;

    public int CrimeVictimId { get; set; }

    public string? CrimeDescript { get; set; }

    public int CrimeInvestigId { get; set; }

    public virtual KrimiInvestigation CrimeInvestig { get; set; } = null!;

    public virtual KrimiPerson CrimeVictim { get; set; } = null!;
}
