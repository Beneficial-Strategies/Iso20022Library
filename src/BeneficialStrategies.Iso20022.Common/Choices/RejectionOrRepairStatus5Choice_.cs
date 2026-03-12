// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus5Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus5Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus5Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus5Choice.Reason),nameof(RejectionOrRepairStatus5Choice.Reason))]
    [IsoId("_UUTEw9p-Ed-ak6NoX_4Aeg_-762584058")]
    [DisplayName("Rejection Or Repair Status 5 Choice")]
    public abstract partial record RejectionOrRepairStatus5Choice_
    {
    }
}
