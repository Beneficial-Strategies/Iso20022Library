// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason30Choice.Code))]
    [KnownType(typeof(RejectedReason30Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason30Choice.Code), nameof(RejectedReason30Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason30Choice.Proprietary),
        nameof(RejectedReason30Choice.Proprietary)
    )]
    [IsoId("_eKVR2cAUEembi_x1QDJfxw")]
    [DisplayName("Rejected Reason 30 Choice")]
    public abstract record RejectedReason30Choice_ { }
}
