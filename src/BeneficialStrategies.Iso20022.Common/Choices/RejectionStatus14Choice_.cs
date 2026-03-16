// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus14Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus14Choice.NoSpecifiedReason),
        nameof(RejectionStatus14Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus14Choice.Reason),
        nameof(RejectionStatus14Choice.Reason)
    )]
    [IsoId("_nUhn4SwvEeOEV5XHD-BKpw")]
    [DisplayName("Rejection Status 14 Choice")]
    public abstract record RejectionStatus14Choice_ { }
}
