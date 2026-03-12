// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason41Choice.Code))]
    [KnownType(typeof(RejectionReason41Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason41Choice.Code),nameof(RejectionReason41Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason41Choice.Proprietary),nameof(RejectionReason41Choice.Proprietary))]
    [IsoId("_NxY26StVEeyhipY4f42fZQ")]
    [DisplayName("Rejection Reason 41 Choice")]
    public abstract partial record RejectionReason41Choice_
    {
    }
}
