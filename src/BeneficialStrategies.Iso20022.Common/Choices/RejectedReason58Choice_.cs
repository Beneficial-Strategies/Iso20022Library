// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Reason58Choice.
    /// </summary>
    [KnownType(typeof(RejectedReason58Choice.Code))]
    [KnownType(typeof(RejectedReason58Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason58Choice.Code),nameof(RejectedReason58Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason58Choice.Proprietary),nameof(RejectedReason58Choice.Proprietary))]
    [IsoId("_JqYgqWwCEe6-uamPcUrBKg")]
    [DisplayName("Rejected Reason58Choice")]
    public abstract partial record RejectedReason58Choice_
    {
    }
}
