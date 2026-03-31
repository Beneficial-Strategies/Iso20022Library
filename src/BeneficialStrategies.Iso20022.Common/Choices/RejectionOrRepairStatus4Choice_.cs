// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus4Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus4Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus4Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus4Choice.Reason),
        nameof(RejectionOrRepairStatus4Choice.Reason)
    )]
    [IsoId("_UUmmwtp-Ed-ak6NoX_4Aeg_2139855666")]
    [DisplayName("Rejection Or Repair Status 4 Choice")]
    public abstract record RejectionOrRepairStatus4Choice_ { }
}
