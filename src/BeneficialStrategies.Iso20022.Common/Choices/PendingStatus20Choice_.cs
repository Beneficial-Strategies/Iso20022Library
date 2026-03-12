// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(PendingStatus20Choice.Forwarded))]
    [KnownType(typeof(PendingStatus20Choice.UnderInvestigation))]
    [JsonDerivedType(typeof(PendingStatus20Choice.Forwarded),nameof(PendingStatus20Choice.Forwarded))]
    [JsonDerivedType(typeof(PendingStatus20Choice.UnderInvestigation),nameof(PendingStatus20Choice.UnderInvestigation))]
    [IsoId("_0k3gwglIEeGATtfOBToyew_-1102038135")]
    [DisplayName("Pending Status 20 Choice")]
    public abstract partial record PendingStatus20Choice_
    {
    }
}
