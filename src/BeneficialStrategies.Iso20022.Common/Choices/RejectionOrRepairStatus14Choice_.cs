// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus14Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus14Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus14Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus14Choice.Reason),
        nameof(RejectionOrRepairStatus14Choice.Reason)
    )]
    [IsoId("_OJVuI_4vEeClUvPNHKL9Zw")]
    [DisplayName("Rejection Or Repair Status 14 Choice")]
    public abstract record RejectionOrRepairStatus14Choice_ { }
}
