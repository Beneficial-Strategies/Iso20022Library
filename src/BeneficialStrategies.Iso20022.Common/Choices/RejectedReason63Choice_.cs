// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Reason63Choice.
    /// </summary>
    [KnownType(typeof(RejectedReason63Choice.Code))]
    [KnownType(typeof(RejectedReason63Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason63Choice.Code), nameof(RejectedReason63Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason63Choice.Proprietary),
        nameof(RejectedReason63Choice.Proprietary)
    )]
    [IsoId("_C18bMZzpEe-DHYbvdRjdbA")]
    [DisplayName("Rejected Reason63Choice")]
    public abstract record RejectedReason63Choice_ { }
}
