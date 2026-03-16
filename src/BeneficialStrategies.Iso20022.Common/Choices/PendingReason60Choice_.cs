// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason60Choice.Code))]
    [KnownType(typeof(PendingReason60Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason60Choice.Code), nameof(PendingReason60Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason60Choice.Proprietary),
        nameof(PendingReason60Choice.Proprietary)
    )]
    [IsoId("_qTHeYSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Pending Reason 60 Choice")]
    public abstract record PendingReason60Choice_ { }
}
