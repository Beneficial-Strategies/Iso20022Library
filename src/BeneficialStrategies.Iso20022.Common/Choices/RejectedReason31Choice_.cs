// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason31Choice.Code))]
    [KnownType(typeof(RejectedReason31Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason31Choice.Code), nameof(RejectedReason31Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason31Choice.Proprietary),
        nameof(RejectedReason31Choice.Proprietary)
    )]
    [IsoId("_mMjl8-XyEemEj48jhmlA0Q")]
    [DisplayName("Rejected Reason 31 Choice")]
    public abstract record RejectedReason31Choice_ { }
}
