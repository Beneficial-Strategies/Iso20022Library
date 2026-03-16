// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason58Choice.Code))]
    [KnownType(typeof(PendingReason58Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason58Choice.Code), nameof(PendingReason58Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason58Choice.Proprietary),
        nameof(PendingReason58Choice.Proprietary)
    )]
    [IsoId("_BwupsQpIEeup4r-PFG2T5Q")]
    [DisplayName("Pending Reason 58 Choice")]
    public abstract record PendingReason58Choice_ { }
}
