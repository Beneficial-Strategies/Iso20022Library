// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason9Choice.Code))]
    [KnownType(typeof(RejectedReason9Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason9Choice.Code),nameof(RejectedReason9Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason9Choice.Proprietary),nameof(RejectedReason9Choice.Proprietary))]
    [IsoId("_jd1is1hYEeSewsfsZR0hxA")]
    [DisplayName("Rejected Reason 9 Choice")]
    public abstract partial record RejectedReason9Choice_
    {
    }
}
