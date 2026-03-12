// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement query unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason32Choice.Code))]
    [KnownType(typeof(UnmatchedReason32Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason32Choice.Code),nameof(UnmatchedReason32Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason32Choice.Proprietary),nameof(UnmatchedReason32Choice.Proprietary))]
    [IsoId("_g6DZKwd4Ee2fOITqoTnSLQ")]
    [DisplayName("Unmatched Reason 32 Choice")]
    public abstract partial record UnmatchedReason32Choice_
    {
    }
}
