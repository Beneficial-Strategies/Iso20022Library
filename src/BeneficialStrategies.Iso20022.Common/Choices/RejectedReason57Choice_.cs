// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Reason57Choice.
    /// </summary>
    [KnownType(typeof(RejectedReason57Choice.Code))]
    [KnownType(typeof(RejectedReason57Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason57Choice.Code),nameof(RejectedReason57Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason57Choice.Proprietary),nameof(RejectedReason57Choice.Proprietary))]
    [IsoId("_rLpbwX_VEe6NNIFrPQqloA")]
    [DisplayName("Rejected Reason57Choice")]
    public abstract partial record RejectedReason57Choice_
    {
    }
}
