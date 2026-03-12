// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [KnownType(typeof(RejectionReason39Choice.Code))]
    [KnownType(typeof(RejectionReason39Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason39Choice.Code),nameof(RejectionReason39Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason39Choice.Proprietary),nameof(RejectionReason39Choice.Proprietary))]
    [IsoId("_GQC2VRIwEeydmIVkS03esw")]
    [DisplayName("Rejection Reason 39 Choice")]
    public abstract partial record RejectionReason39Choice_
    {
    }
}
