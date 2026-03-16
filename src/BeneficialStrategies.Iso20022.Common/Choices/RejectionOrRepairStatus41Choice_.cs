// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus41Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus41Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus41Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus41Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus41Choice.Reason),
        nameof(RejectionOrRepairStatus41Choice.Reason)
    )]
    [IsoId("_ZkDCOStUEeyhipY4f42fZQ")]
    [DisplayName("Rejection Or Repair Status 41 Choice")]
    public abstract record RejectionOrRepairStatus41Choice_ { }
}
