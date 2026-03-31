// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason14Choice.Code))]
    [KnownType(typeof(UnmatchedReason14Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason14Choice.Code), nameof(UnmatchedReason14Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason14Choice.Proprietary),
        nameof(UnmatchedReason14Choice.Proprietary)
    )]
    [IsoId("_Nrbv0SwZEeOEV5XHD-BKpw")]
    [DisplayName("Unmatched Reason 14 Choice")]
    public abstract record UnmatchedReason14Choice_ { }
}
