// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus44Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus44Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus44Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus44Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus44Choice.Reason),
        nameof(RejectionOrRepairStatus44Choice.Reason)
    )]
    [IsoId("_SeYDKStYEeyhipY4f42fZQ")]
    [DisplayName("Rejection Or Repair Status 44 Choice")]
    public abstract record RejectionOrRepairStatus44Choice_ { }
}
