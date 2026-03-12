// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason42Choice.Code))]
    [KnownType(typeof(RejectionReason42Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason42Choice.Code),nameof(RejectionReason42Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason42Choice.Proprietary),nameof(RejectionReason42Choice.Proprietary))]
    [IsoId("_PcLIUStWEeyhipY4f42fZQ")]
    [DisplayName("Rejection Reason 42 Choice")]
    public abstract partial record RejectionReason42Choice_
    {
    }
}
