// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Reason60Choice.
    /// </summary>
    [KnownType(typeof(RejectedReason60Choice.Code))]
    [KnownType(typeof(RejectedReason60Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason60Choice.Code),nameof(RejectedReason60Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason60Choice.Proprietary),nameof(RejectedReason60Choice.Proprietary))]
    [IsoId("_BKNdGWwHEe6A47ZrJkn1kg")]
    [DisplayName("Rejected Reason60Choice")]
    public abstract partial record RejectedReason60Choice_
    {
    }
}
