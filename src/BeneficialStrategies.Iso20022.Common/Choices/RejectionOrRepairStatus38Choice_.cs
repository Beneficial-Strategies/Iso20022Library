// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus38Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus38Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus38Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus38Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus38Choice.Reason),
        nameof(RejectionOrRepairStatus38Choice.Reason)
    )]
    [IsoId("_WXlDkeFUEeWIA4E9cYSxxQ")]
    [DisplayName("Rejection Or Repair Status 38 Choice")]
    public abstract record RejectionOrRepairStatus38Choice_ { }
}
