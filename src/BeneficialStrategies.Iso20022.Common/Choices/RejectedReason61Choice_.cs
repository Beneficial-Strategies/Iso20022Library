// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Reason61Choice.
    /// </summary>
    [KnownType(typeof(RejectedReason61Choice.Code))]
    [KnownType(typeof(RejectedReason61Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason61Choice.Code), nameof(RejectedReason61Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason61Choice.Proprietary),
        nameof(RejectedReason61Choice.Proprietary)
    )]
    [IsoId("_Uo2N5XSdEe6VWZz2tTgENw")]
    [DisplayName("Rejected Reason61Choice")]
    public abstract record RejectedReason61Choice_ { }
}
