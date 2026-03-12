// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus47Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus47Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus47Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus47Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus47Choice.Reason),nameof(RejectionOrRepairStatus47Choice.Reason))]
    [IsoId("_ds1d7Ti8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Or Repair Status 47 Choice")]
    public abstract partial record RejectionOrRepairStatus47Choice_
    {
    }
}
