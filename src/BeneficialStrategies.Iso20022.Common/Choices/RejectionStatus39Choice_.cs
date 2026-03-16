// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus39Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus39Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus39Choice.NoSpecifiedReason),
        nameof(RejectionStatus39Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus39Choice.Reason),
        nameof(RejectionStatus39Choice.Reason)
    )]
    [IsoId("_hRtxIytXEeyhipY4f42fZQ")]
    [DisplayName("Rejection Status 39 Choice")]
    public abstract record RejectionStatus39Choice_ { }
}
