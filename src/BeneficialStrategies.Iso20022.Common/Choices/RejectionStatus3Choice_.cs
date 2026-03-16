// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus3Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus3Choice.NoSpecifiedReason),
        nameof(RejectionStatus3Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectionStatus3Choice.Reason), nameof(RejectionStatus3Choice.Reason))]
    [IsoId("_UVy5k9p-Ed-ak6NoX_4Aeg_-2005031459")]
    [DisplayName("Rejection Status 3 Choice")]
    public abstract record RejectionStatus3Choice_ { }
}
