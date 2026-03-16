// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason36Choice.Code))]
    [KnownType(typeof(RejectedReason36Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason36Choice.Code), nameof(RejectedReason36Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason36Choice.Proprietary),
        nameof(RejectedReason36Choice.Proprietary)
    )]
    [IsoId("_cp36c_NfEeqRfth943bvEA")]
    [DisplayName("Rejected Reason 36 Choice")]
    public abstract record RejectedReason36Choice_ { }
}
