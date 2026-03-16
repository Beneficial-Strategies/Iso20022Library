// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason31Choice.Code))]
    [KnownType(typeof(UnmatchedReason31Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason31Choice.Code), nameof(UnmatchedReason31Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason31Choice.Proprietary),
        nameof(UnmatchedReason31Choice.Proprietary)
    )]
    [IsoId("_mfMbKRUIEeuZw7VHHgrHLg")]
    [DisplayName("Unmatched Reason 31 Choice")]
    public abstract record UnmatchedReason31Choice_ { }
}
