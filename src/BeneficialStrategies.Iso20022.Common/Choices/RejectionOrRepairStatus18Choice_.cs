// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus18Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus18Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus18Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus18Choice.Reason),nameof(RejectionOrRepairStatus18Choice.Reason))]
    [IsoId("_4Yi_Qf7rEeCvPoRGOxRobQ")]
    [DisplayName("Rejection Or Repair Status 18 Choice")]
    public abstract partial record RejectionOrRepairStatus18Choice_
    {
    }
}
