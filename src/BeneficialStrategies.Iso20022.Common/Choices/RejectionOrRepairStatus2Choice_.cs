// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus2Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus2Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus2Choice.Reason),nameof(RejectionOrRepairStatus2Choice.Reason))]
    [IsoId("_UW1bZdp-Ed-ak6NoX_4Aeg_1986298919")]
    [DisplayName("Rejection Or Repair Status 2 Choice")]
    public abstract partial record RejectionOrRepairStatus2Choice_
    {
    }
}
