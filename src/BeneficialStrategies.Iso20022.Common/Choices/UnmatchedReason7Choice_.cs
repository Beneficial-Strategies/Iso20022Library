// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement query unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason7Choice.Code))]
    [KnownType(typeof(UnmatchedReason7Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason7Choice.Code), nameof(UnmatchedReason7Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason7Choice.Proprietary),
        nameof(UnmatchedReason7Choice.Proprietary)
    )]
    [IsoId("_A4j1JtokEeC60axPepSq7g_1119416834")]
    [DisplayName("Unmatched Reason 7 Choice")]
    public abstract record UnmatchedReason7Choice_ { }
}
