// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus13Choice.Reason))]
    [JsonDerivedType(
        typeof(UnmatchedStatus13Choice.NoSpecifiedReason),
        nameof(UnmatchedStatus13Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(UnmatchedStatus13Choice.Reason),
        nameof(UnmatchedStatus13Choice.Reason)
    )]
    [IsoId("_NoI_sSwjEeOEV5XHD-BKpw")]
    [DisplayName("Unmatched Status 13 Choice")]
    public abstract record UnmatchedStatus13Choice_ { }
}
