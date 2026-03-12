// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for a rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason20Choice.Code))]
    [KnownType(typeof(RejectedReason20Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason20Choice.Code),nameof(RejectedReason20Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason20Choice.Proprietary),nameof(RejectedReason20Choice.Proprietary))]
    [IsoId("_aD_roUHjEea8I67lh6qdSQ")]
    [DisplayName("Rejected Reason 20 Choice")]
    public abstract partial record RejectedReason20Choice_
    {
    }
}
