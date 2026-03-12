// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus2Choice.Matched))]
    [KnownType(typeof(MatchingStatus2Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus2Choice.Matched),nameof(MatchingStatus2Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus2Choice.Unmatched),nameof(MatchingStatus2Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus2Choice.Proprietary),nameof(MatchingStatus2Choice.Proprietary))]
    [IsoId("_UaHY6Np-Ed-ak6NoX_4Aeg_-283039310")]
    [DisplayName("Matching Status 2 Choice")]
    public abstract partial record MatchingStatus2Choice_
    {
    }
}
