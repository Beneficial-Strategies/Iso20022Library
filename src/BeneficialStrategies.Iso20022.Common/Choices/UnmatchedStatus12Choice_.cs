// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus12Choice.Reason))]
    [JsonDerivedType(
        typeof(UnmatchedStatus12Choice.NoSpecifiedReason),
        nameof(UnmatchedStatus12Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(UnmatchedStatus12Choice.Reason),
        nameof(UnmatchedStatus12Choice.Reason)
    )]
    [IsoId("_qg7OESwREeOEV5XHD-BKpw")]
    [DisplayName("Unmatched Status 12 Choice")]
    public abstract record UnmatchedStatus12Choice_ { }
}
