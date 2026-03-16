// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus36Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus36Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus36Choice.NoSpecifiedReason),
        nameof(RejectionStatus36Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus36Choice.Reason),
        nameof(RejectionStatus36Choice.Reason)
    )]
    [IsoId("_NAqksytVEeyhipY4f42fZQ")]
    [DisplayName("Rejection Status 36 Choice")]
    public abstract record RejectionStatus36Choice_ { }
}
