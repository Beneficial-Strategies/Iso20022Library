// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Accepted Reason15Choice.
    /// </summary>
    [KnownType(typeof(AcceptedReason15Choice.Code))]
    [KnownType(typeof(AcceptedReason15Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedReason15Choice.Code), nameof(AcceptedReason15Choice.Code))]
    [JsonDerivedType(
        typeof(AcceptedReason15Choice.Proprietary),
        nameof(AcceptedReason15Choice.Proprietary)
    )]
    [IsoId("_7U8u8ZzoEe-DHYbvdRjdbA")]
    [DisplayName("Accepted Reason15Choice")]
    public abstract record AcceptedReason15Choice_ { }
}
