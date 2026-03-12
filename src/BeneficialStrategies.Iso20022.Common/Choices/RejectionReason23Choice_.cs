// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason23Choice.Code))]
    [KnownType(typeof(RejectionReason23Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason23Choice.Code),nameof(RejectionReason23Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason23Choice.Proprietary),nameof(RejectionReason23Choice.Proprietary))]
    [IsoId("_9UlZETqzEeWyoP0PbocV1Q")]
    [DisplayName("Rejection Reason 23 Choice")]
    public abstract partial record RejectionReason23Choice_
    {
    }
}
