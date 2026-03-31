// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [KnownType(typeof(UnmatchedReason30Choice.Code))]
    [KnownType(typeof(UnmatchedReason30Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason30Choice.Code), nameof(UnmatchedReason30Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason30Choice.Proprietary),
        nameof(UnmatchedReason30Choice.Proprietary)
    )]
    [IsoId("_4-yjYOCXEei2UYJ62ws-Fw")]
    [DisplayName("Unmatched Reason 30 Choice")]
    public abstract record UnmatchedReason30Choice_ { }
}
