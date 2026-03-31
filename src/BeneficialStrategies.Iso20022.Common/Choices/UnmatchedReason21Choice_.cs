// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason21Choice.Code))]
    [KnownType(typeof(UnmatchedReason21Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason21Choice.Code), nameof(UnmatchedReason21Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason21Choice.Proprietary),
        nameof(UnmatchedReason21Choice.Proprietary)
    )]
    [IsoId("_ItrNiTqOEeWyoP0PbocV1Q")]
    [DisplayName("Unmatched Reason 21 Choice")]
    public abstract record UnmatchedReason21Choice_ { }
}
