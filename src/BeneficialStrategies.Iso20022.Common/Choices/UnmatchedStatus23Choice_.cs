// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus23Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus23Choice.Reason))]
    [JsonDerivedType(
        typeof(UnmatchedStatus23Choice.NoSpecifiedReason),
        nameof(UnmatchedStatus23Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(UnmatchedStatus23Choice.Reason),
        nameof(UnmatchedStatus23Choice.Reason)
    )]
    [IsoId("_llnu0RUIEeuZw7VHHgrHLg")]
    [DisplayName("Unmatched Status 23 Choice")]
    public abstract record UnmatchedStatus23Choice_ { }
}
